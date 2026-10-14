using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000038 RID: 56
	public class CoreWebView2MoveFocusRequestedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000CC24 File Offset: 0x0000AE24
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs _nativeICoreWebView2MoveFocusRequestedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2MoveFocusRequestedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2MoveFocusRequestedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2MoveFocusRequestedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2MoveFocusRequestedEventArgsValue = value;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000CC2E File Offset: 0x0000AE2E
		internal CoreWebView2MoveFocusRequestedEventArgs(object rawCoreWebView2MoveFocusRequestedEventArgs)
		{
			this._rawNative = rawCoreWebView2MoveFocusRequestedEventArgs;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason Reason
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason reason;
				try
				{
					reason = (global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason)this._nativeICoreWebView2MoveFocusRequestedEventArgs.Reason;
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
				return reason;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000CD44 File Offset: 0x0000AF44
		public bool Handled
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2MoveFocusRequestedEventArgs.Handled != 0);
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
					this._nativeICoreWebView2MoveFocusRequestedEventArgs.Handled = (value ? 1 : 0);
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

		// Token: 0x0400011D RID: 285
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2MoveFocusRequestedEventArgs _nativeICoreWebView2MoveFocusRequestedEventArgsValue;

		// Token: 0x0400011E RID: 286
		internal object _rawNative;
	}
}
