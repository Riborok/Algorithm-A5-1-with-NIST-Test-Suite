// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NIST;

namespace App.NIST {
	internal class NISTTestResultsDisplayer {
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

		public void DisplayResults(IReadOnlyList<Control> controls, IReadOnlyList<double?> testResult) {
			for (int i = 0; i < controls.Count; i++)
				DisplayResult(controls[i], testResult[i]);
		}
		
		private void DisplayResult(Control control, double? result) {
			if (result == null) {
				control.Text = _errorDefaultText;
				control.BackColor = _colorError;
				return;
			}
			
			double value = result.Value;
			string format = value >= Math.Pow(10, -_accuracy) ? $"F{_accuracy}" : $"E{Math.Max(1, _accuracy - 5)}";
			control.Text = value.ToString(format);
			control.BackColor = value < NISTTest.SignificanceLevel ? _colorReject : _colorAccept;
		}
	}
}