using System;
using System.Windows.Input;
using System.Windows.Interop;

namespace CefSharp.Wpf
{
	// Token: 0x02000006 RID: 6
	public interface IWpfKeyboardHandler : global::System.IDisposable
	{
		// Token: 0x0600011F RID: 287
		void Setup(global::System.Windows.Interop.HwndSource source);

		// Token: 0x06000120 RID: 288
		void HandleKeyPress(global::System.Windows.Input.KeyEventArgs e);

		// Token: 0x06000121 RID: 289
		void HandleTextInput(global::System.Windows.Input.TextCompositionEventArgs e);
	}
}
