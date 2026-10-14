using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Mapping;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Edm.Services;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E3 RID: 483
	[global::System.Diagnostics.DebuggerDisplay("{Discriminator}")]
	public class ValueConditionConfiguration
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00043186 File Offset: 0x00041386
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x0004318E File Offset: 0x0004138E
		internal string Discriminator { get; set; }

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x00043197 File Offset: 0x00041397
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x0004319F File Offset: 0x0004139F
		internal object Value { get; set; }

		// Token: 0x0600195F RID: 6495 RVA: 0x000431A8 File Offset: 0x000413A8
		internal ValueConditionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration entityMapConfiguration, string discriminator)
		{
			this._entityMappingConfiguration = entityMapConfiguration;
			this.Discriminator = discriminator;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x000431C0 File Offset: 0x000413C0
		private ValueConditionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration owner, global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration source)
		{
			this._entityMappingConfiguration = owner;
			this.Discriminator = source.Discriminator;
			this.Value = source.Value;
			this._configuration = ((source._configuration == null) ? null : source._configuration.Clone());
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0004320E File Offset: 0x0004140E
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration Clone(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration owner)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration(owner, this);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00043218 File Offset: 0x00041418
		private T GetOrCreateConfiguration<T>() where T : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration, new()
		{
			if (this._configuration == null)
			{
				this._configuration = global::System.Activator.CreateInstance<T>();
			}
			else if (!(this._configuration is T))
			{
				T t = global::System.Activator.CreateInstance<T>();
				t.CopyFrom(this._configuration);
				this._configuration = t;
			}
			this._configuration.OverridableConfigurationParts = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.None;
			return (T)((object)this._configuration);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00043286 File Offset: 0x00041486
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration HasValue<T>(T value) where T : struct
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration.ValidateValueType(value);
			this.Value = value;
			this._entityMappingConfiguration.AddValueCondition(this);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration(this.GetOrCreateConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>());
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000432B6 File Offset: 0x000414B6
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration HasValue<T>(T? value) where T : struct
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration.ValidateValueType(value);
			this.Value = value;
			this._entityMappingConfiguration.AddValueCondition(this);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitiveColumnConfiguration(this.GetOrCreateConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>());
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x000432E6 File Offset: 0x000414E6
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration HasValue(string value)
		{
			this.Value = value;
			this._entityMappingConfiguration.AddValueCondition(this);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.StringColumnConfiguration(this.GetOrCreateConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>());
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00043308 File Offset: 0x00041508
		private static void ValidateValueType(object value)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			if (value != null && !value.GetType().IsPrimitiveType(out primitiveType))
			{
				throw global::System.Data.Entity.Resources.Error.InvalidDiscriminatorType(value.GetType().Name);
			}
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x00043338 File Offset: 0x00041538
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> GetMappingFragmentsWithColumnAsDefaultDiscriminator(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			return from tmf in databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping ecm) => ecm.EntitySetMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntitySetMapping esm) => esm.EntityTypeMappings).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments)
			where tmf.Table == table && tmf.GetDefaultDiscriminator() == column
			select tmf;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000433DC File Offset: 0x000415DC
		internal static bool AnyBaseTypeToTableWithoutColumnCondition(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping, bool> <>9__3;
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType baseType = entityType.BaseType; baseType != null; baseType = baseType.BaseType)
			{
				if (!baseType.Abstract)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.MappingFragment> source = databaseMapping.GetEntityTypeMappings((global::System.Data.Entity.Core.Metadata.Edm.EntityType)baseType).SelectMany((global::System.Data.Entity.Core.Mapping.EntityTypeMapping etm) => etm.MappingFragments);
					global::System.Func<global::System.Data.Entity.Core.Mapping.MappingFragment, bool> predicate;
					if ((predicate = <>9__1) == null)
					{
						predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.MappingFragment tmf) => tmf.Table == table));
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.MappingFragment> source2 = source.Where(predicate).ToList<global::System.Data.Entity.Core.Mapping.MappingFragment>();
					if (source2.Any<global::System.Data.Entity.Core.Mapping.MappingFragment>())
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> source3 = source2.SelectMany((global::System.Data.Entity.Core.Mapping.MappingFragment etmf) => etmf.ColumnConditions);
						global::System.Func<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping, bool> predicate2;
						if ((predicate2 = <>9__3) == null)
						{
							predicate2 = (<>9__3 = ((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc) => cc.Column != column));
						}
						if (source3.All(predicate2))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000434D4 File Offset: 0x000416D4
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = fragment.Table.Properties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => string.Equals(c.Name, this.Discriminator, global::System.StringComparison.Ordinal));
			if (edmProperty != null && global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration.GetMappingFragmentsWithColumnAsDefaultDiscriminator(databaseMapping, fragment.Table, edmProperty).Any<global::System.Data.Entity.Core.Mapping.MappingFragment>())
			{
				edmProperty.Name = (from p in fragment.Table.Properties
				select p.Name).Uniquify(edmProperty.Name);
				edmProperty = null;
			}
			if (edmProperty == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType = providerManifest.GetStoreType(global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.DiscriminatorTypeUsage);
				edmProperty = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(this.Discriminator, storeType)
				{
					Nullable = false
				};
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.AddColumn(fragment.Table, edmProperty);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration.AnyBaseTypeToTableWithoutColumnCondition(databaseMapping, entityType, fragment.Table, edmProperty))
			{
				edmProperty.Nullable = true;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = edmProperty.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
			if (this.Value != null)
			{
				this.ConfigureColumnType(providerManifest, primitivePropertyConfiguration, edmProperty);
				fragment.AddDiscriminatorCondition(edmProperty, this.Value);
			}
			else
			{
				if (string.IsNullOrWhiteSpace(edmProperty.TypeName))
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage storeType2 = providerManifest.GetStoreType(global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.DiscriminatorTypeUsage);
					edmProperty.PrimitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)storeType2.EdmType;
					edmProperty.MaxLength = new int?(128);
					edmProperty.Nullable = false;
				}
				this.GetOrCreateConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>().IsNullable = new bool?(true);
				fragment.AddNullabilityCondition(edmProperty, true);
			}
			if (this._configuration == null)
			{
				return;
			}
			string p2;
			if (primitivePropertyConfiguration != null && (primitivePropertyConfiguration.OverridableConfigurationParts & global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace) != global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInCSpace && !primitivePropertyConfiguration.IsCompatible(this._configuration, true, out p2))
			{
				throw global::System.Data.Entity.Resources.Error.ConflictingColumnConfiguration(edmProperty, fragment.Table, p2);
			}
			if (this._configuration.IsNullable != null)
			{
				edmProperty.Nullable = this._configuration.IsNullable.Value;
			}
			this._configuration.Configure(edmProperty, fragment.Table, providerManifest, false, false);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000436A4 File Offset: 0x000418A4
		private void ConfigureColumnType(global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration existingConfiguration, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty discriminatorColumn)
		{
			if ((existingConfiguration != null && existingConfiguration.ColumnType != null) || (this._configuration != null && this._configuration.ColumnType != null))
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			this.Value.GetType().IsPrimitiveType(out primitiveType);
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2 = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)providerManifest.GetStoreType((primitiveType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)) ? global::System.Data.Entity.ModelConfiguration.Edm.Services.DatabaseMappingGenerator.DiscriminatorTypeUsage : global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(primitiveType.PrimitiveTypeKind))).EdmType;
			if (existingConfiguration != null && !discriminatorColumn.TypeName.Equals(primitiveType2.Name, global::System.StringComparison.OrdinalIgnoreCase))
			{
				throw global::System.Data.Entity.Resources.Error.ConflictingInferredColumnType(discriminatorColumn.Name, discriminatorColumn.TypeName, primitiveType2.Name);
			}
			discriminatorColumn.PrimitiveType = primitiveType2;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0004374D File Offset: 0x0004194D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00043755 File Offset: 0x00041955
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0004375E File Offset: 0x0004195E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00043766 File Offset: 0x00041966
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A78 RID: 2680
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration _entityMappingConfiguration;

		// Token: 0x04000A7B RID: 2683
		private global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration _configuration;
	}
}
