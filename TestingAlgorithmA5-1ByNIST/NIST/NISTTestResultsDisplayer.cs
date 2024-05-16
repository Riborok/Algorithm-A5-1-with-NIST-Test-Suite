// ReSharper disable InconsistentNaming
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AlgorithmA5_1;
using BitUtils;
using BitUtils.Extensions;
using NIST;

namespace TestingAlgorithmA5_1ByNIST.NIST {
	internal class NISTTestResultsDisplayer {
		private const string OutputFolderPath = "Generated Sequence";
		
		private readonly string _errorDefaultText;
		private readonly int _accuracy;
		private readonly Color _colorError;
		private readonly Color _colorReject;
		private readonly Color _colorAccept;

		public NISTTestResultsDisplayer(string errorDefaultText, int accuracy, 
			Color colorError, Color colorReject, Color colorAccept) {
			_errorDefaultText = errorDefaultText;
			_accuracy = accuracy;
			_colorError = colorError;
			_colorReject = colorReject;
			_colorAccept = colorAccept;
		}
		
		public static void CreateOutputFolderIfNotExists() {
			if (!Directory.Exists(OutputFolderPath))
				Directory.CreateDirectory(OutputFolderPath);
		}
		
		public static void DisplayA51Registers(A5_1 a51, NISTControls nistControls) {
			var registerControls = nistControls.RegisterControls;
			
			nistControls.GeneratedTextControl.BeginInvoke((MethodInvoker)delegate {
				registerControls[0].Text = a51.Lfsr1.ToString();
				registerControls[1].Text = a51.Lfsr2.ToString();
				registerControls[2].Text = a51.Lfsr3.ToString();
			});
		}
		
		public static void DisplayAndSaveGeneratedKey(byte[] buffer, int length, NISTControls nistControls) {
			var bytes = buffer.ToBinaryString(length);
			DisplayGeneratedKey(bytes, nistControls);
			SaveGeneratedKey(bytes, nistControls.Name);
		}
		
		private static void DisplayGeneratedKey(string bits, NISTControls nistControls) {
			nistControls.GeneratedTextControl.BeginInvoke((MethodInvoker)delegate {
				nistControls.GeneratedTextControl.Text = bits.Length >= Bits.InKilobyte * 5 
					? "The bit sequence is too big"
					: bits;
			});
		}
		
		private static void SaveGeneratedKey(string bits, string fileName) {
			var fullFilePath = Path.Combine(OutputFolderPath, fileName + ".txt");
			File.WriteAllText(fullFilePath, bits);
		}

		public void DisplayResults(IReadOnlyList<Control> controls, IReadOnlyList<double?> testResult) {
			for (int i = 0; i < controls.Count; i++)
				DisplayResult(controls[i], testResult[i]);
		}
		
		private void DisplayResult(Control control, double? result) {
			if (result == null) {
				control.BeginInvoke((MethodInvoker)delegate {
					control.Text = _errorDefaultText;
					control.BackColor = _colorError;
				});
				return;
			}
			
			double value = result.Value;
			string format = value >= Math.Pow(10, -_accuracy) ? $"F{_accuracy}" : $"E{Math.Max(1, _accuracy - 5)}";
			control.BeginInvoke((MethodInvoker)delegate {
				control.Text = value.ToString(format);
				control.BackColor = value < NISTTest.SignificanceLevel ? _colorReject : _colorAccept;
			});
		}
	}
}
