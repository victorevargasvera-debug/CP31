using System;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200032F RID: 815
	internal static class ApplyOpRules
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x0006F464 File Offset: 0x0006D664
		private static bool ProcessApplyOverFilter(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			if (((global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context).PlanCompiler.TransformationsDeferred)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = command.GetNodeInfo(child.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(applyNode.Child0);
			if (nodeInfo.ExternalReferences.Overlaps(extendedNodeInfo.Definitions))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op;
			if (applyNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply)
			{
				op = command.CreateInnerJoinOp();
			}
			else
			{
				op = command.CreateLeftOuterJoinOp();
			}
			newNode = command.CreateNode(op, applyNode.Child0, child.Child0, child.Child1);
			return true;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0006F500 File Offset: 0x0006D700
		private static bool ProcessOuterApplyOverDummyProjectOverFilter(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)child.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child3 = child2.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(child3);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = command.GetExtendedNodeInfo(applyNode.Child0);
			if (projectOp.Outputs.Overlaps(extendedNodeInfo2.Definitions) || extendedNodeInfo.ExternalReferences.Overlaps(extendedNodeInfo2.Definitions))
			{
				return false;
			}
			bool flag = false;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = null;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Var first;
			bool flag2;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext.TryGetInt32Var(extendedNodeInfo.NonNullableDefinitions, out first))
			{
				flag2 = true;
			}
			else
			{
				first = extendedNodeInfo.NonNullableDefinitions.First;
				flag2 = false;
			}
			if (first != null)
			{
				flag = true;
				global::System.Data.Entity.Core.Query.InternalTrees.Node child4 = child.Child1.Child0;
				if (child4.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel && flag2 && transformationRulesContext.CanChangeNullSentinelValue)
				{
					child4.Child0 = context.Command.CreateNode(context.Command.CreateVarRefOp(first));
				}
				else
				{
					child4.Child0 = transformationRulesContext.BuildNullIfExpression(first, child4.Child0);
				}
				command.RecomputeNodeInfo(child4);
				command.RecomputeNodeInfo(child.Child1);
				arg = child3;
			}
			else
			{
				arg = child;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in command.GetNodeInfo(child2.Child1).ExternalReferences)
				{
					if (extendedNodeInfo.Definitions.IsSet(v))
					{
						projectOp.Outputs.Set(v);
					}
				}
				child.Child0 = child3;
			}
			context.Command.RecomputeNodeInfo(child);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = command.CreateNode(command.CreateLeftOuterJoinOp(), applyNode.Child0, arg, child2.Child1);
			if (flag)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo3 = command.GetExtendedNodeInfo(node);
				child.Child0 = node;
				projectOp.Outputs.Or(extendedNodeInfo3.Definitions);
				newNode = child;
			}
			else
			{
				newNode = node;
			}
			return true;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0006F70C File Offset: 0x0006D90C
		private static bool ProcessCrossApplyOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)child.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(applyNode);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = command.CreateVarVec(projectOp.Outputs);
			varVec.Or(extendedNodeInfo.Definitions);
			projectOp.Outputs.InitFrom(varVec);
			applyNode.Child1 = child.Child0;
			context.Command.RecomputeNodeInfo(applyNode);
			child.Child0 = applyNode;
			newNode = child;
			return true;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0006F784 File Offset: 0x0006D984
		private static bool ProcessOuterApplyOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child1;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Var first = context.Command.GetExtendedNodeInfo(child.Child0).NonNullableDefinitions.First;
			if (first == null && child2.Children.Count == 1 && (child2.Child0.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant || child2.Child0.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp internalConstantOp = null;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(child.Child0);
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in child2.Children)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef, "Expected VarDefOp. Found " + node2.Op.OpType.ToString() + " instead");
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = node2.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
				if (varRefOp == null || !extendedNodeInfo.Definitions.IsSet(varRefOp.Var))
				{
					if (first == null)
					{
						internalConstantOp = command.CreateInternalConstantOp(command.IntegerType, 1);
						global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = command.CreateNode(internalConstantOp);
						global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateVarDefListNode(definingExpr, out first);
						global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = command.CreateProjectOp(first);
						projectOp.Outputs.Or(extendedNodeInfo.Definitions);
						node = command.CreateNode(projectOp, child.Child0, arg);
					}
					global::System.Data.Entity.Core.Query.InternalTrees.Node child3;
					if (internalConstantOp != null && (internalConstantOp.IsEquivalent(node2.Child0.Op) || node2.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel))
					{
						child3 = command.CreateNode(command.CreateVarRefOp(first));
					}
					else
					{
						child3 = transformationRulesContext.BuildNullIfExpression(first, node2.Child0);
					}
					node2.Child0 = child3;
					command.RecomputeNodeInfo(node2);
					flag = true;
				}
			}
			if (flag)
			{
				command.RecomputeNodeInfo(child2);
			}
			applyNode.Child1 = ((node != null) ? node : child.Child0);
			command.RecomputeNodeInfo(applyNode);
			child.Child0 = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = command.GetExtendedNodeInfo(applyNode.Child0);
			((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)child.Op).Outputs.Or(extendedNodeInfo2.Definitions);
			newNode = child;
			return true;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0006FA10 File Offset: 0x0006DC10
		private static bool ProcessApplyOverAnything(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = applyNode.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp applyBaseOp = (global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp)applyNode.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(child2);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = command.GetExtendedNodeInfo(child);
			bool flag = false;
			if (applyBaseOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.OuterApply && extendedNodeInfo.MinRows >= global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One)
			{
				applyBaseOp = command.CreateCrossApplyOp();
				flag = true;
			}
			if (!extendedNodeInfo.ExternalReferences.Overlaps(extendedNodeInfo2.Definitions))
			{
				if (applyBaseOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply)
				{
					newNode = command.CreateNode(command.CreateCrossJoinOp(), child, child2);
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp op = command.CreateLeftOuterJoinOp();
					global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op2 = command.CreateTrueOp();
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateNode(op2);
					newNode = command.CreateNode(op, child, child2, arg);
				}
				return true;
			}
			if (flag)
			{
				newNode = command.CreateNode(applyBaseOp, child, child2);
				return true;
			}
			return false;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0006FAE4 File Offset: 0x0006DCE4
		private static bool ProcessApplyIntoScalarSubquery(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(applyNode.Child1);
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = applyNode.Op.OpType;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.CanRewriteApply(applyNode.Child1, extendedNodeInfo, opType))
			{
				newNode = applyNode;
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = command.GetExtendedNodeInfo(applyNode.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.Var first = extendedNodeInfo.Definitions.First;
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = command.CreateVarVec(extendedNodeInfo2.Definitions);
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			transformationRulesContext.RemapSubtree(applyNode.Child1);
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.VarDefinitionRemapper.RemapSubtree(applyNode.Child1, command, first);
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = command.CreateNode(command.CreateElementOp(first.Type), applyNode.Child1);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateVarDefListNode(definingExpr, out var);
			varVec.Set(var);
			newNode = command.CreateNode(command.CreateProjectOp(varVec), applyNode.Child0, arg);
			transformationRulesContext.AddVarMapping(first, var);
			return true;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0006FBBF File Offset: 0x0006DDBF
		private static bool CanRewriteApply(global::System.Data.Entity.Core.Query.InternalTrees.Node rightChild, global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo applyRightChildNodeInfo, global::System.Data.Entity.Core.Query.InternalTrees.OpType applyKind)
		{
			return applyRightChildNodeInfo.Definitions.Count == 1 && applyRightChildNodeInfo.MaxRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One && (applyKind != global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply || applyRightChildNodeInfo.MinRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One) && global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.OutputCountVisitor.CountOutputs(rightChild) == 1;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0006FBF8 File Offset: 0x0006DDF8
		private static bool ProcessCrossApplyOverLeftOuterJoinOverSingleRowTable(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node applyNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = applyNode;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = applyNode.Child1;
			if (((global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp)child.Child2.Op).IsFalse)
			{
				return false;
			}
			applyNode.Op = context.Command.CreateOuterApplyOp();
			applyNode.Child1 = child.Child1;
			return true;
		}

		// Token: 0x04000D88 RID: 3464
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossApplyOverFilter = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyOverFilter));

		// Token: 0x04000D89 RID: 3465
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyOverFilter = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyOverFilter));

		// Token: 0x04000D8A RID: 3466
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyOverProjectInternalConstantOverFilter = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
				{
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
				}),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
				{
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
					{
						new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
					})
				})
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessOuterApplyOverDummyProjectOverFilter));

		// Token: 0x04000D8B RID: 3467
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyOverProjectNullSentinelOverFilter = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
				{
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
				}),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
				{
					new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
					{
						new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
					})
				})
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessOuterApplyOverDummyProjectOverFilter));

		// Token: 0x04000D8C RID: 3468
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossApplyOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessCrossApplyOverProject));

		// Token: 0x04000D8D RID: 3469
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessOuterApplyOverProject));

		// Token: 0x04000D8E RID: 3470
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossApplyOverAnything = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyOverAnything));

		// Token: 0x04000D8F RID: 3471
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyOverAnything = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyOverAnything));

		// Token: 0x04000D90 RID: 3472
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossApplyIntoScalarSubquery = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyIntoScalarSubquery));

		// Token: 0x04000D91 RID: 3473
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterApplyIntoScalarSubquery = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessApplyIntoScalarSubquery));

		// Token: 0x04000D92 RID: 3474
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossApplyOverLeftOuterJoinOverSingleRowTable = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.ProcessCrossApplyOverLeftOuterJoinOverSingleRowTable));

		// Token: 0x04000D93 RID: 3475
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_CrossApplyOverAnything,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_CrossApplyOverFilter,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_CrossApplyOverProject,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverAnything,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverProjectInternalConstantOverFilter,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverProjectNullSentinelOverFilter,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverProject,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyOverFilter,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_CrossApplyOverLeftOuterJoinOverSingleRowTable,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_CrossApplyIntoScalarSubquery,
			global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.Rule_OuterApplyIntoScalarSubquery
		};

		// Token: 0x020009D1 RID: 2513
		internal class OutputCountVisitor : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<int>
		{
			// Token: 0x06005F98 RID: 24472 RVA: 0x001483BE File Offset: 0x001465BE
			internal static int CountOutputs(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
			{
				return new global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.OutputCountVisitor().VisitNode(node);
			}

			// Token: 0x06005F99 RID: 24473 RVA: 0x001483CC File Offset: 0x001465CC
			internal new int VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				int num = 0;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
				{
					num += base.VisitNode(n2);
				}
				return num;
			}

			// Token: 0x06005F9A RID: 24474 RVA: 0x00148428 File Offset: 0x00146628
			protected override int VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return this.VisitChildren(n);
			}

			// Token: 0x06005F9B RID: 24475 RVA: 0x00148431 File Offset: 0x00146631
			protected override int VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return op.Outputs.Count;
			}

			// Token: 0x06005F9C RID: 24476 RVA: 0x0014843E File Offset: 0x0014663E
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return op.Keys.Count;
			}

			// Token: 0x06005F9D RID: 24477 RVA: 0x0014844B File Offset: 0x0014664B
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return base.VisitNode(n.Child0);
			}

			// Token: 0x06005F9E RID: 24478 RVA: 0x00148459 File Offset: 0x00146659
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return op.Outputs.Count;
			}

			// Token: 0x06005F9F RID: 24479 RVA: 0x00148466 File Offset: 0x00146666
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return op.Outputs.Count;
			}

			// Token: 0x06005FA0 RID: 24480 RVA: 0x00148473 File Offset: 0x00146673
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return op.Table.Columns.Count;
			}

			// Token: 0x06005FA1 RID: 24481 RVA: 0x00148485 File Offset: 0x00146685
			public override int Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return 0;
			}

			// Token: 0x06005FA2 RID: 24482 RVA: 0x00148488 File Offset: 0x00146688
			protected override int VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				return base.VisitNode(n.Child0);
			}
		}

		// Token: 0x020009D2 RID: 2514
		internal class VarDefinitionRemapper : global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper
		{
			// Token: 0x06005FA4 RID: 24484 RVA: 0x0014849E File Offset: 0x0014669E
			private VarDefinitionRemapper(global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar, global::System.Data.Entity.Core.Query.InternalTrees.Command command) : base(command)
			{
				this.m_oldVar = oldVar;
			}

			// Token: 0x06005FA5 RID: 24485 RVA: 0x001484AE File Offset: 0x001466AE
			internal static void RemapSubtree(global::System.Data.Entity.Core.Query.InternalTrees.Node root, global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar)
			{
				new global::System.Data.Entity.Core.Query.PlanCompiler.ApplyOpRules.VarDefinitionRemapper(oldVar, command).RemapSubtree(root);
			}

			// Token: 0x06005FA6 RID: 24486 RVA: 0x001484C0 File Offset: 0x001466C0
			internal override void RemapSubtree(global::System.Data.Entity.Core.Query.InternalTrees.Node subTree)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node subTree2 in subTree.Children)
				{
					this.RemapSubtree(subTree2);
				}
				this.VisitNode(subTree);
				this.m_command.RecomputeNodeInfo(subTree);
			}

			// Token: 0x06005FA7 RID: 24487 RVA: 0x00148528 File Offset: 0x00146728
			public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				if (op.Var == this.m_oldVar)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_command.CreateComputedVar(n.Child0.Op.Type);
					n.Op = this.m_command.CreateVarDefOp(var);
					base.AddMapping(this.m_oldVar, var);
				}
			}

			// Token: 0x06005FA8 RID: 24488 RVA: 0x00148580 File Offset: 0x00146780
			public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				if (op.Table.Columns.Contains(this.m_oldVar))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = this.m_command.CreateScanTableOp(op.Table.TableMetadata);
					for (int i = 0; i < op.Table.Columns.Count; i++)
					{
						base.AddMapping(op.Table.Columns[i], scanTableOp.Table.Columns[i]);
					}
					n.Op = scanTableOp;
				}
			}

			// Token: 0x06005FA9 RID: 24489 RVA: 0x00148608 File Offset: 0x00146808
			protected override void VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				base.VisitSetOp(op, n);
				if (op.Outputs.IsSet(this.m_oldVar))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_command.CreateSetOpVar(this.m_oldVar.Type);
					op.Outputs.Clear(this.m_oldVar);
					op.Outputs.Set(var);
					this.RemapVarMapKey(op.VarMap[0], var);
					this.RemapVarMapKey(op.VarMap[1], var);
					base.AddMapping(this.m_oldVar, var);
				}
			}

			// Token: 0x06005FAA RID: 24490 RVA: 0x00148690 File Offset: 0x00146890
			private void RemapVarMapKey(global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap, global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var value = varMap[this.m_oldVar];
				varMap.Remove(this.m_oldVar);
				varMap.Add(newVar, value);
			}

			// Token: 0x04002864 RID: 10340
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Var m_oldVar;
		}
	}
}
