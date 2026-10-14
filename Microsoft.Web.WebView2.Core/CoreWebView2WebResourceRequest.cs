using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002D RID: 45
	public class CoreWebView2WebResourceRequest
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00008150 File Offset: 0x00006350
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000081AC File Offset: 0x000063AC
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest _nativeICoreWebView2WebResourceRequest
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebResourceRequestValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebResourceRequestValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebResourceRequestValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceRequestValue = value;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000081B6 File Offset: 0x000063B6
		internal CoreWebView2WebResourceRequest(object rawCoreWebView2WebResourceRequest)
		{
			this._rawNative = rawCoreWebView2WebResourceRequest;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000081C8 File Offset: 0x000063C8
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00008248 File Offset: 0x00006448
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2WebResourceRequest.Uri;
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
				return uri;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceRequest.Uri = value;
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

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000082C8 File Offset: 0x000064C8
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00008348 File Offset: 0x00006548
		public string Method
		{
			get
			{
				string method;
				try
				{
					method = this._nativeICoreWebView2WebResourceRequest.Method;
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
				return method;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2WebResourceRequest.Method = value;
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

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000083C8 File Offset: 0x000065C8
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000845C File Offset: 0x0000665C
		public global::System.IO.Stream Content
		{
			get
			{
				global::System.IO.Stream result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceRequest.Content == null) ? null : new global::Microsoft.Web.WebView2.Core.COMStreamWrapper(this._nativeICoreWebView2WebResourceRequest.Content));
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
					this._nativeICoreWebView2WebResourceRequest.Content = new global::Microsoft.Web.WebView2.Core.ManagedIStream(value);
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

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000084E0 File Offset: 0x000066E0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders Headers
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceRequest.Headers == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders(this._nativeICoreWebView2WebResourceRequest.Headers));
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

		// Token: 0x04000102 RID: 258
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequest _nativeICoreWebView2WebResourceRequestValue;

		// Token: 0x04000103 RID: 259
		internal object _rawNative;
	}
}
