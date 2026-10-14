using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000346 RID: 838
	internal class GroupAggregateVarRefInfo
	{
		// Token: 0x060027DE RID: 10206 RVA: 0x00074EE8 File Offset: 0x000730E8
		internal GroupAggregateVarRefInfo(global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node computation, bool isUnnested)
		{
			this._groupAggregateVarInfo = groupAggregateVarInfo;
			this._computation = computation;
			this._isUnnested = isUnnested;
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00074F05 File Offset: 0x00073105
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Computation
		{
			get
			{
				return this._computation;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x00074F0D File Offset: 0x0007310D
		internal global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo GroupAggregateVarInfo
		{
			get
			{
				return this._groupAggregateVarInfo;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00074F15 File Offset: 0x00073115
		internal bool IsUnnested
		{
			get
			{
				return this._isUnnested;
			}
		}

		// Token: 0x04000DEE RID: 3566
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node _computation;

		// Token: 0x04000DEF RID: 3567
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo _groupAggregateVarInfo;

		// Token: 0x04000DF0 RID: 3568
		private readonly bool _isUnnested;
	}
}
