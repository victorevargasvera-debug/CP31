using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056B RID: 1387
	internal enum PerfType
	{
		// Token: 0x04001833 RID: 6195
		InitialSetup,
		// Token: 0x04001834 RID: 6196
		CellCreation,
		// Token: 0x04001835 RID: 6197
		KeyConstraint,
		// Token: 0x04001836 RID: 6198
		ViewgenContext,
		// Token: 0x04001837 RID: 6199
		UpdateViews,
		// Token: 0x04001838 RID: 6200
		DisjointConstraint,
		// Token: 0x04001839 RID: 6201
		PartitionConstraint,
		// Token: 0x0400183A RID: 6202
		DomainConstraint,
		// Token: 0x0400183B RID: 6203
		ForeignConstraint,
		// Token: 0x0400183C RID: 6204
		QueryViews,
		// Token: 0x0400183D RID: 6205
		BoolResolution,
		// Token: 0x0400183E RID: 6206
		Unsatisfiability,
		// Token: 0x0400183F RID: 6207
		ViewParsing
	}
}
