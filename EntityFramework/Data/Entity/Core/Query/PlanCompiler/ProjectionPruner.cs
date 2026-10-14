using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035C RID: 860
	internal class ProjectionPruner : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x0008696B File Offset: 0x00084B6B
		private global::System.Data.Entity.Core.Query.InternalTrees.Command m_command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00086978 File Offset: 0x00084B78
		private ProjectionPruner(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			this.m_compilerState = compilerState;
			this.m_referencedVars = compilerState.Command.CreateVarVec();
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00086998 File Offset: 0x00084B98
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			compilerState.Command.Root = global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.Process(compilerState, compilerState.Command.Root);
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000869B6 File Offset: 0x00084BB6
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return new global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner(compilerState).Process(node);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000869C4 File Offset: 0x00084BC4
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Process(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return base.VisitNode(node);
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000869CD File Offset: 0x00084BCD
		private void AddReference(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			this.m_referencedVars.Set(v);
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x000869DC File Offset: 0x00084BDC
		private void AddReference(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> varSet)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in varSet)
			{
				this.AddReference(v);
			}
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00086A24 File Offset: 0x00084C24
		private bool IsReferenced(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			return this.m_referencedVars.IsSet(v);
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00086A32 File Offset: 0x00084C32
		private bool IsUnreferenced(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			return !this.IsReferenced(v);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00086A40 File Offset: 0x00084C40
		private void PruneVarMap(global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in varMap.Keys)
			{
				if (!this.IsReferenced(var))
				{
					list.Add(var);
				}
				else
				{
					this.AddReference(varMap[var]);
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in list)
			{
				varMap.Remove(key);
			}
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00086AEC File Offset: 0x00084CEC
		private void PruneVarSet(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varSet)
		{
			varSet.And(this.m_referencedVars);
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00086AFA File Offset: 0x00084CFA
		protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			base.VisitChildren(n);
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00086B0F File Offset: 0x00084D0F
		protected override void VisitChildrenReverse(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			base.VisitChildrenReverse(n);
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00086B24 File Offset: 0x00084D24
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				if (this.IsReferenced(varDefOp.Var))
				{
					list.Add(base.VisitNode(node));
				}
			}
			return this.m_command.CreateNode(op, list);
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00086BAC File Offset: 0x00084DAC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n == this.m_command.Root)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.ColumnMapVarTracker.FindVars(op.ColumnMap, this.m_referencedVars);
				op.Outputs.RemoveAll(new global::System.Predicate<global::System.Data.Entity.Core.Query.InternalTrees.Var>(this.IsUnreferenced));
			}
			else
			{
				this.AddReference(op.Outputs);
			}
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00086C06 File Offset: 0x00084E06
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.AddReference(op.Outputs);
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00086C1C File Offset: 0x00084E1C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.AddReference(op.Discriminator);
			return this.VisitNestOp(op, n);
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00086C32 File Offset: 0x00084E32
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitNestOp(op, n);
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00086C3C File Offset: 0x00084E3C
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildrenReverse(n);
			return n;
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00086C48 File Offset: 0x00084E48
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.Keys.Count > 1 && n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				this.RemoveRedundantConstantKeys(op.Keys, ((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Child0.Op).Outputs, n.Child0.Child1);
			}
			this.AddReference(op.Keys);
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00086CB8 File Offset: 0x00084EB8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.m_command.GetExtendedNodeInfo(n.Child0);
			this.AddReference(extendedNodeInfo.Definitions);
			n.Child0 = base.VisitNode(n.Child0);
			this.m_command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00086D02 File Offset: 0x00084F02
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildrenReverse(n);
			return n;
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00086D0C File Offset: 0x00084F0C
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = n.Children.Count - 1; i >= 2; i--)
			{
				n.Children[i] = base.VisitNode(n.Children[i]);
			}
			if (op.Keys.Count > 1)
			{
				this.RemoveRedundantConstantKeys(op.Keys, op.Outputs, n.Child1);
			}
			this.AddReference(op.Keys);
			n.Children[1] = base.VisitNode(n.Children[1]);
			n.Children[0] = base.VisitNode(n.Children[0]);
			this.PruneVarSet(op.Outputs);
			if (op.Keys.Count == 0 && op.Outputs.Count == 0)
			{
				return this.m_command.CreateNode(this.m_command.CreateSingleRowTableOp());
			}
			this.m_command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00086E08 File Offset: 0x00085008
		private void RemoveRedundantConstantKeys(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVec, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVec, global::System.Data.Entity.Core.Query.InternalTrees.Node varDefListNode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> constantKeys = (from d in varDefListNode.Children
			where d.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef && global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsConstantBaseOp(d.Child0.Op.OpType)
			select d).ToList<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec constantKeyVars = this.m_command.CreateVarVec(from d in constantKeys
			select ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)d.Op).Var);
			constantKeyVars.Minus(this.m_referencedVars);
			keyVec.Minus(constantKeyVars);
			outputVec.Minus(constantKeyVars);
			varDefListNode.Children.RemoveAll((global::System.Data.Entity.Core.Query.InternalTrees.Node c) => constantKeys.Contains(c) && constantKeyVars.IsSet(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)c.Op).Var));
			if (keyVec.Count == 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = constantKeys.First<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var;
				keyVec.Set(var);
				outputVec.Set(var);
				varDefListNode.Children.Add(node);
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00086F0C File Offset: 0x0008510C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.VisitGroupByOp(op, n);
			if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupByInto && n.Child3.Children.Count == 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp groupByIntoOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp)node.Op;
				node = this.m_command.CreateNode(this.m_command.CreateGroupByOp(groupByIntoOp.Keys, groupByIntoOp.Outputs), node.Child0, node.Child1, node.Child2);
			}
			return node;
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00086F88 File Offset: 0x00085188
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				this.VisitChildren(n);
				return n;
			}
			n.Child2 = base.VisitNode(n.Child2);
			n.Child0 = base.VisitNode(n.Child0);
			n.Child1 = base.VisitNode(n.Child1);
			this.m_command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00086FF0 File Offset: 0x000851F0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.PruneVarSet(op.Outputs);
			this.VisitChildrenReverse(n);
			if (!op.Outputs.IsEmpty)
			{
				return n;
			}
			return n.Child0;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0008701A File Offset: 0x0008521A
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!n.HasChild0, "scanTable with an input?");
			op.Table.ReferencedColumns.And(this.m_referencedVars);
			this.m_command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00087054 File Offset: 0x00085254
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect == op.OpType || global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except == op.OpType)
			{
				this.AddReference(op.Outputs);
			}
			this.PruneVarSet(op.Outputs);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 in op.VarMap)
			{
				this.PruneVarMap(varMap2);
			}
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000870B8 File Offset: 0x000852B8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in op.Keys)
			{
				this.AddReference(sortKey.Var);
			}
			if (n.HasChild1)
			{
				n.Child1 = base.VisitNode(n.Child1);
			}
			n.Child0 = base.VisitNode(n.Child0);
			this.m_command.RecomputeNodeInfo(n);
			return n;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x0008714C File Offset: 0x0008534C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.AddReference(op.Var);
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00087162 File Offset: 0x00085362
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.AddReference(op.Var);
			return n;
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00087174 File Offset: 0x00085374
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Child0.Op;
			this.AddReference(projectOp.Outputs.First);
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x04000E66 RID: 3686
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000E67 RID: 3687
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_referencedVars;

		// Token: 0x020009F5 RID: 2549
		private class ColumnMapVarTracker : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<global::System.Data.Entity.Core.Query.InternalTrees.VarVec>
		{
			// Token: 0x06006043 RID: 24643 RVA: 0x0014A110 File Offset: 0x00148310
			internal static void FindVars(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.ColumnMapVarTracker visitor = new global::System.Data.Entity.Core.Query.PlanCompiler.ProjectionPruner.ColumnMapVarTracker();
				columnMap.Accept<global::System.Data.Entity.Core.Query.InternalTrees.VarVec>(visitor, vec);
			}

			// Token: 0x06006044 RID: 24644 RVA: 0x0014A12B File Offset: 0x0014832B
			private ColumnMapVarTracker()
			{
			}

			// Token: 0x06006045 RID: 24645 RVA: 0x0014A133 File Offset: 0x00148333
			internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarVec arg)
			{
				arg.Set(columnMap.Var);
				base.Visit(columnMap, arg);
			}
		}
	}
}
