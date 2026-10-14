using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000331 RID: 817
	internal class AugmentedNode
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x00070223 File Offset: 0x0006E423
		internal AugmentedNode(int id, global::System.Data.Entity.Core.Query.InternalTrees.Node node) : this(id, node, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode>())
		{
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x00070234 File Offset: 0x0006E434
		internal AugmentedNode(int id, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> children)
		{
			this.m_id = id;
			this.m_node = node;
			this.m_children = children;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(children != null, "null children (gasp!)");
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode in this.m_children)
			{
				augmentedNode.m_parent = this;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000702BC File Offset: 0x0006E4BC
		internal int Id
		{
			get
			{
				return this.m_id;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000702C4 File Offset: 0x0006E4C4
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node Node
		{
			get
			{
				return this.m_node;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000702CC File Offset: 0x0006E4CC
		internal global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode Parent
		{
			get
			{
				return this.m_parent;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000702D4 File Offset: 0x0006E4D4
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> Children
		{
			get
			{
				return this.m_children;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000702DC File Offset: 0x0006E4DC
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> JoinEdges
		{
			get
			{
				return this.m_joinEdges;
			}
		}

		// Token: 0x04000D97 RID: 3479
		private readonly int m_id;

		// Token: 0x04000D98 RID: 3480
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node m_node;

		// Token: 0x04000D99 RID: 3481
		protected global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode m_parent;

		// Token: 0x04000D9A RID: 3482
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> m_children;

		// Token: 0x04000D9B RID: 3483
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> m_joinEdges = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>();
	}
}
