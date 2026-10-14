using System;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000372 RID: 882
	internal class TypeIdPropertyRef : global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef
	{
		// Token: 0x06002ABA RID: 10938 RVA: 0x0008BBDC File Offset: 0x00089DDC
		private TypeIdPropertyRef()
		{
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0008BBE4 File Offset: 0x00089DE4
		public override string ToString()
		{
			return "TYPEID";
		}

		// Token: 0x04000EC9 RID: 3785
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef Instance = new global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef();
	}
}
