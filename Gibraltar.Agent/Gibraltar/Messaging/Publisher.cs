using System;
using System.Collections.Generic;
using System.Threading;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x0200023C RID: 572
	internal class Publisher
	{
		// Token: 0x14000084 RID: 132
		// (add) Token: 0x06001CCA RID: 7370 RVA: 0x000650F8 File Offset: 0x000632F8
		// (remove) Token: 0x06001CCB RID: 7371 RVA: 0x00065130 File Offset: 0x00063330
		internal static event global::Gibraltar.Messaging.PacketEventHandler MessageDispatching;

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x06001CCC RID: 7372 RVA: 0x00065168 File Offset: 0x00063368
		// (remove) Token: 0x06001CCD RID: 7373 RVA: 0x000651A0 File Offset: 0x000633A0
		internal static event global::Gibraltar.Messaging.LogMessageNotifyEventHandler LogMessageNotify;

		// Token: 0x06001CCE RID: 7374 RVA: 0x000651D8 File Offset: 0x000633D8
		public Publisher(string sessionName, global::Gibraltar.Monitor.AgentConfiguration configuration, global::Gibraltar.Monitor.SessionSummary sessionSummary)
		{
			if (string.IsNullOrEmpty(sessionName))
			{
				throw new global::System.ArgumentNullException("sessionName");
			}
			if (configuration == null)
			{
				throw new global::System.ArgumentNullException("configuration");
			}
			if (sessionSummary == null)
			{
				throw new global::System.ArgumentNullException("sessionSummary");
			}
			this.m_SessionName = sessionName;
			this.m_SessionSummary = sessionSummary;
			this.m_Configuration = configuration;
			this.m_MessageQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope>(50);
			this.m_MessageOverflowQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope>(50);
			this.m_CachedTypes = new global::Gibraltar.Serialization.PacketDefinitionList();
			this.m_PacketCache = new global::Gibraltar.Serialization.PacketCache();
			this.m_Messengers = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.IMessenger>();
			this.m_MessageQueueMaxLength = global::System.Math.Max(configuration.Publisher.MaxQueueLength, 1);
			this.CreateMessageDispatchThread();
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x000652D8 File Offset: 0x000634D8
		internal static void ThreadMustNotBlock()
		{
			global::Gibraltar.Messaging.Publisher.t_ThreadMustNotBlock = true;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x000652E0 File Offset: 0x000634E0
		internal static bool QueryThreadMustNotBlock()
		{
			return global::Gibraltar.Messaging.Publisher.t_ThreadMustNotBlock;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000652E8 File Offset: 0x000634E8
		internal static void ThreadMustNotNotify()
		{
			global::Gibraltar.Messaging.Publisher.t_ThreadMustNotNotify = true;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000652F0 File Offset: 0x000634F0
		internal static bool QueryThreadMustNotNotify()
		{
			return global::Gibraltar.Messaging.Publisher.t_ThreadMustNotNotify;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000652F8 File Offset: 0x000634F8
		private void CreateMessageDispatchThread()
		{
			object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
			lock (messageDispatchThreadLock)
			{
				this.m_MessageDispatchThreadFailed = false;
				this.m_MessageDispatchThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.MessageDispatchMain));
				this.m_MessageDispatchThread.Name = "Loupe Publisher";
				this.m_MessageDispatchThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				this.m_MessageDispatchThread.IsBackground = this.m_ExitMode;
				this.m_MessageDispatchThread.Start();
				global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00065394 File Offset: 0x00063594
		private void MessageDispatchMain()
		{
			try
			{
				global::Gibraltar.Messaging.Publisher.ThreadMustNotBlock();
				object obj = this.m_MessageDispatchThreadLock;
				bool isBackground;
				lock (obj)
				{
					this.EnsureInitialized();
					isBackground = this.m_MessageDispatchThread.IsBackground;
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
					goto IL_128;
				}
				IL_3B:
				global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = null;
				obj = this.m_MessageQueueLock;
				lock (obj)
				{
					if (this.m_ExitMode && !isBackground)
					{
						goto IL_145;
					}
					while (this.m_MessageQueue.Count == 0 && !this.m_Shutdown)
					{
						global::System.Threading.Monitor.Wait(this.m_MessageQueueLock);
					}
					if (this.m_MessageQueue.Count > 0)
					{
						packetEnvelope = this.m_MessageQueue.Dequeue();
						while (this.m_MessageOverflowQueue.Count > 0 && this.m_MessageQueue.Count < this.m_MessageQueueMaxLength)
						{
							global::Gibraltar.Messaging.PacketEnvelope packetEnvelope2 = this.m_MessageOverflowQueue.Dequeue();
							this.m_MessageQueue.Enqueue(packetEnvelope2);
							packetEnvelope2.IsPending = false;
						}
					}
					global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
				}
				if (packetEnvelope != null)
				{
					obj = this.m_ConfigLock;
					lock (obj)
					{
						this.DispatchPacket(packetEnvelope);
					}
				}
				IL_128:
				if (!this.m_Shutdown && (!this.m_ExitMode || isBackground))
				{
					goto IL_3B;
				}
				IL_145:
				this.m_MessageDispatchThread = null;
				if (!this.m_Shutdown)
				{
					this.CreateMessageDispatchThread();
				}
			}
			catch (global::System.Exception ex)
			{
				object obj = this.m_MessageDispatchThreadLock;
				lock (obj)
				{
					this.m_MessageDispatchThread = null;
					this.m_MessageDispatchThreadFailed = true;
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
				}
				if (ex is global::System.Threading.ThreadAbortException)
				{
					this.OnThreadAbort();
				}
			}
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x000655D0 File Offset: 0x000637D0
		private void OnThreadAbort()
		{
			object messageQueueLock = this.m_MessageQueueLock;
			lock (messageQueueLock)
			{
				if (this.m_ExitMode)
				{
					this.m_Shutdown = true;
					while (this.m_MessageQueue.Count > 0)
					{
						global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = this.m_MessageQueue.Dequeue();
						packetEnvelope.IsPending = false;
						packetEnvelope.IsCommitted = true;
					}
					while (this.m_MessageOverflowQueue.Count > 0)
					{
						global::Gibraltar.Messaging.PacketEnvelope packetEnvelope2 = this.m_MessageOverflowQueue.Dequeue();
						packetEnvelope2.IsPending = false;
						packetEnvelope2.IsCommitted = true;
					}
					global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
				}
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00065680 File Offset: 0x00063880
		private void DispatchPacket(global::Gibraltar.Messaging.PacketEnvelope envelope)
		{
			global::Gibraltar.Messaging.IMessengerPacket packet;
			lock (envelope)
			{
				packet = envelope.Packet;
				bool writeThrough = envelope.WriteThrough;
				if (envelope.IsCommand)
				{
					global::Gibraltar.Messaging.CommandPacket commandPacket = (global::Gibraltar.Messaging.CommandPacket)packet;
					if (commandPacket.Command == global::Gibraltar.Messaging.MessagingCommand.ExitMode)
					{
						this.m_ExitMode = true;
						writeThrough = true;
					}
					else if (commandPacket.Command == global::Gibraltar.Messaging.MessagingCommand.CloseMessenger)
					{
						this.m_Shutdown = true;
						writeThrough = true;
					}
				}
				else
				{
					this.StampPacket(packet, packet.Timestamp);
					global::Gibraltar.Monitor.Internal.GibraltarPacket gibraltarPacket = packet as global::Gibraltar.Monitor.Internal.GibraltarPacket;
					if (gibraltarPacket != null)
					{
						gibraltarPacket.FixData();
					}
					try
					{
						global::Gibraltar.Messaging.PacketEventHandler messageDispatching = global::Gibraltar.Messaging.Publisher.MessageDispatching;
						if (messageDispatching != null)
						{
							messageDispatching(this, new global::Gibraltar.Messaging.PacketEventArgs(packet));
						}
					}
					catch (global::System.Exception ex)
					{
						if (ex is global::System.Threading.ThreadAbortException)
						{
							throw;
						}
					}
				}
				if (envelope.IsHeader)
				{
					object headerPacketsLock = this.m_HeaderPacketsLock;
					lock (headerPacketsLock)
					{
						this.m_HeaderPackets.Add((global::Gibraltar.Messaging.ICachedMessengerPacket)packet);
						global::System.Threading.Monitor.PulseAll(this.m_HeaderPacketsLock);
					}
				}
				foreach (global::Gibraltar.Messaging.IMessenger messenger in this.m_Messengers)
				{
					try
					{
						messenger.Write(packet, writeThrough);
					}
					catch (global::System.Exception ex2)
					{
						if (ex2 is global::System.Threading.ThreadAbortException)
						{
							throw;
						}
					}
				}
				envelope.IsCommitted = true;
			}
			this.QueueToNotifier(packet);
			if (!this.m_Configuration.SessionFile.Enabled && packet.Sequence % 8192L == 0L)
			{
				global::Gibraltar.StringReference.Pack();
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x0006589C File Offset: 0x00063A9C
		private void EnsureInitialized()
		{
			if (!this.m_Initialized)
			{
				this.m_ForceWriteThrough = this.m_Configuration.Publisher.ForceSynchronous;
				try
				{
					if (this.m_Configuration.SessionFile.Enabled)
					{
						this.AddMessenger(this.m_Configuration.SessionFile);
					}
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.ErrorNotifier.Notify(this, exception);
				}
				try
				{
					if (this.m_Configuration.Viewer.Enabled && this.m_SessionSummary.AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows)
					{
						this.AddMessenger(this.m_Configuration.Viewer);
					}
				}
				catch (global::System.Exception exception2)
				{
					global::Gibraltar.ErrorNotifier.Notify(this, exception2);
				}
				try
				{
					if (this.m_Configuration.NetworkViewer.Enabled)
					{
						this.AddMessenger(this.m_Configuration.NetworkViewer);
					}
				}
				catch (global::System.Exception exception3)
				{
					global::Gibraltar.ErrorNotifier.Notify(this, exception3);
				}
				this.m_Initialized = true;
			}
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000659B4 File Offset: 0x00063BB4
		private void AddMessenger(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			global::Gibraltar.Messaging.IMessenger messenger = null;
			try
			{
				messenger = (global::Gibraltar.Messaging.IMessenger)global::System.Activator.CreateInstance(global::System.Type.GetType(configuration.MessengerType, true, true));
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, exception);
			}
			if (messenger != null)
			{
				try
				{
					messenger.Initialize(this, configuration);
					object configLock = this.m_ConfigLock;
					lock (configLock)
					{
						this.m_Messengers.Add(messenger);
					}
				}
				catch (global::System.Exception exception2)
				{
					global::Gibraltar.ErrorNotifier.Notify(this, exception2);
				}
			}
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00065A5C File Offset: 0x00063C5C
		private void EnsureMessageDispatchThreadIsValid()
		{
			if (this.m_MessageDispatchThreadFailed && !this.m_Shutdown)
			{
				object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
				lock (messageDispatchThreadLock)
				{
					if (this.m_MessageDispatchThreadFailed)
					{
						this.CreateMessageDispatchThread();
					}
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
				}
			}
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00065ACC File Offset: 0x00063CCC
		private void QueueToNotifier(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			global::Gibraltar.Messaging.LogMessageNotifyEventHandler logMessageNotify = global::Gibraltar.Messaging.Publisher.LogMessageNotify;
			if (logMessageNotify != null)
			{
				logMessageNotify(this, new global::Gibraltar.Messaging.LogMessageNotifyEventArgs(packet));
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00065AF8 File Offset: 0x00063CF8
		private global::Gibraltar.Messaging.PacketEnvelope QueuePacket(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough)
		{
			packet.Timestamp = global::System.DateTimeOffset.Now;
			global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = new global::Gibraltar.Messaging.PacketEnvelope(packet, writeThrough);
			if (this.m_MessageOverflowQueue.Count > 0 || this.m_MessageQueue.Count > this.m_MessageQueueMaxLength)
			{
				if (global::Gibraltar.Messaging.Publisher.t_ThreadMustNotBlock && !packetEnvelope.IsCommand)
				{
					packetEnvelope = null;
				}
				else
				{
					this.m_MessageOverflowQueue.Enqueue(packetEnvelope);
					packetEnvelope.IsPending = true;
				}
			}
			else
			{
				this.m_MessageQueue.Enqueue(packetEnvelope);
			}
			return packetEnvelope;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00065B84 File Offset: 0x00063D84
		private void StampPacket(global::Gibraltar.Messaging.IMessengerPacket packet, global::System.DateTimeOffset defaultTimeStamp)
		{
			if (!(packet is global::Gibraltar.Messaging.CommandPacket))
			{
				global::System.Collections.Generic.Dictionary<global::Gibraltar.Serialization.IPacket, global::Gibraltar.Serialization.IPacket> requiredPackets = this.GetRequiredPackets(packet);
				if (requiredPackets != null && requiredPackets.Count > 0)
				{
					foreach (global::Gibraltar.Serialization.IPacket packet2 in requiredPackets.Values)
					{
						global::Gibraltar.Messaging.IMessengerPacket messengerPacket = packet2 as global::Gibraltar.Messaging.IMessengerPacket;
						if (messengerPacket != null && messengerPacket.Sequence == 0L && messengerPacket.Timestamp.Ticks == 0L)
						{
							this.StampPacket(messengerPacket, defaultTimeStamp);
						}
					}
				}
			}
			packet.Sequence = this.m_PacketSequence;
			this.m_PacketSequence += 1L;
			if (packet.Timestamp.Ticks == 0L)
			{
				packet.Timestamp = defaultTimeStamp;
			}
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00065C64 File Offset: 0x00063E64
		private static void WaitOnPacket(global::Gibraltar.Messaging.PacketEnvelope packetEnvelope)
		{
			lock (packetEnvelope)
			{
				while (!packetEnvelope.IsCommitted)
				{
					global::System.Threading.Monitor.Wait(packetEnvelope);
				}
				global::System.Threading.Monitor.PulseAll(packetEnvelope);
			}
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00065CB0 File Offset: 0x00063EB0
		private static void WaitOnPending(global::Gibraltar.Messaging.PacketEnvelope packetEnvelope)
		{
			lock (packetEnvelope)
			{
				while (packetEnvelope.IsPending)
				{
					global::System.Threading.Monitor.Wait(packetEnvelope);
				}
				global::System.Threading.Monitor.PulseAll(packetEnvelope);
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00065CFC File Offset: 0x00063EFC
		private global::System.Collections.Generic.Dictionary<global::Gibraltar.Serialization.IPacket, global::Gibraltar.Serialization.IPacket> GetRequiredPackets(global::Gibraltar.Serialization.IPacket packet)
		{
			int num = this.m_CachedTypes.IndexOf(packet);
			global::Gibraltar.Serialization.PacketDefinition packetDefinition;
			if (num < 0)
			{
				packetDefinition = global::Gibraltar.Serialization.PacketDefinition.CreatePacketDefinition(packet);
				this.m_CachedTypes.Add(packetDefinition);
			}
			else
			{
				packetDefinition = this.m_CachedTypes[num];
			}
			return packetDefinition.GetRequiredPackets(packet);
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00065D50 File Offset: 0x00063F50
		public global::Gibraltar.Monitor.PublisherConfiguration Configuration
		{
			get
			{
				return this.m_Configuration.Publisher;
			}
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00065D60 File Offset: 0x00063F60
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00065D70 File Offset: 0x00063F70
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (releaseManaged && !this.m_Shutdown)
				{
					this.Publish(new global::Gibraltar.Messaging.CommandPacket[]
					{
						new global::Gibraltar.Messaging.CommandPacket(global::Gibraltar.Messaging.MessagingCommand.CloseMessenger)
					}, true);
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x00065DB0 File Offset: 0x00063FB0
		public global::Gibraltar.Serialization.PacketCache PacketCache
		{
			get
			{
				return this.m_PacketCache;
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00065DB8 File Offset: 0x00063FB8
		public void Publish(global::Gibraltar.Messaging.IMessengerPacket[] packetArray, bool writeThrough)
		{
			if (packetArray == null)
			{
				return;
			}
			int num = packetArray.Length;
			int num2 = num - 1;
			while (num2 >= 0 && packetArray[num2] == null)
			{
				num2--;
			}
			if (num2 < 0)
			{
				return;
			}
			global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = null;
			int num3 = 0;
			object messageQueueLock = this.m_MessageQueueLock;
			bool flag;
			bool flag2;
			lock (messageQueueLock)
			{
				if (this.m_Shutdown)
				{
					return;
				}
				flag = (this.m_ForceWriteThrough || writeThrough || this.m_ExitingMode);
				for (int i = 0; i < num; i++)
				{
					global::Gibraltar.Messaging.IMessengerPacket messengerPacket = packetArray[i];
					if (messengerPacket != null)
					{
						global::Gibraltar.Messaging.PacketEnvelope packetEnvelope2 = this.QueuePacket(messengerPacket, flag && i >= num2);
						if (packetEnvelope2 != null)
						{
							num3++;
							packetEnvelope = packetEnvelope2;
							if (!this.m_ExitMode && packetEnvelope2.IsCommand)
							{
								global::Gibraltar.Messaging.CommandPacket commandPacket = (global::Gibraltar.Messaging.CommandPacket)messengerPacket;
								if (commandPacket.Command == global::Gibraltar.Messaging.MessagingCommand.ExitMode)
								{
									this.m_ExitingMode = true;
									global::Loupe.Extensibility.Data.SessionStatus sessionStatus = (global::Loupe.Extensibility.Data.SessionStatus)commandPacket.State;
									if (this.m_SessionSummary.Status < sessionStatus)
									{
										this.m_SessionSummary.Status = sessionStatus;
									}
								}
							}
						}
					}
				}
				if (flag && !global::Gibraltar.Messaging.Publisher.t_ThreadMustNotBlock && num3 > 0 && (packetEnvelope == null || packetEnvelope.Packet != packetArray[num2]))
				{
					global::Gibraltar.Messaging.CommandPacket packet = new global::Gibraltar.Messaging.CommandPacket(global::Gibraltar.Messaging.MessagingCommand.Flush);
					global::Gibraltar.Messaging.PacketEnvelope packetEnvelope3 = this.QueuePacket(packet, true);
					if (packetEnvelope3 != null)
					{
						packetEnvelope = packetEnvelope3;
					}
				}
				flag2 = (packetEnvelope != null && packetEnvelope.IsPending);
				global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
			}
			this.EnsureMessageDispatchThreadIsValid();
			if (packetEnvelope == null || global::Gibraltar.Messaging.Publisher.t_ThreadMustNotBlock)
			{
				return;
			}
			if (flag2)
			{
				global::Gibraltar.Messaging.Publisher.WaitOnPending(packetEnvelope);
			}
			if (flag)
			{
				global::Gibraltar.Messaging.Publisher.WaitOnPacket(packetEnvelope);
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x00065FB0 File Offset: 0x000641B0
		public string SessionName
		{
			get
			{
				return this.m_SessionName;
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x00065FB8 File Offset: 0x000641B8
		public global::Gibraltar.Monitor.SessionSummary SessionSummary
		{
			get
			{
				return this.m_SessionSummary;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00065FC0 File Offset: 0x000641C0
		public global::Gibraltar.Messaging.ICachedMessengerPacket[] HeaderPackets
		{
			get
			{
				object headerPacketsLock = this.m_HeaderPacketsLock;
				global::Gibraltar.Messaging.ICachedMessengerPacket[] result;
				lock (headerPacketsLock)
				{
					result = this.m_HeaderPackets.ToArray();
					global::System.Threading.Monitor.PulseAll(this.m_HeaderPacketsLock);
				}
				return result;
			}
		}

		// Token: 0x04000A9B RID: 2715
		private readonly global::Gibraltar.Monitor.SessionSummary m_SessionSummary;

		// Token: 0x04000A9C RID: 2716
		private readonly object m_MessageQueueLock = new object();

		// Token: 0x04000A9D RID: 2717
		private readonly object m_MessageDispatchThreadLock = new object();

		// Token: 0x04000A9E RID: 2718
		private readonly object m_HeaderPacketsLock = new object();

		// Token: 0x04000A9F RID: 2719
		private readonly object m_ConfigLock = new object();

		// Token: 0x04000AA0 RID: 2720
		private readonly global::Gibraltar.Serialization.PacketDefinitionList m_CachedTypes;

		// Token: 0x04000AA1 RID: 2721
		private readonly global::Gibraltar.Serialization.PacketCache m_PacketCache;

		// Token: 0x04000AA2 RID: 2722
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Messaging.ICachedMessengerPacket> m_HeaderPackets = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.ICachedMessengerPacket>();

		// Token: 0x04000AA3 RID: 2723
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope> m_MessageQueue;

		// Token: 0x04000AA4 RID: 2724
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope> m_MessageOverflowQueue;

		// Token: 0x04000AA5 RID: 2725
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Messaging.IMessenger> m_Messengers;

		// Token: 0x04000AA6 RID: 2726
		private readonly string m_SessionName;

		// Token: 0x04000AA7 RID: 2727
		private global::Gibraltar.Monitor.AgentConfiguration m_Configuration;

		// Token: 0x04000AA8 RID: 2728
		private global::System.Threading.Thread m_MessageDispatchThread;

		// Token: 0x04000AA9 RID: 2729
		private volatile bool m_MessageDispatchThreadFailed;

		// Token: 0x04000AAA RID: 2730
		private int m_MessageQueueMaxLength = 2000;

		// Token: 0x04000AAB RID: 2731
		private bool m_ForceWriteThrough;

		// Token: 0x04000AAC RID: 2732
		private bool m_Initialized;

		// Token: 0x04000AAD RID: 2733
		private bool m_ExitingMode;

		// Token: 0x04000AAE RID: 2734
		private bool m_ExitMode;

		// Token: 0x04000AAF RID: 2735
		private volatile bool m_Shutdown;

		// Token: 0x04000AB0 RID: 2736
		private long m_PacketSequence;

		// Token: 0x04000AB1 RID: 2737
		private bool m_Disposed;

		// Token: 0x04000AB2 RID: 2738
		[global::System.ThreadStatic]
		private static bool t_ThreadMustNotBlock;

		// Token: 0x04000AB3 RID: 2739
		[global::System.ThreadStatic]
		private static bool t_ThreadMustNotNotify;
	}
}
