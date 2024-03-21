using System;
using System.IO;
using System.Windows.Forms;
using AlgorithmA5_1;
using App.FileUtils;
using App.Managers;
using BitUtils.Extensions;
using OfficeOpenXml;

namespace App {
    public partial class Encryptor : Form {
        private const string PlaintextFrequency = "Plaintext Frequency";
        private const string CiphertextFrequency = "Ciphertext Frequency";
        
        private readonly A5_1 _a51 = new A5_1();
        
        private readonly BufferManager _initTextBufferManager;
        private readonly BufferManager _ciphertextBufferManager;
        private readonly ExcelManager _initTextExcelManager;
        private readonly ExcelManager _ciphertextExcelManager;
        
        public Encryptor() {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            cbInitialization.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;

            var fileService = new BinaryFileService();
            (_initTextBufferManager, _ciphertextBufferManager) = CreateBufferManager(fileService);
            (_initTextExcelManager, _ciphertextExcelManager) = CreateExcelManagers(fileService);
        }
        
        private (BufferManager initTextBufferManager, BufferManager ciphertextBufferManager) CreateBufferManager(IFileService fileService) {
            const string filter = @"All files (*.*)|*.*";

            var initTextBufferManager = new BufferManager(
                CreateLambdaFunction(tbInitText, new ChartManager(chInitText, PlaintextFrequency)),
                new FileManager(tbInitTextFileName, fileService, filter)
            );
            var ciphertextBufferManager = new BufferManager(
                CreateLambdaFunction(tbCiphertext, new ChartManager(chCiphertext, CiphertextFrequency)),
                new FileManager(tbCiphertextFileName, fileService, filter)
            );
            
            return (initTextBufferManager, ciphertextBufferManager);
        }

        private (ExcelManager initTextExcelManager, ExcelManager ciphertextExcelManager) CreateExcelManagers(IFileService fileService) {
            const string filter = @"Excel files (*.xlsx)|*.xlsx";

            var initTextExcelManager = new ExcelManager(PlaintextFrequency, _initTextBufferManager,
                new FileManager(tbChartInitText, fileService, filter));
            var ciphertextExcelManager = new ExcelManager(CiphertextFrequency, _ciphertextBufferManager,
                new FileManager(tbChartCiphertext, fileService, filter));
            
            return (initTextExcelManager, ciphertextExcelManager);
        }
        
        private static Action<byte[]?> CreateLambdaFunction(Control textBox, ChartManager chartManager) {
            const int bytesInKilobyte = 1024;
            return buffer => {
                if (buffer == null) {
                    textBox.Text = string.Empty;
                    chartManager.ClearChart();
                    return;
                }
                textBox.Text = buffer.Length >= bytesInKilobyte * 5 
                    ? "The file is too big" : buffer.ToBinaryString();
                chartManager.PlotHistogram(buffer);
            };
        }

        private void chSaveInitText_Click(object sender, EventArgs e) {
            try {
                _initTextExcelManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void chSaveCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextExcelManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void chSaveAsInitText_Click(object sender, EventArgs e) {
            try {
                _initTextExcelManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void chSaveAsCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextExcelManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butNewInitText_Click(object sender, EventArgs e) {
            try {
                _initTextBufferManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butNewCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextBufferManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butOpenInitText_Click(object sender, EventArgs e) {
            try {
                _initTextBufferManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butOpenCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextBufferManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveInitText_Click(object sender, EventArgs e) {
            try {
                _initTextBufferManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextBufferManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butSaveAsInitText_Click(object sender, EventArgs e) {
            try {
                _initTextBufferManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butSaveAsCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextBufferManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butResetInitText_Click(object sender, EventArgs e) {
            _initTextBufferManager.Reset();
        }

        private void butResetCiphertext_Click(object sender, EventArgs e) {
            _ciphertextBufferManager.Reset();
        }

        private void butEncrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            if (_initTextBufferManager.Buffer == null || TryGetKey(out ulong key))
                return;

            _ciphertextBufferManager.Buffer = ApplyA51(key, _initTextBufferManager.Buffer);
        }

        private void butDecrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            if (_ciphertextBufferManager.Buffer == null || TryGetKey(out ulong key))
                return;

            _initTextBufferManager.Buffer = ApplyA51(key, _ciphertextBufferManager.Buffer);
        }

        private bool TryGetKey(out ulong key) {
            bool result = !ulong.TryParse(tbKey.Text, out key);
            if (result)
                tbErrors.Text = @"Invalid key format. Enter a valid 64-bit unsigned integer value.";
            return result;
        }

        private byte[] ApplyA51(ulong key, byte[] inputBuffer) {
            ResetA5_1(key);
            
            byte[] outputBuffer = new byte[inputBuffer.Length];
            byte[] a51Key = _a51.GenerateBytes(inputBuffer.Length);
            for (int i = 0; i < outputBuffer.Length; i++)
                outputBuffer[i] = (byte)(a51Key[i] ^ inputBuffer[i]);

            #if DEBUG
                File.WriteAllText("input.txt", inputBuffer.ToBinaryString());
                File.WriteAllText("output.txt", outputBuffer.ToBinaryString());
                File.WriteAllText("a5_1.txt", a51Key.ToBinaryString());
            #endif
            
            return outputBuffer;
        }
        
        private void ResetA5_1(ulong key) {
            if (cbInitialization.SelectedIndex == 0)
                _a51.InitV1(key);
            else if(cbInitialization.SelectedIndex == 1)
                _a51.InitV2(key);
        }
    }
}