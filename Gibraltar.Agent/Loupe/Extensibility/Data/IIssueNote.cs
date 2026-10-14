using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000088 RID: 136
	internal interface IIssueNote
	{
		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000648 RID: 1608
		global::System.Guid Id { get; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000649 RID: 1609
		int Sequence { get; }

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600064A RID: 1610
		string Note { get; }

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600064B RID: 1611
		global::Loupe.Extensibility.Data.IUserProfile AddedBy { get; }

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600064C RID: 1612
		global::System.DateTimeOffset AddedTimestamp { get; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600064D RID: 1613
		global::Loupe.Extensibility.Data.IIssue Issue { get; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600064E RID: 1614
		global::Loupe.Extensibility.Data.IssueNoteCategory Category { get; }
	}
}
