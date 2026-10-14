using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200034D RID: 845
	internal static class JoinOpRules
	{
		// Token: 0x0600289D RID: 10397 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		private static bool ProcessJoinOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = joinNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = joinNode.HasChild2 ? joinNode.Child2 : null;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int> varRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, int>();
			if (node != null && !transformationRulesContext.IsScalarOpTree(node, varRefMap))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = command.CreateVarVec();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			if (joinNode.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && joinNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project && joinNode.Child1.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)joinNode.Child0.Op;
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp2 = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)joinNode.Child1.Op;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap = transformationRulesContext.GetVarMap(joinNode.Child0.Child1, varRefMap);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap2 = transformationRulesContext.GetVarMap(joinNode.Child1.Child1, varRefMap);
				if (varMap == null || varMap2 == null)
				{
					return false;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg;
				if (node != null)
				{
					node = transformationRulesContext.ReMap(node, varMap);
					node = transformationRulesContext.ReMap(node, varMap2);
					arg = context.Command.CreateNode(joinNode.Op, joinNode.Child0.Child0, joinNode.Child1.Child0, node);
				}
				else
				{
					arg = context.Command.CreateNode(joinNode.Op, joinNode.Child0.Child0, joinNode.Child1.Child0);
				}
				varVec.InitFrom(projectOp.Outputs);
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in projectOp2.Outputs)
				{
					varVec.Set(v);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = command.CreateProjectOp(varVec);
				list.AddRange(joinNode.Child0.Child1.Children);
				list.AddRange(joinNode.Child1.Child1.Children);
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = command.CreateNode(command.CreateVarDefListOp(), list);
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = command.CreateNode(op, arg, arg2);
				newNode = node2;
				return true;
			}
			else
			{
				int index;
				int index2;
				if (joinNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
				{
					index = 0;
					index2 = 1;
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(joinNode.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin, "unexpected non-LeftOuterJoin");
					index = 1;
					index2 = 0;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = joinNode.Children[index];
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp3 = node3.Op as global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp;
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varMap3 = transformationRulesContext.GetVarMap(node3.Child1, varRefMap);
				if (varMap3 == null)
				{
					return false;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(joinNode.Children[index2]);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = command.CreateVarVec(projectOp3.Outputs);
				varVec2.Or(extendedNodeInfo.Definitions);
				projectOp3.Outputs.InitFrom(varVec2);
				if (node != null)
				{
					node = transformationRulesContext.ReMap(node, varMap3);
					joinNode.Child2 = node;
				}
				joinNode.Children[index] = node3.Child0;
				context.Command.RecomputeNodeInfo(joinNode);
				newNode = context.Command.CreateNode(projectOp3, joinNode, node3.Child1);
				return true;
			}
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0007BBB0 File Offset: 0x00079DB0
		private static bool ProcessJoinOverFilter(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = joinNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext transformationRulesContext = (global::System.Data.Entity.Core.Query.PlanCompiler.TransformationRulesContext)context;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = transformationRulesContext.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = joinNode.Child0;
			if (joinNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter)
			{
				node = joinNode.Child0.Child1;
				child = joinNode.Child0.Child0;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = joinNode.Child1;
			if (joinNode.Child1.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter && joinNode.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				if (node == null)
				{
					node = joinNode.Child1.Child1;
				}
				else
				{
					node = command.CreateNode(command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, joinNode.Child1.Child1);
				}
				arg = joinNode.Child1.Child0;
			}
			if (node == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2;
			if (joinNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				arg2 = command.CreateNode(joinNode.Op, child, arg);
			}
			else
			{
				arg2 = command.CreateNode(joinNode.Op, child, arg, joinNode.Child2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op = command.CreateFilterOp();
			newNode = command.CreateNode(op, arg2, node);
			transformationRulesContext.SuppressFilterPushdown(newNode);
			return true;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0007BCC3 File Offset: 0x00079EC3
		private static bool ProcessJoinOverSingleRowTable(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = joinNode;
			if (joinNode.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRowTable)
			{
				newNode = joinNode.Child1;
			}
			else
			{
				newNode = joinNode.Child0;
			}
			return true;
		}

		// Token: 0x04000E1A RID: 3610
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverProject1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverProject));

		// Token: 0x04000E1B RID: 3611
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverProject2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverProject));

		// Token: 0x04000E1C RID: 3612
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_InnerJoinOverProject1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverProject));

		// Token: 0x04000E1D RID: 3613
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_InnerJoinOverProject2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverProject));

		// Token: 0x04000E1E RID: 3614
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterJoinOverProject2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverProject));

		// Token: 0x04000E1F RID: 3615
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverFilter1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			})
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverFilter));

		// Token: 0x04000E20 RID: 3616
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverFilter2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverFilter));

		// Token: 0x04000E21 RID: 3617
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_InnerJoinOverFilter1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverFilter));

		// Token: 0x04000E22 RID: 3618
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_InnerJoinOverFilter2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverFilter));

		// Token: 0x04000E23 RID: 3619
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_OuterJoinOverFilter2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverFilter));

		// Token: 0x04000E24 RID: 3620
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverSingleRowTable1 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverSingleRowTable));

		// Token: 0x04000E25 RID: 3621
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_CrossJoinOverSingleRowTable2 = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverSingleRowTable));

		// Token: 0x04000E26 RID: 3622
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_LeftOuterJoinOverSingleRowTable = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.ProcessJoinOverSingleRowTable));

		// Token: 0x04000E27 RID: 3623
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverProject1,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverProject2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverProject1,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverProject2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_OuterJoinOverProject2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverFilter1,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverFilter2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverFilter1,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_InnerJoinOverFilter2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_OuterJoinOverFilter2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverSingleRowTable1,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_CrossJoinOverSingleRowTable2,
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinOpRules.Rule_LeftOuterJoinOverSingleRowTable
		};
	}
}
