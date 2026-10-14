using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000379 RID: 889
	internal class VarRefManager
	{
		// Token: 0x06002AE9 RID: 10985 RVA: 0x0008BF67 File Offset: 0x0008A167
		internal VarRefManager(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_nodeToParentMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			this.m_nodeToSiblingNumber = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int>();
			this.m_command = command;
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x0008BF8C File Offset: 0x0008A18C
		internal void AddChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node parent)
		{
			for (int i = 0; i < parent.Children.Count; i++)
			{
				this.m_nodeToParentMap[parent.Children[i]] = parent;
				this.m_nodeToSiblingNumber[parent.Children[i]] = i;
			}
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x0008BFE0 File Offset: 0x0008A1E0
		internal bool HasKeyReferences(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Data.Entity.Core.Query.InternalTrees.Node definingNode, global::System.Data.Entity.Core.Query.InternalTrees.Node targetJoinNode)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node key = definingNode;
			bool flag = true;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node;
			while (flag & this.m_nodeToParentMap.TryGetValue(key, out node))
			{
				if (node != targetJoinNode)
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferencesShallow(node, keys, this.m_nodeToSiblingNumber[key], out flag))
					{
						return true;
					}
					for (int i = this.m_nodeToSiblingNumber[key] + 1; i < node.Children.Count; i++)
					{
						if (node.Children[i].GetNodeInfo(this.m_command).ExternalReferences.Overlaps(keys))
						{
							return true;
						}
					}
				}
				key = node;
			}
			return false;
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x0008C070 File Offset: 0x0008A270
		private static bool HasVarReferencesShallow(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars, int childIndex, out bool continueUp)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = node.Op.OpType;
			if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project)
			{
				switch (opType)
				{
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort:
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort:
					continueUp = true;
					return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences(((global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp)node.Op).Keys, vars);
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.GroupBy:
					continueUp = false;
					return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences(((global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp)node.Op).Keys, vars);
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll:
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect:
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except:
					continueUp = false;
					return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences((global::System.Data.Entity.Core.Query.InternalTrees.SetOp)node.Op, vars, childIndex);
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct:
					continueUp = false;
					return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences(((global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp)node.Op).Keys, vars);
				case global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject:
					continueUp = false;
					return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences(((global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)node.Op).Outputs, vars);
				}
				continueUp = true;
				return false;
			}
			continueUp = false;
			return global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager.HasVarReferences(((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)node.Op).Outputs, vars);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0008C174 File Offset: 0x0008A374
		private static bool HasVarReferences(global::System.Data.Entity.Core.Query.InternalTrees.VarList listToCheck, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var item in vars)
			{
				if (listToCheck.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0008C1C8 File Offset: 0x0008A3C8
		private static bool HasVarReferences(global::System.Data.Entity.Core.Query.InternalTrees.VarVec listToCheck, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars)
		{
			return listToCheck.Overlaps(vars);
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0008C1D4 File Offset: 0x0008A3D4
		private static bool HasVarReferences(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> listToCheck, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in listToCheck)
			{
				if (vars.IsSet(sortKey.Var))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x0008C230 File Offset: 0x0008A430
		private static bool HasVarReferences(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars, int index)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.VarMap[index].Values)
			{
				if (vars.IsSet(v))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000ED5 RID: 3797
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_nodeToParentMap;

		// Token: 0x04000ED6 RID: 3798
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> m_nodeToSiblingNumber;

		// Token: 0x04000ED7 RID: 3799
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
	}
}
