using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002A RID: 42
	public class CoreWebView2WebResourceResponseReceivedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00007864 File Offset: 0x00005A64
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000078C0 File Offset: 0x00005AC0
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseReceivedEventArgsValue = value;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000078CA File Offset: 0x00005ACA
		internal CoreWebView2WebResourceResponseReceivedEventArgs(object rawCoreWebView2WebResourceResponseReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebResourceResponseReceivedEventArgs;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000078DC File Offset: 0x00005ADC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest Request
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest(this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Request));
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
				return result;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00007970 File Offset: 0x00005B70
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView Response
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView(this._nativeICoreWebView2WebResourceResponseReceivedEventArgs.Response));
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
				return result;
			}
		}

		// Token: 0x040000FC RID: 252
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseReceivedEventArgs _nativeICoreWebView2WebResourceResponseReceivedEventArgsValue;

		// Token: 0x040000FD RID: 253
		internal object _rawNative;
	}
}
