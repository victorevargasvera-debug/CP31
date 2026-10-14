using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Configuration.Mapping;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Index;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Edm.Services;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration.Types
{
	// Token: 0x020001FE RID: 510
	internal class EntityTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
	{
		// Token: 0x06001AD7 RID: 6871 RVA: 0x000478B8 File Offset: 0x00045AB8
		internal EntityTypeConfiguration(global::System.Type structuralType) : base(structuralType)
		{
			this.IsReplaceable = false;
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00047944 File Offset: 0x00045B44
		private EntityTypeConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration source) : base(source)
		{
			this._keyProperties.AddRange(source._keyProperties);
			this._keyConfiguration = source._keyConfiguration;
			source._indexConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration> c)
			{
				this._indexConfigurations.Add(c.Key, c.Value.Clone());
			});
			source._navigationPropertyConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration> c)
			{
				this._navigationPropertyConfigurations.Add(c.Key, c.Value.Clone());
			});
			source._entitySubTypesMappingConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> c)
			{
				this._entitySubTypesMappingConfigurations.Add(c.Key, c.Value.Clone());
			});
			this._entityMappingConfigurations.AddRange(from e in source._entityMappingConfigurations.Except(source._nonCloneableMappings)
			select e.Clone());
			this._entitySetName = source._entitySetName;
			if (source._modificationStoredProceduresConfiguration != null)
			{
				this._modificationStoredProceduresConfiguration = source._modificationStoredProceduresConfiguration.Clone();
			}
			this.IsReplaceable = source.IsReplaceable;
			this.IsTableNameConfigured = source.IsTableNameConfigured;
			this.IsExplicitEntity = source.IsExplicitEntity;
			foreach (global::System.Collections.Generic.KeyValuePair<string, object> item in source._annotations)
			{
				this._annotations.Add(item);
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00047AFC File Offset: 0x00045CFC
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration(this);
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x00047B04 File Offset: 0x00045D04
		internal global::System.Collections.Generic.IEnumerable<global::System.Type> ConfiguredComplexTypes
		{
			get
			{
				return from pi in (from c in base.PrimitivePropertyConfigurations
				where c.Key.Count > 1
				select c.Key.Reverse<global::System.Reflection.PropertyInfo>().Skip(1)).SelectMany((global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> p) => p)
				select pi.PropertyType;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00047BA8 File Offset: 0x00045DA8
		internal bool IsStructuralConfigurationOnly
		{
			get
			{
				return !this._keyProperties.Any<global::System.Reflection.PropertyInfo>() && !this._navigationPropertyConfigurations.Any<global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration>>() && !this._entityMappingConfigurations.Any<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>() && !this._entitySubTypesMappingConfigurations.Any<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>>() && this._entitySetName == null;
			}
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00047BF4 File Offset: 0x00045DF4
		internal override void RemoveProperty(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath)
		{
			base.RemoveProperty(propertyPath);
			this._navigationPropertyConfigurations.Remove(propertyPath.Single<global::System.Reflection.PropertyInfo>());
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x00047C0F File Offset: 0x00045E0F
		internal bool IsKeyConfigured
		{
			get
			{
				return this._keyConfiguration != null;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00047C1A File Offset: 0x00045E1A
		internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> KeyProperties
		{
			get
			{
				return this._keyProperties;
			}
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00047C24 File Offset: 0x00045E24
		internal virtual void Key(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> keyProperties)
		{
			this.ClearKey();
			foreach (global::System.Reflection.PropertyInfo propertyInfo in keyProperties)
			{
				this.Key(propertyInfo, new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts?(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.None));
			}
			if (this._keyConfiguration == null)
			{
				this._keyConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration();
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00047C8C File Offset: 0x00045E8C
		public void Key(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			this.Key(propertyInfo, null);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00047CB8 File Offset: 0x00045EB8
		internal virtual void Key(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts? overridableConfigurationParts)
		{
			if (!propertyInfo.IsValidEdmScalarProperty())
			{
				throw global::System.Data.Entity.Resources.Error.ModelBuilder_KeyPropertiesMustBePrimitive(propertyInfo.Name, base.ClrType);
			}
			if (this._keyConfiguration == null && !this._keyProperties.ContainsSame(propertyInfo))
			{
				this._keyProperties.Add(propertyInfo);
				base.Property(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), overridableConfigurationParts);
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00047D0F File Offset: 0x00045F0F
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration ConfigureKey()
		{
			if (this._keyConfiguration == null)
			{
				this._keyConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration();
			}
			return this._keyConfiguration;
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00047D2A File Offset: 0x00045F2A
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> PropertyIndexes
		{
			get
			{
				return this._indexConfigurations.Keys;
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00047D38 File Offset: 0x00045F38
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration Index(global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath indexProperties)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration result;
			if (!this._indexConfigurations.TryGetValue(indexProperties, out result))
			{
				this._indexConfigurations.Add(indexProperties, result = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration());
			}
			return result;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00047D69 File Offset: 0x00045F69
		internal void ClearKey()
		{
			this._keyProperties.Clear();
			this._keyConfiguration = null;
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00047D7D File Offset: 0x00045F7D
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00047D85 File Offset: 0x00045F85
		public bool IsTableNameConfigured { get; private set; }

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x00047D8E File Offset: 0x00045F8E
		// (set) Token: 0x06001AE9 RID: 6889 RVA: 0x00047D96 File Offset: 0x00045F96
		internal bool IsReplaceable { get; set; }

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x00047D9F File Offset: 0x00045F9F
		// (set) Token: 0x06001AEB RID: 6891 RVA: 0x00047DA7 File Offset: 0x00045FA7
		internal bool IsExplicitEntity { get; set; }

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x00047DB0 File Offset: 0x00045FB0
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration ModificationStoredProceduresConfiguration
		{
			get
			{
				return this._modificationStoredProceduresConfiguration;
			}
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00047DB8 File Offset: 0x00045FB8
		internal virtual void MapToStoredProcedures()
		{
			if (this._modificationStoredProceduresConfiguration == null)
			{
				this._modificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration();
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00047DCD File Offset: 0x00045FCD
		internal virtual void MapToStoredProcedures(global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration modificationStoredProceduresConfiguration, bool allowOverride)
		{
			if (this._modificationStoredProceduresConfiguration == null)
			{
				this._modificationStoredProceduresConfiguration = modificationStoredProceduresConfiguration;
				return;
			}
			this._modificationStoredProceduresConfiguration.Merge(modificationStoredProceduresConfiguration, allowOverride);
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x00047DEC File Offset: 0x00045FEC
		internal void ReplaceFrom(global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration existing)
		{
			if (this.EntitySetName == null)
			{
				this.EntitySetName = existing.EntitySetName;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00047E02 File Offset: 0x00046002
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x00047E0A File Offset: 0x0004600A
		public virtual string EntitySetName
		{
			get
			{
				return this._entitySetName;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._entitySetName = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x00047E1F File Offset: 0x0004601F
		internal override global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> ConfiguredProperties
		{
			get
			{
				return base.ConfiguredProperties.Union(this._navigationPropertyConfigurations.Keys);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x00047E37 File Offset: 0x00046037
		public string TableName
		{
			get
			{
				if (!this.IsTableNameConfigured)
				{
					return null;
				}
				return this.GetTableName().Name;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00047E4E File Offset: 0x0004604E
		public string SchemaName
		{
			get
			{
				if (!this.IsTableNameConfigured)
				{
					return null;
				}
				return this.GetTableName().Schema;
			}
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x00047E65 File Offset: 0x00046065
		internal global::System.Data.Entity.Utilities.DatabaseName GetTableName()
		{
			if (!this.IsTableNameConfigured)
			{
				return null;
			}
			return this._entityMappingConfigurations.First<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>().TableName;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00047E81 File Offset: 0x00046081
		public void ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this.ToTable(tableName, null);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00047E98 File Offset: 0x00046098
		public void ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this.IsTableNameConfigured = true;
			if (!this._entityMappingConfigurations.Any<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>())
			{
				this._entityMappingConfigurations.Add(new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration());
			}
			this._entityMappingConfigurations.First<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>().TableName = (string.IsNullOrWhiteSpace(schemaName) ? new global::System.Data.Entity.Utilities.DatabaseName(tableName) : new global::System.Data.Entity.Utilities.DatabaseName(tableName, schemaName));
			this.UpdateTableNameForSubTypes();
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x00047F02 File Offset: 0x00046102
		public global::System.Collections.Generic.IDictionary<string, object> Annotations
		{
			get
			{
				return this._annotations;
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00047F0A File Offset: 0x0004610A
		public virtual void SetAnnotation(string name, object value)
		{
			if (!name.IsValidUndottedName())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BadAnnotationName(name));
			}
			this._annotations[name] = value;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00047F30 File Offset: 0x00046130
		private void UpdateTableNameForSubTypes()
		{
			(from stmc in this._entitySubTypesMappingConfigurations
			where stmc.Value.TableName == null
			select stmc into tphs
			select tphs.Value).Each((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration tphmc) => tphmc.TableName = this.GetTableName());
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00047F9C File Offset: 0x0004619C
		internal void AddMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration mappingConfiguration, bool cloneable = true)
		{
			if (this._entityMappingConfigurations.Contains(mappingConfiguration))
			{
				return;
			}
			global::System.Data.Entity.Utilities.DatabaseName tableName = mappingConfiguration.TableName;
			if (tableName != null && this._entityMappingConfigurations.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration mf) => tableName.Equals(mf.TableName)) != null)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidTableMapping(base.ClrType.Name, tableName);
			}
			this._entityMappingConfigurations.Add(mappingConfiguration);
			if (this._entityMappingConfigurations.Count > 1)
			{
				if (this._entityMappingConfigurations.Any((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration mc) => mc.TableName == null))
				{
					throw global::System.Data.Entity.Resources.Error.InvalidTableMapping_NoTableName(base.ClrType.Name);
				}
			}
			this.IsTableNameConfigured |= (tableName != null);
			if (!cloneable)
			{
				this._nonCloneableMappings.Add(mappingConfiguration);
			}
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00048080 File Offset: 0x00046280
		internal void AddSubTypeMappingConfiguration(global::System.Type subType, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration mappingConfiguration)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration entityMappingConfiguration;
			if (this._entitySubTypesMappingConfigurations.TryGetValue(subType, out entityMappingConfiguration))
			{
				throw global::System.Data.Entity.Resources.Error.InvalidChainedMappingSyntax(subType.Name);
			}
			this._entitySubTypesMappingConfigurations.Add(subType, mappingConfiguration);
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000480B6 File Offset: 0x000462B6
		internal global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> SubTypeMappingConfigurations
		{
			get
			{
				return this._entitySubTypesMappingConfigurations;
			}
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000480C0 File Offset: 0x000462C0
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration Navigation(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration result;
			if (!this._navigationPropertyConfigurations.TryGetValue(propertyInfo, out result))
			{
				this._navigationPropertyConfigurations.Add(propertyInfo, result = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration(propertyInfo));
			}
			return result;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000480F2 File Offset: 0x000462F2
		internal virtual void Configure(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			this.ConfigureKey(entityType);
			base.Configure(entityType.Name, entityType.Properties, entityType.GetMetadataProperties());
			this.ConfigureAssociations(entityType, model);
			this.ConfigureEntitySetName(entityType, model);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00048124 File Offset: 0x00046324
		private void ConfigureEntitySetName(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			if (this.EntitySetName == null || entityType.BaseType != null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = model.GetEntitySet(entityType);
			entitySet.Name = model.GetEntitySets().Except(new global::System.Data.Entity.Core.Metadata.Edm.EntitySet[]
			{
				entitySet
			}).UniquifyName(this.EntitySetName);
			entitySet.SetConfiguration(this);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00048178 File Offset: 0x00046378
		private void ConfigureKey(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (!this._keyProperties.Any<global::System.Reflection.PropertyInfo>())
			{
				return;
			}
			if (entityType.BaseType != null)
			{
				throw global::System.Data.Entity.Resources.Error.KeyRegisteredOnDerivedType(base.ClrType, entityType.GetRootType().GetClrType());
			}
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable = this._keyProperties.AsEnumerable<global::System.Reflection.PropertyInfo>();
			if (this._keyConfiguration == null)
			{
				var source = from p in this._keyProperties
				select new
				{
					PropertyInfo = p,
					ColumnOrder = base.Property(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(p), null).ColumnOrder
				};
				if (this._keyProperties.Count > 1)
				{
					if (source.Any(p => p.ColumnOrder == null))
					{
						throw global::System.Data.Entity.Resources.Error.ModelGeneration_UnableToDetermineKeyOrder(base.ClrType);
					}
				}
				enumerable = from p in source
				orderby p.ColumnOrder
				select p.PropertyInfo;
			}
			foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty declaredPrimitiveProperty = entityType.GetDeclaredPrimitiveProperty(propertyInfo);
				if (declaredPrimitiveProperty == null)
				{
					throw global::System.Data.Entity.Resources.Error.KeyPropertyNotFound(propertyInfo.Name, entityType.Name);
				}
				declaredPrimitiveProperty.Nullable = false;
				entityType.AddKeyMember(declaredPrimitiveProperty);
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000482D0 File Offset: 0x000464D0
		private void ConfigureIndexes(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping mapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = mapping.GetEntityTypeMappings(entityType);
			if (this._keyConfiguration != null)
			{
				entityTypeMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.Fragments).Each(delegate(global::System.Data.Entity.Core.Mapping.MappingFragment f)
				{
					this._keyConfiguration.Configure(f.Table);
				});
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration> keyValuePair in this._indexConfigurations)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> enumerator2 = entityTypeMappings.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = enumerator2.Current;
						global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> propertyMappings = keyValuePair.Key.ToDictionary((global::System.Reflection.PropertyInfo icp) => icp, (global::System.Reflection.PropertyInfo icp) => entityTypeMapping.GetPropertyMapping(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
						{
							entityType.GetDeclaredPrimitiveProperty(icp)
						}));
						if (keyValuePair.Key.Count > 1 && string.IsNullOrEmpty(keyValuePair.Value.Name))
						{
							keyValuePair.Value.Name = global::System.Data.Entity.Migrations.Model.IndexOperation.BuildDefaultName(from icp in keyValuePair.Key
							select propertyMappings[icp].ColumnProperty.Name);
						}
						int num = 0;
						foreach (global::System.Reflection.PropertyInfo key in ((global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo>)keyValuePair.Key))
						{
							global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder columnMappingBuilder = propertyMappings[key];
							keyValuePair.Value.Configure(columnMappingBuilder.ColumnProperty, (keyValuePair.Key.Count != 1) ? num : -1);
							num++;
						}
					}
				}
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00048504 File Offset: 0x00046704
		private void ConfigureAssociations(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration> keyValuePair in this._navigationPropertyConfigurations)
			{
				global::System.Reflection.PropertyInfo propertyInfo = keyValuePair.Key;
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration value = keyValuePair.Value;
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = entityType.GetNavigationProperty(propertyInfo);
				if (navigationProperty == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = entityType.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => p.GetClrPropertyInfo() == propertyInfo);
					if (edmProperty != null && edmProperty.ComplexType != null)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidNavigationPropertyComplexType(propertyInfo.Name, entityType.Name, edmProperty.ComplexType.Name));
					}
					throw global::System.Data.Entity.Resources.Error.NavigationPropertyNotFound(propertyInfo.Name, entityType.Name);
				}
				else if (entityType.DeclaredNavigationProperties.Any((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty np) => np.GetClrPropertyInfo().IsSameAs(propertyInfo)))
				{
					value.Configure(navigationProperty, model, this);
				}
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0004860C File Offset: 0x0004680C
		internal void ConfigureTablesAndConditions(global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (entityTypeMapping != null) ? entityTypeMapping.EntityType : databaseMapping.Model.GetEntityType(base.ClrType);
			if (this._entityMappingConfigurations.Any<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>())
			{
				for (int i = 0; i < this._entityMappingConfigurations.Count; i++)
				{
					this._entityMappingConfigurations[i].Configure(databaseMapping, entitySets, providerManifest, entityType, ref entityTypeMapping, this.IsMappingAnyInheritedProperty(entityType), i, this._entityMappingConfigurations.Count, this._annotations);
				}
				return;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.ConfigureUnconfiguredType(databaseMapping, entitySets, providerManifest, entityType, this._annotations);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0004869C File Offset: 0x0004689C
		internal bool IsMappingAnyInheritedProperty(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return this._entityMappingConfigurations.Any((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration emc) => emc.MapsAnyInheritedProperties(entityType));
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000486CD File Offset: 0x000468CD
		internal bool IsNavigationPropertyConfigured(global::System.Reflection.PropertyInfo propertyInfo)
		{
			return this._navigationPropertyConfigurations.ContainsKey(propertyInfo);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x000486DC File Offset: 0x000468DC
		internal static void ConfigureUnconfiguredType(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IDictionary<string, object> commonAnnotations)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration entityMappingConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration();
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityType.GetClrType());
			entityMappingConfiguration.Configure(databaseMapping, entitySets, providerManifest, entityType, ref entityTypeMapping, false, 0, 1, commonAnnotations);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0004870C File Offset: 0x0004690C
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityType.GetClrType());
			if (entityTypeMapping != null)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.VerifyAllCSpacePropertiesAreMapped(databaseMapping.GetEntityTypeMappings(entityType).ToList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>(), entityTypeMapping.EntityType.DeclaredProperties, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			}
			this.ConfigurePropertyMappings(databaseMapping, entityType, providerManifest, false);
			this.ConfigureIndexes(databaseMapping, entityType);
			this.ConfigureAssociationMappings(databaseMapping, entityType, providerManifest);
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.ConfigureDependentKeys(databaseMapping, providerManifest);
			this.ConfigureModificationStoredProcedures(databaseMapping, entityType, providerManifest);
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00048778 File Offset: 0x00046978
		internal void ConfigureFunctionParameters(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding> parameterBindings = (from esm in databaseMapping.GetEntitySetMappings()
			from mfm in esm.ModificationFunctionMappings
			where mfm.EntityType == entityType
			from pb in mfm.PrimaryParameterBindings
			select pb).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>();
			base.ConfigureFunctionParameters(parameterBindings);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes = databaseMapping.Model.EntityTypes;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> <>9__5;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> predicate;
			if ((predicate = <>9__5) == null)
			{
				predicate = (<>9__5 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.BaseType == entityType));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in entityTypes.Where(predicate))
			{
				this.ConfigureFunctionParameters(databaseMapping, entityType2);
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000488A8 File Offset: 0x00046AA8
		private void ConfigureModificationStoredProcedures(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			if (this._modificationStoredProceduresConfiguration != null)
			{
				new global::System.Data.Entity.ModelConfiguration.Edm.Services.ModificationFunctionMappingGenerator(providerManifest).Generate(entityType, databaseMapping);
				global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping = databaseMapping.GetEntitySetMappings().SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.ModificationFunctionMappings).SingleOrDefault((global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping mfm) => mfm.EntityType == entityType);
				if (entityTypeModificationFunctionMapping != null)
				{
					this._modificationStoredProceduresConfiguration.Configure(entityTypeModificationFunctionMapping, providerManifest);
				}
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00048928 File Offset: 0x00046B28
		private void ConfigurePropertyMappings(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, bool allowOverride = false)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings = databaseMapping.GetEntityTypeMappings(entityType);
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> propertyMappings = (from etm in entityTypeMappings
			from etmf in etm.MappingFragments
			from pm in etmf.ColumnMappings
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(pm, etmf.Table)).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			base.ConfigurePropertyMappings(propertyMappings, providerManifest, allowOverride);
			this._entityMappingConfigurations.Each(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration c)
			{
				c.ConfigurePropertyMappings(propertyMappings, providerManifest, allowOverride);
			});
			global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>> inheritedPropertyMappings = (from esm in databaseMapping.GetEntitySetMappings()
			from etm in esm.EntityTypeMappings
			where etm.IsHierarchyMapping && etm.EntityType.IsAncestorOf(entityType)
			from etmf in etm.MappingFragments
			from pm1 in etmf.ColumnMappings
			where !propertyMappings.Any((global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType> pm2) => pm2.Item1.PropertyPath.SequenceEqual(pm1.PropertyPath))
			select global::System.Tuple.Create<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>(pm1, etmf.Table)).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>();
			base.ConfigurePropertyMappings(inheritedPropertyMappings, providerManifest, false);
			this._entityMappingConfigurations.Each(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration c)
			{
				c.ConfigurePropertyMappings(inheritedPropertyMappings, providerManifest, false);
			});
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes = databaseMapping.Model.EntityTypes;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> <>9__16;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> predicate;
			if ((predicate = <>9__16) == null)
			{
				predicate = (<>9__16 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.BaseType == entityType));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in entityTypes.Where(predicate))
			{
				this.ConfigurePropertyMappings(databaseMapping, entityType2, providerManifest, true);
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00048BDC File Offset: 0x00046DDC
		private void ConfigureAssociationMappings(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration> keyValuePair in this._navigationPropertyConfigurations)
			{
				global::System.Reflection.PropertyInfo key = keyValuePair.Key;
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration value = keyValuePair.Value;
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = entityType.GetNavigationProperty(key);
				if (navigationProperty == null)
				{
					throw global::System.Data.Entity.Resources.Error.NavigationPropertyNotFound(key.Name, entityType.Name);
				}
				global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping = databaseMapping.GetAssociationSetMappings().SingleOrDefault((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => asm.AssociationSet.ElementType == navigationProperty.Association);
				if (associationSetMapping != null)
				{
					value.Configure(associationSetMapping, databaseMapping, providerManifest);
				}
			}
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00048C90 File Offset: 0x00046E90
		private static void ConfigureDependentKeys(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = (databaseMapping.Database.EntityTypes as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>) ?? databaseMapping.Database.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = list[i];
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder> list2 = (entityType.ForeignKeyBuilders as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>) ?? entityType.ForeignKeyBuilders.ToList<global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder>();
				for (int j = 0; j < list2.Count; j++)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = list2[j];
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> dependentColumns = foreignKeyBuilder.DependentColumns;
					global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3 = (dependentColumns as global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>) ?? dependentColumns.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					for (int k = 0; k < list3.Count; k++)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = list3[k];
						global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = edmProperty.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
						if (primitivePropertyConfiguration == null || primitivePropertyConfiguration.ColumnType == null)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = foreignKeyBuilder.PrincipalTable.KeyProperties.ElementAt(k);
							edmProperty.PrimitiveType = providerManifest.GetStoreTypeFromName(edmProperty2.TypeName);
							edmProperty.CopyFrom(edmProperty2);
						}
					}
				}
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00048DAC File Offset: 0x00046FAC
		private static void VerifyAllCSpacePropertiesAreMapped(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Mapping.EntityTypeMapping> entityTypeMappings, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = entityTypeMappings.First<global::System.Data.Entity.Core.Mapping.EntityTypeMapping>().EntityType;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> <>9__2;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
			{
				propertyPath.Add(edmProperty);
				if (edmProperty.IsComplexType)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.VerifyAllCSpacePropertiesAreMapped(entityTypeMappings, edmProperty.ComplexType.Properties, propertyPath);
				}
				else
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> source = entityTypeMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments).SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment mf) => mf.ColumnMappings);
					global::System.Func<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, bool> predicate;
					if ((predicate = <>9__2) == null)
					{
						predicate = (<>9__2 = ((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.PropertyPath.SequenceEqual(propertyPath)));
					}
					if (!source.Any(predicate) && !entityType.Abstract)
					{
						throw global::System.Data.Entity.Resources.Error.InvalidEntitySplittingProperties(entityType.Name);
					}
				}
				propertyPath.Remove(edmProperty);
			}
		}

		// Token: 0x04000AA3 RID: 2723
		private readonly global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> _keyProperties = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();

		// Token: 0x04000AA4 RID: 2724
		private global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration _keyConfiguration;

		// Token: 0x04000AA5 RID: 2725
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration> _indexConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration>();

		// Token: 0x04000AA6 RID: 2726
		private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration> _navigationPropertyConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration>(new global::System.Data.Entity.Utilities.DynamicEqualityComparer<global::System.Reflection.PropertyInfo>((global::System.Reflection.PropertyInfo p1, global::System.Reflection.PropertyInfo p2) => p1.IsSameAs(p2)));

		// Token: 0x04000AA7 RID: 2727
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> _entityMappingConfigurations = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>();

		// Token: 0x04000AA8 RID: 2728
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> _entitySubTypesMappingConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>();

		// Token: 0x04000AA9 RID: 2729
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> _nonCloneableMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration>();

		// Token: 0x04000AAA RID: 2730
		private readonly global::System.Collections.Generic.IDictionary<string, object> _annotations = new global::System.Collections.Generic.Dictionary<string, object>();

		// Token: 0x04000AAB RID: 2731
		private string _entitySetName;

		// Token: 0x04000AAC RID: 2732
		private global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration _modificationStoredProceduresConfiguration;
	}
}
