using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000028 RID: 40
	public class CoreWebView2WindowFeatures
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00007084 File Offset: 0x00005284
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000070E0 File Offset: 0x000052E0
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures _nativeICoreWebView2WindowFeatures
		{
			get
			{
				bool flag = this._nativeICoreWebView2WindowFeaturesValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2WindowFeaturesValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2WindowFeaturesValue;
			}
			set
			{
				this._nativeICoreWebView2WindowFeaturesValue = value;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000070EA File Offset: 0x000052EA
		internal CoreWebView2WindowFeatures(object rawCoreWebView2WindowFeatures)
		{
			this._rawNative = rawCoreWebView2WindowFeatures;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000070FC File Offset: 0x000052FC
		public bool HasPosition
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.HasPosition != 0);
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00007180 File Offset: 0x00005380
		public bool HasSize
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.HasSize != 0);
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00007204 File Offset: 0x00005404
		public uint Left
		{
			get
			{
				uint left;
				try
				{
					left = this._nativeICoreWebView2WindowFeatures.Left;
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
				return left;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00007284 File Offset: 0x00005484
		public uint Top
		{
			get
			{
				uint top;
				try
				{
					top = this._nativeICoreWebView2WindowFeatures.Top;
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
				return top;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00007304 File Offset: 0x00005504
		public uint Height
		{
			get
			{
				uint height;
				try
				{
					height = this._nativeICoreWebView2WindowFeatures.Height;
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
				return height;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00007384 File Offset: 0x00005584
		public uint Width
		{
			get
			{
				uint width;
				try
				{
					width = this._nativeICoreWebView2WindowFeatures.Width;
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
				return width;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00007404 File Offset: 0x00005604
		public bool ShouldDisplayMenuBar
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.ShouldDisplayMenuBar != 0);
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00007488 File Offset: 0x00005688
		public bool ShouldDisplayStatus
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.ShouldDisplayStatus != 0);
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000750C File Offset: 0x0000570C
		public bool ShouldDisplayToolbar
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.ShouldDisplayToolbar != 0);
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00007590 File Offset: 0x00005790
		public bool ShouldDisplayScrollBars
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2WindowFeatures.ShouldDisplayScrollBars != 0);
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

		// Token: 0x040000F8 RID: 248
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2WindowFeatures _nativeICoreWebView2WindowFeaturesValue;

		// Token: 0x040000F9 RID: 249
		internal object _rawNative;
	}
}
