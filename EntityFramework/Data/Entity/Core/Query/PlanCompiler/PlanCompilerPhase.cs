using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000357 RID: 855
	internal enum PlanCompilerPhase
	{
		// Token: 0x04000E4C RID: 3660
		PreProcessor,
		// Token: 0x04000E4D RID: 3661
		AggregatePushdown,
		// Token: 0x04000E4E RID: 3662
		Normalization,
		// Token: 0x04000E4F RID: 3663
		NTE,
		// Token: 0x04000E50 RID: 3664
		ProjectionPruning,
		// Token: 0x04000E51 RID: 3665
		NestPullup,
		// Token: 0x04000E52 RID: 3666
		Transformations,
		// Token: 0x04000E53 RID: 3667
		JoinElimination,
		// Token: 0x04000E54 RID: 3668
		NullSemantics,
		// Token: 0x04000E55 RID: 3669
		CodeGen,
		// Token: 0x04000E56 RID: 3670
		PostCodeGen,
		// Token: 0x04000E57 RID: 3671
		MaxMarker
	}
}
