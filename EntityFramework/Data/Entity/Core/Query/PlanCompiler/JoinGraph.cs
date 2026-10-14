using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200034B RID: 843
	internal class JoinGraph
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x00078F6C File Offset: 0x0007716C
		internal JoinGraph(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager constraintManager, global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager varRefManager, global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode)
		{
			this.m_command = command;
			this.m_constraintManager = constraintManager;
			this.m_varRefManager = varRefManager;
			this.m_vertexes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode>();
			this.m_tableVertexMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Table, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode>();
			this.m_varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			this.m_reverseVarMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.VarVec>();
			this.m_varToDefiningNodeMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode>();
			this.m_processedNodes = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			this.m_root = (this.BuildAugmentedNodeTree(joinNode) as global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(this.m_root != null, "The root isn't a join?");
			this.BuildJoinEdges(this.m_root, this.m_root.Id);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00079013 File Offset: 0x00077213
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node DoJoinElimination(out global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> processedNodes)
		{
			this.TryTurnLeftOuterJoinsIntoInnerJoins();
			this.GenerateTransitiveEdges();
			this.EliminateSelfJoins();
			this.EliminateParentChildJoins();
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = this.BuildNodeTree();
			varMap = this.m_varMap;
			processedNodes = this.m_processedNodes;
			return result;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00079044 File Offset: 0x00077244
		private global::System.Data.Entity.Core.Query.InternalTrees.VarVec GetColumnVars(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.m_command.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in varVec)
			{
				if (var.VarType == global::System.Data.Entity.Core.Query.InternalTrees.VarType.Column)
				{
					varVec2.Set(var);
				}
			}
			return varVec2;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x000790A4 File Offset: 0x000772A4
		private static void GetColumnVars(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> columnVars, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vec)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in vec)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(var.VarType == global::System.Data.Entity.Core.Query.InternalTrees.VarType.Column, "Expected a columnVar. Found " + var.VarType.ToString());
				columnVars.Add((global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar)var);
			}
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00079120 File Offset: 0x00077320
		private void SplitPredicate(global::System.Data.Entity.Core.Query.InternalTrees.Node joinNode, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> leftVars, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> rightVars, out global::System.Data.Entity.Core.Query.InternalTrees.Node otherPredicateNode)
		{
			leftVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			rightVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			otherPredicateNode = joinNode.Child2;
			if (joinNode.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin)
			{
				return;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.Predicate predicate = new global::System.Data.Entity.Core.Query.PlanCompiler.Predicate(this.m_command, joinNode.Child2);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo = this.m_command.GetExtendedNodeInfo(joinNode.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo extendedNodeInfo2 = this.m_command.GetExtendedNodeInfo(joinNode.Child1);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec columnVars = this.GetColumnVars(extendedNodeInfo.Definitions);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec columnVars2 = this.GetColumnVars(extendedNodeInfo2.Definitions);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> vec;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> vec2;
			global::System.Data.Entity.Core.Query.PlanCompiler.Predicate predicate2;
			predicate.GetEquiJoinPredicates(columnVars, columnVars2, out vec, out vec2, out predicate2);
			otherPredicateNode = predicate2.BuildAndTree();
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.GetColumnVars(leftVars, vec);
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.GetColumnVars(rightVars, vec2);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000791CC File Offset: 0x000773CC
		private global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode BuildAugmentedNodeTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode;
			switch (node.Op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable:
			{
				this.m_processedNodes[node] = node;
				global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = (global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)node.Op;
				augmentedNode = new global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode(this.m_vertexes.Count, node);
				this.m_tableVertexMap[scanTableOp.Table] = (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode)augmentedNode;
				goto IL_16A;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin:
			{
				this.m_processedNodes[node] = node;
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode leftChild = this.BuildAugmentedNodeTree(node.Child0);
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode rightChild = this.BuildAugmentedNodeTree(node.Child1);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> leftVars;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> rightVars;
				global::System.Data.Entity.Core.Query.InternalTrees.Node otherPredicate;
				this.SplitPredicate(node, out leftVars, out rightVars, out otherPredicate);
				this.m_varRefManager.AddChildren(node);
				augmentedNode = new global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode(this.m_vertexes.Count, node, leftChild, rightChild, leftVars, rightVars, otherPredicate);
				goto IL_16A;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin:
			{
				this.m_processedNodes[node] = node;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode>();
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in node.Children)
				{
					list.Add(this.BuildAugmentedNodeTree(node2));
				}
				augmentedNode = new global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode(this.m_vertexes.Count, node, list);
				this.m_varRefManager.AddChildren(node);
				goto IL_16A;
			}
			}
			augmentedNode = new global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode(this.m_vertexes.Count, node);
			IL_16A:
			this.m_vertexes.Add(augmentedNode);
			return augmentedNode;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00079360 File Offset: 0x00077560
		private bool AddJoinEdge(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode joinNode, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar leftVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar rightVar)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode;
			if (!this.m_tableVertexMap.TryGetValue(leftVar.Table, out augmentedTableNode))
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode right;
			if (!this.m_tableVertexMap.TryGetValue(rightVar.Table, out right))
			{
				return false;
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in augmentedTableNode.JoinEdges)
			{
				if (joinEdge.Right.Table.Equals(rightVar.Table))
				{
					return joinEdge.AddCondition(joinNode, leftVar, rightVar);
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge item = global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge.CreateJoinEdge(augmentedTableNode, right, joinNode, leftVar, rightVar);
			augmentedTableNode.JoinEdges.Add(item);
			joinNode.JoinEdges.Add(item);
			return true;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x0007942C File Offset: 0x0007762C
		private static bool SingleTableVars(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> varList)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar in varList)
			{
				if (table == null)
				{
					table = columnVar.Table;
				}
				else if (columnVar.Table != table)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0007948C File Offset: 0x0007768C
		private void BuildJoinEdges(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode joinNode, int maxVisibility)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = joinNode.Node.Op.OpType;
			if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode node in joinNode.Children)
				{
					this.BuildJoinEdges(node, maxVisibility);
				}
				return;
			}
			int maxVisibility2;
			int maxVisibility3;
			if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin)
			{
				maxVisibility2 = joinNode.Id;
				maxVisibility3 = joinNode.Id;
			}
			else if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				maxVisibility2 = maxVisibility;
				maxVisibility3 = joinNode.Id;
			}
			else
			{
				maxVisibility2 = maxVisibility;
				maxVisibility3 = maxVisibility;
			}
			this.BuildJoinEdges(joinNode.Children[0], maxVisibility2);
			this.BuildJoinEdges(joinNode.Children[1], maxVisibility3);
			if (joinNode.Node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.FullOuterJoin || joinNode.LeftVars.Count == 0)
			{
				return;
			}
			if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.SingleTableVars(joinNode.RightVars) || !global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.SingleTableVars(joinNode.LeftVars)))
			{
				return;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind joinKind = (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin) ? global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter : global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner;
			for (int i = 0; i < joinNode.LeftVars.Count; i++)
			{
				if (this.AddJoinEdge(joinNode, joinNode.LeftVars[i], joinNode.RightVars[i]) && joinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner)
				{
					this.AddJoinEdge(joinNode, joinNode.RightVars[i], joinNode.LeftVars[i]);
				}
			}
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000795F8 File Offset: 0x000777F8
		private void BuildJoinEdges(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode node, int maxVisibility)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = node.Node.Op.OpType;
			if (opType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
			{
				if (opType - global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin <= 3)
				{
					this.BuildJoinEdges(node as global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode, maxVisibility);
					return;
				}
			}
			else
			{
				((global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode)node).LastVisibleId = maxVisibility;
			}
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0007963C File Offset: 0x0007783C
		private static bool GenerateTransitiveEdge(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge1, global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge2)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edge1.Right == edge2.Left, "need a common table for transitive predicate generation");
			if (edge1.RestrictedElimination || edge2.RestrictedElimination)
			{
				return false;
			}
			if (edge2.Right == edge1.Left)
			{
				return false;
			}
			if (edge1.JoinKind != edge2.JoinKind)
			{
				return false;
			}
			if (edge1.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && (edge1.Left != edge1.Right || edge2.Left != edge2.Right))
			{
				return false;
			}
			if (edge1.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && edge1.RightVars.Count != edge2.LeftVars.Count)
			{
				return false;
			}
			using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>.Enumerator enumerator = edge1.Left.JoinEdges.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Right == edge2.Right)
					{
						return false;
					}
				}
			}
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> enumerable = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CreateOrderedKeyValueList(edge1.RightVars, edge1.LeftVars);
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> enumerable2 = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CreateOrderedKeyValueList(edge2.LeftVars, edge2.RightVars);
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> enumerator2 = enumerable.GetEnumerator();
			global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> enumerator3 = enumerable2.GetEnumerator();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>();
			bool flag = enumerator2.MoveNext() && enumerator3.MoveNext();
			while (flag)
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> keyValuePair = enumerator2.Current;
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar key = keyValuePair.Key;
				keyValuePair = enumerator3.Current;
				if (key == keyValuePair.Key)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list3 = list;
					keyValuePair = enumerator2.Current;
					list3.Add(keyValuePair.Value);
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list4 = list2;
					keyValuePair = enumerator3.Current;
					list4.Add(keyValuePair.Value);
					flag = (enumerator2.MoveNext() && enumerator3.MoveNext());
				}
				else
				{
					if (edge1.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter)
					{
						return false;
					}
					keyValuePair = enumerator2.Current;
					int id = keyValuePair.Key.Id;
					keyValuePair = enumerator3.Current;
					if (id > keyValuePair.Key.Id)
					{
						flag = enumerator3.MoveNext();
					}
					else
					{
						flag = enumerator2.MoveNext();
					}
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge item = global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge.CreateTransitiveJoinEdge(edge1.Left, edge2.Right, edge1.JoinKind, list, list2);
			edge1.Left.JoinEdges.Add(item);
			if (edge1.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge item2 = global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge.CreateTransitiveJoinEdge(edge2.Right, edge1.Left, edge1.JoinKind, list2, list);
				edge2.Right.JoinEdges.Add(item2);
			}
			return true;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x000798A4 File Offset: 0x00077AA4
		private static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> CreateOrderedKeyValueList(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> keyVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> valueVars)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>>(keyVars.Count);
			for (int i = 0; i < keyVars.Count; i++)
			{
				list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>(keyVars[i], valueVars[i]));
			}
			return from kv in list
			orderby kv.Key.Id
			select kv;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0007990C File Offset: 0x00077B0C
		private void TryTurnLeftOuterJoinsIntoInnerJoins()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode augmentedJoinNode in from j in this.m_vertexes.OfType<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode>()
			where j.Node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && j.JoinEdges.Count > 0
			select j)
			{
				if (this.CanAllJoinEdgesBeTurnedIntoInnerJoins(augmentedJoinNode.Children[1], augmentedJoinNode.JoinEdges))
				{
					augmentedJoinNode.Node.Op = this.m_command.CreateInnerJoinOp();
					this.m_modifiedGraph = true;
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>(augmentedJoinNode.JoinEdges.Count);
					foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in augmentedJoinNode.JoinEdges)
					{
						joinEdge.JoinKind = global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner;
						if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.ContainsJoinEdgeForTable(joinEdge.Right.JoinEdges, joinEdge.Left.Table))
						{
							global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge2 = global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge.CreateJoinEdge(joinEdge.Right, joinEdge.Left, augmentedJoinNode, joinEdge.RightVars[0], joinEdge.LeftVars[0]);
							joinEdge.Right.JoinEdges.Add(joinEdge2);
							list.Add(joinEdge2);
							for (int i = 1; i < joinEdge.LeftVars.Count; i++)
							{
								joinEdge2.AddCondition(augmentedJoinNode, joinEdge.RightVars[i], joinEdge.LeftVars[i]);
							}
						}
					}
					augmentedJoinNode.JoinEdges.AddRange(list);
				}
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00079AE8 File Offset: 0x00077CE8
		private static bool AreAllTableRowsPreserved(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode root, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode table)
		{
			if (root is global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode)
			{
				return true;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode = table;
			for (;;)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode augmentedJoinNode = (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode)augmentedNode.Parent;
				if (augmentedJoinNode.Node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin || augmentedJoinNode.Children[0] != augmentedNode)
				{
					break;
				}
				augmentedNode = augmentedJoinNode;
				if (augmentedNode == root)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00079B3C File Offset: 0x00077D3C
		private static bool ContainsJoinEdgeForTable(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> joinEdges, global::System.Data.Entity.Core.Query.InternalTrees.Table table)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> enumerator = joinEdges.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Right.Table.Equals(table))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00079B98 File Offset: 0x00077D98
		private bool CanAllJoinEdgesBeTurnedIntoInnerJoins(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode rightNode, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> joinEdges)
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in joinEdges)
			{
				if (!this.CanJoinEdgeBeTurnedIntoInnerJoin(rightNode, joinEdge))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00079BEC File Offset: 0x00077DEC
		private bool CanJoinEdgeBeTurnedIntoInnerJoin(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode rightNode, global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			return !joinEdge.RestrictedElimination && global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.AreAllTableRowsPreserved(rightNode, joinEdge.Right) && this.IsConstraintPresentForTurningIntoInnerJoin(joinEdge);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00079C10 File Offset: 0x00077E10
		private bool IsConstraintPresentForTurningIntoInnerJoin(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint> list;
			if (this.m_constraintManager.IsParentChildRelationship(joinEdge.Right.Table.TableMetadata.Extent, joinEdge.Left.Table.TableMetadata.Extent, out list))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list != null && list.Count > 0, "Invalid foreign key constraints");
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint foreignKeyConstraint in list)
				{
					global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> source;
					if (global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.IsJoinOnFkConstraint(foreignKeyConstraint, joinEdge.RightVars, joinEdge.LeftVars, out source) && foreignKeyConstraint.ParentKeys.Count == joinEdge.RightVars.Count)
					{
						if ((from v in source
						where v.ColumnMetadata.IsNullable
						select v).Count<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>() == 0)
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00079D10 File Offset: 0x00077F10
		private void GenerateTransitiveEdges()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode in this.m_vertexes)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode = augmentedNode as global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode;
				if (augmentedTableNode != null)
				{
					for (int i = 0; i < augmentedTableNode.JoinEdges.Count; i++)
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge = augmentedTableNode.JoinEdges[i];
						int j = 0;
						global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode right = joinEdge.Right;
						while (j < right.JoinEdges.Count)
						{
							global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge = right.JoinEdges[j];
							global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.GenerateTransitiveEdge(joinEdge, edge);
							j++;
						}
					}
				}
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00079DC4 File Offset: 0x00077FC4
		private static bool CanBeEliminatedBasedOnLojParticipation(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode table, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode replacingTable)
		{
			if (replacingTable.Id < table.NewLocationId)
			{
				return global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeMovedBasedOnLojParticipation(table, replacingTable);
			}
			return global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeMovedBasedOnLojParticipation(replacingTable, table);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00079DE4 File Offset: 0x00077FE4
		private static bool CanBeEliminatedViaStarJoinBasedOnOtherJoinParticipation(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge tableJoinEdge, global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge replacingTableJoinEdge)
		{
			if (tableJoinEdge.JoinNode == null || replacingTableJoinEdge.JoinNode == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode leastCommonAncestor = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.GetLeastCommonAncestor(tableJoinEdge.Right, replacingTableJoinEdge.Right);
			return !global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanGetFileredByJoins(tableJoinEdge, leastCommonAncestor, true) && !global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanGetFileredByJoins(replacingTableJoinEdge, leastCommonAncestor, false);
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00079E2C File Offset: 0x0007802C
		private static bool CanGetFileredByJoins(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode leastCommonAncestor, bool disallowAnyJoin)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode = joinEdge.Right;
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode parent = augmentedNode.Parent;
			while (parent != null && augmentedNode != leastCommonAncestor)
			{
				if (parent.Node != joinEdge.JoinNode.Node && (disallowAnyJoin || parent.Node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin || parent.Children[0] != augmentedNode))
				{
					return true;
				}
				augmentedNode = augmentedNode.Parent;
				parent = augmentedNode.Parent;
			}
			return false;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00079E9C File Offset: 0x0007809C
		private static bool CanBeMovedBasedOnLojParticipation(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode table, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode replacingTable)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode leastCommonAncestor = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.GetLeastCommonAncestor(table, replacingTable);
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode = table;
			while (augmentedNode.Parent != null && augmentedNode != leastCommonAncestor)
			{
				if (augmentedNode.Parent.Node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin && augmentedNode.Parent.Children[0] == augmentedNode)
				{
					return false;
				}
				augmentedNode = augmentedNode.Parent;
			}
			return true;
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00079EF8 File Offset: 0x000780F8
		private static global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode GetLeastCommonAncestor(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode node1, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode node2)
		{
			if (node1.Id == node2.Id)
			{
				return node1;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode2;
			if (node1.Id < node2.Id)
			{
				augmentedNode = node1;
				augmentedNode2 = node2;
			}
			else
			{
				augmentedNode = node2;
				augmentedNode2 = node1;
			}
			while (augmentedNode.Id < augmentedNode2.Id)
			{
				augmentedNode = augmentedNode.Parent;
			}
			return augmentedNode;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00079F48 File Offset: 0x00078148
		private void MarkTableAsEliminated<T>(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode replacementNode, global::System.Collections.Generic.List<T> tableVars, global::System.Collections.Generic.List<T> replacementVars) where T : global::System.Data.Entity.Core.Query.InternalTrees.Var
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(tableVars != null && replacementVars != null, "null vars");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(tableVars.Count == replacementVars.Count, "var count mismatch");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(tableVars.Count > 0, "no vars in the table ?");
			this.m_modifiedGraph = true;
			if (tableNode.Id < replacementNode.NewLocationId)
			{
				tableNode.ReplacementTable = replacementNode;
				replacementNode.NewLocationId = tableNode.Id;
			}
			else
			{
				tableNode.ReplacementTable = null;
			}
			for (int i = 0; i < tableVars.Count; i++)
			{
				if (tableNode.Table.ReferencedColumns.IsSet(tableVars[i]))
				{
					this.m_varMap[tableVars[i]] = replacementVars[i];
					this.AddReverseMapping(replacementVars[i], tableVars[i]);
					replacementNode.Table.ReferencedColumns.Set(replacementVars[i]);
				}
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in replacementNode.Table.ReferencedColumns)
			{
				this.m_varToDefiningNodeMap[key] = replacementNode;
			}
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0007A0A8 File Offset: 0x000782A8
		private void AddReverseMapping(global::System.Data.Entity.Core.Query.InternalTrees.Var replacingVar, global::System.Data.Entity.Core.Query.InternalTrees.Var replacedVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec;
			if (this.m_reverseVarMap.TryGetValue(replacedVar, out varVec))
			{
				this.m_reverseVarMap.Remove(replacedVar);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2;
			if (!this.m_reverseVarMap.TryGetValue(replacingVar, out varVec2))
			{
				if (varVec != null)
				{
					varVec2 = varVec;
				}
				else
				{
					varVec2 = this.m_command.CreateVarVec();
				}
				this.m_reverseVarMap[replacingVar] = varVec2;
			}
			else if (varVec != null)
			{
				varVec2.Or(varVec);
			}
			varVec2.Set(replacedVar);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0007A115 File Offset: 0x00078315
		private void EliminateSelfJoinedTable(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode replacementNode)
		{
			this.MarkTableAsEliminated<global::System.Data.Entity.Core.Query.InternalTrees.Var>(tableNode, replacementNode, tableNode.Table.Columns, replacementNode.Table.Columns);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0007A138 File Offset: 0x00078338
		private void EliminateStarSelfJoin(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> joinEdges)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>>();
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in joinEdges)
			{
				bool flag = false;
				foreach (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> list2 in list)
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.AreMatchingForStarSelfJoinElimination(list2[0], joinEdge))
					{
						list2.Add(joinEdge);
						flag = true;
						break;
					}
				}
				if (!flag && this.QualifiesForStarSelfJoinGroup(joinEdge))
				{
					list.Add(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>
					{
						joinEdge
					});
				}
			}
			foreach (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> list3 in from l in list
			where l.Count > 1
			select l)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge2 = list3[0];
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge3 in list3)
				{
					if (joinEdge2.Right.Id > joinEdge3.Right.Id)
					{
						joinEdge2 = joinEdge3;
					}
				}
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge4 in list3)
				{
					if (joinEdge4 != joinEdge2 && global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeEliminatedViaStarJoinBasedOnOtherJoinParticipation(joinEdge4, joinEdge2))
					{
						this.EliminateSelfJoinedTable(joinEdge4.Right, joinEdge2.Right);
					}
				}
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0007A31C File Offset: 0x0007851C
		private static bool AreMatchingForStarSelfJoinElimination(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge1, global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge2)
		{
			if (edge2.LeftVars.Count != edge1.LeftVars.Count || edge2.JoinKind != edge1.JoinKind)
			{
				return false;
			}
			for (int i = 0; i < edge2.LeftVars.Count; i++)
			{
				if (!edge2.LeftVars[i].Equals(edge1.LeftVars[i]) || !edge2.RightVars[i].ColumnMetadata.Name.Equals(edge1.RightVars[i].ColumnMetadata.Name))
				{
					return false;
				}
			}
			return global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.MatchOtherPredicates(edge1, edge2);
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0007A3C4 File Offset: 0x000785C4
		private static bool MatchOtherPredicates(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge1, global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge edge2)
		{
			if (edge1.JoinNode == null)
			{
				return edge2.JoinNode == null;
			}
			if (edge2.JoinNode == null)
			{
				return false;
			}
			if (edge1.JoinNode.OtherPredicate == null)
			{
				return edge2.JoinNode.OtherPredicate == null;
			}
			return edge2.JoinNode.OtherPredicate != null && global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.MatchOtherPredicates(edge1.JoinNode.OtherPredicate, edge2.JoinNode.OtherPredicate);
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0007A434 File Offset: 0x00078634
		private static bool MatchOtherPredicates(global::System.Data.Entity.Core.Query.InternalTrees.Node x, global::System.Data.Entity.Core.Query.InternalTrees.Node y)
		{
			if (x.Children.Count != y.Children.Count)
			{
				return false;
			}
			if (x.Op.IsEquivalent(y.Op))
			{
				return !x.Children.Where((global::System.Data.Entity.Core.Query.InternalTrees.Node t, int i) => !global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.MatchOtherPredicates(t, y.Children[i])).Any<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = x.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp2 = y.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp2 == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = varRefOp.Var as global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar;
			if (columnVar == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar2 = varRefOp2.Var as global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar;
			return columnVar2 != null && columnVar.ColumnMetadata.Name.Equals(columnVar2.ColumnMetadata.Name);
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0007A50C File Offset: 0x0007870C
		private bool QualifiesForStarSelfJoinGroup(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(joinEdge.Right.Table.Keys);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in joinEdge.RightVars)
			{
				if (joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && !varVec.IsSet(v))
				{
					return false;
				}
				varVec.Clear(v);
			}
			return varVec.IsEmpty && (joinEdge.JoinNode == null || joinEdge.JoinNode.OtherPredicate == null || global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.QualifiesForStarSelfJoinGroup(joinEdge.JoinNode.OtherPredicate, this.m_command.GetExtendedNodeInfo(joinEdge.Right.Node).Definitions));
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0007A5E0 File Offset: 0x000787E0
		private static bool QualifiesForStarSelfJoinGroup(global::System.Data.Entity.Core.Query.InternalTrees.Node otherPredicateNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec rightTableColumnVars)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp varRefOp = otherPredicateNode.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp;
			if (varRefOp == null)
			{
				return true;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = varRefOp.Var as global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar;
			return columnVar == null || (rightTableColumnVars.IsSet(columnVar) && otherPredicateNode.Children.All((global::System.Data.Entity.Core.Query.InternalTrees.Node node) => global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.QualifiesForStarSelfJoinGroup(node, rightTableColumnVars)));
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0007A644 File Offset: 0x00078844
		private void EliminateStarSelfJoins(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>>();
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in tableNode.JoinEdges)
			{
				if (!joinEdge.IsEliminated)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge> list;
					if (!dictionary.TryGetValue(joinEdge.Right.Table.TableMetadata.Extent, out list))
					{
						list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>();
						dictionary[joinEdge.Right.Table.TableMetadata.Extent] = list;
					}
					list.Add(joinEdge);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge>> keyValuePair in dictionary)
			{
				if (keyValuePair.Value.Count > 1)
				{
					this.EliminateStarSelfJoin(keyValuePair.Value);
				}
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0007A73C File Offset: 0x0007893C
		private bool EliminateSelfJoin(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			if (joinEdge.RestrictedElimination)
			{
				return false;
			}
			if (joinEdge.IsEliminated)
			{
				return false;
			}
			if (!joinEdge.Left.Table.TableMetadata.Extent.Equals(joinEdge.Right.Table.TableMetadata.Extent))
			{
				return false;
			}
			for (int i = 0; i < joinEdge.LeftVars.Count; i++)
			{
				if (!joinEdge.LeftVars[i].ColumnMetadata.Name.Equals(joinEdge.RightVars[i].ColumnMetadata.Name))
				{
					return false;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec(joinEdge.Left.Table.Keys);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in joinEdge.LeftVars)
			{
				if (joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && !varVec.IsSet(v))
				{
					return false;
				}
				varVec.Clear(v);
			}
			if (!varVec.IsEmpty)
			{
				return false;
			}
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeEliminatedBasedOnLojParticipation(joinEdge.Right, joinEdge.Left))
			{
				return false;
			}
			this.EliminateSelfJoinedTable(joinEdge.Right, joinEdge.Left);
			return true;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0007A88C File Offset: 0x00078A8C
		private void EliminateSelfJoins(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode)
		{
			if (tableNode.IsEliminated)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in tableNode.JoinEdges)
			{
				this.EliminateSelfJoin(joinEdge);
			}
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0007A8EC File Offset: 0x00078AEC
		private void EliminateSelfJoins()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode in this.m_vertexes)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode = augmentedNode as global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode;
				if (augmentedTableNode != null)
				{
					this.EliminateSelfJoins(augmentedTableNode);
					this.EliminateStarSelfJoins(augmentedTableNode);
				}
			}
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0007A950 File Offset: 0x00078B50
		private void EliminateLeftTable(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner, "Expected inner join");
			this.MarkTableAsEliminated<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>(joinEdge.Left, joinEdge.Right, joinEdge.LeftVars, joinEdge.RightVars);
			if (joinEdge.Right.NullableColumns == null)
			{
				joinEdge.Right.NullableColumns = this.m_command.CreateVarVec();
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar in joinEdge.RightVars)
			{
				if (columnVar.ColumnMetadata.IsNullable)
				{
					joinEdge.Right.NullableColumns.Set(columnVar);
				}
			}
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0007AA10 File Offset: 0x00078C10
		private void EliminateRightTable(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter, "Expected left-outer-join");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(joinEdge.Left.Id < joinEdge.Right.Id, string.Concat(new string[]
			{
				"(left-id, right-id) = (",
				joinEdge.Left.Id.ToString(),
				",",
				joinEdge.Right.Id.ToString(),
				")"
			}));
			this.MarkTableAsEliminated<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>(joinEdge.Right, joinEdge.Left, joinEdge.RightVars, joinEdge.LeftVars);
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0007AABA File Offset: 0x00078CBA
		private static bool HasNonKeyReferences(global::System.Data.Entity.Core.Query.InternalTrees.Table table)
		{
			return !table.Keys.Subsumes(table.ReferencedColumns);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0007AAD0 File Offset: 0x00078CD0
		private bool RightTableHasKeyReferences(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			if (joinEdge.JoinNode == null)
			{
				return true;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in joinEdge.Right.Table.Keys)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec other;
				if (this.m_reverseVarMap.TryGetValue(key, out other))
				{
					if (varVec == null)
					{
						varVec = joinEdge.Right.Table.Keys.Clone();
					}
					varVec.Or(other);
				}
			}
			if (varVec == null)
			{
				varVec = joinEdge.Right.Table.Keys;
			}
			return this.m_varRefManager.HasKeyReferences(varVec, joinEdge.Right.Node, joinEdge.JoinNode.Node);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0007AB94 File Offset: 0x00078D94
		private bool TryEliminateParentChildJoin(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge, global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint fkConstraint)
		{
			if (joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && fkConstraint.ChildMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
			{
				return false;
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.IsJoinOnFkConstraint(fkConstraint, joinEdge.LeftVars, joinEdge.RightVars, out list))
			{
				return false;
			}
			if (joinEdge.JoinKind != global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.Inner)
			{
				return this.TryEliminateRightTable(joinEdge, fkConstraint.ChildKeys.Count, fkConstraint.ChildMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.HasNonKeyReferences(joinEdge.Left.Table))
			{
				return false;
			}
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeEliminatedBasedOnLojParticipation(joinEdge.Right, joinEdge.Left))
			{
				return false;
			}
			this.EliminateLeftTable(joinEdge);
			return true;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x0007AC24 File Offset: 0x00078E24
		private static bool IsJoinOnFkConstraint(global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint fkConstraint, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> parentVars, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> childVars, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> childForeignKeyVars)
		{
			childForeignKeyVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>(fkConstraint.ChildKeys.Count);
			foreach (string value in fkConstraint.ParentKeys)
			{
				bool flag = false;
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> enumerator2 = parentVars.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.ColumnMetadata.Name.Equals(value))
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			foreach (string value2 in fkConstraint.ChildKeys)
			{
				bool flag2 = false;
				int i = 0;
				while (i < parentVars.Count)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = childVars[i];
					if (columnVar.ColumnMetadata.Name.Equals(value2))
					{
						childForeignKeyVars.Add(columnVar);
						flag2 = true;
						global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar2 = parentVars[i];
						string text;
						if (!fkConstraint.GetParentProperty(columnVar.ColumnMetadata.Name, out text) || !text.Equals(columnVar2.ColumnMetadata.Name))
						{
							return false;
						}
						break;
					}
					else
					{
						i++;
					}
				}
				if (!flag2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x0007ADA0 File Offset: 0x00078FA0
		private bool TryEliminateChildParentJoin(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge, global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint fkConstraint)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar> list;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.IsJoinOnFkConstraint(fkConstraint, joinEdge.RightVars, joinEdge.LeftVars, out list))
			{
				return false;
			}
			if (list.Count > 1)
			{
				if ((from v in list
				where v.ColumnMetadata.IsNullable
				select v).Count<global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar>() > 0)
				{
					return false;
				}
			}
			return this.TryEliminateRightTable(joinEdge, fkConstraint.ParentKeys.Count, true);
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0007AE10 File Offset: 0x00079010
		private bool TryEliminateRightTable(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge, int fkConstraintKeyCount, bool allowRefsForJoinedOnFkOnly)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.HasNonKeyReferences(joinEdge.Right.Table))
			{
				return false;
			}
			if ((!allowRefsForJoinedOnFkOnly || joinEdge.RightVars.Count != fkConstraintKeyCount) && this.RightTableHasKeyReferences(joinEdge))
			{
				return false;
			}
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.CanBeEliminatedBasedOnLojParticipation(joinEdge.Right, joinEdge.Left))
			{
				return false;
			}
			this.EliminateRightTable(joinEdge);
			return true;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x0007AE6C File Offset: 0x0007906C
		private void EliminateParentChildJoin(global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge)
		{
			if (joinEdge.RestrictedElimination)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint> list;
			if (this.m_constraintManager.IsParentChildRelationship(joinEdge.Left.Table.TableMetadata.Extent, joinEdge.Right.Table.TableMetadata.Extent, out list))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list != null && list.Count > 0, "Invalid foreign key constraints");
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint fkConstraint in list)
				{
					if (this.TryEliminateParentChildJoin(joinEdge, fkConstraint))
					{
						return;
					}
				}
			}
			if (joinEdge.JoinKind == global::System.Data.Entity.Core.Query.PlanCompiler.JoinKind.LeftOuter && this.m_constraintManager.IsParentChildRelationship(joinEdge.Right.Table.TableMetadata.Extent, joinEdge.Left.Table.TableMetadata.Extent, out list))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list != null && list.Count > 0, "Invalid foreign key constraints");
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.ForeignKeyConstraint fkConstraint2 in list)
				{
					if (this.TryEliminateChildParentJoin(joinEdge, fkConstraint2))
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x0007AFC0 File Offset: 0x000791C0
		private void EliminateParentChildJoins(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode)
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.JoinEdge joinEdge in tableNode.JoinEdges)
			{
				this.EliminateParentChildJoin(joinEdge);
				if (tableNode.IsEliminated)
				{
					break;
				}
			}
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x0007B020 File Offset: 0x00079220
		private void EliminateParentChildJoins()
		{
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode in this.m_vertexes)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode = augmentedNode as global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode;
				if (augmentedTableNode != null && !augmentedTableNode.IsEliminated)
				{
					this.EliminateParentChildJoins(augmentedTableNode);
				}
			}
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x0007B084 File Offset: 0x00079284
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildNodeTree()
		{
			if (!this.m_modifiedGraph)
			{
				return this.m_root.Node;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in this.m_varMap)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = keyValuePair.Value;
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
				while (this.m_varMap.TryGetValue(var, out var2))
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(var2 != null, "null var mapping?");
					var = var2;
				}
				varMap[keyValuePair.Key] = var;
			}
			this.m_varMap = varMap;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> dictionary;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.RebuildNodeTree(this.m_root, out dictionary);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "Resulting node tree is null");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dictionary == null || dictionary.Count == 0, "Leaking predicates?");
			return node;
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x0007B160 File Offset: 0x00079360
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildFilterForNullableColumns(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Query.InternalTrees.VarVec nonNullableColumns)
		{
			if (nonNullableColumns == null)
			{
				return inputNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = nonNullableColumns.Remap(this.m_varMap);
			if (varVec.IsEmpty)
			{
				return inputNode;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in varVec)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.m_command.CreateNode(this.m_command.CreateVarRefOp(v));
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), arg);
				node2 = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Not), node2);
				if (node == null)
				{
					node = node2;
				}
				else
				{
					node = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node != null, "Null predicate?");
			return this.m_command.CreateNode(this.m_command.CreateFilterOp(), inputNode, node);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0007B260 File Offset: 0x00079460
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildFilterNode(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Query.InternalTrees.Node predicateNode)
		{
			if (predicateNode == null)
			{
				return inputNode;
			}
			return this.m_command.CreateNode(this.m_command.CreateFilterOp(), inputNode, predicateNode);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0007B280 File Offset: 0x00079480
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RebuildPredicate(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode joinNode, out int minLocationId)
		{
			minLocationId = joinNode.Id;
			if (joinNode.OtherPredicate != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in joinNode.OtherPredicate.GetNodeInfo(this.m_command).ExternalReferences)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
					if (!this.m_varMap.TryGetValue(var, out var2))
					{
						var2 = var;
					}
					minLocationId = this.GetLeastCommonAncestor(minLocationId, this.GetLocationId(var2, minLocationId));
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = joinNode.OtherPredicate;
			for (int i = 0; i < joinNode.LeftVars.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var3;
				if (!this.m_varMap.TryGetValue(joinNode.LeftVars[i], out var3))
				{
					var3 = joinNode.LeftVars[i];
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Var var4;
				if (!this.m_varMap.TryGetValue(joinNode.RightVars[i], out var4))
				{
					var4 = joinNode.RightVars[i];
				}
				if (!var3.Equals(var4))
				{
					minLocationId = this.GetLeastCommonAncestor(minLocationId, this.GetLocationId(var3, minLocationId));
					minLocationId = this.GetLeastCommonAncestor(minLocationId, this.GetLocationId(var4, minLocationId));
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.m_command.CreateNode(this.m_command.CreateVarRefOp(var3));
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg2 = this.m_command.CreateNode(this.m_command.CreateVarRefOp(var4));
					global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.m_command.CreateNode(this.m_command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false), arg, arg2);
					if (node != null)
					{
						node = global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.CombinePredicates(node2, node, this.m_command);
					}
					else
					{
						node = node2;
					}
				}
			}
			return node;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x0007B42C File Offset: 0x0007962C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RebuildNodeTreeForCrossJoins(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode joinNode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode in joinNode.Children)
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> dictionary;
				list.Add(this.RebuildNodeTree(augmentedNode, out dictionary));
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(dictionary == null || dictionary.Count == 0, "Leaking predicates");
			}
			if (list.Count == 0)
			{
				return null;
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.m_command.CreateNode(this.m_command.CreateCrossJoinOp(), list);
			this.m_processedNodes[node] = node;
			return node;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x0007B4EC File Offset: 0x000796EC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RebuildNodeTree(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode joinNode, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> predicates)
		{
			if (joinNode.Node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				predicates = null;
				return this.RebuildNodeTreeForCrossJoins(joinNode);
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> leftPredicates;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.RebuildNodeTree(joinNode.Children[0], out leftPredicates);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> rightPredicates;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.RebuildNodeTree(joinNode.Children[1], out rightPredicates);
			int id;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node3;
			if (node != null && node2 == null && joinNode.Node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.LeftOuterJoin)
			{
				id = joinNode.Id;
				node3 = null;
			}
			else
			{
				node3 = this.RebuildPredicate(joinNode, out id);
			}
			node3 = this.CombinePredicateNodes(joinNode.Id, node3, id, leftPredicates, rightPredicates, out predicates);
			if (node == null && node2 == null)
			{
				if (node3 == null)
				{
					return null;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode = this.m_command.CreateNode(this.m_command.CreateSingleRowTableOp());
				return this.BuildFilterNode(inputNode, node3);
			}
			else
			{
				if (node == null)
				{
					return this.BuildFilterNode(node2, node3);
				}
				if (node2 == null)
				{
					return this.BuildFilterNode(node, node3);
				}
				if (node3 == null)
				{
					node3 = this.m_command.CreateNode(this.m_command.CreateTrueOp());
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this.m_command.CreateNode(joinNode.Node.Op, node, node2, node3);
				this.m_processedNodes[node4] = node4;
				return node4;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0007B61C File Offset: 0x0007981C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RebuildNodeTree(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode tableNode)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode = tableNode;
			if (tableNode.IsMoved)
			{
				return null;
			}
			while (augmentedTableNode.IsEliminated)
			{
				augmentedTableNode = augmentedTableNode.ReplacementTable;
				if (augmentedTableNode == null)
				{
					return null;
				}
			}
			if (augmentedTableNode.NewLocationId < tableNode.Id)
			{
				return null;
			}
			return this.BuildFilterForNullableColumns(augmentedTableNode.Node, augmentedTableNode.NullableColumns);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0007B66C File Offset: 0x0007986C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RebuildNodeTree(global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> predicates)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpType opType = augmentedNode.Node.Op.OpType;
			if (opType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable)
			{
				predicates = null;
				return this.RebuildNodeTree((global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode)augmentedNode);
			}
			if (opType - global::System.Data.Entity.Core.Query.InternalTrees.OpType.InnerJoin > 3)
			{
				predicates = null;
				return augmentedNode.Node;
			}
			return this.RebuildNodeTree((global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode)augmentedNode, out predicates);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0007B6C0 File Offset: 0x000798C0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CombinePredicateNodes(int targetNodeId, global::System.Data.Entity.Core.Query.InternalTrees.Node localPredicateNode, int localPredicateMinLocationId, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> leftPredicates, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> rightPredicates, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> outPredicates)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = null;
			outPredicates = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int>();
			if (localPredicateNode != null)
			{
				result = this.ClassifyPredicate(targetNodeId, localPredicateNode, localPredicateMinLocationId, result, outPredicates);
			}
			if (leftPredicates != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> keyValuePair in leftPredicates)
				{
					result = this.ClassifyPredicate(targetNodeId, keyValuePair.Key, keyValuePair.Value, result, outPredicates);
				}
			}
			if (rightPredicates != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> keyValuePair2 in rightPredicates)
				{
					result = this.ClassifyPredicate(targetNodeId, keyValuePair2.Key, keyValuePair2.Value, result, outPredicates);
				}
			}
			return result;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0007B798 File Offset: 0x00079998
		private global::System.Data.Entity.Core.Query.InternalTrees.Node ClassifyPredicate(int targetNodeId, global::System.Data.Entity.Core.Query.InternalTrees.Node predicateNode, int predicateMinLocationId, global::System.Data.Entity.Core.Query.InternalTrees.Node result, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, int> outPredicates)
		{
			if (targetNodeId >= predicateMinLocationId)
			{
				result = this.CombinePredicates(result, predicateNode);
			}
			else
			{
				outPredicates.Add(predicateNode, predicateMinLocationId);
			}
			return result;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0007B7B6 File Offset: 0x000799B6
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CombinePredicates(global::System.Data.Entity.Core.Query.InternalTrees.Node node1, global::System.Data.Entity.Core.Query.InternalTrees.Node node2)
		{
			if (node1 == null)
			{
				return node2;
			}
			if (node2 == null)
			{
				return node1;
			}
			return global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.CombinePredicates(node1, node2, this.m_command);
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0007B7D0 File Offset: 0x000799D0
		private int GetLocationId(global::System.Data.Entity.Core.Query.InternalTrees.Var var, int defaultLocationId)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode augmentedTableNode;
			if (!this.m_varToDefiningNodeMap.TryGetValue(var, out augmentedTableNode))
			{
				return defaultLocationId;
			}
			if (augmentedTableNode.IsMoved)
			{
				return augmentedTableNode.NewLocationId;
			}
			return augmentedTableNode.Id;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0007B804 File Offset: 0x00079A04
		private int GetLeastCommonAncestor(int nodeId1, int nodeId2)
		{
			if (nodeId1 == nodeId2)
			{
				return nodeId1;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode = this.m_root;
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode2 = augmentedNode;
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode3 = augmentedNode;
			while (augmentedNode2 == augmentedNode3)
			{
				augmentedNode = augmentedNode2;
				if (augmentedNode.Id == nodeId1 || augmentedNode.Id == nodeId2)
				{
					return augmentedNode.Id;
				}
				augmentedNode2 = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.PickSubtree(nodeId1, augmentedNode);
				augmentedNode3 = global::System.Data.Entity.Core.Query.PlanCompiler.JoinGraph.PickSubtree(nodeId2, augmentedNode);
			}
			return augmentedNode.Id;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0007B85C File Offset: 0x00079A5C
		private static global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode PickSubtree(int nodeId, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode root)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode augmentedNode = root.Children[0];
			int num = 1;
			while (augmentedNode.Id < nodeId && num < root.Children.Count)
			{
				augmentedNode = root.Children[num];
				num++;
			}
			return augmentedNode;
		}

		// Token: 0x04000E0C RID: 3596
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;

		// Token: 0x04000E0D RID: 3597
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedJoinNode m_root;

		// Token: 0x04000E0E RID: 3598
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedNode> m_vertexes;

		// Token: 0x04000E0F RID: 3599
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Table, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode> m_tableVertexMap;

		// Token: 0x04000E10 RID: 3600
		private global::System.Data.Entity.Core.Query.InternalTrees.VarMap m_varMap;

		// Token: 0x04000E11 RID: 3601
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.VarVec> m_reverseVarMap;

		// Token: 0x04000E12 RID: 3602
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.AugmentedTableNode> m_varToDefiningNodeMap;

		// Token: 0x04000E13 RID: 3603
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.InternalTrees.Node> m_processedNodes;

		// Token: 0x04000E14 RID: 3604
		private bool m_modifiedGraph;

		// Token: 0x04000E15 RID: 3605
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.ConstraintManager m_constraintManager;

		// Token: 0x04000E16 RID: 3606
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarRefManager m_varRefManager;
	}
}
