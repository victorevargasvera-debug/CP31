using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000340 RID: 832
	internal static class FilterOpRules
	{
		// Token: 0x060027AF RID: 10159 RVA: 0x000734BC File Offset: 0x000716BC
		private static global::System.Data.Entity.Core.Query.InternalTrees.Node GetPushdownPredicate(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec columns, out global::System.Data.Entity.Core.Query.InternalTrees.Node nonPushdownPredicateNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = filterNode.Child1;
			nonPushdownPredicateNode = null;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(filterNode);
			if (columns == null && extendedNodeInfo.ExternalReferences.IsEmpty)
			{
				return node;
			}
			if (columns == null)
			{
				columns = command.GetExtendedNodeInfo(filterNode.Child0).Definitions;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.Predicate predicate;
			node = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(command, node).GetSingleTablePredicates(columns, out predicate).BuildAndTree();
			nonPushdownPredicateNode = predicate.BuildAndTree();
			return node;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00073524 File Offset: 0x00071724
		private static bool ProcessFilterOverFilter(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = context.Command.CreateNode(context.Command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), filterNode.Child0.Child1, filterNode.Child1);
			newNode = context.Command.CreateNode(context.Command.CreateFilterOp(), filterNode.Child0.Child0, arg);
			return true;
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00073580 File Offset: 0x00071780
		private static bool ProcessFilterOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child1;
			if (child.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstantPredicate)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int>();
			if (!transformationRulesContext.IsScalarOpTree(child, varRefMap))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = filterNode.Child0;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap = transformationRulesContext.GetVarMap(child2.Child1, varRefMap);
			if (varMap == null)
			{
				return false;
			}
			if (transformationRulesContext.IncludeCustomFunctionOp(child, varMap))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = transformationRulesContext.ReMap(child, varMap);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateFilterOp(), child2.Child0, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = transformationRulesContext.Command.CreateNode(child2.Op, arg2, child2.Child1);
			newNode = node;
			return true;
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00073634 File Offset: 0x00071834
		private static bool ProcessFilterOverSetOp(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			global::System.Data.Entity.Core.Query.InternalTrees.Node pushdownPredicate = global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.GetPushdownPredicate(transformationRulesContext.Command, filterNode, null, out node);
			if (pushdownPredicate == null)
			{
				return false;
			}
			if (!transformationRulesContext.IsScalarOpTree(pushdownPredicate))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.SetOp setOp = (global::System.Data.Entity.Core.Query.InternalTrees.SetOp)child.Op;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 in setOp.VarMap)
			{
				if (setOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except && num == 1)
				{
					list.Add(child.Child1);
					break;
				}
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap2)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node value = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateVarRefOp(keyValuePair.Value));
					dictionary.Add(keyValuePair.Key, value);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = pushdownPredicate;
				if (num == 0 && filterNode.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except)
				{
					node2 = transformationRulesContext.Copy(node2);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = transformationRulesContext.ReMap(node2, dictionary);
				transformationRulesContext.Command.RecomputeNodeInfo(node3);
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateFilterOp(), child.Children[num], node3);
				list.Add(item);
				num++;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = transformationRulesContext.Command.CreateNode(child.Op, list);
			if (node != null)
			{
				newNode = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateFilterOp(), node4, node);
			}
			else
			{
				newNode = node4;
			}
			return true;
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000737F0 File Offset: 0x000719F0
		private static bool ProcessFilterOverDistinct(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			global::System.Data.Entity.Core.Query.InternalTrees.Node pushdownPredicate = global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.GetPushdownPredicate(context.Command, filterNode, null, out node);
			if (pushdownPredicate == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = context.Command.CreateNode(context.Command.CreateFilterOp(), child.Child0, pushdownPredicate);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = context.Command.CreateNode(child.Op, arg);
			if (node != null)
			{
				newNode = context.Command.CreateNode(context.Command.CreateFilterOp(), node2, node);
			}
			else
			{
				newNode = node2;
			}
			return true;
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00073874 File Offset: 0x00071A74
		private static bool ProcessFilterOverGroupBy(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp groupByOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)child.Op;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int>();
			if (!transformationRulesContext.IsScalarOpTree(filterNode.Child1, varRefMap))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			global::System.Data.Entity.Core.Query.InternalTrees.Node pushdownPredicate = global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.GetPushdownPredicate(context.Command, filterNode, groupByOp.Keys, out node);
			if (pushdownPredicate == null)
			{
				return false;
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap = transformationRulesContext.GetVarMap(child.Child1, varRefMap);
			if (varMap == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = transformationRulesContext.ReMap(pushdownPredicate, varMap);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateFilterOp(), child.Child0, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = transformationRulesContext.Command.CreateNode(child.Op, arg2, child.Child1, child.Child2);
			if (node == null)
			{
				newNode = node2;
			}
			else
			{
				newNode = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateFilterOp(), node2, node);
			}
			return true;
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0007395C File Offset: 0x00071B5C
		private static bool ProcessFilterOverJoin(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			if (transformationRulesContext.IsFilterPushdownSuppressed(filterNode))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = child.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = child.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = child.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			bool flag = false;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(node2);
			global::System.Data.Entity.Core.Query.PlanCompiler.Predicate predicate = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(command, filterNode.Child1);
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && !predicate.PreservesNulls(extendedNodeInfo.Definitions, true))
			{
				if (transformationRulesContext.PlanCompiler.IsAfterPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NullSemantics) && transformationRulesContext.PlanCompiler.IsAfterPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination))
				{
					op = command.CreateInnerJoinOp();
					flag = true;
				}
				else
				{
					transformationRulesContext.PlanCompiler.TransformationsDeferred = true;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = command.GetExtendedNodeInfo(node);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = null;
			if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
			{
				node3 = predicate.GetSingleTablePredicates(extendedNodeInfo2.Definitions, out predicate).BuildAndTree();
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = null;
			if (node2.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable && op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				node4 = predicate.GetSingleTablePredicates(extendedNodeInfo.Definitions, out predicate).BuildAndTree();
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node5 = null;
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin)
			{
				node5 = predicate.GetJoinPredicates(extendedNodeInfo2.Definitions, extendedNodeInfo.Definitions, out predicate).BuildAndTree();
			}
			if (node3 != null)
			{
				node = command.CreateNode(command.CreateFilterOp(), node, node3);
				flag = true;
			}
			if (node4 != null)
			{
				node2 = command.CreateNode(command.CreateFilterOp(), node2, node4);
				flag = true;
			}
			if (node5 != null)
			{
				flag = true;
				if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
				{
					op = command.CreateInnerJoinOp();
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin, "unexpected non-InnerJoin?");
					node5 = global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.CombinePredicates(child.Child2, node5, command);
				}
			}
			else
			{
				node5 = ((op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin) ? null : child.Child2);
			}
			if (!flag)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node6;
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				node6 = command.CreateNode(op, node, node2);
			}
			else
			{
				node6 = command.CreateNode(op, node, node2, node5);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node7 = predicate.BuildAndTree();
			if (node7 == null)
			{
				newNode = node6;
			}
			else
			{
				newNode = command.CreateNode(command.CreateFilterOp(), node6, node7);
			}
			return true;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00073B90 File Offset: 0x00071D90
		private static bool ProcessFilterOverOuterApply(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node filterNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = filterNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = filterNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child1;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(child2);
			if (!new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(command, filterNode.Child1).PreservesNulls(extendedNodeInfo.Definitions, true))
			{
				if (transformationRulesContext.PlanCompiler.IsAfterPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.NullSemantics) && transformationRulesContext.PlanCompiler.IsAfterPhase(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerPhase.JoinElimination))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateNode(command.CreateCrossApplyOp(), child.Child0, child2);
					global::System.Data.Entity.Core.Query.InternalTrees.Node node = command.CreateNode(command.CreateFilterOp(), arg, filterNode.Child1);
					newNode = node;
					return true;
				}
				transformationRulesContext.PlanCompiler.TransformationsDeferred = true;
			}
			return false;
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00073C3C File Offset: 0x00071E3C
		private static bool ProcessFilterWithConstantPredicate(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp constantPredicateOp = (global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp)n.Child1.Op;
			if (constantPredicateOp.IsTrue)
			{
				newNode = n.Child0;
				return true;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(constantPredicateOp.IsFalse, "unexpected non-false predicate?");
			if (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRowTable || (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project && n.Child0.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRowTable))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = transformationRulesContext.Command.GetExtendedNodeInfo(n.Child0);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = transformationRulesContext.Command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in extendedNodeInfo.Definitions)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NullOp op = transformationRulesContext.Command.CreateNullOp(var.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = transformationRulesContext.Command.CreateNode(op);
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = transformationRulesContext.Command.CreateVarDefNode(definingExpr, out var2);
				transformationRulesContext.AddVarMapping(var, var2);
				varVec.Set(var2);
				list.Add(item);
			}
			if (varVec.IsEmpty)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NullOp op2 = transformationRulesContext.Command.CreateNullOp(transformationRulesContext.Command.BooleanType);
				global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr2 = transformationRulesContext.Command.CreateNode(op2);
				global::System.Data.Entity.Core.Query.InternalTrees.Var v;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = transformationRulesContext.Command.CreateVarDefNode(definingExpr2, out v);
				varVec.Set(v);
				list.Add(item2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateSingleRowTableOp());
			n.Child0 = child;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = transformationRulesContext.Command.CreateNode(transformationRulesContext.Command.CreateVarDefListOp(), list);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op3 = transformationRulesContext.Command.CreateProjectOp(varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = transformationRulesContext.Command.CreateNode(op3, n, arg);
			node.Child0 = n;
			newNode = node;
			return true;
		}

		// Token: 0x04000DCF RID: 3535
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverFilter = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverFilter));

		// Token: 0x04000DD0 RID: 3536
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverProject));

		// Token: 0x04000DD1 RID: 3537
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverUnionAll = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverSetOp));

		// Token: 0x04000DD2 RID: 3538
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverIntersect = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverSetOp));

		// Token: 0x04000DD3 RID: 3539
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverExcept = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverSetOp));

		// Token: 0x04000DD4 RID: 3540
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverDistinct = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverDistinct));

		// Token: 0x04000DD5 RID: 3541
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverGroupBy = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverGroupBy));

		// Token: 0x04000DD6 RID: 3542
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverCrossJoin = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverJoin));

		// Token: 0x04000DD7 RID: 3543
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverInnerJoin = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverJoin));

		// Token: 0x04000DD8 RID: 3544
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverLeftOuterJoin = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverJoin));

		// Token: 0x04000DD9 RID: 3545
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterOverOuterApply = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterOverOuterApply));

		// Token: 0x04000DDA RID: 3546
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_FilterWithConstantPredicate = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.ProcessFilterWithConstantPredicate));

		// Token: 0x04000DDB RID: 3547
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterWithConstantPredicate,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverCrossJoin,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverDistinct,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverExcept,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverFilter,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverGroupBy,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverInnerJoin,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverIntersect,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverLeftOuterJoin,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverProject,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverUnionAll,
			global::System.Data.Entity.Core.Query.PlanCompiler.FilterOpRules.Rule_FilterOverOuterApply
		};
	}
}
