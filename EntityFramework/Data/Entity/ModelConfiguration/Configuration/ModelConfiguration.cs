using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Mapping;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E4 RID: 484
	internal class ModelConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationBase
	{
		// Token: 0x06001970 RID: 6512 RVA: 0x00043782 File Offset: 0x00041982
		internal ModelConfiguration()
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x000437AC File Offset: 0x000419AC
		private ModelConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration source)
		{
			source._entityConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> c)
			{
				this._entityConfigurations.Add(c.Key, c.Value.Clone());
			});
			source._complexTypeConfigurations.Each(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> c)
			{
				this._complexTypeConfigurations.Add(c.Key, c.Value.Clone());
			});
			this._ignoredTypes.AddRange(source._ignoredTypes);
			this.DefaultSchema = source.DefaultSchema;
			this.ModelNamespace = source.ModelNamespace;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00043837 File Offset: 0x00041A37
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration Clone()
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration(this);
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x0004383F File Offset: 0x00041A3F
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Type> ConfiguredTypes
		{
			get
			{
				return this._entityConfigurations.Keys.Union(this._complexTypeConfigurations.Keys).Union(this._ignoredTypes);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x00043867 File Offset: 0x00041A67
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Type> Entities
		{
			get
			{
				return this._entityConfigurations.Keys.Except(this._ignoredTypes).ToList<global::System.Type>();
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x00043884 File Offset: 0x00041A84
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Type> ComplexTypes
		{
			get
			{
				return this._complexTypeConfigurations.Keys.Except(this._ignoredTypes).ToList<global::System.Type>();
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x000438A1 File Offset: 0x00041AA1
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Type> StructuralTypes
		{
			get
			{
				return this._entityConfigurations.Keys.Union(this._complexTypeConfigurations.Keys).Except(this._ignoredTypes).ToList<global::System.Type>();
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x000438CE File Offset: 0x00041ACE
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x000438D6 File Offset: 0x00041AD6
		public string DefaultSchema { get; set; }

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x000438DF File Offset: 0x00041ADF
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x000438E7 File Offset: 0x00041AE7
		public string ModelNamespace { get; set; }

		// Token: 0x0600197B RID: 6523 RVA: 0x000438F0 File Offset: 0x00041AF0
		internal virtual void Add(global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2;
			if ((this._entityConfigurations.TryGetValue(entityTypeConfiguration.ClrType, out entityTypeConfiguration2) && !entityTypeConfiguration2.IsReplaceable) || this._complexTypeConfigurations.ContainsKey(entityTypeConfiguration.ClrType))
			{
				throw global::System.Data.Entity.Resources.Error.DuplicateStructuralTypeConfiguration(entityTypeConfiguration.ClrType);
			}
			if (entityTypeConfiguration2 != null && entityTypeConfiguration2.IsReplaceable)
			{
				this._entityConfigurations.Remove(entityTypeConfiguration2.ClrType);
				entityTypeConfiguration.ReplaceFrom(entityTypeConfiguration2);
			}
			else
			{
				entityTypeConfiguration.IsReplaceable = false;
			}
			this._entityConfigurations.Add(entityTypeConfiguration.ClrType, entityTypeConfiguration);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00043978 File Offset: 0x00041B78
		internal virtual void Add(global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration complexTypeConfiguration)
		{
			if (this._entityConfigurations.ContainsKey(complexTypeConfiguration.ClrType) || this._complexTypeConfigurations.ContainsKey(complexTypeConfiguration.ClrType))
			{
				throw global::System.Data.Entity.Resources.Error.DuplicateStructuralTypeConfiguration(complexTypeConfiguration.ClrType);
			}
			this._complexTypeConfigurations.Add(complexTypeConfiguration.ClrType, complexTypeConfiguration);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000439C9 File Offset: 0x00041BC9
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration Entity(global::System.Type entityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(entityType, "entityType");
			return this.Entity(entityType, false);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000439E0 File Offset: 0x00041BE0
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration Entity(global::System.Type entityType, bool explicitEntity)
		{
			if (this._complexTypeConfigurations.ContainsKey(entityType))
			{
				throw global::System.Data.Entity.Resources.Error.EntityTypeConfigurationMismatch(entityType.Name);
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration result;
			if (!this._entityConfigurations.TryGetValue(entityType, out result))
			{
				global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityConfigurations = this._entityConfigurations;
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration(entityType);
				entityTypeConfiguration.IsExplicitEntity = explicitEntity;
				result = entityTypeConfiguration;
				entityConfigurations.Add(entityType, entityTypeConfiguration);
			}
			return result;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00043A34 File Offset: 0x00041C34
		public virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration ComplexType(global::System.Type complexType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(complexType, "complexType");
			if (this._entityConfigurations.ContainsKey(complexType))
			{
				throw global::System.Data.Entity.Resources.Error.ComplexTypeConfigurationMismatch(complexType.Name);
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration result;
			if (!this._complexTypeConfigurations.TryGetValue(complexType, out result))
			{
				this._complexTypeConfigurations.Add(complexType, result = new global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration(complexType));
			}
			return result;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00043A8C File Offset: 0x00041C8C
		public virtual void Ignore(global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			this._ignoredTypes.Add(type);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00043AA8 File Offset: 0x00041CA8
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration GetStructuralTypeConfiguration(global::System.Type type)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration result;
			if (this._entityConfigurations.TryGetValue(type, out result))
			{
				return result;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration result2;
			if (this._complexTypeConfigurations.TryGetValue(type, out result2))
			{
				return result2;
			}
			return null;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00043ADA File Offset: 0x00041CDA
		public virtual bool IsComplexType(global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			return this._complexTypeConfigurations.ContainsKey(type);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00043AF4 File Offset: 0x00041CF4
		public virtual bool IsIgnoredType(global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			return this._ignoredTypes.Contains(type);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00043B10 File Offset: 0x00041D10
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetConfiguredProperties(global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration structuralTypeConfiguration = this.GetStructuralTypeConfiguration(type);
			if (structuralTypeConfiguration == null)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Reflection.PropertyInfo>();
			}
			return structuralTypeConfiguration.ConfiguredProperties;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00043B40 File Offset: 0x00041D40
		public virtual bool IsIgnoredProperty(global::System.Type type, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			global::System.Func<global::System.Reflection.PropertyInfo, bool> <>9__0;
			while (type != null)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration structuralTypeConfiguration = this.GetStructuralTypeConfiguration(type);
				if (structuralTypeConfiguration != null)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> ignoredProperties = structuralTypeConfiguration.IgnoredProperties;
					global::System.Func<global::System.Reflection.PropertyInfo, bool> predicate;
					if ((predicate = <>9__0) == null)
					{
						predicate = (<>9__0 = ((global::System.Reflection.PropertyInfo p) => p.IsSameAs(propertyInfo)));
					}
					if (ignoredProperties.Any(predicate))
					{
						return true;
					}
				}
				type = type.BaseType;
			}
			return false;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00043BC4 File Offset: 0x00041DC4
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			this.ConfigureEntities(model);
			this.ConfigureComplexTypes(model);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00043BD4 File Offset: 0x00041DD4
		private void ConfigureEntities(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration in this.ActiveEntityConfigurations)
			{
				this.ConfigureFunctionMappings(model, entityTypeConfiguration, model.GetEntityType(entityTypeConfiguration.ClrType));
			}
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2 in this.ActiveEntityConfigurations)
			{
				entityTypeConfiguration2.Configure(model.GetEntityType(entityTypeConfiguration2.ClrType), model);
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00043C78 File Offset: 0x00041E78
		private void ConfigureFunctionMappings(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (entityTypeConfiguration.ModificationStoredProceduresConfiguration == null)
			{
				return;
			}
			while (entityType.BaseType != null)
			{
				global::System.Type clrType = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType).GetClrType();
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2;
				if (!entityType.BaseType.Abstract && (!this._entityConfigurations.TryGetValue(clrType, out entityTypeConfiguration2) || entityTypeConfiguration2.ModificationStoredProceduresConfiguration == null))
				{
					throw global::System.Data.Entity.Resources.Error.BaseTypeNotMappedToFunctions(clrType.Name, entityTypeConfiguration.ClrType.Name);
				}
				entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
			}
			model.GetSelfAndAllDerivedTypes(entityType).Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EntityType e)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration3 = this.Entity(e.GetClrType());
				if (entityTypeConfiguration3.ModificationStoredProceduresConfiguration == null)
				{
					entityTypeConfiguration3.MapToStoredProcedures();
				}
			});
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00043D08 File Offset: 0x00041F08
		private void ConfigureComplexTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration complexTypeConfiguration in this.ActiveComplexTypeConfigurations)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = model.GetComplexType(complexTypeConfiguration.ClrType);
				complexTypeConfiguration.Configure(complexType);
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00043D64 File Offset: 0x00041F64
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration structuralTypeConfiguration in from global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration c in 
				from ct in databaseMapping.Model.ComplexTypes
				select ct.GetConfiguration()
			where c != null
			select c)
			{
				structuralTypeConfiguration.ConfigurePropertyMappings(databaseMapping.GetComplexPropertyMappings(structuralTypeConfiguration.ClrType).ToList<global::System.Tuple<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder, global::System.Data.Entity.Core.Metadata.Edm.EntityType>>(), providerManifest, false);
			}
			this.ConfigureEntityTypes(databaseMapping, databaseMapping.Model.Container.EntitySets, providerManifest);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.RemoveRedundantColumnConditions(databaseMapping);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.RemoveRedundantTables(databaseMapping);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.ConfigureTables(databaseMapping.Database);
			this.ConfigureDefaultSchema(databaseMapping);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionNames(databaseMapping);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.ConfigureFunctionParameters(databaseMapping);
			global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.RemoveDuplicateTphColumns(databaseMapping);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00043E60 File Offset: 0x00042060
		private static void ConfigureFunctionParameters(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration structuralTypeConfiguration in from global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration c in 
				from ct in databaseMapping.Model.ComplexTypes
				select ct.GetConfiguration()
			where c != null
			select c)
			{
				structuralTypeConfiguration.ConfigureFunctionParameters(databaseMapping.GetComplexParameterBindings(structuralTypeConfiguration.ClrType).ToList<global::System.Data.Entity.Core.Mapping.ModificationFunctionParameterBinding>());
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in from e in databaseMapping.Model.EntityTypes
			where e.GetConfiguration() != null
			select e)
			{
				((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)entityType.GetConfiguration()).ConfigureFunctionParameters(databaseMapping, entityType);
			}
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00043F80 File Offset: 0x00042180
		private static void UniquifyFunctionNames(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.Core.Mapping.EntityTypeModificationFunctionMapping entityTypeModificationFunctionMapping in databaseMapping.GetEntitySetMappings().SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.ModificationFunctionMappings))
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)entityTypeModificationFunctionMapping.EntityType.GetConfiguration();
				if (entityTypeConfiguration.ModificationStoredProceduresConfiguration != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration modificationStoredProceduresConfiguration = entityTypeConfiguration.ModificationStoredProceduresConfiguration;
					global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionName(databaseMapping, modificationStoredProceduresConfiguration.InsertModificationStoredProcedureConfiguration, entityTypeModificationFunctionMapping.InsertFunctionMapping);
					global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionName(databaseMapping, modificationStoredProceduresConfiguration.UpdateModificationStoredProcedureConfiguration, entityTypeModificationFunctionMapping.UpdateFunctionMapping);
					global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionName(databaseMapping, modificationStoredProceduresConfiguration.DeleteModificationStoredProcedureConfiguration, entityTypeModificationFunctionMapping.DeleteFunctionMapping);
				}
			}
			foreach (global::System.Data.Entity.Core.Mapping.AssociationSetModificationFunctionMapping associationSetModificationFunctionMapping in from asm in databaseMapping.GetAssociationSetMappings()
			select asm.ModificationFunctionMapping into asm
			where asm != null
			select asm)
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration)associationSetModificationFunctionMapping.AssociationSet.ElementType.GetConfiguration();
				if (navigationPropertyConfiguration.ModificationStoredProceduresConfiguration != null)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionName(databaseMapping, navigationPropertyConfiguration.ModificationStoredProceduresConfiguration.InsertModificationStoredProcedureConfiguration, associationSetModificationFunctionMapping.InsertFunctionMapping);
					global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.UniquifyFunctionName(databaseMapping, navigationPropertyConfiguration.ModificationStoredProceduresConfiguration.DeleteModificationStoredProcedureConfiguration, associationSetModificationFunctionMapping.DeleteFunctionMapping);
				}
			}
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00044118 File Offset: 0x00042318
		private static void UniquifyFunctionName(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration modificationStoredProcedureConfiguration, global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping functionMapping)
		{
			if (modificationStoredProcedureConfiguration == null || string.IsNullOrWhiteSpace(modificationStoredProcedureConfiguration.Name))
			{
				functionMapping.Function.StoreFunctionNameAttribute = (from f in databaseMapping.Database.Functions.Except(new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction[]
				{
					functionMapping.Function
				})
				select f.FunctionName).Uniquify(functionMapping.Function.FunctionName);
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00044194 File Offset: 0x00042394
		private void ConfigureDefaultSchema(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			(from es in databaseMapping.Database.GetEntitySets()
			where string.IsNullOrWhiteSpace(es.Schema)
			select es).Each((global::System.Data.Entity.Core.Metadata.Edm.EntitySet es) => es.Schema = (this.DefaultSchema ?? "dbo"));
			(from f in databaseMapping.Database.Functions
			where string.IsNullOrWhiteSpace(f.Schema)
			select f).Each((global::System.Data.Entity.Core.Metadata.Edm.EdmFunction f) => f.Schema = (this.DefaultSchema ?? "dbo"));
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00044224 File Offset: 0x00042424
		private void ConfigureEntityTypes(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> list = this.SortEntityConfigurationsByInheritance(databaseMapping);
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration in list)
			{
				global::System.Data.Entity.Core.Mapping.EntityTypeMapping entityTypeMapping = databaseMapping.GetEntityTypeMapping(entityTypeConfiguration.ClrType);
				entityTypeConfiguration.ConfigureTablesAndConditions(entityTypeMapping, databaseMapping, entitySets, providerManifest);
				global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.ConfigureUnconfiguredDerivedTypes(databaseMapping, entitySets, providerManifest, databaseMapping.Model.GetEntityType(entityTypeConfiguration.ClrType), list);
			}
			new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingService(databaseMapping).Configure();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in from e in databaseMapping.Model.EntityTypes
			where e.GetConfiguration() != null
			select e)
			{
				((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)entityType.GetConfiguration()).Configure(entityType, databaseMapping, providerManifest);
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00044324 File Offset: 0x00042524
		private static void ConfigureUnconfiguredDerivedTypes(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> sortedEntityConfigurations)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntityType> list = databaseMapping.Model.GetDerivedTypes(entityType).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			while (list.Count > 0)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType currentType = list[0];
				list.RemoveAt(0);
				if (!currentType.Abstract && sortedEntityConfigurations.All((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration etc) => etc.ClrType != currentType.GetClrType()))
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration.ConfigureUnconfiguredType(databaseMapping, entitySets, providerManifest, currentType, new global::System.Collections.Generic.Dictionary<string, object>());
					list.AddRange(databaseMapping.Model.GetDerivedTypes(currentType));
				}
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000443B4 File Offset: 0x000425B4
		private static void ConfigureTables(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType table in database.EntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>())
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration.ConfigureTable(database, table);
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0004440C File Offset: 0x0004260C
		private static void ConfigureTable(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			global::System.Data.Entity.Utilities.DatabaseName tableName = table.GetTableName();
			if (tableName == null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = database.GetEntitySet(table);
			if (!string.IsNullOrWhiteSpace(tableName.Schema))
			{
				entitySet.Schema = tableName.Schema;
			}
			entitySet.Table = tableName.Name;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00044454 File Offset: 0x00042654
		private global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> SortEntityConfigurationsByInheritance(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> list = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>();
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration in this.ActiveEntityConfigurations)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = databaseMapping.Model.GetEntityType(entityTypeConfiguration.ClrType);
				if (entityType != null)
				{
					if (entityType.BaseType == null)
					{
						if (!list.Contains(entityTypeConfiguration))
						{
							list.Add(entityTypeConfiguration);
						}
					}
					else
					{
						global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntityType> stack = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
						while (entityType != null)
						{
							stack.Push(entityType);
							entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType.BaseType;
						}
						global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration, bool> <>9__0;
						while (stack.Count > 0)
						{
							entityType = stack.Pop();
							global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> activeEntityConfigurations = this.ActiveEntityConfigurations;
							global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration, bool> predicate;
							if ((predicate = <>9__0) == null)
							{
								predicate = (<>9__0 = ((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration ec) => ec.ClrType == entityType.GetClrType()));
							}
							global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2 = activeEntityConfigurations.SingleOrDefault(predicate);
							if (entityTypeConfiguration2 != null && !list.Contains(entityTypeConfiguration2))
							{
								list.Add(entityTypeConfiguration2);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00044588 File Offset: 0x00042788
		internal void NormalizeConfigurations()
		{
			this.DiscoverIndirectlyConfiguredComplexTypes();
			this.ReassignSubtypeMappings();
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00044596 File Offset: 0x00042796
		private void DiscoverIndirectlyConfiguredComplexTypes()
		{
			this.ActiveEntityConfigurations.SelectMany((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration ec) => ec.ConfiguredComplexTypes).Each((global::System.Type t) => this.ComplexType(t));
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x000445D4 File Offset: 0x000427D4
		private void ReassignSubtypeMappings()
		{
			foreach (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration in this.ActiveEntityConfigurations)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration> keyValuePair in entityTypeConfiguration.SubTypeMappingConfigurations)
				{
					global::System.Type subTypeClrType = keyValuePair.Key;
					global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2 = this.ActiveEntityConfigurations.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration ec) => ec.ClrType == subTypeClrType);
					if (entityTypeConfiguration2 == null)
					{
						entityTypeConfiguration2 = new global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration(subTypeClrType);
						this._entityConfigurations.Add(subTypeClrType, entityTypeConfiguration2);
					}
					entityTypeConfiguration2.AddMappingConfiguration(keyValuePair.Value, false);
				}
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x000446B8 File Offset: 0x000428B8
		private static void RemoveDuplicateTphColumns(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType currentTable2 in databaseMapping.Database.EntityTypes)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityType currentTable = currentTable2;
				new global::System.Data.Entity.ModelConfiguration.Configuration.TphColumnFixer((from f in databaseMapping.GetEntitySetMappings().SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping e) => e.EntityTypeMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping e) => e.MappingFragments)
				where f.Table == currentTable
				select f).SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment f) => f.ColumnMappings), currentTable, databaseMapping.Database).RemoveDuplicateTphColumns();
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x000447B0 File Offset: 0x000429B0
		private static void RemoveRedundantColumnConditions(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			(from esm in databaseMapping.GetEntitySetMappings()
			select new
			{
				Set = esm,
				Fragments = from etm in esm.EntityTypeMappings
				from etmf in etm.MappingFragments
				group etmf by etmf.Table into g
				where g.Count((global::System.Data.Entity.Core.Mapping.MappingFragment x) => x.GetDefaultDiscriminator() != null) == 1
				select g.Single((global::System.Data.Entity.Core.Mapping.MappingFragment x) => x.GetDefaultDiscriminator() != null)
			}).Each(delegate(x)
			{
				x.Fragments.Each(delegate(global::System.Data.Entity.Core.Mapping.MappingFragment f)
				{
					f.RemoveDefaultDiscriminator(x.Set);
				});
			});
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0004480C File Offset: 0x00042A0C
		private static void RemoveRedundantTables(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping)
		{
			global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> <>9__7;
			(from t in databaseMapping.Database.EntityTypes
			where databaseMapping.GetEntitySetMappings().SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments).All((global::System.Data.Entity.Core.Mapping.MappingFragment etmf) => etmf.Table != t) && databaseMapping.GetAssociationSetMappings().All((global::System.Data.Entity.Core.Mapping.AssociationSetMapping asm) => asm.Table != t)
			select t).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>().Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EntityType t)
			{
				global::System.Data.Entity.Utilities.DatabaseName tableName = t.GetTableName();
				if (tableName != null)
				{
					throw global::System.Data.Entity.Resources.Error.OrphanedConfiguredTableDetected(tableName);
				}
				databaseMapping.Database.RemoveEntityType(t);
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> ts = (from at in databaseMapping.Database.AssociationTypes
				where at.SourceEnd.GetEntityType() == t || at.TargetEnd.GetEntityType() == t
				select at).ToList<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
				global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> action;
				if ((action = <>9__7) == null)
				{
					action = (<>9__7 = delegate(global::System.Data.Entity.Core.Metadata.Edm.AssociationType at)
					{
						databaseMapping.Database.RemoveAssociationType(at);
					});
				}
				ts.Each(action);
			});
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00044860 File Offset: 0x00042A60
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> ActiveEntityConfigurations
		{
			get
			{
				return this._entityConfigurations.Where(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> keyValuePair)
				{
					global::System.Collections.Generic.HashSet<global::System.Type> ignoredTypes = this._ignoredTypes;
					global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> keyValuePair2 = keyValuePair;
					return !ignoredTypes.Contains(keyValuePair2.Key);
				}).Select(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> keyValuePair)
				{
					global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> keyValuePair2 = keyValuePair;
					return keyValuePair2.Value;
				}).ToList<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>();
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x000448B0 File Offset: 0x00042AB0
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> ActiveComplexTypeConfigurations
		{
			get
			{
				return this._complexTypeConfigurations.Where(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> keyValuePair)
				{
					global::System.Collections.Generic.HashSet<global::System.Type> ignoredTypes = this._ignoredTypes;
					global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> keyValuePair2 = keyValuePair;
					return !ignoredTypes.Contains(keyValuePair2.Key);
				}).Select(delegate(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> keyValuePair)
				{
					global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> keyValuePair2 = keyValuePair;
					return keyValuePair2.Value;
				}).ToList<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>();
			}
		}

		// Token: 0x04000A7C RID: 2684
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> _entityConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>();

		// Token: 0x04000A7D RID: 2685
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> _complexTypeConfigurations = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>();

		// Token: 0x04000A7E RID: 2686
		private readonly global::System.Collections.Generic.HashSet<global::System.Type> _ignoredTypes = new global::System.Collections.Generic.HashSet<global::System.Type>();
	}
}
