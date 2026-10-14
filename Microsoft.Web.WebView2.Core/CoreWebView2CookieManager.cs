using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000004 RID: 4
	public class CoreWebView2CookieManager
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00003D70 File Offset: 0x00001F70
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie CreateCookieWithSystemNetCookie(global::System.Net.Cookie systemNetCookie)
		{
			return new global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CreateCookie(systemNetCookie.Name, systemNetCookie.Value, systemNetCookie.Domain, systemNetCookie.Path))
			{
				IsHttpOnly = systemNetCookie.HttpOnly,
				IsSecure = systemNetCookie.Secure,
				Expires = systemNetCookie.Expires.ToUniversalTime()
			};
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003E38 File Offset: 0x00002038
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager _nativeICoreWebView2CookieManager
		{
			get
			{
				bool flag = this._nativeICoreWebView2CookieManagerValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CookieManagerValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2CookieManagerValue;
			}
			set
			{
				this._nativeICoreWebView2CookieManagerValue = value;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003E42 File Offset: 0x00002042
		internal CoreWebView2CookieManager(object rawCoreWebView2CookieManager)
		{
			this._rawNative = rawCoreWebView2CookieManager;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003E54 File Offset: 0x00002054
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie CreateCookie(string name, string value, string Domain, string Path)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CreateCookie(name, value, Domain, Path));
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

		// Token: 0x06000049 RID: 73 RVA: 0x00003EDC File Offset: 0x000020DC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie CopyCookie(global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie cookieParam)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie(this._nativeICoreWebView2CookieManager.CopyCookie(cookieParam._nativeICoreWebView2Cookie));
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

		// Token: 0x0600004A RID: 74 RVA: 0x00003F68 File Offset: 0x00002168
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie>> GetCookiesAsync(string uri)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager.<GetCookiesAsync>d__10 <GetCookiesAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager.<GetCookiesAsync>d__10();
			<GetCookiesAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.Collections.Generic.List<global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie>>.Create();
			<GetCookiesAsync>d__.<>4__this = this;
			<GetCookiesAsync>d__.uri = uri;
			<GetCookiesAsync>d__.<>1__state = -1;
			<GetCookiesAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager.<GetCookiesAsync>d__10>(ref <GetCookiesAsync>d__);
			return <GetCookiesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003FB4 File Offset: 0x000021B4
		public void AddOrUpdateCookie(global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie cookie)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.AddOrUpdateCookie(cookie._nativeICoreWebView2Cookie);
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

		// Token: 0x0600004C RID: 76 RVA: 0x00004038 File Offset: 0x00002238
		public void DeleteCookie(global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie cookie)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookie(cookie._nativeICoreWebView2Cookie);
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

		// Token: 0x0600004D RID: 77 RVA: 0x000040BC File Offset: 0x000022BC
		public void DeleteCookies(string name, string uri)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookies(name, uri);
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

		// Token: 0x0600004E RID: 78 RVA: 0x0000413C File Offset: 0x0000233C
		public void DeleteCookiesWithDomainAndPath(string name, string Domain, string Path)
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteCookiesWithDomainAndPath(name, Domain, Path);
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

		// Token: 0x0600004F RID: 79 RVA: 0x000041BC File Offset: 0x000023BC
		public void DeleteAllCookies()
		{
			try
			{
				this._nativeICoreWebView2CookieManager.DeleteAllCookies();
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

		// Token: 0x04000016 RID: 22
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CookieManager _nativeICoreWebView2CookieManagerValue;

		// Token: 0x04000017 RID: 23
		internal object _rawNative;
	}
}
