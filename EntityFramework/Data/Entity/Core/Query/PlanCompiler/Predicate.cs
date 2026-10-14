using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000359 RID: 857
	internal class Predicate
	{
		// Token: 0x06002970 RID: 10608 RVA: 0x00083B25 File Offset: 0x00081D25
		internal Predicate(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_command = command;
			this.m_parts = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00083B3F File Offset: 0x00081D3F
		internal Predicate(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.InternalTrees.Node andTree) : this(command)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(andTree != null, "null node passed to Predicate() constructor");
			this.InitFromAndTree(andTree);
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00083B5D File Offset: 0x00081D5D
		internal void AddPart(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_parts.Add(n);
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00083B6C File Offset: 0x00081D6C
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node BuildAndTree()
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in this.m_parts)
			{
				if (node == null)
				{
					node = node2;
				}
				else
				{
					node = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
			}
			return node;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00083BE0 File Offset: 0x00081DE0
		internal global::System.Data.Entity.Core.Query.PlanCompiler.Predicate GetSingleTablePredicates(global::System.Data.Entity.Core.Query.InternalTrees.VarVec tableDefinitions, out global::System.Data.Entity.Core.Query.PlanCompiler.Predicate otherPredicates)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.Predicate> list;
			this.GetSingleTablePredicates(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.VarVec>
			{
				tableDefinitions
			}, out list, out otherPredicates);
			return list[0];
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00083C0C File Offset: 0x00081E0C
		internal void GetEquiJoinPredicates(global::System.Data.Entity.Core.Query.InternalTrees.VarVec leftTableDefinitions, global::System.Data.Entity.Core.Query.InternalTrees.VarVec rightTableDefinitions, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> leftTableEquiJoinColumns, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> rightTableEquiJoinColumns, out global::System.Data.Entity.Core.Query.PlanCompiler.Predicate otherPredicates)
		{
			otherPredicates = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command);
			leftTableEquiJoinColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			rightTableEquiJoinColumns = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in this.m_parts)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item;
				global::System.Data.Entity.Core.Query.InternalTrees.Var item2;
				if (global::System.Data.Entity.Core.Query.PlanCompiler.Predicate.IsEquiJoinPredicate(node, leftTableDefinitions, rightTableDefinitions, out item, out item2))
				{
					leftTableEquiJoinColumns.Add(item);
					rightTableEquiJoinColumns.Add(item2);
				}
				else
				{
					otherPredicates.AddPart(node);
				}
			}
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00083CA0 File Offset: 0x00081EA0
		internal global::System.Data.Entity.Core.Query.PlanCompiler.Predicate GetJoinPredicates(global::System.Data.Entity.Core.Query.InternalTrees.VarVec leftTableDefinitions, global::System.Data.Entity.Core.Query.InternalTrees.VarVec rightTableDefinitions, out global::System.Data.Entity.Core.Query.PlanCompiler.Predicate otherPredicates)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.Predicate predicate = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command);
			otherPredicates = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in this.m_parts)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var;
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				if (global::System.Data.Entity.Core.Query.PlanCompiler.Predicate.IsEquiJoinPredicate(node, leftTableDefinitions, rightTableDefinitions, out var, out var2))
				{
					predicate.AddPart(node);
				}
				else
				{
					otherPredicates.AddPart(node);
				}
			}
			return predicate;
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00083D28 File Offset: 0x00081F28
		internal bool SatisfiesKey(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars, global::System.Data.Entity.Core.Query.InternalTrees.VarVec definitions)
		{
			if (keyVars.Count > 0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = keyVars.Clone();
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in this.m_parts)
				{
					if (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.Var v;
						if (this.IsKeyPredicate(node.Child0, node.Child1, keyVars, definitions, out v))
						{
							varVec.Clear(v);
						}
						else if (this.IsKeyPredicate(node.Child1, node.Child0, keyVars, definitions, out v))
						{
							varVec.Clear(v);
						}
					}
				}
				return varVec.IsEmpty;
			}
			return false;
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00083DE0 File Offset: 0x00081FE0
		internal bool PreservesNulls(global::System.Data.Entity.Core.Query.InternalTrees.VarVec tableColumns, bool ansiNullSemantics)
		{
			if (!ansiNullSemantics)
			{
				return true;
			}
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>.Enumerator enumerator = this.m_parts.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!global::System.Data.Entity.Core.Query.PlanCompiler.Predicate.PreservesNulls(enumerator.Current, tableColumns))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00083E40 File Offset: 0x00082040
		private void InitFromAndTree(global::System.Data.Entity.Core.Query.InternalTrees.Node andTree)
		{
			if (andTree.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.And)
			{
				this.InitFromAndTree(andTree.Child0);
				this.InitFromAndTree(andTree.Child1);
				return;
			}
			this.m_parts.Add(andTree);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00083E78 File Offset: 0x00082078
		private void GetSingleTablePredicates(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.VarVec> tableDefinitions, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.Predicate> singleTablePredicates, out global::System.Data.Entity.Core.Query.PlanCompiler.Predicate otherPredicates)
		{
			singleTablePredicates = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.Predicate>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec in tableDefinitions)
			{
				singleTablePredicates.Add(new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command));
			}
			otherPredicates = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.m_command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n in this.m_parts)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo nodeInfo = this.m_command.GetNodeInfo(n);
				bool flag = false;
				for (int i = 0; i < tableDefinitions.Count; i++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = tableDefinitions[i];
					if (varVec3 != null)
					{
						varVec2.InitFrom(nodeInfo.ExternalReferences);
						varVec2.Minus(varVec3);
						if (varVec2.IsEmpty)
						{
							flag = true;
							singleTablePredicates[i].AddPart(n);
							break;
						}
					}
				}
				if (!flag)
				{
					otherPredicates.AddPart(n);
				}
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00083FA0 File Offset: 0x000821A0
		private static bool IsEquiJoinPredicate(global::System.Data.Entity.Core.Query.InternalTrees.Node simplePredicateNode, out global::System.Data.Entity.Core.Query.InternalTrees.Var leftVar, out global::System.Data.Entity.Core.Query.InternalTrees.Var rightVar)
		{
			leftVar = null;
			rightVar = null;
			if (simplePredicateNode.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = simplePredicateNode.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp2 = simplePredicateNode.Child1.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp2 == null)
			{
				return false;
			}
			leftVar = varRefOp.Var;
			rightVar = varRefOp2.Var;
			return true;
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00084004 File Offset: 0x00082204
		private static bool IsEquiJoinPredicate(global::System.Data.Entity.Core.Query.InternalTrees.Node simplePredicateNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec leftTableDefinitions, global::System.Data.Entity.Core.Query.InternalTrees.VarVec rightTableDefinitions, out global::System.Data.Entity.Core.Query.InternalTrees.Var leftVar, out global::System.Data.Entity.Core.Query.InternalTrees.Var rightVar)
		{
			leftVar = null;
			rightVar = null;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.Predicate.IsEquiJoinPredicate(simplePredicateNode, out var, out var2))
			{
				return false;
			}
			if (leftTableDefinitions.IsSet(var) && rightTableDefinitions.IsSet(var2))
			{
				leftVar = var;
				rightVar = var2;
			}
			else
			{
				if (!leftTableDefinitions.IsSet(var2) || !rightTableDefinitions.IsSet(var))
				{
					return false;
				}
				leftVar = var2;
				rightVar = var;
			}
			return true;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00084060 File Offset: 0x00082260
		private static bool PreservesNulls(global::System.Data.Entity.Core.Query.InternalTrees.Node simplePredNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec tableColumns)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = simplePredNode.Op.OpType;
			if (opType - global::System.Data.Entity.Core.Query.InternalTrees.OpType.GT > 5)
			{
				if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Like)
				{
					if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not)
					{
						return true;
					}
					if (simplePredNode.Child0.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull)
					{
						return true;
					}
					global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = simplePredNode.Child0.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
					return varRefOp == null || !tableColumns.IsSet(varRefOp.Var);
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp constantBaseOp = simplePredNode.Child1.Op as global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp;
					if (constantBaseOp == null || constantBaseOp.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
					{
						return true;
					}
					global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = simplePredNode.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
					return varRefOp == null || !tableColumns.IsSet(varRefOp.Var);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = simplePredNode.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
				if (varRefOp != null && tableColumns.IsSet(varRefOp.Var))
				{
					return false;
				}
				varRefOp = (simplePredNode.Child1.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp);
				return varRefOp == null || !tableColumns.IsSet(varRefOp.Var);
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00084164 File Offset: 0x00082364
		private bool IsKeyPredicate(global::System.Data.Entity.Core.Query.InternalTrees.Node left, global::System.Data.Entity.Core.Query.InternalTrees.Node right, global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars, global::System.Data.Entity.Core.Query.InternalTrees.VarVec definitions, out global::System.Data.Entity.Core.Query.InternalTrees.Var keyVar)
		{
			keyVar = null;
			if (left.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.VarRef)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp)left.Op;
			keyVar = varRefOp.Var;
			if (!keyVars.IsSet(keyVar))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.GetNodeInfo(right).ExternalReferences.Clone();
			varVec.And(definitions);
			return varVec.IsEmpty;
		}

		// Token: 0x04000E58 RID: 3672
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x04000E59 RID: 3673
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> m_parts;
	}
}
