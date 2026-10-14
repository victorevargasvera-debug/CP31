using System;

namespace CefSharp.Handler
{
	// Token: 0x0200010D RID: 269
	public class KeyboardHandler : global::CefSharp.IKeyboardHandler
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		bool global::CefSharp.IKeyboardHandler.OnPreKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
		{
			return this.OnPreKeyEvent(chromiumWebBrowser, browser, type, windowsKeyCode, nativeKeyCode, modifiers, isSystemKey, ref isKeyboardShortcut);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		protected virtual bool OnPreKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
		{
			return false;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000CAF7 File Offset: 0x0000ACF7
		bool global::CefSharp.IKeyboardHandler.OnKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey)
		{
			return this.OnKeyEvent(chromiumWebBrowser, browser, type, windowsKeyCode, nativeKeyCode, modifiers, isSystemKey);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000CB0A File Offset: 0x0000AD0A
		protected virtual bool OnKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey)
		{
			return false;
		}
	}
}
