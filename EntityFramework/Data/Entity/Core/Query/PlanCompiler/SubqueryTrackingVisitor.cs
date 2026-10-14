using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036D RID: 877
	internal abstract class SubqueryTrackingVisitor : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x0008AA70 File Offset: 0x00088C70
		protected global::System.Data.Entity.Core.Query.InternalTrees.Command m_command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0008AA7D File Offset: 0x00088C7D
		protected SubqueryTrackingVisitor(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState)
		{
			this.m_compilerState = planCompilerState;
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x0008AAA4 File Offset: 0x00088CA4
		protected void AddSubqueryToRelOpNode(global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode, global::System.Data.Entity.Core.Query.InternalTrees.Node subquery)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list;
			if (!this.m_nodeSubqueries.TryGetValue(relOpNode, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				this.m_nodeSubqueries[relOpNode] = list;
			}
			list.Add(subquery);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0008AADC File Offset: 0x00088CDC
		protected global::System.Data.Entity.Core.Query.InternalTrees.Node AddSubqueryToParentRelOp(global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar, global::System.Data.Entity.Core.Query.InternalTrees.Node subquery)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.FindRelOpAncestor();
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "no ancestors found?");
			this.AddSubqueryToRelOpNode(node, subquery);
			subquery = this.m_command.CreateNode(this.m_command.CreateVarRefOp(outputVar));
			return subquery;
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0008AB20 File Offset: 0x00088D20
		protected global::System.Data.Entity.Core.Query.InternalTrees.Node FindRelOpAncestor()
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in this.m_ancestors)
			{
				if (node.Op.IsRelOp)
				{
					return node;
				}
				if (node.Op.IsPhysicalOp)
				{
					return null;
				}
			}
			return null;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0008AB94 File Offset: 0x00088D94
		protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_ancestors.Push(n);
			for (int i = 0; i < n.Children.Count; i++)
			{
				n.Children[i] = base.VisitNode(n.Children[i]);
			}
			this.m_ancestors.Pop();
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0008ABF0 File Offset: 0x00088DF0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node AugmentWithSubqueries(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> subqueries, bool inputFirst)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			int num;
			if (inputFirst)
			{
				node = input;
				num = 0;
			}
			else
			{
				node = subqueries[0];
				num = 1;
			}
			for (int i = num; i < subqueries.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp op = this.m_command.CreateOuterApplyOp();
				node = this.m_command.CreateNode(op, node, subqueries[i]);
			}
			if (!inputFirst)
			{
				node = this.m_command.CreateNode(this.m_command.CreateCrossApplyOp(), node, input);
			}
			this.m_compilerState.MarkPhaseAsNeeded(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination);
			return node;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0008AC6C File Offset: 0x00088E6C
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list;
			if (this.m_nodeSubqueries.TryGetValue(n, out list) && list.Count > 0)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupByInto, "VisitRelOpDefault: Unexpected op?" + n.Op.OpType.ToString());
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = this.AugmentWithSubqueries(n.Child0, list, true);
				n.Child0 = child;
			}
			return n;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x0008AD1C File Offset: 0x00088F1C
		protected bool ProcessJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> subqueries;
			if (!this.m_nodeSubqueries.TryGetValue(n, out subqueries))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin || n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin, "unexpected op?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.HasChild2, "missing second child to JoinOp?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child2;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.m_command.CreateNode(this.m_command.CreateSingleRowTableOp());
			node = this.AugmentWithSubqueries(node, subqueries, true);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.m_command.CreateNode(this.m_command.CreateFilterOp(), node, child);
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = this.m_command.CreateNode(this.m_command.CreateExistsOp(), arg);
			n.Child2 = child2;
			return true;
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0008ADF0 File Offset: 0x00088FF0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> subqueries;
			if (this.m_nodeSubqueries.TryGetValue(n, out subqueries))
			{
				return this.AugmentWithSubqueries(n, subqueries, false);
			}
			return n;
		}

		// Token: 0x04000EAC RID: 3756
		protected readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000EAD RID: 3757
		protected readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.Node> m_ancestors = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.Node>();

		// Token: 0x04000EAE RID: 3758
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>> m_nodeSubqueries = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>>();
	}
}
