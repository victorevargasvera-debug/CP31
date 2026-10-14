using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000330 RID: 816
	internal sealed class AugmentedJoinNode : global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode
	{
		// Token: 0x060026F5 RID: 9973 RVA: 0x000701B4 File Offset: 0x0006E3B4
		internal AugmentedJoinNode(int id, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode leftChild, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode rightChild, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> leftVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> rightVars, global::System.Data.Entity.Core.Query.InternalTrees.Node otherPredicate) : this(id, node, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode>(new global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode[]
		{
			leftChild,
			rightChild
		}))
		{
			this.m_otherPredicate = otherPredicate;
			this.m_rightVars = rightVars;
			this.m_leftVars = leftVars;
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000701EA File Offset: 0x0006E3EA
		internal AugmentedJoinNode(int id, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> children) : base(id, node, children)
		{
			this.m_leftVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			this.m_rightVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x0007020B File Offset: 0x0006E40B
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node OtherPredicate
		{
			get
			{
				return this.m_otherPredicate;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00070213 File Offset: 0x0006E413
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> LeftVars
		{
			get
			{
				return this.m_leftVars;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x0007021B File Offset: 0x0006E41B
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> RightVars
		{
			get
			{
				return this.m_rightVars;
			}
		}

		// Token: 0x04000D94 RID: 3476
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> m_leftVars;

		// Token: 0x04000D95 RID: 3477
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> m_rightVars;

		// Token: 0x04000D96 RID: 3478
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node m_otherPredicate;
	}
}
