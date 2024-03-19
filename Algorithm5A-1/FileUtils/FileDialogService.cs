using System.Windows.Forms;

namespace Algorithm5A_1.FileUtils {
	public static class FileDialogService {
		private static readonly SaveFileDialog SaveDialog = new SaveFileDialog();
		private static readonly OpenFileDialog OpenDialog = new OpenFileDialog();

		static FileDialogService() {
			InstallSaveDialog();
			InstallOpenDialog();
		}

		private static void InstallSaveDialog() {
			SaveDialog.Title = @"Create file";
			SaveDialog.FilterIndex = 1;
			SaveDialog.RestoreDirectory = true;
		}

		private static void InstallOpenDialog() {
			OpenDialog.Title = @"Open file";
			OpenDialog.FilterIndex = 1;
			OpenDialog.RestoreDirectory = true;
		}

		public static string? ShowSaveDialog(string filter) {
			SaveDialog.Filter = filter;
			return SaveDialog.ShowDialog() == DialogResult.OK ? SaveDialog.FileName : null;
		}

		public static string? ShowOpenDialog(string filter) {
			SaveDialog.Filter = filter;
			return OpenDialog.ShowDialog() == DialogResult.OK ? OpenDialog.FileName : null;	
		} 

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