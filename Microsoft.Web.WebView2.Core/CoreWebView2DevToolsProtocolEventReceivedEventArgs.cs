using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003E RID: 62
	public class CoreWebView2DevToolsProtocolEventReceivedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000D838 File Offset: 0x0000BA38
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue = value;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000D842 File Offset: 0x0000BA42
		internal CoreWebView2DevToolsProtocolEventReceivedEventArgs(object rawCoreWebView2DevToolsProtocolEventReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2DevToolsProtocolEventReceivedEventArgs;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000D854 File Offset: 0x0000BA54
		public string ParameterObjectAsJson
		{
			get
			{
				string parameterObjectAsJson;
				try
				{
					parameterObjectAsJson = this._nativeICoreWebView2DevToolsProtocolEventReceivedEventArgs.ParameterObjectAsJson;
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
				return parameterObjectAsJson;
			}
		}

		// Token: 0x0400012B RID: 299
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceivedEventArgs _nativeICoreWebView2DevToolsProtocolEventReceivedEventArgsValue;

		// Token: 0x0400012C RID: 300
		internal object _rawNative;
	}
}
