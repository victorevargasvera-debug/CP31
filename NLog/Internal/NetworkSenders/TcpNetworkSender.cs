using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using NLog.Common;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x0200013A RID: 314
	internal class TcpNetworkSender : global::NLog.Internal.NetworkSenders.NetworkSender
	{
		// Token: 0x06000E19 RID: 3609 RVA: 0x00023B03 File Offset: 0x00021D03
		public TcpNetworkSender(string url, global::System.Net.Sockets.AddressFamily addressFamily) : base(url)
		{
			this.AddressFamily = addressFamily;
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00023B1E File Offset: 0x00021D1E
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00023B26 File Offset: 0x00021D26
		internal global::System.Net.Sockets.AddressFamily AddressFamily { get; set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00023B2F File Offset: 0x00021D2F
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00023B37 File Offset: 0x00021D37
		internal int MaxQueueSize { get; set; }

		// Token: 0x06000E1E RID: 3614 RVA: 0x00023B40 File Offset: 0x00021D40
		protected internal virtual global::NLog.Internal.NetworkSenders.ISocket CreateSocket(global::System.Net.Sockets.AddressFamily addressFamily, global::System.Net.Sockets.SocketType socketType, global::System.Net.Sockets.ProtocolType protocolType)
		{
			return new global::NLog.Internal.NetworkSenders.SocketProxy(addressFamily, socketType, protocolType);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00023B4C File Offset: 0x00021D4C
		protected override void DoInitialize()
		{
			global::NLog.Internal.NetworkSenders.TcpNetworkSender.MySocketAsyncEventArgs mySocketAsyncEventArgs = new global::NLog.Internal.NetworkSenders.TcpNetworkSender.MySocketAsyncEventArgs();
			mySocketAsyncEventArgs.RemoteEndPoint = this.ParseEndpointAddress(new global::System.Uri(base.Address), this.AddressFamily);
			mySocketAsyncEventArgs.Completed += this.SocketOperationCompleted;
			mySocketAsyncEventArgs.UserToken = null;
			this._socket = this.CreateSocket(mySocketAsyncEventArgs.RemoteEndPoint.AddressFamily, global::System.Net.Sockets.SocketType.Stream, global::System.Net.Sockets.ProtocolType.Tcp);
			this._asyncOperationInProgress = true;
			if (!this._socket.ConnectAsync(mySocketAsyncEventArgs))
			{
				this.SocketOperationCompleted(this._socket, mySocketAsyncEventArgs);
			}
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00023BD0 File Offset: 0x00021DD0
		protected override void DoClose(global::NLog.Common.AsyncContinuation continuation)
		{
			lock (this)
			{
				if (this._asyncOperationInProgress)
				{
					this._closeContinuation = continuation;
				}
				else
				{
					this.CloseSocket(continuation);
				}
			}
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00023C20 File Offset: 0x00021E20
		protected override void DoFlush(global::NLog.Common.AsyncContinuation continuation)
		{
			lock (this)
			{
				if (!this._asyncOperationInProgress && this._pendingRequests.Count == 0)
				{
					continuation(null);
				}
				else
				{
					this._flushContinuation = continuation;
				}
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00023C7C File Offset: 0x00021E7C
		protected override void DoSend(byte[] bytes, int offset, int length, global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::NLog.Internal.NetworkSenders.TcpNetworkSender.MySocketAsyncEventArgs mySocketAsyncEventArgs = new global::NLog.Internal.NetworkSenders.TcpNetworkSender.MySocketAsyncEventArgs();
			mySocketAsyncEventArgs.SetBuffer(bytes, offset, length);
			mySocketAsyncEventArgs.UserToken = asyncContinuation;
			mySocketAsyncEventArgs.Completed += this.SocketOperationCompleted;
			lock (this)
			{
				if (this.MaxQueueSize != 0 && this._pendingRequests.Count >= this.MaxQueueSize)
				{
					global::System.Net.Sockets.SocketAsyncEventArgs socketAsyncEventArgs = this._pendingRequests.Dequeue();
					if (socketAsyncEventArgs != null)
					{
						socketAsyncEventArgs.Dispose();
					}
				}
				this._pendingRequests.Enqueue(mySocketAsyncEventArgs);
			}
			this.ProcessNextQueuedItem();
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00023D1C File Offset: 0x00021F1C
		private void CloseSocket(global::NLog.Common.AsyncContinuation continuation)
		{
			try
			{
				global::NLog.Internal.NetworkSenders.ISocket socket = this._socket;
				this._socket = null;
				if (socket != null)
				{
					socket.Close();
				}
				continuation(null);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				continuation(exception);
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00023D70 File Offset: 0x00021F70
		private void SocketOperationCompleted(object sender, global::System.Net.Sockets.SocketAsyncEventArgs e)
		{
			lock (this)
			{
				this._asyncOperationInProgress = false;
				global::NLog.Common.AsyncContinuation asyncContinuation = e.UserToken as global::NLog.Common.AsyncContinuation;
				if (e.SocketError != global::System.Net.Sockets.SocketError.Success)
				{
					this._pendingError = new global::System.IO.IOException("Error: " + e.SocketError);
				}
				e.Dispose();
				if (asyncContinuation != null)
				{
					asyncContinuation(this._pendingError);
				}
			}
			this.ProcessNextQueuedItem();
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00023DFC File Offset: 0x00021FFC
		private void ProcessNextQueuedItem()
		{
			lock (this)
			{
				if (!this._asyncOperationInProgress)
				{
					if (this._pendingError != null)
					{
						while (this._pendingRequests.Count != 0)
						{
							global::System.Net.Sockets.SocketAsyncEventArgs socketAsyncEventArgs = this._pendingRequests.Dequeue();
							global::NLog.Common.AsyncContinuation asyncContinuation = (global::NLog.Common.AsyncContinuation)socketAsyncEventArgs.UserToken;
							socketAsyncEventArgs.Dispose();
							asyncContinuation(this._pendingError);
						}
					}
					if (this._pendingRequests.Count == 0)
					{
						global::NLog.Common.AsyncContinuation flushContinuation = this._flushContinuation;
						if (flushContinuation != null)
						{
							this._flushContinuation = null;
							flushContinuation(this._pendingError);
						}
						global::NLog.Common.AsyncContinuation closeContinuation = this._closeContinuation;
						if (closeContinuation != null)
						{
							this._closeContinuation = null;
							this.CloseSocket(closeContinuation);
						}
					}
					else
					{
						global::System.Net.Sockets.SocketAsyncEventArgs socketAsyncEventArgs = this._pendingRequests.Dequeue();
						this._asyncOperationInProgress = true;
						if (!this._socket.SendAsync(socketAsyncEventArgs))
						{
							this.SocketOperationCompleted(this._socket, socketAsyncEventArgs);
						}
					}
				}
			}
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00023EF4 File Offset: 0x000220F4
		public override void CheckSocket()
		{
			if (this._socket == null)
			{
				this.DoInitialize();
			}
		}

		// Token: 0x040003E2 RID: 994
		private readonly global::System.Collections.Generic.Queue<global::System.Net.Sockets.SocketAsyncEventArgs> _pendingRequests = new global::System.Collections.Generic.Queue<global::System.Net.Sockets.SocketAsyncEventArgs>();

		// Token: 0x040003E3 RID: 995
		private global::NLog.Internal.NetworkSenders.ISocket _socket;

		// Token: 0x040003E4 RID: 996
		private global::System.Exception _pendingError;

		// Token: 0x040003E5 RID: 997
		private bool _asyncOperationInProgress;

		// Token: 0x040003E6 RID: 998
		private global::NLog.Common.AsyncContinuation _closeContinuation;

		// Token: 0x040003E7 RID: 999
		private global::NLog.Common.AsyncContinuation _flushContinuation;

		// Token: 0x02000225 RID: 549
		internal class MySocketAsyncEventArgs : global::System.Net.Sockets.SocketAsyncEventArgs
		{
			// Token: 0x0600134B RID: 4939 RVA: 0x0003263A File Offset: 0x0003083A
			public void RaiseCompleted()
			{
				this.OnCompleted(this);
			}
		}
	}
}
