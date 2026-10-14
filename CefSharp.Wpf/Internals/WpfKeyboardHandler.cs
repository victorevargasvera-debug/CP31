using System;
using System.Windows.Input;
using System.Windows.Interop;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x0200001A RID: 26
	public class WpfKeyboardHandler : global::CefSharp.Wpf.IWpfKeyboardHandler, global::System.IDisposable
	{
		// Token: 0x0600019B RID: 411 RVA: 0x000064DC File Offset: 0x000046DC
		public WpfKeyboardHandler(global::CefSharp.Wpf.ChromiumWebBrowser owner)
		{
			this.owner = owner;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000064EB File Offset: 0x000046EB
		public virtual void Setup(global::System.Windows.Interop.HwndSource source)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000064ED File Offset: 0x000046ED
		public virtual void Dispose()
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000064F0 File Offset: 0x000046F0
		public virtual void HandleKeyPress(global::System.Windows.Input.KeyEventArgs e)
		{
			global::CefSharp.IBrowser browserCore = this.owner.BrowserCore;
			global::System.Windows.Input.Key key = (e.SystemKey == global::System.Windows.Input.Key.None) ? e.Key : e.SystemKey;
			if (browserCore != null)
			{
				int wParam;
				switch (key)
				{
				case global::System.Windows.Input.Key.LeftShift:
				case global::System.Windows.Input.Key.RightShift:
					wParam = 16;
					break;
				case global::System.Windows.Input.Key.LeftCtrl:
				case global::System.Windows.Input.Key.RightCtrl:
					wParam = 17;
					break;
				case global::System.Windows.Input.Key.LeftAlt:
				case global::System.Windows.Input.Key.RightAlt:
					wParam = 18;
					break;
				default:
					wParam = global::System.Windows.Input.KeyInterop.VirtualKeyFromKey(key);
					break;
				}
				int message;
				if (e.IsDown)
				{
					message = ((e.SystemKey != global::System.Windows.Input.Key.None) ? 260 : 256);
				}
				else
				{
					message = ((e.SystemKey != global::System.Windows.Input.Key.None) ? 261 : 257);
				}
				browserCore.GetHost().SendKeyEvent(message, wParam, 0);
			}
			if (key == global::System.Windows.Input.Key.Tab || key == global::System.Windows.Input.Key.Home || key == global::System.Windows.Input.Key.End || key == global::System.Windows.Input.Key.Up || key == global::System.Windows.Input.Key.Down || key == global::System.Windows.Input.Key.Left || key == global::System.Windows.Input.Key.Right || (key == global::System.Windows.Input.Key.A && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control))
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000065D8 File Offset: 0x000047D8
		public virtual void HandleTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			global::CefSharp.IBrowser browserCore = this.owner.BrowserCore;
			if (browserCore != null)
			{
				global::CefSharp.IBrowserHost host = browserCore.GetHost();
				for (int i = 0; i < e.Text.Length; i++)
				{
					host.SendKeyEvent(258, (int)e.Text[i], 0);
				}
				e.Handled = true;
			}
		}

		// Token: 0x04000186 RID: 390
		protected readonly global::CefSharp.Wpf.ChromiumWebBrowser owner;
	}
}
