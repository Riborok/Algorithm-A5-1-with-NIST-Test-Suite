using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AlgorithmA5_1;
using App.FileUtils;
using App.Managers;
using App.NIST;
using BitUtils;
using BitUtils.Extensions;
using OfficeOpenXml;
// ReSharper disable InconsistentNaming

namespace App {
    public partial class Encryptor : Form {
        private const string PlaintextFrequency = "Plaintext Frequency";
        private const string CiphertextFrequency = "Ciphertext Frequency";
        
        private readonly A5_1 _a51 = new A5_1();
        
        private readonly BufferManager _initTextBufferManager;
        private readonly BufferManager _ciphertextBufferManager;
        private readonly ExcelManager _initTextExcelManager;
        private readonly ExcelManager _ciphertextExcelManager;

        private readonly NISTControls _nistControls;
        
        private readonly NISTTestCalculator _testCalculator;
        private readonly NISTTestResultsDisplayer _resultsDisplayer = new NISTTestResultsDisplayer(
            "Error", 6, 
            Color.LightSalmon, Color.LightCoral, Color.LightGreen);
        
        public Encryptor() {
            InitializeComponent();
            AdditionalInitialization();

            _testCalculator = new NISTTestCalculator(tbErrors);
            var fileService = new BinaryFileService();
            _nistControls = CreateNistControls(Color.White);
            (_initTextBufferManager, _ciphertextBufferManager) = CreateBufferManager(fileService);
            (_initTextExcelManager, _ciphertextExcelManager) = CreateExcelManagers(fileService);
        }

        private void AdditionalInitialization() {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            cbInitialization.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private NISTControls CreateNistControls(Color color) {
            return new NISTControls(new Control[] { 
                tbFreqTest, tbBlockFreqTest, tbRunsTest, 
                tbLROTest, tbRankTest, tbDFTTest
            }, color);
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
                tbErrors.Text += exception.Message + Environment.NewLine;
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
                tbErrors.Text += @"Invalid key format. Enter a valid 64-bit unsigned integer value." + Environment.NewLine;
            return isValid;
        }

        private byte[] ApplyA51(ulong key, byte[] inputBuffer) {
            byte[] a51Key = GenerateAndDisplayA51Key(key, inputBuffer.Length);
            
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
        
        private byte[] GenerateAndDisplayA51Key(ulong key, int length) {
            ResetA5_1(key);
            byte[] a51Key = _a51.GenerateBytes(length);
            DisplayBits(a51Key, tbKeyA51);
            return a51Key;
        }

        private void ResetA5_1(ulong key) {
            if (cbInitialization.SelectedIndex == 0)
                _a51.InitV1(key);
            else if(cbInitialization.SelectedIndex == 1)
                _a51.InitV2(key);
        }

        private void butRunTests_Click(object sender, EventArgs e) => ProcessRunTests();

        private void ProcessRunTests() {
            tbErrors.Text = string.Empty;
            if (TryGetTestParams(out int blockSz, out int matrixM, out int matrixQ, out int length) && TryGetKey(out ulong key)) {
                byte[] a51Key = GenerateAndDisplayA51Key(key, MathUtils.CeilInt(length, Bits.InByte));
                RunTestsForBufferManager(a51Key, _nistControls.Controls, blockSz, matrixM, matrixQ, length);
            }
        }

        private bool TryGetTestParams(out int blockSz, out int matrixM, out int matrixQ, out int length) {
            bool isValid = true;
            isValid &= ValidateInput(tbBlockSz.Text, "Block Size", out blockSz);
            isValid &= ValidateInput(tbMatrixM.Text, "Matrix M", out matrixM);
            isValid &= ValidateInput(tbMatrixQ.Text, "Matrix Q", out matrixQ);
            isValid &= ValidateInput(tbKeyLength.Text, "Key Length", out length);
            return isValid;
        }
        
        private bool ValidateInput(string input, string fieldName, out int value) {
            if (!int.TryParse(input, out value)) {
                tbErrors.Text += $@"Invalid {fieldName} format. Enter a valid integer value.{Environment.NewLine}";
                return false;
            }
            return true;
        }
        
        private void RunTestsForBufferManager(byte[] buffer, IReadOnlyList<Control> controls, 
                                                int blockSz, int matrixM, int matrixQ, int length) {
            var testResults = _testCalculator.CalcTestResults(buffer, 
                length, blockSz, matrixM, matrixQ);
            _resultsDisplayer.DisplayResults(controls, testResults);
        }
    }
}