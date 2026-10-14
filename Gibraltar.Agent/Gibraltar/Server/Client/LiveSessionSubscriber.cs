using System;
using Gibraltar.Data;
using Gibraltar.Messaging.Net;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000175 RID: 373
	internal class LiveSessionSubscriber : global::Gibraltar.Messaging.Net.NetworkClient, global::Gibraltar.Monitor.Internal.ISessionPacketCache
	{
		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000F7B RID: 3963 RVA: 0x0002A280 File Offset: 0x00028480
		// (remove) Token: 0x06000F7C RID: 3964 RVA: 0x0002A2BC File Offset: 0x000284BC
		public event global::Gibraltar.Messaging.Net.MessageAvailableEventHandler MessageAvailable;

		// Token: 0x06000F7D RID: 3965 RVA: 0x0002A2F8 File Offset: 0x000284F8
		public LiveSessionSubscriber(global::Gibraltar.Server.Client.NetworkConnectionOptions options, global::System.Guid repositoryId, global::System.Guid sessionId, global::System.Guid channelId, long lastSequence) : this(options, repositoryId, sessionId, channelId, lastSequence, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion)
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0002A320 File Offset: 0x00028520
		public LiveSessionSubscriber(global::Gibraltar.Server.Client.NetworkConnectionOptions options, global::System.Guid repositoryId, global::System.Guid sessionId, global::System.Guid channelId, long lastSequence, int majorVersion, int minorVersion) : base(options, false, majorVersion, minorVersion)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_RepositoryId = repositoryId;
				this.m_ChannelId = channelId;
				this.m_SessionId = sessionId;
				this.m_LastSequence = lastSequence;
				this.m_ChannelId = channelId;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x0002A3AC File Offset: 0x000285AC
		public global::System.Guid ChannelId
		{
			get
			{
				return this.m_ChannelId;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0002A3B4 File Offset: 0x000285B4
		public global::System.Guid SessionId
		{
			get
			{
				return this.m_SessionId;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x0002A3BC File Offset: 0x000285BC
		public global::Gibraltar.Monitor.SessionSummary Summary
		{
			get
			{
				return this.m_SessionSummary;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0002A3C4 File Offset: 0x000285C4
		public global::Gibraltar.Monitor.ThreadInfoCollection Threads
		{
			get
			{
				return this.m_Threads;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x0002A3CC File Offset: 0x000285CC
		public global::Gibraltar.Monitor.ApplicationUserCollection Users
		{
			get
			{
				return this.m_Users;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0002A3D4 File Offset: 0x000285D4
		public long LastSequence
		{
			get
			{
				return this.m_LastSequence;
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0002A3DC File Offset: 0x000285DC
		public void SendToServer(global::Gibraltar.Data.SessionCriteria criteria)
		{
			global::Gibraltar.Messaging.Net.SendSessionCommandMessage message = new global::Gibraltar.Messaging.Net.SendSessionCommandMessage(this.m_SessionId, criteria);
			base.SendMessage(message);
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0002A404 File Offset: 0x00028604
		// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0002A40C File Offset: 0x0002860C
		public global::System.TimeSpan ClockDrift
		{
			get
			{
				return this.m_ClockDrift;
			}
			set
			{
				this.m_ClockDrift = value;
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0002A418 File Offset: 0x00028618
		protected override bool Connect()
		{
			bool flag = false;
			global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage liveViewStartCommandMessage = new global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage(this.m_RepositoryId, this.m_SessionId, this.m_ChannelId, this.LastSequence);
			liveViewStartCommandMessage.Validate();
			base.SendMessage(liveViewStartCommandMessage);
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
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Client", "Packet Stream start command received from server", "Received the start command, now we will switch over to the Loupe session stream data.\r\n{0}", new object[]
							{
								this
							});
						}
						flag = true;
					}
				}
			}
			while (networkMessage != null && !flag);
			return flag;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0002A4BC File Offset: 0x000286BC
		protected override void TransferData()
		{
			bool flag = false;
			global::Gibraltar.Serialization.IPacket packet;
			do
			{
				packet = base.ReadSerializedPacket();
				if (packet != null)
				{
					try
					{
						global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket;
						global::Gibraltar.Monitor.Internal.ApplicationUserPacket userPacket;
						global::Gibraltar.Monitor.Internal.ThreadInfoPacket threadInfoPacket;
						global::Gibraltar.Monitor.Internal.SessionSummaryPacket sessionSummary;
						global::Gibraltar.Monitor.Internal.SessionClosePacket sessionClose;
						if ((logMessagePacket = (packet as global::Gibraltar.Monitor.Internal.LogMessagePacket)) != null)
						{
							global::Gibraltar.Monitor.ThreadInfo threadInfo;
							if (this.m_Threads.TryGetValue(logMessagePacket.ThreadIndex, out threadInfo))
							{
								logMessagePacket.ThreadInfoPacket = threadInfo.Packet;
							}
							this.EnqueueMessage(logMessagePacket);
						}
						else if ((userPacket = (packet as global::Gibraltar.Monitor.Internal.ApplicationUserPacket)) != null)
						{
							this.AddUser(userPacket);
						}
						else if ((threadInfoPacket = (packet as global::Gibraltar.Monitor.Internal.ThreadInfoPacket)) != null)
						{
							this.AddThread(threadInfoPacket);
							flag = true;
						}
						else if ((sessionSummary = (packet as global::Gibraltar.Monitor.Internal.SessionSummaryPacket)) != null)
						{
							this.SetSessionSummary(sessionSummary);
						}
						else if ((sessionClose = (packet as global::Gibraltar.Monitor.Internal.SessionClosePacket)) != null)
						{
							this.SetSessionClose(sessionClose);
						}
						global::Gibraltar.Monitor.Internal.GibraltarPacket gibraltarPacket;
						if ((gibraltarPacket = (packet as global::Gibraltar.Monitor.Internal.GibraltarPacket)) != null)
						{
							this.m_LastSequence = global::System.Math.Max(this.m_LastSequence, gibraltarPacket.Sequence);
						}
					}
					catch (global::System.Exception ex)
					{
						global::System.GC.KeepAlive(ex);
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Unexpected exception while loading packet stream", "{0}", new object[]
							{
								ex.Message
							});
						}
					}
				}
				global::Gibraltar.Serialization.IPacket packet2 = packet;
				if (packet2 == null)
				{
					global::System.GC.KeepAlive(packet2);
				}
				if (flag)
				{
					object @lock = this.m_Lock;
					lock (@lock)
					{
						this.m_Threads.UniquifyThreadNames();
					}
					flag = false;
				}
			}
			while (packet != null);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0002A64C File Offset: 0x0002884C
		protected override void OnClose()
		{
			global::Gibraltar.Messaging.Net.LiveViewStopCommandMessage message = new global::Gibraltar.Messaging.Net.LiveViewStopCommandMessage(this.m_ChannelId, this.m_SessionId);
			base.SendMessage(message);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0002A678 File Offset: 0x00028878
		protected virtual void OnMessageAvailable(global::Loupe.Extensibility.Data.ILogMessage newMessage)
		{
			global::Gibraltar.Messaging.Net.MessageAvailableEventHandler messageAvailable = this.MessageAvailable;
			if (messageAvailable != null)
			{
				try
				{
					messageAvailable(this, new global::Gibraltar.Messaging.Net.MessageAvailableEventArgs(newMessage));
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Client exception thrown during message available event", ex.Message, new object[0]);
					}
				}
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0002A6E4 File Offset: 0x000288E4
		protected override void OnPacketFactoryRegister(global::Gibraltar.Serialization.PacketReader packetReader)
		{
			new global::Gibraltar.Monitor.Internal.SessionPacketFactory().Register(packetReader);
			new global::Gibraltar.Monitor.Internal.LogMessagePacketFactory(this).Register(packetReader);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0002A700 File Offset: 0x00028900
		private void SetSessionClose(global::Gibraltar.Monitor.Internal.SessionClosePacket sessionClosePacket)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionSummary != null && ((this.m_EndInfo == null) ? (sessionClosePacket.EndingStatus >= this.m_SessionSummary.Status) : (sessionClosePacket.EndingStatus > this.m_SessionSummary.Status)))
				{
					this.m_EndInfo = sessionClosePacket;
					this.m_SessionSummary.Status = this.m_EndInfo.EndingStatus;
				}
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0002A79C File Offset: 0x0002899C
		private void SetSessionSummary(global::Gibraltar.Monitor.Internal.SessionSummaryPacket sessionSummaryPacket)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionSummary == null)
				{
					this.m_SessionSummary = new global::Gibraltar.Monitor.SessionSummary(sessionSummaryPacket);
					if (this.m_EndInfo != null)
					{
						this.m_SessionSummary.Status = this.m_EndInfo.EndingStatus;
					}
					if (string.IsNullOrEmpty(this.m_SessionSummary.Caption))
					{
						this.m_SessionSummary.Caption = global::Gibraltar.Monitor.SessionSummary.DefaultCaption(this.m_SessionSummary);
					}
				}
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0002A838 File Offset: 0x00028A38
		private void EnqueueMessage(global::Loupe.Extensibility.Data.ILogMessage logMessage)
		{
			this.OnMessageAvailable(logMessage);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0002A844 File Offset: 0x00028A44
		private void AddThread(global::Gibraltar.Monitor.Internal.ThreadInfoPacket threadInfoPacket)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.ThreadInfo item = new global::Gibraltar.Monitor.ThreadInfo(threadInfoPacket);
				if (!this.m_Threads.Contains(item))
				{
					this.m_Threads.Add(item);
				}
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0002A8A0 File Offset: 0x00028AA0
		private void AddUser(global::Gibraltar.Monitor.Internal.ApplicationUserPacket userPacket)
		{
			global::Gibraltar.Monitor.ApplicationUser user = new global::Gibraltar.Monitor.ApplicationUser(userPacket);
			this.m_Users.TrySetValue(user);
		}

		// Token: 0x04000531 RID: 1329
		private readonly global::System.Guid m_SessionId;

		// Token: 0x04000532 RID: 1330
		private readonly global::Gibraltar.Monitor.ThreadInfoCollection m_Threads = new global::Gibraltar.Monitor.ThreadInfoCollection();

		// Token: 0x04000533 RID: 1331
		private readonly global::Gibraltar.Monitor.ApplicationUserCollection m_Users = new global::Gibraltar.Monitor.ApplicationUserCollection();

		// Token: 0x04000534 RID: 1332
		private readonly object m_Lock = new object();

		// Token: 0x04000535 RID: 1333
		private global::Gibraltar.Monitor.SessionSummary m_SessionSummary;

		// Token: 0x04000536 RID: 1334
		private global::Gibraltar.Monitor.Internal.SessionClosePacket m_EndInfo;

		// Token: 0x04000537 RID: 1335
		private long m_LastSequence;

		// Token: 0x04000538 RID: 1336
		private global::System.TimeSpan m_ClockDrift;

		// Token: 0x04000539 RID: 1337
		private readonly global::System.Guid m_RepositoryId;

		// Token: 0x0400053A RID: 1338
		private readonly global::System.Guid m_ChannelId;
	}
}
