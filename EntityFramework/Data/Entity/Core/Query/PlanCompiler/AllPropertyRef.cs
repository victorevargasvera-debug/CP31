using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200032E RID: 814
	internal class AllPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x060026E8 RID: 9960 RVA: 0x0006F446 File Offset: 0x0006D646
		private AllPropertyRef()
		{
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0006F44E File Offset: 0x0006D64E
		internal override global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef CreateNestedPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef p)
		{
			return p;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0006F451 File Offset: 0x0006D651
		public override string ToString()
		{
			return "ALL";
		}

		// Token: 0x04000D87 RID: 3463
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.AllPropertyRef Instance = new global::System.Data.Entity.Core.Query.PlanCompiler.AllPropertyRef();
	}
}
