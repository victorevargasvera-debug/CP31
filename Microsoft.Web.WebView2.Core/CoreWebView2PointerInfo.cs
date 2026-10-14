using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000033 RID: 51
	public class CoreWebView2PointerInfo
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000A0C4 File Offset: 0x000082C4
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000A120 File Offset: 0x00008320
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfo
		{
			get
			{
				bool flag = this._nativeICoreWebView2PointerInfoValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2PointerInfoValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2PointerInfoValue;
			}
			set
			{
				this._nativeICoreWebView2PointerInfoValue = value;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000A12A File Offset: 0x0000832A
		internal CoreWebView2PointerInfo(object rawCoreWebView2PointerInfo)
		{
			this._rawNative = rawCoreWebView2PointerInfo;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000A13C File Offset: 0x0000833C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000A1BC File Offset: 0x000083BC
		public uint PointerKind
		{
			get
			{
				uint pointerKind;
				try
				{
					pointerKind = this._nativeICoreWebView2PointerInfo.PointerKind;
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
				return pointerKind;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PointerKind = value;
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000A23C File Offset: 0x0000843C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000A2BC File Offset: 0x000084BC
		public uint PointerId
		{
			get
			{
				uint pointerId;
				try
				{
					pointerId = this._nativeICoreWebView2PointerInfo.PointerId;
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
				return pointerId;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PointerId = value;
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000A33C File Offset: 0x0000853C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000A3BC File Offset: 0x000085BC
		public uint FrameId
		{
			get
			{
				uint frameId;
				try
				{
					frameId = this._nativeICoreWebView2PointerInfo.FrameId;
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
				return frameId;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.FrameId = value;
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000A43C File Offset: 0x0000863C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000A4BC File Offset: 0x000086BC
		public uint PointerFlags
		{
			get
			{
				uint pointerFlags;
				try
				{
					pointerFlags = this._nativeICoreWebView2PointerInfo.PointerFlags;
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
				return pointerFlags;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PointerFlags = value;
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0000A53C File Offset: 0x0000873C
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000A5C0 File Offset: 0x000087C0
		public global::System.Drawing.Rectangle PointerDeviceRect
		{
			get
			{
				global::System.Drawing.Rectangle result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2PointerInfo.PointerDeviceRect);
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
					this._nativeICoreWebView2PointerInfo.PointerDeviceRect = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0000A644 File Offset: 0x00008844
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0000A6C8 File Offset: 0x000088C8
		public global::System.Drawing.Rectangle DisplayRect
		{
			get
			{
				global::System.Drawing.Rectangle result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2PointerInfo.DisplayRect);
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
					this._nativeICoreWebView2PointerInfo.DisplayRect = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000A74C File Offset: 0x0000894C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000A7D0 File Offset: 0x000089D0
		public global::System.Drawing.Point PixelLocation
		{
			get
			{
				global::System.Drawing.Point result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2PointerInfo.PixelLocation);
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
					this._nativeICoreWebView2PointerInfo.PixelLocation = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointNetToCOM(value);
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000A854 File Offset: 0x00008A54
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public global::System.Drawing.Point HimetricLocation
		{
			get
			{
				global::System.Drawing.Point result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2PointerInfo.HimetricLocation);
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
					this._nativeICoreWebView2PointerInfo.HimetricLocation = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointNetToCOM(value);
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0000A95C File Offset: 0x00008B5C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		public global::System.Drawing.Point PixelLocationRaw
		{
			get
			{
				global::System.Drawing.Point result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2PointerInfo.PixelLocationRaw);
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
					this._nativeICoreWebView2PointerInfo.PixelLocationRaw = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointNetToCOM(value);
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0000AA64 File Offset: 0x00008C64
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public global::System.Drawing.Point HimetricLocationRaw
		{
			get
			{
				global::System.Drawing.Point result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointCOMToNet(this._nativeICoreWebView2PointerInfo.HimetricLocationRaw);
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
					this._nativeICoreWebView2PointerInfo.HimetricLocationRaw = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointNetToCOM(value);
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0000AB6C File Offset: 0x00008D6C
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0000ABEC File Offset: 0x00008DEC
		public uint Time
		{
			get
			{
				uint time;
				try
				{
					time = this._nativeICoreWebView2PointerInfo.Time;
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
				return time;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.Time = value;
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0000AC6C File Offset: 0x00008E6C
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public uint HistoryCount
		{
			get
			{
				uint historyCount;
				try
				{
					historyCount = this._nativeICoreWebView2PointerInfo.HistoryCount;
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
				return historyCount;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.HistoryCount = value;
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000AD6C File Offset: 0x00008F6C
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public int InputData
		{
			get
			{
				int inputData;
				try
				{
					inputData = this._nativeICoreWebView2PointerInfo.InputData;
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
				return inputData;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.InputData = value;
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

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000AE6C File Offset: 0x0000906C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000AEEC File Offset: 0x000090EC
		public uint KeyStates
		{
			get
			{
				uint keyStates;
				try
				{
					keyStates = this._nativeICoreWebView2PointerInfo.KeyStates;
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
				return keyStates;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.KeyStates = value;
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000AF6C File Offset: 0x0000916C
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000AFEC File Offset: 0x000091EC
		public ulong PerformanceCount
		{
			get
			{
				ulong performanceCount;
				try
				{
					performanceCount = this._nativeICoreWebView2PointerInfo.PerformanceCount;
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
				return performanceCount;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PerformanceCount = value;
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000B06C File Offset: 0x0000926C
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000B0EC File Offset: 0x000092EC
		public int ButtonChangeKind
		{
			get
			{
				int buttonChangeKind;
				try
				{
					buttonChangeKind = this._nativeICoreWebView2PointerInfo.ButtonChangeKind;
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
				return buttonChangeKind;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.ButtonChangeKind = value;
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000B16C File Offset: 0x0000936C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000B1EC File Offset: 0x000093EC
		public uint PenFlags
		{
			get
			{
				uint penFlags;
				try
				{
					penFlags = this._nativeICoreWebView2PointerInfo.PenFlags;
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
				return penFlags;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenFlags = value;
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000B26C File Offset: 0x0000946C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000B2EC File Offset: 0x000094EC
		public uint PenMask
		{
			get
			{
				uint penMask;
				try
				{
					penMask = this._nativeICoreWebView2PointerInfo.PenMask;
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
				return penMask;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenMask = value;
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000B36C File Offset: 0x0000956C
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000B3EC File Offset: 0x000095EC
		public uint PenPressure
		{
			get
			{
				uint penPressure;
				try
				{
					penPressure = this._nativeICoreWebView2PointerInfo.PenPressure;
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
				return penPressure;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenPressure = value;
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000B46C File Offset: 0x0000966C
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000B4EC File Offset: 0x000096EC
		public uint PenRotation
		{
			get
			{
				uint penRotation;
				try
				{
					penRotation = this._nativeICoreWebView2PointerInfo.PenRotation;
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
				return penRotation;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenRotation = value;
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000B56C File Offset: 0x0000976C
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000B5EC File Offset: 0x000097EC
		public int PenTiltX
		{
			get
			{
				int penTiltX;
				try
				{
					penTiltX = this._nativeICoreWebView2PointerInfo.PenTiltX;
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
				return penTiltX;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenTiltX = value;
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000B66C File Offset: 0x0000986C
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000B6EC File Offset: 0x000098EC
		public int PenTiltY
		{
			get
			{
				int penTiltY;
				try
				{
					penTiltY = this._nativeICoreWebView2PointerInfo.PenTiltY;
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
				return penTiltY;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.PenTiltY = value;
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000B76C File Offset: 0x0000996C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000B7EC File Offset: 0x000099EC
		public uint TouchFlags
		{
			get
			{
				uint touchFlags;
				try
				{
					touchFlags = this._nativeICoreWebView2PointerInfo.TouchFlags;
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
				return touchFlags;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.TouchFlags = value;
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000B86C File Offset: 0x00009A6C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public uint TouchMask
		{
			get
			{
				uint touchMask;
				try
				{
					touchMask = this._nativeICoreWebView2PointerInfo.TouchMask;
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
				return touchMask;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.TouchMask = value;
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000B96C File Offset: 0x00009B6C
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public global::System.Drawing.Rectangle TouchContact
		{
			get
			{
				global::System.Drawing.Rectangle result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2PointerInfo.TouchContact);
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
					this._nativeICoreWebView2PointerInfo.TouchContact = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000BA74 File Offset: 0x00009C74
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000BAF8 File Offset: 0x00009CF8
		public global::System.Drawing.Rectangle TouchContactRaw
		{
			get
			{
				global::System.Drawing.Rectangle result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2PointerInfo.TouchContactRaw);
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
					this._nativeICoreWebView2PointerInfo.TouchContactRaw = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000BB7C File Offset: 0x00009D7C
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public uint TouchOrientation
		{
			get
			{
				uint touchOrientation;
				try
				{
					touchOrientation = this._nativeICoreWebView2PointerInfo.TouchOrientation;
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
				return touchOrientation;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.TouchOrientation = value;
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000BC7C File Offset: 0x00009E7C
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000BCFC File Offset: 0x00009EFC
		public uint TouchPressure
		{
			get
			{
				uint touchPressure;
				try
				{
					touchPressure = this._nativeICoreWebView2PointerInfo.TouchPressure;
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
				return touchPressure;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2PointerInfo.TouchPressure = value;
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

		// Token: 0x04000113 RID: 275
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2PointerInfo _nativeICoreWebView2PointerInfoValue;

		// Token: 0x04000114 RID: 276
		internal object _rawNative;
	}
}
