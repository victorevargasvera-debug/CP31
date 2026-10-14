using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003C RID: 60
	public class CoreWebView2DOMContentLoadedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0000D548 File Offset: 0x0000B748
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventArgs _nativeICoreWebView2DOMContentLoadedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2DOMContentLoadedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DOMContentLoadedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DOMContentLoadedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2DOMContentLoadedEventArgsValue = value;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000D552 File Offset: 0x0000B752
		internal CoreWebView2DOMContentLoadedEventArgs(object rawCoreWebView2DOMContentLoadedEventArgs)
		{
			this._rawNative = rawCoreWebView2DOMContentLoadedEventArgs;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000D564 File Offset: 0x0000B764
		public ulong NavigationId
		{
			get
			{
				ulong navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2DOMContentLoadedEventArgs.NavigationId;
				}
				catch (global::System.InvalidCastException ex)
				{
					bool flag = ex.HResult == -2147467262;
					if (flag)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
					}
					throw ex;
				}
				catch (global::System.Runtime.InteropServices.COMException ex2)
				{
					bool flag2 = ex2.HResult == -2147019873;
					if (flag2)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
					}
					throw ex2;
				}
				return navigationId;
			}
		}

		// Token: 0x04000125 RID: 293
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DOMContentLoadedEventArgs _nativeICoreWebView2DOMContentLoadedEventArgsValue;

		// Token: 0x04000126 RID: 294
		internal object _rawNative;
	}
}
