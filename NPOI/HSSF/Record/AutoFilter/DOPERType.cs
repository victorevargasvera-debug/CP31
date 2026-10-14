using System;

namespace NPOI.HSSF.Record.AutoFilter
{
	// Token: 0x02000459 RID: 1113
	public enum DOPERType : byte
	{
		// Token: 0x040011B5 RID: 4533
		FilterCondition,
		// Token: 0x040011B6 RID: 4534
		RKNumber = 2,
		// Token: 0x040011B7 RID: 4535
		IEEENumber = 4,
		// Token: 0x040011B8 RID: 4536
		String = 6,
		// Token: 0x040011B9 RID: 4537
		BooleanOrErrors = 8,
		// Token: 0x040011BA RID: 4538
		MatchAllBlanks = 12,
		// Token: 0x040011BB RID: 4539
		MatchNoneBlank = 14
	}
}
