using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200033E RID: 830
	internal class EntitySetIdPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x060027A7 RID: 10151 RVA: 0x00073421 File Offset: 0x00071621
		private EntitySetIdPropertyRef()
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00073429 File Offset: 0x00071629
		public override string ToString()
		{
			return "ENTITYSETID";
		}

		// Token: 0x04000DCC RID: 3532
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef Instance = new global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef();
	}
}
