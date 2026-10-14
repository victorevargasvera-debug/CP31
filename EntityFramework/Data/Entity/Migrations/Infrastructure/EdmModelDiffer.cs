using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000CF RID: 207
	internal class EdmModelDiffer
	{
		// Token: 0x06001000 RID: 4096 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		public global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.MigrationOperation> Diff(global::System.Xml.Linq.XDocument sourceModel, global::System.Xml.Linq.XDocument targetModel, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator = null, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator = null, string sourceModelVersion = null, string targetModelVersion = null)
		{
			if (sourceModel == targetModel || global::System.Xml.Linq.XNode.DeepEquals(sourceModel, targetModel))
			{
				return new global::System.Data.Entity.Migrations.Model.MigrationOperation[0];
			}
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo;
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection storageMappingItemCollection = sourceModel.GetStorageMappingItemCollection(out providerInfo);
			global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata source = new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata
			{
				EdmItemCollection = storageMappingItemCollection.EdmItemCollection,
				StoreItemCollection = storageMappingItemCollection.StoreItemCollection,
				StoreEntityContainer = storageMappingItemCollection.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(),
				EntityContainerMapping = storageMappingItemCollection.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(),
				ProviderManifest = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetProviderManifest(providerInfo),
				ProviderInfo = providerInfo
			};
			storageMappingItemCollection = targetModel.GetStorageMappingItemCollection(out providerInfo);
			global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata target = new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata
			{
				EdmItemCollection = storageMappingItemCollection.EdmItemCollection,
				StoreItemCollection = storageMappingItemCollection.StoreItemCollection,
				StoreEntityContainer = storageMappingItemCollection.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(),
				EntityContainerMapping = storageMappingItemCollection.GetItems<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>().Single<global::System.Data.Entity.Core.Mapping.EntityContainerMapping>(),
				ProviderManifest = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetProviderManifest(providerInfo),
				ProviderInfo = providerInfo
			};
			return this.Diff(source, target, modificationCommandTreeGenerator, migrationSqlGenerator, sourceModelVersion, targetModelVersion);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00020DDC File Offset: 0x0001EFDC
		private global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.MigrationOperation> Diff(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata source, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata target, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator, string sourceModelVersion = null, string targetModelVersion = null)
		{
			this._source = source;
			this._target = target;
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> entityTypePairs = this.FindEntityTypePairs().ToList<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> mappingFragmentPairs = this.FindMappingFragmentPairs(entityTypePairs).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> list = this.FindAssociationTypePairs(entityTypePairs).ToList<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs = this.FindTablePairs(mappingFragmentPairs, list).ToList<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>>();
			list.AddRange(this.FindStoreOnlyAssociationTypePairs(list, tablePairs));
			global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.RenameTableOperation> renameTableOperations = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedTables(tablePairs).ToList<global::System.Data.Entity.Migrations.Model.RenameTableOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> list2 = this.FindRenamedColumns(mappingFragmentPairs, list).ToList<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AddColumnOperation> second = this.FindAddedColumns(tablePairs, list2).ToList<global::System.Data.Entity.Migrations.Model.AddColumnOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropColumnOperation> second2 = this.FindDroppedColumns(tablePairs, list2).ToList<global::System.Data.Entity.Migrations.Model.DropColumnOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> list3 = this.FindAlteredColumns(tablePairs, list2).ToList<global::System.Data.Entity.Migrations.Model.AlterColumnOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropColumnOperation> second3 = this.FindOrphanedColumns(tablePairs, list2).ToList<global::System.Data.Entity.Migrations.Model.DropColumnOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MoveTableOperation> second4 = this.FindMovedTables(tablePairs).ToList<global::System.Data.Entity.Migrations.Model.MoveTableOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.CreateTableOperation> second5 = this.FindAddedTables(tablePairs).ToList<global::System.Data.Entity.Migrations.Model.CreateTableOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropTableOperation> second6 = this.FindDroppedTables(tablePairs).ToList<global::System.Data.Entity.Migrations.Model.DropTableOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AlterTableOperation> second7 = this.FindAlteredTables(tablePairs).ToList<global::System.Data.Entity.Migrations.Model.AlterTableOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation> source2 = this.FindAlteredPrimaryKeys(tablePairs, list2, list3).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation> source3 = this.FindAddedForeignKeys(list, list2).Concat(source2.OfType<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>()).ToList<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation> source4 = this.FindDroppedForeignKeys(list, list2).Concat(source2.OfType<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation>()).ToList<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation> second8 = this.FindAddedModificationFunctions(modificationCommandTreeGenerator, migrationSqlGenerator).ToList<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation> second9 = this.FindAlteredModificationFunctions(modificationCommandTreeGenerator, migrationSqlGenerator).ToList<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropProcedureOperation> second10 = this.FindDroppedModificationFunctions().ToList<global::System.Data.Entity.Migrations.Model.DropProcedureOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation> second11 = this.FindRenamedModificationFunctions().ToList<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation> second12 = this.FindMovedModificationFunctions().ToList<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> sourceIndexes = ((string.IsNullOrWhiteSpace(sourceModelVersion) || string.Compare(sourceModelVersion.Substring(0, 3), "6.1", global::System.StringComparison.Ordinal) >= 0) ? this.FindSourceIndexes(tablePairs) : global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildLegacyIndexes(source)).ToList<global::System.Data.Entity.Infrastructure.ConsolidatedIndex>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> targetIndexes = ((string.IsNullOrWhiteSpace(targetModelVersion) || string.Compare(targetModelVersion.Substring(0, 3), "6.1", global::System.StringComparison.Ordinal) >= 0) ? this.FindTargetIndexes() : global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildLegacyIndexes(target)).ToList<global::System.Data.Entity.Infrastructure.ConsolidatedIndex>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.CreateIndexOperation> list4 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindAddedIndexes(sourceIndexes, targetIndexes, list3, list2).ToList<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.DropIndexOperation> list5 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindDroppedIndexes(sourceIndexes, targetIndexes, list3, list2).ToList<global::System.Data.Entity.Migrations.Model.DropIndexOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.RenameIndexOperation> renameIndexOperations = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedIndexes(list4, list5, list3, list2).ToList<global::System.Data.Entity.Migrations.Model.RenameIndexOperation>();
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies(renameTableOperations).Concat(second4).Concat(source4.Distinct(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer._foreignKeyEqualityComparer)).Concat(list5.Distinct(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer._indexEqualityComparer)).Concat(second3).Concat(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies(list2)).Concat(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies(renameIndexOperations)).Concat(source2.OfType<global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation>()).Concat(second5).Concat(second7).Concat(second).Concat(list3).Concat(source2.OfType<global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation>()).Concat(list4.Distinct(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer._indexEqualityComparer)).Concat(source3.Distinct(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer._foreignKeyEqualityComparer)).Concat(second2).Concat(second6).Concat(second8).Concat(second12).Concat(second11).Concat(second9).Concat(second10).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000210D7 File Offset: 0x0001F2D7
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> BuildLegacyIndexes(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> enumerator = modelMetadata.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = enumerator.Current;
					string name = global::System.Data.Entity.Migrations.Model.IndexOperation.BuildDefaultName(from p in associationType.Constraint.ToProperties
					select p.Name);
					string schemaQualifiedName = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(modelMetadata.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == associationType.Constraint.DependentEnd.GetEntityType()));
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> toProperties = associationType.Constraint.ToProperties;
					global::System.Data.Entity.Infrastructure.ConsolidatedIndex consolidatedIndex;
					if (toProperties.Count > 0)
					{
						consolidatedIndex = new global::System.Data.Entity.Infrastructure.ConsolidatedIndex(schemaQualifiedName, toProperties[0].Name, new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(name, 0));
						for (int i = 1; i < toProperties.Count; i++)
						{
							consolidatedIndex.Add(toProperties[i].Name, new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(name, i));
						}
					}
					else
					{
						consolidatedIndex = new global::System.Data.Entity.Infrastructure.ConsolidatedIndex(schemaQualifiedName, new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(name));
					}
					yield return consolidatedIndex;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000210E8 File Offset: 0x0001F2E8
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> FindEntityTypePairs()
		{
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> list = (from et1 in this._source.EdmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()
			from et2 in this._target.EdmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()
			where et1.Name.EqualsOrdinal(et2.Name)
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(et1, et2)).ToList<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> second = (from t in list
			select t.Item1).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> source = this._source.EdmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().Except(second).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> second2 = (from t in list
			select t.Item2).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> targetRemainingEntities = this._target.EdmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().Except(second2).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			return list.Concat(from et1 in source
			from et2 in targetRemainingEntities
			where global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FuzzyMatchEntities(et1, et2)
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(et1, et2));
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000212A0 File Offset: 0x0001F4A0
		private static bool FuzzyMatchEntities(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType1, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2)
		{
			if (!entityType1.KeyMembers.SequenceEqual(entityType2.KeyMembers, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>((global::System.Data.Entity.Core.Metadata.Edm.EdmMember m1, global::System.Data.Entity.Core.Metadata.Edm.EdmMember m2) => m1.EdmEquals(m2))))
			{
				return false;
			}
			if ((entityType1.BaseType != null && entityType2.BaseType == null) || (entityType1.BaseType == null && entityType2.BaseType != null))
			{
				return false;
			}
			return (double)((float)(from m1 in entityType1.DeclaredMembers
			from m2 in entityType2.DeclaredMembers
			where m1.EdmEquals(m2)
			select 1).Count<int>() * 2f / (float)(entityType1.DeclaredMembers.Count + entityType2.DeclaredMembers.Count)) > 0.8;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000213D8 File Offset: 0x0001F5D8
		private static bool SourceAndTargetMatch(global::System.Data.Entity.Core.Metadata.Edm.EntityType sourceEntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping sourceEntityTypeMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType targetEntityType, global::System.Data.Entity.Core.Mapping.EntityTypeMapping targetEntityTypeMapping)
		{
			if (sourceEntityTypeMapping.EntityType != null && targetEntityTypeMapping.EntityType != null)
			{
				if (sourceEntityType == sourceEntityTypeMapping.EntityType && targetEntityType == targetEntityTypeMapping.EntityType)
				{
					return true;
				}
			}
			else
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> isOfTypes = sourceEntityTypeMapping.IsOfTypes;
				if (isOfTypes.Contains(sourceEntityType))
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> isOfTypes2 = targetEntityTypeMapping.IsOfTypes;
					if (isOfTypes2.Contains(targetEntityType))
					{
						global::System.Collections.Generic.IEnumerable<string> first = from et in isOfTypes.Except(new global::System.Data.Entity.Core.Metadata.Edm.EntityType[]
						{
							sourceEntityType
						})
						select et.Name;
						global::System.Collections.Generic.IEnumerable<string> second = from et in isOfTypes2.Except(new global::System.Data.Entity.Core.Metadata.Edm.EntityType[]
						{
							targetEntityType
						})
						select et.Name;
						if (first.SequenceEqual(second))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000214A8 File Offset: 0x0001F6A8
		private static bool MappingTypesAreIdentical(global::System.Data.Entity.Core.Mapping.EntityTypeMapping sourceEntityTypeMapping, global::System.Data.Entity.Core.Mapping.EntityTypeMapping targetEntityTypeMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = sourceEntityTypeMapping.EntityType ?? sourceEntityTypeMapping.IsOfTypes.First<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>();
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = targetEntityTypeMapping.EntityType ?? targetEntityTypeMapping.IsOfTypes.First<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase>();
			return edmType.FullName == entityTypeBase.FullName;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000214F0 File Offset: 0x0001F6F0
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> FindMappingFragmentPairs(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> entityTypePairs)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> targetEntityTypeMappings = this._target.EntityContainerMapping.EntitySetMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings).ToList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> enumerable = this._source.EntityContainerMapping.EntitySetMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> matchedTargets = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> enumerator = enumerable.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm1 = enumerator.Current;
					using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>.Enumerator enumerator2 = targetEntityTypeMappings.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm2 = enumerator2.Current;
							if (!matchedTargets.Contains(etm2))
							{
								bool flag = entityTypePairs.Any((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType> t) => global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.SourceAndTargetMatch(t.Item1, etm1, t.Item2, etm2));
								if (!flag)
								{
									flag = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.MappingTypesAreIdentical(etm1, etm2);
								}
								if (flag)
								{
									matchedTargets.Add(etm2);
									foreach (global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment> tuple in etm1.MappingFragments.Zip(etm2.MappingFragments, new global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>>(global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>)))
									{
										yield return tuple;
									}
									global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> enumerator3 = null;
									break;
								}
							}
						}
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>.Enumerator);
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00021508 File Offset: 0x0001F708
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> FindAssociationTypePairs(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> entityTypePairs)
		{
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> list = (from ets in entityTypePairs
			from np1 in ets.Item1.NavigationProperties
			from np2 in ets.Item2.NavigationProperties
			where np1.Name.EqualsIgnoreCase(np2.Name)
			from t in this.GetStoreAssociationTypePairs(np1.Association, np2.Association, entityTypePairs)
			select t).Distinct<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>>().ToList<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> source = this._source.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from t in list
			select t.Item1).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> targetRemainingAssociationTypes = this._target.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from t in list
			select t.Item2).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			return list.Concat(from <>h__TransparentIdentifier0 in (from at1 in source
			from at2 in targetRemainingAssociationTypes
			select new
			{
				at1,
				at2
			}).Where(delegate(<>h__TransparentIdentifier0)
			{
				if (<>h__TransparentIdentifier0.at1.Name.EqualsIgnoreCase(<>h__TransparentIdentifier0.at2.Name))
				{
					return true;
				}
				if (<>h__TransparentIdentifier0.at1.Constraint != null && <>h__TransparentIdentifier0.at2.Constraint != null && <>h__TransparentIdentifier0.at1.Constraint.PrincipalEnd.GetEntityType().EdmEquals(<>h__TransparentIdentifier0.at2.Constraint.PrincipalEnd.GetEntityType()) && <>h__TransparentIdentifier0.at1.Constraint.DependentEnd.GetEntityType().EdmEquals(<>h__TransparentIdentifier0.at2.Constraint.DependentEnd.GetEntityType()))
				{
					return <>h__TransparentIdentifier0.at1.Constraint.ToProperties.SequenceEqual(<>h__TransparentIdentifier0.at2.Constraint.ToProperties, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>((global::System.Data.Entity.Core.Metadata.Edm.EdmMember p1, global::System.Data.Entity.Core.Metadata.Edm.EdmMember p2) => p1.EdmEquals(p2)));
				}
				return false;
			})
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(<>h__TransparentIdentifier0.at1, <>h__TransparentIdentifier0.at2));
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00021718 File Offset: 0x0001F918
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> GetStoreAssociationTypePairs(global::System.Data.Entity.Core.Metadata.Edm.AssociationType conceptualAssociationType1, global::System.Data.Entity.Core.Metadata.Edm.AssociationType conceptualAssociationType2, global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> entityTypePairs)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType item;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType item2;
			if (this._source.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(conceptualAssociationType1.Name), out item) && this._target.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(conceptualAssociationType2.Name), out item2))
			{
				yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, item2);
			}
			else
			{
				global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.<>c__DisplayClass15_0 CS$<>8__locals1 = new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.<>c__DisplayClass15_0();
				CS$<>8__locals1.sourceEnd1 = conceptualAssociationType1.SourceEnd;
				global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType> tuple = entityTypePairs.Single((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType> t) => t.Item1 == CS$<>8__locals1.sourceEnd1.GetEntityType());
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd2 = (conceptualAssociationType2.SourceEnd.GetEntityType() == tuple.Item2) ? conceptualAssociationType2.SourceEnd : conceptualAssociationType2.TargetEnd;
				if (this._source.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(CS$<>8__locals1.sourceEnd1.Name), out item) && this._target.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(sourceEnd2.Name), out item2))
				{
					yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, item2);
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd = conceptualAssociationType1.GetOtherEnd(CS$<>8__locals1.sourceEnd1);
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd2 = conceptualAssociationType2.GetOtherEnd(sourceEnd2);
				if (this._source.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(otherEnd.Name), out item) && this._target.StoreItemCollection.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetStoreAssociationIdentity(otherEnd2.Name), out item2))
				{
					yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, item2);
				}
				CS$<>8__locals1 = null;
				sourceEnd2 = null;
			}
			yield break;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00021740 File Offset: 0x0001F940
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> FindStoreOnlyAssociationTypePairs(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs, global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> list = this._source.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from t in associationTypePairs
			select t.Item1).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> list2 = this._target.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from t in associationTypePairs
			select t.Item2).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> list3 = new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>>();
			while (list.Any<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType1 = list[0];
				for (int i = 0; i < list2.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType2 = list2[i];
					if (tablePairs.Any((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> t) => t.Item1.ElementType == associationType1.Constraint.PrincipalEnd.GetEntityType() && t.Item2.ElementType == associationType2.Constraint.PrincipalEnd.GetEntityType()) && tablePairs.Any((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> t) => t.Item1.ElementType == associationType1.Constraint.DependentEnd.GetEntityType() && t.Item2.ElementType == associationType2.Constraint.DependentEnd.GetEntityType()))
					{
						list3.Add(global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationType1, associationType2));
						list2.RemoveAt(i);
						break;
					}
				}
				list.RemoveAt(0);
			}
			return list3;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00021883 File Offset: 0x0001FA83
		private static string GetStoreAssociationIdentity(string associationName)
		{
			return "CodeFirstDatabaseSchema." + associationName;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00021890 File Offset: 0x0001FA90
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> FindTablePairs(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> mappingFragmentPairs, global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> sourceTables = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> targetTables = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
			foreach (global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment> tuple in mappingFragmentPairs)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet tableSet = tuple.Item1.TableSet;
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet tableSet2 = tuple.Item2.TableSet;
				if (!sourceTables.Contains(tableSet) && !targetTables.Contains(tableSet2))
				{
					sourceTables.Add(tableSet);
					targetTables.Add(tableSet2);
					yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(tableSet, tableSet2);
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> enumerator = null;
			using (global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> enumerator2 = associationTypePairs.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType> associationTypePair = enumerator2.Current;
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = this._source.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == associationTypePair.Item1.Constraint.DependentEnd.GetEntityType());
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = this._target.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == associationTypePair.Item2.Constraint.DependentEnd.GetEntityType());
					if (!sourceTables.Contains(entitySet) && !targetTables.Contains(entitySet2))
					{
						sourceTables.Add(entitySet);
						targetTables.Add(entitySet2);
						yield return global::System.Tuple.Create<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, entitySet2);
					}
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> enumerator2 = null;
			yield break;
			yield break;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000218B0 File Offset: 0x0001FAB0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameTableOperation> HandleTransitiveRenameDependencies(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.RenameTableOperation> renameTableOperations)
		{
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies<global::System.Data.Entity.Migrations.Model.RenameTableOperation>(renameTableOperations, delegate(global::System.Data.Entity.Migrations.Model.RenameTableOperation rt1, global::System.Data.Entity.Migrations.Model.RenameTableOperation rt2)
			{
				global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(rt1.Name);
				global::System.Data.Entity.Utilities.DatabaseName databaseName2 = global::System.Data.Entity.Utilities.DatabaseName.Parse(rt2.Name);
				return databaseName.Name.EqualsIgnoreCase(rt2.NewName) && databaseName.Schema.EqualsIgnoreCase(databaseName2.Schema);
			}, (string t, global::System.Data.Entity.Migrations.Model.RenameTableOperation rt) => new global::System.Data.Entity.Migrations.Model.RenameTableOperation(t, rt.NewName, null), delegate(global::System.Data.Entity.Migrations.Model.RenameTableOperation rt, string t)
			{
				rt.NewName = t;
			});
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00021920 File Offset: 0x0001FB20
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> HandleTransitiveRenameDependencies(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renameColumnOperations)
		{
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>(renameColumnOperations, (global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc1, global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc2) => rc1.Table.EqualsIgnoreCase(rc2.Table) && rc1.Name.EqualsIgnoreCase(rc2.NewName), (string c, global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc) => new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(rc.Table, c, rc.NewName, null), delegate(global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc, string c)
			{
				rc.NewName = c;
			});
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00021990 File Offset: 0x0001FB90
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameIndexOperation> HandleTransitiveRenameDependencies(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.RenameIndexOperation> renameIndexOperations)
		{
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.HandleTransitiveRenameDependencies<global::System.Data.Entity.Migrations.Model.RenameIndexOperation>(renameIndexOperations, (global::System.Data.Entity.Migrations.Model.RenameIndexOperation ri1, global::System.Data.Entity.Migrations.Model.RenameIndexOperation ri2) => ri1.Table.EqualsIgnoreCase(ri2.Table) && ri1.Name.EqualsIgnoreCase(ri2.NewName), (string i, global::System.Data.Entity.Migrations.Model.RenameIndexOperation rc) => new global::System.Data.Entity.Migrations.Model.RenameIndexOperation(rc.Table, i, rc.NewName, null), delegate(global::System.Data.Entity.Migrations.Model.RenameIndexOperation rc, string i)
			{
				rc.NewName = i;
			});
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00021A00 File Offset: 0x0001FC00
		private static global::System.Collections.Generic.IEnumerable<T> HandleTransitiveRenameDependencies<T>(global::System.Collections.Generic.IList<T> renameOperations, global::System.Func<T, T, bool> dependencyFinder, global::System.Func<string, T, T> renameCreator, global::System.Action<T, string> setNewName) where T : class
		{
			int tempCounter = 0;
			global::System.Collections.Generic.List<T> tempRenames = new global::System.Collections.Generic.List<T>();
			int num;
			for (int i = 0; i < renameOperations.Count; i = num + 1)
			{
				T renameOperation = renameOperations[i];
				if (renameOperations.Skip(i + 1).SingleOrDefault((T rt) => dependencyFinder(renameOperation, rt)) != null)
				{
					string str = "__mig_tmp__";
					num = tempCounter;
					tempCounter = num + 1;
					string text = str + num.ToString();
					tempRenames.Add(renameCreator(text, renameOperation));
					setNewName(renameOperation, text);
				}
				yield return renameOperation;
				num = i;
			}
			foreach (T t in tempRenames)
			{
				yield return t;
			}
			global::System.Collections.Generic.List<T>.Enumerator enumerator = default(global::System.Collections.Generic.List<T>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00021A28 File Offset: 0x0001FC28
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation> FindMovedModificationFunctions()
		{
			return (from esm1 in this._source.EntityContainerMapping.EntitySetMappings
			from mfm1 in esm1.ModificationFunctionMappings
			from esm2 in this._target.EntityContainerMapping.EntitySetMappings
			from mfm2 in esm2.ModificationFunctionMappings
			where mfm1.EntityType.Identity == mfm2.EntityType.Identity
			from o in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.DiffModificationFunctionSchemas(mfm1, mfm2)
			select o).Concat(from asm1 in this._source.EntityContainerMapping.AssociationSetMappings
			where asm1.ModificationFunctionMapping != null
			from asm2 in this._target.EntityContainerMapping.AssociationSetMappings
			where asm2.ModificationFunctionMapping != null && asm1.ModificationFunctionMapping.AssociationSet.Identity == asm2.ModificationFunctionMapping.AssociationSet.Identity
			from o in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.DiffModificationFunctionSchemas(asm1.ModificationFunctionMapping, asm2.ModificationFunctionMapping)
			select o);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00021C32 File Offset: 0x0001FE32
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation> DiffModificationFunctionSchemas(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping targetModificationFunctionMapping)
		{
			if (!sourceModificationFunctionMapping.InsertFunctionMapping.Function.Schema.EqualsOrdinal(targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema))
			{
				yield return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.InsertFunctionMapping.Function), targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema, null);
			}
			if (!sourceModificationFunctionMapping.UpdateFunctionMapping.Function.Schema.EqualsOrdinal(targetModificationFunctionMapping.UpdateFunctionMapping.Function.Schema))
			{
				yield return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.UpdateFunctionMapping.Function), targetModificationFunctionMapping.UpdateFunctionMapping.Function.Schema, null);
			}
			if (!sourceModificationFunctionMapping.DeleteFunctionMapping.Function.Schema.EqualsOrdinal(targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema))
			{
				yield return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.DeleteFunctionMapping.Function), targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema, null);
			}
			yield break;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00021C49 File Offset: 0x0001FE49
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation> DiffModificationFunctionSchemas(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping targetModificationFunctionMapping)
		{
			if (!sourceModificationFunctionMapping.InsertFunctionMapping.Function.Schema.EqualsOrdinal(targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema))
			{
				yield return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.InsertFunctionMapping.Function), targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema, null);
			}
			if (!sourceModificationFunctionMapping.DeleteFunctionMapping.Function.Schema.EqualsOrdinal(targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema))
			{
				yield return new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.DeleteFunctionMapping.Function), targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema, null);
			}
			yield break;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00021C60 File Offset: 0x0001FE60
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation> FindAddedModificationFunctions(global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return (from esm1 in this._target.EntityContainerMapping.EntitySetMappings
			from mfm1 in esm1.ModificationFunctionMappings
			where !(from esm2 in this._source.EntityContainerMapping.EntitySetMappings
			from mfm2 in esm2.ModificationFunctionMappings
			where mfm1.EntityType.Identity == mfm2.EntityType.Identity
			select mfm2).Any<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>()
			from o in this.BuildCreateProcedureOperations(mfm1, modificationCommandTreeGenerator, migrationSqlGenerator)
			select o).Concat(from asm1 in this._target.EntityContainerMapping.AssociationSetMappings
			where asm1.ModificationFunctionMapping != null
			where !(from asm2 in this._source.EntityContainerMapping.AssociationSetMappings
			where asm2.ModificationFunctionMapping != null && asm1.ModificationFunctionMapping.AssociationSet.Identity == asm2.ModificationFunctionMapping.AssociationSet.Identity
			select asm2.ModificationFunctionMapping).Any<global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping>()
			from o in this.BuildCreateProcedureOperations(asm1.ModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator)
			select o);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00021D98 File Offset: 0x0001FF98
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation> FindRenamedModificationFunctions()
		{
			return (from esm1 in this._source.EntityContainerMapping.EntitySetMappings
			from mfm1 in esm1.ModificationFunctionMappings
			from esm2 in this._target.EntityContainerMapping.EntitySetMappings
			from mfm2 in esm2.ModificationFunctionMappings
			where mfm1.EntityType.Identity == mfm2.EntityType.Identity
			from o in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.DiffModificationFunctionNames(mfm1, mfm2)
			select o).Concat(from asm1 in this._source.EntityContainerMapping.AssociationSetMappings
			where asm1.ModificationFunctionMapping != null
			from asm2 in this._target.EntityContainerMapping.AssociationSetMappings
			where asm2.ModificationFunctionMapping != null && asm1.ModificationFunctionMapping.AssociationSet.Identity == asm2.ModificationFunctionMapping.AssociationSet.Identity
			from o in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.DiffModificationFunctionNames(asm1.ModificationFunctionMapping, asm2.ModificationFunctionMapping)
			select o);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00021FA2 File Offset: 0x000201A2
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation> DiffModificationFunctionNames(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping targetModificationFunctionMapping)
		{
			if (!sourceModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName.EqualsOrdinal(targetModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName))
			{
				yield return new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName, targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema), targetModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName, null);
			}
			if (!sourceModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName.EqualsOrdinal(targetModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName))
			{
				yield return new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName, targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema), targetModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName, null);
			}
			yield break;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00021FB9 File Offset: 0x000201B9
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation> DiffModificationFunctionNames(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping targetModificationFunctionMapping)
		{
			if (!sourceModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName.EqualsOrdinal(targetModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName))
			{
				yield return new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName, targetModificationFunctionMapping.InsertFunctionMapping.Function.Schema), targetModificationFunctionMapping.InsertFunctionMapping.Function.FunctionName, null);
			}
			if (!sourceModificationFunctionMapping.UpdateFunctionMapping.Function.FunctionName.EqualsOrdinal(targetModificationFunctionMapping.UpdateFunctionMapping.Function.FunctionName))
			{
				yield return new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.UpdateFunctionMapping.Function.FunctionName, targetModificationFunctionMapping.UpdateFunctionMapping.Function.Schema), targetModificationFunctionMapping.UpdateFunctionMapping.Function.FunctionName, null);
			}
			if (!sourceModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName.EqualsOrdinal(targetModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName))
			{
				yield return new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(sourceModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName, targetModificationFunctionMapping.DeleteFunctionMapping.Function.Schema), targetModificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName, null);
			}
			yield break;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00021FD0 File Offset: 0x000201D0
		private static string GetSchemaQualifiedName(string table, string schema)
		{
			return new global::System.Data.Entity.Utilities.DatabaseName(table, schema).ToString();
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00021FE0 File Offset: 0x000201E0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation> FindAlteredModificationFunctions(global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return (from esm1 in this._source.EntityContainerMapping.EntitySetMappings
			from mfm1 in esm1.ModificationFunctionMappings
			from esm2 in this._target.EntityContainerMapping.EntitySetMappings
			from mfm2 in esm2.ModificationFunctionMappings
			where mfm1.EntityType.Identity == mfm2.EntityType.Identity
			from o in this.DiffModificationFunctions(mfm1, mfm2, modificationCommandTreeGenerator, migrationSqlGenerator)
			select o).Concat(from asm1 in this._source.EntityContainerMapping.AssociationSetMappings
			where asm1.ModificationFunctionMapping != null
			from asm2 in this._target.EntityContainerMapping.AssociationSetMappings
			where asm2.ModificationFunctionMapping != null && asm1.ModificationFunctionMapping.AssociationSet.Identity == asm2.ModificationFunctionMapping.AssociationSet.Identity
			from o in this.DiffModificationFunctions(asm1.ModificationFunctionMapping, asm2.ModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator)
			select o);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000221DF File Offset: 0x000203DF
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation> DiffModificationFunctions(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping targetModificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			if (!this.DiffModificationFunction(sourceModificationFunctionMapping.InsertFunctionMapping, targetModificationFunctionMapping.InsertFunctionMapping))
			{
				yield return this.BuildAlterProcedureOperation(targetModificationFunctionMapping.InsertFunctionMapping.Function, this.GenerateInsertFunctionBody(targetModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			}
			if (!this.DiffModificationFunction(sourceModificationFunctionMapping.DeleteFunctionMapping, targetModificationFunctionMapping.DeleteFunctionMapping))
			{
				yield return this.BuildAlterProcedureOperation(targetModificationFunctionMapping.DeleteFunctionMapping.Function, this.GenerateDeleteFunctionBody(targetModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			}
			yield break;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0002220C File Offset: 0x0002040C
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation> DiffModificationFunctions(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping sourceModificationFunctionMapping, global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping targetModificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			if (!this.DiffModificationFunction(sourceModificationFunctionMapping.InsertFunctionMapping, targetModificationFunctionMapping.InsertFunctionMapping))
			{
				yield return this.BuildAlterProcedureOperation(targetModificationFunctionMapping.InsertFunctionMapping.Function, this.GenerateInsertFunctionBody(targetModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			}
			if (!this.DiffModificationFunction(sourceModificationFunctionMapping.UpdateFunctionMapping, targetModificationFunctionMapping.UpdateFunctionMapping))
			{
				yield return this.BuildAlterProcedureOperation(targetModificationFunctionMapping.UpdateFunctionMapping.Function, this.GenerateUpdateFunctionBody(targetModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			}
			if (!this.DiffModificationFunction(sourceModificationFunctionMapping.DeleteFunctionMapping, targetModificationFunctionMapping.DeleteFunctionMapping))
			{
				yield return this.BuildAlterProcedureOperation(targetModificationFunctionMapping.DeleteFunctionMapping.Function, this.GenerateDeleteFunctionBody(targetModificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			}
			yield break;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00022239 File Offset: 0x00020439
		private string GenerateInsertFunctionBody(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return this.GenerateFunctionBody<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>(modificationFunctionMapping, (global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator m, string s) => m.GenerateInsert(s), modificationCommandTreeGenerator, migrationSqlGenerator, modificationFunctionMapping.InsertFunctionMapping.Function.FunctionName, null);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00022274 File Offset: 0x00020474
		private string GenerateInsertFunctionBody(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return this.GenerateFunctionBody<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>(modificationFunctionMapping, (global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator m, string s) => m.GenerateAssociationInsert(s), modificationCommandTreeGenerator, migrationSqlGenerator, null);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000222A0 File Offset: 0x000204A0
		private string GenerateUpdateFunctionBody(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return this.GenerateFunctionBody<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>(modificationFunctionMapping, (global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator m, string s) => m.GenerateUpdate(s), modificationCommandTreeGenerator, migrationSqlGenerator, modificationFunctionMapping.UpdateFunctionMapping.Function.FunctionName, modificationFunctionMapping.UpdateFunctionMapping.RowsAffectedParameterName);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000222F0 File Offset: 0x000204F0
		private string GenerateDeleteFunctionBody(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return this.GenerateFunctionBody<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>(modificationFunctionMapping, (global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator m, string s) => m.GenerateDelete(s), modificationCommandTreeGenerator, migrationSqlGenerator, modificationFunctionMapping.DeleteFunctionMapping.Function.FunctionName, modificationFunctionMapping.DeleteFunctionMapping.RowsAffectedParameterName);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00022340 File Offset: 0x00020540
		private string GenerateDeleteFunctionBody(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			return this.GenerateFunctionBody<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>(modificationFunctionMapping, (global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator m, string s) => m.GenerateAssociationDelete(s), modificationCommandTreeGenerator, migrationSqlGenerator, modificationFunctionMapping.DeleteFunctionMapping.RowsAffectedParameterName);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00022378 File Offset: 0x00020578
		private string GenerateFunctionBody<TCommandTree>(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping, global::System.Func<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator, string, global::System.Collections.Generic.IEnumerable<TCommandTree>> treeGenerator, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator, string functionName, string rowsAffectedParameterName) where TCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
		{
			TCommandTree[] commandTrees = new TCommandTree[0];
			if (modificationCommandTreeGenerator != null)
			{
				global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter dynamicToFunctionModificationCommandConverter = new global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter(modificationFunctionMapping, this._target.EntityContainerMapping);
				try
				{
					commandTrees = dynamicToFunctionModificationCommandConverter.Convert<TCommandTree>(treeGenerator(modificationCommandTreeGenerator.Value, modificationFunctionMapping.EntityType.Identity)).ToArray<TCommandTree>();
				}
				catch (global::System.Data.Entity.Core.UpdateException innerException)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ErrorGeneratingCommandTree(functionName, modificationFunctionMapping.EntityType.Name), innerException);
				}
			}
			return this.GenerateFunctionBody<TCommandTree>(migrationSqlGenerator, rowsAffectedParameterName, commandTrees);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000223FC File Offset: 0x000205FC
		private string GenerateFunctionBody<TCommandTree>(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationFunctionMapping, global::System.Func<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator, string, global::System.Collections.Generic.IEnumerable<TCommandTree>> treeGenerator, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator, string rowsAffectedParameterName) where TCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
		{
			TCommandTree[] commandTrees = new TCommandTree[0];
			if (modificationCommandTreeGenerator != null)
			{
				commandTrees = new global::System.Data.Entity.Migrations.Infrastructure.DynamicToFunctionModificationCommandConverter(modificationFunctionMapping, this._target.EntityContainerMapping).Convert<TCommandTree>(treeGenerator(modificationCommandTreeGenerator.Value, modificationFunctionMapping.AssociationSet.ElementType.Identity)).ToArray<TCommandTree>();
			}
			return this.GenerateFunctionBody<TCommandTree>(migrationSqlGenerator, rowsAffectedParameterName, commandTrees);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00022458 File Offset: 0x00020658
		private string GenerateFunctionBody<TCommandTree>(global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator, string rowsAffectedParameterName, TCommandTree[] commandTrees) where TCommandTree : global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree
		{
			if (migrationSqlGenerator == null)
			{
				return null;
			}
			string providerManifestToken = this._target.ProviderInfo.ProviderManifestToken;
			return migrationSqlGenerator.GenerateProcedureBody(commandTrees, rowsAffectedParameterName, providerManifestToken);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00022484 File Offset: 0x00020684
		private bool DiffModificationFunction(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping1, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping2)
		{
			if (!functionMapping1.RowsAffectedParameterName.EqualsOrdinal(functionMapping2.RowsAffectedParameterName))
			{
				return false;
			}
			if (!functionMapping1.ParameterBindings.SequenceEqual(functionMapping2.ParameterBindings, new global::System.Func<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding, bool>(this.DiffParameterBinding)))
			{
				return false;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> enumerable = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding>();
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> resultBindings = functionMapping1.ResultBindings;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding> source = resultBindings ?? enumerable;
			resultBindings = functionMapping2.ResultBindings;
			return source.SequenceEqual(resultBindings ?? enumerable, new global::System.Func<global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding, global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding, bool>(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.DiffResultBinding));
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00022500 File Offset: 0x00020700
		private bool DiffParameterBinding(global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding parameterBinding1, global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding parameterBinding2)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter = parameterBinding1.Parameter;
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter2 = parameterBinding2.Parameter;
			if (!parameter.Name.EqualsOrdinal(parameter2.Name))
			{
				return false;
			}
			if (parameter.Mode != parameter2.Mode)
			{
				return false;
			}
			if (parameterBinding1.IsCurrent != parameterBinding2.IsCurrent)
			{
				return false;
			}
			if (!parameterBinding1.MemberPath.Members.SequenceEqual(parameterBinding2.MemberPath.Members, (global::System.Data.Entity.Core.Metadata.Edm.EdmMember m1, global::System.Data.Entity.Core.Metadata.Edm.EdmMember m2) => m1.Identity.EqualsOrdinal(m2.Identity)))
			{
				return false;
			}
			if (this._source.ProviderInfo.Equals(this._target.ProviderInfo))
			{
				return parameter.TypeName.EqualsIgnoreCase(parameter2.TypeName) && parameter.TypeUsage.EdmEquals(parameter2.TypeUsage);
			}
			byte? b = parameter.Precision;
			int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			b = parameter2.Precision;
			int? num2 = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
			{
				b = parameter.Scale;
				num2 = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
				b = parameter2.Scale;
				num = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
				return num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null);
			}
			return false;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000226C0 File Offset: 0x000208C0
		private static bool DiffResultBinding(global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding resultBinding1, global::System.Data.Entity.Core.Mapping.ModificationFunctionResultBinding resultBinding2)
		{
			return resultBinding1.ColumnName.EqualsOrdinal(resultBinding2.ColumnName) && resultBinding1.Property.Identity.EqualsOrdinal(resultBinding2.Property.Identity);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000226F7 File Offset: 0x000208F7
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation> BuildCreateProcedureOperations(global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			yield return this.BuildCreateProcedureOperation(modificationFunctionMapping.InsertFunctionMapping.Function, this.GenerateInsertFunctionBody(modificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			yield return this.BuildCreateProcedureOperation(modificationFunctionMapping.UpdateFunctionMapping.Function, this.GenerateUpdateFunctionBody(modificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			yield return this.BuildCreateProcedureOperation(modificationFunctionMapping.DeleteFunctionMapping.Function, this.GenerateDeleteFunctionBody(modificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			yield break;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0002271C File Offset: 0x0002091C
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation> BuildCreateProcedureOperations(global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping modificationFunctionMapping, global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> modificationCommandTreeGenerator, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			yield return this.BuildCreateProcedureOperation(modificationFunctionMapping.InsertFunctionMapping.Function, this.GenerateInsertFunctionBody(modificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			yield return this.BuildCreateProcedureOperation(modificationFunctionMapping.DeleteFunctionMapping.Function, this.GenerateDeleteFunctionBody(modificationFunctionMapping, modificationCommandTreeGenerator, migrationSqlGenerator));
			yield break;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00022744 File Offset: 0x00020944
		private global::System.Data.Entity.Migrations.Model.CreateProcedureOperation BuildCreateProcedureOperation(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, string bodySql)
		{
			global::System.Data.Entity.Migrations.Model.CreateProcedureOperation createProcedureOperation = new global::System.Data.Entity.Migrations.Model.CreateProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(function), bodySql, null);
			function.Parameters.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter p)
			{
				createProcedureOperation.Parameters.Add(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildParameterModel(p, this._target));
			});
			return createProcedureOperation;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00022790 File Offset: 0x00020990
		private global::System.Data.Entity.Migrations.Model.AlterProcedureOperation BuildAlterProcedureOperation(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, string bodySql)
		{
			global::System.Data.Entity.Migrations.Model.AlterProcedureOperation alterProcedureOperation = new global::System.Data.Entity.Migrations.Model.AlterProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(function), bodySql, null);
			function.Parameters.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter p)
			{
				alterProcedureOperation.Parameters.Add(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildParameterModel(p, this._target));
			});
			return alterProcedureOperation;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x000227DC File Offset: 0x000209DC
		private static global::System.Data.Entity.Migrations.Model.ParameterModel BuildParameterModel(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = functionParameter.TypeUsage.ModelTypeUsage;
			string name = modelMetadata.ProviderManifest.GetStoreType(modelTypeUsage).EdmType.Name;
			global::System.Data.Entity.Migrations.Model.ParameterModel parameterModel = new global::System.Data.Entity.Migrations.Model.ParameterModel(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)modelTypeUsage.EdmType).PrimitiveTypeKind, modelTypeUsage)
			{
				Name = functionParameter.Name,
				IsOutParameter = (functionParameter.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out),
				StoreType = ((!functionParameter.TypeName.EqualsIgnoreCase(name)) ? functionParameter.TypeName : null)
			};
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (modelTypeUsage.Facets.TryGetValue("MaxLength", true, out facet) && facet.Value != null)
			{
				parameterModel.MaxLength = (facet.Value as int?);
			}
			if (modelTypeUsage.Facets.TryGetValue("Precision", true, out facet) && facet.Value != null)
			{
				parameterModel.Precision = (byte?)facet.Value;
			}
			if (modelTypeUsage.Facets.TryGetValue("Scale", true, out facet) && facet.Value != null)
			{
				parameterModel.Scale = (byte?)facet.Value;
			}
			if (modelTypeUsage.Facets.TryGetValue("FixedLength", true, out facet) && facet.Value != null && (bool)facet.Value)
			{
				parameterModel.IsFixedLength = new bool?(true);
			}
			if (modelTypeUsage.Facets.TryGetValue("Unicode", true, out facet) && facet.Value != null && !(bool)facet.Value)
			{
				parameterModel.IsUnicode = new bool?(false);
			}
			return parameterModel;
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00022958 File Offset: 0x00020B58
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropProcedureOperation> FindDroppedModificationFunctions()
		{
			return (from esm1 in this._source.EntityContainerMapping.EntitySetMappings
			from mfm1 in esm1.ModificationFunctionMappings
			where !(from esm2 in this._target.EntityContainerMapping.EntitySetMappings
			from mfm2 in esm2.ModificationFunctionMappings
			where mfm1.EntityType.Identity == mfm2.EntityType.Identity
			select mfm2).Any<global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping>()
			from o in new global::System.Data.Entity.Migrations.Model.DropProcedureOperation[]
			{
				new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(mfm1.InsertFunctionMapping.Function), null),
				new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(mfm1.UpdateFunctionMapping.Function), null),
				new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(mfm1.DeleteFunctionMapping.Function), null)
			}
			select o).Concat(from asm1 in this._source.EntityContainerMapping.AssociationSetMappings
			where asm1.ModificationFunctionMapping != null
			where !(from asm2 in this._target.EntityContainerMapping.AssociationSetMappings
			where asm2.ModificationFunctionMapping != null && asm1.ModificationFunctionMapping.AssociationSet.Identity == asm2.ModificationFunctionMapping.AssociationSet.Identity
			select asm2.ModificationFunctionMapping).Any<global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping>()
			from o in new global::System.Data.Entity.Migrations.Model.DropProcedureOperation[]
			{
				new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(asm1.ModificationFunctionMapping.InsertFunctionMapping.Function), null),
				new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(asm1.ModificationFunctionMapping.DeleteFunctionMapping.Function), null)
			}
			select o);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00022A9C File Offset: 0x00020C9C
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameTableOperation> FindRenamedTables(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from p in tablePairs
			where !p.Item1.Table.EqualsIgnoreCase(p.Item2.Table)
			select new global::System.Data.Entity.Migrations.Model.RenameTableOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(p.Item1), p.Item2.Table, null);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00022AF4 File Offset: 0x00020CF4
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.CreateTableOperation> FindAddedTables(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from es in this._target.StoreEntityContainer.EntitySets.Except(from p in tablePairs
			select p.Item2)
			select global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildCreateTableOperation(es, this._target);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00022B4C File Offset: 0x00020D4C
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MoveTableOperation> FindMovedTables(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from p in tablePairs
			where !p.Item1.Schema.EqualsIgnoreCase(p.Item2.Schema)
			select new global::System.Data.Entity.Migrations.Model.MoveTableOperation(new global::System.Data.Entity.Utilities.DatabaseName(p.Item2.Table, p.Item1.Schema).ToString(), p.Item2.Schema, null)
			{
				CreateTableOperation = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildCreateTableOperation(p.Item2, this._target)
			};
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00022B84 File Offset: 0x00020D84
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropTableOperation> FindDroppedTables(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from es in this._source.StoreEntityContainer.EntitySets.Except(from p in tablePairs
			select p.Item1)
			select new global::System.Data.Entity.Migrations.Model.DropTableOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(es), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(es.ElementType), (from p in es.ElementType.Properties
			where global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p).Count > 0
			select p).ToDictionary((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p)), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildCreateTableOperation(es, this._source), null);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00022BDC File Offset: 0x00020DDC
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AlterTableOperation> FindAlteredTables(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from p in tablePairs
			where !global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p.Item1.ElementType).SequenceEqual(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p.Item2.ElementType))
			select this.BuildAlterTableAnnotationsOperation(p.Item1, p.Item2);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00022C14 File Offset: 0x00020E14
		private global::System.Data.Entity.Migrations.Model.AlterTableOperation BuildAlterTableAnnotationsOperation(global::System.Data.Entity.Core.Metadata.Edm.EntitySet sourceTable, global::System.Data.Entity.Core.Metadata.Edm.EntitySet destinationTable)
		{
			global::System.Data.Entity.Migrations.Model.AlterTableOperation operation = new global::System.Data.Entity.Migrations.Model.AlterTableOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(destinationTable), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildAnnotationPairs(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(sourceTable.ElementType), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(destinationTable.ElementType)), null);
			destinationTable.ElementType.Properties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				operation.Columns.Add(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(p, this._target, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, object> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, object> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(a.Value, a.Value))));
			});
			return operation;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00022C80 File Offset: 0x00020E80
		internal static global::System.Collections.Generic.Dictionary<string, object> GetAnnotations(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			return (from a in item.Annotations
			where a.Name.StartsWith("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:", global::System.StringComparison.Ordinal) && !a.Name.EndsWith("Index", global::System.StringComparison.Ordinal)
			select a).ToDictionary((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a) => a.Name.Substring("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:".Length), (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a) => a.Value);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00022CFC File Offset: 0x00020EFC
		internal static global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute GetPrimaryKeyIndexAttribute(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return (from a in entityType.Annotations
			where a.Name == "http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index"
			select a.Value).OfType<global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation>().SelectMany((global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation ia) => ia.Indexes).SingleOrDefault<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>();
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00022D88 File Offset: 0x00020F88
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> FindAlteredPrimaryKeys(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> alteredColumns)
		{
			return from ts in tablePairs
			let t2 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(ts.Item2)
			let pk1 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetPrimaryKeyIndexAttribute(ts.Item1.ElementType) ?? new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute()
			let pk2 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetPrimaryKeyIndexAttribute(ts.Item2.ElementType) ?? new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute()
			where !ts.Item1.ElementType.KeyProperties.SequenceEqual(ts.Item2.ElementType.KeyProperties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p2) => p1.Name.EqualsIgnoreCase(p2.Name) || renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc) => rc.Table.EqualsIgnoreCase(t2) && rc.Name.EqualsIgnoreCase(p1.Name) && rc.NewName.EqualsIgnoreCase(p2.Name))) || ts.Item2.ElementType.KeyProperties.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => alteredColumns.Any((global::System.Data.Entity.Migrations.Model.AlterColumnOperation ac) => ac.Table.EqualsIgnoreCase(t2) && ac.Column.Name.EqualsIgnoreCase(p.Name))) || pk1.Name != pk2.Name || pk1.IsClusteredConfigured != pk2.IsClusteredConfigured || pk1.IsClustered != pk2.IsClustered
			from o in this.BuildChangePrimaryKeyOperations(ts)
			select o;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00022E5E File Offset: 0x0002105E
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> BuildChangePrimaryKeyOperations(global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> tablePair)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> list = (from at in this._source.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>()
			select at.Constraint into c
			where c.FromProperties.SequenceEqual(tablePair.Item1.ElementType.KeyProperties)
			select c).ToList<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in list)
			{
				yield return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildDropForeignKeyOperation(referentialConstraint, this._source);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>.Enumerator enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>.Enumerator);
			global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation(null)
			{
				Table = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(tablePair.Item2)
			};
			tablePair.Item1.ElementType.KeyProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty pr)
			{
				dropPrimaryKeyOperation.Columns.Add(pr.Name);
			});
			global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute primaryKeyIndexAttribute = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetPrimaryKeyIndexAttribute(tablePair.Item1.ElementType);
			if (primaryKeyIndexAttribute != null)
			{
				dropPrimaryKeyOperation.Name = primaryKeyIndexAttribute.Name;
				if (primaryKeyIndexAttribute.IsClusteredConfigured)
				{
					dropPrimaryKeyOperation.IsClustered = primaryKeyIndexAttribute.IsClustered;
				}
			}
			yield return dropPrimaryKeyOperation;
			global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(null)
			{
				Table = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(tablePair.Item2)
			};
			tablePair.Item2.ElementType.KeyProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty pr)
			{
				addPrimaryKeyOperation.Columns.Add(pr.Name);
			});
			global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute primaryKeyIndexAttribute2 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetPrimaryKeyIndexAttribute(tablePair.Item2.ElementType);
			if (primaryKeyIndexAttribute2 != null)
			{
				addPrimaryKeyOperation.Name = primaryKeyIndexAttribute2.Name;
				if (primaryKeyIndexAttribute2.IsClusteredConfigured)
				{
					addPrimaryKeyOperation.IsClustered = primaryKeyIndexAttribute2.IsClustered;
				}
			}
			yield return addPrimaryKeyOperation;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> list2 = (from at in this._target.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>()
			select at.Constraint into c
			where c.FromProperties.SequenceEqual(tablePair.Item2.ElementType.KeyProperties)
			select c).ToList<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint2 in list2)
			{
				yield return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildAddForeignKeyOperation(referentialConstraint2, this._target);
			}
			enumerator = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00022E78 File Offset: 0x00021078
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation> FindAddedForeignKeys(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from at in this._target.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from p in associationTypePairs
			select p.Item2).Concat(from at in associationTypePairs
			where !this.DiffAssociations(at.Item1.Constraint, at.Item2.Constraint, renamedColumns)
			select at.Item2)
			select global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildAddForeignKeyOperation(at.Constraint, this._target);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00022F20 File Offset: 0x00021120
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation> FindDroppedForeignKeys(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from at in this._source.StoreItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Except(from p in associationTypePairs
			select p.Item1).Concat(from at in associationTypePairs
			where !this.DiffAssociations(at.Item1.Constraint, at.Item2.Constraint, renamedColumns)
			select at.Item1)
			select global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildDropForeignKeyOperation(at.Constraint, this._source);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00022FC8 File Offset: 0x000211C8
		private bool DiffAssociations(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint1, global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint2, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			string targetTable = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(this._target.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == referentialConstraint2.DependentEnd.GetEntityType()));
			return referentialConstraint1.ToProperties.SequenceEqual(referentialConstraint2.ToProperties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p2) => p1.Name.EqualsIgnoreCase(p2.Name) || renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc) => rc.Table.EqualsIgnoreCase(targetTable) && rc.Name.EqualsIgnoreCase(p1.Name) && rc.NewName.EqualsIgnoreCase(p2.Name))) && referentialConstraint1.PrincipalEnd.DeleteBehavior == referentialConstraint2.PrincipalEnd.DeleteBehavior;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00023058 File Offset: 0x00021258
		private static global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation BuildAddForeignKeyOperation(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation(null);
			global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildForeignKeyOperation(referentialConstraint, addForeignKeyOperation, modelMetadata);
			referentialConstraint.FromProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty pr)
			{
				addForeignKeyOperation.PrincipalColumns.Add(pr.Name);
			});
			addForeignKeyOperation.CascadeDelete = (referentialConstraint.PrincipalEnd.DeleteBehavior == global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade);
			return addForeignKeyOperation;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000230BC File Offset: 0x000212BC
		private static global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation BuildDropForeignKeyOperation(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation dropForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildAddForeignKeyOperation(referentialConstraint, modelMetadata), null);
			global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildForeignKeyOperation(referentialConstraint, dropForeignKeyOperation, modelMetadata);
			return dropForeignKeyOperation;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000230E0 File Offset: 0x000212E0
		private static void BuildForeignKeyOperation(global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint, global::System.Data.Entity.Migrations.Model.ForeignKeyOperation foreignKeyOperation, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			foreignKeyOperation.PrincipalTable = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(modelMetadata.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == referentialConstraint.PrincipalEnd.GetEntityType()));
			foreignKeyOperation.DependentTable = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(modelMetadata.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == referentialConstraint.DependentEnd.GetEntityType()));
			referentialConstraint.ToProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty pr)
			{
				foreignKeyOperation.DependentColumns.Add(pr.Name);
			});
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00023178 File Offset: 0x00021378
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AddColumnOperation> FindAddedColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from p in tablePairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(p.Item2)
			from c in p.Item2.ElementType.Properties.Except(p.Item1.ElementType.Properties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c2) => c1.Name.EqualsIgnoreCase(c2.Name))
			where !renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation cr) => cr.Table.EqualsIgnoreCase(t) && cr.NewName.EqualsIgnoreCase(c.Name))
			select new global::System.Data.Entity.Migrations.Model.AddColumnOperation(t, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(c, this._target, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(c).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, object> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, object> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(null, a.Value))), null);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00023224 File Offset: 0x00021424
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropColumnOperation> FindDroppedColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from p in tablePairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(p.Item2)
			from c in p.Item1.ElementType.Properties.Except(p.Item2.ElementType.Properties, (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c2) => c1.Name.EqualsIgnoreCase(c2.Name))
			where !renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc) => rc.Table.EqualsIgnoreCase(t) && rc.Name.EqualsIgnoreCase(c.Name))
			select new global::System.Data.Entity.Migrations.Model.DropColumnOperation(t, c.Name, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(c), new global::System.Data.Entity.Migrations.Model.AddColumnOperation(t, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(c, this._source, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(c).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, object> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, object> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(null, a.Value))), null), null);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000232D0 File Offset: 0x000214D0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropColumnOperation> FindOrphanedColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from p in tablePairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(p.Item2)
			from rc1 in renamedColumns
			where rc1.Table.EqualsIgnoreCase(t)
			from c in p.Item1.ElementType.Properties
			where c.Name.EqualsIgnoreCase(rc1.NewName) && !renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc2) => rc2 != rc1 && rc2.Table.EqualsIgnoreCase(rc1.Table) && rc2.Name.EqualsIgnoreCase(rc1.NewName))
			select new global::System.Data.Entity.Migrations.Model.DropColumnOperation(t, c.Name, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(c), new global::System.Data.Entity.Migrations.Model.AddColumnOperation(t, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(c, this._source, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(c).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, object> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, object> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(null, a.Value))), null), null);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000233D0 File Offset: 0x000215D0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> FindAlteredColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from p in tablePairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(p.Item2)
			from p1 in p.Item1.ElementType.Properties
			let p2 = p.Item2.ElementType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => (p1.Name.EqualsIgnoreCase(c.Name) || renamedColumns.Any((global::System.Data.Entity.Migrations.Model.RenameColumnOperation rc) => rc.Table.EqualsIgnoreCase(t) && rc.Name.EqualsIgnoreCase(p1.Name) && rc.NewName.EqualsIgnoreCase(c.Name))) && !this.DiffColumns(p1, c))
			where p2 != null
			select this.BuildAlterColumnOperation(t, p2, this._target, p1, this._source);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000234A0 File Offset: 0x000216A0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> FindSourceIndexes(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet>> tablePairs)
		{
			return from es in this._source.StoreEntityContainer.EntitySets
			let p = tablePairs.SingleOrDefault((global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Data.Entity.Core.Metadata.Edm.EntitySet> p) => p.Item1 == es)
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName((p != null) ? p.Item2 : es)
			from i in global::System.Data.Entity.Infrastructure.ConsolidatedIndex.BuildIndexes(t, from c in es.ElementType.Properties
			select global::System.Tuple.Create<string, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(c.Name, c))
			select i;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00023544 File Offset: 0x00021744
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> FindTargetIndexes()
		{
			return from es in this._target.StoreEntityContainer.EntitySets
			from i in global::System.Data.Entity.Infrastructure.ConsolidatedIndex.BuildIndexes(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(es), from p in es.ElementType.Properties
			select global::System.Tuple.Create<string, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(p.Name, p))
			select i;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x000235A4 File Offset: 0x000217A4
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.CreateIndexOperation> FindAddedIndexes(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> sourceIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> targetIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> alteredColumns, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from i in targetIndexes.Except(sourceIndexes, (global::System.Data.Entity.Infrastructure.ConsolidatedIndex i1, global::System.Data.Entity.Infrastructure.ConsolidatedIndex i2) => global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.IndexesEqual(i1, i2, renamedColumns) && !alteredColumns.Any((global::System.Data.Entity.Migrations.Model.AlterColumnOperation ac) => ac.Table.EqualsIgnoreCase(i2.Table) && i2.Columns.Contains(ac.Column.Name, global::System.StringComparer.OrdinalIgnoreCase)))
			select i.CreateCreateIndexOperation();
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000235FC File Offset: 0x000217FC
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.DropIndexOperation> FindDroppedIndexes(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> sourceIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> targetIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> alteredColumns, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from i in sourceIndexes.Except(targetIndexes, (global::System.Data.Entity.Infrastructure.ConsolidatedIndex i2, global::System.Data.Entity.Infrastructure.ConsolidatedIndex i1) => global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.IndexesEqual(i1, i2, renamedColumns) && !alteredColumns.Any((global::System.Data.Entity.Migrations.Model.AlterColumnOperation ac) => ac.Table.EqualsIgnoreCase(i2.Table) && i2.Columns.Contains(ac.Column.Name, global::System.StringComparer.OrdinalIgnoreCase)))
			select i.CreateDropIndexOperation();
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00023654 File Offset: 0x00021854
		private static bool IndexesEqual(global::System.Data.Entity.Infrastructure.ConsolidatedIndex consolidatedIndex1, global::System.Data.Entity.Infrastructure.ConsolidatedIndex consolidatedIndex2, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return consolidatedIndex1.Table.EqualsIgnoreCase(consolidatedIndex2.Table) && consolidatedIndex1.Index.Equals(consolidatedIndex2.Index) && (from c in consolidatedIndex1.Columns
			select (from rc in renamedColumns
			where rc.Table.EqualsIgnoreCase(consolidatedIndex1.Table) && rc.Name.EqualsIgnoreCase(c)
			select rc.NewName).SingleOrDefault<string>() ?? c).SequenceEqual(consolidatedIndex2.Columns, global::System.StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000236D8 File Offset: 0x000218D8
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameIndexOperation> FindRenamedIndexes(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.CreateIndexOperation> addedIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.DropIndexOperation> droppedIndexes, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.AlterColumnOperation> alteredColumns, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> renamedColumns)
		{
			return from ci1 in addedIndexes.ToList<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>()
			from di in droppedIndexes.ToList<global::System.Data.Entity.Migrations.Model.DropIndexOperation>()
			let ci2 = (global::System.Data.Entity.Migrations.Model.CreateIndexOperation)di.Inverse
			where ci1.Table.EqualsIgnoreCase(ci2.Table) && !ci1.Name.EqualsIgnoreCase(ci2.Name) && ci1.Columns.SequenceEqual(from c in ci2.Columns
			select (from rc in renamedColumns
			where rc.Table.EqualsIgnoreCase(ci2.Table) && rc.Name.EqualsIgnoreCase(c)
			select rc.NewName).SingleOrDefault<string>() ?? c, global::System.StringComparer.OrdinalIgnoreCase) && ci1.IsClustered == ci2.IsClustered && ci1.IsUnique == ci2.IsUnique && (!alteredColumns.Any((global::System.Data.Entity.Migrations.Model.AlterColumnOperation ac) => ac.Table.EqualsIgnoreCase(ci1.Table) && ci1.Columns.Contains(ac.Column.Name, global::System.StringComparer.OrdinalIgnoreCase)) && addedIndexes.Remove(ci1)) && droppedIndexes.Remove(di)
			select new global::System.Data.Entity.Migrations.Model.RenameIndexOperation(ci1.Table, di.Name, ci1.Name, null);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002379C File Offset: 0x0002199C
		private bool DiffColumns(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column2)
		{
			if (column1.Nullable != column2.Nullable)
			{
				return false;
			}
			if (column1.PrimitiveType.PrimitiveTypeKind != column2.PrimitiveType.PrimitiveTypeKind)
			{
				return false;
			}
			if (column1.StoreGeneratedPattern != column2.StoreGeneratedPattern)
			{
				return false;
			}
			if (!(from a in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(column1)
			orderby a.Key
			select a).SequenceEqual(from a in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(column2)
			orderby a.Key
			select a))
			{
				return false;
			}
			if (this._source.ProviderInfo.Equals(this._target.ProviderInfo))
			{
				return column1.TypeName.EqualsIgnoreCase(column2.TypeName) && column1.TypeUsage.EdmEquals(column2.TypeUsage);
			}
			byte? b = column1.Precision;
			int? num = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			b = column2.Precision;
			int? num2 = (b != null) ? new int?((int)b.GetValueOrDefault()) : null;
			if (num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null))
			{
				b = column1.Scale;
				num2 = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
				b = column2.Scale;
				num = ((b != null) ? new int?((int)b.GetValueOrDefault()) : null);
				if (num2.GetValueOrDefault() == num.GetValueOrDefault() & num2 != null == (num != null))
				{
					bool? flag = column1.IsUnicode;
					bool? flag2 = column2.IsUnicode;
					if (flag.GetValueOrDefault() == flag2.GetValueOrDefault() & flag != null == (flag2 != null))
					{
						flag2 = column1.IsFixedLength;
						flag = column2.IsFixedLength;
						return flag2.GetValueOrDefault() == flag.GetValueOrDefault() & flag2 != null == (flag != null);
					}
				}
			}
			return false;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x000239D4 File Offset: 0x00021BD4
		private global::System.Data.Entity.Migrations.Model.AlterColumnOperation BuildAlterColumnOperation(string table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty targetProperty, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata targetModelMetadata, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty sourceProperty, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata sourceModelMetadata)
		{
			global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> dictionary = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildAnnotationPairs(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(sourceProperty), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(targetProperty));
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations = dictionary.ToDictionary((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(a.Value.NewValue, a.Value.OldValue));
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(targetProperty, targetModelMetadata, dictionary);
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel2 = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(sourceProperty, sourceModelMetadata, annotations);
			columnModel2.Name = columnModel.Name;
			return new global::System.Data.Entity.Migrations.Model.AlterColumnOperation(table, columnModel, columnModel.IsNarrowerThan(columnModel2, this._target.ProviderManifest), new global::System.Data.Entity.Migrations.Model.AlterColumnOperation(table, columnModel2, columnModel2.IsNarrowerThan(columnModel, this._target.ProviderManifest), null), null);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00023A90 File Offset: 0x00021C90
		private static global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> BuildAnnotationPairs(global::System.Collections.Generic.IDictionary<string, object> rawSourceAnnotations, global::System.Collections.Generic.IDictionary<string, object> rawTargetAnnotations)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues>();
			foreach (string key in rawTargetAnnotations.Keys.Concat(rawSourceAnnotations.Keys).Distinct<string>())
			{
				if (!rawSourceAnnotations.ContainsKey(key))
				{
					dictionary[key] = new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(null, rawTargetAnnotations[key]);
				}
				else if (!rawTargetAnnotations.ContainsKey(key))
				{
					dictionary[key] = new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(rawSourceAnnotations[key], null);
				}
				else if (!object.Equals(rawSourceAnnotations[key], rawTargetAnnotations[key]))
				{
					dictionary[key] = new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(rawSourceAnnotations[key], rawTargetAnnotations[key]);
				}
			}
			return dictionary;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00023B5C File Offset: 0x00021D5C
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> mappingFragmentPairs, global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs)
		{
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedMappedColumns(mappingFragmentPairs).Concat(this.FindRenamedForeignKeyColumns(associationTypePairs)).Concat(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedDiscriminatorColumns(mappingFragmentPairs)).Distinct(new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>((global::System.Data.Entity.Migrations.Model.RenameColumnOperation c1, global::System.Data.Entity.Migrations.Model.RenameColumnOperation c2) => c1.Table.EqualsIgnoreCase(c2.Table) && c1.Name.EqualsIgnoreCase(c2.Name) && c1.NewName.EqualsIgnoreCase(c2.NewName)));
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00023BB0 File Offset: 0x00021DB0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedMappedColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> mappingFragmentPairs)
		{
			return from mfs in mappingFragmentPairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(mfs.Item2.StoreEntitySet)
			from cr in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedMappedColumns(mfs.Item1, mfs.Item2, t)
			select cr;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00023C28 File Offset: 0x00021E28
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedMappedColumns(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment1, global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2, string table)
		{
			return from cmb1 in mappingFragment1.FlattenedProperties
			from cmb2 in mappingFragment2.FlattenedProperties
			where cmb1.PropertyPath.SequenceEqual(cmb2.PropertyPath, new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p1, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p2) => p1.EdmEquals(p2))) && !cmb1.ColumnProperty.Name.EqualsIgnoreCase(cmb2.ColumnProperty.Name)
			select new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(table, cmb1.ColumnProperty.Name, cmb2.ColumnProperty.Name, null);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00023CB4 File Offset: 0x00021EB4
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedForeignKeyColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.AssociationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> associationTypePairs)
		{
			return from ats in associationTypePairs
			let rc1 = ats.Item1.Constraint
			let rc2 = ats.Item2.Constraint
			from ps in rc1.ToProperties.Zip(rc2.ToProperties)
			where !ps.Key.Name.EqualsIgnoreCase(ps.Value.Name) && (!rc2.DependentEnd.GetEntityType().Properties.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name.EqualsIgnoreCase(ps.Key.Name)) || rc1.DependentEnd.GetEntityType().Properties.Any((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.Name.EqualsIgnoreCase(ps.Value.Name)))
			select new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(this._target.StoreEntityContainer.EntitySets.Single((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.ElementType == rc2.DependentEnd.GetEntityType())), ps.Key.Name, ps.Value.Name, null);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00023D84 File Offset: 0x00021F84
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedDiscriminatorColumns(global::System.Collections.Generic.ICollection<global::System.Tuple<global::System.Data.Entity.Core.Mapping.MappingFragment, global::System.Data.Entity.Core.Mapping.MappingFragment>> mappingFragmentPairs)
		{
			return from mfs in mappingFragmentPairs
			let t = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(mfs.Item2.StoreEntitySet)
			from cr in global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.FindRenamedDiscriminatorColumns(mfs.Item1, mfs.Item2, t)
			select cr;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00023DFC File Offset: 0x00021FFC
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.RenameColumnOperation> FindRenamedDiscriminatorColumns(global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment1, global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2, string table)
		{
			return from c1 in mappingFragment1.Conditions
			from c2 in mappingFragment2.Conditions
			where object.Equals(c1.Value, c2.Value)
			where !c1.Column.Name.EqualsIgnoreCase(c2.Column.Name)
			select new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(table, c1.Column.Name, c2.Column.Name, null);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00023EAC File Offset: 0x000220AC
		private static global::System.Data.Entity.Migrations.Model.CreateTableOperation BuildCreateTableOperation(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata)
		{
			global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = new global::System.Data.Entity.Migrations.Model.CreateTableOperation(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetSchemaQualifiedName(entitySet), global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(entitySet.ElementType), null);
			entitySet.ElementType.Properties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				createTableOperation.Columns.Add(global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(p, modelMetadata, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetAnnotations(p).ToDictionary((global::System.Collections.Generic.KeyValuePair<string, object> a) => a.Key, (global::System.Collections.Generic.KeyValuePair<string, object> a) => new global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues(null, a.Value))));
			});
			global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(null);
			entitySet.ElementType.KeyProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				addPrimaryKeyOperation.Columns.Add(p.Name);
			});
			global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute primaryKeyIndexAttribute = global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.GetPrimaryKeyIndexAttribute(entitySet.ElementType);
			if (primaryKeyIndexAttribute != null)
			{
				addPrimaryKeyOperation.Name = primaryKeyIndexAttribute.Name;
				if (primaryKeyIndexAttribute.IsClusteredConfigured)
				{
					addPrimaryKeyOperation.IsClustered = primaryKeyIndexAttribute.IsClustered;
				}
			}
			createTableOperation.PrimaryKey = addPrimaryKeyOperation;
			return createTableOperation;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00023F78 File Offset: 0x00022178
		private static global::System.Data.Entity.Migrations.Model.ColumnModel BuildColumnModel(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata modelMetadata, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType = modelMetadata.ProviderManifest.GetEdmType(property.TypeUsage);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = modelMetadata.ProviderManifest.GetStoreType(edmType);
			return global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.BuildColumnModel(property, edmType, storeType, annotations);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00023FB0 File Offset: 0x000221B0
		public static global::System.Data.Entity.Migrations.Model.ColumnModel BuildColumnModel(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage conceptualTypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage defaultStoreTypeUsage, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations)
		{
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel = new global::System.Data.Entity.Migrations.Model.ColumnModel(property.PrimitiveType.PrimitiveTypeKind, conceptualTypeUsage);
			columnModel.Name = property.Name;
			columnModel.IsNullable = ((!property.Nullable) ? new bool?(false) : null);
			columnModel.StoreType = ((!property.TypeName.EqualsIgnoreCase(defaultStoreTypeUsage.EdmType.Name)) ? property.TypeName : null);
			columnModel.IsIdentity = (property.IsStoreGeneratedIdentity && global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer._validIdentityTypes.Contains(property.PrimitiveType.PrimitiveTypeKind));
			bool isTimestamp;
			if (property.PrimitiveType.PrimitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary)
			{
				int? maxLength = property.MaxLength;
				int num = 8;
				if (maxLength.GetValueOrDefault() == num & maxLength != null)
				{
					isTimestamp = property.IsStoreGeneratedComputed;
					goto IL_BF;
				}
			}
			isTimestamp = false;
			IL_BF:
			columnModel.IsTimestamp = isTimestamp;
			bool? flag = property.IsUnicode;
			bool flag2 = false;
			columnModel.IsUnicode = ((flag.GetValueOrDefault() == flag2 & flag != null) ? new bool?(false) : null);
			flag = property.IsFixedLength;
			flag2 = true;
			columnModel.IsFixedLength = ((flag.GetValueOrDefault() == flag2 & flag != null) ? new bool?(true) : null);
			columnModel.Annotations = annotations;
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel2 = columnModel;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (property.TypeUsage.Facets.TryGetValue("MaxLength", true, out facet) && !facet.IsUnbounded && !facet.Description.IsConstant)
			{
				columnModel2.MaxLength = (int?)facet.Value;
			}
			if (property.TypeUsage.Facets.TryGetValue("Precision", true, out facet) && !facet.IsUnbounded && !facet.Description.IsConstant)
			{
				columnModel2.Precision = (byte?)facet.Value;
			}
			if (property.TypeUsage.Facets.TryGetValue("Scale", true, out facet) && !facet.IsUnbounded && !facet.Description.IsConstant)
			{
				columnModel2.Scale = (byte?)facet.Value;
			}
			return columnModel2;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x000241B6 File Offset: 0x000223B6
		private static global::System.Data.Entity.Core.Common.DbProviderManifest GetProviderManifest(global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(providerInfo.ProviderInvariantName).GetProviderServices().GetProviderManifest(providerInfo.ProviderManifestToken);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x000241D8 File Offset: 0x000223D8
		private static string GetSchemaQualifiedName(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return new global::System.Data.Entity.Utilities.DatabaseName(entitySet.Table, entitySet.Schema).ToString();
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x000241F0 File Offset: 0x000223F0
		private static string GetSchemaQualifiedName(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return new global::System.Data.Entity.Utilities.DatabaseName(function.FunctionName, function.Schema).ToString();
		}

		// Token: 0x040008A0 RID: 2208
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[] _validIdentityTypes = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
		};

		// Token: 0x040008A1 RID: 2209
		private static readonly global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Migrations.Model.ForeignKeyOperation> _foreignKeyEqualityComparer = new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Migrations.Model.ForeignKeyOperation>((global::System.Data.Entity.Migrations.Model.ForeignKeyOperation fk1, global::System.Data.Entity.Migrations.Model.ForeignKeyOperation fk2) => fk1.Name.EqualsOrdinal(fk2.Name));

		// Token: 0x040008A2 RID: 2210
		private static readonly global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Migrations.Model.IndexOperation> _indexEqualityComparer = new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Data.Entity.Migrations.Model.IndexOperation>((global::System.Data.Entity.Migrations.Model.IndexOperation i1, global::System.Data.Entity.Migrations.Model.IndexOperation i2) => i1.Name.EqualsOrdinal(i2.Name) && i1.Table.EqualsOrdinal(i2.Table));

		// Token: 0x040008A3 RID: 2211
		private global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata _source;

		// Token: 0x040008A4 RID: 2212
		private global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer.ModelMetadata _target;

		// Token: 0x02000760 RID: 1888
		private class ModelMetadata
		{
			// Token: 0x17001021 RID: 4129
			// (get) Token: 0x06005621 RID: 22049 RVA: 0x0013223D File Offset: 0x0013043D
			// (set) Token: 0x06005622 RID: 22050 RVA: 0x00132245 File Offset: 0x00130445
			public global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection EdmItemCollection { get; set; }

			// Token: 0x17001022 RID: 4130
			// (get) Token: 0x06005623 RID: 22051 RVA: 0x0013224E File Offset: 0x0013044E
			// (set) Token: 0x06005624 RID: 22052 RVA: 0x00132256 File Offset: 0x00130456
			public global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection StoreItemCollection { get; set; }

			// Token: 0x17001023 RID: 4131
			// (get) Token: 0x06005625 RID: 22053 RVA: 0x0013225F File Offset: 0x0013045F
			// (set) Token: 0x06005626 RID: 22054 RVA: 0x00132267 File Offset: 0x00130467
			public global::System.Data.Entity.Core.Mapping.EntityContainerMapping EntityContainerMapping { get; set; }

			// Token: 0x17001024 RID: 4132
			// (get) Token: 0x06005627 RID: 22055 RVA: 0x00132270 File Offset: 0x00130470
			// (set) Token: 0x06005628 RID: 22056 RVA: 0x00132278 File Offset: 0x00130478
			public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer StoreEntityContainer { get; set; }

			// Token: 0x17001025 RID: 4133
			// (get) Token: 0x06005629 RID: 22057 RVA: 0x00132281 File Offset: 0x00130481
			// (set) Token: 0x0600562A RID: 22058 RVA: 0x00132289 File Offset: 0x00130489
			public global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest { get; set; }

			// Token: 0x17001026 RID: 4134
			// (get) Token: 0x0600562B RID: 22059 RVA: 0x00132292 File Offset: 0x00130492
			// (set) Token: 0x0600562C RID: 22060 RVA: 0x0013229A File Offset: 0x0013049A
			public global::System.Data.Entity.Infrastructure.DbProviderInfo ProviderInfo { get; set; }
		}
	}
}
