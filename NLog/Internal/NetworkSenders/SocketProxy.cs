using System;
using System.Net.Sockets;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000139 RID: 313
	internal sealed class SocketProxy : global::NLog.Internal.NetworkSenders.ISocket, global::System.IDisposable
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00023AA1 File Offset: 0x00021CA1
		internal SocketProxy(global::System.Net.Sockets.AddressFamily addressFamily, global::System.Net.Sockets.SocketType socketType, global::System.Net.Sockets.ProtocolType protocolType)
		{
			this._socket = new global::System.Net.Sockets.Socket(addressFamily, socketType, protocolType);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00023AB7 File Offset: 0x00021CB7
		public global::System.Net.Sockets.Socket UnderlyingSocket
		{
			get
			{
				return this._socket;
			}
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00023ABF File Offset: 0x00021CBF
		public void Close()
		{
			this._socket.Close();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00023ACC File Offset: 0x00021CCC
		public bool ConnectAsync(global::System.Net.Sockets.SocketAsyncEventArgs args)
		{
			return this._socket.ConnectAsync(args);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00023ADA File Offset: 0x00021CDA
		public bool SendAsync(global::System.Net.Sockets.SocketAsyncEventArgs args)
		{
			return this._socket.SendAsync(args);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00023AE8 File Offset: 0x00021CE8
		public bool SendToAsync(global::System.Net.Sockets.SocketAsyncEventArgs args)
		{
			return this._socket.SendToAsync(args);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00023AF6 File Offset: 0x00021CF6
		public void Dispose()
		{
			((global::System.IDisposable)this._socket).Dispose();
		}

		// Token: 0x040003E1 RID: 993
		private readonly global::System.Net.Sockets.Socket _socket;
	}
}
