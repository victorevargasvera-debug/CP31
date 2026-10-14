using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Edm.Services;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x0200020E RID: 526
	internal class EntityMappingConfiguration
	{
		// Token: 0x06001BDC RID: 7132 RVA: 0x0004C440 File Offset: 0x0004A640
		internal EntityMappingConfiguration()
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0004C474 File Offset: 0x0004A674
		private EntityMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration source)
		{
			this._tableName = source._tableName;
			this.MapInheritedProperties = source.MapInheritedProperties;
			if (source._properties != null)
			{
				this._properties = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>(source._properties);
			}
			this._valueConditions.AddRange(from c in source._valueConditions
			select c.Clone(this));
			this._notNullConditions.AddRange(from c in source._notNullConditions
			select c.Clone(this));
			source._primitivePropertyConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> c)
			{
				this._primitivePropertyConfigurations.Add(c.Key, c.Value.Clone());
			});
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> item in source._annotations)
			{
				this._annotations.Add(item);
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0004C584 File Offset: 0x0004A784
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration(this);
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0004C58C File Offset: 0x0004A78C
		// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x0004C594 File Offset: 0x0004A794
		public bool MapInheritedProperties { get; set; }

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0004C59D File Offset: 0x0004A79D
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x0004C5A5 File Offset: 0x0004A7A5
		public global::System.Data.Entity.Utilities.DatabaseName TableName
		{
			get
			{
				return this._tableName;
			}
			set
			{
				this._tableName = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0004C5AE File Offset: 0x0004A7AE
		public global::System.Collections.Generic.IDictionary<string, object> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0004C5B6 File Offset: 0x0004A7B6
		public virtual void SetAnnotation(string name, object value)
		{
			if (!name.IsValidUndottedName())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BadAnnotationName(name));
			}
			this._annotations[name] = value;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0004C5D9 File Offset: 0x0004A7D9
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0004C5E1 File Offset: 0x0004A7E1
		internal global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> Properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				if (this._properties == null)
				{
					this._properties = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>();
				}
				value.Each(new global::System.Action<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>(this.Property));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0004C608 File Offset: 0x0004A808
		internal global::System.Collections.Generic.IDictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> PrimitivePropertyConfigurations
		{
			get
			{
				return this._primitivePropertyConfigurations;
			}
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0004C610 File Offset: 0x0004A810
		internal TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath, global::System.Func<TPrimitivePropertyConfiguration> primitivePropertyConfigurationCreator) where TPrimitivePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
		{
			if (this._properties == null)
			{
				this._properties = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>();
			}
			this.Property(propertyPath);
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration;
			if (!this._primitivePropertyConfigurations.TryGetValue(propertyPath, out primitivePropertyConfiguration))
			{
				this._primitivePropertyConfigurations.Add(propertyPath, primitivePropertyConfiguration = primitivePropertyConfigurationCreator());
			}
			return (TPrimitivePropertyConfiguration)((object)primitivePropertyConfiguration);
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0004C668 File Offset: 0x0004A868
		private void Property(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath property)
		{
			if (!(from pp in this._properties
			where pp.SequenceEqual(property)
			select pp).Any<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>())
			{
				this._properties.Add(property);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0004C6B1 File Offset: 0x0004A8B1
		public global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration> ValueConditions
		{
			get
			{
				return this._valueConditions;
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		public void AddValueCondition(global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration valueCondition)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration valueConditionConfiguration = this.ValueConditions.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration vc) => vc.Discriminator.Equals(valueCondition.Discriminator, global::System.StringComparison.Ordinal));
			if (valueConditionConfiguration == null)
			{
				this.ValueConditions.Add(valueCondition);
				return;
			}
			valueConditionConfiguration.Value = valueCondition.Value;
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x0004C714 File Offset: 0x0004A914
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0004C71C File Offset: 0x0004A91C
		public global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration> NullabilityConditions
		{
			get
			{
				return this._notNullConditions;
			}
			set
			{
				value.Each(new global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration>(this.AddNullabilityCondition));
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0004C730 File Offset: 0x0004A930
		public void AddNullabilityCondition(global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration notNullConditionConfiguration)
		{
			if (!this.NullabilityConditions.Contains(notNullConditionConfiguration))
			{
				this.NullabilityConditions.Add(notNullConditionConfiguration);
			}
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0004C74C File Offset: 0x0004A94C
		public bool MapsAnyInheritedProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> properties = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>();
			if (this.Properties != null)
			{
				this.Properties.Each(delegate(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath p)
				{
					properties.AddRange(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.PropertyPathToEdmPropertyPath(p, entityType));
				});
			}
			return this.MapInheritedProperties || properties.Any((global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath x) => !entityType.KeyProperties().Contains(x.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()) && !entityType.DeclaredProperties.Contains(x.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()));
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0004C7B4 File Offset: 0x0004A9B4
		public void Configure(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, ref global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, bool isMappingAnyInheritedProperty, int configurationIndex, int configurationCount, global::System.Collections.Generic.IDictionary<string, object> commonAnnotations)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType baseType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
			bool flag = baseType == null && configurationIndex == 0;
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = this.FindOrCreateTypeMappingFragment(databaseMapping, ref entityTypeMapping, configurationIndex, entityType, providerManifest);
			global::System.Data.Entity.Core.Metadata.Edm.EntityType table = mappingFragment.Table;
			bool flag2;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this.FindOrCreateTargetTable(databaseMapping, mappingFragment, entityType, table, out flag2);
			bool isSharingTableWithBase = this.DiscoverIsSharingWithBase(databaseMapping, entityType, entityType2);
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> hashSet = this.DiscoverAllMappingsToContain(databaseMapping, entityType, entityType2, isSharingTableWithBase);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> list = mappingFragment.ColumnMappings.ToList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
			using (global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>.Enumerator enumerator = hashSet.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath propertyPath = enumerator.Current;
					global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder = mappingFragment.ColumnMappings.SingleOrDefault((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.SequenceEqual(propertyPath));
					if (columnMappingBuilder == null)
					{
						throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_DuplicateMappedProperty(entityType.Name, propertyPath.ToString());
					}
					list.Remove(columnMappingBuilder);
				}
			}
			if (!flag)
			{
				bool isSplitting;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindParentTable(databaseMapping, table, entityTypeMapping, entityType2, isMappingAnyInheritedProperty, configurationIndex, configurationCount, out isSplitting);
				if (entityType3 != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.DatabaseOperations.AddTypeConstraint(databaseMapping.Database, entityType, entityType3, entityType2, isSplitting);
				}
			}
			if (table != entityType2)
			{
				if (this.Properties == null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.AssociationMappingOperations.MoveAllDeclaredAssociationSetMappings(databaseMapping, entityType, table, entityType2, !flag2);
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.MoveAllDeclaredForeignKeyConstraintsForPrimaryKeyColumns(entityType, table, entityType2);
				}
				if (isMappingAnyInheritedProperty)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> baseTables = from mf in databaseMapping.GetEntityTypeMappings(baseType).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments)
					select mf.Table;
					global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping asm) => asm.AssociationSetMappings).FirstOrDefault((global::System.Data.Entity.Core.Mapping.AssociationSetMapping a) => baseTables.Contains(a.Table) && (baseType == a.AssociationSet.ElementType.SourceEnd.GetEntityType() || baseType == a.AssociationSet.ElementType.TargetEnd.GetEntityType()));
					if (associationSetMapping != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationType elementType = associationSetMapping.AssociationSet.ElementType;
						throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_TPCWithIAsOnNonLeafType(elementType.Name, elementType.SourceEnd.GetEntityType().Name, elementType.TargetEnd.GetEntityType().Name);
					}
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.CopyAllForeignKeyConstraintsForPrimaryKeyColumns(databaseMapping.Database, table, entityType2);
				}
			}
			if (list.Any<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType extraTable = null;
				if (configurationIndex < configurationCount - 1)
				{
					global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm2 = list.First<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
					extraTable = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindTableForTemporaryExtraPropertyMapping(databaseMapping, entityType, table, entityType2, pm2);
					global::System.Data.Entity.Core.Mapping.MappingFragment toFragment = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.CreateTypeMappingFragment(entityTypeMapping, mappingFragment, databaseMapping.Database.GetEntitySet(extraTable));
					bool requiresUpdate = extraTable != table;
					using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder propertyMappingBuilder = enumerator2.Current;
							global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.MovePropertyMapping(databaseMapping, entitySets, mappingFragment, toFragment, propertyMappingBuilder, requiresUpdate, true);
						}
						goto IL_3BA;
					}
				}
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType4 = null;
				global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__5;
				foreach (global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder2 in list)
				{
					extraTable = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindTableForExtraPropertyMapping(databaseMapping, entityType, table, entityType2, ref entityType4, columnMappingBuilder2);
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = entityTypeMapping.MappingFragments;
					global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
					if ((predicate = <>9__5) == null)
					{
						predicate = (<>9__5 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => tmf.Table == extraTable));
					}
					global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment2 = mappingFragments.SingleOrDefault(predicate);
					if (mappingFragment2 == null)
					{
						mappingFragment2 = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.CreateTypeMappingFragment(entityTypeMapping, mappingFragment, databaseMapping.Database.GetEntitySet(extraTable));
						mappingFragment2.SetIsUnmappedPropertiesFragment(true);
					}
					if (extraTable == table)
					{
						global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.CopyDefaultDiscriminator(mappingFragment, mappingFragment2);
					}
					bool requiresUpdate2 = extraTable != table;
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.MovePropertyMapping(databaseMapping, entitySets, mappingFragment, mappingFragment2, columnMappingBuilder2, requiresUpdate2, true);
				}
			}
			IL_3BA:
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.UpdatePropertyMappings(databaseMapping, entitySets, table, mappingFragment, !flag2);
			this.ConfigureDefaultDiscriminator(entityType, mappingFragment);
			this.ConfigureConditions(databaseMapping, entityType, mappingFragment, providerManifest);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.UpdateConditions(databaseMapping.Database, table, mappingFragment);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.UpdatePrincipalTables(databaseMapping, entityType, table, entityType2, isMappingAnyInheritedProperty);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.CleanupUnmappedArtifacts(databaseMapping, table);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.CleanupUnmappedArtifacts(databaseMapping, entityType2);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.ConfigureAnnotations(entityType2, commonAnnotations);
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.ConfigureAnnotations(entityType2, this._annotations);
			entityType2.SetConfiguration(this);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0004CC0C File Offset: 0x0004AE0C
		private static void ConfigureAnnotations(global::System.Data.Entity.Core.Metadata.Edm.EdmType toTable, global::System.Collections.Generic.IDictionary<string, object> annotations)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator = annotations.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Collections.Generic.KeyValuePair<string, object> annotation = enumerator.Current;
					string name = "http://schemas.microsoft.com/ado/2013/11/edm/customannotation:" + annotation.Key;
					global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = toTable.Annotations.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a) => a.Name == name && !object.Equals(a.Value, annotation.Value));
					if (metadataProperty != null)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingTypeAnnotation(annotation.Key, annotation.Value, metadataProperty.Value, toTable.Name));
					}
					toTable.AddAnnotation(name, annotation.Value);
				}
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0004CCD8 File Offset: 0x0004AED8
		internal void ConfigurePropertyMappings(global::System.Collections.Generic.IList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> propertyMappings, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool allowOverride = false)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> keyValuePair in this._primitivePropertyConfigurations)
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath = keyValuePair.Key;
				keyValuePair.Value.Configure(from pm in propertyMappings
				where propertyPath.Equals(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(from p in pm.Item1.PropertyPath.Skip(pm.Item1.PropertyPath.Count - propertyPath.Count)
				select p.GetClrPropertyInfo())) && object.Equals(this.TableName, pm.Item2.GetTableName())
				select pm, providerManifest, allowOverride, true);
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0004CD60 File Offset: 0x0004AF60
		private void ConfigureDefaultDiscriminator(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			if (this.ValueConditions.Any<global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration>() || this.NullabilityConditions.Any<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = fragment.RemoveDefaultDiscriminatorCondition();
				if (edmProperty != null && entityType.BaseType != null)
				{
					edmProperty.Nullable = true;
				}
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0004CDA0 File Offset: 0x0004AFA0
		private static void CopyDefaultDiscriminator(global::System.Data.Entity.Core.Mapping.MappingFragment fromFragment, global::System.Data.Entity.Core.Mapping.MappingFragment toFragment)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty discriminatorColumn = fromFragment.GetDefaultDiscriminator();
			if (discriminatorColumn != null)
			{
				global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping = fromFragment.ColumnConditions.SingleOrDefault((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc) => cc.Column == discriminatorColumn);
				if (conditionPropertyMapping != null)
				{
					toFragment.AddDiscriminatorCondition(conditionPropertyMapping.Column, conditionPropertyMapping.Value);
					toFragment.SetDefaultDiscriminator(conditionPropertyMapping.Column);
				}
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0004CE00 File Offset: 0x0004B000
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType FindTableForTemporaryExtraPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2;
			if (fromTable == toTable)
			{
				entityType2 = databaseMapping.Database.AddTable(entityType.Name, fromTable);
			}
			else if (entityType.BaseType == null)
			{
				entityType2 = fromTable;
			}
			else
			{
				entityType2 = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindBaseTableForExtraPropertyMapping(databaseMapping, entityType, pm);
				if (entityType2 == null)
				{
					entityType2 = fromTable;
				}
			}
			return entityType2;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0004CE44 File Offset: 0x0004B044
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType FindTableForExtraPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, ref global::System.Data.Entity.Core.Metadata.Edm.EntityType unmappedTable, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindBaseTableForExtraPropertyMapping(databaseMapping, entityType, pm);
			if (entityType2 == null)
			{
				if (fromTable != toTable && entityType.BaseType == null)
				{
					return fromTable;
				}
				if (unmappedTable == null)
				{
					unmappedTable = databaseMapping.Database.AddTable(fromTable.Name, fromTable);
				}
				entityType2 = unmappedTable;
			}
			return entityType2;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0004CE8C File Offset: 0x0004B08C
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType FindBaseTableForExtraPropertyMapping(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
			global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = null;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__0;
			while (entityType2 != null && mappingFragment == null)
			{
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityType2);
				if (entityTypeMapping != null)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = entityTypeMapping.MappingFragments;
					global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = delegate(global::System.Data.Entity.Core.Mapping.MappingFragment f)
						{
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings = f.ColumnMappings;
							global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate2;
							if ((predicate2 = <>9__1) == null)
							{
								predicate2 = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder bpm) => bpm.PropertyPath.SequenceEqual(pm.PropertyPath)));
							}
							return columnMappings.Any(predicate2);
						});
					}
					mappingFragment = mappingFragments.SingleOrDefault(predicate);
					if (mappingFragment != null)
					{
						return mappingFragment.Table;
					}
				}
				entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType2.BaseType;
			}
			return null;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0004CF0C File Offset: 0x0004B10C
		private bool DiscoverIsSharingWithBase(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable)
		{
			bool flag = false;
			if (entityType.BaseType != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = entityType.BaseType;
				bool flag2 = false;
				global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__1;
				while (baseType != null && !flag)
				{
					global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = databaseMapping.GetEntityTypeMappings((global::System.Data.Entity.Core.Metadata.Edm.EntityType)baseType);
					if (entityTypeMappings.Any<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>())
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> source = entityTypeMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping m) => m.MappingFragments);
						global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
						if ((predicate = <>9__1) == null)
						{
							predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => tmf.Table == toTable));
						}
						flag = source.Any(predicate);
						flag2 = true;
					}
					baseType = baseType.BaseType;
				}
				if (!flag2)
				{
					flag = (this.TableName == null || string.IsNullOrWhiteSpace(this.TableName.Name));
				}
			}
			return flag;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0004CFD4 File Offset: 0x0004B1D4
		private static global::System.Data.Entity.Core.Metadata.Edm.EntityType FindParentTable(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool isMappingInheritedProperties, int configurationIndex, int configurationCount, out bool isSplitting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			isSplitting = false;
			if ((entityTypeMapping.UsesOtherTables(toTable) || configurationCount > 1) && configurationIndex != 0)
			{
				entityType = entityTypeMapping.GetPrimaryTable();
				isSplitting = true;
			}
			if (entityType == null && fromTable != toTable && !isMappingInheritedProperties)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = entityTypeMapping.EntityType.BaseType;
				while (baseType != null && entityType == null)
				{
					global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping2 = databaseMapping.GetEntityTypeMappings((global::System.Data.Entity.Core.Metadata.Edm.EntityType)baseType).FirstOrDefault<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
					if (entityTypeMapping2 != null)
					{
						entityType = entityTypeMapping2.GetPrimaryTable();
					}
					baseType = baseType.BaseType;
				}
			}
			return entityType;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0004D048 File Offset: 0x0004B248
		private global::System.Data.Entity.Core.Mapping.MappingFragment FindOrCreateTypeMappingFragment(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, ref global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, int configurationIndex, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (entityTypeMapping == null)
			{
				new global::System.Data.Entity.ModelConfiguration.Edm.Services.TableMappingGenerator(providerManifest).Generate(entityType, databaseMapping);
				entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityType);
				configurationIndex = 0;
			}
			global::System.Data.Entity.Core.Mapping.MappingFragment result;
			if (configurationIndex < entityTypeMapping.MappingFragments.Count)
			{
				result = entityTypeMapping.MappingFragments[configurationIndex];
			}
			else
			{
				if (this.MapInheritedProperties)
				{
					throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_DuplicateMapInheritedProperties(entityType.Name);
				}
				if (this.Properties == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_DuplicateMappedProperties(entityType.Name);
				}
				global::System.Func<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath, bool> <>9__1;
				this.Properties.Each(delegate(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath p)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> source = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.PropertyPathToEdmPropertyPath(p, entityType);
					global::System.Func<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath pp) => !entityType.KeyProperties().Contains(pp.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())));
					}
					if (source.Any(predicate))
					{
						throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_DuplicateMappedProperty(entityType.Name, p.ToString());
					}
				});
				global::System.Data.Entity.Core.Metadata.Edm.EntityType table = entityTypeMapping.MappingFragments[0].Table;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = databaseMapping.Database.AddTable(table.Name, table);
				result = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingOperations.CreateTypeMappingFragment(entityTypeMapping, entityTypeMapping.MappingFragments[0], databaseMapping.Database.GetEntitySet(entityType2));
			}
			return result;
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0004D140 File Offset: 0x0004B340
		private global::System.Data.Entity.Core.Metadata.Edm.EntityType FindOrCreateTargetTable(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, out bool isTableSharing)
		{
			isTableSharing = false;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2;
			if (this.TableName == null)
			{
				entityType2 = fragment.Table;
			}
			else
			{
				entityType2 = databaseMapping.Database.FindTableByName(this.TableName);
				if (entityType2 == null)
				{
					if (entityType.BaseType == null)
					{
						entityType2 = fragment.Table;
					}
					else
					{
						entityType2 = databaseMapping.Database.AddTable(this.TableName.Name, fromTable);
					}
				}
				isTableSharing = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.UpdateColumnNamesForTableSharing(databaseMapping, entityType, entityType2, fragment);
				fragment.TableSet = databaseMapping.Database.GetEntitySet(entityType2);
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> enumerator = (from cm in fragment.ColumnMappings
				where cm.ColumnProperty.IsPrimaryKeyColumn
				select cm).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMapping = enumerator.Current;
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = entityType2.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => string.Equals(c.Name, columnMapping.ColumnProperty.Name, global::System.StringComparison.Ordinal));
						columnMapping.ColumnProperty = (edmProperty ?? columnMapping.ColumnProperty);
					}
				}
				entityType2.SetTableName(this.TableName);
			}
			return entityType2;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0004D26C File Offset: 0x0004B46C
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> DiscoverAllMappingsToContain(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool isSharingTableWithBase)
		{
			global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> mappingsToContain = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>();
			entityType.KeyProperties().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				mappingsToContain.AddRange(p.ToPropertyPathList());
			});
			if (this.MapInheritedProperties)
			{
				entityType.Properties.Except(entityType.DeclaredProperties).Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
				{
					mappingsToContain.AddRange(p.ToPropertyPathList());
				});
			}
			if (isSharingTableWithBase)
			{
				global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> baseMappingsToContain = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = null;
				global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = null;
				global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__4;
				while (entityType2 != null && entityTypeMapping == null)
				{
					entityTypeMapping = databaseMapping.GetEntityTypeMapping((global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType);
					if (entityTypeMapping != null)
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> mappingFragments = entityTypeMapping.MappingFragments;
						global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
						if ((predicate = <>9__4) == null)
						{
							predicate = (<>9__4 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => tmf.Table == toTable));
						}
						mappingFragment = mappingFragments.SingleOrDefault(predicate);
					}
					if (mappingFragment == null)
					{
						entityType2.DeclaredProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
						{
							baseMappingsToContain.AddRange(p.ToPropertyPathList());
						});
					}
					entityType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType2.BaseType;
				}
				if (mappingFragment != null)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder in mappingFragment.ColumnMappings)
					{
						mappingsToContain.Add(new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath(columnMappingBuilder.PropertyPath));
					}
				}
				mappingsToContain.AddRange(baseMappingsToContain);
			}
			if (this.Properties == null)
			{
				entityType.DeclaredProperties.Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
				{
					mappingsToContain.AddRange(p.ToPropertyPathList());
				});
			}
			else
			{
				this.Properties.Each(delegate(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath p)
				{
					mappingsToContain.AddRange(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.PropertyPathToEdmPropertyPath(p, entityType));
				});
			}
			return mappingsToContain;
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0004D440 File Offset: 0x0004B640
		private void ConfigureConditions(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this.ValueConditions.Any<global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration>() || this.NullabilityConditions.Any<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration>())
			{
				fragment.ClearConditions();
				foreach (global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration valueConditionConfiguration in this.ValueConditions)
				{
					valueConditionConfiguration.Configure(databaseMapping, fragment, entityType, providerManifest);
				}
				foreach (global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration notNullConditionConfiguration in this.NullabilityConditions)
				{
					notNullConditionConfiguration.Configure(databaseMapping, fragment, entityType);
				}
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
		internal static void CleanupUnmappedArtifacts(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			global::System.Data.Entity.Core.Mapping.AssociationSetMapping[] source = (from asm in databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.AssociationSetMappings)
			where asm.Table == table
			select asm).ToArray<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>();
			global::System.Data.Entity.Core.Mapping.MappingFragment[] source2 = (from f in databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.EntitySetMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments)
			where f.Table == table
			select f).ToArray<global::System.Data.Entity.Core.Mapping.MappingFragment>();
			if (!source.Any<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>() && !source2.Any<global::System.Data.Entity.Core.Mapping.MappingFragment>())
			{
				databaseMapping.Database.RemoveEntityType(table);
				(from t in databaseMapping.Database.AssociationTypes
				where t.SourceEnd.GetEntityType() == table || t.TargetEnd.GetEntityType() == table
				select t).ToArray<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.AssociationType t)
				{
					databaseMapping.Database.RemoveAssociationType(t);
				});
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] array = table.Properties.ToArray<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column = array[i];
				if (source2.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment f) => f.ColumnMappings).All((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.ColumnProperty != column))
				{
					if (source2.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment f) => f.ColumnConditions).All((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc) => cc.Column != column))
					{
						if (source.SelectMany((global::System.Data.Entity.Core.Mapping.AssociationSetMapping am) => am.SourceEndMapping.PropertyMappings).All((global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping pm) => pm.Column != column))
						{
							if (source.SelectMany((global::System.Data.Entity.Core.Mapping.AssociationSetMapping am) => am.SourceEndMapping.PropertyMappings).All((global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping pm) => pm.Column != column))
							{
								global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.RemoveAllForeignKeyConstraintsForColumn(table, column, databaseMapping);
								global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.RemoveColumn(table, column);
							}
						}
					}
				}
			}
			(from fk in table.ForeignKeyBuilders
			where fk.PrincipalTable == table && fk.DependentColumns.SequenceEqual(table.KeyProperties)
			select fk).ToArray<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>().Each(new global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>(table.RemoveForeignKey));
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0004D7D4 File Offset: 0x0004B9D4
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> PropertyPathToEdmPropertyPath(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath path, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = entityType;
			int i;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> <>9__0;
			int j;
			for (i = 0; i < path.Count; i = j + 1)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> source = structuralType.Members.OfType<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo().IsSameAs(path[i])));
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = source.SingleOrDefault(predicate);
				if (edmProperty == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_CannotMapIgnoredProperty(entityType.Name, path.ToString());
				}
				list.Add(edmProperty);
				if (edmProperty.IsComplexType)
				{
					structuralType = edmProperty.ComplexType;
				}
				j = i;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = list.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			if (edmProperty2.IsUnderlyingPrimitiveType)
			{
				return new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath[]
				{
					new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath(list)
				};
			}
			if (edmProperty2.IsComplexType)
			{
				list.Remove(edmProperty2);
				return edmProperty2.ToPropertyPathList(list);
			}
			return new global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath[]
			{
				global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath.Empty
			};
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> FindAllTypeMappingsUsingTable(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityContainerMapping> entityContainerMappings = databaseMapping.EntityContainerMappings;
			for (int i = 0; i < entityContainerMappings.Count; i++)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntitySetMapping> list2 = entityContainerMappings[i].EntitySetMappings.ToList<global::System.Data.Entity.Core.Mapping.EntitySetMapping>();
				for (int j = 0; j < list2.Count; j++)
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = list2[j].EntityTypeMappings;
					for (int k = 0; k < entityTypeMappings.Count; k++)
					{
						global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = entityTypeMappings[k];
						global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = entityTypeMapping.EntityType.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration;
						for (int l = 0; l < entityTypeMapping.MappingFragments.Count; l++)
						{
							bool flag = entityTypeConfiguration != null && entityTypeConfiguration.IsTableNameConfigured;
							if ((!flag && entityTypeMapping.MappingFragments[l].Table == toTable) || (flag && global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.IsTableNameEqual(toTable, entityTypeConfiguration.GetTableName())))
							{
								list.Add(entityTypeMapping);
								break;
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0004D9E0 File Offset: 0x0004BBE0
		private static bool IsTableNameEqual(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Utilities.DatabaseName otherTableName)
		{
			global::System.Data.Entity.Utilities.DatabaseName tableName = table.GetTableName();
			if (tableName != null)
			{
				return otherTableName.Equals(tableName);
			}
			return otherTableName.Name.Equals(table.Name, global::System.StringComparison.Ordinal) && otherTableName.Schema == null;
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0004DA20 File Offset: 0x0004BC20
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> FindAllOneToOneFKAssociationTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType candidateType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in model.Containers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet> associationSets = entityContainer.AssociationSets;
				for (int i = 0; i < associationSets.Count; i++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = associationSets[i];
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember sourceEnd = associationSet.ElementType.SourceEnd;
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd = associationSet.ElementType.TargetEnd;
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = sourceEnd.GetEntityType();
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 = targetEnd.GetEntityType();
					if (associationSet.ElementType.Constraint != null && sourceEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && targetEnd.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One && ((entityType2 == entityType && entityType3 == candidateType) || (entityType3 == entityType && entityType2 == candidateType)))
					{
						list.Add(associationSet.ElementType);
					}
				}
			}
			return list;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0004DB08 File Offset: 0x0004BD08
		private static bool UpdateColumnNamesForTableSharing(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> list = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindAllTypeMappingsUsingTable(databaseMapping, toTable);
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>>();
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping in list)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = entityTypeMapping.EntityType;
				if (entityType != entityType2)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> enumerable = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.FindAllOneToOneFKAssociationTypes(databaseMapping.Model, entityType, entityType2);
					global::System.Data.Entity.Core.Metadata.Edm.EntityType rootType = entityType2.GetRootType();
					if (!dictionary.ContainsKey(rootType))
					{
						dictionary.Add(rootType, enumerable.ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>());
					}
					else
					{
						dictionary[rootType].AddRange(enumerable);
					}
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>> keyValuePair in dictionary)
			{
				if (keyValuePair.Key != entityType.GetRootType() && keyValuePair.Value.Count == 0)
				{
					list2.Add(keyValuePair.Key);
				}
			}
			if (list2.Count > 0 && list2.Count == dictionary.Count)
			{
				global::System.Data.Entity.Utilities.DatabaseName tableName = toTable.GetTableName();
				throw global::System.Data.Entity.Resources.Error.EntityMappingConfiguration_InvalidTableSharing(entityType.Name, list2.First<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().Name, (tableName != null) ? tableName.Name : databaseMapping.Database.GetEntitySet(toTable).Table);
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> source = dictionary.Values.SelectMany((global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> l) => l);
			if (source.Any<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = source.First<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 = associationType.Constraint.FromRole.GetEntityType();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentEntityType = (entityType == entityType3) ? associationType.Constraint.ToRole.GetEntityType() : entityType;
				global::System.Data.Entity.Core.Mapping.MappingFragment mappingFragment = (entityType == entityType3) ? list.Single((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.EntityType == dependentEntityType).Fragments.SingleOrDefault((global::System.Data.Entity.Core.Mapping.MappingFragment mf) => mf.Table == toTable) : fragment;
				if (mappingFragment != null)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3 = entityType3.KeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list4 = dependentEntityType.KeyProperties().ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					for (int i = 0; i < list3.Count; i++)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dependentKey = list4[i];
						dependentKey.SetStoreGeneratedPattern(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.None);
						mappingFragment.ColumnMappings.Single((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() == dependentKey).ColumnProperty.Name = list3[i].Name;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x04000ADA RID: 2778
		private global::System.Data.Entity.Utilities.DatabaseName _tableName;

		// Token: 0x04000ADB RID: 2779
		private global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> _properties;

		// Token: 0x04000ADC RID: 2780
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration> _valueConditions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration>();

		// Token: 0x04000ADD RID: 2781
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration> _notNullConditions = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration>();

		// Token: 0x04000ADE RID: 2782
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> _primitivePropertyConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>();

		// Token: 0x04000ADF RID: 2783
		private readonly global::System.Collections.Generic.IDictionary<string, object> _annotations = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
