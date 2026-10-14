using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000198 RID: 408
	internal class LogMessageGroup : global::System.IComparable<global::Gibraltar.Monitor.LogMessageGroup>
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x00032C90 File Offset: 0x00030E90
		internal LogMessageGroup(string name, global::Gibraltar.Monitor.LogMessageGroup parent, global::Gibraltar.Monitor.LogMessage message)
		{
			this.MaxSeverity = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
			this.MaxSeverityWithChildren = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose;
			this.Name = name;
			this.Parent = parent;
			this.FullName = ((parent == null) ? name : (parent.FullName + "." + name));
			if (message != null)
			{
				this.AddMessage(message);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00032CFC File Offset: 0x00030EFC
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00032D04 File Offset: 0x00030F04
		public string Name { get; private set; }

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00032D10 File Offset: 0x00030F10
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00032D18 File Offset: 0x00030F18
		public global::Gibraltar.Monitor.LogMessageGroup Parent { get; private set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00032D24 File Offset: 0x00030F24
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00032D2C File Offset: 0x00030F2C
		public global::Loupe.Extensibility.Data.LogMessageSeverity MaxSeverityWithChildren { get; private set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00032D38 File Offset: 0x00030F38
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00032D40 File Offset: 0x00030F40
		public global::Loupe.Extensibility.Data.LogMessageSeverity MaxSeverity { get; private set; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00032D4C File Offset: 0x00030F4C
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00032D54 File Offset: 0x00030F54
		public int MessageCountWithChildren { get; private set; }

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00032D60 File Offset: 0x00030F60
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00032D68 File Offset: 0x00030F68
		public int MessageCount { get; private set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00032D74 File Offset: 0x00030F74
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00032D7C File Offset: 0x00030F7C
		public string FullName { get; private set; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00032D88 File Offset: 0x00030F88
		public global::Gibraltar.Monitor.LogMessageGroupCollection Groups
		{
			get
			{
				if (this.m_ChildGroups == null)
				{
					this.m_ChildGroups = new global::Gibraltar.Monitor.LogMessageGroupCollection(this);
				}
				return this.m_ChildGroups;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00032DA8 File Offset: 0x00030FA8
		public bool IsLeaf
		{
			get
			{
				return this.m_ChildGroups == null || this.Groups.Count == 0;
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00032DC8 File Offset: 0x00030FC8
		internal void AddMessage(global::Gibraltar.Monitor.LogMessage message)
		{
			int messageCount = this.MessageCount;
			this.MessageCount = messageCount + 1;
			this.MaxSeverity = (global::Loupe.Extensibility.Data.LogMessageSeverity)global::System.Math.Min((int)message.Severity, (int)this.MaxSeverity);
			this.AddChildMessage(message);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00032E08 File Offset: 0x00031008
		internal void AddChildMessage(global::Gibraltar.Monitor.LogMessage message)
		{
			int messageCountWithChildren = this.MessageCountWithChildren;
			this.MessageCountWithChildren = messageCountWithChildren + 1;
			this.MaxSeverityWithChildren = (global::Loupe.Extensibility.Data.LogMessageSeverity)global::System.Math.Min((int)message.Severity, (int)this.MaxSeverityWithChildren);
			if (this.Parent != null)
			{
				this.Parent.AddChildMessage(message);
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00032E58 File Offset: 0x00031058
		public int CompareTo(global::Gibraltar.Monitor.LogMessageGroup other)
		{
			return this.Name.CompareTo(other.Name);
		}

		// Token: 0x040005F8 RID: 1528
		private global::Gibraltar.Monitor.LogMessageGroupCollection m_ChildGroups;
	}
}
