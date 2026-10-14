using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000031 RID: 49
	public class CoreWebView2ScriptDialogOpeningEventArgs : global::System.EventArgs
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000098E8 File Offset: 0x00007AE8
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00009944 File Offset: 0x00007B44
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs _nativeICoreWebView2ScriptDialogOpeningEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2ScriptDialogOpeningEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2ScriptDialogOpeningEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2ScriptDialogOpeningEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2ScriptDialogOpeningEventArgsValue = value;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000994E File Offset: 0x00007B4E
		internal CoreWebView2ScriptDialogOpeningEventArgs(object rawCoreWebView2ScriptDialogOpeningEventArgs)
		{
			this._rawNative = rawCoreWebView2ScriptDialogOpeningEventArgs;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00009960 File Offset: 0x00007B60
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2ScriptDialogOpeningEventArgs.Uri;
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

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000099E0 File Offset: 0x00007BE0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogKind Kind
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogKind kind;
				try
				{
					kind = (global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogKind)this._nativeICoreWebView2ScriptDialogOpeningEventArgs.Kind;
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
				return kind;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00009A60 File Offset: 0x00007C60
		public string Message
		{
			get
			{
				string message;
				try
				{
					message = this._nativeICoreWebView2ScriptDialogOpeningEventArgs.Message;
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
				return message;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00009AE0 File Offset: 0x00007CE0
		public string DefaultText
		{
			get
			{
				string defaultText;
				try
				{
					defaultText = this._nativeICoreWebView2ScriptDialogOpeningEventArgs.DefaultText;
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
				return defaultText;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00009B60 File Offset: 0x00007D60
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public string ResultText
		{
			get
			{
				string resultText;
				try
				{
					resultText = this._nativeICoreWebView2ScriptDialogOpeningEventArgs.ResultText;
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
				return resultText;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2ScriptDialogOpeningEventArgs.ResultText = value;
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

		// Token: 0x06000165 RID: 357 RVA: 0x00009C60 File Offset: 0x00007E60
		public void Accept()
		{
			try
			{
				this._nativeICoreWebView2ScriptDialogOpeningEventArgs.Accept();
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

		// Token: 0x06000166 RID: 358 RVA: 0x00009CDC File Offset: 0x00007EDC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral GetDeferral()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2Deferral(this._nativeICoreWebView2ScriptDialogOpeningEventArgs.GetDeferral());
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

		// Token: 0x0400010E RID: 270
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2ScriptDialogOpeningEventArgs _nativeICoreWebView2ScriptDialogOpeningEventArgsValue;

		// Token: 0x0400010F RID: 271
		internal object _rawNative;
	}
}
