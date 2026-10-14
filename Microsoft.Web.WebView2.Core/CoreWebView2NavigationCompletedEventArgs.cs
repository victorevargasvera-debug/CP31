using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000037 RID: 55
	public class CoreWebView2NavigationCompletedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000CA28 File Offset: 0x0000AC28
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2NavigationCompletedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2NavigationCompletedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2NavigationCompletedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NavigationCompletedEventArgsValue = value;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000CA32 File Offset: 0x0000AC32
		internal CoreWebView2NavigationCompletedEventArgs(object rawCoreWebView2NavigationCompletedEventArgs)
		{
			this._rawNative = rawCoreWebView2NavigationCompletedEventArgs;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000CA44 File Offset: 0x0000AC44
		public bool IsSuccess
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NavigationCompletedEventArgs.IsSuccess != 0);
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus WebErrorStatus
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus webErrorStatus;
				try
				{
					webErrorStatus = (global::Microsoft.Web.WebView2.Core.CoreWebView2WebErrorStatus)this._nativeICoreWebView2NavigationCompletedEventArgs.WebErrorStatus;
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
				return webErrorStatus;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000CB48 File Offset: 0x0000AD48
		public ulong NavigationId
		{
			get
			{
				ulong navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2NavigationCompletedEventArgs.NavigationId;
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

		// Token: 0x0400011B RID: 283
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationCompletedEventArgs _nativeICoreWebView2NavigationCompletedEventArgsValue;

		// Token: 0x0400011C RID: 284
		internal object _rawNative;
	}
}
