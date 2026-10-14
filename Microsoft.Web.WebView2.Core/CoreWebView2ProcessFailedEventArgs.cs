using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000032 RID: 50
	public class CoreWebView2ProcessFailedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00009D60 File Offset: 0x00007F60
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00009DBC File Offset: 0x00007FBC
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2ProcessFailedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2ProcessFailedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2ProcessFailedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ProcessFailedEventArgsValue = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00009DC8 File Offset: 0x00007FC8
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00009E24 File Offset: 0x00008024
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2
		{
			get
			{
				bool flag = this._nativeICoreWebView2ProcessFailedEventArgs2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2ProcessFailedEventArgs2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2ProcessFailedEventArgs2Value;
			}
			set
			{
				this._nativeICoreWebView2ProcessFailedEventArgs2Value = value;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00009E2E File Offset: 0x0000802E
		internal CoreWebView2ProcessFailedEventArgs(object rawCoreWebView2ProcessFailedEventArgs)
		{
			this._rawNative = rawCoreWebView2ProcessFailedEventArgs;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00009E40 File Offset: 0x00008040
		public global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind ProcessFailedKind
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind processFailedKind;
				try
				{
					processFailedKind = (global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind)this._nativeICoreWebView2ProcessFailedEventArgs.ProcessFailedKind;
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
				return processFailedKind;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00009EC0 File Offset: 0x000080C0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedReason Reason
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedReason reason;
				try
				{
					reason = (global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedReason)this._nativeICoreWebView2ProcessFailedEventArgs2.Reason;
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

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00009F40 File Offset: 0x00008140
		public int ExitCode
		{
			get
			{
				int exitCode;
				try
				{
					exitCode = this._nativeICoreWebView2ProcessFailedEventArgs2.ExitCode;
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
				return exitCode;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00009FC0 File Offset: 0x000081C0
		public string ProcessDescription
		{
			get
			{
				string processDescription;
				try
				{
					processDescription = this._nativeICoreWebView2ProcessFailedEventArgs2.ProcessDescription;
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
				return processDescription;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0000A040 File Offset: 0x00008240
		public global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> FrameInfosForFailedProcess
		{
			get
			{
				global::System.Collections.Generic.IReadOnlyList<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameInfo> result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.CoreWebView2FrameInfoCollectionCOMToNet(this._nativeICoreWebView2ProcessFailedEventArgs2.FrameInfosForFailedProcess);
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

		// Token: 0x04000110 RID: 272
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs _nativeICoreWebView2ProcessFailedEventArgsValue;

		// Token: 0x04000111 RID: 273
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ProcessFailedEventArgs2 _nativeICoreWebView2ProcessFailedEventArgs2Value;

		// Token: 0x04000112 RID: 274
		internal object _rawNative;
	}
}
