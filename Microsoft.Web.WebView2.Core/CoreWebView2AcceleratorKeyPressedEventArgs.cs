using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000041 RID: 65
	public class CoreWebView2AcceleratorKeyPressedEventArgs : global::System.EventArgs
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000E018 File Offset: 0x0000C218
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgs
		{
			get
			{
				bool flag = this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;
			}
			set
			{
				this._nativeICoreWebView2AcceleratorKeyPressedEventArgsValue = value;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000E022 File Offset: 0x0000C222
		internal CoreWebView2AcceleratorKeyPressedEventArgs(object rawCoreWebView2AcceleratorKeyPressedEventArgs)
		{
			this._rawNative = rawCoreWebView2AcceleratorKeyPressedEventArgs;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000E034 File Offset: 0x0000C234
		public global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind KeyEventKind
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind keyEventKind;
				try
				{
					keyEventKind = (global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind)this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventKind;
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
				return keyEventKind;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		public uint VirtualKey
		{
			get
			{
				uint virtualKey;
				try
				{
					virtualKey = this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.VirtualKey;
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
				return virtualKey;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000E134 File Offset: 0x0000C334
		public int KeyEventLParam
		{
			get
			{
				int keyEventLParam;
				try
				{
					keyEventLParam = this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.KeyEventLParam;
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
				return keyEventLParam;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2PhysicalKeyStatus PhysicalKeyStatus
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2PhysicalKeyStatus result;
				try
				{
					result = new global::Microsoft.Web.WebView2.Core.CoreWebView2PhysicalKeyStatus(this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.PhysicalKeyStatus);
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

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000E238 File Offset: 0x0000C438
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000E2BC File Offset: 0x0000C4BC
		public bool Handled
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled != 0);
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
					this._nativeICoreWebView2AcceleratorKeyPressedEventArgs.Handled = (value ? 1 : 0);
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

		// Token: 0x04000134 RID: 308
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2AcceleratorKeyPressedEventArgs _nativeICoreWebView2AcceleratorKeyPressedEventArgsValue;

		// Token: 0x04000135 RID: 309
		internal object _rawNative;
	}
}
