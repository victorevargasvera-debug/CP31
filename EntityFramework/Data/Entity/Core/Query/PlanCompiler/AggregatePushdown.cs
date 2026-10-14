using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200032C RID: 812
	internal class AggregatePushdown
	{
		// Token: 0x060026E0 RID: 9952 RVA: 0x0006F054 File Offset: 0x0006D254
		private AggregatePushdown(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_command = command;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0006F063 File Offset: 0x0006D263
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState)
		{
			new global::System.Data.Entity.Core.Query.PlanCompiler.AggregatePushdown(planCompilerState.Command).Process();
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x0006F078 File Offset: 0x0006D278
		private void Process()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo in global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateRefComputingVisitor.Process(this.m_command, out this.m_tryGetParent))
			{
				if (groupAggregateVarInfo.HasCandidateAggregateNodes)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>> candidate in groupAggregateVarInfo.CandidateAggregateNodes)
					{
						this.TryProcessCandidate(candidate, groupAggregateVarInfo);
					}
				}
			}
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x0006F114 File Offset: 0x0006D314
		private void TryProcessCandidate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>> candidate, global::System.Data.Entity.Core.Query.PlanCompiler.GroupAggregateVarInfo groupAggregateVarInfo)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingGroupNode = groupAggregateVarInfo.DefiningGroupNode;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> list;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			this.FindPathsToLeastCommonAncestor(candidate.Key, definingGroupNode, out list, out list2);
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.AggregatePushdown.AreAllNodesSupportedForPropagation(list2))
			{
				return;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp groupByIntoOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp)definingGroupNode.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(groupByIntoOp.Inputs.Count == 1, "There should be one input var to GroupByInto at this stage");
			global::System.Data.Entity.Core.Query.InternalTrees.Var first = groupByIntoOp.Inputs.First;
			global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp functionOp = (global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp)candidate.Key.Op;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>(1);
			dictionary.Add(groupAggregateVarInfo.GroupAggregateVar, first);
			global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper varRemapper = new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(this.m_command, dictionary);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(candidate.Value.Count);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n in candidate.Value)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this.m_command, n);
				varRemapper.RemapSubtree(node);
				list3.Add(node);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = this.m_command.CreateNode(this.m_command.CreateAggregateOp(functionOp.Function, false), list3);
			global::System.Data.Entity.Core.Query.InternalTrees.Var v;
			global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.m_command.CreateVarDefNode(definingExpr, out v);
			definingGroupNode.Child2.Children.Add(item);
			((global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp)definingGroupNode.Op).Outputs.Set(v);
			for (int i = 0; i < list2.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = list2[i];
				if (node2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
				{
					((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)node2.Op).Outputs.Set(v);
				}
			}
			candidate.Key.Op = this.m_command.CreateVarRefOp(v);
			candidate.Key.Children.Clear();
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x0006F2EC File Offset: 0x0006D4EC
		private static bool AreAllNodesSupportedForPropagation(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> nodes)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in nodes)
			{
				if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project && node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter && node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x0006F364 File Offset: 0x0006D564
		private void FindPathsToLeastCommonAncestor(global::System.Data.Entity.Core.Query.InternalTrees.Node node1, global::System.Data.Entity.Core.Query.InternalTrees.Node node2, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> ancestors1, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> ancestors2)
		{
			ancestors1 = this.FindAncestors(node1);
			ancestors2 = this.FindAncestors(node2);
			int num = ancestors1.Count - 1;
			int num2 = ancestors2.Count - 1;
			while (ancestors1[num] == ancestors2[num2])
			{
				num--;
				num2--;
			}
			for (int i = ancestors1.Count - 1; i > num; i--)
			{
				ancestors1.RemoveAt(i);
			}
			for (int j = ancestors2.Count - 1; j > num2; j--)
			{
				ancestors2.RemoveAt(j);
			}
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0006F3F0 File Offset: 0x0006D5F0
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> FindAncestors(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.Node key = node;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
			while (this.m_tryGetParent(key, out node2))
			{
				list.Add(node2);
				key = node2;
			}
			return list;
		}

		// Token: 0x04000D85 RID: 3461
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x04000D86 RID: 3462
		private global::System.Data.Entity.Core.Query.PlanCompiler.TryGetValue m_tryGetParent;
	}
}
