using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000566 RID: 1382
	internal class CellTreeSimplifier : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004374 RID: 17268 RVA: 0x000E837A File Offset: 0x000E657A
		private CellTreeSimplifier(global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context)
		{
			this.m_viewgenContext = context;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x000E8389 File Offset: 0x000E6589
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode MergeNodes(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier(rootNode.ViewgenContext).SimplifyTreeByMergingNodes(rootNode);
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x000E839C File Offset: 0x000E659C
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode SimplifyTreeByMergingNodes(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			if (rootNode is global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode)
			{
				return rootNode;
			}
			rootNode = this.RestructureTreeForMerges(rootNode);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = rootNode.Children;
			for (int i = 0; i < list.Count; i++)
			{
				list[i] = this.SimplifyTreeByMergingNodes(list[i]);
			}
			bool flag = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.IsAssociativeOp(rootNode.OpType);
			if (flag)
			{
				list = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.GroupLeafChildrenByExtent(list);
			}
			else
			{
				list = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.GroupNonAssociativeLeafChildren(list);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, rootNode.OpType);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = null;
			bool flag2 = false;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 in list)
			{
				if (cellTreeNode == null)
				{
					cellTreeNode = cellTreeNode2;
				}
				else
				{
					bool flag3 = false;
					if (!flag2 && cellTreeNode.OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Leaf && cellTreeNode2.OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Leaf)
					{
						flag3 = this.TryMergeCellQueries(rootNode.OpType, ref cellTreeNode, cellTreeNode2);
					}
					if (!flag3)
					{
						opCellTreeNode.Add(cellTreeNode);
						cellTreeNode = cellTreeNode2;
						if (!flag)
						{
							flag2 = true;
						}
					}
				}
			}
			opCellTreeNode.Add(cellTreeNode);
			return opCellTreeNode.AssociativeFlatten();
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000E84B4 File Offset: 0x000E66B4
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode RestructureTreeForMerges(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> children = rootNode.Children;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.IsAssociativeOp(rootNode.OpType) || children.Count <= 1)
			{
				return rootNode;
			}
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> commonGrandChildren = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.GetCommonGrandChildren(children);
			if (commonGrandChildren == null)
			{
				return rootNode;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType = children[0].OpType;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode>(children.Count);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in children)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode)cellTreeNode;
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>(opCellTreeNode.Children.Count);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 in opCellTreeNode.Children)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode)cellTreeNode2;
					if (!commonGrandChildren.Contains(leafCellTreeNode))
					{
						list2.Add(leafCellTreeNode);
					}
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode item = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, opCellTreeNode.OpType, global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(list2));
				list.Add(item);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode3 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, rootNode.OpType, global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(list));
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode4 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, opType, global::System.Data.Entity.Core.Common.Utils.Helpers.AsSuperTypeList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(commonGrandChildren));
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, opType, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
			{
				cellTreeNode4,
				cellTreeNode3
			}).AssociativeFlatten();
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000E8628 File Offset: 0x000E6828
		private static global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> GetCommonGrandChildren(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> nodes)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> set = null;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType cellTreeOpType = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Leaf;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in nodes)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = cellTreeNode as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode;
				if (opCellTreeNode == null)
				{
					return null;
				}
				if (cellTreeOpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Leaf)
				{
					cellTreeOpType = opCellTreeNode.OpType;
				}
				else if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode.IsAssociativeOp(opCellTreeNode.OpType) || cellTreeOpType != opCellTreeNode.OpType)
				{
					return null;
				}
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode.EqualityComparer);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 in opCellTreeNode.Children)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = cellTreeNode2 as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
					if (leafCellTreeNode == null)
					{
						return null;
					}
					set2.Add(leafCellTreeNode);
				}
				if (set == null)
				{
					set = set2;
				}
				else
				{
					set.Intersect(set2);
				}
			}
			if (set.Count == 0)
			{
				return null;
			}
			return set;
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000E8734 File Offset: 0x000E6934
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> GroupLeafChildrenByExtent(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> nodes)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in nodes)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = cellTreeNode as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
				if (leafCellTreeNode != null)
				{
					keyToListMap.Add(leafCellTreeNode.LeftCellWrapper.RightCellQuery.Extent, leafCellTreeNode);
				}
				else
				{
					list.Add(cellTreeNode);
				}
			}
			list.AddRange(keyToListMap.AllValues);
			return list;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x000E87C8 File Offset: 0x000E69C8
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> GroupNonAssociativeLeafChildren(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> nodes)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			list.Add(nodes[0]);
			for (int i = 1; i < nodes.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = nodes[i];
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = cellTreeNode as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
				if (leafCellTreeNode != null)
				{
					keyToListMap.Add(leafCellTreeNode.LeftCellWrapper.RightCellQuery.Extent, leafCellTreeNode);
				}
				else
				{
					list2.Add(cellTreeNode);
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode2 = nodes[0] as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
			if (leafCellTreeNode2 != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = leafCellTreeNode2.LeftCellWrapper.RightCellQuery.Extent;
				if (keyToListMap.ContainsKey(extent))
				{
					list.AddRange(keyToListMap.ListForKey(extent));
					keyToListMap.RemoveKey(extent);
				}
			}
			list.AddRange(keyToListMap.AllValues);
			list.AddRange(list2);
			return list;
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000E88A0 File Offset: 0x000E6AA0
		private bool TryMergeCellQueries(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, ref global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode node2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = node1 as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode2 = node2 as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery rightCellQuery;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.TryMergeTwoCellQueries(leafCellTreeNode.LeftCellWrapper.RightCellQuery, leafCellTreeNode2.LeftCellWrapper.RightCellQuery, opType, out rightCellQuery))
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftCellQuery;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.TryMergeTwoCellQueries(leafCellTreeNode.LeftCellWrapper.LeftCellQuery, leafCellTreeNode2.LeftCellWrapper.LeftCellQuery, opType, out leftCellQuery))
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, opType);
			opCellTreeNode.Add(node1);
			opCellTreeNode.Add(node2);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper cellWrapper = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper(this.m_viewgenContext.ViewTarget, opCellTreeNode.Attributes, opCellTreeNode.LeftFragmentQuery, leftCellQuery, rightCellQuery, this.m_viewgenContext.MemberMaps, leafCellTreeNode.LeftCellWrapper.Cells.Concat(leafCellTreeNode2.LeftCellWrapper.Cells));
			node1 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode(this.m_viewgenContext, cellWrapper, opCellTreeNode.RightFragmentQuery);
			return true;
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000E8980 File Offset: 0x000E6B80
		internal static bool TryMergeTwoCellQueries(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery query1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery query2, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType, out global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery mergedQuery)
		{
			mergedQuery = null;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = null;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression2 = null;
			switch (opType)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union:
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ:
				boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
				boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ:
				boolExpression2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
				break;
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> remap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer);
			if (!query1.Extent.Equals(query2.Extent))
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath sourceExtentMemberPath = query1.SourceExtentMemberPath;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conjunct = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.True;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression4 = null;
			switch (opType)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union:
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ:
				conjunct = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query1.WhereClause,
					boolExpression
				});
				boolExpression3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query2.WhereClause,
					boolExpression2
				});
				boolExpression4 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						query1.WhereClause,
						boolExpression
					}),
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						query2.WhereClause,
						boolExpression2
					})
				});
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
				boolExpression3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query2.WhereClause,
					boolExpression2
				});
				boolExpression4 = query1.WhereClause;
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
				boolExpression4 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query1.WhereClause,
					query2.WhereClause
				});
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ:
				boolExpression3 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query2.WhereClause,
					boolExpression2
				});
				boolExpression4 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
				{
					query1.WhereClause,
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(boolExpression3)
				});
				break;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> boolExprs = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.MergeBoolExpressions(query1, query2, conjunct, boolExpression3, opType);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot[] projectedSlots;
			if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ProjectedSlot.TryMergeRemapSlots(query1.ProjectedSlots, query2.ProjectedSlots, out projectedSlots))
			{
				return false;
			}
			boolExpression4 = boolExpression4.RemapBool(remap);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct elimDupl = global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.MergeDupl(query1.SelectDistinctFlag, query2.SelectDistinctFlag);
			boolExpression4.ExpensiveSimplify();
			mergedQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery(projectedSlots, boolExpression4, boolExprs, elimDupl, sourceExtentMemberPath);
			return true;
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x000E8B77 File Offset: 0x000E6D77
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct MergeDupl(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct d1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct d2)
		{
			if (d1 == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes || d2 == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes)
			{
				return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.Yes;
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery.SelectDistinct.No;
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000E8B84 File Offset: 0x000E6D84
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> MergeBoolExpressions(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery query1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery query2, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conjunct1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression conjunct2, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list = query1.BoolVars;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list2 = query2.BoolVars;
			if (!conjunct1.IsTrue)
			{
				list = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AddConjunctionToBools(list, conjunct1);
			}
			if (!conjunct2.IsTrue)
			{
				list2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.AddConjunctionToBools(list2, conjunct2);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression boolExpression = null;
				if (list[i] == null)
				{
					boolExpression = list2[i];
				}
				else if (list2[i] == null)
				{
					boolExpression = list[i];
				}
				else if (opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ)
				{
					boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						list[i],
						list2[i]
					});
				}
				else if (opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union)
				{
					boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateOr(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						list[i],
						list2[i]
					});
				}
				else if (opType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ)
				{
					boolExpression = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateAnd(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression[]
					{
						list[i],
						global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolExpression.CreateNot(list2[i])
					});
				}
				if (boolExpression != null)
				{
					boolExpression.ExpensiveSimplify();
				}
				list3.Add(boolExpression);
			}
			return list3;
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x000E8C99 File Offset: 0x000E6E99
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_viewgenContext.MemberMaps.ProjectedSlotMap.ToCompactString(builder);
		}

		// Token: 0x04001813 RID: 6163
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext m_viewgenContext;
	}
}
