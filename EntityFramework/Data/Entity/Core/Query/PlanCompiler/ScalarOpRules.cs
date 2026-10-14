using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000364 RID: 868
	internal static class ScalarOpRules
	{
		// Token: 0x06002A35 RID: 10805 RVA: 0x00088764 File Offset: 0x00086964
		private static bool ProcessSimplifyCase(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node caseOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp caseOp = (global::System.Data.Entity.Core.Query.InternalTrees.CaseOp)caseOpNode.Op;
			newNode = caseOpNode;
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessSimplifyCase_Collapse(caseOpNode, out newNode) || global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessSimplifyCase_EliminateWhenClauses(context, caseOp, caseOpNode, out newNode);
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0008879C File Offset: 0x0008699C
		private static bool ProcessSimplifyCase_Collapse(global::System.Data.Entity.Core.Query.InternalTrees.Node caseOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = caseOpNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = caseOpNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node other = caseOpNode.Children[caseOpNode.Children.Count - 1];
			if (!child.IsEquivalent(other))
			{
				return false;
			}
			for (int i = 3; i < caseOpNode.Children.Count - 1; i += 2)
			{
				if (!caseOpNode.Children[i].IsEquivalent(child))
				{
					return false;
				}
			}
			newNode = child;
			return true;
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x0008880C File Offset: 0x00086A0C
		private static bool ProcessSimplifyCase_EliminateWhenClauses(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.CaseOp caseOp, global::System.Data.Entity.Core.Query.InternalTrees.Node caseOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = null;
			newNode = caseOpNode;
			int i = 0;
			while (i < caseOpNode.Children.Count)
			{
				if (i == caseOpNode.Children.Count - 1)
				{
					if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast == caseOpNode.Children[i].Op.OpType)
					{
						return false;
					}
					if (list != null)
					{
						list.Add(caseOpNode.Children[i]);
						break;
					}
					break;
				}
				else
				{
					if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast == caseOpNode.Children[i + 1].Op.OpType)
					{
						return false;
					}
					if (caseOpNode.Children[i].Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstantPredicate)
					{
						if (list != null)
						{
							list.Add(caseOpNode.Children[i]);
							list.Add(caseOpNode.Children[i + 1]);
						}
						i += 2;
					}
					else
					{
						global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp constantPredicateOp = (global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp)caseOpNode.Children[i].Op;
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
							for (int j = 0; j < i; j++)
							{
								list.Add(caseOpNode.Children[j]);
							}
						}
						if (constantPredicateOp.IsTrue)
						{
							list.Add(caseOpNode.Children[i + 1]);
							break;
						}
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(constantPredicateOp.IsFalse, "constant predicate must be either true or false");
						i += 2;
					}
				}
			}
			if (list == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count > 0, "new args list must not be empty");
			if (list.Count == 1)
			{
				newNode = list[0];
			}
			else
			{
				newNode = context.Command.CreateNode(caseOp, list);
			}
			return true;
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00088994 File Offset: 0x00086B94
		private static bool ProcessFlattenCase(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node caseOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = caseOpNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = caseOpNode.Children[caseOpNode.Children.Count - 1];
			if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case)
			{
				return false;
			}
			caseOpNode.Children.RemoveAt(caseOpNode.Children.Count - 1);
			caseOpNode.Children.AddRange(node.Children);
			return true;
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000889F8 File Offset: 0x00086BF8
		private static bool ProcessIsNullOverCase(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node isNullOpNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = isNullOpNode.Child0;
			if (child.Children.Count != 3)
			{
				newNode = isNullOpNode;
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child3 = child.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child4 = child.Child2;
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = child3.Op.OpType;
			if (opType > global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
			{
				if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.OpType opType2 = child4.Op.OpType;
					if (opType2 <= global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
					{
						newNode = child2;
						return true;
					}
				}
			}
			else if (child4.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
			{
				newNode = context.Command.CreateNode(context.Command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), child2);
				return true;
			}
			newNode = isNullOpNode;
			return false;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00088A94 File Offset: 0x00086C94
		private static bool ProcessComparisonsOverConstant(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = node;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ || node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE, "unexpected comparison op type?");
			bool? flag = new bool?(node.Child0.Op.IsEquivalent(node.Child1.Op));
			if (flag == null)
			{
				return false;
			}
			bool value = (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ) ? flag.Value : (!flag.Value);
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op = context.Command.CreateConstantPredicateOp(value);
			newNode = context.Command.CreateNode(op);
			return true;
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00088B3C File Offset: 0x00086D3C
		private static bool? MatchesPattern(string str, string pattern)
		{
			int num = pattern.IndexOf('%');
			if (num == -1 || num != pattern.Length - 1 || pattern.Length > str.Length + 1)
			{
				return null;
			}
			bool value = true;
			int num2 = 0;
			while (num2 < str.Length && num2 < pattern.Length - 1)
			{
				if (pattern[num2] != str[num2])
				{
					value = false;
					break;
				}
				num2++;
			}
			return new bool?(value);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00088BB8 File Offset: 0x00086DB8
		private static bool ProcessLikeOverConstant(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp internalConstantOp = (global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp)n.Child1.Op;
			bool? flag = global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.MatchesPattern((string)((global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp)n.Child0.Op).Value, (string)internalConstantOp.Value);
			if (flag == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op = context.Command.CreateConstantPredicateOp(flag.Value);
			newNode = context.Command.CreateNode(op);
			return true;
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00088C34 File Offset: 0x00086E34
		private static bool ProcessLogOpOverConstant(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Node constantPredicateNode, global::System.Data.Entity.Core.Query.InternalTrees.Node otherNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(constantPredicateNode != null, "null constantPredicateOp?");
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp constantPredicateOp = (global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp)constantPredicateNode.Op;
			switch (node.Op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.And:
				newNode = (constantPredicateOp.IsTrue ? otherNode : constantPredicateNode);
				return true;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or:
				newNode = (constantPredicateOp.IsTrue ? constantPredicateNode : otherNode);
				return true;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not:
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(otherNode == null, "Not Op with more than 1 child. Gasp!");
				newNode = context.Command.CreateNode(context.Command.CreateConstantPredicateOp(!constantPredicateOp.Value));
				return true;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Unexpected OpType - " + node.Op.OpType.ToString());
			newNode = null;
			return true;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00088D04 File Offset: 0x00086F04
		private static bool ProcessAndOverConstantPredicate1(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLogOpOverConstant(context, node, node.Child1, node.Child0, out newNode);
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00088D1A File Offset: 0x00086F1A
		private static bool ProcessAndOverConstantPredicate2(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLogOpOverConstant(context, node, node.Child0, node.Child1, out newNode);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00088D30 File Offset: 0x00086F30
		private static bool ProcessOrOverConstantPredicate1(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLogOpOverConstant(context, node, node.Child1, node.Child0, out newNode);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00088D46 File Offset: 0x00086F46
		private static bool ProcessOrOverConstantPredicate2(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLogOpOverConstant(context, node, node.Child0, node.Child1, out newNode);
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00088D5C File Offset: 0x00086F5C
		private static bool ProcessNotOverConstantPredicate(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLogOpOverConstant(context, node, node.Child0, null, out newNode);
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00088D6D File Offset: 0x00086F6D
		private static bool ProcessIsNullOverConstant(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node isNullNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = context.Command.CreateNode(context.Command.CreateFalseOp());
			return true;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00088D88 File Offset: 0x00086F88
		private static bool ProcessIsNullOverNull(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node isNullNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = context.Command.CreateNode(context.Command.CreateTrueOp());
			return true;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00088DA3 File Offset: 0x00086FA3
		private static bool ProcessNullCast(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node castNullOp, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = context.Command.CreateNode(context.Command.CreateNullOp(castNullOp.Op.Type));
			return true;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00088DCC File Offset: 0x00086FCC
		private static bool ProcessIsNullOverVarRef(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node isNullNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)isNullNode.Child0.Op).Var;
			if (transformationRulesContext.IsNonNullable(var))
			{
				newNode = command.CreateNode(context.Command.CreateFalseOp());
				return true;
			}
			newNode = isNullNode;
			return false;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00088E20 File Offset: 0x00087020
		private static bool ProcessIsNullOverAnything(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node isNullNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = isNullNode.Child0.Op.OpType;
			if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Cast)
			{
				if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function)
				{
					newNode = isNullNode;
				}
				else
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function = ((global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp)isNullNode.Child0.Op).Function;
					newNode = (global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.PreservesNulls(function) ? command.CreateNode(command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), isNullNode.Child0.Child0) : isNullNode);
				}
			}
			else
			{
				newNode = command.CreateNode(command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), isNullNode.Child0.Child0);
			}
			switch (isNullNode.Child0.Op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel:
				return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverConstant(context, newNode, out newNode);
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null:
				return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverNull(context, newNode, out newNode);
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef:
				return global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverVarRef(context, newNode, out newNode);
			}
			return isNullNode != newNode;
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00088F06 File Offset: 0x00087106
		private static bool PreservesNulls(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return function.FullName == "Edm.Length";
		}

		// Token: 0x04000E7D RID: 3709
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_SimplifyCase = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessSimplifyCase));

		// Token: 0x04000E7E RID: 3710
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_FlattenCase = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Case, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessFlattenCase));

		// Token: 0x04000E7F RID: 3711
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverCase = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverCase));

		// Token: 0x04000E80 RID: 3712
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_EqualsOverConstant = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp.PatternEq, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessComparisonsOverConstant));

		// Token: 0x04000E81 RID: 3713
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_LikeOverConstants = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LikeOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.NullOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessLikeOverConstant));

		// Token: 0x04000E82 RID: 3714
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_AndOverConstantPred1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternAnd, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessAndOverConstantPredicate1));

		// Token: 0x04000E83 RID: 3715
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_AndOverConstantPred2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternAnd, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessAndOverConstantPredicate2));

		// Token: 0x04000E84 RID: 3716
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OrOverConstantPred1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternOr, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessOrOverConstantPredicate1));

		// Token: 0x04000E85 RID: 3717
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OrOverConstantPred2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternOr, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessOrOverConstantPredicate2));

		// Token: 0x04000E86 RID: 3718
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_NotOverConstantPred = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternNot, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessNotOverConstantPredicate));

		// Token: 0x04000E87 RID: 3719
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverConstant = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverConstant));

		// Token: 0x04000E88 RID: 3720
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverNullSentinel = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverConstant));

		// Token: 0x04000E89 RID: 3721
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverNull = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.NullOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverNull));

		// Token: 0x04000E8A RID: 3722
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_NullCast = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CastOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.NullOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessNullCast));

		// Token: 0x04000E8B RID: 3723
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverVarRef = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverVarRef));

		// Token: 0x04000E8C RID: 3724
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_IsNullOverAnything = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp.PatternIsNull, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.ProcessIsNullOverAnything));

		// Token: 0x04000E8D RID: 3725
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverCase,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_SimplifyCase,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_FlattenCase,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_LikeOverConstants,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_EqualsOverConstant,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred1,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_AndOverConstantPred2,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_OrOverConstantPred1,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_OrOverConstantPred2,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_NotOverConstantPred,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverConstant,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverNullSentinel,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverNull,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_NullCast,
			global::System.Data.Entity.Core.Query.PlanCompiler.ScalarOpRules.Rule_IsNullOverVarRef
		};
	}
}
