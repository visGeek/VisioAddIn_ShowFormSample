using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisioAddIn1 {
	internal class Win32Window : System.Windows.Forms.IWin32Window
	{
		public Win32Window(int windowHandle)
		{
			this.Handle = new IntPtr(windowHandle);
		}

		public IntPtr Handle { get; private set; }
	}
}
