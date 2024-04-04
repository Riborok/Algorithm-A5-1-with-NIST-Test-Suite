using System.Drawing;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace TestingAlgorithmA5_1ByNIST.NIST {
	public class NISTControls {
		private readonly Color _defaultColor;
		public Control[] TestControls { get; }
		public Control[] RegisterControls { get; }
		public Control GeneratedTextControl { get; }
		
		public NISTControls(Control[] testControls, Control[] registerControls,
			Control generatedTextControl, Color defaultColor) {
			TestControls = testControls;
			RegisterControls = registerControls;
			GeneratedTextControl = generatedTextControl;
			_defaultColor = defaultColor;
			ClearAll();
		}

		public void ClearAll() {
			foreach (var control in TestControls)
				Clear(control);
			foreach (var control in RegisterControls)
				Clear(control);
		}

		private void Clear(Control control) {
			control.Text = "";
			control.BackColor = _defaultColor;
		}
	}
}
