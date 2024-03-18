using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Algorithm5A_1.Extensions;
// ReSharper disable InconsistentNaming

namespace Algorithm5A_1.FileUtils {
    public class FileManager {
        private string _path = string.Empty;
        private readonly Control _fileName;
        private readonly Control _tbText;
        private readonly IFileService _fileService;
        private readonly FileDialogService _dialogService;
        private byte[]? _buffer;
        
        public FileManager(Control fileName, Control tbText, IFileService fileService, string filter) {
            _fileName = fileName;
            _tbText = tbText;
            _fileService = fileService;
            _dialogService = new FileDialogService(filter);
        }

        public void Reset() {
            _path = string.Empty;
            _fileName.Text = string.Empty;
            _tbText.Text = string.Empty;
            _buffer = null;
        }

        public void Create() {
            string? path = _dialogService.ShowSaveDialog();
            if (path != null) {
                _fileService.CreateFile(path);
                UpdatePath(path);
            }
        }

        public void Open() {
            string? path = _dialogService.ShowOpenDialog();
            if (path != null) {
                _buffer = _fileService.ReadFile(path);
                UpdateTbText();
                UpdatePath(path);
            }
        }
        
        private void UpdateTbText() => _tbText.Text = _buffer!.ConvertToBinaryString();
        
        public void SaveAs() {
            string? path = _dialogService.ShowSaveDialog();
            if (path != null) {
                if (_buffer != null)
                    _fileService.SaveFile(path, _buffer);
                UpdatePath(path);
            }
        }
        
        private void UpdatePath(string path) {
            _path = path;
            _fileName.Text = Path.GetFileName(_path);
        }

        public void Save() {
            if (_path == string.Empty)
                OfferToCreateOrOpenFile();
            else if (_buffer == null)
                _buffer = _fileService.ReadFile(_path);
            
            if (_path != string.Empty && _buffer != null) 
                _fileService.SaveFile(_path, _buffer);
        }
        
        private void OfferToCreateOrOpenFile() {
            DialogResult dialogResult = FileDialogService.ShowWarningDialog(
                @"Do you want to create a file?"
            );
            if (dialogResult == DialogResult.Yes)
                Create();
            else if (dialogResult == DialogResult.No)
                Open();
        }

        public IReadOnlyList<byte>? BufferRO => _buffer;
        
        public byte[]? Buffer {
            set {
                _buffer = value;
                UpdateTbText();
            }
        } 
    }
}