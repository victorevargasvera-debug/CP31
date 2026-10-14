using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000237 RID: 567
	[global::System.Diagnostics.DebuggerDisplay("Name={Name} Caption={Caption}")]
	internal abstract class MessengerBase : global::Gibraltar.Messaging.IMessenger, global::System.IEquatable<global::Gibraltar.Messaging.IMessenger>, global::System.IDisposable
	{
		// Token: 0x06001C72 RID: 7282 RVA: 0x00063F90 File Offset: 0x00062190
		protected MessengerBase(bool supportsWriteThrough = true)
		{
			this.m_SupportsWriteThrough = supportsWriteThrough;
			this.m_MessageQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope>(50);
			this.m_MessageOverflowQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope>(50);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00063FEC File Offset: 0x000621EC
		private void CreateMessageDispatchThread()
		{
			object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
			lock (messageDispatchThreadLock)
			{
				this.m_MessageDispatchThreadFailed = false;
				this.m_MessageDispatchThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.MessageDispatchMain));
				this.m_MessageDispatchThread.Name = "Loupe Messenger";
				this.m_MessageDispatchThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				this.m_MessageDispatchThread.IsBackground = true;
				this.m_MessageDispatchThread.Start();
				global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00064084 File Offset: 0x00062284
		private void MessageDispatchMain()
		{
			try
			{
				global::Gibraltar.Messaging.Publisher.ThreadMustNotBlock();
				object obj = this.m_MessageDispatchThreadLock;
				lock (obj)
				{
					this.EnsureInitialized();
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
					goto IL_160;
				}
				IL_2F:
				global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = null;
				obj = this.m_MessageQueueLock;
				lock (obj)
				{
					while (this.m_MessageQueue.Count == 0 && !this.m_Closed && (!this.AutoFlush || this.m_NextFlushDue > global::System.DateTime.Now))
					{
						global::System.Threading.Monitor.Wait(this.m_MessageQueueLock, 1000);
					}
					if (this.m_MessageQueue.Count > 0)
					{
						packetEnvelope = this.m_MessageQueue.Dequeue();
						if (this.m_MessageQueue.Count < this.m_MessageQueueMaxLength)
						{
							this.m_MaintenanceMode = false;
						}
						while (this.m_MessageOverflowQueue.Count > 0 && this.m_MessageQueue.Count < this.m_MessageQueueMaxLength)
						{
							this.TransferOverflow();
						}
					}
					global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
				}
				if (packetEnvelope != null)
				{
					global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceModeRequest = global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.None;
					this.DispatchPacket(packetEnvelope, ref maintenanceModeRequest);
					if (maintenanceModeRequest != global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.None && (!this.m_Exiting || maintenanceModeRequest == global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.Explicit))
					{
						this.EnterMaintenanceMode();
					}
				}
				if (this.AutoFlush && this.m_NextFlushDue <= global::System.DateTime.Now)
				{
					this.ActionOnFlush();
				}
				IL_160:
				if (!this.m_Closed && this.m_Initialized)
				{
					goto IL_2F;
				}
				this.m_MessageDispatchThread = null;
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

		// Token: 0x06001C75 RID: 7285 RVA: 0x000642C4 File Offset: 0x000624C4
		private void OnThreadAbort()
		{
			object messageQueueLock = this.m_MessageQueueLock;
			lock (messageQueueLock)
			{
				if (this.m_Exiting)
				{
					this.m_Closed = true;
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
				}
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0006436C File Offset: 0x0006256C
		private void TransferOverflow()
		{
			global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = this.m_MessageOverflowQueue.Dequeue();
			this.m_MessageQueue.Enqueue(packetEnvelope);
			packetEnvelope.IsPending = false;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0006439C File Offset: 0x0006259C
		private void DispatchPacket(global::Gibraltar.Messaging.PacketEnvelope packetEnvelope, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			lock (packetEnvelope)
			{
				if (packetEnvelope.IsCommand)
				{
					global::Gibraltar.Messaging.CommandPacket commandPacket = (global::Gibraltar.Messaging.CommandPacket)packetEnvelope.Packet;
					global::Gibraltar.Messaging.MessagingCommand command = commandPacket.Command;
					switch (command)
					{
					case global::Gibraltar.Messaging.MessagingCommand.Flush:
						this.ActionOnFlush();
						goto IL_AD;
					case global::Gibraltar.Messaging.MessagingCommand.ExitMode:
						this.m_Exiting = true;
						this.m_Exited = true;
						this.ActionOnFlush();
						this.ActionOnExit();
						goto IL_AD;
					case global::Gibraltar.Messaging.MessagingCommand.CloseMessenger:
						this.m_Closed = true;
						this.ActionOnClose();
						goto IL_AD;
					}
					this.ActionOnCommand(command, commandPacket.State, packetEnvelope.WriteThrough, ref maintenanceRequested);
				}
				else
				{
					this.ActionOnWrite(packetEnvelope.Packet, packetEnvelope.WriteThrough, ref maintenanceRequested);
				}
				IL_AD:
				packetEnvelope.IsCommitted = true;
				global::System.Threading.Monitor.PulseAll(packetEnvelope);
			}
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00064480 File Offset: 0x00062680
		private void EnterMaintenanceMode()
		{
			object messageQueueLock = this.m_MessageQueueLock;
			lock (messageQueueLock)
			{
				this.m_MaintenanceMode = true;
				while (this.m_MessageOverflowQueue.Count > 0)
				{
					this.TransferOverflow();
				}
				global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
			}
			this.ActionOnMaintenance();
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x000644E8 File Offset: 0x000626E8
		private void ActionOnCommand(global::Gibraltar.Messaging.MessagingCommand command, object state, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			try
			{
				this.OnCommand(command, state, writeThrough, ref maintenanceRequested);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00064520 File Offset: 0x00062720
		private void ActionOnExit()
		{
			try
			{
				this.OnExit();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00064554 File Offset: 0x00062754
		private void ActionOnClose()
		{
			try
			{
				this.OnClose();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00064588 File Offset: 0x00062788
		private void ActionOnConfigurationUpdate(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			try
			{
				this.OnConfigurationUpdate(configuration);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000645BC File Offset: 0x000627BC
		private void ActionOnFlush()
		{
			if (this.AutoFlush)
			{
				this.UpdateNextFlushDue();
			}
			try
			{
				this.OnFlush();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00064600 File Offset: 0x00062800
		private void ActionOnInitialize(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			try
			{
				this.OnInitialize(configuration);
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Messenger", "Initialized " + this.Name + " Messenger", "{0}\r\n{1}\r\n\r\nConfiguration:\r\n{2}", new object[]
					{
						this.Caption,
						this.Description,
						configuration
					});
				}
				if (this.AutoFlush)
				{
					this.UpdateNextFlushDue();
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
				throw;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00064690 File Offset: 0x00062890
		private void ActionOnMaintenance()
		{
			try
			{
				this.OnMaintenance();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000646C4 File Offset: 0x000628C4
		private void ActionOnOverflow()
		{
			try
			{
				this.OnOverflow();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000646F8 File Offset: 0x000628F8
		private void ActionOnOverflowRestore()
		{
			try
			{
				this.OnOverflowRestore();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0006472C File Offset: 0x0006292C
		private void ActionOnWrite(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			try
			{
				this.OnWrite(packet, writeThrough, ref maintenanceRequested);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00064764 File Offset: 0x00062964
		private void UpdateNextFlushDue()
		{
			this.m_NextFlushDue = global::System.DateTime.Now.AddSeconds((double)this.AutoFlushInterval);
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00064790 File Offset: 0x00062990
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00064798 File Offset: 0x00062998
		protected bool AutoFlush { get; set; }

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000647A4 File Offset: 0x000629A4
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x000647AC File Offset: 0x000629AC
		protected int AutoFlushInterval { get; set; }

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000647B8 File Offset: 0x000629B8
		protected global::Gibraltar.Messaging.Publisher Publisher
		{
			get
			{
				return this.m_Publisher;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x000647C0 File Offset: 0x000629C0
		protected bool Exiting
		{
			get
			{
				return this.m_Exiting;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000647CC File Offset: 0x000629CC
		protected bool Exited
		{
			get
			{
				return this.m_Exited;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000647D4 File Offset: 0x000629D4
		protected bool Closed
		{
			get
			{
				return this.m_Closed;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000647DC File Offset: 0x000629DC
		protected bool Initialized
		{
			get
			{
				return this.m_Initialized;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000647E8 File Offset: 0x000629E8
		protected bool ForceWriteThrough
		{
			get
			{
				return this.m_ForceWriteThrough;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000647F0 File Offset: 0x000629F0
		protected object QueueLock
		{
			get
			{
				return this.m_MessageQueueLock;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x000647F8 File Offset: 0x000629F8
		protected object ThreadLock
		{
			get
			{
				return this.m_MessageDispatchThreadLock;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00064800 File Offset: 0x00062A00
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x00064808 File Offset: 0x00062A08
		protected global::Gibraltar.Messaging.OverflowMode OverflowMode { get; set; }

		// Token: 0x06001C92 RID: 7314 RVA: 0x00064814 File Offset: 0x00062A14
		protected void EnsureInitialized()
		{
			if (!this.m_Initialized)
			{
				this.m_Name = this.m_Configuration.Name;
				this.m_Caption = this.m_Name;
				this.m_ForceWriteThrough = this.m_Configuration.ForceSynchronous;
				this.m_MessageQueueMaxLength = this.m_Configuration.MaxQueueLength;
				try
				{
					this.ActionOnInitialize(this.m_Configuration);
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					throw;
				}
				this.m_Initialized = true;
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000648A0 File Offset: 0x00062AA0
		protected void EnsureMessageDispatchThreadIsValid()
		{
			if (this.m_MessageDispatchThreadFailed)
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

		// Token: 0x06001C94 RID: 7316 RVA: 0x00064904 File Offset: 0x00062B04
		protected void EnsureOpen(string caller)
		{
			if (this.m_Closed)
			{
				throw new global::System.ArgumentException("The messenger has been closed, so " + caller + " can no longer be called.");
			}
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00064928 File Offset: 0x00062B28
		protected global::Gibraltar.Messaging.PacketEnvelope QueuePacket(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough)
		{
			object messageQueueLock = this.m_MessageQueueLock;
			global::Gibraltar.Messaging.PacketEnvelope result;
			lock (messageQueueLock)
			{
				global::Gibraltar.Messaging.PacketEnvelope packetEnvelope = new global::Gibraltar.Messaging.PacketEnvelope(packet, writeThrough);
				if (packetEnvelope.IsCommand)
				{
					global::Gibraltar.Messaging.MessagingCommand command = ((global::Gibraltar.Messaging.CommandPacket)packet).Command;
					if (command == global::Gibraltar.Messaging.MessagingCommand.Flush)
					{
						if (this.AutoFlush)
						{
							this.UpdateNextFlushDue();
						}
					}
					else if (command == global::Gibraltar.Messaging.MessagingCommand.ExitMode || command == global::Gibraltar.Messaging.MessagingCommand.CloseMessenger)
					{
						this.m_Exiting = true;
					}
				}
				if (!this.m_MaintenanceMode && (this.m_MessageOverflowQueue.Count > 0 || this.m_MessageQueue.Count > this.m_MessageQueueMaxLength))
				{
					if (this.OverflowMode == global::Gibraltar.Messaging.OverflowMode.Drop)
					{
						this.m_DroppedPackets += 1L;
						packetEnvelope.IsCommitted = true;
					}
					else
					{
						this.m_MessageOverflowQueue.Enqueue(packetEnvelope);
						packetEnvelope.IsPending = true;
						if (!this.m_InOverflowMode)
						{
							this.m_InOverflowMode = true;
							this.ActionOnOverflow();
						}
					}
				}
				else
				{
					this.m_MessageQueue.Enqueue(packetEnvelope);
					if (this.m_InOverflowMode)
					{
						this.m_InOverflowMode = false;
						this.ActionOnOverflowRestore();
					}
				}
				result = packetEnvelope;
			}
			return result;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00064A70 File Offset: 0x00062C70
		protected static void WaitOnPacket(global::Gibraltar.Messaging.PacketEnvelope packetEnvelope)
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

		// Token: 0x06001C97 RID: 7319 RVA: 0x00064ABC File Offset: 0x00062CBC
		protected static void WaitOnPending(global::Gibraltar.Messaging.PacketEnvelope packetEnvelope)
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

		// Token: 0x06001C98 RID: 7320 RVA: 0x00064B08 File Offset: 0x00062D08
		protected virtual void OnCommand(global::Gibraltar.Messaging.MessagingCommand command, object state, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00064B0C File Offset: 0x00062D0C
		protected virtual void OnExit()
		{
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00064B10 File Offset: 0x00062D10
		protected virtual void OnClose()
		{
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00064B14 File Offset: 0x00062D14
		protected virtual void OnConfigurationUpdate(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00064B18 File Offset: 0x00062D18
		protected virtual void OnFlush()
		{
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00064B1C File Offset: 0x00062D1C
		protected virtual void OnInitialize(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00064B20 File Offset: 0x00062D20
		protected virtual void OnMaintenance()
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00064B24 File Offset: 0x00062D24
		protected virtual void OnOverflow()
		{
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00064B28 File Offset: 0x00062D28
		protected virtual void OnOverflowRestore()
		{
		}

		// Token: 0x06001CA1 RID: 7329
		protected abstract void OnWrite(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested);

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00064B2C File Offset: 0x00062D2C
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x00064B34 File Offset: 0x00062D34
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			protected set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00064B40 File Offset: 0x00062D40
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x00064B48 File Offset: 0x00062D48
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			protected set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00064B54 File Offset: 0x00062D54
		public void ConfigurationUpdated(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			this.EnsureOpen("ConfigurationUpdated");
			object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
			lock (messageDispatchThreadLock)
			{
				this.m_Configuration = configuration;
				if (this.m_Initialized)
				{
					this.ActionOnConfigurationUpdate(this.m_Configuration);
				}
				global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
			}
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00064BC0 File Offset: 0x00062DC0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00064BD0 File Offset: 0x00062DD0
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				if (releaseManaged && !this.m_Closed)
				{
					this.Write(new global::Gibraltar.Messaging.CommandPacket(global::Gibraltar.Messaging.MessagingCommand.CloseMessenger), true);
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00064C04 File Offset: 0x00062E04
		public bool Equals(global::Gibraltar.Messaging.IMessenger other)
		{
			return other != null && this.m_Name.Equals(other.Name);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00064C20 File Offset: 0x00062E20
		public void Initialize(global::Gibraltar.Messaging.Publisher publisher, global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			this.EnsureOpen("Initialize");
			this.m_Publisher = publisher;
			this.m_Configuration = configuration;
			this.CreateMessageDispatchThread();
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x00064C44 File Offset: 0x00062E44
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00064C4C File Offset: 0x00062E4C
		public void Write(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough)
		{
			if (packet == null)
			{
				return;
			}
			object messageQueueLock = this.m_MessageQueueLock;
			bool flag;
			global::Gibraltar.Messaging.PacketEnvelope packetEnvelope;
			bool isPending;
			lock (messageQueueLock)
			{
				if (this.m_Closed)
				{
					return;
				}
				flag = (this.m_SupportsWriteThrough && (this.m_ForceWriteThrough || writeThrough || this.m_Exiting));
				packetEnvelope = this.QueuePacket(packet, flag);
				isPending = packetEnvelope.IsPending;
				global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
			}
			this.EnsureMessageDispatchThreadIsValid();
			if (isPending)
			{
				global::Gibraltar.Messaging.MessengerBase.WaitOnPending(packetEnvelope);
			}
			if (flag)
			{
				global::Gibraltar.Messaging.MessengerBase.WaitOnPacket(packetEnvelope);
			}
		}

		// Token: 0x04000A6C RID: 2668
		public const string LogCategory = "Loupe.Messenger";

		// Token: 0x04000A6D RID: 2669
		private readonly bool m_SupportsWriteThrough;

		// Token: 0x04000A6E RID: 2670
		private readonly object m_MessageQueueLock = new object();

		// Token: 0x04000A6F RID: 2671
		private readonly object m_MessageDispatchThreadLock = new object();

		// Token: 0x04000A70 RID: 2672
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope> m_MessageQueue;

		// Token: 0x04000A71 RID: 2673
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.PacketEnvelope> m_MessageOverflowQueue;

		// Token: 0x04000A72 RID: 2674
		private string m_Caption;

		// Token: 0x04000A73 RID: 2675
		private string m_Description;

		// Token: 0x04000A74 RID: 2676
		private string m_Name;

		// Token: 0x04000A75 RID: 2677
		private global::Gibraltar.Messaging.Publisher m_Publisher;

		// Token: 0x04000A76 RID: 2678
		private global::Gibraltar.Messaging.MessengerConfiguration m_Configuration;

		// Token: 0x04000A77 RID: 2679
		private global::System.Threading.Thread m_MessageDispatchThread;

		// Token: 0x04000A78 RID: 2680
		private volatile bool m_MessageDispatchThreadFailed;

		// Token: 0x04000A79 RID: 2681
		private int m_MessageQueueMaxLength = 2000;

		// Token: 0x04000A7A RID: 2682
		private bool m_ForceWriteThrough;

		// Token: 0x04000A7B RID: 2683
		private volatile bool m_Initialized;

		// Token: 0x04000A7C RID: 2684
		private volatile bool m_Exiting;

		// Token: 0x04000A7D RID: 2685
		private bool m_Exited;

		// Token: 0x04000A7E RID: 2686
		private bool m_Closed;

		// Token: 0x04000A7F RID: 2687
		private bool m_InOverflowMode;

		// Token: 0x04000A80 RID: 2688
		private bool m_MaintenanceMode;

		// Token: 0x04000A81 RID: 2689
		private bool m_Disposed;

		// Token: 0x04000A82 RID: 2690
		private global::System.DateTime m_NextFlushDue;

		// Token: 0x04000A83 RID: 2691
		private long m_DroppedPackets;

		// Token: 0x020004B7 RID: 1207
		protected enum MaintenanceModeRequest
		{
			// Token: 0x040013A8 RID: 5032
			None,
			// Token: 0x040013A9 RID: 5033
			Regular,
			// Token: 0x040013AA RID: 5034
			Explicit
		}
	}
}
