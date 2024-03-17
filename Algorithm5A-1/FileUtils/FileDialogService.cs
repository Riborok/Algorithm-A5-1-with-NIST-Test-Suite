using System.Windows.Forms;

namespace Algorithm5A_1.FileUtils {
	public class FileDialogService {
		private readonly SaveFileDialog _saveDialog = new SaveFileDialog();
		private readonly OpenFileDialog _openDialog = new OpenFileDialog();

		public FileDialogService(string filter) {
			InstallSaveDialog(filter);
			InstallOpenDialog(filter);
		}

		private void InstallSaveDialog(string filter) {
			_saveDialog.Title = @"Create file";
			_saveDialog.Filter = filter;
			_saveDialog.FilterIndex = 1;
			_saveDialog.RestoreDirectory = true;
		}

		private void InstallOpenDialog(string filter) {
			_openDialog.Title = @"Open file";
			_openDialog.Filter = filter;
			_openDialog.FilterIndex = 1;
			_openDialog.RestoreDirectory = true;
		}

		public string? ShowSaveDialog() => _saveDialog.ShowDialog() == DialogResult.OK ? _saveDialog.FileName : null;

		public string? ShowOpenDialog() => _openDialog.ShowDialog() == DialogResult.OK ? _openDialog.FileName : null;

		public static DialogResult ShowWarningDialog(string message) {
			return MessageBox.Show(
				message,
				@"Warning",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Warning
			);
		}
	}
}