using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm5A_1.Algorithm_A5_1;
using Algorithm5A_1.FileUtils;

namespace Algorithm5A_1
{
    public partial class Encryptor : Form {
        private readonly A5_1 _a51 = new A5_1();
        private readonly FileManager _textFileManager;
        private readonly FileManager _ciphertextFileManager;
        
        public Encryptor()
        {
            InitializeComponent();
            cbInitialization.SelectedIndex = 0;
            StartPosition = FormStartPosition.CenterScreen;
            
            const string filter = @"All files (*.*)|*.*";
            var fileService = new BinaryFileService();
            _textFileManager = new FileManager(tbInitTextFileName, tbInitText, fileService, filter);
            _ciphertextFileManager = new FileManager(tbCiphertextFileName, tbCiphertext, fileService, filter);
        }

        private void butNewInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butNewCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Create();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butOpenInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butOpenCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Open();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butSaveCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.Save();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butSaveAsInitText_Click(object sender, EventArgs e) {
            try {
                _textFileManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }
        
        private void butSaveAsCiphertext_Click(object sender, EventArgs e) {
            try {
                _ciphertextFileManager.SaveAs();
            } catch (IOException exception) {
                tbErrors.Text = exception.Message;
            }
        }

        private void butEncrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            if (_textFileManager.BufferRO == null || TryGetKey(out ulong key))
                return;

            _ciphertextFileManager.Buffer = ApplyA51(key, _textFileManager.BufferRO);
        }

        private void butDecrypt_Click(object sender, EventArgs e) {
            tbErrors.Text = string.Empty;
            if (_ciphertextFileManager.BufferRO == null || TryGetKey(out ulong key))
                return;

            _textFileManager.Buffer = ApplyA51(key, _ciphertextFileManager.BufferRO);
        }

        private bool TryGetKey(out ulong key) {
            bool result = !ulong.TryParse(tbKey.Text, out key);
            if (result)
                tbErrors.Text = @"Invalid key format. Enter a valid 64-bit unsigned integer value.";
            return result;
        }

        private byte[] ApplyA51(ulong key, IReadOnlyList<byte> inputBuffer)
        {
            ResetA5_1(key);
            var outputBuffer = new byte[inputBuffer.Count];
            for (int i = 0; i < outputBuffer.Length; i++)
                outputBuffer[i] = (byte)(_a51.GenerateByte() ^ inputBuffer[i]);

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