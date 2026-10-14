using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.Update.Internal;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x02000565 RID: 1381
	internal class CellPartitioner : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x06004371 RID: 17265 RVA: 0x000E8095 File Offset: 0x000E6295
		internal CellPartitioner(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> foreignKeyConstraints)
		{
			this.m_foreignKeyConstraints = foreignKeyConstraints;
			this.m_cells = cells;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x000E80AC File Offset: 0x000E62AC
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> GroupRelatedCells()
		{
			global::System.Data.Entity.Core.Mapping.Update.Internal.UndirectedGraph<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> undirectedGraph = new global::System.Data.Entity.Core.Mapping.Update.Internal.UndirectedGraph<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> extentToCell = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in this.m_cells)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in new global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase[]
				{
					cell.CQuery.Extent,
					cell.SQuery.Extent
				})
				{
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> set;
					if (!extentToCell.TryGetValue(entitySetBase, out set))
					{
						set = (extentToCell[entitySetBase] = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>());
					}
					set.Add(cell);
					undirectedGraph.AddVertex(entitySetBase);
				}
				undirectedGraph.AddEdge(cell.CQuery.Extent, cell.SQuery.Extent);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = cell.CQuery.Extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
				if (associationSet != null)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd in associationSet.AssociationSetEnds)
					{
						undirectedGraph.AddEdge(associationSetEnd.EntitySet, associationSet);
					}
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint foreignConstraint in this.m_foreignKeyConstraints)
			{
				undirectedGraph.AddEdge(foreignConstraint.ChildTable, foreignConstraint.ParentTable);
			}
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<int, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> keyToListMap = undirectedGraph.GenerateConnectedComponents();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>>();
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> <>9__0;
			foreach (int key in keyToListMap.Keys)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> source = keyToListMap.ListForKey(key);
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> selector;
				if ((selector = <>9__0) == null)
				{
					selector = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase e) => extentToCell[e]));
				}
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> enumerable = source.Select(selector);
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
				foreach (global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> elements in enumerable)
				{
					set2.AddRange(elements);
				}
				list.Add(set2);
			}
			return list;
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x000E836C File Offset: 0x000E656C
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CellsToBuilder(builder, this.m_cells);
		}

		// Token: 0x04001811 RID: 6161
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> m_cells;

		// Token: 0x04001812 RID: 6162
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> m_foreignKeyConstraints;
	}
}
