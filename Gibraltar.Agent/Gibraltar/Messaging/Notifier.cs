using System;
using System.Collections.Generic;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x0200022D RID: 557
	internal class Notifier
	{
		// Token: 0x14000082 RID: 130
		// (add) Token: 0x06001BEF RID: 7151 RVA: 0x00062080 File Offset: 0x00060280
		// (remove) Token: 0x06001BF0 RID: 7152 RVA: 0x000620BC File Offset: 0x000602BC
		private event global::Gibraltar.Messaging.NotificationEventHandler m_NotificationEvent;

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000620F8 File Offset: 0x000602F8
		public Notifier(global::Loupe.Extensibility.Data.LogMessageSeverity minimumSeverity, string notifierName)
		{
			this.m_MessageQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.Internal.LogMessagePacket>(50);
			this.m_MinimumSeverity = minimumSeverity;
			this.m_MinimumWaitNextNotify = global::System.TimeSpan.Zero;
			this.m_MessageDispatchThreadFailed = true;
			if (string.IsNullOrEmpty(notifierName))
			{
				this.m_NotifierName = string.Empty;
				this.m_NotifierCategoryName = "Gibraltar.Agent.Notifier";
				return;
			}
			this.m_NotifierName = notifierName;
			this.m_NotifierCategoryName = string.Format("{0}.{1}", "Gibraltar.Agent.Notifier", notifierName);
		}

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x06001BF2 RID: 7154 RVA: 0x00062198 File Offset: 0x00060398
		// (remove) Token: 0x06001BF3 RID: 7155 RVA: 0x0006220C File Offset: 0x0006040C
		public event global::Gibraltar.Messaging.NotificationEventHandler NotificationEvent
		{
			add
			{
				if (value == null)
				{
					return;
				}
				object messageQueueLock = this.m_MessageQueueLock;
				lock (messageQueueLock)
				{
					if (this.m_NotificationEvent == null)
					{
						global::Gibraltar.Messaging.Publisher.LogMessageNotify -= this.Publisher_LogMessageNotify;
						global::Gibraltar.Messaging.Publisher.LogMessageNotify += this.Publisher_LogMessageNotify;
					}
					this.m_NotificationEvent += value;
				}
			}
			remove
			{
				if (value == null)
				{
					return;
				}
				object messageQueueLock = this.m_MessageQueueLock;
				lock (messageQueueLock)
				{
					if (this.m_NotificationEvent != null)
					{
						this.m_NotificationEvent -= value;
						if (this.m_NotificationEvent == null)
						{
							global::Gibraltar.Messaging.Publisher.LogMessageNotify -= this.Publisher_LogMessageNotify;
							this.m_MessageQueue.Clear();
							global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
						}
					}
				}
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00062294 File Offset: 0x00060494
		public string NotifierCategoryName
		{
			get
			{
				return this.m_NotifierCategoryName;
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0006229C File Offset: 0x0006049C
		private void Publisher_LogMessageNotify(object sender, global::Gibraltar.Messaging.LogMessageNotifyEventArgs e)
		{
			this.QueuePacket(e.Packet);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000622AC File Offset: 0x000604AC
		private void QueuePacket(global::Gibraltar.Messaging.IMessengerPacket messengerPacket)
		{
			global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = messengerPacket as global::Gibraltar.Monitor.Internal.LogMessagePacket;
			if (logMessagePacket == null || logMessagePacket.SuppressNotification)
			{
				return;
			}
			if (logMessagePacket.Severity > this.m_MinimumSeverity)
			{
				return;
			}
			object messageQueueLock = this.m_MessageQueueLock;
			lock (messageQueueLock)
			{
				if (this.m_NotificationEvent == null)
				{
					return;
				}
				int count = this.m_MessageQueue.Count;
				if (count < this.m_MessageQueueMaxLength)
				{
					if (count <= 0)
					{
						this.m_BurstCollectionWait = global::System.DateTimeOffset.MinValue;
					}
					this.m_MessageQueue.Enqueue(logMessagePacket);
					if (count <= 0 || global::System.DateTimeOffset.Now >= this.m_NextNotifyAfter)
					{
						global::System.Threading.Monitor.PulseAll(this.m_MessageQueueLock);
					}
				}
			}
			this.EnsureNotificationThreadIsValid();
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00062380 File Offset: 0x00060580
		private void EnsureNotificationThreadIsValid()
		{
			if (this.m_MessageDispatchThreadFailed)
			{
				object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
				lock (messageDispatchThreadLock)
				{
					if (this.m_MessageDispatchThreadFailed)
					{
						this.CreateNotificationDispatchThread();
					}
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
				}
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000623E4 File Offset: 0x000605E4
		private void CreateNotificationDispatchThread()
		{
			object messageDispatchThreadLock = this.m_MessageDispatchThreadLock;
			lock (messageDispatchThreadLock)
			{
				this.m_MessageDispatchThreadFailed = false;
				string name = string.IsNullOrEmpty(this.m_NotifierName) ? "Gibraltar Notifier" : string.Format("{0} {1}", "Gibraltar Notifier", this.m_NotifierName);
				this.m_MessageDispatchThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.NotificationDispatchMain));
				this.m_MessageDispatchThread.Name = name;
				this.m_MessageDispatchThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				this.m_MessageDispatchThread.IsBackground = true;
				this.m_MessageDispatchThread.Start();
				global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x000624A8 File Offset: 0x000606A8
		private void NotificationDispatchMain()
		{
			try
			{
				global::Gibraltar.Messaging.Publisher.ThreadMustNotNotify();
				for (;;)
				{
					global::Loupe.Extensibility.Data.ILogMessage[] array = null;
					object obj = this.m_MessageQueueLock;
					global::Gibraltar.Messaging.NotificationEventHandler notificationEvent;
					lock (obj)
					{
						while (this.m_MessageQueue.Count <= 0)
						{
							global::System.Threading.Monitor.Wait(this.m_MessageQueueLock);
							if (this.m_NotificationEvent == null)
							{
								this.m_MinimumWaitNextNotify = global::System.TimeSpan.Zero;
								this.m_NextNotifyAfter = global::System.DateTimeOffset.UtcNow;
								this.m_MessageQueue.Clear();
							}
						}
						global::System.DateTimeOffset utcNow = global::System.DateTimeOffset.UtcNow;
						if (this.m_BurstCollectionWait == global::System.DateTimeOffset.MinValue)
						{
							this.m_BurstCollectionWait = this.m_MessageQueue.Peek().Timestamp.AddMilliseconds(28.0);
							if (this.m_BurstCollectionWait < utcNow)
							{
								this.m_BurstCollectionWait = utcNow.AddMilliseconds(10.0);
							}
						}
						if (this.m_NextNotifyAfter < this.m_BurstCollectionWait && this.m_BurstCollectionWait > utcNow)
						{
							this.m_NextNotifyAfter = this.m_BurstCollectionWait;
						}
						while (this.m_NextNotifyAfter > utcNow && this.m_MessageQueue.Count > 0)
						{
							global::System.TimeSpan timeout = this.m_NextNotifyAfter - utcNow;
							global::System.Threading.Monitor.Wait(this.m_MessageQueueLock, timeout);
							utcNow = global::System.DateTimeOffset.UtcNow;
						}
						notificationEvent = this.m_NotificationEvent;
						if (notificationEvent == null)
						{
							this.m_MinimumWaitNextNotify = global::System.TimeSpan.Zero;
							this.m_NextNotifyAfter = global::System.DateTimeOffset.UtcNow;
						}
						else if (this.m_MessageQueue.Count > 0)
						{
							array = this.m_MessageQueue.ToArray();
						}
						this.m_MessageQueue.Clear();
					}
					if (array != null)
					{
						global::Gibraltar.Messaging.NotificationEventArgs notificationEventArgs = new global::Gibraltar.Messaging.NotificationEventArgs(array, this.m_MinimumWaitNextNotify);
						global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.Configuration.Server;
						if (notificationEventArgs.TopSeverity <= global::Loupe.Extensibility.Data.LogMessageSeverity.Error && server.AutoSendOnError && server.AutoSendSessions && server.Enabled && global::Gibraltar.Monitor.Log.AutoSendConsentGranted)
						{
							notificationEventArgs.SendSession = true;
							notificationEventArgs.MinimumNotificationDelay = new global::System.TimeSpan(0, 5, 0);
						}
						try
						{
							notificationEvent(this, notificationEventArgs);
						}
						catch (global::System.Exception ex)
						{
							if (ex is global::System.Threading.ThreadAbortException)
							{
								throw;
							}
							global::Gibraltar.Monitor.Log.RecordException(this.EventErrorSourceProvider, ex, null, this.m_NotifierCategoryName, true);
						}
						finally
						{
							this.m_MinimumWaitNextNotify = notificationEventArgs.MinimumNotificationDelay;
							if (this.m_MinimumWaitNextNotify < global::System.TimeSpan.Zero)
							{
								this.m_MinimumWaitNextNotify = global::System.TimeSpan.Zero;
							}
							if (notificationEventArgs.SendSession)
							{
								global::Gibraltar.Monitor.Log.SendSessions(new global::Gibraltar.Data.SessionCriteria?(global::Gibraltar.Data.SessionCriteria.ActiveSession), null, true);
							}
							this.m_LastNotifyCompleted = global::System.DateTimeOffset.UtcNow;
							this.m_NextNotifyAfter = this.m_LastNotifyCompleted + this.m_MinimumWaitNextNotify;
						}
					}
				}
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
				object obj = this.m_MessageDispatchThreadLock;
				lock (obj)
				{
					this.m_MessageDispatchThread = null;
					this.m_MessageDispatchThreadFailed = true;
					global::System.Threading.Monitor.PulseAll(this.m_MessageDispatchThreadLock);
				}
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x0006282C File Offset: 0x00060A2C
		private global::Gibraltar.Monitor.MessageSourceProvider EventErrorSourceProvider
		{
			get
			{
				if (this.m_EventErrorSourceProvider == null)
				{
					this.m_EventErrorSourceProvider = new global::Gibraltar.Monitor.MessageSourceProvider("Gibraltar.Messaging.Notifier", "NotificationDispatchMain");
				}
				return this.m_EventErrorSourceProvider;
			}
		}

		// Token: 0x04000A1F RID: 2591
		private const string NotifierCategoryBase = "Gibraltar.Agent.Notifier";

		// Token: 0x04000A20 RID: 2592
		private const string NotifierThreadBase = "Gibraltar Notifier";

		// Token: 0x04000A21 RID: 2593
		private const int BurstMillisecondLatency = 28;

		// Token: 0x04000A22 RID: 2594
		private readonly object m_MessageQueueLock = new object();

		// Token: 0x04000A23 RID: 2595
		private readonly object m_MessageDispatchThreadLock = new object();

		// Token: 0x04000A24 RID: 2596
		private readonly global::Loupe.Extensibility.Data.LogMessageSeverity m_MinimumSeverity;

		// Token: 0x04000A25 RID: 2597
		private readonly string m_NotifierName;

		// Token: 0x04000A26 RID: 2598
		private readonly string m_NotifierCategoryName;

		// Token: 0x04000A27 RID: 2599
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Monitor.Internal.LogMessagePacket> m_MessageQueue;

		// Token: 0x04000A28 RID: 2600
		private global::System.Threading.Thread m_MessageDispatchThread;

		// Token: 0x04000A29 RID: 2601
		private volatile bool m_MessageDispatchThreadFailed;

		// Token: 0x04000A2A RID: 2602
		private int m_MessageQueueMaxLength = 2000;

		// Token: 0x04000A2B RID: 2603
		private global::System.DateTimeOffset m_BurstCollectionWait;

		// Token: 0x04000A2C RID: 2604
		private global::System.DateTimeOffset m_LastNotifyCompleted;

		// Token: 0x04000A2D RID: 2605
		private global::System.TimeSpan m_MinimumWaitNextNotify;

		// Token: 0x04000A2E RID: 2606
		private global::System.DateTimeOffset m_NextNotifyAfter;

		// Token: 0x04000A2F RID: 2607
		private global::Gibraltar.Monitor.MessageSourceProvider m_EventErrorSourceProvider;
	}
}
