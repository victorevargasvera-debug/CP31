using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002B RID: 43
	public class CoreWebView2WebResourceResponse
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00007A04 File Offset: 0x00005C04
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00007A60 File Offset: 0x00005C60
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse _nativeICoreWebView2WebResourceResponse
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebResourceResponseValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseValue = value;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00007A6A File Offset: 0x00005C6A
		internal CoreWebView2WebResourceResponse(object rawCoreWebView2WebResourceResponse)
		{
			this._rawNative = rawCoreWebView2WebResourceResponse;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00007A7C File Offset: 0x00005C7C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00007B10 File Offset: 0x00005D10
		public global::System.IO.Stream Content
		{
			get
			{
				global::System.IO.Stream result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceResponse.Content == null) ? null : new global::Microsoft.Web.WebView2.Core.COMStreamWrapper(this._nativeICoreWebView2WebResourceResponse.Content));
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
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.Content = new global::Microsoft.Web.WebView2.Core.ManagedIStream(value);
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
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00007B94 File Offset: 0x00005D94
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders Headers
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceResponse.Headers == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders(this._nativeICoreWebView2WebResourceResponse.Headers));
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00007C28 File Offset: 0x00005E28
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public int StatusCode
		{
			get
			{
				int statusCode;
				try
				{
					statusCode = this._nativeICoreWebView2WebResourceResponse.StatusCode;
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
				return statusCode;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.StatusCode = value;
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
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00007D28 File Offset: 0x00005F28
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00007DA8 File Offset: 0x00005FA8
		public string ReasonPhrase
		{
			get
			{
				string reasonPhrase;
				try
				{
					reasonPhrase = this._nativeICoreWebView2WebResourceResponse.ReasonPhrase;
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
				return reasonPhrase;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceResponse.ReasonPhrase = value;
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
			}
		}

		// Token: 0x040000FE RID: 254
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponse _nativeICoreWebView2WebResourceResponseValue;

		// Token: 0x040000FF RID: 255
		internal object _rawNative;
	}
}
