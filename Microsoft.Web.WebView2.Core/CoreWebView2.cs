using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000042 RID: 66
	public class CoreWebView2
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000E39C File Offset: 0x0000C59C
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 _nativeICoreWebView2
		{
			get
			{
				bool flag = this._nativeICoreWebView2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2Value;
			}
			set
			{
				this._nativeICoreWebView2Value = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000E404 File Offset: 0x0000C604
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2 _nativeICoreWebView2_2
		{
			get
			{
				bool flag = this._nativeICoreWebView2_2Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_2Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2_2Value;
			}
			set
			{
				this._nativeICoreWebView2_2Value = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0000E410 File Offset: 0x0000C610
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000E46C File Offset: 0x0000C66C
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3 _nativeICoreWebView2_3
		{
			get
			{
				bool flag = this._nativeICoreWebView2_3Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_3Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2_3Value;
			}
			set
			{
				this._nativeICoreWebView2_3Value = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000E478 File Offset: 0x0000C678
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4 _nativeICoreWebView2_4
		{
			get
			{
				bool flag = this._nativeICoreWebView2_4Value == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_4Value = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2_4Value;
			}
			set
			{
				this._nativeICoreWebView2_4Value = value;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000E4DE File Offset: 0x0000C6DE
		internal CoreWebView2(object rawCoreWebView2)
		{
			this._rawNative = rawCoreWebView2;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Settings Settings
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2Settings result;
				try
				{
					result = ((this._nativeICoreWebView2.Settings == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2Settings(this._nativeICoreWebView2.Settings));
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

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000E584 File Offset: 0x0000C784
		public string Source
		{
			get
			{
				string source;
				try
				{
					source = this._nativeICoreWebView2.Source;
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000E604 File Offset: 0x0000C804
		public uint BrowserProcessId
		{
			get
			{
				uint browserProcessId;
				try
				{
					browserProcessId = this._nativeICoreWebView2.BrowserProcessId;
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
				return browserProcessId;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0000E684 File Offset: 0x0000C884
		public bool CanGoBack
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2.CanGoBack != 0);
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000E708 File Offset: 0x0000C908
		public bool CanGoForward
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2.CanGoForward != 0);
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

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000E78C File Offset: 0x0000C98C
		public string DocumentTitle
		{
			get
			{
				string documentTitle;
				try
				{
					documentTitle = this._nativeICoreWebView2.DocumentTitle;
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
				return documentTitle;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000223 RID: 547 RVA: 0x0000E80C File Offset: 0x0000CA0C
		public bool ContainsFullScreenElement
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2.ContainsFullScreenElement != 0);
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

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000224 RID: 548 RVA: 0x0000E890 File Offset: 0x0000CA90
		// (remove) Token: 0x06000225 RID: 549 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> NavigationStarting
		{
			add
			{
				bool flag = this.navigationStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_NavigationStarting(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler.CallbackType(this.OnNavigationStarting)), out this._navigationStartingToken);
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
				this.navigationStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>)global::System.Delegate.Combine(this.navigationStarting, value);
			}
			remove
			{
				this.navigationStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>)global::System.Delegate.Remove(this.navigationStarting, value);
				bool flag = this.navigationStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_NavigationStarting(this._navigationStartingToken);
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

		// Token: 0x06000226 RID: 550 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		internal void OnNavigationStarting(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> eventHandler = this.navigationStarting;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000227 RID: 551 RVA: 0x0000EA10 File Offset: 0x0000CC10
		// (remove) Token: 0x06000228 RID: 552 RVA: 0x0000EACC File Offset: 0x0000CCCC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> ContentLoading
		{
			add
			{
				bool flag = this.contentLoading == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_ContentLoading(new global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventHandler.CallbackType(this.OnContentLoading)), out this._contentLoadingToken);
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
				this.contentLoading = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>)global::System.Delegate.Combine(this.contentLoading, value);
			}
			remove
			{
				this.contentLoading = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>)global::System.Delegate.Remove(this.contentLoading, value);
				bool flag = this.contentLoading == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_ContentLoading(this._contentLoadingToken);
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

		// Token: 0x06000229 RID: 553 RVA: 0x0000EB78 File Offset: 0x0000CD78
		internal void OnContentLoading(global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> eventHandler = this.contentLoading;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600022A RID: 554 RVA: 0x0000EB90 File Offset: 0x0000CD90
		// (remove) Token: 0x0600022B RID: 555 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> SourceChanged
		{
			add
			{
				bool flag = this.sourceChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_SourceChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventHandler.CallbackType(this.OnSourceChanged)), out this._sourceChangedToken);
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
				this.sourceChanged = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>)global::System.Delegate.Combine(this.sourceChanged, value);
			}
			remove
			{
				this.sourceChanged = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>)global::System.Delegate.Remove(this.sourceChanged, value);
				bool flag = this.sourceChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_SourceChanged(this._sourceChangedToken);
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

		// Token: 0x0600022C RID: 556 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		internal void OnSourceChanged(global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> eventHandler = this.sourceChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600022D RID: 557 RVA: 0x0000ED10 File Offset: 0x0000CF10
		// (remove) Token: 0x0600022E RID: 558 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		public event global::System.EventHandler<object> HistoryChanged
		{
			add
			{
				bool flag = this.historyChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_HistoryChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2HistoryChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2HistoryChangedEventHandler.CallbackType(this.OnHistoryChanged)), out this._historyChangedToken);
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
				this.historyChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.historyChanged, value);
			}
			remove
			{
				this.historyChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.historyChanged, value);
				bool flag = this.historyChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_HistoryChanged(this._historyChangedToken);
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

		// Token: 0x0600022F RID: 559 RVA: 0x0000EE78 File Offset: 0x0000D078
		internal void OnHistoryChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.historyChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000230 RID: 560 RVA: 0x0000EE90 File Offset: 0x0000D090
		// (remove) Token: 0x06000231 RID: 561 RVA: 0x0000EF4C File Offset: 0x0000D14C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> NavigationCompleted
		{
			add
			{
				bool flag = this.navigationCompleted == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_NavigationCompleted(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler.CallbackType(this.OnNavigationCompleted)), out this._navigationCompletedToken);
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
				this.navigationCompleted = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>)global::System.Delegate.Combine(this.navigationCompleted, value);
			}
			remove
			{
				this.navigationCompleted = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>)global::System.Delegate.Remove(this.navigationCompleted, value);
				bool flag = this.navigationCompleted == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_NavigationCompleted(this._navigationCompletedToken);
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

		// Token: 0x06000232 RID: 562 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		internal void OnNavigationCompleted(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> eventHandler = this.navigationCompleted;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000233 RID: 563 RVA: 0x0000F010 File Offset: 0x0000D210
		// (remove) Token: 0x06000234 RID: 564 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> FrameNavigationStarting
		{
			add
			{
				bool flag = this.frameNavigationStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_FrameNavigationStarting(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventHandler.CallbackType(this.OnFrameNavigationStarting)), out this._frameNavigationStartingToken);
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
				this.frameNavigationStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>)global::System.Delegate.Combine(this.frameNavigationStarting, value);
			}
			remove
			{
				this.frameNavigationStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>)global::System.Delegate.Remove(this.frameNavigationStarting, value);
				bool flag = this.frameNavigationStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_FrameNavigationStarting(this._frameNavigationStartingToken);
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

		// Token: 0x06000235 RID: 565 RVA: 0x0000F178 File Offset: 0x0000D378
		internal void OnFrameNavigationStarting(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> eventHandler = this.frameNavigationStarting;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000236 RID: 566 RVA: 0x0000F190 File Offset: 0x0000D390
		// (remove) Token: 0x06000237 RID: 567 RVA: 0x0000F24C File Offset: 0x0000D44C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> FrameNavigationCompleted
		{
			add
			{
				bool flag = this.frameNavigationCompleted == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_FrameNavigationCompleted(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventHandler.CallbackType(this.OnFrameNavigationCompleted)), out this._frameNavigationCompletedToken);
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
				this.frameNavigationCompleted = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>)global::System.Delegate.Combine(this.frameNavigationCompleted, value);
			}
			remove
			{
				this.frameNavigationCompleted = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>)global::System.Delegate.Remove(this.frameNavigationCompleted, value);
				bool flag = this.frameNavigationCompleted == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_FrameNavigationCompleted(this._frameNavigationCompletedToken);
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

		// Token: 0x06000238 RID: 568 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		internal void OnFrameNavigationCompleted(global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> eventHandler = this.frameNavigationCompleted;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000239 RID: 569 RVA: 0x0000F310 File Offset: 0x0000D510
		// (remove) Token: 0x0600023A RID: 570 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs> ScriptDialogOpening
		{
			add
			{
				bool flag = this.scriptDialogOpening == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_ScriptDialogOpening(new global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventHandler.CallbackType(this.OnScriptDialogOpening)), out this._scriptDialogOpeningToken);
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
				this.scriptDialogOpening = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs>)global::System.Delegate.Combine(this.scriptDialogOpening, value);
			}
			remove
			{
				this.scriptDialogOpening = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs>)global::System.Delegate.Remove(this.scriptDialogOpening, value);
				bool flag = this.scriptDialogOpening == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_ScriptDialogOpening(this._scriptDialogOpeningToken);
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

		// Token: 0x0600023B RID: 571 RVA: 0x0000F478 File Offset: 0x0000D678
		internal void OnScriptDialogOpening(global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs> eventHandler = this.scriptDialogOpening;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600023C RID: 572 RVA: 0x0000F490 File Offset: 0x0000D690
		// (remove) Token: 0x0600023D RID: 573 RVA: 0x0000F54C File Offset: 0x0000D74C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs> PermissionRequested
		{
			add
			{
				bool flag = this.permissionRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_PermissionRequested(new global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventHandler.CallbackType(this.OnPermissionRequested)), out this._permissionRequestedToken);
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
				this.permissionRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs>)global::System.Delegate.Combine(this.permissionRequested, value);
			}
			remove
			{
				this.permissionRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs>)global::System.Delegate.Remove(this.permissionRequested, value);
				bool flag = this.permissionRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_PermissionRequested(this._permissionRequestedToken);
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

		// Token: 0x0600023E RID: 574 RVA: 0x0000F5F8 File Offset: 0x0000D7F8
		internal void OnPermissionRequested(global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs> eventHandler = this.permissionRequested;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600023F RID: 575 RVA: 0x0000F610 File Offset: 0x0000D810
		// (remove) Token: 0x06000240 RID: 576 RVA: 0x0000F6CC File Offset: 0x0000D8CC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs> ProcessFailed
		{
			add
			{
				bool flag = this.processFailed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_ProcessFailed(new global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventHandler.CallbackType(this.OnProcessFailed)), out this._processFailedToken);
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
				this.processFailed = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs>)global::System.Delegate.Combine(this.processFailed, value);
			}
			remove
			{
				this.processFailed = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs>)global::System.Delegate.Remove(this.processFailed, value);
				bool flag = this.processFailed == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_ProcessFailed(this._processFailedToken);
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

		// Token: 0x06000241 RID: 577 RVA: 0x0000F778 File Offset: 0x0000D978
		internal void OnProcessFailed(global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs> eventHandler = this.processFailed;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000242 RID: 578 RVA: 0x0000F790 File Offset: 0x0000D990
		// (remove) Token: 0x06000243 RID: 579 RVA: 0x0000F84C File Offset: 0x0000DA4C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived
		{
			add
			{
				bool flag = this.webMessageReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_WebMessageReceived(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventHandler.CallbackType(this.OnWebMessageReceived)), out this._webMessageReceivedToken);
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
				this.webMessageReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>)global::System.Delegate.Combine(this.webMessageReceived, value);
			}
			remove
			{
				this.webMessageReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs>)global::System.Delegate.Remove(this.webMessageReceived, value);
				bool flag = this.webMessageReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_WebMessageReceived(this._webMessageReceivedToken);
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

		// Token: 0x06000244 RID: 580 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
		internal void OnWebMessageReceived(global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> eventHandler = this.webMessageReceived;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000245 RID: 581 RVA: 0x0000F910 File Offset: 0x0000DB10
		// (remove) Token: 0x06000246 RID: 582 RVA: 0x0000F9CC File Offset: 0x0000DBCC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs> NewWindowRequested
		{
			add
			{
				bool flag = this.newWindowRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_NewWindowRequested(new global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventHandler.CallbackType(this.OnNewWindowRequested)), out this._newWindowRequestedToken);
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
				this.newWindowRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs>)global::System.Delegate.Combine(this.newWindowRequested, value);
			}
			remove
			{
				this.newWindowRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs>)global::System.Delegate.Remove(this.newWindowRequested, value);
				bool flag = this.newWindowRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_NewWindowRequested(this._newWindowRequestedToken);
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

		// Token: 0x06000247 RID: 583 RVA: 0x0000FA78 File Offset: 0x0000DC78
		internal void OnNewWindowRequested(global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs> eventHandler = this.newWindowRequested;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000248 RID: 584 RVA: 0x0000FA90 File Offset: 0x0000DC90
		// (remove) Token: 0x06000249 RID: 585 RVA: 0x0000FB4C File Offset: 0x0000DD4C
		public event global::System.EventHandler<object> DocumentTitleChanged
		{
			add
			{
				bool flag = this.documentTitleChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_DocumentTitleChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2DocumentTitleChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2DocumentTitleChangedEventHandler.CallbackType(this.OnDocumentTitleChanged)), out this._documentTitleChangedToken);
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
				this.documentTitleChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.documentTitleChanged, value);
			}
			remove
			{
				this.documentTitleChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.documentTitleChanged, value);
				bool flag = this.documentTitleChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_DocumentTitleChanged(this._documentTitleChangedToken);
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

		// Token: 0x0600024A RID: 586 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		internal void OnDocumentTitleChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.documentTitleChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x0600024B RID: 587 RVA: 0x0000FC10 File Offset: 0x0000DE10
		// (remove) Token: 0x0600024C RID: 588 RVA: 0x0000FCCC File Offset: 0x0000DECC
		public event global::System.EventHandler<object> ContainsFullScreenElementChanged
		{
			add
			{
				bool flag = this.containsFullScreenElementChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_ContainsFullScreenElementChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2ContainsFullScreenElementChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2ContainsFullScreenElementChangedEventHandler.CallbackType(this.OnContainsFullScreenElementChanged)), out this._containsFullScreenElementChangedToken);
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
				this.containsFullScreenElementChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.containsFullScreenElementChanged, value);
			}
			remove
			{
				this.containsFullScreenElementChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.containsFullScreenElementChanged, value);
				bool flag = this.containsFullScreenElementChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_ContainsFullScreenElementChanged(this._containsFullScreenElementChangedToken);
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

		// Token: 0x0600024D RID: 589 RVA: 0x0000FD78 File Offset: 0x0000DF78
		internal void OnContainsFullScreenElementChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.containsFullScreenElementChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x0600024E RID: 590 RVA: 0x0000FD90 File Offset: 0x0000DF90
		// (remove) Token: 0x0600024F RID: 591 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs> WebResourceRequested
		{
			add
			{
				bool flag = this.webResourceRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_WebResourceRequested(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventHandler.CallbackType(this.OnWebResourceRequested)), out this._webResourceRequestedToken);
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
				this.webResourceRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs>)global::System.Delegate.Combine(this.webResourceRequested, value);
			}
			remove
			{
				this.webResourceRequested = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs>)global::System.Delegate.Remove(this.webResourceRequested, value);
				bool flag = this.webResourceRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_WebResourceRequested(this._webResourceRequestedToken);
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

		// Token: 0x06000250 RID: 592 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		internal void OnWebResourceRequested(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs> eventHandler = this.webResourceRequested;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000251 RID: 593 RVA: 0x0000FF10 File Offset: 0x0000E110
		// (remove) Token: 0x06000252 RID: 594 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		public event global::System.EventHandler<object> WindowCloseRequested
		{
			add
			{
				bool flag = this.windowCloseRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.add_WindowCloseRequested(new global::Microsoft.Web.WebView2.Core.CoreWebView2WindowCloseRequestedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2WindowCloseRequestedEventHandler.CallbackType(this.OnWindowCloseRequested)), out this._windowCloseRequestedToken);
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
				this.windowCloseRequested = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.windowCloseRequested, value);
			}
			remove
			{
				this.windowCloseRequested = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.windowCloseRequested, value);
				bool flag = this.windowCloseRequested == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2.remove_WindowCloseRequested(this._windowCloseRequestedToken);
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

		// Token: 0x06000253 RID: 595 RVA: 0x00010078 File Offset: 0x0000E278
		internal void OnWindowCloseRequested(object args)
		{
			global::System.EventHandler<object> eventHandler = this.windowCloseRequested;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00010090 File Offset: 0x0000E290
		public void Navigate(string uri)
		{
			try
			{
				this._nativeICoreWebView2.Navigate(uri);
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

		// Token: 0x06000255 RID: 597 RVA: 0x00010110 File Offset: 0x0000E310
		public void NavigateToString(string htmlContent)
		{
			try
			{
				this._nativeICoreWebView2.NavigateToString(htmlContent);
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

		// Token: 0x06000256 RID: 598 RVA: 0x00010190 File Offset: 0x0000E390
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<string> AddScriptToExecuteOnDocumentCreatedAsync(string javaScript)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2.<AddScriptToExecuteOnDocumentCreatedAsync>d__131 <AddScriptToExecuteOnDocumentCreatedAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2.<AddScriptToExecuteOnDocumentCreatedAsync>d__131();
			<AddScriptToExecuteOnDocumentCreatedAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<AddScriptToExecuteOnDocumentCreatedAsync>d__.<>4__this = this;
			<AddScriptToExecuteOnDocumentCreatedAsync>d__.javaScript = javaScript;
			<AddScriptToExecuteOnDocumentCreatedAsync>d__.<>1__state = -1;
			<AddScriptToExecuteOnDocumentCreatedAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2.<AddScriptToExecuteOnDocumentCreatedAsync>d__131>(ref <AddScriptToExecuteOnDocumentCreatedAsync>d__);
			return <AddScriptToExecuteOnDocumentCreatedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000101DC File Offset: 0x0000E3DC
		public void RemoveScriptToExecuteOnDocumentCreated(string id)
		{
			try
			{
				this._nativeICoreWebView2.RemoveScriptToExecuteOnDocumentCreated(id);
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

		// Token: 0x06000258 RID: 600 RVA: 0x0001025C File Offset: 0x0000E45C
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<string> ExecuteScriptAsync(string javaScript)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2.<ExecuteScriptAsync>d__133 <ExecuteScriptAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2.<ExecuteScriptAsync>d__133();
			<ExecuteScriptAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<ExecuteScriptAsync>d__.<>4__this = this;
			<ExecuteScriptAsync>d__.javaScript = javaScript;
			<ExecuteScriptAsync>d__.<>1__state = -1;
			<ExecuteScriptAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2.<ExecuteScriptAsync>d__133>(ref <ExecuteScriptAsync>d__);
			return <ExecuteScriptAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task CapturePreviewAsync(global::Microsoft.Web.WebView2.Core.CoreWebView2CapturePreviewImageFormat imageFormat, global::System.IO.Stream imageStream)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2.<CapturePreviewAsync>d__134 <CapturePreviewAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2.<CapturePreviewAsync>d__134();
			<CapturePreviewAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<CapturePreviewAsync>d__.<>4__this = this;
			<CapturePreviewAsync>d__.imageFormat = imageFormat;
			<CapturePreviewAsync>d__.imageStream = imageStream;
			<CapturePreviewAsync>d__.<>1__state = -1;
			<CapturePreviewAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2.<CapturePreviewAsync>d__134>(ref <CapturePreviewAsync>d__);
			return <CapturePreviewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000102FC File Offset: 0x0000E4FC
		public void Reload()
		{
			try
			{
				this._nativeICoreWebView2.Reload();
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

		// Token: 0x0600025B RID: 603 RVA: 0x00010378 File Offset: 0x0000E578
		public void PostWebMessageAsJson(string webMessageAsJson)
		{
			try
			{
				this._nativeICoreWebView2.PostWebMessageAsJson(webMessageAsJson);
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

		// Token: 0x0600025C RID: 604 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public void PostWebMessageAsString(string webMessageAsString)
		{
			try
			{
				this._nativeICoreWebView2.PostWebMessageAsString(webMessageAsString);
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

		// Token: 0x0600025D RID: 605 RVA: 0x00010478 File Offset: 0x0000E678
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<string> CallDevToolsProtocolMethodAsync(string methodName, string parametersAsJson)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2.<CallDevToolsProtocolMethodAsync>d__138 <CallDevToolsProtocolMethodAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2.<CallDevToolsProtocolMethodAsync>d__138();
			<CallDevToolsProtocolMethodAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<CallDevToolsProtocolMethodAsync>d__.<>4__this = this;
			<CallDevToolsProtocolMethodAsync>d__.methodName = methodName;
			<CallDevToolsProtocolMethodAsync>d__.parametersAsJson = parametersAsJson;
			<CallDevToolsProtocolMethodAsync>d__.<>1__state = -1;
			<CallDevToolsProtocolMethodAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2.<CallDevToolsProtocolMethodAsync>d__138>(ref <CallDevToolsProtocolMethodAsync>d__);
			return <CallDevToolsProtocolMethodAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000104CC File Offset: 0x0000E6CC
		public void GoBack()
		{
			try
			{
				this._nativeICoreWebView2.GoBack();
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

		// Token: 0x0600025F RID: 607 RVA: 0x00010548 File Offset: 0x0000E748
		public void GoForward()
		{
			try
			{
				this._nativeICoreWebView2.GoForward();
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

		// Token: 0x06000260 RID: 608 RVA: 0x000105C4 File Offset: 0x0000E7C4
		public global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver(string eventName)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceiver result;
			try
			{
				result = new global::Microsoft.Web.WebView2.Core.CoreWebView2DevToolsProtocolEventReceiver(this._nativeICoreWebView2.GetDevToolsProtocolEventReceiver(eventName));
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

		// Token: 0x06000261 RID: 609 RVA: 0x00010648 File Offset: 0x0000E848
		public void Stop()
		{
			try
			{
				this._nativeICoreWebView2.Stop();
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

		// Token: 0x06000262 RID: 610 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public void AddHostObjectToScript(string name, object rawObject)
		{
			try
			{
				global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 nativeICoreWebView = this._nativeICoreWebView2;
				object obj = rawObject;
				nativeICoreWebView.AddHostObjectToScript(name, ref obj);
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

		// Token: 0x06000263 RID: 611 RVA: 0x00010748 File Offset: 0x0000E948
		public void RemoveHostObjectFromScript(string name)
		{
			try
			{
				this._nativeICoreWebView2.RemoveHostObjectFromScript(name);
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

		// Token: 0x06000264 RID: 612 RVA: 0x000107C8 File Offset: 0x0000E9C8
		public void OpenDevToolsWindow()
		{
			try
			{
				this._nativeICoreWebView2.OpenDevToolsWindow();
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

		// Token: 0x06000265 RID: 613 RVA: 0x00010844 File Offset: 0x0000EA44
		public void AddWebResourceRequestedFilter(string uri, global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext ResourceContext)
		{
			try
			{
				this._nativeICoreWebView2.AddWebResourceRequestedFilter(uri, (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

		// Token: 0x06000266 RID: 614 RVA: 0x000108C4 File Offset: 0x0000EAC4
		public void RemoveWebResourceRequestedFilter(string uri, global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceContext ResourceContext)
		{
			try
			{
				this._nativeICoreWebView2.RemoveWebResourceRequestedFilter(uri, (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_WEB_RESOURCE_CONTEXT)ResourceContext);
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

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00010944 File Offset: 0x0000EB44
		public global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager CookieManager
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager result;
				try
				{
					result = ((this._nativeICoreWebView2_2.CookieManager == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2CookieManager(this._nativeICoreWebView2_2.CookieManager));
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000109D8 File Offset: 0x0000EBD8
		public global::Microsoft.Web.WebView2.Core.CoreWebView2Environment Environment
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2Environment result;
				try
				{
					result = ((this._nativeICoreWebView2_2.Environment == null) ? null : new global::Microsoft.Web.WebView2.Core.CoreWebView2Environment(this._nativeICoreWebView2_2.Environment));
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

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000269 RID: 617 RVA: 0x00010A6C File Offset: 0x0000EC6C
		// (remove) Token: 0x0600026A RID: 618 RVA: 0x00010B28 File Offset: 0x0000ED28
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs> WebResourceResponseReceived
		{
			add
			{
				bool flag = this.webResourceResponseReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_2.add_WebResourceResponseReceived(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventHandler.CallbackType(this.OnWebResourceResponseReceived)), out this._webResourceResponseReceivedToken);
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
				this.webResourceResponseReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs>)global::System.Delegate.Combine(this.webResourceResponseReceived, value);
			}
			remove
			{
				this.webResourceResponseReceived = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs>)global::System.Delegate.Remove(this.webResourceResponseReceived, value);
				bool flag = this.webResourceResponseReceived == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_2.remove_WebResourceResponseReceived(this._webResourceResponseReceivedToken);
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

		// Token: 0x0600026B RID: 619 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		internal void OnWebResourceResponseReceived(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs> eventHandler = this.webResourceResponseReceived;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600026C RID: 620 RVA: 0x00010BEC File Offset: 0x0000EDEC
		// (remove) Token: 0x0600026D RID: 621 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs> DOMContentLoaded
		{
			add
			{
				bool flag = this.dOMContentLoaded == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_2.add_DOMContentLoaded(new global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventHandler.CallbackType(this.OnDOMContentLoaded)), out this._dOMContentLoadedToken);
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
				this.dOMContentLoaded = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs>)global::System.Delegate.Combine(this.dOMContentLoaded, value);
			}
			remove
			{
				this.dOMContentLoaded = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs>)global::System.Delegate.Remove(this.dOMContentLoaded, value);
				bool flag = this.dOMContentLoaded == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_2.remove_DOMContentLoaded(this._dOMContentLoadedToken);
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

		// Token: 0x0600026E RID: 622 RVA: 0x00010D54 File Offset: 0x0000EF54
		internal void OnDOMContentLoaded(global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs> eventHandler = this.dOMContentLoaded;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00010D6C File Offset: 0x0000EF6C
		public void NavigateWithWebResourceRequest(global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequest Request)
		{
			try
			{
				this._nativeICoreWebView2_2.NavigateWithWebResourceRequest(Request._nativeICoreWebView2WebResourceRequest);
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public bool IsSuspended
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2_3.IsSuspended != 0);
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

		// Token: 0x06000271 RID: 625 RVA: 0x00010E74 File Offset: 0x0000F074
		[global::System.Diagnostics.DebuggerStepThrough]
		public global::System.Threading.Tasks.Task<bool> TrySuspendAsync()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2.<TrySuspendAsync>d__167 <TrySuspendAsync>d__ = new global::Microsoft.Web.WebView2.Core.CoreWebView2.<TrySuspendAsync>d__167();
			<TrySuspendAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<TrySuspendAsync>d__.<>4__this = this;
			<TrySuspendAsync>d__.<>1__state = -1;
			<TrySuspendAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Core.CoreWebView2.<TrySuspendAsync>d__167>(ref <TrySuspendAsync>d__);
			return <TrySuspendAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00010EB8 File Offset: 0x0000F0B8
		public void Resume()
		{
			try
			{
				this._nativeICoreWebView2_3.Resume();
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

		// Token: 0x06000273 RID: 627 RVA: 0x00010F34 File Offset: 0x0000F134
		public void SetVirtualHostNameToFolderMapping(string hostName, string folderPath, global::Microsoft.Web.WebView2.Core.CoreWebView2HostResourceAccessKind accessKind)
		{
			try
			{
				this._nativeICoreWebView2_3.SetVirtualHostNameToFolderMapping(hostName, folderPath, (global::Microsoft.Web.WebView2.Core.Raw.COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND)accessKind);
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

		// Token: 0x06000274 RID: 628 RVA: 0x00010FB4 File Offset: 0x0000F1B4
		public void ClearVirtualHostNameToFolderMapping(string hostName)
		{
			try
			{
				this._nativeICoreWebView2_3.ClearVirtualHostNameToFolderMapping(hostName);
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

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000275 RID: 629 RVA: 0x00011034 File Offset: 0x0000F234
		// (remove) Token: 0x06000276 RID: 630 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs> FrameCreated
		{
			add
			{
				bool flag = this.frameCreated == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_4.add_FrameCreated(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventHandler.CallbackType(this.OnFrameCreated)), out this._frameCreatedToken);
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
				this.frameCreated = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs>)global::System.Delegate.Combine(this.frameCreated, value);
			}
			remove
			{
				this.frameCreated = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs>)global::System.Delegate.Remove(this.frameCreated, value);
				bool flag = this.frameCreated == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_4.remove_FrameCreated(this._frameCreatedToken);
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

		// Token: 0x06000277 RID: 631 RVA: 0x0001119C File Offset: 0x0000F39C
		internal void OnFrameCreated(global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs> eventHandler = this.frameCreated;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000278 RID: 632 RVA: 0x000111B4 File Offset: 0x0000F3B4
		// (remove) Token: 0x06000279 RID: 633 RVA: 0x00011270 File Offset: 0x0000F470
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs> DownloadStarting
		{
			add
			{
				bool flag = this.downloadStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_4.add_DownloadStarting(new global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventHandler.CallbackType(this.OnDownloadStarting)), out this._downloadStartingToken);
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
				this.downloadStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs>)global::System.Delegate.Combine(this.downloadStarting, value);
			}
			remove
			{
				this.downloadStarting = (global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs>)global::System.Delegate.Remove(this.downloadStarting, value);
				bool flag = this.downloadStarting == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2_4.remove_DownloadStarting(this._downloadStartingToken);
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

		// Token: 0x0600027A RID: 634 RVA: 0x0001131C File Offset: 0x0000F51C
		internal void OnDownloadStarting(global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs args)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs> eventHandler = this.downloadStarting;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x04000136 RID: 310
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2 _nativeICoreWebView2Value;

		// Token: 0x04000137 RID: 311
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_2 _nativeICoreWebView2_2Value;

		// Token: 0x04000138 RID: 312
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_3 _nativeICoreWebView2_3Value;

		// Token: 0x04000139 RID: 313
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2_4 _nativeICoreWebView2_4Value;

		// Token: 0x0400013A RID: 314
		internal object _rawNative;

		// Token: 0x0400013B RID: 315
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _navigationStartingToken;

		// Token: 0x0400013C RID: 316
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> navigationStarting;

		// Token: 0x0400013D RID: 317
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _contentLoadingToken;

		// Token: 0x0400013E RID: 318
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> contentLoading;

		// Token: 0x0400013F RID: 319
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _sourceChangedToken;

		// Token: 0x04000140 RID: 320
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> sourceChanged;

		// Token: 0x04000141 RID: 321
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _historyChangedToken;

		// Token: 0x04000142 RID: 322
		private global::System.EventHandler<object> historyChanged;

		// Token: 0x04000143 RID: 323
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _navigationCompletedToken;

		// Token: 0x04000144 RID: 324
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> navigationCompleted;

		// Token: 0x04000145 RID: 325
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _frameNavigationStartingToken;

		// Token: 0x04000146 RID: 326
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> frameNavigationStarting;

		// Token: 0x04000147 RID: 327
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _frameNavigationCompletedToken;

		// Token: 0x04000148 RID: 328
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> frameNavigationCompleted;

		// Token: 0x04000149 RID: 329
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _scriptDialogOpeningToken;

		// Token: 0x0400014A RID: 330
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ScriptDialogOpeningEventArgs> scriptDialogOpening;

		// Token: 0x0400014B RID: 331
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _permissionRequestedToken;

		// Token: 0x0400014C RID: 332
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2PermissionRequestedEventArgs> permissionRequested;

		// Token: 0x0400014D RID: 333
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _processFailedToken;

		// Token: 0x0400014E RID: 334
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs> processFailed;

		// Token: 0x0400014F RID: 335
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _webMessageReceivedToken;

		// Token: 0x04000150 RID: 336
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> webMessageReceived;

		// Token: 0x04000151 RID: 337
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _newWindowRequestedToken;

		// Token: 0x04000152 RID: 338
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs> newWindowRequested;

		// Token: 0x04000153 RID: 339
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _documentTitleChangedToken;

		// Token: 0x04000154 RID: 340
		private global::System.EventHandler<object> documentTitleChanged;

		// Token: 0x04000155 RID: 341
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _containsFullScreenElementChangedToken;

		// Token: 0x04000156 RID: 342
		private global::System.EventHandler<object> containsFullScreenElementChanged;

		// Token: 0x04000157 RID: 343
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _webResourceRequestedToken;

		// Token: 0x04000158 RID: 344
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceRequestedEventArgs> webResourceRequested;

		// Token: 0x04000159 RID: 345
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _windowCloseRequestedToken;

		// Token: 0x0400015A RID: 346
		private global::System.EventHandler<object> windowCloseRequested;

		// Token: 0x0400015B RID: 347
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _webResourceResponseReceivedToken;

		// Token: 0x0400015C RID: 348
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebResourceResponseReceivedEventArgs> webResourceResponseReceived;

		// Token: 0x0400015D RID: 349
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _dOMContentLoadedToken;

		// Token: 0x0400015E RID: 350
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs> dOMContentLoaded;

		// Token: 0x0400015F RID: 351
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _frameCreatedToken;

		// Token: 0x04000160 RID: 352
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2FrameCreatedEventArgs> frameCreated;

		// Token: 0x04000161 RID: 353
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _downloadStartingToken;

		// Token: 0x04000162 RID: 354
		private global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadStartingEventArgs> downloadStarting;
	}
}
