using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x0200000E RID: 14
	public class CoreWebView2Deferral : global::System.IDisposable
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00006842 File Offset: 0x00004A42
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00006854 File Offset: 0x00004A54
		protected virtual void Dispose(bool disposing)
		{
			bool flag = this.disposed;
			if (!flag)
			{
				if (disposing)
				{
					this.handle.Dispose();
				}
				this.Complete();
				this.disposed = true;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00006890 File Offset: 0x00004A90
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000068EC File Offset: 0x00004AEC
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral _nativeICoreWebView2Deferral
		{
			get
			{
				bool flag = this._nativeICoreWebView2DeferralValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DeferralValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DeferralValue;
			}
			set
			{
				this._nativeICoreWebView2DeferralValue = value;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000068F6 File Offset: 0x00004AF6
		internal CoreWebView2Deferral(object rawCoreWebView2Deferral)
		{
			this._rawNative = rawCoreWebView2Deferral;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006920 File Offset: 0x00004B20
		public void Complete()
		{
			try
			{
				this._nativeICoreWebView2Deferral.Complete();
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

		// Token: 0x04000039 RID: 57
		private bool disposed = false;

		// Token: 0x0400003A RID: 58
		private global::System.Runtime.InteropServices.SafeHandle handle = new global::Microsoft.Win32.SafeHandles.SafeFileHandle(global::System.IntPtr.Zero, true);

		// Token: 0x0400003B RID: 59
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Deferral _nativeICoreWebView2DeferralValue;

		// Token: 0x0400003C RID: 60
		internal object _rawNative;
	}
}
