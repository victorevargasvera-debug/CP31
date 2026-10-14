using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000086 RID: 134
	internal interface IIssueLink
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600063C RID: 1596
		global::System.Guid Id { get; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600063D RID: 1597
		string Caption { get; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600063E RID: 1598
		string Value { get; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600063F RID: 1599
		global::Loupe.Extensibility.Data.IIssue Issue { get; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000640 RID: 1600
		global::Loupe.Extensibility.Data.IIssueLinkType Type { get; }

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000641 RID: 1601
		string Url { get; }

		// Token: 0x06000642 RID: 1602
		void Remove();
	}
}
