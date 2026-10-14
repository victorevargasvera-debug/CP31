using System;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000352 RID: 850
	internal class Normalizer : global::System.Data.Entity.Core.Query.PlanCompiler.SubqueryTrackingVisitor
	{
		// Token: 0x06002931 RID: 10545 RVA: 0x00082B36 File Offset: 0x00080D36
		private Normalizer(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState) : base(planCompilerState)
		{
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00082B3F File Offset: 0x00080D3F
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler planCompilerState)
		{
			new global::System.Data.Entity.Core.Query.PlanCompiler.Normalizer(planCompilerState).Process();
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00082B4C File Offset: 0x00080D4C
		private void Process()
		{
			base.m_command.Root = base.VisitNode(base.m_command.Root);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00082B6A File Offset: 0x00080D6A
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			n.Child0 = this.BuildDummyProjectForExists(n.Child0);
			return n;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00082B88 File Offset: 0x00080D88
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildDummyProjectForExists(global::System.Data.Entity.Core.Query.InternalTrees.Node child)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			return base.m_command.BuildProject(child, base.m_command.CreateNode(base.m_command.CreateInternalConstantOp(base.m_command.IntegerType, 1)), out var);
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00082BCC File Offset: 0x00080DCC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildUnnest(global::System.Data.Entity.Core.Query.InternalTrees.Node collectionNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(collectionNode.Op.IsScalarOp, "non-scalar usage of Un-nest?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(collectionNode.Op.Type), "non-collection usage for Un-nest?");
			global::System.Data.Entity.Core.Query.InternalTrees.Var v;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateVarDefNode(collectionNode, out v);
			global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op = base.m_command.CreateUnnestOp(v);
			return base.m_command.CreateNode(op, arg);
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00082C34 File Offset: 0x00080E34
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitCollectionFunction(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(op.Type), "non-TVF function?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildUnnest(n);
			global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp;
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op2 = base.m_command.CreatePhysicalProjectOp(unnestOp.Table.Columns[0]);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(op2, node);
			global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op3 = base.m_command.CreateCollectOp(n.Op.Type);
			return base.m_command.CreateNode(op3, arg);
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00082CBC File Offset: 0x00080EBC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitCollectionAggregateFunction(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast == child.Op.OpType)
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(child.Op.Type).TypeUsage;
				child = child.Child0;
				while (global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast == child.Op.OpType)
				{
					child = child.Child0;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildUnnest(child);
			global::System.Data.Entity.Core.Query.InternalTrees.Var v = (node.Op as global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp).Table.Columns[0];
			global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op2 = base.m_command.CreateAggregateOp(op.Function, false);
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op3 = base.m_command.CreateVarRefOp(v);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = base.m_command.CreateNode(op3);
			if (typeUsage != null)
			{
				arg = base.m_command.CreateNode(base.m_command.CreateSoftCastOp(typeUsage), arg);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr = base.m_command.CreateNode(op2, arg);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec gbyKeys = base.m_command.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = base.m_command.CreateNode(base.m_command.CreateVarDefListOp());
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = base.m_command.CreateVarVec();
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg3 = base.m_command.CreateVarDefListNode(definingExpr, out var);
			varVec.Set(var);
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op4 = base.m_command.CreateGroupByOp(gbyKeys, varVec);
			global::System.Data.Entity.Core.Query.InternalTrees.Node subquery = base.m_command.CreateNode(op4, node, arg2, arg3);
			return base.AddSubqueryToParentRelOp(var, subquery);
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00082E18 File Offset: 0x00081018
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(op.Type))
			{
				node = this.VisitCollectionFunction(op, n);
			}
			else if (global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsCollectionAggregateFunction(op, n))
			{
				node = this.VisitCollectionAggregateFunction(op, n);
			}
			else
			{
				node = n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "failure to construct a functionOp?");
			return node;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00082E6D File Offset: 0x0008106D
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (base.ProcessJoinOp(n))
			{
				n.Child2.Child0 = this.BuildDummyProjectForExists(n.Child2.Child0);
			}
			return n;
		}
	}
}
