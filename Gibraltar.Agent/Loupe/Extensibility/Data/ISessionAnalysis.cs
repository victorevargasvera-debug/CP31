using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200008C RID: 140
	internal interface ISessionAnalysis
	{
		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600065C RID: 1628
		global::Loupe.Extensibility.Data.ISession Session { get; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600065D RID: 1629
		global::Loupe.Extensibility.Data.ILogEventCollection LogEvents { get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600065E RID: 1630
		global::Loupe.Extensibility.Data.IApplicationUserCollection Users { get; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600065F RID: 1631
		bool IsNewSession { get; }
	}
}
