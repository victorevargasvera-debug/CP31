using System;
using System.Net;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000003 RID: 3
	public class CoreWebView2Cookie
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003588 File Offset: 0x00001788
		public global::System.Net.Cookie ToSystemNetCookie()
		{
			return new global::System.Net.Cookie(this.Name, this.Value, this.Path, this.Domain)
			{
				Expires = this.Expires,
				HttpOnly = this.IsHttpOnly,
				Secure = this.IsSecure
			};
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000035E0 File Offset: 0x000017E0
		private global::System.DateTime SecondsSinceUnixEpochToDateTime(double seconds)
		{
			bool flag = seconds < 0.0;
			global::System.DateTime result;
			if (flag)
			{
				result = global::System.DateTime.MinValue;
			}
			else
			{
				bool flag2 = seconds * 10000000.0 + (double)global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie._unixEpoch.Ticks > (double)global::System.DateTime.MaxValue.Ticks;
				if (flag2)
				{
					result = global::System.DateTime.MaxValue;
				}
				else
				{
					result = global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie._unixEpoch.AddSeconds(seconds);
				}
			}
			return result;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000364A File Offset: 0x0000184A
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003660 File Offset: 0x00001860
		public global::System.DateTime Expires
		{
			get
			{
				return this.SecondsSinceUnixEpochToDateTime(this._nativeICoreWebView2Cookie.Expires);
			}
			set
			{
				bool flag = value.Kind != global::System.DateTimeKind.Utc;
				if (flag)
				{
					value = value.ToUniversalTime();
				}
				double totalSeconds = (value - global::Microsoft.Web.WebView2.Core.CoreWebView2Cookie._unixEpoch).TotalSeconds;
				this._nativeICoreWebView2Cookie.Expires = ((totalSeconds < 0.0) ? global::System.Convert.ToDouble(-1.0) : totalSeconds);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000036C8 File Offset: 0x000018C8
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003724 File Offset: 0x00001924
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie _nativeICoreWebView2Cookie
		{
			get
			{
				bool flag = this._nativeICoreWebView2CookieValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CookieValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2CookieValue;
			}
			set
			{
				this._nativeICoreWebView2CookieValue = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000372E File Offset: 0x0000192E
		internal CoreWebView2Cookie(object rawCoreWebView2Cookie)
		{
			this._rawNative = rawCoreWebView2Cookie;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003740 File Offset: 0x00001940
		public string Name
		{
			get
			{
				string name;
				try
				{
					name = this._nativeICoreWebView2Cookie.Name;
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
				return name;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000037C0 File Offset: 0x000019C0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003840 File Offset: 0x00001A40
		public string Value
		{
			get
			{
				string value;
				try
				{
					value = this._nativeICoreWebView2Cookie.Value;
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
				return value;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.Value = value;
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000038C0 File Offset: 0x00001AC0
		public string Domain
		{
			get
			{
				string domain;
				try
				{
					domain = this._nativeICoreWebView2Cookie.Domain;
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
				return domain;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003940 File Offset: 0x00001B40
		public string Path
		{
			get
			{
				string path;
				try
				{
					path = this._nativeICoreWebView2Cookie.Path;
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
				return path;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00003A44 File Offset: 0x00001C44
		public bool IsHttpOnly
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2Cookie.IsHttpOnly != 0);
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
					this._nativeICoreWebView2Cookie.IsHttpOnly = (value ? 1 : 0);
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00003B48 File Offset: 0x00001D48
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CookieSameSiteKind SameSite
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2CookieSameSiteKind sameSite;
				try
				{
					sameSite = (global::Microsoft.Web.WebView2.Core.CoreWebView2CookieSameSiteKind)this._nativeICoreWebView2Cookie.SameSite;
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
				return sameSite;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Cookie.SameSite = (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_COOKIE_SAME_SITE_KIND)value;
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

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003BC8 File Offset: 0x00001DC8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003C4C File Offset: 0x00001E4C
		public bool IsSecure
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2Cookie.IsSecure != 0);
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
					this._nativeICoreWebView2Cookie.IsSecure = (value ? 1 : 0);
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

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public bool IsSession
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2Cookie.IsSession != 0);
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

		// Token: 0x04000013 RID: 19
		private static global::System.DateTime _unixEpoch = global::System.DateTime.SpecifyKind(new global::System.DateTime(1970, 1, 1), global::System.DateTimeKind.Utc);

		// Token: 0x04000014 RID: 20
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Cookie _nativeICoreWebView2CookieValue;

		// Token: 0x04000015 RID: 21
		internal object _rawNative;
	}
}
