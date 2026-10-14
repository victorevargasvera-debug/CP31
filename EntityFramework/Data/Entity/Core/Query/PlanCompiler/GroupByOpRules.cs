using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000347 RID: 839
	internal static class GroupByOpRules
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x00074F20 File Offset: 0x00073120
		private static bool ProcessGroupByWithSimpleVarRedefinitions(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp groupByOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)n.Op;
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
					groupByOp.Outputs.Clear(varDefOp.Var);
					groupByOp.Outputs.Set(varRefOp2.Var);
					groupByOp.Keys.Clear(varDefOp.Var);
					groupByOp.Keys.Set(varRefOp2.Var);
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

		// Token: 0x060027E3 RID: 10211 RVA: 0x000750F8 File Offset: 0x000732F8
		private static bool ProcessGroupByOpOnAllInputColumnsWithAggregateOperation(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = context.Command.Root.Op as global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp;
			if (physicalProjectOp == null || physicalProjectOp.Outputs.Count > 1)
			{
				return false;
			}
			if (n.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
			{
				return false;
			}
			if (n.Child2 == null || n.Child2.Child0 == null || n.Child2.Child0.Child0 == null || n.Child2.Child0.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Aggregate)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp groupByOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)n.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = ((global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)n.Child0.Op).Table;
			global::System.Data.Entity.Core.Query.InternalTrees.VarList columns = table.Columns;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in columns)
			{
				if (!groupByOp.Keys.IsSet(v))
				{
					return false;
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v2 in columns)
			{
				groupByOp.Outputs.Clear(v2);
				groupByOp.Keys.Clear(v2);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = command.CreateScanTableOp(table.TableMetadata);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = command.CreateNode(scanTableOp);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = command.CreateNode(command.CreateOuterApplyOp(), arg, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var v3;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = command.CreateVarDefListNode(command.CreateNode(command.CreateVarRefOp(groupByOp.Outputs.First)), out v3);
			newNode = command.CreateNode(command.CreateProjectOp(v3), arg2, arg3);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator2 = scanTableOp.Table.Keys.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator3 = table.Keys.GetEnumerator();
			for (int i = 0; i < table.Keys.Count; i++)
			{
				enumerator2.MoveNext();
				enumerator3.MoveNext();
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = command.CreateNode(command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false), command.CreateNode(command.CreateVarRefOp(enumerator2.Current)), command.CreateNode(command.CreateVarRefOp(enumerator3.Current)));
				if (node != null)
				{
					node = command.CreateNode(command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
				else
				{
					node = node2;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = command.CreateNode(command.CreateFilterOp(), n.Child0, node);
			n.Child0 = child;
			return true;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0007539C File Offset: 0x0007359C
		private static bool ProcessGroupByOverProject(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			newNode = n;
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp groupByOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)n.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child2 = child.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child3 = n.Child1;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child4 = n.Child2;
			if (child3.Children.Count > 0)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = command.GetExtendedNodeInfo(child).LocalDefinitions;
			if (groupByOp.Outputs.Overlaps(varVec))
			{
				return false;
			}
			bool flag = false;
			for (int i = 0; i < child2.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = child2.Children[i];
				if (node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant || node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant || node.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel)
				{
					if (!flag)
					{
						varVec = command.CreateVarVec(varVec);
						flag = true;
					}
					varVec.Clear(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var);
				}
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.VarRefUsageFinder.AnyVarUsedMoreThanOnce(varVec, child4, command))
			{
				return false;
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node>(child2.Children.Count);
			for (int j = 0; j < child2.Children.Count; j++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = child2.Children[j];
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = ((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node2.Op).Var;
				dictionary.Add(var, node2.Child0);
			}
			newNode.Child2 = global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.VarRefReplacer.Replace(dictionary, child4, command);
			newNode.Child0 = child.Child0;
			return true;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00075528 File Offset: 0x00073728
		private static bool ProcessGroupByOpWithNoAggregates(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.Node newNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Command command = context.Command;
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp groupByOp = (global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)n.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = command.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op = command.CreateProjectOp(groupByOp.Keys);
			newNode = command.CreateNode(op, n.Child0, n.Child1);
			if (extendedNodeInfo.Keys.NoKeys || !groupByOp.Keys.Subsumes(extendedNodeInfo.Keys.KeyVars))
			{
				newNode = command.CreateNode(command.CreateDistinctOp(command.CreateVarVec(groupByOp.Keys)), newNode);
			}
			return true;
		}

		// Token: 0x04000DF1 RID: 3569
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_GroupByOpWithSimpleVarRedefinitions = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.ProcessGroupByWithSimpleVarRedefinitions));

		// Token: 0x04000DF2 RID: 3570
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule Rule_GroupByOpOnAllInputColumnsWithAggregateOperation = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleRule(global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy, new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.ProcessGroupByOpOnAllInputColumnsWithAggregateOperation));

		// Token: 0x04000DF3 RID: 3571
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_GroupByOverProject = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
				new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
			}),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.ProcessGroupByOverProject));

		// Token: 0x04000DF4 RID: 3572
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule Rule_GroupByOpWithNoAggregates = new global::System.Data.Entity.Core.Query.InternalTrees.PatternMatchRule(new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
		{
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.LeafOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0]),
			new global::System.Data.Entity.Core.Query.InternalTrees.Node(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Pattern, new global::System.Data.Entity.Core.Query.InternalTrees.Node[0])
		}), new global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate(global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.ProcessGroupByOpWithNoAggregates));

		// Token: 0x04000DF5 RID: 3573
		internal static readonly global::System.Data.Entity.Core.Query.InternalTrees.Rule[] Rules = new global::System.Data.Entity.Core.Query.InternalTrees.Rule[]
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOpWithSimpleVarRedefinitions,
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOverProject,
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOpWithNoAggregates,
			global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.Rule_GroupByOpOnAllInputColumnsWithAggregateOperation
		};

		// Token: 0x020009DD RID: 2525
		internal class VarRefReplacer : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
		{
			// Token: 0x06005FCA RID: 24522 RVA: 0x00148AA4 File Offset: 0x00146CA4
			private VarRefReplacer(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varReplacementTable, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
			{
				this.m_varReplacementTable = varReplacementTable;
				this.m_command = command;
			}

			// Token: 0x06005FCB RID: 24523 RVA: 0x00148ABA File Offset: 0x00146CBA
			internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Replace(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> varReplacementTable, global::System.Data.Entity.Core.Query.InternalTrees.Node root, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
			{
				return new global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.VarRefReplacer(varReplacementTable, command).VisitNode(root);
			}

			// Token: 0x06005FCC RID: 24524 RVA: 0x00148ACC File Offset: 0x00146CCC
			public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node result;
				if (this.m_varReplacementTable.TryGetValue(op.Var, out result))
				{
					return result;
				}
				return n;
			}

			// Token: 0x06005FCD RID: 24525 RVA: 0x00148AF4 File Offset: 0x00146CF4
			protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = base.VisitDefault(n);
				this.m_command.RecomputeNodeInfo(node);
				return node;
			}

			// Token: 0x0400286F RID: 10351
			private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_varReplacementTable;

			// Token: 0x04002870 RID: 10352
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
		}

		// Token: 0x020009DE RID: 2526
		internal class VarRefUsageFinder : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor
		{
			// Token: 0x06005FCE RID: 24526 RVA: 0x00148B16 File Offset: 0x00146D16
			private VarRefUsageFinder(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
			{
				this.m_varVec = varVec;
				this.m_usedVars = command.CreateVarVec();
			}

			// Token: 0x06005FCF RID: 24527 RVA: 0x00148B31 File Offset: 0x00146D31
			internal static bool AnyVarUsedMoreThanOnce(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec, global::System.Data.Entity.Core.Query.InternalTrees.Node root, global::System.Data.Entity.Core.Query.InternalTrees.Command command)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.VarRefUsageFinder varRefUsageFinder = new global::System.Data.Entity.Core.Query.PlanCompiler.GroupByOpRules.VarRefUsageFinder(varVec, command);
				varRefUsageFinder.VisitNode(root);
				return varRefUsageFinder.m_anyUsedMoreThenOnce;
			}

			// Token: 0x06005FD0 RID: 24528 RVA: 0x00148B48 File Offset: 0x00146D48
			public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = op.Var;
				if (this.m_varVec.IsSet(var))
				{
					if (this.m_usedVars.IsSet(var))
					{
						this.m_anyUsedMoreThenOnce = true;
						return;
					}
					this.m_usedVars.Set(var);
				}
			}

			// Token: 0x06005FD1 RID: 24529 RVA: 0x00148B8C File Offset: 0x00146D8C
			protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
			{
				if (this.m_anyUsedMoreThenOnce)
				{
					return;
				}
				base.VisitChildren(n);
			}

			// Token: 0x04002871 RID: 10353
			private bool m_anyUsedMoreThenOnce;

			// Token: 0x04002872 RID: 10354
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_varVec;

			// Token: 0x04002873 RID: 10355
			private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_usedVars;
		}
	}
}
