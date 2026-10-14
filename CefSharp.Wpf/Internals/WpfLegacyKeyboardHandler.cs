using System;
using System.Windows.Input;
using System.Windows.Interop;
using CefSharp.Internals;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x0200001B RID: 27
	public class WpfLegacyKeyboardHandler : global::CefSharp.Wpf.IWpfKeyboardHandler, global::System.IDisposable
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00006630 File Offset: 0x00004830
		public WpfLegacyKeyboardHandler(global::CefSharp.Wpf.ChromiumWebBrowser owner)
		{
			this.owner = owner;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000663F File Offset: 0x0000483F
		public virtual void Setup(global::System.Windows.Interop.HwndSource source)
		{
			this.source = source;
			if (source != null)
			{
				this.sourceHook = new global::System.Windows.Interop.HwndSourceHook(this.SourceHook);
				source.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.SourceHook));
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00006671 File Offset: 0x00004871
		public virtual void Dispose()
		{
			if (this.source != null && this.sourceHook != null)
			{
				this.source.RemoveHook(this.sourceHook);
			}
			this.source = null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000669C File Offset: 0x0000489C
		protected virtual global::System.IntPtr SourceHook(global::System.IntPtr hWnd, int message, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (handled)
			{
				return global::System.IntPtr.Zero;
			}
			if ((message - 256 <= 2 || message - 260 <= 2 || message == 646) && this.owner.IsKeyboardFocused)
			{
				if (message == 260 && wParam.ToInt32() == global::System.Windows.Input.KeyInterop.VirtualKeyFromKey(global::System.Windows.Input.Key.F4))
				{
					return global::System.IntPtr.Zero;
				}
				global::CefSharp.IBrowser browserCore = this.owner.BrowserCore;
				if (browserCore != null)
				{
					browserCore.GetHost().SendKeyEvent(message, wParam.CastToInt32(), lParam.CastToInt32());
					handled = true;
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00006730 File Offset: 0x00004930
		public virtual void HandleKeyPress(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Tab || e.Key == global::System.Windows.Input.Key.Home || e.Key == global::System.Windows.Input.Key.End || e.Key == global::System.Windows.Input.Key.Up || e.Key == global::System.Windows.Input.Key.Down || e.Key == global::System.Windows.Input.Key.Left || e.Key == global::System.Windows.Input.Key.Right || (e.Key == global::System.Windows.Input.Key.A && global::System.Windows.Input.Keyboard.Modifiers == global::System.Windows.Input.ModifierKeys.Control))
			{
				global::CefSharp.CefEventFlags modifiers = e.GetModifiers();
				int message = e.IsDown ? 256 : 257;
				int wParam = global::System.Windows.Input.KeyInterop.VirtualKeyFromKey(e.Key);
				global::CefSharp.IBrowser browserCore = this.owner.BrowserCore;
				if (browserCore != null)
				{
					browserCore.GetHost().SendKeyEvent(message, wParam, (int)modifiers);
					e.Handled = true;
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000067E0 File Offset: 0x000049E0
		public virtual void HandleTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
		}

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Interop.HwndSourceHook sourceHook;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Interop.HwndSource source;

		// Token: 0x04000189 RID: 393
		private readonly global::CefSharp.Wpf.ChromiumWebBrowser owner;
	}
}
