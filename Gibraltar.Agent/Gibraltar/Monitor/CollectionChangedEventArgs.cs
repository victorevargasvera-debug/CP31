using System;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A2 RID: 418
	internal class CollectionChangedEventArgs<CollectionType, CollectedObjectType> : global::System.EventArgs
	{
		// Token: 0x06001267 RID: 4711 RVA: 0x000357DC File Offset: 0x000339DC
		public CollectionChangedEventArgs(CollectionType collection, CollectedObjectType subject, global::Gibraltar.Monitor.CollectionAction action)
		{
			this.m_Collection = collection;
			this.m_Subject = subject;
			this.m_Action = action;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x000357FC File Offset: 0x000339FC
		public CollectedObjectType Subject
		{
			get
			{
				return this.m_Subject;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00035804 File Offset: 0x00033A04
		public CollectionType Collection
		{
			get
			{
				return this.m_Collection;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0003580C File Offset: 0x00033A0C
		public global::Gibraltar.Monitor.CollectionAction Action
		{
			get
			{
				return this.m_Action;
			}
		}

		// Token: 0x04000639 RID: 1593
		private readonly CollectionType m_Collection;

		// Token: 0x0400063A RID: 1594
		private readonly CollectedObjectType m_Subject;

		// Token: 0x0400063B RID: 1595
		private readonly global::Gibraltar.Monitor.CollectionAction m_Action;
	}
}
