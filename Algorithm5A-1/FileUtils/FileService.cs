using System.IO;

namespace Algorithm5A_1.FileUtils {
	public interface IFileService {
		void CreateFile(string path);
		byte[] ReadFile(string path);
		void SaveFile(string path, byte[] content);
	}

	public class BinaryFileService : IFileService {
		public void CreateFile(string path) {
			try {
				File.Create(path).Dispose();
			} catch {
				throw new IOException("The file could not be created!");
			}
		}

		public byte[] ReadFile(string path) {
			try {
				return File.ReadAllBytes(path);
			} catch {
				throw new IOException("The file could not be read!");
			}
		}

		public void SaveFile(string path, byte[] content) {
			try {
				File.WriteAllBytes(path, content);
			} catch {
				throw new IOException("The file could not be saved!");
			}
		}
	}
}