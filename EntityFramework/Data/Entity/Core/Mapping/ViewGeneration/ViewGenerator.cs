using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration
{
	// Token: 0x0200056E RID: 1390
	internal class ViewGenerator : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x060043CD RID: 17357 RVA: 0x000EADB4 File Offset: 0x000E8FB4
		internal ViewGenerator(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cellGroup, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> foreignKeyConstraints, global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this.m_cellGroup = cellGroup;
			this.m_config = config;
			this.m_queryRewriterCache = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter>();
			this.m_foreignKeyConstraints = foreignKeyConstraints;
			this.m_entityContainerMapping = entityContainerMapping;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> inheritanceGraph = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.BuildUndirectedGraphOfTypes(entityContainerMapping.StorageMappingItemCollection.EdmItemCollection);
			this.SetConfiguration(entityContainerMapping);
			this.m_queryDomainMap = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView, this.m_config.IsValidationEnabled, cellGroup, entityContainerMapping.StorageMappingItemCollection.EdmItemCollection, this.m_config, inheritanceGraph);
			this.m_updateDomainMap = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView, this.m_config.IsValidationEnabled, cellGroup, entityContainerMapping.StorageMappingItemCollection.EdmItemCollection, this.m_config, inheritanceGraph);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap.PropagateUpdateDomainToQueryDomain(cellGroup, this.m_queryDomainMap, this.m_updateDomainMap);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator.UpdateWhereClauseForEachCell(cellGroup, this.m_queryDomainMap, this.m_updateDomainMap, this.m_config);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap openDomain = this.m_queryDomainMap.GetOpenDomain();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap openDomain2 = this.m_updateDomainMap.GetOpenDomain();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cellGroup)
			{
				cell.CQuery.WhereClause.FixDomainMap(openDomain);
				cell.SQuery.WhereClause.FixDomainMap(openDomain2);
				cell.CQuery.WhereClause.ExpensiveSimplify();
				cell.SQuery.WhereClause.ExpensiveSimplify();
				cell.CQuery.WhereClause.FixDomainMap(this.m_queryDomainMap);
				cell.SQuery.WhereClause.FixDomainMap(this.m_updateDomainMap);
			}
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000EAF48 File Offset: 0x000E9148
		private void SetConfiguration(global::System.Data.Entity.Core.Mapping.EntityContainerMapping entityContainerMapping)
		{
			this.m_config.IsValidationEnabled = entityContainerMapping.Validate;
			this.m_config.GenerateUpdateViews = entityContainerMapping.GenerateUpdateViews;
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000EAF6C File Offset: 0x000E916C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog GenerateAllBidirectionalViews(global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			if (this.m_config.IsNormalTracing)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CellsToBuilder(stringBuilder, this.m_cellGroup);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(stringBuilder.ToString());
			}
			this.m_config.SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.CellCreation);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator(this.m_cellGroup, this.m_config).Validate();
			if (errorLog.Count > 0)
			{
				errorLog.PrintTrace();
				return errorLog;
			}
			this.m_config.SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.KeyConstraint);
			if (this.m_config.GenerateUpdateViews)
			{
				errorLog = this.GenerateDirectionalViews(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView, identifiers, views);
				if (errorLog.Count > 0)
				{
					return errorLog;
				}
			}
			if (this.m_config.IsValidationEnabled)
			{
				this.CheckForeignKeyConstraints(errorLog);
			}
			this.m_config.SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.ForeignConstraint);
			if (errorLog.Count > 0)
			{
				errorLog.PrintTrace();
				return errorLog;
			}
			this.m_updateDomainMap.ExpandDomainsToIncludeAllPossibleValues();
			return this.GenerateDirectionalViews(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView, identifiers, views);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x000EB04C File Offset: 0x000E924C
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog GenerateQueryViewForSingleExtent(global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode mode)
		{
			if (this.m_config.IsNormalTracing)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CellsToBuilder(stringBuilder, this.m_cellGroup);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(stringBuilder.ToString());
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CellGroupValidator(this.m_cellGroup, this.m_config).Validate();
			if (errorLog.Count > 0)
			{
				errorLog.PrintTrace();
				return errorLog;
			}
			if (this.m_config.IsValidationEnabled)
			{
				this.CheckForeignKeyConstraints(errorLog);
			}
			if (errorLog.Count > 0)
			{
				errorLog.PrintTrace();
				return errorLog;
			}
			this.m_updateDomainMap.ExpandDomainsToIncludeAllPossibleValues();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in this.m_cellGroup)
			{
				cell.SQuery.WhereClause.FixDomainMap(this.m_updateDomainMap);
			}
			return this.GenerateQueryViewForExtentAndType(identifiers, views, entity, type, mode);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x000EB13C File Offset: 0x000E933C
		private static void UpdateWhereClauseForEachCell(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> extentCells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap queryDomainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap updateDomainMap, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in extentCells)
			{
				cell.CQuery.UpdateWhereClause(queryDomainMap);
				cell.SQuery.UpdateWhereClause(updateDomainMap);
			}
			queryDomainMap.ReduceEnumerableDomainToEnumeratedValues(config);
			updateDomainMap.ReduceEnumerableDomainToEnumeratedValues(config);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x000EB1A4 File Offset: 0x000E93A4
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog GenerateQueryViewForExtentAndType(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entity, global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase type, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode mode)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
			if (this.m_config.IsViewTracing)
			{
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
				global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("================= Generating {0} Query View for: {1} ===========================", new object[]
				{
					(mode == global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeViews) ? "OfType" : "OfTypeOnly",
					entity.Name
				});
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
			}
			try
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context = this.CreateViewgenContext(entity, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView, identifiers);
				this.GenerateViewsForExtentAndType(type, context, identifiers, views, mode);
			}
			catch (global::System.Data.Entity.Core.InternalMappingException ex)
			{
				errorLog.Merge(ex.ErrorLog);
			}
			return errorLog;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000EB254 File Offset: 0x000E9454
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog GenerateDirectionalViews(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views)
		{
			bool flag = viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView;
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> keyToListMap = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator.GroupCellsByExtent(this.m_cellGroup, viewTarget);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in keyToListMap.Keys)
			{
				if (this.m_config.IsViewTracing)
				{
					global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
					global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
					global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("================= Generating {0} View for: {1} ===========================", new object[]
					{
						flag ? "Query" : "Update",
						entitySetBase.Name
					});
					global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
					global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
				}
				try
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter queryRewriter = this.GenerateDirectionalViewsForExtent(viewTarget, entitySetBase, identifiers, views);
					if (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.UpdateView && this.m_config.IsValidationEnabled)
					{
						if (this.m_config.IsViewTracing)
						{
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("----------------- Validation for generated update view for: {0} -----------------", new object[]
							{
								entitySetBase.Name
							});
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
							global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
						}
						new global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.RewritingValidator(queryRewriter.ViewgenContext, queryRewriter.BasicView).Validate();
					}
				}
				catch (global::System.Data.Entity.Core.InternalMappingException ex)
				{
					errorLog.Merge(ex.ErrorLog);
				}
			}
			return errorLog;
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x000EB3D4 File Offset: 0x000E95D4
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter GenerateDirectionalViewsForExtent(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context = this.CreateViewgenContext(extent, viewTarget, identifiers);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter queryRewriter = null;
			if (this.m_config.GenerateViewsForEachType)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmType> enumerator = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(extent.ElementType, this.m_entityContainerMapping.StorageMappingItemCollection.EdmItemCollection, false).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = enumerator.Current;
						if (this.m_config.IsViewTracing && !edmType.Equals(extent.ElementType))
						{
							global::System.Data.Entity.Core.Common.Utils.Helpers.FormatTraceLine("CQL View for {0} and type {1}", new object[]
							{
								extent.Name,
								edmType.Name
							});
						}
						queryRewriter = this.GenerateViewsForExtentAndType(edmType, context, identifiers, views, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeViews);
					}
					goto IL_B7;
				}
			}
			queryRewriter = this.GenerateViewsForExtentAndType(extent.ElementType, context, identifiers, views, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode.OfTypeViews);
			IL_B7:
			if (viewTarget == global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget.QueryView)
			{
				this.m_config.SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.QueryViews);
			}
			else
			{
				this.m_config.SetTimeForFinishedActivity(global::System.Data.Entity.Core.Mapping.ViewGeneration.PerfType.UpdateViews);
			}
			this.m_queryRewriterCache[extent] = queryRewriter;
			return queryRewriter;
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x000EB4D4 File Offset: 0x000E96D4
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext CreateViewgenContext(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter queryRewriter;
			if (!this.m_queryRewriterCache.TryGetValue(extent, out queryRewriter))
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> extentCells = (from c in this.m_cellGroup
				where c.GetLeftQuery(viewTarget).Extent == extent
				select c).ToList<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>();
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext(viewTarget, extent, extentCells, identifiers, this.m_config, this.m_queryDomainMap, this.m_updateDomainMap, this.m_entityContainerMapping);
			}
			return queryRewriter.ViewgenContext;
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x000EB55C File Offset: 0x000E975C
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter GenerateViewsForExtentAndType(global::System.Data.Entity.Core.Metadata.Edm.EdmType generatedType, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewgenContext context, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers, global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenMode mode)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter queryRewriter = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter(generatedType, context, mode);
			queryRewriter.GenerateViewComponents();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView = queryRewriter.BasicView;
			if (this.m_config.IsNormalTracing)
			{
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTrace("Basic View: ");
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(basicView.ToString());
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode cellTreeNode = global::System.Data.Entity.Core.Mapping.ViewGeneration.ViewGenerator.GenerateSimplifiedView(basicView, queryRewriter.UsedCells);
			if (this.m_config.IsNormalTracing)
			{
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(string.Empty);
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTrace("Simplified View: ");
				global::System.Data.Entity.Core.Common.Utils.Helpers.StringTraceLine(cellTreeNode.ToString());
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGenerator cqlGenerator = new global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGenerator(cellTreeNode, queryRewriter.CaseStatements, identifiers, context.MemberMaps.ProjectedSlotMap, queryRewriter.UsedCells.Count, queryRewriter.TopLevelWhereClause, this.m_entityContainerMapping.StorageMappingItemCollection);
			string eSQL;
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree commandTree;
			if (this.m_config.GenerateEsql)
			{
				eSQL = cqlGenerator.GenerateEsql();
				commandTree = null;
			}
			else
			{
				eSQL = null;
				commandTree = cqlGenerator.GenerateCqt();
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView value = global::System.Data.Entity.Core.Mapping.ViewGeneration.GeneratedView.CreateGeneratedView(context.Extent, generatedType, commandTree, eSQL, this.m_entityContainerMapping.StorageMappingItemCollection, this.m_config);
			views.Add(context.Extent, value);
			return queryRewriter;
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x000EB668 File Offset: 0x000E9868
		private static global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode GenerateSimplifiedView(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellTreeNode basicView, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.LeftCellWrapper> usedCells)
		{
			int count = usedCells.Count;
			for (int i = 0; i < count; i++)
			{
				usedCells[i].RightCellQuery.InitializeBoolExpressions(count, i);
			}
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.CellTreeSimplifier.MergeNodes(basicView);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x000EB6A4 File Offset: 0x000E98A4
		private void CheckForeignKeyConstraints(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint foreignConstraint in this.m_foreignKeyConstraints)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter childRewriter = null;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter parentRewriter = null;
				this.m_queryRewriterCache.TryGetValue(foreignConstraint.ChildTable, out childRewriter);
				this.m_queryRewriterCache.TryGetValue(foreignConstraint.ParentTable, out parentRewriter);
				foreignConstraint.CheckConstraint(this.m_cellGroup, childRewriter, parentRewriter, errorLog, this.m_config);
			}
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000EB734 File Offset: 0x000E9934
		private static global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> GroupCellsByExtent(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> cells, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ViewTarget viewTarget)
		{
			global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> keyToListMap = new global::System.Data.Entity.Core.Common.Utils.KeyToListMap<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>(global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>.Default);
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell cell in cells)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CellQuery leftQuery = cell.GetLeftQuery(viewTarget);
				keyToListMap.Add(leftQuery.Extent, cell);
			}
			return keyToListMap;
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000EB798 File Offset: 0x000E9998
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell.CellsToBuilder(builder, this.m_cellGroup);
		}

		// Token: 0x04001850 RID: 6224
		private readonly global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> m_cellGroup;

		// Token: 0x04001851 RID: 6225
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator m_config;

		// Token: 0x04001852 RID: 6226
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_queryDomainMap;

		// Token: 0x04001853 RID: 6227
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap m_updateDomainMap;

		// Token: 0x04001854 RID: 6228
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.QueryRewriter> m_queryRewriterCache;

		// Token: 0x04001855 RID: 6229
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> m_foreignKeyConstraints;

		// Token: 0x04001856 RID: 6230
		private readonly global::System.Data.Entity.Core.Mapping.EntityContainerMapping m_entityContainerMapping;
	}
}
