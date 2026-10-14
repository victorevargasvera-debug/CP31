using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000034 RID: 52
	public class CoreWebView2PermissionRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000BD7C File Offset: 0x00009F7C
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2PermissionRequestedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2PermissionRequestedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2PermissionRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2PermissionRequestedEventArgsValue = value;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000BDE2 File Offset: 0x00009FE2
		internal CoreWebView2PermissionRequestedEventArgs(object rawCoreWebView2PermissionRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2PermissionRequestedEventArgs;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2PermissionRequestedEventArgs.Uri;
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
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000BE74 File Offset: 0x0000A074
		public global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionKind PermissionKind
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionKind permissionKind;
				try
				{
					permissionKind = (global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionKind)this._nativeICoreWebView2PermissionRequestedEventArgs.PermissionKind;
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
				return permissionKind;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		public bool IsUserInitiated
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2PermissionRequestedEventArgs.IsUserInitiated != 0);
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000BF78 File Offset: 0x0000A178
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000BFF8 File Offset: 0x0000A1F8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionState State
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionState state;
				try
				{
					state = (global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionState)this._nativeICoreWebView2PermissionRequestedEventArgs.State;
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
				return state;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PermissionRequestedEventArgs.State = (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_PERMISSION_STATE)value;
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

		// Token: 0x060001B4 RID: 436 RVA: 0x0000C078 File Offset: 0x0000A278
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral GetDeferral()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral(this._nativeICoreWebView2PermissionRequestedEventArgs.GetDeferral());
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

		// Token: 0x04000115 RID: 277
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PermissionRequestedEventArgs _nativeICoreWebView2PermissionRequestedEventArgsValue;

		// Token: 0x04000116 RID: 278
		internal object _rawNative;
	}
}
