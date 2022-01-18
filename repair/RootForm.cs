using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Repair {
	public partial class RootForm : Form {
		public RootForm() {
			InitializeComponent();
		}

		private void OpenTemplate(object sender, EventArgs e) {
			Console.WriteLine("OK");
		}

	}
}