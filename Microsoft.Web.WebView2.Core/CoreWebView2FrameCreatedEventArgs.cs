using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003A RID: 58
	public class CoreWebView2FrameCreatedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000CF40 File Offset: 0x0000B140
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000CF9C File Offset: 0x0000B19C
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs _nativeICoreWebView2FrameCreatedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2FrameCreatedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2FrameCreatedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2FrameCreatedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2FrameCreatedEventArgsValue = value;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000CFA6 File Offset: 0x0000B1A6
		internal CoreWebView2FrameCreatedEventArgs(object rawCoreWebView2FrameCreatedEventArgs)
		{
			this._rawNative = rawCoreWebView2FrameCreatedEventArgs;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Frame Frame
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2Frame result;
				try
				{
					result = ((this._nativeICoreWebView2FrameCreatedEventArgs.Frame == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2Frame(this._nativeICoreWebView2FrameCreatedEventArgs.Frame));
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

		// Token: 0x04000121 RID: 289
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameCreatedEventArgs _nativeICoreWebView2FrameCreatedEventArgsValue;

		// Token: 0x04000122 RID: 290
		internal object _rawNative;
	}
}
