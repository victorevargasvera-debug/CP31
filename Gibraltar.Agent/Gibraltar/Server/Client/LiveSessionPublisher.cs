using System;
using System.Net;
using Gibraltar.Data;
using Gibraltar.Messaging;
using Gibraltar.Messaging.Net;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000176 RID: 374
	internal class LiveSessionPublisher : global::Gibraltar.Messaging.Net.NetworkClient
	{
		// Token: 0x06000F92 RID: 3986 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		public LiveSessionPublisher(global::Gibraltar.Messaging.NetworkMessenger messenger, global::Gibraltar.Server.Client.NetworkConnectionOptions options) : this(messenger, options, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0002A8DC File Offset: 0x00028ADC
		public LiveSessionPublisher(global::Gibraltar.Messaging.NetworkMessenger messenger, global::Gibraltar.Server.Client.NetworkConnectionOptions options, int majorVersion, int minorVersion) : base(options, true, majorVersion, minorVersion)
		{
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Client", "New live sessions publisher being created", "Configuration:\r\n{0}", new object[]
				{
					options
				});
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Messenger = messenger;
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0002A95C File Offset: 0x00028B5C
		public LiveSessionPublisher(global::Gibraltar.Messaging.NetworkMessenger messenger, global::Gibraltar.Messaging.LocalServerDiscoveryFile discoveryFile) : this(messenger, new global::Gibraltar.Server.Client.NetworkConnectionOptions
		{
			HostName = global::System.Net.IPAddress.Loopback.ToString(),
			Port = discoveryFile.PublisherPort
		})
		{
			this.m_DiscoveryFile = discoveryFile;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0002A99C File Offset: 0x00028B9C
		public void SendSummary()
		{
			global::Gibraltar.Messaging.Net.SessionHeaderMessage message = new global::Gibraltar.Messaging.Net.SessionHeaderMessage(new global::Gibraltar.Data.SessionHeader(global::Gibraltar.Monitor.Log.SessionSummary));
			base.SendMessage(message);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0002A9C4 File Offset: 0x00028BC4
		protected override bool Connect()
		{
			global::Gibraltar.Messaging.Net.RegisterAgentCommandMessage message = new global::Gibraltar.Messaging.Net.RegisterAgentCommandMessage(global::Gibraltar.Monitor.Log.SessionSummary.Id);
			base.SendMessage(message);
			this.SendSummary();
			return true;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		protected override void TransferData()
		{
			global::Gibraltar.Messaging.Net.NetworkMessage networkMessage;
			do
			{
				networkMessage = base.ReadNetworkMessage();
				if (networkMessage != null)
				{
					global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage liveViewStartCommandMessage = networkMessage as global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage;
					global::Gibraltar.Messaging.Net.SendSessionCommandMessage sendSessionCommandMessage = networkMessage as global::Gibraltar.Messaging.Net.SendSessionCommandMessage;
					if (liveViewStartCommandMessage != null)
					{
						liveViewStartCommandMessage.Validate();
						this.m_Messenger.StartLiveView(base.GetOptions(), liveViewStartCommandMessage.RepositoryId, liveViewStartCommandMessage.ChannelId, liveViewStartCommandMessage.SequenceOffset);
					}
					else if (sendSessionCommandMessage != null)
					{
						this.m_Messenger.SendToServer((global::Gibraltar.Messaging.Net.SendSessionCommandMessage)networkMessage);
					}
				}
			}
			while (networkMessage != null);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0002AA70 File Offset: 0x00028C70
		protected override bool RetryDelay(ref int defaultDelayMs)
		{
			return this.m_DiscoveryFile == null || this.m_DiscoveryFile.IsAlive;
		}

		// Token: 0x0400053C RID: 1340
		private readonly global::Gibraltar.Messaging.NetworkMessenger m_Messenger;

		// Token: 0x0400053D RID: 1341
		private readonly global::Gibraltar.Messaging.LocalServerDiscoveryFile m_DiscoveryFile;

		// Token: 0x0400053E RID: 1342
		private readonly object m_Lock = new object();
	}
}
