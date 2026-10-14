using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000085 RID: 133
	internal interface IIssue
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600061E RID: 1566
		global::System.Guid Id { get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600061F RID: 1567
		string Name { get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000620 RID: 1568
		global::System.Uri Uri { get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000621 RID: 1569
		string Caption { get; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000622 RID: 1570
		string Description { get; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000623 RID: 1571
		string Workaround { get; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000624 RID: 1572
		global::Loupe.Extensibility.Data.IssueStatus Status { get; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000625 RID: 1573
		global::Loupe.Extensibility.Data.IDisplay StatusDisplay { get; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000626 RID: 1574
		bool IsPublic { get; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000627 RID: 1575
		string PublicCaption { get; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000628 RID: 1576
		string PublicDescription { get; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000629 RID: 1577
		string PublicWorkaround { get; }

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600062A RID: 1578
		int SessionCount { get; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600062B RID: 1579
		int ComputerCount { get; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600062C RID: 1580
		int ApplicationUserCount { get; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600062D RID: 1581
		global::System.DateTimeOffset UpdatedTimestamp { get; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600062E RID: 1582
		global::System.DateTimeOffset AddedTimestamp { get; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600062F RID: 1583
		global::Loupe.Extensibility.Data.IRepositoryApplication Application { get; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000630 RID: 1584
		global::Loupe.Extensibility.Data.IRepositoryApplicationVersion FixedIn { get; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000631 RID: 1585
		global::Loupe.Extensibility.Data.IUserProfile AddedBy { get; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000632 RID: 1586
		global::Loupe.Extensibility.Data.IUserProfile AssignedTo { get; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000633 RID: 1587
		global::Loupe.Extensibility.Data.IUserProfile UpdatedBy { get; }

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000634 RID: 1588
		global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IApplicationEvent> ApplicationEvents { get; }

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000635 RID: 1589
		global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IIssueLink> Links { get; }

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000636 RID: 1590
		global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IIssueNote> Notes { get; }

		// Token: 0x06000637 RID: 1591
		global::Loupe.Extensibility.Data.IIssueNote AddNote(global::Loupe.Extensibility.Data.IssueNoteCategory category, string note, string userName = null);

		// Token: 0x06000638 RID: 1592
		global::Loupe.Extensibility.Data.IIssueLink AddLink(global::Loupe.Extensibility.Data.IIssueLinkType type, string caption, string value);

		// Token: 0x06000639 RID: 1593
		void ReOpen(string note, string userName = null);

		// Token: 0x0600063A RID: 1594
		void Resolve(global::Loupe.Extensibility.Data.IRepositoryApplicationVersion fixedInVersion, string note, string userName = null);

		// Token: 0x0600063B RID: 1595
		void Suppress(string note, string userName = null);
	}
}
