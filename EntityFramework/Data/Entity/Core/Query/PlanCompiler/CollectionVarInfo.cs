using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000334 RID: 820
	internal class CollectionVarInfo : global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x00070519 File Offset: 0x0006E719
		internal CollectionVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			this.m_newVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			this.m_newVars.Add(newVar);
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00070538 File Offset: 0x0006E738
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var NewVar
		{
			get
			{
				return this.m_newVars[0];
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x00070546 File Offset: 0x0006E746
		internal override global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind Kind
		{
			get
			{
				return global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.CollectionVarInfo;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x00070549 File Offset: 0x0006E749
		internal override global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> NewVars
		{
			get
			{
				return this.m_newVars;
			}
		}

		// Token: 0x04000DA3 RID: 3491
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> m_newVars;
	}
}
