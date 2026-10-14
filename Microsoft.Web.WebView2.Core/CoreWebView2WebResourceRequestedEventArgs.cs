using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002C RID: 44
	public class CoreWebView2WebResourceRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00007E28 File Offset: 0x00006028
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00007E84 File Offset: 0x00006084
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebResourceRequestedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebResourceRequestedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebResourceRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceRequestedEventArgsValue = value;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00007E8E File Offset: 0x0000608E
		internal CoreWebView2WebResourceRequestedEventArgs(object rawCoreWebView2WebResourceRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2WebResourceRequestedEventArgs;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00007EA0 File Offset: 0x000060A0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest Request
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceRequestedEventArgs.Request == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest(this._nativeICoreWebView2WebResourceRequestedEventArgs.Request));
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00007F34 File Offset: 0x00006134
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00007FC8 File Offset: 0x000061C8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse Response
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceRequestedEventArgs.Response == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponse(this._nativeICoreWebView2WebResourceRequestedEventArgs.Response));
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
					this._nativeICoreWebView2WebResourceRequestedEventArgs.Response = value._nativeICoreWebView2WebResourceResponse;
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

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000804C File Offset: 0x0000624C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext ResourceContext
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext resourceContext;
				try
				{
					resourceContext = (global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext)this._nativeICoreWebView2WebResourceRequestedEventArgs.ResourceContext;
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
				return resourceContext;
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000080CC File Offset: 0x000062CC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral GetDeferral()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral(this._nativeICoreWebView2WebResourceRequestedEventArgs.GetDeferral());
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

		// Token: 0x04000100 RID: 256
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceRequestedEventArgs _nativeICoreWebView2WebResourceRequestedEventArgsValue;

		// Token: 0x04000101 RID: 257
		internal object _rawNative;
	}
}
