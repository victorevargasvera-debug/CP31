using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000369 RID: 873
	internal class SortRemover : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x06002A56 RID: 10838 RVA: 0x0008979B File Offset: 0x0008799B
		private SortRemover(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.Node topMostSort)
		{
			this.m_command = command;
			this.m_topMostSort = topMostSort;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000897BC File Offset: 0x000879BC
		internal static void Process(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node topMostSort;
			if (command.Root.Child0 != null && command.Root.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort)
			{
				topMostSort = command.Root.Child0;
			}
			else
			{
				topMostSort = null;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.SortRemover sortRemover = new global::System.Data.Entity.Core.Query.PlanCompiler.SortRemover(command, topMostSort);
			command.Root = sortRemover.VisitNode(command.Root);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x0008981C File Offset: 0x00087A1C
		protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			bool flag = false;
			for (int i = 0; i < n.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Children[i];
				n.Children[i] = base.VisitNode(n.Children[i]);
				if (node != n.Children[i] || this.changedNodes.Contains(node))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.m_command.RecomputeNodeInfo(n);
				this.changedNodes.Add(n);
			}
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000898A8 File Offset: 0x00087AA8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.Keys.Count > 0 || n.Children.Count != 3 || n.Child0 == null || n.Child1 == null || n.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort || n.Child1.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null || n.Child0.Children.Count != 1)
			{
				return n;
			}
			return this.m_command.CreateNode(this.m_command.CreateConstrainedSortOp(((global::System.Data.Entity.Core.Query.InternalTrees.SortOp)n.Child0.Op).Keys, op.WithTies), n.Child0.Child0, n.Child1, n.Child2);
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00089968 File Offset: 0x00087B68
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (n == this.m_topMostSort)
			{
				result = n;
			}
			else
			{
				result = n.Child0;
			}
			return result;
		}

		// Token: 0x04000E98 RID: 3736
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x04000E99 RID: 3737
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node m_topMostSort;

		// Token: 0x04000E9A RID: 3738
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Node> changedNodes = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
	}
}
