using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000563 RID: 1379
	internal class BasicViewGenerator : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004357 RID: 17239 RVA: 0x000E6974 File Offset: 0x000E4B74
		internal BasicViewGenerator(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex projectedSlotMap, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> usedCells, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery activeDomain, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			this.m_projectedSlotMap = projectedSlotMap;
			this.m_usedCells = usedCells;
			this.m_viewgenContext = context;
			this.m_activeDomain = activeDomain;
			this.m_errorLog = errorLog;
			this.m_config = config;
			this.m_domainMap = domainMap;
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x000E69B1 File Offset: 0x000E4BB1
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryProcessor LeftQP
		{
			get
			{
				return this.m_viewgenContext.LeftFragmentQP;
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x000E69C0 File Offset: 0x000E4BC0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode CreateViewExpression()
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper cellWrapper in this.m_usedCells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode child = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode(this.m_viewgenContext, cellWrapper);
				opCellTreeNode.Add(child);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = this.GroupByRightExtent(opCellTreeNode);
			cellTreeNode = this.IsolateUnions(cellTreeNode);
			cellTreeNode = this.IsolateByOperator(cellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union);
			cellTreeNode = this.IsolateByOperator(cellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ);
			cellTreeNode = this.IsolateByOperator(cellTreeNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ);
			if (this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				cellTreeNode = this.ConvertUnionsToNormalizedLOJs(cellTreeNode);
			}
			return cellTreeNode;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000E6A70 File Offset: 0x000E4C70
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode GroupByRightExtent(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in rootNode.Children)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode)cellTreeNode;
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent = leafCellTreeNode.LeftCellWrapper.RightCellQuery.Extent;
				keyToListMap.Add(extent, leafCellTreeNode);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase key in keyToListMap.Keys)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode child in keyToListMap.ListForKey(key))
				{
					opCellTreeNode2.Add(child);
				}
				opCellTreeNode.Add(opCellTreeNode2);
			}
			return opCellTreeNode.Flatten();
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x000E6B94 File Offset: 0x000E4D94
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode IsolateUnions(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			if (rootNode.Children.Count <= 1)
			{
				return rootNode;
			}
			for (int i = 0; i < rootNode.Children.Count; i++)
			{
				rootNode.Children[i] = this.IsolateUnions(rootNode.Children[i]);
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union);
			global::System.Data.Entity.Core.Common.Utils.ModifiableIteratorCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> modifiableIteratorCollection = new global::System.Data.Entity.Core.Common.Utils.ModifiableIteratorCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(rootNode.Children);
			while (!modifiableIteratorCollection.IsEmpty)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child = modifiableIteratorCollection.RemoveOneElement();
				opCellTreeNode2.Add(child);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in modifiableIteratorCollection.Elements())
				{
					if (!this.IsDisjoint(opCellTreeNode2, cellTreeNode))
					{
						opCellTreeNode2.Add(cellTreeNode);
						modifiableIteratorCollection.RemoveCurrentOfIterator();
						modifiableIteratorCollection.ResetIterator();
					}
				}
				opCellTreeNode.Add(opCellTreeNode2);
			}
			return opCellTreeNode.Flatten();
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x000E6C90 File Offset: 0x000E4E90
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode ConvertUnionsToNormalizedLOJs(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode)
		{
			for (int i = 0; i < rootNode.Children.Count; i++)
			{
				rootNode.Children[i] = this.ConvertUnionsToNormalizedLOJs(rootNode.Children[i]);
			}
			if (rootNode.OpType != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ || rootNode.Children.Count < 2)
			{
				return rootNode;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, rootNode.OpType);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode2 = null;
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> hashSet = null;
			if (rootNode.Children[0].OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ)
			{
				opCellTreeNode2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, rootNode.Children[0].OpType);
				opCellTreeNode.Add(opCellTreeNode2);
				list.AddRange(rootNode.Children[0].Children);
				hashSet = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(rootNode.Children[0].Children);
			}
			else
			{
				opCellTreeNode.Add(rootNode.Children[0]);
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode in rootNode.Children.Skip(1))
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode3 = cellTreeNode as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode;
				if (opCellTreeNode3 != null && opCellTreeNode3.OpType == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union)
				{
					list.AddRange(opCellTreeNode3.Children);
				}
				else
				{
					list.Add(cellTreeNode);
				}
			}
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode2 in list)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode = cellTreeNode2 as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode;
				if (leafCellTreeNode != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase leafNodeTable = global::System.Data.Entity.Core.Mapping.ViewGeneration.BasicViewGenerator.GetLeafNodeTable(leafCellTreeNode);
					if (leafNodeTable != null)
					{
						keyToListMap.Add((global::System.Data.Entity.Core.Metadata.Edm.EntitySet)leafNodeTable, leafCellTreeNode);
					}
				}
				else if (hashSet != null && hashSet.Contains(cellTreeNode2))
				{
					opCellTreeNode2.Add(cellTreeNode2);
				}
				else
				{
					opCellTreeNode.Add(cellTreeNode2);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>> keyValuePair in (from m in keyToListMap.KeyValuePairs
			where m.Value.Count > 1
			select m).ToArray<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>>>())
			{
				keyToListMap.RemoveKey(keyValuePair.Key);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leafCellTreeNode2 in keyValuePair.Value)
				{
					if (hashSet != null && hashSet.Contains(leafCellTreeNode2))
					{
						opCellTreeNode2.Add(leafCellTreeNode2);
					}
					else
					{
						opCellTreeNode.Add(leafCellTreeNode2);
					}
				}
			}
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> keyToListMap2 = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>> keyValuePair2 in keyToListMap.KeyValuePairs)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet key = keyValuePair2.Key;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in global::System.Data.Entity.Core.Mapping.ViewGeneration.BasicViewGenerator.GetFKOverPKDependents(key))
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode> source;
					if (keyToListMap.TryGetListForKey(entitySet, out source) && (hashSet == null || !hashSet.Contains(source.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>())))
					{
						keyToListMap2.Add(key, entitySet);
					}
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode4 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ);
				opCellTreeNode4.Add(keyValuePair2.Value.Single<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode>());
				dictionary.Add(key, opCellTreeNode4);
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default);
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> keyValuePair3 in keyToListMap2.KeyValuePairs)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet key2 = keyValuePair3.Key;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 in keyValuePair3.Value)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode child;
					if (dictionary.TryGetValue(entitySet2, out child) && !dictionary2.ContainsKey(entitySet2) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.BasicViewGenerator.CheckLOJCycle(entitySet2, key2, dictionary2))
					{
						dictionary[keyValuePair3.Key].Add(child);
						dictionary2.Add(entitySet2, key2);
					}
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode> keyValuePair4 in dictionary)
			{
				if (!dictionary2.ContainsKey(keyValuePair4.Key))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode value = keyValuePair4.Value;
					if (hashSet != null && hashSet.Contains(value.Children[0]))
					{
						opCellTreeNode2.Add(value);
					}
					else
					{
						opCellTreeNode.Add(value);
					}
				}
			}
			return opCellTreeNode.Flatten();
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x000E7198 File Offset: 0x000E5398
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetFKOverPKDependents(global::System.Data.Entity.Core.Metadata.Edm.EntitySet principal)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> enumerator = principal.ForeignKeyPrincipals.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> pkFkInfo = enumerator.Current;
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = pkFkInfo.Item2.ToRole.GetEntityType().KeyMembers;
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties = pkFkInfo.Item2.ToProperties;
					if (keyMembers.Count == toProperties.Count)
					{
						int num = 0;
						while (num < keyMembers.Count && keyMembers[num].EdmEquals(toProperties[num]))
						{
							num++;
						}
						if (num == keyMembers.Count)
						{
							yield return (from ase in pkFkInfo.Item1.AssociationSetEnds
							where ase.Name == pkFkInfo.Item2.ToRole.Name
							select ase).Single<global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd>().EntitySet;
						}
					}
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x000E71A8 File Offset: 0x000E53A8
		private static global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetLeafNodeTable(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeafCellTreeNode leaf)
		{
			return leaf.LeftCellWrapper.RightCellQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x000E71BF File Offset: 0x000E53BF
		private static bool CheckLOJCycle(global::System.Data.Entity.Core.Metadata.Edm.EntitySet child, global::System.Data.Entity.Core.Metadata.Edm.EntitySet parent, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> nestedExtents)
		{
			while (!global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>.Default.Equals(parent, child))
			{
				if (!nestedExtents.TryGetValue(parent, out parent))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x000E71E0 File Offset: 0x000E53E0
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode IsolateByOperator(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode rootNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opTypeToIsolate)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> children = rootNode.Children;
			if (children.Count <= 1)
			{
				return rootNode;
			}
			for (int i = 0; i < children.Count; i++)
			{
				children[i] = this.IsolateByOperator(children[i], opTypeToIsolate);
			}
			if ((rootNode.OpType != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.FOJ && rootNode.OpType != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ) || rootNode.OpType == opTypeToIsolate)
			{
				return rootNode;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, rootNode.OpType);
			global::System.Data.Entity.Core.Common.Utils.ModifiableIteratorCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode> modifiableIteratorCollection = new global::System.Data.Entity.Core.Common.Utils.ModifiableIteratorCollection<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode>(children);
			while (!modifiableIteratorCollection.IsEmpty)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode opCellTreeNode2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, opTypeToIsolate);
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode child = modifiableIteratorCollection.RemoveOneElement();
				opCellTreeNode2.Add(child);
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode childNode in modifiableIteratorCollection.Elements())
				{
					if (this.TryAddChildToGroup(opTypeToIsolate, childNode, opCellTreeNode2))
					{
						modifiableIteratorCollection.RemoveCurrentOfIterator();
						if (opTypeToIsolate == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ)
						{
							modifiableIteratorCollection.ResetIterator();
						}
					}
				}
				opCellTreeNode.Add(opCellTreeNode2);
			}
			return opCellTreeNode.Flatten();
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x000E72F0 File Offset: 0x000E54F0
		private bool TryAddChildToGroup(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType opTypeToIsolate, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode childNode, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode groupNode)
		{
			switch (opTypeToIsolate)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.Union:
				if (this.IsDisjoint(childNode, groupNode))
				{
					groupNode.Add(childNode);
					return true;
				}
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LOJ:
				if (this.IsContainedIn(childNode, groupNode))
				{
					groupNode.Add(childNode);
					return true;
				}
				if (this.IsContainedIn(groupNode, childNode))
				{
					groupNode.AddFirst(childNode);
					return true;
				}
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ:
				if (this.IsEquivalentTo(childNode, groupNode))
				{
					groupNode.Add(childNode);
					return true;
				}
				break;
			}
			return false;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x000E7364 File Offset: 0x000E5564
		private bool IsDisjoint(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n2)
		{
			bool flag = this.LeftQP.IsDisjointFrom(n1.LeftFragmentQuery, n2.LeftFragmentQuery);
			if (flag && this.m_viewgenContext.ViewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				return true;
			}
			bool isEmptyRightFragmentQuery = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.IJ, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
			{
				n1,
				n2
			}).IsEmptyRightFragmentQuery;
			if (this.m_viewgenContext.ViewTarget != global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView || !flag || isEmptyRightFragmentQuery)
			{
				return flag || isEmptyRightFragmentQuery;
			}
			if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ErrorPatternMatcher.FindMappingErrors(this.m_viewgenContext, this.m_domainMap, this.m_errorLog))
			{
				return false;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(global::System.Data.Entity.Resources.Strings.Viewgen_RightSideNotDisjoint(this.m_viewgenContext.Extent.ToString()));
			stringBuilder.AppendLine();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery fragmentQuery = this.LeftQP.Intersect(n1.RightFragmentQuery, n2.RightFragmentQuery);
			if (this.LeftQP.IsSatisfiable(fragmentQuery))
			{
				fragmentQuery.Condition.ExpensiveSimplify();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator.EntityConfigurationToUserString(fragmentQuery.Condition, stringBuilder);
			}
			this.m_errorLog.AddEntry(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ViewGenErrorCode.DisjointConstraintViolation, stringBuilder.ToString(), this.m_viewgenContext.AllWrappersForExtent, string.Empty));
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Utils.ExceptionHelpers.ThrowMappingException(this.m_errorLog, this.m_config);
			return false;
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x000E7494 File Offset: 0x000E5694
		private bool IsContainedIn(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n2)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q = this.LeftQP.Intersect(n1.LeftFragmentQuery, this.m_activeDomain);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery q2 = this.LeftQP.Intersect(n2.LeftFragmentQuery, this.m_activeDomain);
			return this.LeftQP.IsContainedIn(q, q2) || new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.OpCellTreeNode(this.m_viewgenContext, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeOpType.LASJ, new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode[]
			{
				n1,
				n2
			}).IsEmptyRightFragmentQuery;
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x000E7501 File Offset: 0x000E5701
		private bool IsEquivalentTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n1, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode n2)
		{
			return this.IsContainedIn(n1, n2) && this.IsContainedIn(n2, n1);
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x000E7517 File Offset: 0x000E5717
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			this.m_projectedSlotMap.ToCompactString(builder);
		}

		// Token: 0x04001807 RID: 6151
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberProjectionIndex m_projectedSlotMap;

		// Token: 0x04001808 RID: 6152
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> m_usedCells;

		// Token: 0x04001809 RID: 6153
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQuery m_activeDomain;

		// Token: 0x0400180A RID: 6154
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext m_viewgenContext;

		// Token: 0x0400180B RID: 6155
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog m_errorLog;

		// Token: 0x0400180C RID: 6156
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator m_config;

		// Token: 0x0400180D RID: 6157
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_domainMap;
	}
}
