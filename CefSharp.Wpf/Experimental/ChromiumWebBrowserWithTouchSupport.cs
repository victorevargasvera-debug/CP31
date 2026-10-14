using System;
using System.Windows.Input;
using CefSharp.Enums;
using CefSharp.Structs;
using CefSharp.Wpf.Internals;

namespace CefSharp.Wpf.Experimental
{
	// Token: 0x0200001E RID: 30
	public class ChromiumWebBrowserWithTouchSupport : global::CefSharp.Wpf.ChromiumWebBrowser
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x00006C28 File Offset: 0x00004E28
		protected override void OnStylusDown(global::System.Windows.Input.StylusDownEventArgs e)
		{
			if (e.StylusDevice.TabletDevice.Type == global::System.Windows.Input.TabletDeviceType.Stylus)
			{
				base.Focus();
				base.CaptureStylus();
				this.OnStylus(e, global::CefSharp.Enums.TouchEventType.Pressed);
			}
			base.OnStylusDown(e);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00006C59 File Offset: 0x00004E59
		protected override void OnStylusMove(global::System.Windows.Input.StylusEventArgs e)
		{
			if (e.StylusDevice.TabletDevice.Type == global::System.Windows.Input.TabletDeviceType.Stylus)
			{
				this.OnStylus(e, global::CefSharp.Enums.TouchEventType.Moved);
			}
			base.OnStylusMove(e);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00006C7C File Offset: 0x00004E7C
		protected override void OnStylusUp(global::System.Windows.Input.StylusEventArgs e)
		{
			if (e.StylusDevice.TabletDevice.Type == global::System.Windows.Input.TabletDeviceType.Stylus)
			{
				base.ReleaseStylusCapture();
				this.OnStylus(e, global::CefSharp.Enums.TouchEventType.Released);
			}
			base.OnStylusUp(e);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006CA8 File Offset: 0x00004EA8
		private void OnStylus(global::System.Windows.Input.StylusEventArgs e, global::CefSharp.Enums.TouchEventType touchEventType)
		{
			global::CefSharp.IBrowser browser = base.GetBrowser();
			if (!e.Handled && browser != null)
			{
				global::CefSharp.CefEventFlags modifierKeys = global::CefSharp.Wpf.Internals.WpfExtensions.GetModifierKeys(global::CefSharp.CefEventFlags.None);
				global::CefSharp.Enums.PointerType pointerType = e.StylusDevice.Inverted ? global::CefSharp.Enums.PointerType.Eraser : global::CefSharp.Enums.PointerType.Pen;
				foreach (global::System.Windows.Input.StylusPoint stylusPoint in e.GetStylusPoints(this))
				{
					global::CefSharp.Structs.TouchEvent evt = new global::CefSharp.Structs.TouchEvent
					{
						Id = e.StylusDevice.Id,
						X = (float)stylusPoint.X,
						Y = (float)stylusPoint.Y,
						PointerType = pointerType,
						Pressure = stylusPoint.PressureFactor,
						Type = touchEventType,
						Modifiers = modifierKeys
					};
					browser.GetHost().SendTouchEvent(evt);
				}
				e.Handled = true;
			}
		}
	}
}
