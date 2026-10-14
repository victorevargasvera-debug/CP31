using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Edm.Services
{
	// Token: 0x02000174 RID: 372
	internal class AssociationTypeMappingGenerator : global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x0003AF45 File Offset: 0x00039145
		public AssociationTypeMappingGenerator(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest) : base(providerManifest)
		{
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x0003AF4E File Offset: 0x0003914E
		public void Generate(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			if (associationType.Constraint != null)
			{
				global::System.Data.Entity.ModelConfiguration.Edm.Services.AssociationTypeMappingGenerator.GenerateForeignKeyAssociationType(associationType, databaseMapping);
				return;
			}
			if (associationType.IsManyToMany())
			{
				this.GenerateManyToManyAssociation(associationType, databaseMapping);
				return;
			}
			this.GenerateIndependentAssociationType(associationType, databaseMapping);
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x0003AF7C File Offset: 0x0003917C
		private static void GenerateForeignKeyAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd = associationType.Constraint.DependentEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd = associationType.GetOtherEnd(dependentEnd);
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMappingInHierarchy = global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.GetEntityTypeMappingInHierarchy(databaseMapping, otherEnd.GetEntityType());
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping dependentEntityTypeMapping = global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.GetEntityTypeMappingInHierarchy(databaseMapping, dependentEnd.GetEntityType());
			global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = new global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder(databaseMapping.Database, associationType.Name)
			{
				PrincipalTable = entityTypeMappingInHierarchy.MappingFragments.Single<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table,
				DeleteAction = ((otherEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None) ? otherEnd.DeleteBehavior : global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			};
			dependentEntityTypeMapping.MappingFragments.Single<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table.AddForeignKey(foreignKeyBuilder);
			foreignKeyBuilder.DependentColumns = from dependentProperty in associationType.Constraint.ToProperties
			select dependentEntityTypeMapping.GetPropertyMapping(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				dependentProperty
			}).ColumnProperty;
			foreignKeyBuilder.SetAssociationType(associationType);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x0003B04C File Offset: 0x0003924C
		private void GenerateManyToManyAssociation(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = associationType.SourceEnd.GetEntityType();
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = associationType.TargetEnd.GetEntityType();
			global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable = databaseMapping.Database.AddTable(entityType.Name + entityType2.Name);
			global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = global::System.Data.Entity.ModelConfiguration.Edm.Services.AssociationTypeMappingGenerator.GenerateAssociationSetMapping(associationType, databaseMapping, associationType.SourceEnd, associationType.TargetEnd, dependentTable);
			this.GenerateIndependentForeignKeyConstraint(databaseMapping, entityType, entityType2, dependentTable, associationSetMapping, associationSetMapping.SourceEndMapping, associationType.SourceEnd.Name, null, true);
			this.GenerateIndependentForeignKeyConstraint(databaseMapping, entityType2, entityType, dependentTable, associationSetMapping, associationSetMapping.TargetEndMapping, associationType.TargetEnd.Name, null, true);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0003B0E0 File Offset: 0x000392E0
		private void GenerateIndependentAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd;
			if (!associationType.TryGuessPrincipalAndDependentEnds(out sourceEnd, out targetEnd))
			{
				if (!associationType.IsPrincipalConfigured())
				{
					throw global::System.Data.Entity.Resources.Error.UnableToDeterminePrincipal(associationType.SourceEnd.GetEntityType().GetClrType(), associationType.TargetEnd.GetEntityType().GetClrType());
				}
				sourceEnd = associationType.SourceEnd;
				targetEnd = associationType.TargetEnd;
			}
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMappingInHierarchy = global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.GetEntityTypeMappingInHierarchy(databaseMapping, targetEnd.GetEntityType());
			global::System.Data.Entity.Core.Metadata.Edm.EntityType table = entityTypeMappingInHierarchy.MappingFragments.First<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table;
			global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = global::System.Data.Entity.ModelConfiguration.Edm.Services.AssociationTypeMappingGenerator.GenerateAssociationSetMapping(associationType, databaseMapping, sourceEnd, targetEnd, table);
			this.GenerateIndependentForeignKeyConstraint(databaseMapping, sourceEnd.GetEntityType(), targetEnd.GetEntityType(), table, associationSetMapping, associationSetMapping.SourceEndMapping, associationType.Name, sourceEnd, false);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in targetEnd.GetEntityType().KeyProperties())
			{
				associationSetMapping.TargetEndMapping.AddPropertyMapping(new global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping(edmProperty, entityTypeMappingInHierarchy.GetPropertyMapping(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
				{
					edmProperty
				}).ColumnProperty));
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0003B1F4 File Offset: 0x000393F4
		private static global::System.Data.Entity.Core.Mapping.AssociationSetMapping GenerateAssociationSetMapping(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentEnd, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable)
		{
			global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = databaseMapping.AddAssociationSetMapping(databaseMapping.Model.GetAssociationSet(associationType), databaseMapping.Database.GetEntitySet(dependentTable));
			associationSetMapping.StoreEntitySet = databaseMapping.Database.GetEntitySet(dependentTable);
			associationSetMapping.SourceEndMapping.AssociationEnd = principalEnd;
			associationSetMapping.TargetEndMapping.AssociationEnd = dependentEnd;
			return associationSetMapping;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0003B24C File Offset: 0x0003944C
		private void GenerateIndependentForeignKeyConstraint(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable, global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Mapping.EndPropertyMapping associationEndMapping, string name, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd, bool isPrimaryKeyColumn = false)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType table = global::System.Data.Entity.ModelConfiguration.Edm.Services.StructuralTypeMappingGenerator.GetEntityTypeMappingInHierarchy(databaseMapping, principalEntityType).MappingFragments.Single<global::System.Data.Entity.Core.Mapping.MappingFragment>().Table;
			global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = new global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder(databaseMapping.Database, name)
			{
				PrincipalTable = table,
				DeleteAction = ((associationEndMapping.AssociationEnd.DeleteBehavior != global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None) ? associationEndMapping.AssociationEnd.DeleteBehavior : global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None)
			};
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty principalNavigationProperty = databaseMapping.Model.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => e.DeclaredNavigationProperties).SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty n) => n.ResultEnd == principalEnd);
			dependentTable.AddForeignKey(foreignKeyBuilder);
			foreignKeyBuilder.DependentColumns = this.GenerateIndependentForeignKeyColumns(principalEntityType, dependentEntityType, associationSetMapping, associationEndMapping, dependentTable, isPrimaryKeyColumn, principalNavigationProperty);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0003B318 File Offset: 0x00039518
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GenerateIndependentForeignKeyColumns(global::System.Data.Entity.Core.Metadata.Edm.EntityType principalEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentEntityType, global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Mapping.EndPropertyMapping associationEndMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable, bool isPrimaryKeyColumn, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty principalNavigationProperty)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property in principalEntityType.KeyProperties())
			{
				string columnName = ((principalNavigationProperty != null) ? principalNavigationProperty.Name : principalEntityType.Name) + "_" + property.Name;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty foreignKeyColumn = base.MapTableColumn(property, columnName, false);
				dependentTable.AddColumn(foreignKeyColumn);
				if (isPrimaryKeyColumn)
				{
					dependentTable.AddKeyMember(foreignKeyColumn);
				}
				foreignKeyColumn.Nullable = (associationEndMapping.AssociationEnd.IsOptional() || (associationEndMapping.AssociationEnd.IsRequired() && dependentEntityType.BaseType != null));
				foreignKeyColumn.StoreGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None;
				yield return foreignKeyColumn;
				associationEndMapping.AddPropertyMapping(new global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping(property, foreignKeyColumn));
				if (foreignKeyColumn.Nullable)
				{
					associationSetMapping.AddCondition(new global::System.Data.Entity.Core.Mapping.IsNullConditionMapping(foreignKeyColumn, false));
				}
				foreignKeyColumn = null;
				property = null;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = null;
			yield break;
			yield break;
		}
	}
}
