using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000008 RID: 8
	public class CoreWebView2Frame
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00005928 File Offset: 0x00003B28
		public void AddHostObjectToScript(string name, object rawObject, global::System.Collections.Generic.IEnumerable<string> origins)
		{
			global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame nativeICoreWebView2Frame = this._nativeICoreWebView2Frame;
			object obj = rawObject;
			nativeICoreWebView2Frame.AddHostObjectToScriptWithOrigins(name, ref obj, (uint)origins.Count<string>(), (from origin in origins
			select origin).ToArray<string>());
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00005978 File Offset: 0x00003B78
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000059D4 File Offset: 0x00003BD4
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame _nativeICoreWebView2Frame
		{
			get
			{
				bool flag = this._nativeICoreWebView2FrameValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2FrameValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2FrameValue;
			}
			set
			{
				this._nativeICoreWebView2FrameValue = value;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000059DE File Offset: 0x00003BDE
		internal CoreWebView2Frame(object rawCoreWebView2Frame)
		{
			this._rawNative = rawCoreWebView2Frame;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000059F0 File Offset: 0x00003BF0
		public string Name
		{
			get
			{
				string name;
				try
				{
					name = this._nativeICoreWebView2Frame.Name;
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

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000096 RID: 150 RVA: 0x00005A70 File Offset: 0x00003C70
		// (remove) Token: 0x06000097 RID: 151 RVA: 0x00005B2C File Offset: 0x00003D2C
		public event global::System.EventHandler<object> NameChanged
		{
			add
			{
				bool flag = this.nameChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Frame.add_NameChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameNameChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameNameChangedEventHandler.CallbackType(this.OnNameChanged)), out this._nameChangedToken);
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
				this.nameChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.nameChanged, value);
			}
			remove
			{
				this.nameChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.nameChanged, value);
				bool flag = this.nameChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Frame.remove_NameChanged(this._nameChangedToken);
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

		// Token: 0x06000098 RID: 152 RVA: 0x00005BD8 File Offset: 0x00003DD8
		internal void OnNameChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.nameChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000099 RID: 153 RVA: 0x00005BF0 File Offset: 0x00003DF0
		// (remove) Token: 0x0600009A RID: 154 RVA: 0x00005CAC File Offset: 0x00003EAC
		public event global::System.EventHandler<object> Destroyed
		{
			add
			{
				bool flag = this.destroyed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Frame.add_Destroyed(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameDestroyedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameDestroyedEventHandler.CallbackType(this.OnDestroyed)), out this._destroyedToken);
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
				this.destroyed = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.destroyed, value);
			}
			remove
			{
				this.destroyed = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.destroyed, value);
				bool flag = this.destroyed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Frame.remove_Destroyed(this._destroyedToken);
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

		// Token: 0x0600009B RID: 155 RVA: 0x00005D58 File Offset: 0x00003F58
		internal void OnDestroyed(object args)
		{
			global::System.EventHandler<object> eventHandler = this.destroyed;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005D70 File Offset: 0x00003F70
		public void RemoveHostObjectFromScript(string name)
		{
			try
			{
				this._nativeICoreWebView2Frame.RemoveHostObjectFromScript(name);
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

		// Token: 0x0600009D RID: 157 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public int IsDestroyed()
		{
			int result;
			try
			{
				result = this._nativeICoreWebView2Frame.IsDestroyed();
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

		// Token: 0x0400002A RID: 42
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2Frame _nativeICoreWebView2FrameValue;

		// Token: 0x0400002B RID: 43
		internal object _rawNative;

		// Token: 0x0400002C RID: 44
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _nameChangedToken;

		// Token: 0x0400002D RID: 45
		private global::System.EventHandler<object> nameChanged;

		// Token: 0x0400002E RID: 46
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _destroyedToken;

		// Token: 0x0400002F RID: 47
		private global::System.EventHandler<object> destroyed;
	}
}
