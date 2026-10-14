using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000029 RID: 41
	public class CoreWebView2WebResourceResponseView
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00007614 File Offset: 0x00005814
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00007670 File Offset: 0x00005870
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseView
		{
			get
			{
				bool flag = this._nativeICoreWebView2WebResourceResponseViewValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WebResourceResponseViewValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WebResourceResponseViewValue;
			}
			set
			{
				this._nativeICoreWebView2WebResourceResponseViewValue = value;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000767A File Offset: 0x0000587A
		internal CoreWebView2WebResourceResponseView(object rawCoreWebView2WebResourceResponseView)
		{
			this._rawNative = rawCoreWebView2WebResourceResponseView;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0000768C File Offset: 0x0000588C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders Headers
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders result;
				try
				{
					result = ((this._nativeICoreWebView2WebResourceResponseView.Headers == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpResponseHeaders(this._nativeICoreWebView2WebResourceResponseView.Headers));
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00007720 File Offset: 0x00005920
		public int StatusCode
		{
			get
			{
				int statusCode;
				try
				{
					statusCode = this._nativeICoreWebView2WebResourceResponseView.StatusCode;
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
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000077A0 File Offset: 0x000059A0
		public string ReasonPhrase
		{
			get
			{
				string reasonPhrase;
				try
				{
					reasonPhrase = this._nativeICoreWebView2WebResourceResponseView.ReasonPhrase;
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
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00007820 File Offset: 0x00005A20
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<global::System.IO.Stream> GetContentAsync()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView.<GetContentAsync>d__13 <GetContentAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView.<GetContentAsync>d__13();
			<GetContentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.IO.Stream>.Create();
			<GetContentAsync>d__.<>4__this = this;
			<GetContentAsync>d__.<>1__state = -1;
			<GetContentAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseView.<GetContentAsync>d__13>(ref <GetContentAsync>d__);
			return <GetContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x040000FA RID: 250
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WebResourceResponseView _nativeICoreWebView2WebResourceResponseViewValue;

		// Token: 0x040000FB RID: 251
		internal object _rawNative;
	}
}
