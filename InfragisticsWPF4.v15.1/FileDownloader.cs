using System;
using System.Net;
using System.Threading;

namespace Infragistics
{
	// Token: 0x02000044 RID: 68
	internal class FileDownloader
	{
		// Token: 0x060002AF RID: 687 RVA: 0x0000B6DB File Offset: 0x000098DB
		internal FileDownloader(string uri, global::System.Threading.CancellationTokenSource cancellationTokenSource = null) : this((uri != null) ? new global::System.Uri(uri, global::System.UriKind.RelativeOrAbsolute) : null, cancellationTokenSource)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000B6F1 File Offset: 0x000098F1
		internal FileDownloader(global::System.Uri uri, global::System.Threading.CancellationTokenSource cancellationTokenSource = null)
		{
			if (uri == null)
			{
				throw new global::System.ArgumentNullException("uri");
			}
			this._uri = uri;
			this._cancellationTokenSource = cancellationTokenSource;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000B71B File Offset: 0x0000991B
		internal byte[] DownloadedData
		{
			get
			{
				return this._downloadedData;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000B723 File Offset: 0x00009923
		internal global::System.Exception Error
		{
			get
			{
				return this._error;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000B72B File Offset: 0x0000992B
		internal global::Infragistics.FileDownloadStatus Status
		{
			get
			{
				return this._status;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000B733 File Offset: 0x00009933
		internal global::System.Uri Uri
		{
			get
			{
				return this._uri;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000B750 File Offset: 0x00009950
		public void DownloadData(int millisecondsTimeout = -1)
		{
			global::System.Threading.ManualResetEventSlim resetEvent = new global::System.Threading.ManualResetEventSlim();
			this.BeginDownload(delegate(global::Infragistics.FileDownloader f)
			{
				resetEvent.Set();
			}, millisecondsTimeout);
			if (!resetEvent.Wait(millisecondsTimeout))
			{
				this._request = null;
				if (this._status == global::Infragistics.FileDownloadStatus.Downloading)
				{
					this._status = global::Infragistics.FileDownloadStatus.TimedOut;
					this._error = new global::System.TimeoutException(string.Format("Download of '{0}' timed out at {1} seconds", this._uri.ToString(), global::System.Math.Ceiling((double)millisecondsTimeout / 1000.0)));
				}
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000B7DC File Offset: 0x000099DC
		public void DownloadDataAsync(global::System.Action<global::Infragistics.FileDownloader> completedCallback, int millisecondsTimeout = -1)
		{
			this._syncContext = global::System.Threading.SynchronizationContext.Current;
			this.BeginDownload(completedCallback, millisecondsTimeout);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000B7F1 File Offset: 0x000099F1
		protected virtual void OnDownloadCompleted()
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000B914 File Offset: 0x00009B14
		private void BeginDownload(global::System.Action<global::Infragistics.FileDownloader> completedCallback, int millisecondsTimeout)
		{
			if (this._status != global::Infragistics.FileDownloadStatus.NotStarted && this._status != global::Infragistics.FileDownloadStatus.TimedOut)
			{
				throw new global::System.InvalidOperationException("Download already started");
			}
			if (this._request != null)
			{
				throw new global::System.InvalidOperationException("Download already started");
			}
			this._status = global::Infragistics.FileDownloadStatus.Downloading;
			global::System.Threading.CancellationTokenSource cancellationTokenSource = this._cancellationTokenSource ?? new global::System.Threading.CancellationTokenSource();
			global::System.Threading.CancellationToken token = cancellationTokenSource.Token;
			if (token.IsCancellationRequested)
			{
				this._status = global::Infragistics.FileDownloadStatus.Canceled;
				this.ProcessCompleted(completedCallback);
				return;
			}
			try
			{
				this._request = global::System.Net.WebRequest.Create(this._uri);
				if (this._request == null)
				{
					this._status = global::Infragistics.FileDownloadStatus.Failed;
					this._error = new global::System.Exception("Could not create WebRequest");
					this.ProcessCompleted(completedCallback);
					return;
				}
			}
			catch (global::System.Exception error)
			{
				this._status = global::Infragistics.FileDownloadStatus.Failed;
				this._error = error;
				this.ProcessCompleted(completedCallback);
				return;
			}
			this._request.Timeout = millisecondsTimeout;
			token.Register(delegate()
			{
				try
				{
					if (this._request != null)
					{
						this._request.Abort();
					}
				}
				catch (global::System.Exception)
				{
				}
			});
			try
			{
				this._request.BeginGetResponse(delegate(global::System.IAsyncResult r)
				{
					try
					{
						if (this._request != null)
						{
							if (token.IsCancellationRequested)
							{
								this._request = null;
								this._status = global::Infragistics.FileDownloadStatus.Canceled;
							}
							else
							{
								using (global::System.Net.WebResponse webResponse = this._request.EndGetResponse(r))
								{
									this._request = null;
									this._downloadedData = global::Infragistics.CoreUtilities.ReadData(webResponse.GetResponseStream());
									this._status = global::Infragistics.FileDownloadStatus.Complete;
								}
							}
							this.ProcessCompleted(completedCallback);
						}
					}
					catch (global::System.Exception e2)
					{
						this.ProcessException(completedCallback, token, e2);
					}
				}, null);
			}
			catch (global::System.Exception e)
			{
				this.ProcessException(completedCallback, token, e);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BA8C File Offset: 0x00009C8C
		private void ProcessCompleted(global::System.Action<global::Infragistics.FileDownloader> completedCallback)
		{
			if (this._syncContext != null)
			{
				this._syncContext.Send(new global::System.Threading.SendOrPostCallback(this.NotifyCompleted), completedCallback);
				return;
			}
			this.NotifyCompleted(completedCallback);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000BAB6 File Offset: 0x00009CB6
		private void NotifyCompleted(object completedCallback)
		{
			this.OnDownloadCompleted();
			if (completedCallback != null)
			{
				((global::System.Action<global::Infragistics.FileDownloader>)completedCallback)(this);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BACD File Offset: 0x00009CCD
		private global::System.Threading.CancellationToken ProcessException(global::System.Action<global::Infragistics.FileDownloader> completedCallback, global::System.Threading.CancellationToken token, global::System.Exception e)
		{
			this._request = null;
			if (token.IsCancellationRequested)
			{
				this._status = global::Infragistics.FileDownloadStatus.Canceled;
			}
			else
			{
				this._error = e;
				this._status = global::Infragistics.FileDownloadStatus.Failed;
			}
			this.ProcessCompleted(completedCallback);
			return token;
		}

		// Token: 0x040000D1 RID: 209
		private global::System.Uri _uri;

		// Token: 0x040000D2 RID: 210
		private global::Infragistics.FileDownloadStatus _status;

		// Token: 0x040000D3 RID: 211
		private byte[] _downloadedData;

		// Token: 0x040000D4 RID: 212
		private global::System.Exception _error;

		// Token: 0x040000D5 RID: 213
		private global::System.Threading.CancellationTokenSource _cancellationTokenSource;

		// Token: 0x040000D6 RID: 214
		private global::System.Net.WebRequest _request;

		// Token: 0x040000D7 RID: 215
		private global::System.Threading.SynchronizationContext _syncContext;
	}
}
