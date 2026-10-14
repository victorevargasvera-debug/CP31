using System;
using System.Net.Sockets;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000136 RID: 310
	internal interface ISocket
	{
		// Token: 0x06000DFA RID: 3578
		bool ConnectAsync(global::System.Net.Sockets.SocketAsyncEventArgs args);

		// Token: 0x06000DFB RID: 3579
		void Close();

		// Token: 0x06000DFC RID: 3580
		bool SendAsync(global::System.Net.Sockets.SocketAsyncEventArgs args);

		// Token: 0x06000DFD RID: 3581
		bool SendToAsync(global::System.Net.Sockets.SocketAsyncEventArgs args);
	}
}
