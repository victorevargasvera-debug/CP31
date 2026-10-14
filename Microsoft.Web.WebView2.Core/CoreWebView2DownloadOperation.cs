using System;
using System.Runtime.InteropServices;
using Microsoft.Web.WebView2.Core.Raw;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000005 RID: 5
	public class CoreWebView2DownloadOperation
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004238 File Offset: 0x00002438
		public global::System.DateTime EstimatedEndTime
		{
			get
			{
				return global::System.DateTime.Parse(this._nativeICoreWebView2DownloadOperation.EstimatedEndTime);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000424C File Offset: 0x0000244C
		public ulong? TotalBytesToReceive
		{
			get
			{
				return (this._nativeICoreWebView2DownloadOperation.TotalBytesToReceive >= 0L) ? new ulong?((ulong)this._nativeICoreWebView2DownloadOperation.TotalBytesToReceive) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004284 File Offset: 0x00002484
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000042E0 File Offset: 0x000024E0
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperation
		{
			get
			{
				bool flag = this._nativeICoreWebView2DownloadOperationValue == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperationValue = (global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation)this._rawNative;
					}
					catch (global::System.Exception inner)
					{
						throw new global::System.NotImplementedException("Unable to cast to Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation.\nThis may happen if you are using an interface not supported by the version of the WebView2 Runtime you are using.\nFor instance, if you are using an experimental interface from an older SDK that has been modified or removed in a newer runtime.\nOr, if you are using a public interface from a newer SDK that wasn't implemented in an older runtime.\nFor more information about WebView2 versioning please visit the following: https://docs.microsoft.com/microsoft-edge/webview2/concepts/versioning", inner);
					}
				}
				return this._nativeICoreWebView2DownloadOperationValue;
			}
			set
			{
				this._nativeICoreWebView2DownloadOperationValue = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000042EA File Offset: 0x000024EA
		internal CoreWebView2DownloadOperation(object rawCoreWebView2DownloadOperation)
		{
			this._rawNative = rawCoreWebView2DownloadOperation;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000042FC File Offset: 0x000024FC
		public string Uri
		{
			get
			{
				string uri;
				try
				{
					uri = this._nativeICoreWebView2DownloadOperation.Uri;
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
				return uri;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000437C File Offset: 0x0000257C
		public string ContentDisposition
		{
			get
			{
				string contentDisposition;
				try
				{
					contentDisposition = this._nativeICoreWebView2DownloadOperation.ContentDisposition;
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
				return contentDisposition;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000043FC File Offset: 0x000025FC
		public string MimeType
		{
			get
			{
				string mimeType;
				try
				{
					mimeType = this._nativeICoreWebView2DownloadOperation.MimeType;
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
				return mimeType;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000447C File Offset: 0x0000267C
		public long BytesReceived
		{
			get
			{
				long bytesReceived;
				try
				{
					bytesReceived = this._nativeICoreWebView2DownloadOperation.BytesReceived;
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
				return bytesReceived;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000044FC File Offset: 0x000026FC
		public string ResultFilePath
		{
			get
			{
				string resultFilePath;
				try
				{
					resultFilePath = this._nativeICoreWebView2DownloadOperation.ResultFilePath;
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
				return resultFilePath;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000457C File Offset: 0x0000277C
		public global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadState State
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadState state;
				try
				{
					state = (global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadState)this._nativeICoreWebView2DownloadOperation.State;
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
				return state;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000045FC File Offset: 0x000027FC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadInterruptReason InterruptReason
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadInterruptReason interruptReason;
				try
				{
					interruptReason = (global::Microsoft.Web.WebView2.Core.CoreWebView2DownloadInterruptReason)this._nativeICoreWebView2DownloadOperation.InterruptReason;
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
				return interruptReason;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000467C File Offset: 0x0000287C
		public bool CanResume
		{
			get
			{
				bool result;
				try
				{
					result = (this._nativeICoreWebView2DownloadOperation.CanResume != 0);
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600005D RID: 93 RVA: 0x00004700 File Offset: 0x00002900
		// (remove) Token: 0x0600005E RID: 94 RVA: 0x000047BC File Offset: 0x000029BC
		public event global::System.EventHandler<object> BytesReceivedChanged
		{
			add
			{
				bool flag = this.bytesReceivedChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_BytesReceivedChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2BytesReceivedChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2BytesReceivedChangedEventHandler.CallbackType(this.OnBytesReceivedChanged)), out this._bytesReceivedChangedToken);
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
				this.bytesReceivedChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.bytesReceivedChanged, value);
			}
			remove
			{
				this.bytesReceivedChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.bytesReceivedChanged, value);
				bool flag = this.bytesReceivedChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_BytesReceivedChanged(this._bytesReceivedChangedToken);
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

		// Token: 0x0600005F RID: 95 RVA: 0x00004868 File Offset: 0x00002A68
		internal void OnBytesReceivedChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.bytesReceivedChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000060 RID: 96 RVA: 0x00004880 File Offset: 0x00002A80
		// (remove) Token: 0x06000061 RID: 97 RVA: 0x0000493C File Offset: 0x00002B3C
		public event global::System.EventHandler<object> EstimatedEndTimeChanged
		{
			add
			{
				bool flag = this.estimatedEndTimeChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_EstimatedEndTimeChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2EstimatedEndTimeChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2EstimatedEndTimeChangedEventHandler.CallbackType(this.OnEstimatedEndTimeChanged)), out this._estimatedEndTimeChangedToken);
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
				this.estimatedEndTimeChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.estimatedEndTimeChanged, value);
			}
			remove
			{
				this.estimatedEndTimeChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.estimatedEndTimeChanged, value);
				bool flag = this.estimatedEndTimeChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_EstimatedEndTimeChanged(this._estimatedEndTimeChangedToken);
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

		// Token: 0x06000062 RID: 98 RVA: 0x000049E8 File Offset: 0x00002BE8
		internal void OnEstimatedEndTimeChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.estimatedEndTimeChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000063 RID: 99 RVA: 0x00004A00 File Offset: 0x00002C00
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x00004ABC File Offset: 0x00002CBC
		public event global::System.EventHandler<object> StateChanged
		{
			add
			{
				bool flag = this.stateChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.add_StateChanged(new global::Microsoft.Web.WebView2.Core.CoreWebView2StateChangedEventHandler(new global::Microsoft.Web.WebView2.Core.CoreWebView2StateChangedEventHandler.CallbackType(this.OnStateChanged)), out this._stateChangedToken);
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
				this.stateChanged = (global::System.EventHandler<object>)global::System.Delegate.Combine(this.stateChanged, value);
			}
			remove
			{
				this.stateChanged = (global::System.EventHandler<object>)global::System.Delegate.Remove(this.stateChanged, value);
				bool flag = this.stateChanged == null;
				if (flag)
				{
					try
					{
						this._nativeICoreWebView2DownloadOperation.remove_StateChanged(this._stateChangedToken);
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

		// Token: 0x06000065 RID: 101 RVA: 0x00004B68 File Offset: 0x00002D68
		internal void OnStateChanged(object args)
		{
			global::System.EventHandler<object> eventHandler = this.stateChanged;
			if (eventHandler != null)
			{
				eventHandler(this, args);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004B80 File Offset: 0x00002D80
		public void Cancel()
		{
			try
			{
				this._nativeICoreWebView2DownloadOperation.Cancel();
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

		// Token: 0x06000067 RID: 103 RVA: 0x00004BFC File Offset: 0x00002DFC
		public void Pause()
		{
			try
			{
				this._nativeICoreWebView2DownloadOperation.Pause();
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

		// Token: 0x06000068 RID: 104 RVA: 0x00004C78 File Offset: 0x00002E78
		public void Resume()
		{
			try
			{
				this._nativeICoreWebView2DownloadOperation.Resume();
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

		// Token: 0x04000018 RID: 24
		internal global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2DownloadOperation _nativeICoreWebView2DownloadOperationValue;

		// Token: 0x04000019 RID: 25
		internal object _rawNative;

		// Token: 0x0400001A RID: 26
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _bytesReceivedChangedToken;

		// Token: 0x0400001B RID: 27
		private global::System.EventHandler<object> bytesReceivedChanged;

		// Token: 0x0400001C RID: 28
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _estimatedEndTimeChangedToken;

		// Token: 0x0400001D RID: 29
		private global::System.EventHandler<object> estimatedEndTimeChanged;

		// Token: 0x0400001E RID: 30
		private global::Microsoft.Web.WebView2.Core.Raw.EventRegistrationToken _stateChangedToken;

		// Token: 0x0400001F RID: 31
		private global::System.EventHandler<object> stateChanged;
	}
}
