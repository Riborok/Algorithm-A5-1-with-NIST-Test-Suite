using System;
using Encryptor.FileUtils;

namespace Encryptor.Managers {
	internal class BufferManager {
		private readonly Action<byte[]?> _updateText;
		private readonly FileManager _fileManager;
		private byte[]? _buffer;
		
		public BufferManager(Action<byte[]?> updateText, FileManager fileManager) {
			_updateText = updateText;
			_fileManager = fileManager;
		}

		public void Reset() {
			_fileManager.Reset();
			_buffer = null;
			_updateText(_buffer);
		}
		
		public void Create() {
			_fileManager.Create();
		}
		
		public void Open() {
			var opened = _fileManager.Open();
			if (opened != null) {
				_buffer = opened;
				_updateText(_buffer);
			}
		}
		
		public void SaveAs() {
			_fileManager.SaveAs(_buffer);
		}
		
		public void Save() {
			_fileManager.Save(_buffer);
		}

		public byte[]? Buffer {
			get => _buffer;
			set {
				_buffer = value;
				_updateText(_buffer);
			}
		} 
	}
}
