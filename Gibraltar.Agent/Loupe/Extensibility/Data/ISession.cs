using System;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000077 RID: 119
	internal interface ISession : global::System.IEquatable<global::Loupe.Extensibility.Data.ISession>, global::System.IComparable<global::Loupe.Extensibility.Data.ISession>
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000599 RID: 1433
		global::System.Guid Id { get; }

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600059A RID: 1434
		string Caption { get; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600059B RID: 1435
		string Description { get; }

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600059C RID: 1436
		bool HasCorruptData { get; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600059D RID: 1437
		global::Loupe.Extensibility.Data.SessionStatus Status { get; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600059E RID: 1438
		global::Loupe.Extensibility.Data.LogMessageSeverity TopSeverity { get; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600059F RID: 1439
		int MessageCount { get; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060005A0 RID: 1440
		int CriticalCount { get; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060005A1 RID: 1441
		int ErrorCount { get; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060005A2 RID: 1442
		int WarningCount { get; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060005A3 RID: 1443
		global::Loupe.Extensibility.Data.ISessionSummary Summary { get; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060005A4 RID: 1444
		global::Loupe.Extensibility.Data.IThreadInfoCollection Threads { get; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060005A5 RID: 1445
		global::Loupe.Extensibility.Data.IAssemblyInfoCollection Assemblies { get; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060005A6 RID: 1446
		global::Loupe.Extensibility.Data.IApplicationUserCollection Users { get; }

		// Token: 0x060005A7 RID: 1447
		global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ILogMessage> GetMessages();

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060005A8 RID: 1448
		global::Loupe.Extensibility.Data.IMetricDefinitionCollection MetricDefinitions { get; }
	}
}
