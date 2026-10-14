using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200008D RID: 141
	internal interface IApplicationEvent
	{
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000660 RID: 1632
		global::System.Guid Id { get; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000661 RID: 1633
		global::System.Uri Uri { get; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000662 RID: 1634
		string Caption { get; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000663 RID: 1635
		string FingerprintHash { get; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000664 RID: 1636
		global::Loupe.Extensibility.Data.LogMessageSeverity Severity { get; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000665 RID: 1637
		global::Loupe.Extensibility.Data.IDisplay SeverityDisplay { get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000666 RID: 1638
		int SessionCount { get; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000667 RID: 1639
		long OccurrenceCount { get; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000668 RID: 1640
		int ApplicationUserCount { get; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000669 RID: 1641
		bool IsSuppressed { get; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600066A RID: 1642
		int ComputerCount { get; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600066B RID: 1643
		bool ForReview { get; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600066C RID: 1644
		global::System.DateTimeOffset LastOccurrenceTimestamp { get; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600066D RID: 1645
		global::System.DateTimeOffset FirstOccurrenceTimestamp { get; }

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600066E RID: 1646
		global::Loupe.Extensibility.Data.IRepositoryApplication Application { get; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600066F RID: 1647
		global::Loupe.Extensibility.Data.IRepositoryApplicationVersion FirstVersion { get; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000670 RID: 1648
		global::Loupe.Extensibility.Data.IRepositoryApplicationVersion LastVersion { get; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000671 RID: 1649
		global::Loupe.Extensibility.Data.IReleaseType MaxReleaseType { get; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000672 RID: 1650
		global::Loupe.Extensibility.Data.IIssue Issue { get; }

		// Token: 0x06000673 RID: 1651
		global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ILogEvent> GetLogEvents();

		// Token: 0x06000674 RID: 1652
		global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IComputer> GetComputers();

		// Token: 0x06000675 RID: 1653
		global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ISessionSummary> GetSessions();

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000676 RID: 1654
		global::Loupe.Extensibility.Data.IComputer LastComputer { get; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000677 RID: 1655
		global::Loupe.Extensibility.Data.IApplicationUser LastApplicationUser { get; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000678 RID: 1656
		global::Loupe.Extensibility.Data.ILogEvent LastLogEvent { get; }

		// Token: 0x06000679 RID: 1657
		void AddIssue(string caption, string description, string workaround, bool activate, bool isPublic, string publicCaption = null, string publicDescription = null, string publicWorkaround = null, string note = null, string assignedUserName = null, string userName = null);
	}
}
