using System;

namespace CefSharp
{
	// Token: 0x0200005E RID: 94
	public interface IKeyboardHandler
	{
		// Token: 0x06000158 RID: 344
		bool OnPreKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut);

		// Token: 0x06000159 RID: 345
		bool OnKeyEvent(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.KeyType type, int windowsKeyCode, int nativeKeyCode, global::CefSharp.CefEventFlags modifiers, bool isSystemKey);
	}
}
