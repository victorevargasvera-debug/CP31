using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000365 RID: 869
	internal static class SetOpRules
	{
		// Token: 0x06002A4A RID: 10826 RVA: 0x000893BC File Offset: 0x000875BC
		private static bool ProcessSetOpOverEmptySet(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node setOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			bool flag = context.Command.GetExtendedNodeInfo(setOpNode.Child0).MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			bool flag2 = context.Command.GetExtendedNodeInfo(setOpNode.Child1).MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			if (!flag && !flag2)
			{
				newNode = setOpNode;
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.SetOp setOp = (global::System.Data.Entity.Core.Query.InternalTrees.SetOp)setOpNode.Op;
			int num;
			if ((!flag2 && setOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll) || (!flag && setOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect))
			{
				num = 1;
			}
			else
			{
				num = 0;
			}
			newNode = setOpNode.Children[num];
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in setOp.VarMap[num])
			{
				transformationRulesContext.AddVarMapping(keyValuePair.Key, keyValuePair.Value);
			}
			return true;
		}

		// Token: 0x04000E8E RID: 3726
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_UnionAllOverEmptySet = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.ProcessSetOpOverEmptySet));

		// Token: 0x04000E8F RID: 3727
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_IntersectOverEmptySet = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.ProcessSetOpOverEmptySet));

		// Token: 0x04000E90 RID: 3728
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_ExceptOverEmptySet = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.ProcessSetOpOverEmptySet));

		// Token: 0x04000E91 RID: 3729
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.Rule_UnionAllOverEmptySet,
			global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.Rule_IntersectOverEmptySet,
			global::System.Data.Entity.Core.Query.PlanCompiler.SetOpRules.Rule_ExceptOverEmptySet
		};
	}
}
