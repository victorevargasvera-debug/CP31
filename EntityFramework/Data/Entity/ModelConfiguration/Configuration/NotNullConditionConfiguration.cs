using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Mapping;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E0 RID: 480
	public class NotNullConditionConfiguration
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00042EC3 File Offset: 0x000410C3
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00042ECB File Offset: 0x000410CB
		internal global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath PropertyPath { get; set; }

		// Token: 0x06001938 RID: 6456 RVA: 0x00042ED4 File Offset: 0x000410D4
		internal NotNullConditionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration entityMapConfiguration, global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath propertyPath)
		{
			this._entityMappingConfiguration = entityMapConfiguration;
			this.PropertyPath = propertyPath;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00042EEA File Offset: 0x000410EA
		private NotNullConditionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration owner, global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration source)
		{
			this._entityMappingConfiguration = owner;
			this.PropertyPath = source.PropertyPath;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00042F05 File Offset: 0x00041105
		internal virtual global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration Clone(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration owner)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration(owner, this);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00042F0E File Offset: 0x0004110E
		public void HasValue()
		{
			this._entityMappingConfiguration.AddNullabilityCondition(this);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00042F1C File Offset: 0x0004111C
		internal void Configure(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Mapping.MappingFragment fragment, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath> edmPropertyPath = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration.PropertyPathToEdmPropertyPath(this.PropertyPath, entityType);
			if (edmPropertyPath.Count<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>() > 1)
			{
				throw global::System.Data.Entity.Resources.Error.InvalidNotNullCondition(this.PropertyPath.ToString(), entityType.Name);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (from pm in fragment.ColumnMappings
			where pm.PropertyPath.SequenceEqual(edmPropertyPath.Single<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>())
			select pm.ColumnProperty).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			if (edmProperty == null || !fragment.Table.Properties.Contains(edmProperty))
			{
				throw global::System.Data.Entity.Resources.Error.InvalidNotNullCondition(this.PropertyPath.ToString(), entityType.Name);
			}
			if (global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration.AnyBaseTypeToTableWithoutColumnCondition(databaseMapping, entityType, fragment.Table, edmProperty))
			{
				edmProperty.Nullable = true;
			}
			new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration
			{
				IsNullable = new bool?(false),
				OverridableConfigurationParts = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace
			}.Configure(edmPropertyPath.Single<global::System.Data.Entity.ModelConfiguration.Utilities.EdmPropertyPath>().Last<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			fragment.AddNullabilityCondition(edmProperty, false);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00043020 File Offset: 0x00041220
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00043028 File Offset: 0x00041228
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00043031 File Offset: 0x00041231
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00043039 File Offset: 0x00041239
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A75 RID: 2677
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration _entityMappingConfiguration;
	}
}
