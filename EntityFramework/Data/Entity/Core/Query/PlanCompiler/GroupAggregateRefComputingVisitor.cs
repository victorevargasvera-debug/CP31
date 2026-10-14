using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000342 RID: 834
	internal class GroupAggregateRefComputingVisitor : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor
	{
		// Token: 0x060027C0 RID: 10176 RVA: 0x00074618 File Offset: 0x00072818
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo> Process(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, out global::System.Data.Entity.Core.Query.PlanCompiler.TryGetValue tryGetParent)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateRefComputingVisitor groupAggregateRefComputingVisitor = new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateRefComputingVisitor(itree);
			groupAggregateRefComputingVisitor.VisitNode(itree.Root);
			tryGetParent = new global::System.Data.Entity.Core.Query.PlanCompiler.TryGetValue(groupAggregateRefComputingVisitor._childToParent.TryGetValue);
			return groupAggregateRefComputingVisitor._groupAggregateVarInfoManager.GroupAggregateVarInfos;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00074657 File Offset: 0x00072857
		private GroupAggregateRefComputingVisitor(global::System.Data.Entity.Core.Query.InternalTrees.Command itree)
		{
			this._command = itree;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0007467C File Offset: 0x0007287C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Op op2 = child.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo;
			global::System.Data.Entity.Core.Query.InternalTrees.Node computationTemplate;
			bool isUnnested;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator.TryTranslateOverGroupAggregateVar(child, true, this._command, this._groupAggregateVarInfoManager, out groupAggregateVarInfo, out computationTemplate, out isUnnested))
			{
				this._groupAggregateVarInfoManager.Add(op.Var, groupAggregateVarInfo, computationTemplate, isUnnested);
				return;
			}
			if (op2.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp newRecordOp = (global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp)op2;
				for (int i = 0; i < child.Children.Count; i++)
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator.TryTranslateOverGroupAggregateVar(child.Children[i], true, this._command, this._groupAggregateVarInfoManager, out groupAggregateVarInfo, out computationTemplate, out isUnnested))
					{
						this._groupAggregateVarInfoManager.Add(op.Var, groupAggregateVarInfo, computationTemplate, isUnnested, newRecordOp.Properties[i]);
					}
				}
			}
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00074748 File Offset: 0x00072948
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitGroupByOp(op, n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Child3.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var;
				global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo;
				if (!this._groupAggregateVarInfoManager.TryGetReferencedGroupAggregateVarInfo(var, out groupAggregateVarRefInfo))
				{
					this._groupAggregateVarInfoManager.Add(var, new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo(n, var), this._command.CreateNode(this._command.CreateVarRefOp(var)), false);
				}
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x000747EC File Offset: 0x000729EC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarRefInfo groupAggregateVarRefInfo;
			if (this._groupAggregateVarInfoManager.TryGetReferencedGroupAggregateVarInfo(op.Var, out groupAggregateVarRefInfo))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Table.Columns.Count == 1, "Expected one column before NTE");
				this._groupAggregateVarInfoManager.Add(op.Table.Columns[0], groupAggregateVarRefInfo.GroupAggregateVarInfo, groupAggregateVarRefInfo.Computation, true);
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0007485C File Offset: 0x00072A5C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsCollectionAggregateFunction(op, n))
			{
				return;
			}
			if (n.Children.Count > 1)
			{
				return;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			bool flag;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarComputationTranslator.TryTranslateOverGroupAggregateVar(n.Child0, false, this._command, this._groupAggregateVarInfoManager, out groupAggregateVarInfo, out node, out flag) && (flag || global::System.Data.Entity.Core.Query.PlanCompiler.AggregatePushdownUtil.IsVarRefOverGivenVar(node, groupAggregateVarInfo.GroupAggregateVar)))
			{
				groupAggregateVarInfo.CandidateAggregateNodes.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>>(n, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>
				{
					node
				}));
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x000748E0 File Offset: 0x00072AE0
		protected override void VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				if (node.Op.Arity != 0)
				{
					this._childToParent.Add(node, n);
				}
			}
		}

		// Token: 0x04000DE1 RID: 3553
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command _command;

		// Token: 0x04000DE2 RID: 3554
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfoManager _groupAggregateVarInfoManager = new global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfoManager();

		// Token: 0x04000DE3 RID: 3555
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> _childToParent = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
	}
}
