using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000002 RID: 2
	public class CoreWebView2Controller
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public global::Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2
		{
			get
			{
				bool flag = this._nativeICoreWebView2Controller.CoreWebView2 == null;
				global::Microsoft.Web.WebView2.Core.CoreWebView2 result;
				if (flag)
				{
					result = null;
				}
				else
				{
					bool flag2 = this._coreWebView2 == null;
					if (flag2)
					{
						this._coreWebView2 = new global::Microsoft.Web.WebView2.Core.CoreWebView2(this._nativeICoreWebView2Controller.CoreWebView2);
					}
					result = this._coreWebView2;
				}
				return result;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020A4 File Offset: 0x000002A4
		private void Initialize()
		{
			bool flag = this._nativeICoreWebView2Controller != null;
			if (flag)
			{
				global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 coreWebView = this._nativeICoreWebView2Controller.CoreWebView2;
				bool flag2 = coreWebView is global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Staging;
				if (flag2)
				{
					global::Microsoft.Web.WebView2.Core.CoreWebView2HostObjectHelper coreWebView2HostObjectHelper = new global::Microsoft.Web.WebView2.Core.CoreWebView2HostObjectHelper();
					global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Staging coreWebView2Staging = coreWebView as global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Staging;
					coreWebView2Staging.AddHostObjectHelper(coreWebView2HostObjectHelper._nativeICoreWebView2StagingHostObjectHelper);
				}
				else
				{
					global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 coreWebView2 = coreWebView;
					string name = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";
					object obj = new global::Microsoft.Web.WebView2.Core.HostObjectHelper();
					coreWebView2.AddHostObjectToScript(name, ref obj);
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002170 File Offset: 0x00000370
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller _nativeICoreWebView2Controller
		{
			get
			{
				bool flag = this._nativeICoreWebView2ControllerValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2ControllerValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2ControllerValue;
			}
			set
			{
				this._nativeICoreWebView2ControllerValue = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000217C File Offset: 0x0000037C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000021D8 File Offset: 0x000003D8
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2 _nativeICoreWebView2Controller2
		{
			get
			{
				bool flag = this._nativeICoreWebView2Controller2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Controller2Value;
			}
			set
			{
				this._nativeICoreWebView2Controller2Value = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000021E4 File Offset: 0x000003E4
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002240 File Offset: 0x00000440
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3 _nativeICoreWebView2Controller3
		{
			get
			{
				bool flag = this._nativeICoreWebView2Controller3Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller3Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Controller3Value;
			}
			set
			{
				this._nativeICoreWebView2Controller3Value = value;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000224A File Offset: 0x0000044A
		internal CoreWebView2Controller(object rawCoreWebView2Controller)
		{
			this._rawNative = rawCoreWebView2Controller;
			this.Initialize();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000226C File Offset: 0x0000046C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000022F0 File Offset: 0x000004F0
		public bool IsVisible
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2Controller.IsVisible != 0);
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
					this._nativeICoreWebView2Controller.IsVisible = (value ? 1 : 0);
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

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002374 File Offset: 0x00000574
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000023F8 File Offset: 0x000005F8
		public global::System.Drawing.Rectangle Bounds
		{
			get
			{
				global::System.Drawing.Rectangle result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleCOMToNet(this._nativeICoreWebView2Controller.Bounds);
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
					this._nativeICoreWebView2Controller.Bounds = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(value);
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

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000247C File Offset: 0x0000067C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000024FC File Offset: 0x000006FC
		public double ZoomFactor
		{
			get
			{
				double zoomFactor;
				try
				{
					zoomFactor = this._nativeICoreWebView2Controller.ZoomFactor;
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
				return zoomFactor;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.ZoomFactor = value;
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000257C File Offset: 0x0000077C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000025FC File Offset: 0x000007FC
		public global::System.IntPtr ParentWindow
		{
			get
			{
				global::System.IntPtr parentWindow;
				try
				{
					parentWindow = this._nativeICoreWebView2Controller.ParentWindow;
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
				return parentWindow;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller.ParentWindow = value;
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

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000012 RID: 18 RVA: 0x0000267C File Offset: 0x0000087C
		// (remove) Token: 0x06000013 RID: 19 RVA: 0x00002738 File Offset: 0x00000938
		public event global::System.EventHandler<object> ZoomFactorChanged
		{
			add
			{
				bool flag = this.zoomFactorChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_ZoomFactorChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2ZoomFactorChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2ZoomFactorChangedEventHandler.CallbackType(this.OnZoomFactorChanged)), out this._zoomFactorChangedToken);
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
				this.zoomFactorChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.zoomFactorChanged, value);
			}
			remove
			{
				this.zoomFactorChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.zoomFactorChanged, value);
				bool flag = this.zoomFactorChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_ZoomFactorChanged(this._zoomFactorChangedToken);
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

		// Token: 0x06000014 RID: 20 RVA: 0x000027E4 File Offset: 0x000009E4
		internal void OnZoomFactorChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.zoomFactorChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000015 RID: 21 RVA: 0x000027FC File Offset: 0x000009FC
		// (remove) Token: 0x06000016 RID: 22 RVA: 0x000028B8 File Offset: 0x00000AB8
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs> MoveFocusRequested
		{
			add
			{
				bool flag = this.moveFocusRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_MoveFocusRequested(new global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventHandler.CallbackType(this.OnMoveFocusRequested)), out this._moveFocusRequestedToken);
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
				this.moveFocusRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs>)global::System.Delegate.Combine(this.moveFocusRequested, value);
			}
			remove
			{
				this.moveFocusRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs>)global::System.Delegate.Remove(this.moveFocusRequested, value);
				bool flag = this.moveFocusRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_MoveFocusRequested(this._moveFocusRequestedToken);
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

		// Token: 0x06000017 RID: 23 RVA: 0x00002964 File Offset: 0x00000B64
		internal void OnMoveFocusRequested(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs> eventHandler = this.moveFocusRequested;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000018 RID: 24 RVA: 0x0000297C File Offset: 0x00000B7C
		// (remove) Token: 0x06000019 RID: 25 RVA: 0x00002A38 File Offset: 0x00000C38
		public event global::System.EventHandler<object> GotFocus
		{
			add
			{
				bool flag = this.gotFocus == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_GotFocus(new global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler.CallbackType(this.OnGotFocus)), out this._gotFocusToken);
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
				this.gotFocus = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.gotFocus, value);
			}
			remove
			{
				this.gotFocus = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.gotFocus, value);
				bool flag = this.gotFocus == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_GotFocus(this._gotFocusToken);
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

		// Token: 0x0600001A RID: 26 RVA: 0x00002AE4 File Offset: 0x00000CE4
		internal void OnGotFocus(object args)
		{
			global::System.EventHandler<object> eventHandler = this.gotFocus;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600001B RID: 27 RVA: 0x00002AFC File Offset: 0x00000CFC
		// (remove) Token: 0x0600001C RID: 28 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public event global::System.EventHandler<object> LostFocus
		{
			add
			{
				bool flag = this.lostFocus == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_LostFocus(new global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2FocusChangedEventHandler.CallbackType(this.OnLostFocus)), out this._lostFocusToken);
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
				this.lostFocus = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.lostFocus, value);
			}
			remove
			{
				this.lostFocus = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.lostFocus, value);
				bool flag = this.lostFocus == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_LostFocus(this._lostFocusToken);
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

		// Token: 0x0600001D RID: 29 RVA: 0x00002C64 File Offset: 0x00000E64
		internal void OnLostFocus(object args)
		{
			global::System.EventHandler<object> eventHandler = this.lostFocus;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600001E RID: 30 RVA: 0x00002C7C File Offset: 0x00000E7C
		// (remove) Token: 0x0600001F RID: 31 RVA: 0x00002D38 File Offset: 0x00000F38
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs> AcceleratorKeyPressed
		{
			add
			{
				bool flag = this.acceleratorKeyPressed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.add_AcceleratorKeyPressed(new global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventHandler.CallbackType(this.OnAcceleratorKeyPressed)), out this._acceleratorKeyPressedToken);
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
				this.acceleratorKeyPressed = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs>)global::System.Delegate.Combine(this.acceleratorKeyPressed, value);
			}
			remove
			{
				this.acceleratorKeyPressed = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs>)global::System.Delegate.Remove(this.acceleratorKeyPressed, value);
				bool flag = this.acceleratorKeyPressed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller.remove_AcceleratorKeyPressed(this._acceleratorKeyPressedToken);
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

		// Token: 0x06000020 RID: 32 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal void OnAcceleratorKeyPressed(global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs> eventHandler = this.acceleratorKeyPressed;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002DFC File Offset: 0x00000FFC
		public void SetBoundsAndZoomFactor(global::System.Drawing.Rectangle Bounds, double ZoomFactor)
		{
			try
			{
				this._nativeICoreWebView2Controller.SetBoundsAndZoomFactor(global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.RectangleNetToCOM(Bounds), ZoomFactor);
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

		// Token: 0x06000022 RID: 34 RVA: 0x00002E80 File Offset: 0x00001080
		public void MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason reason)
		{
			try
			{
				this._nativeICoreWebView2Controller.MoveFocus((global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_MOVE_FOCUS_REASON)reason);
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

		// Token: 0x06000023 RID: 35 RVA: 0x00002F00 File Offset: 0x00001100
		public void NotifyParentWindowPositionChanged()
		{
			try
			{
				this._nativeICoreWebView2Controller.NotifyParentWindowPositionChanged();
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

		// Token: 0x06000024 RID: 36 RVA: 0x00002F7C File Offset: 0x0000117C
		public void Close()
		{
			try
			{
				this._nativeICoreWebView2Controller.Close();
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002FF8 File Offset: 0x000011F8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000307C File Offset: 0x0000127C
		public global::System.Drawing.Color DefaultBackgroundColor
		{
			get
			{
				global::System.Drawing.Color result;
				try
				{
					result = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.ColorCOMToNet(this._nativeICoreWebView2Controller2.DefaultBackgroundColor);
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
					this._nativeICoreWebView2Controller2.DefaultBackgroundColor = global::Microsoft.Web.WebView2.Core.COMDotNetTypeConverter.ColorNetToCOM(value);
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

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003100 File Offset: 0x00001300
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00003180 File Offset: 0x00001380
		public double RasterizationScale
		{
			get
			{
				double rasterizationScale;
				try
				{
					rasterizationScale = this._nativeICoreWebView2Controller3.RasterizationScale;
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
				return rasterizationScale;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller3.RasterizationScale = value;
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

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003200 File Offset: 0x00001400
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00003284 File Offset: 0x00001484
		public bool ShouldDetectMonitorScaleChanges
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges != 0);
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
					this._nativeICoreWebView2Controller3.ShouldDetectMonitorScaleChanges = (value ? 1 : 0);
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003308 File Offset: 0x00001508
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00003388 File Offset: 0x00001588
		public global::Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode BoundsMode
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode boundsMode;
				try
				{
					boundsMode = (global::Microsoft.Web.WebView2.Core.CoreWebView2BoundsMode)this._nativeICoreWebView2Controller3.BoundsMode;
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
				return boundsMode;
			}
			set
			{
				try
				{
					this._nativeICoreWebView2Controller3.BoundsMode = (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_BOUNDS_MODE)value;
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

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600002D RID: 45 RVA: 0x00003408 File Offset: 0x00001608
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x000034C4 File Offset: 0x000016C4
		public event global::System.EventHandler<object> RasterizationScaleChanged
		{
			add
			{
				bool flag = this.rasterizationScaleChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller3.add_RasterizationScaleChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2RasterizationScaleChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2RasterizationScaleChangedEventHandler.CallbackType(this.OnRasterizationScaleChanged)), out this._rasterizationScaleChangedToken);
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
				this.rasterizationScaleChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.rasterizationScaleChanged, value);
			}
			remove
			{
				this.rasterizationScaleChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.rasterizationScaleChanged, value);
				bool flag = this.rasterizationScaleChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Controller3.remove_RasterizationScaleChanged(this._rasterizationScaleChangedToken);
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

		// Token: 0x0600002F RID: 47 RVA: 0x00003570 File Offset: 0x00001770
		internal void OnRasterizationScaleChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.rasterizationScaleChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x04000001 RID: 1
		private const string HostObjectHelperName = "{60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper";

		// Token: 0x04000002 RID: 2
		private global::Microsoft.Web.WebView2.Core.CoreWebView2 _coreWebView2 = null;

		// Token: 0x04000003 RID: 3
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller _nativeICoreWebView2ControllerValue;

		// Token: 0x04000004 RID: 4
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller2 _nativeICoreWebView2Controller2Value;

		// Token: 0x04000005 RID: 5
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Controller3 _nativeICoreWebView2Controller3Value;

		// Token: 0x04000006 RID: 6
		internal object _rawNative;

		// Token: 0x04000007 RID: 7
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _zoomFactorChangedToken;

		// Token: 0x04000008 RID: 8
		private global::System.EventHandler<object> zoomFactorChanged;

		// Token: 0x04000009 RID: 9
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _moveFocusRequestedToken;

		// Token: 0x0400000A RID: 10
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs> moveFocusRequested;

		// Token: 0x0400000B RID: 11
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _gotFocusToken;

		// Token: 0x0400000C RID: 12
		private global::System.EventHandler<object> gotFocus;

		// Token: 0x0400000D RID: 13
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _lostFocusToken;

		// Token: 0x0400000E RID: 14
		private global::System.EventHandler<object> lostFocus;

		// Token: 0x0400000F RID: 15
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _acceleratorKeyPressedToken;

		// Token: 0x04000010 RID: 16
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs> acceleratorKeyPressed;

		// Token: 0x04000011 RID: 17
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _rasterizationScaleChangedToken;

		// Token: 0x04000012 RID: 18
		private global::System.EventHandler<object> rasterizationScaleChanged;
	}
}
