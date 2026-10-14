using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000040 RID: 64
	public class CoreWebView2CompositionController
	{
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000DA50 File Offset: 0x0000BC50
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController _nativeICoreWebView2CompositionController
		{
			get
			{
				bool flag = this._nativeICoreWebView2CompositionControllerValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CompositionControllerValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2CompositionControllerValue;
			}
			set
			{
				this._nativeICoreWebView2CompositionControllerValue = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000DB14 File Offset: 0x0000BD14
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2
		{
			get
			{
				bool flag = this._nativeICoreWebView2CompositionController2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CompositionController2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2CompositionController2Value;
			}
			set
			{
				this._nativeICoreWebView2CompositionController2Value = value;
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000DB1E File Offset: 0x0000BD1E
		internal CoreWebView2CompositionController(object rawCoreWebView2CompositionController)
		{
			this._rawNative = rawCoreWebView2CompositionController;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public object RootVisualTarget
		{
			get
			{
				object rootVisualTarget;
				try
				{
					rootVisualTarget = this._nativeICoreWebView2CompositionController.RootVisualTarget;
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
				return rootVisualTarget;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2CompositionController.RootVisualTarget = value;
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000DC30 File Offset: 0x0000BE30
		public global::System.IntPtr Cursor
		{
			get
			{
				global::System.IntPtr cursor;
				try
				{
					cursor = this._nativeICoreWebView2CompositionController.Cursor;
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
				return cursor;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		public uint SystemCursorId
		{
			get
			{
				uint systemCursorId;
				try
				{
					systemCursorId = this._nativeICoreWebView2CompositionController.SystemCursorId;
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
				return systemCursorId;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000206 RID: 518 RVA: 0x0000DD30 File Offset: 0x0000BF30
		// (remove) Token: 0x06000207 RID: 519 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public event global::System.EventHandler<object> CursorChanged
		{
			add
			{
				bool flag = this.cursorChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CompositionController.add_CursorChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2CursorChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2CursorChangedEventHandler.CallbackType(this.OnCursorChanged)), out this._cursorChangedToken);
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
				this.cursorChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.cursorChanged, value);
			}
			remove
			{
				this.cursorChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.cursorChanged, value);
				bool flag = this.cursorChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2CompositionController.remove_CursorChanged(this._cursorChangedToken);
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

		// Token: 0x06000208 RID: 520 RVA: 0x0000DE98 File Offset: 0x0000C098
		internal void OnCursorChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.cursorChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		public void SendMouseInput(global::Microsoft.Web.WebView2.Core.CoreWebView2MouseEventKind eventKind, global::Microsoft.Web.WebView2.Core.CoreWebView2MouseEventVirtualKeys virtualKeys, uint mouseData, global::System.Drawing.Point point)
		{
			try
			{
				this._nativeICoreWebView2CompositionController.SendMouseInput((global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_MOUSE_EVENT_KIND)eventKind, (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS)virtualKeys, mouseData, global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.PointNetToCOM(point));
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

		// Token: 0x0600020A RID: 522 RVA: 0x0000DF38 File Offset: 0x0000C138
		public void SendPointerInput(global::Microsoft.Web.WebView2.Core.CoreWebView2PointerEventKind eventKind, global::Microsoft.Web.WebView2.Core.CoreWebView2PointerInfo pointerInfo)
		{
			try
			{
				this._nativeICoreWebView2CompositionController.SendPointerInput((global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_POINTER_EVENT_KIND)eventKind, pointerInfo._nativeICoreWebView2PointerInfo);
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

		// Token: 0x0400012F RID: 303
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController _nativeICoreWebView2CompositionControllerValue;

		// Token: 0x04000130 RID: 304
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2CompositionController2 _nativeICoreWebView2CompositionController2Value;

		// Token: 0x04000131 RID: 305
		internal object _rawNative;

		// Token: 0x04000132 RID: 306
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _cursorChangedToken;

		// Token: 0x04000133 RID: 307
		private global::System.EventHandler<object> cursorChanged;
	}
}
