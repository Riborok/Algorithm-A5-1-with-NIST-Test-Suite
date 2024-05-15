using System;
using System.IO;
using System.Windows.Forms;
using AlgorithmA5_1;
using Encryptor.FileUtils;
using Encryptor.Managers;
using BitUtils.Extensions;
using OfficeOpenXml;
// ReSharper disable InconsistentNaming

namespace Encryptor {
    public partial class MainForm : Form {
        private const string PlaintextFrequency = "Plaintext Frequency";
        private const string CiphertextFrequency = "Ciphertext Frequency";
        
        private readonly A5_1 _a51 = new A5_1();
        
        private readonly BufferManager _initTextBufferManager;
        private readonly BufferManager _ciphertextBufferManager;
        private readonly ExcelManager _initTextExcelManager;
        private readonly ExcelManager _ciphertextExcelManager;

        public MainForm() {
            InitializeComponent();
            AdditionalInitialization();
            StartPosition = FormStartPosition.CenterScreen;
            
            var fileService = new BinaryFileService();
            (_initTextBufferManager, _ciphertextBufferManager) = CreateBufferManager(fileService);
            (_initTextExcelManager, _ciphertextExcelManager) = CreateExcelManagers(fileService);
        }

        private void AdditionalInitialization() {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            cbInitialization.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;
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
            return buffer => {
                if (buffer == null) {
                    textBox.Text = string.Empty;
                    chartManager.ClearChart();
                    return;
                }
                DisplayBits(buffer, textBox);
                chartManager.PlotHistogram(buffer);
            };
        }

        private static void DisplayBits(byte[] buffer, Control output) {
            const int bytesInKilobyte = 1024;
            output.Text = buffer.Length >= bytesInKilobyte * 5 ? "The bit sequence is too big" : buffer.ToBinaryString();
        }

        private void chSaveInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextExcelManager.Save);
        }

        private void chSaveCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextExcelManager.Save);
        }

        private void chSaveAsInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextExcelManager.SaveAs);
        }

        private void chSaveAsCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextExcelManager.SaveAs);
        }
        
        private void butNewInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextBufferManager.Create);
        }

        private void butNewCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextBufferManager.Create);
        }

        private void butOpenInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextBufferManager.Open);
        }
        
        private void butOpenCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextBufferManager.Open);
        }

        private void butSaveInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextBufferManager.Save);
        }

        private void butSaveCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextBufferManager.Save);
        }
        
        private void butSaveAsInitText_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_initTextBufferManager.SaveAs);
        }
        
        private void butSaveAsCiphertext_Click(object sender, EventArgs e) {
            HandleFileManagerAction(_ciphertextBufferManager.SaveAs);
        }

        private void HandleFileManagerAction(Action action) {
            tbErrors.Text = string.Empty;
            try {
                action();
            }
            catch (IOException exception) {
                tbErrors.Text += exception.Message + Environment.NewLine + Environment.NewLine;
            }
        }
        
        private void butResetInitText_Click(object sender, EventArgs e) {
            ResetBuffer(_initTextBufferManager);
        }

        private void butResetCiphertext_Click(object sender, EventArgs e) {
            ResetBuffer(_ciphertextBufferManager);
        }

        private void ResetBuffer(BufferManager bufferManager) {
            tbErrors.Text = string.Empty;
            bufferManager.Reset();
        }

        private void butEncrypt_Click(object sender, EventArgs e) {
            ProcessEnDecryptClick(_initTextBufferManager, _ciphertextBufferManager);
        }

        private void butDecrypt_Click(object sender, EventArgs e) {
            ProcessEnDecryptClick(_ciphertextBufferManager, _initTextBufferManager);
        }

        private void ProcessEnDecryptClick(BufferManager inputBufferManager, BufferManager outputBufferManager) {
            tbErrors.Text = string.Empty;
            if (inputBufferManager.Buffer == null || !TryGetKey(out ulong key))
                return;

            outputBufferManager.Buffer = ApplyA51(key, inputBufferManager.Buffer);
        }

        private bool TryGetKey(out ulong key) {
            bool isValid = ulong.TryParse(tbKey.Text, out key);
            if (!isValid)
                tbErrors.Text += $@"Invalid key format. Enter a valid 64-bit unsigned integer value.{Environment.NewLine}{Environment.NewLine}";
            return isValid;
        }

        private byte[] ApplyA51(ulong key, byte[] inputBuffer) {
            ResetA5_1(key);
            byte[] a51Key = _a51.GenerateBytes(inputBuffer.Length);
            DisplayBits(a51Key, tbKeyA51);
            
            byte[] outputBuffer = new byte[inputBuffer.Length];
            for (int i = 0; i < outputBuffer.Length; i++)
                outputBuffer[i] = (byte)(a51Key[i] ^ inputBuffer[i]);

            #if DEBUG
            DebugWriteFiles(inputBuffer, outputBuffer, a51Key);
            #endif
            
            return outputBuffer;
        }
        
        private static void DebugWriteFiles(byte[] inputBuffer, byte[] outputBuffer, byte[] a51Key) {
            const string folderPath = "DebugFiles";

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);  

            File.WriteAllText(Path.Combine(folderPath, "input.txt"), inputBuffer.ToBinaryString());
            File.WriteAllText(Path.Combine(folderPath, "output.txt"), outputBuffer.ToBinaryString());
            File.WriteAllText(Path.Combine(folderPath, "a5_1.txt"), a51Key.ToBinaryString());
        }

        private void ResetA5_1(ulong key) {
            if (cbInitialization.SelectedIndex == 0)
                _a51.InitV1(key);
            else if(cbInitialization.SelectedIndex == 1)
                _a51.InitV2(key);
        }
    }
}
