using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000344 RID: 836
	internal class GroupAggregateVarInfo
	{
		// Token: 0x060027D3 RID: 10195 RVA: 0x00074D84 File Offset: 0x00072F84
		internal GroupAggregateVarInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node defingingGroupNode, global::System.Data.Entity.Core.Query.InternalTrees.Var groupAggregateVar)
		{
			this._definingGroupByNode = defingingGroupNode;
			this._groupAggregateVar = groupAggregateVar;
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00074D9A File Offset: 0x00072F9A
		internal global::System.Collections.Generic.HashSet<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>>> CandidateAggregateNodes
		{
			get
			{
				if (this._candidateAggregateNodes == null)
				{
					this._candidateAggregateNodes = new global::System.Collections.Generic.HashSet<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>>>();
				}
				return this._candidateAggregateNodes;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x00074DB5 File Offset: 0x00072FB5
		internal bool HasCandidateAggregateNodes
		{
			get
			{
				return this._candidateAggregateNodes != null && this._candidateAggregateNodes.Count != 0;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x00074DCF File Offset: 0x00072FCF
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node DefiningGroupNode
		{
			get
			{
				return this._definingGroupByNode;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x00074DD7 File Offset: 0x00072FD7
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var GroupAggregateVar
		{
			get
			{
				return this._groupAggregateVar;
			}
		}

		// Token: 0x04000DE8 RID: 3560
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node _definingGroupByNode;

		// Token: 0x04000DE9 RID: 3561
		private global::System.Collections.Generic.HashSet<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>>> _candidateAggregateNodes;

		// Token: 0x04000DEA RID: 3562
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var _groupAggregateVar;
	}
}
