using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000036 RID: 54
	public class CoreWebView2NavigationStartingEventArgs : global::System.EventArgs
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000C60C File Offset: 0x0000A80C
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2NavigationStartingEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2NavigationStartingEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2NavigationStartingEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NavigationStartingEventArgsValue = value;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000C616 File Offset: 0x0000A816
		internal CoreWebView2NavigationStartingEventArgs(object rawCoreWebView2NavigationStartingEventArgs)
		{
			this._rawNative = rawCoreWebView2NavigationStartingEventArgs;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000C628 File Offset: 0x0000A828
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2NavigationStartingEventArgs.Uri;
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public bool IsUserInitiated
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NavigationStartingEventArgs.IsUserInitiated != 0);
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000C72C File Offset: 0x0000A92C
		public bool IsRedirected
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NavigationStartingEventArgs.IsRedirected != 0);
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders RequestHeaders
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders result;
				try
				{
					result = ((this._nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2HttpRequestHeaders(this._nativeICoreWebView2NavigationStartingEventArgs.RequestHeaders));
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000C844 File Offset: 0x0000AA44
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000C8C8 File Offset: 0x0000AAC8
		public bool Cancel
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NavigationStartingEventArgs.Cancel != 0);
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
					this._nativeICoreWebView2NavigationStartingEventArgs.Cancel = (value ? 1 : 0);
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000C94C File Offset: 0x0000AB4C
		public ulong NavigationId
		{
			get
			{
				ulong navigationId;
				try
				{
					navigationId = this._nativeICoreWebView2NavigationStartingEventArgs.NavigationId;
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

		// Token: 0x04000119 RID: 281
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NavigationStartingEventArgs _nativeICoreWebView2NavigationStartingEventArgsValue;

		// Token: 0x0400011A RID: 282
		internal object _rawNative;
	}
}
