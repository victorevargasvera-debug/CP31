using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C3 RID: 963
	internal class NodeInfoVisitor : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo>
	{
		// Token: 0x06002E08 RID: 11784 RVA: 0x00091A48 File Offset: 0x0008FC48
		internal void RecomputeNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n.IsNodeInfoInitialized)
			{
				base.VisitNode(n).ComputeHashValue(this.m_command, n);
			}
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00091A65 File Offset: 0x0008FC65
		internal NodeInfoVisitor(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_command = command;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00091A74 File Offset: 0x0008FC74
		private global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo GetNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.GetNodeInfo(this.m_command);
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00091A82 File Offset: 0x0008FC82
		private global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo GetExtendedNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.GetExtendedNodeInfo(this.m_command);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00091A90 File Offset: 0x0008FC90
		private global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo InitNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(n);
			nodeInfo.Clear();
			return nodeInfo;
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00091A9F File Offset: 0x0008FC9F
		private global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo InitExtendedNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.GetExtendedNodeInfo(n);
			extendedNodeInfo.Clear();
			return extendedNodeInfo;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00091AB0 File Offset: 0x0008FCB0
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.InitNodeInfo(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo2 = this.GetNodeInfo(n2);
				nodeInfo.ExternalReferences.Or(nodeInfo2.ExternalReferences);
			}
			return nodeInfo;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00091B20 File Offset: 0x0008FD20
		private static bool IsDefinitionNonNullable(global::System.Data.Entity.Core.Query.InternalTrees.Node definition, global::System.Data.Entity.Core.Query.InternalTrees.VarVec nonNullableInputs)
		{
			return definition.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant || definition.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InternalConstant || definition.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NullSentinel || (definition.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef && nonNullableInputs.IsSet(((global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)definition.Op).Var));
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00091B7E File Offset: 0x0008FD7E
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.InitNodeInfo(n);
			nodeInfo.ExternalReferences.Set(op.Var);
			return nodeInfo;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00091B98 File Offset: 0x0008FD98
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.Unimplemented(n);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00091BA4 File Offset: 0x0008FDA4
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitTableOp(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			extendedNodeInfo.LocalDefinitions.Or(op.Table.ReferencedColumns);
			extendedNodeInfo.Definitions.Or(op.Table.ReferencedColumns);
			if (op.Table.ReferencedColumns.Subsumes(op.Table.Keys))
			{
				extendedNodeInfo.Keys.InitFrom(op.Table.Keys);
			}
			extendedNodeInfo.NonNullableDefinitions.Or(op.Table.NonNullableColumns);
			extendedNodeInfo.NonNullableDefinitions.And(extendedNodeInfo.Definitions);
			return extendedNodeInfo;
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00091C40 File Offset: 0x0008FE40
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Table.Columns)
			{
				extendedNodeInfo.LocalDefinitions.Set(v);
				extendedNodeInfo.Definitions.Set(v);
			}
			if (n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarDef && n.Child0.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function && op.Table.Keys.Count > 0 && op.Table.ReferencedColumns.Subsumes(op.Table.Keys))
			{
				extendedNodeInfo.Keys.InitFrom(op.Table.Keys);
			}
			if (n.HasChild0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(n.Child0);
				extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
			}
			else
			{
				extendedNodeInfo.ExternalReferences.Set(op.Var);
			}
			return extendedNodeInfo;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00091D60 File Offset: 0x0008FF60
		internal static global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> ComputeVarRemappings(global::System.Data.Entity.Core.Query.InternalTrees.Node varDefListNode)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in varDefListNode.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = node.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
				if (varRefOp != null)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
					dictionary[varRefOp.Var] = varDefOp.Var;
				}
			}
			return dictionary;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00091DE8 File Offset: 0x0008FFE8
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Outputs)
			{
				if (extendedNodeInfo2.Definitions.IsSet(v))
				{
					extendedNodeInfo.Definitions.Set(v);
				}
				else
				{
					extendedNodeInfo.ExternalReferences.Set(v);
				}
			}
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableDefinitions.And(op.Outputs);
			extendedNodeInfo.NonNullableVisibleDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(node.Child0);
				extendedNodeInfo.LocalDefinitions.Set(varDefOp.Var);
				extendedNodeInfo.ExternalReferences.Clear(varDefOp.Var);
				extendedNodeInfo.Definitions.Set(varDefOp.Var);
				extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
				if (global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor.IsDefinitionNonNullable(node.Child0, extendedNodeInfo.NonNullableVisibleDefinitions))
				{
					extendedNodeInfo.NonNullableDefinitions.Set(varDefOp.Var);
				}
			}
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo2.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.Keys.NoKeys = true;
			if (!extendedNodeInfo2.Keys.NoKeys)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(extendedNodeInfo2.Keys.KeyVars);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap = global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor.ComputeVarRemappings(n.Child1);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = varVec.Remap(varMap);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varSet = varVec2.Clone();
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec other = this.m_command.CreateVarVec(op.Outputs);
				varVec2.Minus(other);
				if (varVec2.IsEmpty)
				{
					extendedNodeInfo.Keys.InitFrom(varSet);
				}
			}
			extendedNodeInfo.InitRowCountFrom(extendedNodeInfo2);
			return extendedNodeInfo;
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00092018 File Offset: 0x00090218
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(n.Child1);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo2.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys);
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableVisibleDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.MinRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp constantPredicateOp = n.Child1.Op as global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp;
			if (constantPredicateOp != null && constantPredicateOp.IsFalse)
			{
				extendedNodeInfo.MaxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			}
			else
			{
				extendedNodeInfo.MaxRows = extendedNodeInfo2.MaxRows;
			}
			return extendedNodeInfo;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000920F8 File Offset: 0x000902F8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			extendedNodeInfo.Definitions.InitFrom(op.Outputs);
			extendedNodeInfo.LocalDefinitions.InitFrom(extendedNodeInfo.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Child1.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(node.Child0);
				extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
				if (global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor.IsDefinitionNonNullable(node.Child0, extendedNodeInfo2.NonNullableDefinitions))
				{
					extendedNodeInfo.NonNullableDefinitions.Set(((global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op).Var);
				}
			}
			extendedNodeInfo.NonNullableDefinitions.Or(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableDefinitions.And(op.Keys);
			for (int i = 2; i < n.Children.Count; i++)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in n.Children[i].Children)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo2 = this.GetNodeInfo(node2.Child0);
					extendedNodeInfo.ExternalReferences.Or(nodeInfo2.ExternalReferences);
				}
			}
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Keys.InitFrom(op.Keys);
			extendedNodeInfo.MinRows = (op.Keys.IsEmpty ? global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One : ((extendedNodeInfo2.MinRows == global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One) ? global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One : global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero));
			extendedNodeInfo.MaxRows = (op.Keys.IsEmpty ? global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One : extendedNodeInfo2.MaxRows);
			return extendedNodeInfo;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000922E8 File Offset: 0x000904E8
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.KeyVec> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.KeyVec>();
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount rowCount = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount rowCount2 = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n2);
				extendedNodeInfo.Definitions.Or(extendedNodeInfo2.Definitions);
				extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
				list.Add(extendedNodeInfo2.Keys);
				extendedNodeInfo.NonNullableDefinitions.Or(extendedNodeInfo2.NonNullableDefinitions);
				if (extendedNodeInfo2.MaxRows > rowCount)
				{
					rowCount = extendedNodeInfo2.MaxRows;
				}
				if (extendedNodeInfo2.MinRows < rowCount2)
				{
					rowCount2 = extendedNodeInfo2.MinRows;
				}
			}
			extendedNodeInfo.Keys.InitFrom(list);
			extendedNodeInfo.SetRowCount(rowCount2, rowCount);
			return extendedNodeInfo;
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000923D4 File Offset: 0x000905D4
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin && op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin)
			{
				return this.Unimplemented(n);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo3 = this.GetExtendedNodeInfo(n.Child1);
			global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(n.Child2);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo3.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo3.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo.Definitions);
			extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys, extendedNodeInfo3.Keys);
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			}
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin)
			{
				extendedNodeInfo.NonNullableDefinitions.Or(extendedNodeInfo3.NonNullableDefinitions);
			}
			extendedNodeInfo.NonNullableVisibleDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableVisibleDefinitions.Or(extendedNodeInfo3.NonNullableDefinitions);
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount minRows;
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount maxRows;
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin)
			{
				minRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
				maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Unbounded;
			}
			else
			{
				if (extendedNodeInfo2.MaxRows > global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One || extendedNodeInfo3.MaxRows > global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One)
				{
					maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Unbounded;
				}
				else
				{
					maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One;
				}
				if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
				{
					minRows = extendedNodeInfo2.MinRows;
				}
				else
				{
					minRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
				}
			}
			extendedNodeInfo.SetRowCount(minRows, maxRows);
			return extendedNodeInfo;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00092564 File Offset: 0x00090764
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo3 = this.GetExtendedNodeInfo(n.Child1);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo3.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo3.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo.Definitions);
			extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys, extendedNodeInfo3.Keys);
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply)
			{
				extendedNodeInfo.NonNullableDefinitions.Or(extendedNodeInfo3.NonNullableDefinitions);
			}
			extendedNodeInfo.NonNullableVisibleDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableVisibleDefinitions.Or(extendedNodeInfo3.NonNullableDefinitions);
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount maxRows;
			if (extendedNodeInfo2.MaxRows <= global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One && extendedNodeInfo3.MaxRows <= global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One)
			{
				maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One;
			}
			else
			{
				maxRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Unbounded;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount minRows = (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossApply) ? global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero : extendedNodeInfo2.MinRows;
			extendedNodeInfo.SetRowCount(minRows, maxRows);
			return extendedNodeInfo;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00092684 File Offset: 0x00090884
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			extendedNodeInfo.Definitions.InitFrom(op.Outputs);
			extendedNodeInfo.LocalDefinitions.InitFrom(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo3 = this.GetExtendedNodeInfo(n.Child1);
			global::System.Data.Entity.Core.Query.InternalTrees.RowCount minRows = global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero;
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo3.ExternalReferences);
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll)
			{
				minRows = ((extendedNodeInfo2.MinRows > extendedNodeInfo3.MinRows) ? extendedNodeInfo2.MinRows : extendedNodeInfo3.MinRows);
			}
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except)
			{
				extendedNodeInfo.Keys.InitFrom(op.Outputs);
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp unionAllOp = (global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)op;
				if (unionAllOp.BranchDiscriminator == null)
				{
					extendedNodeInfo.Keys.NoKeys = true;
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
					for (int i = 0; i < n.Children.Count; i++)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo4 = n.Children[i].GetExtendedNodeInfo(this.m_command);
						if (extendedNodeInfo4.Keys.NoKeys || extendedNodeInfo4.Keys.KeyVars.IsEmpty)
						{
							varVec.Clear();
							break;
						}
						global::System.Data.Entity.Core.Query.InternalTrees.VarVec other = extendedNodeInfo4.Keys.KeyVars.Remap(unionAllOp.VarMap[i].GetReverseMap());
						varVec.Or(other);
					}
					if (varVec.IsEmpty)
					{
						extendedNodeInfo.Keys.NoKeys = true;
					}
					else
					{
						extendedNodeInfo.Keys.InitFrom(varVec);
					}
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec other2 = extendedNodeInfo2.NonNullableDefinitions.Remap(op.VarMap[0].GetReverseMap());
			extendedNodeInfo.NonNullableDefinitions.InitFrom(other2);
			if (op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec other3 = extendedNodeInfo3.NonNullableDefinitions.Remap(op.VarMap[1].GetReverseMap());
				if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect)
				{
					extendedNodeInfo.NonNullableDefinitions.Or(other3);
				}
				else
				{
					extendedNodeInfo.NonNullableDefinitions.And(other3);
				}
			}
			extendedNodeInfo.NonNullableDefinitions.And(op.Outputs);
			extendedNodeInfo.MinRows = minRows;
			return extendedNodeInfo;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x000928B8 File Offset: 0x00090AB8
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			extendedNodeInfo.Definitions.Or(extendedNodeInfo2.Definitions);
			extendedNodeInfo.ExternalReferences.Or(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys);
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableVisibleDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.InitRowCountFrom(extendedNodeInfo2);
			if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort == op.OpType && n.Child2.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Constant && !((global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp)op).WithTies)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp constantBaseOp = (global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp)n.Child2.Op;
				if (global::System.Data.Entity.Core.Common.TypeHelpers.IsIntegerConstant(constantBaseOp.Type, constantBaseOp.Value, 1L))
				{
					extendedNodeInfo.SetRowCount(global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero, global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One);
				}
			}
			return extendedNodeInfo;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x000929A0 File Offset: 0x00090BA0
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			extendedNodeInfo.Keys.InitFrom(op.Keys, true);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			extendedNodeInfo.ExternalReferences.InitFrom(extendedNodeInfo2.ExternalReferences);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.Keys)
			{
				if (extendedNodeInfo2.Definitions.IsSet(v))
				{
					extendedNodeInfo.Definitions.Set(v);
				}
				else
				{
					extendedNodeInfo.ExternalReferences.Set(v);
				}
			}
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableDefinitions.And(op.Keys);
			extendedNodeInfo.InitRowCountFrom(extendedNodeInfo2);
			return extendedNodeInfo;
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00092A70 File Offset: 0x00090C70
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			extendedNodeInfo.Definitions.InitFrom(extendedNodeInfo2.Definitions);
			extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys);
			extendedNodeInfo.ExternalReferences.InitFrom(extendedNodeInfo2.ExternalReferences);
			extendedNodeInfo.NonNullableDefinitions.InitFrom(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.SetRowCount(global::System.Data.Entity.Core.Query.InternalTrees.RowCount.Zero, global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One);
			return extendedNodeInfo;
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00092ADD File Offset: 0x00090CDD
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			extendedNodeInfo.Keys.NoKeys = false;
			extendedNodeInfo.SetRowCount(global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One, global::System.Data.Entity.Core.Query.InternalTrees.RowCount.One);
			return extendedNodeInfo;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00092AFC File Offset: 0x00090CFC
		public override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.GetNodeInfo(n2);
				extendedNodeInfo.ExternalReferences.Or(nodeInfo.ExternalReferences);
			}
			extendedNodeInfo.Definitions.InitFrom(op.Outputs);
			extendedNodeInfo.LocalDefinitions.InitFrom(extendedNodeInfo.Definitions);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.GetExtendedNodeInfo(n.Child0);
			if (!extendedNodeInfo2.Keys.NoKeys)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(extendedNodeInfo2.Keys.KeyVars);
				varVec.Minus(extendedNodeInfo.Definitions);
				if (varVec.IsEmpty)
				{
					extendedNodeInfo.Keys.InitFrom(extendedNodeInfo2.Keys);
				}
			}
			extendedNodeInfo.NonNullableDefinitions.Or(extendedNodeInfo2.NonNullableDefinitions);
			extendedNodeInfo.NonNullableDefinitions.And(extendedNodeInfo.Definitions);
			extendedNodeInfo.NonNullableVisibleDefinitions.Or(extendedNodeInfo2.NonNullableVisibleDefinitions);
			return extendedNodeInfo;
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00092C18 File Offset: 0x00090E18
		protected override global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp singleStreamNestOp = op as global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp;
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.InitExtendedNodeInfo(n);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in op.CollectionInfo)
			{
				extendedNodeInfo.LocalDefinitions.Set(collectionInfo.CollectionVar);
			}
			extendedNodeInfo.Definitions.InitFrom(op.Outputs);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				extendedNodeInfo.ExternalReferences.Or(this.GetExtendedNodeInfo(n2).ExternalReferences);
			}
			extendedNodeInfo.ExternalReferences.Minus(extendedNodeInfo.Definitions);
			if (singleStreamNestOp == null)
			{
				extendedNodeInfo.Keys.InitFrom(this.GetExtendedNodeInfo(n.Child0).Keys);
			}
			else
			{
				extendedNodeInfo.Keys.InitFrom(singleStreamNestOp.Keys);
			}
			return extendedNodeInfo;
		}

		// Token: 0x04000F60 RID: 3936
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
	}
}
