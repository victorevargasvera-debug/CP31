using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000354 RID: 852
	internal class NullSentinelPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x0600294C RID: 10572 RVA: 0x000833D2 File Offset: 0x000815D2
		private NullSentinelPropertyRef()
		{
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600294D RID: 10573 RVA: 0x000833DA File Offset: 0x000815DA
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef Instance
		{
			get
			{
				return global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef._singleton;
			}
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x000833E1 File Offset: 0x000815E1
		public override string ToString()
		{
			return "NULLSENTINEL";
		}

		// Token: 0x04000E3C RID: 3644
		private static readonly global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef _singleton = new global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef();
	}
}
