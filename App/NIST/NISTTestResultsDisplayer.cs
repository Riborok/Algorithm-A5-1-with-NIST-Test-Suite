// ReSharper disable InconsistentNaming
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NIST;

namespace App.NIST {
	internal class NISTTestResultsDisplayer {
		private readonly string _errorDefaultText;
		private readonly string _formatString;
		private readonly Color _colorError;
		private readonly Color _colorReject;
		private readonly Color _colorAccept;

		public NISTTestResultsDisplayer(string errorDefaultText, string formatString, 
			Color colorError, Color colorReject, Color colorAccept) {
			_errorDefaultText = errorDefaultText;
			_formatString = formatString;
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
			control.Text = value.ToString(_formatString);
			control.BackColor = value < NISTTest.SignificanceLevel ? _colorReject : _colorAccept;
		}
	}
}