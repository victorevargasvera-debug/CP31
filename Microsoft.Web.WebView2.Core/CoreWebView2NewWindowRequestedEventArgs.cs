using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000035 RID: 53
	public class CoreWebView2NewWindowRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000C158 File Offset: 0x0000A358
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2NewWindowRequestedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2NewWindowRequestedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2NewWindowRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2NewWindowRequestedEventArgsValue = value;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000C162 File Offset: 0x0000A362
		internal CoreWebView2NewWindowRequestedEventArgs(object rawCoreWebView2NewWindowRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2NewWindowRequestedEventArgs;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000C174 File Offset: 0x0000A374
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2NewWindowRequestedEventArgs.Uri;
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000C288 File Offset: 0x0000A488
		public global::Microsoft.Web.WebView2.Core.CoreWebView2 NewWindow
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2 result;
				try
				{
					result = ((this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2(this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow));
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
					this._nativeICoreWebView2NewWindowRequestedEventArgs.NewWindow = value._nativeICoreWebView2;
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000C30C File Offset: 0x0000A50C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000C390 File Offset: 0x0000A590
		public bool Handled
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NewWindowRequestedEventArgs.Handled != 0);
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
					this._nativeICoreWebView2NewWindowRequestedEventArgs.Handled = (value ? 1 : 0);
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000C414 File Offset: 0x0000A614
		public bool IsUserInitiated
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2NewWindowRequestedEventArgs.IsUserInitiated != 0);
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000C498 File Offset: 0x0000A698
		public global::Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures WindowFeatures
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures result;
				try
				{
					result = ((this._nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2WindowFeatures(this._nativeICoreWebView2NewWindowRequestedEventArgs.WindowFeatures));
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

		// Token: 0x060001BF RID: 447 RVA: 0x0000C52C File Offset: 0x0000A72C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral GetDeferral()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral(this._nativeICoreWebView2NewWindowRequestedEventArgs.GetDeferral());
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

		// Token: 0x04000117 RID: 279
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2NewWindowRequestedEventArgs _nativeICoreWebView2NewWindowRequestedEventArgsValue;

		// Token: 0x04000118 RID: 280
		internal object _rawNative;
	}
}
