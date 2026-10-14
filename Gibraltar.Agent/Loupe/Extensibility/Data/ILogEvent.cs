using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000081 RID: 129
	internal interface ILogEvent
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000600 RID: 1536
		global::Loupe.Extensibility.Data.IApplicationEvent ApplicationEvent { get; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000601 RID: 1537
		global::Loupe.Extensibility.Data.LogMessageSeverity Severity { get; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000602 RID: 1538
		string CategoryName { get; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000603 RID: 1539
		string ClassName { get; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000604 RID: 1540
		string Caption { get; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000605 RID: 1541
		int Occurrences { get; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000606 RID: 1542
		global::Loupe.Extensibility.Data.ILogMessage FirstOccurrence { get; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000607 RID: 1543
		global::System.DateTimeOffset LastOccurrenceTimestamp { get; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000608 RID: 1544
		global::System.Uri Uri { get; }
	}
}
