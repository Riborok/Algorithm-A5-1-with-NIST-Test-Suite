using System.IO;

namespace Encryptor.FileUtils {
	internal interface IFileService {
		void CreateFile(string path);
		byte[] ReadFile(string path);
		void SaveFile(string path, byte[] content);
	}

	internal class BinaryFileService : IFileService {
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
