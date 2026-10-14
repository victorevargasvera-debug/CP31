using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000069 RID: 105
	internal interface ILogMessage : global::System.IComparable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.IEquatable<global::Loupe.Extensibility.Data.ILogMessage>
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000519 RID: 1305
		global::Loupe.Extensibility.Data.ISession Session { get; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600051A RID: 1306
		global::System.Guid Id { get; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600051B RID: 1307
		long Sequence { get; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600051C RID: 1308
		global::System.DateTimeOffset Timestamp { get; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600051D RID: 1309
		global::System.DateTimeOffset DisplayTimestamp { get; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600051E RID: 1310
		global::Loupe.Extensibility.Data.LogMessageSeverity Severity { get; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600051F RID: 1311
		string LogSystem { get; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000520 RID: 1312
		string CategoryName { get; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000521 RID: 1313
		string UserName { get; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000522 RID: 1314
		string Caption { get; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000523 RID: 1315
		string Description { get; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000524 RID: 1316
		string Details { get; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000525 RID: 1317
		string MethodName { get; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000526 RID: 1318
		string ClassName { get; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000527 RID: 1319
		string FileName { get; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000528 RID: 1320
		int LineNumber { get; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000529 RID: 1321
		bool HasException { get; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600052A RID: 1322
		global::Loupe.Extensibility.Data.IExceptionInfo Exception { get; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600052B RID: 1323
		int ThreadId { get; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600052C RID: 1324
		string ThreadName { get; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600052D RID: 1325
		int DomainId { get; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600052E RID: 1326
		string DomainName { get; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600052F RID: 1327
		bool IsBackground { get; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000530 RID: 1328
		bool IsThreadPoolThread { get; }

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000531 RID: 1329
		bool HasThreadInfo { get; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000532 RID: 1330
		bool HasMethodInfo { get; }

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000533 RID: 1331
		bool HasSourceLocation { get; }
	}
}
