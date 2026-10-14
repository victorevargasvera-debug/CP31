using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035D RID: 861
	internal static class ProjectOpRules
	{
		// Token: 0x060029E2 RID: 10722 RVA: 0x000871AC File Offset: 0x000853AC
		private static bool ProcessProjectOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node projectNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = projectNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = projectNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = projectNode.Child0;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in child.Children)
			{
				if (!transformationRulesContext.IsScalarOpTree(node.Child0, varRefMap))
				{
					return false;
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap = transformationRulesContext.GetVarMap(child2.Child1, varRefMap);
			if (varMap == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateVarDefListOp());
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node3 in child.Children)
			{
				node3.Child0 = transformationRulesContext.ReMap(node3.Child0, varMap);
				transformationRulesContext.Command.RecomputeNodeInfo(node3);
				node2.Children.Add(node3);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = transformationRulesContext.Command.GetExtendedNodeInfo(projectNode);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node4 in child2.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node4.Op;
				if (extendedNodeInfo.Definitions.IsSet(varDefOp.Var))
				{
					node2.Children.Add(node4);
				}
			}
			projectNode.Child0 = child2.Child0;
			projectNode.Child1 = node2;
			return true;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00087364 File Offset: 0x00085564
		private static bool ProcessProjectWithNoLocalDefinitions(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			if (!context.Command.GetNodeInfo(n).ExternalReferences.IsEmpty)
			{
				return false;
			}
			newNode = n.Child0;
			return true;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x0008738C File Offset: 0x0008558C
		private static bool ProcessProjectWithSimpleVarRedefinitions(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Op;
			if (n.Child1.Children.Count == 0)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(n);
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = node.Child0;
				if (child.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)child.Op;
					if (!extendedNodeInfo.ExternalReferences.IsSet(varRefOp.Var))
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in n.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node2.Op;
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp2 = node2.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
				if (varRefOp2 != null && !extendedNodeInfo.ExternalReferences.IsSet(varRefOp2.Var))
				{
					projectOp.Outputs.Clear(varDefOp.Var);
					projectOp.Outputs.Set(varRefOp2.Var);
					transformationRulesContext.AddVarMapping(varDefOp.Var, varRefOp2.Var);
				}
				else
				{
					list.Add(node2);
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = command.CreateNode(command.CreateVarDefListOp(), list);
			n.Child1 = child2;
			return true;
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00087540 File Offset: 0x00085740
		private static bool ProcessProjectOpWithNullSentinel(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Op;
			if ((from c in n.Child1.Children
			where c.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel
			select c).Count<global::System.Data.Entity.Core.Query.InternalTrees.Node>() == 0)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(n.Child0);
			bool flag = false;
			bool canChangeNullSentinelValue = transformationRulesContext.CanChangeNullSentinelValue;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			if (!canChangeNullSentinelValue || !global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.TryGetInt32Var(extendedNodeInfo.NonNullableDefinitions, out var))
			{
				flag = true;
				if (canChangeNullSentinelValue)
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.TryGetInt32Var(from child in n.Child1.Children
					where child.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant || child.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant
					select ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)child.Op).Var, out var))
					{
						goto IL_146;
					}
				}
				var = (from child in n.Child1.Children
				where child.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel
				select ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)child.Op).Var).FirstOrDefault<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				if (var == null)
				{
					return false;
				}
			}
			IL_146:
			bool flag2 = false;
			for (int i = n.Child1.Children.Count - 1; i >= 0; i--)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Child1.Children[i];
				if (node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
				{
					if (!flag)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op = command.CreateVarRefOp(var);
						node.Child0 = command.CreateNode(op);
						command.RecomputeNodeInfo(node);
						flag2 = true;
					}
					else if (!var.Equals(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var))
					{
						projectOp.Outputs.Clear(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var);
						n.Child1.Children.RemoveAt(i);
						transformationRulesContext.AddVarMapping(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var, var);
						flag2 = true;
					}
				}
			}
			if (flag2)
			{
				command.RecomputeNodeInfo(n.Child1);
			}
			return flag2;
		}

		// Token: 0x04000E68 RID: 3688
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_ProjectOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.ProcessProjectOverProject));

		// Token: 0x04000E69 RID: 3689
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_ProjectWithNoLocalDefs = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.ProcessProjectWithNoLocalDefinitions));

		// Token: 0x04000E6A RID: 3690
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_ProjectOpWithSimpleVarRedefinitions = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.ProcessProjectWithSimpleVarRedefinitions));

		// Token: 0x04000E6B RID: 3691
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_ProjectOpWithNullSentinel = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.ProcessProjectOpWithNullSentinel));

		// Token: 0x04000E6C RID: 3692
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rule_ProjectOpWithNullSentinel,
			global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rule_ProjectOpWithSimpleVarRedefinitions,
			global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rule_ProjectOverProject,
			global::System.Data.Entity.Core.Query.PlanCompiler.ProjectOpRules.Rule_ProjectWithNoLocalDefs
		};
	}
}
