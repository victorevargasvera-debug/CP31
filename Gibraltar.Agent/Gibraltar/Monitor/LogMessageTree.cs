using System;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019A RID: 410
	internal class LogMessageTree
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x000333DC File Offset: 0x000315DC
		internal LogMessageTree(string name, string caption, string description, global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupFullNameDelegate fullNameDelegate, global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupDelegate messageGroupDelegate)
		{
			if (fullNameDelegate == null)
			{
				throw new global::System.ArgumentNullException("fullNameDelegate");
			}
			if (messageGroupDelegate == null)
			{
				throw new global::System.ArgumentNullException("messageGroupDelegate");
			}
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (string.IsNullOrEmpty(caption))
			{
				throw new global::System.ArgumentNullException("caption");
			}
			this.MaxSeverity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
			this.Name = name;
			this.Caption = caption;
			this.Description = description;
			this.m_FullNameDelegate = fullNameDelegate;
			this.m_MessageGroupDelegate = messageGroupDelegate;
			this.Groups = new global::Gibraltar.Monitor.LogMessageGroupCollection();
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0003348C File Offset: 0x0003168C
		internal void AddMessage(global::Gibraltar.Monitor.LogMessage message)
		{
			if (message == null)
			{
				throw new global::System.ArgumentNullException("message");
			}
			string text = this.m_FullNameDelegate(message);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			global::Gibraltar.Monitor.LogMessageGroup logMessageGroup;
			if (!this.m_GroupFullNameCache.TryGetValue(text, out logMessageGroup))
			{
				string[] array = this.m_MessageGroupDelegate(message);
				string text2 = array[0];
				global::Gibraltar.Monitor.LogMessageGroup logMessageGroup2;
				if (!this.Groups.TryGetValue(text2, out logMessageGroup2))
				{
					logMessageGroup2 = this.Groups.Add(text2, message);
				}
				for (int i = 1; i < array.Length; i++)
				{
					text2 = array[i];
					global::Gibraltar.Monitor.LogMessageGroup logMessageGroup3;
					if (logMessageGroup2.Groups.Count == 0 || !logMessageGroup2.Groups.TryGetValue(text2, out logMessageGroup3))
					{
						logMessageGroup3 = logMessageGroup2.Groups.Add(text2, message);
					}
					logMessageGroup2 = logMessageGroup3;
				}
				logMessageGroup = logMessageGroup2;
				this.m_GroupFullNameCache.Add(text, logMessageGroup);
			}
			logMessageGroup.AddMessage(message);
			this.MaxSeverity = (global::Loupe.Extensibility.Data.LogMessageSeverity)global::System.Math.Min((int)this.MaxSeverity, (int)message.Severity);
			int messageCount = this.MessageCount;
			this.MessageCount = messageCount + 1;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000335B0 File Offset: 0x000317B0
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x000335B8 File Offset: 0x000317B8
		public string Name { get; private set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000335C4 File Offset: 0x000317C4
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x000335CC File Offset: 0x000317CC
		public string Caption { get; private set; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000335D8 File Offset: 0x000317D8
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x000335E0 File Offset: 0x000317E0
		public string Description { get; private set; }

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x000335EC File Offset: 0x000317EC
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x000335F4 File Offset: 0x000317F4
		public global::Gibraltar.Monitor.LogMessageGroupCollection Groups { get; private set; }

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00033600 File Offset: 0x00031800
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00033608 File Offset: 0x00031808
		public global::Loupe.Extensibility.Data.LogMessageSeverity MaxSeverity { get; private set; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00033614 File Offset: 0x00031814
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x0003361C File Offset: 0x0003181C
		public int MessageCount { get; private set; }

		// Token: 0x04000605 RID: 1541
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.LogMessageGroup> m_GroupFullNameCache = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.LogMessageGroup>(global::System.StringComparer.InvariantCultureIgnoreCase);

		// Token: 0x04000606 RID: 1542
		private readonly global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupDelegate m_MessageGroupDelegate;

		// Token: 0x04000607 RID: 1543
		private readonly global::Gibraltar.Monitor.LogMessageTree.LogMessageGroupFullNameDelegate m_FullNameDelegate;

		// Token: 0x020004A5 RID: 1189
		// (Invoke) Token: 0x06003367 RID: 13159
		internal delegate string LogMessageGroupFullNameDelegate(global::Gibraltar.Monitor.LogMessage message);

		// Token: 0x020004A6 RID: 1190
		// (Invoke) Token: 0x0600336B RID: 13163
		internal delegate string[] LogMessageGroupDelegate(global::Gibraltar.Monitor.LogMessage message);
	}
}
