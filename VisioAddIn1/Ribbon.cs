using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace VisioAddIn1 {
	public partial class Ribbon {
		private void Ribbon1_Load(object sender, RibbonUIEventArgs e) {

		}

		private void showButton_Click(object sender, RibbonControlEventArgs e)
		{
			// Visio ウィンドウ
			int windowHandle = Globals.ThisAddIn.Application.WindowHandle32;
			var window = new Win32Window(windowHandle);

			// Visio ウィンドウをオーナーとしてフォームを表示する。
			var form = new MyForm();
			form.Show(window);
		}

		private void showDialogButton_Click(object sender, RibbonControlEventArgs e)
		{
			// Visio ウィンドウ
			int windowHandle = Globals.ThisAddIn.Application.WindowHandle32;
			var window = new Win32Window(windowHandle);

			// Visio ウィンドウをオーナーとしてフォームを表示する。
			var form = new MyForm();
			form.ShowDialog(window);
		}
	}
}
