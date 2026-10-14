using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200002F RID: 47
	public class CoreWebView2SourceChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000876C File Offset: 0x0000696C
		// (set) Token: 0x06000132 RID: 306 RVA: 0x000087C8 File Offset: 0x000069C8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2SourceChangedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2SourceChangedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2SourceChangedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2SourceChangedEventArgsValue = value;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000087D2 File Offset: 0x000069D2
		internal CoreWebView2SourceChangedEventArgs(object rawCoreWebView2SourceChangedEventArgs)
		{
			this._rawNative = rawCoreWebView2SourceChangedEventArgs;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000087E4 File Offset: 0x000069E4
		public bool IsNewDocument
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2SourceChangedEventArgs.IsNewDocument != 0);
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

		// Token: 0x04000106 RID: 262
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2SourceChangedEventArgs _nativeICoreWebView2SourceChangedEventArgsValue;

		// Token: 0x04000107 RID: 263
		internal object _rawNative;
	}
}
