using System.Drawing;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace App.NIST {
	public class NISTControls {
		private readonly Color _colorDefault;
		public Control[] Controls { get; }
		
		public NISTControls(Control[] controls, Color colorDefault) {
			Controls = controls;
			_colorDefault = colorDefault;
			Clear();
		}

		public void Clear() {
			foreach (var control in Controls) {
				control.Text = "";
				control.BackColor = _colorDefault;
			}
		}
	}
}