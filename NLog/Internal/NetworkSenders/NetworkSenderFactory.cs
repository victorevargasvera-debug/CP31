using System;
using System.Net.Sockets;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000138 RID: 312
	internal class NetworkSenderFactory : global::NLog.Internal.NetworkSenders.INetworkSenderFactory
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x000239AC File Offset: 0x00021BAC
		public global::NLog.Internal.NetworkSenders.NetworkSender Create(string url, int maxQueueSize)
		{
			if (url.StartsWith("http://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.HttpNetworkSender(url);
			}
			if (url.StartsWith("https://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.HttpNetworkSender(url);
			}
			if (url.StartsWith("tcp://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.TcpNetworkSender(url, global::System.Net.Sockets.AddressFamily.Unspecified)
				{
					MaxQueueSize = maxQueueSize
				};
			}
			if (url.StartsWith("tcp4://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.TcpNetworkSender(url, global::System.Net.Sockets.AddressFamily.InterNetwork)
				{
					MaxQueueSize = maxQueueSize
				};
			}
			if (url.StartsWith("tcp6://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.TcpNetworkSender(url, global::System.Net.Sockets.AddressFamily.InterNetworkV6)
				{
					MaxQueueSize = maxQueueSize
				};
			}
			if (url.StartsWith("udp://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.UdpNetworkSender(url, global::System.Net.Sockets.AddressFamily.Unspecified);
			}
			if (url.StartsWith("udp4://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.UdpNetworkSender(url, global::System.Net.Sockets.AddressFamily.InterNetwork);
			}
			if (url.StartsWith("udp6://", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NLog.Internal.NetworkSenders.UdpNetworkSender(url, global::System.Net.Sockets.AddressFamily.InterNetworkV6);
			}
			throw new global::System.ArgumentException("Unrecognized network address", "url");
		}

		// Token: 0x040003E0 RID: 992
		public static readonly global::NLog.Internal.NetworkSenders.INetworkSenderFactory Default = new global::NLog.Internal.NetworkSenders.NetworkSenderFactory();
	}
}
