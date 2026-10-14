using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200003D RID: 61
	public class CoreWebView2DevToolsProtocolEventReceiver
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000D640 File Offset: 0x0000B840
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiver
		{
			get
			{
				bool flag = this._nativeICoreWebView2DevToolsProtocolEventReceiverValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiverValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DevToolsProtocolEventReceiverValue;
			}
			set
			{
				this._nativeICoreWebView2DevToolsProtocolEventReceiverValue = value;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000D64A File Offset: 0x0000B84A
		internal CoreWebView2DevToolsProtocolEventReceiver(object rawCoreWebView2DevToolsProtocolEventReceiver)
		{
			this._rawNative = rawCoreWebView2DevToolsProtocolEventReceiver;
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001F1 RID: 497 RVA: 0x0000D65C File Offset: 0x0000B85C
		// (remove) Token: 0x060001F2 RID: 498 RVA: 0x0000D718 File Offset: 0x0000B918
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs> DevToolsProtocolEventReceived
		{
			add
			{
				bool flag = this.devToolsProtocolEventReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiver.add_DevToolsProtocolEventReceived(new global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventHandler.CallbackType(this.OnDevToolsProtocolEventReceived)), out this._devToolsProtocolEventReceivedToken);
					}
					catch (global::System.InvalidCastException ex)
					{
						bool flag2 = ex.HResult == -2147467262;
						if (flag2)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
						}
						throw ex;
					}
					catch (global::System.Runtime.InteropServices.COMException ex2)
					{
						bool flag3 = ex2.HResult == -2147019873;
						if (flag3)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
						}
						throw ex2;
					}
				}
				this.devToolsProtocolEventReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs>)global::System.Delegate.Combine(this.devToolsProtocolEventReceived, value);
			}
			remove
			{
				this.devToolsProtocolEventReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs>)global::System.Delegate.Remove(this.devToolsProtocolEventReceived, value);
				bool flag = this.devToolsProtocolEventReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DevToolsProtocolEventReceiver.remove_DevToolsProtocolEventReceived(this._devToolsProtocolEventReceivedToken);
					}
					catch (global::System.InvalidCastException ex)
					{
						bool flag2 = ex.HResult == -2147467262;
						if (flag2)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members can only be accessed from the UI thread.", ex);
						}
						throw ex;
					}
					catch (global::System.Runtime.InteropServices.COMException ex2)
					{
						bool flag3 = ex2.HResult == -2147019873;
						if (flag3)
						{
							throw new global::System.InvalidOperationException("CoreWebView2 members cannot be accessed after the WebView2 control is disposed.", ex2);
						}
						throw ex2;
					}
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		internal void OnDevToolsProtocolEventReceived(global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs> eventHandler = this.devToolsProtocolEventReceived;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x04000127 RID: 295
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DevToolsProtocolEventReceiver _nativeICoreWebView2DevToolsProtocolEventReceiverValue;

		// Token: 0x04000128 RID: 296
		internal object _rawNative;

		// Token: 0x04000129 RID: 297
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _devToolsProtocolEventReceivedToken;

		// Token: 0x0400012A RID: 298
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceivedEventArgs> devToolsProtocolEventReceived;
	}
}
