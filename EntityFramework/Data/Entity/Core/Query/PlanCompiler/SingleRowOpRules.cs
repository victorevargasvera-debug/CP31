using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000367 RID: 871
	internal static class SingleRowOpRules
	{
		// Token: 0x06002A51 RID: 10833 RVA: 0x000895A4 File Offset: 0x000877A4
		private static bool ProcessSingleRowOpOverAnything(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node singleRowNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = singleRowNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = context.Command.GetExtendedNodeInfo(singleRowNode.Child0);
			if (extendedNodeInfo.MaxRows <= global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One)
			{
				newNode = singleRowNode.Child0;
				return true;
			}
			if (singleRowNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter && new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(context.Command, singleRowNode.Child0.Child1).SatisfiesKey(extendedNodeInfo.Keys.KeyVars, extendedNodeInfo.Definitions))
			{
				extendedNodeInfo.MaxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One;
				newNode = singleRowNode.Child0;
				return true;
			}
			return false;
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00089634 File Offset: 0x00087834
		private static bool ProcessSingleRowOpOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node singleRowNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = singleRowNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = singleRowNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child0;
			singleRowNode.Child0 = child2;
			context.Command.RecomputeNodeInfo(singleRowNode);
			child.Child0 = singleRowNode;
			newNode = child;
			return true;
		}

		// Token: 0x04000E93 RID: 3731
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_SingleRowOpOverAnything = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SingleRowOpRules.ProcessSingleRowOpOverAnything));

		// Token: 0x04000E94 RID: 3732
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_SingleRowOpOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.SingleRowOpRules.ProcessSingleRowOpOverProject));

		// Token: 0x04000E95 RID: 3733
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.SingleRowOpRules.Rule_SingleRowOpOverAnything,
			global::System.Data.Entity.Core.Query.PlanCompiler.SingleRowOpRules.Rule_SingleRowOpOverProject
		};
	}
}
