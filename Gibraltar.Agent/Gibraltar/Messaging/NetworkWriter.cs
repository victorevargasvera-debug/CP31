using System;
using System.Diagnostics;
using System.Net.Sockets;
using Gibraltar.Data;
using Gibraltar.Messaging.Net;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000226 RID: 550
	[global::System.Diagnostics.DebuggerDisplay("Connected: {IsConnected} Failed: {IsFailed} Closed: {IsClosed}")]
	internal class NetworkWriter : global::Gibraltar.Messaging.Net.NetworkClient
	{
		// Token: 0x06001BB8 RID: 7096 RVA: 0x00060680 File Offset: 0x0005E880
		public NetworkWriter(global::Gibraltar.Messaging.NetworkMessenger messenger, global::Gibraltar.Server.Client.NetworkConnectionOptions options, global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset = 0L) : this(messenger, options, repositoryId, channelId, sequenceOffset, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000606A8 File Offset: 0x0005E8A8
		public NetworkWriter(global::Gibraltar.Messaging.NetworkMessenger messenger, global::Gibraltar.Server.Client.NetworkConnectionOptions options, global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset, int majorVersion, int minorVersion)
		{
			this.m_Lock = new object();
			base..ctor(options, false, majorVersion, minorVersion);
			if (channelId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentNullException("channelId");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Messenger = messenger;
				this.m_RepositoryId = repositoryId;
				this.m_ChannelId = channelId;
				this.m_SequenceOffset = sequenceOffset;
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00060730 File Offset: 0x0005E930
		public NetworkWriter(global::Gibraltar.Messaging.NetworkMessenger messenger, global::System.Net.Sockets.TcpClient tcpClient, global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset = 0L) : this(messenger, tcpClient, repositoryId, channelId, sequenceOffset, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00060758 File Offset: 0x0005E958
		public NetworkWriter(global::Gibraltar.Messaging.NetworkMessenger messenger, global::System.Net.Sockets.TcpClient tcpClient, global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset, int majorVersion, int minorVersion)
		{
			this.m_Lock = new object();
			base..ctor(tcpClient, majorVersion, minorVersion);
			if (channelId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentNullException("channelId");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Messenger = messenger;
				this.m_RepositoryId = repositoryId;
				this.m_ChannelId = channelId;
				this.m_SequenceOffset = sequenceOffset;
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000607E0 File Offset: 0x0005E9E0
		public void Write(global::Gibraltar.Messaging.IMessengerPacket[] packets)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!base.IsFailed && !base.IsClosed)
				{
					foreach (global::Gibraltar.Messaging.IMessengerPacket packet in packets)
					{
						this.Write(packet);
					}
				}
			}
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00060854 File Offset: 0x0005EA54
		public void Write(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!base.IsFailed && !base.IsClosed)
				{
					if (global::Gibraltar.Messaging.NetworkWriter.CanWritePacket(packet))
					{
						base.SendPacket(packet);
					}
				}
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000608B8 File Offset: 0x0005EAB8
		public static bool CanWritePacket(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			return packet is global::Gibraltar.Monitor.Internal.LogMessagePacket || packet is global::Gibraltar.Monitor.Internal.ApplicationUserPacket || packet is global::Gibraltar.Monitor.Internal.ExceptionInfoPacket || packet is global::Gibraltar.Monitor.Internal.ThreadInfoPacket || packet is global::Gibraltar.Monitor.Internal.SessionSummaryPacket;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000608F4 File Offset: 0x0005EAF4
		protected override bool Connect()
		{
			global::Gibraltar.Messaging.Publisher.ThreadMustNotBlock();
			bool flag = false;
			base.SendMessage(new global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage(this.m_RepositoryId, global::Gibraltar.Monitor.Log.SessionSummary.Id, this.m_ChannelId, 0L));
			global::Gibraltar.Messaging.Net.NetworkMessage networkMessage;
			do
			{
				networkMessage = base.ReadNetworkMessage();
				if (networkMessage != null)
				{
					if (networkMessage is global::Gibraltar.Messaging.Net.LiveViewStopCommandMessage)
					{
						base.RemoteClose();
					}
					else if (networkMessage is global::Gibraltar.Messaging.Net.PacketStreamStartCommandMessage)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Client", "Packet Stream start command received from server", "Received the start command, now we will switch over to the gibraltar session stream data.\r\n{0}", new object[]
							{
								this
							});
						}
						this.m_Messenger.ActivateWriter(this, this.m_SequenceOffset);
						flag = true;
					}
				}
			}
			while (networkMessage != null && !flag);
			return flag;
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000609A4 File Offset: 0x0005EBA4
		protected override void TransferData()
		{
			global::Gibraltar.Messaging.Net.NetworkMessage networkMessage;
			do
			{
				networkMessage = base.ReadNetworkMessage();
				if (networkMessage != null)
				{
					if (networkMessage is global::Gibraltar.Messaging.Net.LiveViewStopCommandMessage)
					{
						base.RemoteClose();
					}
					else if (networkMessage is global::Gibraltar.Messaging.Net.SendSessionCommandMessage)
					{
						this.m_Messenger.SendToServer((global::Gibraltar.Messaging.Net.SendSessionCommandMessage)networkMessage);
					}
				}
			}
			while (networkMessage != null);
		}

		// Token: 0x040009FB RID: 2555
		private readonly object m_Lock;

		// Token: 0x040009FC RID: 2556
		private readonly global::Gibraltar.Messaging.NetworkMessenger m_Messenger;

		// Token: 0x040009FD RID: 2557
		private readonly long m_SequenceOffset;

		// Token: 0x040009FE RID: 2558
		private readonly global::System.Guid m_ChannelId;

		// Token: 0x040009FF RID: 2559
		private readonly global::System.Guid m_RepositoryId;
	}
}
