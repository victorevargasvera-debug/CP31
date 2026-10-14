using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003B RID: 59
	public class CoreWebView2DownloadStartingEventArgs : global::System.EventArgs
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000D04C File Offset: 0x0000B24C
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs _nativeICoreWebView2DownloadStartingEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2DownloadStartingEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadStartingEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DownloadStartingEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2DownloadStartingEventArgsValue = value;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000D0B2 File Offset: 0x0000B2B2
		internal CoreWebView2DownloadStartingEventArgs(object rawCoreWebView2DownloadStartingEventArgs)
		{
			this._rawNative = rawCoreWebView2DownloadStartingEventArgs;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation DownloadOperation
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation result;
				try
				{
					result = ((this._nativeICoreWebView2DownloadStartingEventArgs.DownloadOperation == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadOperation(this._nativeICoreWebView2DownloadStartingEventArgs.DownloadOperation));
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000D158 File Offset: 0x0000B358
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		public bool Cancel
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2DownloadStartingEventArgs.Cancel != 0);
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
					this._nativeICoreWebView2DownloadStartingEventArgs.Cancel = (value ? 1 : 0);
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		public string ResultFilePath
		{
			get
			{
				string resultFilePath;
				try
				{
					resultFilePath = this._nativeICoreWebView2DownloadStartingEventArgs.ResultFilePath;
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
				return resultFilePath;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2DownloadStartingEventArgs.ResultFilePath = value;
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000D360 File Offset: 0x0000B560
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		public bool Handled
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2DownloadStartingEventArgs.Handled != 0);
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
					this._nativeICoreWebView2DownloadStartingEventArgs.Handled = (value ? 1 : 0);
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

		// Token: 0x060001E9 RID: 489 RVA: 0x0000D468 File Offset: 0x0000B668
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral GetDeferral()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral(this._nativeICoreWebView2DownloadStartingEventArgs.GetDeferral());
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

		// Token: 0x04000123 RID: 291
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadStartingEventArgs _nativeICoreWebView2DownloadStartingEventArgsValue;

		// Token: 0x04000124 RID: 292
		internal object _rawNative;
	}
}
