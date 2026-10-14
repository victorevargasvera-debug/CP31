using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using NLog.Common;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x0200013B RID: 315
	internal class UdpNetworkSender : global::NLog.Internal.NetworkSenders.NetworkSender
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00023F04 File Offset: 0x00022104
		public UdpNetworkSender(string url, global::System.Net.Sockets.AddressFamily addressFamily) : base(url)
		{
			this.AddressFamily = addressFamily;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00023F14 File Offset: 0x00022114
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00023F1C File Offset: 0x0002211C
		internal global::System.Net.Sockets.AddressFamily AddressFamily { get; set; }

		// Token: 0x06000E2A RID: 3626 RVA: 0x00023F28 File Offset: 0x00022128
		protected internal virtual global::NLog.Internal.NetworkSenders.ISocket CreateSocket(global::System.Net.Sockets.AddressFamily addressFamily, global::System.Net.Sockets.SocketType socketType, global::System.Net.Sockets.ProtocolType protocolType)
		{
			global::NLog.Internal.NetworkSenders.SocketProxy socketProxy = new global::NLog.Internal.NetworkSenders.SocketProxy(addressFamily, socketType, protocolType);
			global::System.Uri uri;
			if (global::System.Uri.TryCreate(base.Address, global::System.UriKind.Absolute, out uri) && uri.Host.Equals(global::System.Net.IPAddress.Broadcast.ToString(), global::System.StringComparison.OrdinalIgnoreCase))
			{
				socketProxy.UnderlyingSocket.EnableBroadcast = true;
			}
			return socketProxy;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00023F73 File Offset: 0x00022173
		protected override void DoInitialize()
		{
			this._endpoint = this.ParseEndpointAddress(new global::System.Uri(base.Address), this.AddressFamily);
			this._socket = this.CreateSocket(this._endpoint.AddressFamily, global::System.Net.Sockets.SocketType.Dgram, global::System.Net.Sockets.ProtocolType.Udp);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00023FAC File Offset: 0x000221AC
		protected override void DoClose(global::NLog.Common.AsyncContinuation continuation)
		{
			lock (this)
			{
				this.CloseSocket(continuation);
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00023FE8 File Offset: 0x000221E8
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

		// Token: 0x06000E2E RID: 3630 RVA: 0x0002403C File Offset: 0x0002223C
		protected override void DoSend(byte[] bytes, int offset, int length, global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			lock (this)
			{
				global::System.Net.Sockets.SocketAsyncEventArgs socketAsyncEventArgs = new global::System.Net.Sockets.SocketAsyncEventArgs();
				socketAsyncEventArgs.SetBuffer(bytes, offset, length);
				socketAsyncEventArgs.UserToken = asyncContinuation;
				socketAsyncEventArgs.Completed += this.SocketOperationCompleted;
				socketAsyncEventArgs.RemoteEndPoint = this._endpoint;
				if (!this._socket.SendToAsync(socketAsyncEventArgs))
				{
					this.SocketOperationCompleted(this._socket, socketAsyncEventArgs);
				}
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000240C4 File Offset: 0x000222C4
		private void SocketOperationCompleted(object sender, global::System.Net.Sockets.SocketAsyncEventArgs e)
		{
			global::NLog.Common.AsyncContinuation asyncContinuation = e.UserToken as global::NLog.Common.AsyncContinuation;
			global::System.Exception exception = null;
			if (e.SocketError != global::System.Net.Sockets.SocketError.Success)
			{
				exception = new global::System.IO.IOException("Error: " + e.SocketError);
			}
			e.Dispose();
			if (asyncContinuation != null)
			{
				asyncContinuation(exception);
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00024112 File Offset: 0x00022312
		public override void CheckSocket()
		{
			if (this._socket == null)
			{
				this.DoInitialize();
			}
		}

		// Token: 0x040003EA RID: 1002
		private global::NLog.Internal.NetworkSenders.ISocket _socket;

		// Token: 0x040003EB RID: 1003
		private global::System.Net.EndPoint _endpoint;
	}
}
