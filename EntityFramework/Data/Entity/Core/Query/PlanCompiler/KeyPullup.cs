using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200034E RID: 846
	internal class KeyPullup : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor
	{
		// Token: 0x060028A1 RID: 10401 RVA: 0x0007C352 File Offset: 0x0007A552
		internal KeyPullup(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_command = command;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0007C361 File Offset: 0x0007A561
		internal global::System.Data.Entity.Core.Query.InternalTrees.KeyVec GetKeys(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = node.GetExtendedNodeInfo(this.m_command);
			if (extendedNodeInfo.Keys.NoKeys)
			{
				this.VisitNode(node);
			}
			return extendedNodeInfo.Keys;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0007C388 File Offset: 0x0007A588
		protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				if (node.Op.IsRelOp || node.Op.IsPhysicalOp)
				{
					this.GetKeys(node);
				}
			}
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x0007C3F8 File Offset: 0x0007A5F8
		protected override void VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0007C40D File Offset: 0x0007A60D
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			op.Table.ReferencedColumns.Or(op.Table.Keys);
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0007C438 File Offset: 0x0007A638
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = n.Child0.GetExtendedNodeInfo(this.m_command);
			if (!extendedNodeInfo.Keys.NoKeys)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(op.Outputs);
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap = global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor.ComputeVarRemappings(n.Child1);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec other = extendedNodeInfo.Keys.KeyVars.Remap(varMap);
				varVec.Or(other);
				op.Outputs.InitFrom(varVec);
			}
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0007C4BC File Offset: 0x0007A6BC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_command.CreateSetOpVar(this.m_command.IntegerType);
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec[] array = new global::System.Data.Entity.Core.Query.InternalTrees.VarVec[n.Children.Count];
			for (int i = 0; i < n.Children.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Children[i];
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec v = this.m_command.GetExtendedNodeInfo(node).Keys.KeyVars.Remap(op.VarMap[i]);
				array[i] = this.m_command.CreateVarVec(v);
				array[i].Minus(op.Outputs);
				if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll == node.Op.OpType)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp unionAllOp = (global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)node.Op;
					array[i].Clear(unionAllOp.BranchDiscriminator);
				}
				varList.AddRange(array[i]);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList2 = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var2 in varList)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item = this.m_command.CreateSetOpVar(var2.Type);
				varList2.Add(item);
			}
			for (int j = 0; j < n.Children.Count; j++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = n.Children[j];
				global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.m_command.GetExtendedNodeInfo(node2);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Data.Entity.Core.Query.InternalTrees.Var branchDiscriminator;
				if (global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll == node2.Op.OpType && ((global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)node2.Op).BranchDiscriminator != null)
				{
					branchDiscriminator = ((global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)node2.Op).BranchDiscriminator;
					if (!op.VarMap[j].ContainsValue(branchDiscriminator))
					{
						op.VarMap[j].Add(var, branchDiscriminator);
					}
					else
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(j == 0, "right branch has a discriminator var that the left branch doesn't have?");
						var = op.VarMap[j].GetReverseMap()[branchDiscriminator];
					}
				}
				else
				{
					list.Add(this.m_command.CreateVarDefNode(this.m_command.CreateNode(this.m_command.CreateConstantOp(this.m_command.IntegerType, this.m_command.NextBranchDiscriminatorValue)), out branchDiscriminator));
					varVec.Set(branchDiscriminator);
					op.VarMap[j].Add(var, branchDiscriminator);
				}
				for (int k = 0; k < varList.Count; k++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var3 = varList[k];
					if (!array[j].IsSet(var3))
					{
						list.Add(this.m_command.CreateVarDefNode(this.m_command.CreateNode(this.m_command.CreateNullOp(var3.Type)), out var3));
						varVec.Set(var3);
					}
					op.VarMap[j].Add(varList2[k], var3);
				}
				if (varVec.IsEmpty)
				{
					extendedNodeInfo.Keys.KeyVars.Set(branchDiscriminator);
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count != 0, "no new nodes?");
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v2 in op.VarMap[j].Values)
					{
						varVec.Set(v2);
					}
					n.Children[j] = this.m_command.CreateNode(this.m_command.CreateProjectOp(varVec), node2, this.m_command.CreateNode(this.m_command.CreateVarDefListOp(), list));
					this.m_command.RecomputeNodeInfo(n.Children[j]);
					global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.m_command.GetExtendedNodeInfo(n.Children[j]);
					extendedNodeInfo2.Keys.KeyVars.InitFrom(extendedNodeInfo.Keys.KeyVars);
					extendedNodeInfo2.Keys.KeyVars.Set(branchDiscriminator);
				}
			}
			n.Op = this.m_command.CreateUnionAllOp(op.VarMap[0], op.VarMap[1], var);
			this.m_command.RecomputeNodeInfo(n);
		}

		// Token: 0x04000E28 RID: 3624
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
	}
}
