using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200007A RID: 122
	internal interface IThreadInfo
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060005EF RID: 1519
		global::Loupe.Extensibility.Data.ISession Session { get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060005F0 RID: 1520
		int ThreadId { get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060005F1 RID: 1521
		string ThreadName { get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060005F2 RID: 1522
		int DomainId { get; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060005F3 RID: 1523
		string DomainName { get; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060005F4 RID: 1524
		bool IsBackground { get; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060005F5 RID: 1525
		bool IsThreadPoolThread { get; }
	}
}
