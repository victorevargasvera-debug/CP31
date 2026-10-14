using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002E RID: 46
	public class CoreWebView2WebMessageReceivedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00008574 File Offset: 0x00006774
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000085D0 File Offset: 0x000067D0
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebMessageReceivedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebMessageReceivedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebMessageReceivedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebMessageReceivedEventArgsValue = value;
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000085DA File Offset: 0x000067DA
		internal CoreWebView2WebMessageReceivedEventArgs(object rawCoreWebView2WebMessageReceivedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebMessageReceivedEventArgs;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000085EC File Offset: 0x000067EC
		public string Source
		{
			get
			{
				string source;
				try
				{
					source = this._nativeICoreWebView2WebMessageReceivedEventArgs.Source;
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
				return source;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000866C File Offset: 0x0000686C
		public string WebMessageAsJson
		{
			get
			{
				string webMessageAsJson;
				try
				{
					webMessageAsJson = this._nativeICoreWebView2WebMessageReceivedEventArgs.WebMessageAsJson;
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
				return webMessageAsJson;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000086EC File Offset: 0x000068EC
		public string TryGetWebMessageAsString()
		{
			string result;
			try
			{
				result = this._nativeICoreWebView2WebMessageReceivedEventArgs.TryGetWebMessageAsString();
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

		// Token: 0x04000104 RID: 260
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebMessageReceivedEventArgs _nativeICoreWebView2WebMessageReceivedEventArgsValue;

		// Token: 0x04000105 RID: 261
		internal object _rawNative;
	}
}
