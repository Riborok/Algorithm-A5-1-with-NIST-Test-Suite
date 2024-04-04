using System.IO;
using System.Windows.Forms;

namespace Encryptor.FileUtils {
    internal class FileManager {
        private string _path = string.Empty;
        private readonly Control _fileNameControl;
        private readonly IFileService _fileService;
        private readonly string _filter;
        
        public FileManager(Control fileNameControl, IFileService fileService, string filter) {
            _fileNameControl = fileNameControl;
            _fileService = fileService;
            _filter = filter;
        }

        public void Reset() {
            _path = string.Empty;
            _fileNameControl.Text = string.Empty;
        }

        public void Create() {
            string? path = FileDialogService.ShowSaveDialog(_filter);
            if (path != null) {
                _fileService.CreateFile(path);
                UpdatePath(path);
            }
        }

        public byte[]? Open() {
            return TryOpenWithoutReading() ? _fileService.ReadFile(_path) : null;
        }
        
        private bool TryOpenWithoutReading() {
            string? path = FileDialogService.ShowOpenDialog(_filter);
            if (path != null)
                UpdatePath(path);
            return path != null;
        }

        public void SaveAs(byte[]? buffer) {
            string? path = FileDialogService.ShowSaveDialog(_filter);
            if (path != null) {
                if (buffer != null)
                    _fileService.SaveFile(path, buffer);
                UpdatePath(path);
            }
        }
        
        private void UpdatePath(string path) {
            _path = path;
            _fileNameControl.Text = Path.GetFileName(_path);
        }

        public void Save(byte[]? buffer) {
            if (_path == string.Empty)
                OfferToCreateOrOpenFile(); // can update _path
            else if (buffer == null)
                buffer = _fileService.ReadFile(_path);
            
            if (_path != string.Empty && buffer != null) 
                _fileService.SaveFile(_path, buffer);
        }
        
        private void OfferToCreateOrOpenFile() {
            DialogResult dialogResult = FileDialogService.ShowWarningDialog(@"Do you want to save an to existing file?");
            if (dialogResult == DialogResult.Yes)
                TryOpenWithoutReading();
            else if (dialogResult == DialogResult.No)
                Create();
        }
    }
}
