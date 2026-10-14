using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000039 RID: 57
	public class CoreWebView2FrameInfo
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000CE24 File Offset: 0x0000B024
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfo
		{
			get
			{
				bool flag = this._nativeICoreWebView2FrameInfoValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2FrameInfoValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2FrameInfoValue;
			}
			set
			{
				this._nativeICoreWebView2FrameInfoValue = value;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000CE2E File Offset: 0x0000B02E
		internal CoreWebView2FrameInfo(object rawCoreWebView2FrameInfo)
		{
			this._rawNative = rawCoreWebView2FrameInfo;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000CE40 File Offset: 0x0000B040
		public string Name
		{
			get
			{
				string name;
				try
				{
					name = this._nativeICoreWebView2FrameInfo.Name;
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
				return name;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000CEC0 File Offset: 0x0000B0C0
		public string Source
		{
			get
			{
				string source;
				try
				{
					source = this._nativeICoreWebView2FrameInfo.Source;
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
				return source;
			}
		}

		// Token: 0x0400011F RID: 287
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2FrameInfo _nativeICoreWebView2FrameInfoValue;

		// Token: 0x04000120 RID: 288
		internal object _rawNative;
	}
}
