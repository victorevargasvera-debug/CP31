using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003F RID: 63
	public class CoreWebView2ContentLoadingEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000D930 File Offset: 0x0000BB30
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs _nativeICoreWebView2ContentLoadingEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2ContentLoadingEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2ContentLoadingEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2ContentLoadingEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ContentLoadingEventArgsValue = value;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000D93A File Offset: 0x0000BB3A
		internal CoreWebView2ContentLoadingEventArgs(object rawCoreWebView2ContentLoadingEventArgs)
		{
			this._rawNative = rawCoreWebView2ContentLoadingEventArgs;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000D94C File Offset: 0x0000BB4C
		public bool IsErrorPage
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2ContentLoadingEventArgs.IsErrorPage != 0);
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		public ulong NavigationId
		{
			get
			{
				ulong navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2ContentLoadingEventArgs.NavigationId;
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

		// Token: 0x0400012D RID: 301
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ContentLoadingEventArgs _nativeICoreWebView2ContentLoadingEventArgsValue;

		// Token: 0x0400012E RID: 302
		internal object _rawNative;
	}
}
