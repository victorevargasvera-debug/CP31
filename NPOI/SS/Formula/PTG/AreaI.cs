using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F8 RID: 248
	public interface AreaI
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000851 RID: 2129
		int FirstRow { get; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000852 RID: 2130
		int LastRow { get; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000853 RID: 2131
		int FirstColumn { get; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000854 RID: 2132
		int LastColumn { get; }
	}
}
