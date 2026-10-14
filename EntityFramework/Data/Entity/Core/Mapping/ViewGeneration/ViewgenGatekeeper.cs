using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056F RID: 1391
	internal abstract class ViewgenGatekeeper : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060043DB RID: 17371 RVA: 0x000EB7A8 File Offset: 0x000E99A8
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults GenerateViewsFromMapping(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator cellCreator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellCreator(containerMapping);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells = cellCreator.GenerateCells();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers = cellCreator.Identifiers;
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.GenerateViewsFromCells(cells, config, identifiers, containerMapping);
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x000EB7D4 File Offset: 0x000E99D4
		internal static global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults GenerateTypeSpecificQueryView(global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, bool includeSubtypes, out bool success)
		{
			if (config.IsNormalTracing)
			{
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine("");
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Concat(new string[]
				{
					"<<<<<<<< Generating Query View for Entity [",
					entity.Name,
					"] OfType",
					includeSubtypes ? "" : "Only",
					"(",
					type.Name,
					") >>>>>>>"
				}));
			}
			if (containerMapping.GetEntitySetMapping(entity.Name).QueryView != null)
			{
				success = false;
				return null;
			}
			global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups args = new global::System.Data.Entity.Core.Mapping.InputForComputingCellGroups(containerMapping, config);
			global::System.Data.Entity.Core.Mapping.OutputFromComputeCellGroups cellgroups = containerMapping.GetCellgroups(args);
			success = cellgroups.Success;
			if (!success)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> foreignKeyConstraints = cellgroups.ForeignKeyConstraints;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> list = (from setOfCells in cellgroups.CellGroups
			select new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(from cell in setOfCells
			select new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell(cell))).ToList<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells = cellgroups.Cells;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers = cellgroups.Identifiers;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults viewGenResults = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.EnsureAllCSpaceContainerSetsAreMapped(cells, containerMapping);
			if (errorLog.Count > 0)
			{
				viewGenResults.AddErrors(errorLog);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(viewGenResults.ErrorsToString());
				success = true;
				return viewGenResults;
			}
			foreach (global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> set in list)
			{
				if (global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.DoesCellGroupContainEntitySet(set, entity))
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator viewGenerator = null;
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
					try
					{
						viewGenerator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator(set, config, foreignKeyConstraints, containerMapping);
					}
					catch (global::System.Data.Entity.Core.InternalMappingException ex)
					{
						errorLog2 = ex.ErrorLog;
					}
					if (errorLog2.Count > 0)
					{
						break;
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode mode = includeSubtypes ? global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeViews : global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeOnlyViews;
					errorLog2 = viewGenerator.GenerateQueryViewForSingleExtent(viewGenResults.Views, identifiers, entity, type, mode);
					if (errorLog2.Count != 0)
					{
						viewGenResults.AddErrors(errorLog2);
					}
				}
			}
			success = true;
			return viewGenResults;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x000EB9B4 File Offset: 0x000E9BB4
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults GenerateViewsFromCells(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer storageEntityContainer = containerMapping.StorageEntityContainer;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults viewGenResults = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenResults();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenGatekeeper.EnsureAllCSpaceContainerSetsAreMapped(cells, containerMapping);
			if (errorLog.Count > 0)
			{
				viewGenResults.AddErrors(errorLog);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(viewGenResults.ErrorsToString());
				return viewGenResults;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> foreignConstraints = global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint.GetForeignConstraints(storageEntityContainer);
			foreach (global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cellGroup in new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellPartitioner(cells, foreignConstraints).GroupRelatedCells())
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator viewGenerator = null;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
				try
				{
					viewGenerator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator(cellGroup, config, foreignConstraints, containerMapping);
				}
				catch (global::System.Data.Entity.Core.InternalMappingException ex)
				{
					errorLog2 = ex.ErrorLog;
				}
				if (errorLog2.Count == 0)
				{
					errorLog2 = viewGenerator.GenerateAllBidirectionalViews(viewGenResults.Views, identifiers);
				}
				if (errorLog2.Count != 0)
				{
					viewGenResults.AddErrors(errorLog2);
				}
			}
			return viewGenResults;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x000EBA9C File Offset: 0x000E9C9C
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog EnsureAllCSpaceContainerSetsAreMapped(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.EntityContainerMapping containerMapping)
		{
			global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = null;
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				set.Add(cell.CQuery.Extent);
				entityContainer = cell.CQuery.Extent.EntityContainer;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
			{
				if (!set.Contains(entitySetBase) && !containerMapping.HasQueryViewForSetMap(entitySetBase.Name))
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
					if (associationSet == null || !associationSet.ElementType.IsForeignKey)
					{
						list.Add(entitySetBase);
					}
				}
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
			if (list.Count > 0)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				bool flag = true;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase2 in list)
				{
					if (!flag)
					{
						stringBuilder.Append(", ");
					}
					flag = false;
					stringBuilder.Append(entitySetBase2.Name);
				}
				string message = global::System.Data.Entity.Resources.Strings.ViewGen_Missing_Set_Mapping(stringBuilder);
				int num = -1;
				foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell2 in cells)
				{
					if (num == -1 || cell2.CellLabel.StartLineNumber < num)
					{
						num = cell2.CellLabel.StartLineNumber;
					}
				}
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record record = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record(new global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError(message, 3027, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, containerMapping.SourceLocation, containerMapping.StartLineNumber, containerMapping.StartLinePosition, null));
				errorLog.AddEntry(record);
			}
			return errorLog;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x000EBC9C File Offset: 0x000E9E9C
		private static bool DoesCellGroupContainEntitySet(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> group, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity)
		{
			using (global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>.Enumerator enumerator = group.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetLeftQuery(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView).Extent.Equals(entity))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x000EBCFC File Offset: 0x000E9EFC
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
		}
	}
}
