// ReSharper disable InconsistentNaming
using System.Drawing;
using System.Windows.Forms;

namespace TestingAlgorithmA5_1ByNIST.NIST {
	public class NISTControls {
		private readonly Color _defaultColor;
		public Control[] TestControls { get; }
		public Control[] RegisterControls { get; }
		public Control GeneratedTextControl { get; }
		public string Name { get; }
		
		public NISTControls(Control[] testControls, Control[] registerControls,
			Control generatedTextControl, Color defaultColor, string name) {
			TestControls = testControls;
			RegisterControls = registerControls;
			GeneratedTextControl = generatedTextControl;
			Name = name;
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
