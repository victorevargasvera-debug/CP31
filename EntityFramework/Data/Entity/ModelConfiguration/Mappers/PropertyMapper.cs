using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x0200015C RID: 348
	internal sealed class PropertyMapper
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x00038215 File Offset: 0x00036415
		public PropertyMapper(global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper typeMapper)
		{
			this._typeMapper = typeMapper;
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00038224 File Offset: 0x00036424
		public void Map(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> complexTypeConfiguration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = this.MapPrimitiveOrComplexOrEnumProperty(propertyInfo, complexTypeConfiguration, true);
			if (edmProperty != null)
			{
				complexType.AddMember(edmProperty);
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00038248 File Offset: 0x00036448
		public void Map(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = this.MapPrimitiveOrComplexOrEnumProperty(propertyInfo, entityTypeConfiguration, false);
			if (edmProperty != null)
			{
				entityType.AddMember(edmProperty);
				return;
			}
			new global::System.Data.Entity.ModelConfiguration.Mappers.NavigationPropertyMapper(this._typeMapper).Map(propertyInfo, entityType, entityTypeConfiguration);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00038280 File Offset: 0x00036480
		internal bool MapIfNotNavigationProperty(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = this.MapPrimitiveOrComplexOrEnumProperty(propertyInfo, entityTypeConfiguration, false);
			if (edmProperty != null)
			{
				entityType.AddMember(edmProperty);
				return true;
			}
			return false;
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000382A4 File Offset: 0x000364A4
		private global::System.Data.Entity.Core.Metadata.Edm.EdmProperty MapPrimitiveOrComplexOrEnumProperty(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration> structuralTypeConfiguration, bool discoverComplexTypes = false)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = propertyInfo.AsEdmPrimitiveProperty();
			if (edmProperty == null)
			{
				global::System.Type propertyType = propertyInfo.PropertyType;
				global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = this._typeMapper.MapComplexType(propertyType, discoverComplexTypes);
				if (complexType != null)
				{
					edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateComplex(propertyInfo.Name, complexType);
				}
				else
				{
					bool nullable = propertyType.TryUnwrapNullableType(out propertyType);
					if (propertyType.IsEnum())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = this._typeMapper.MapEnumType(propertyType);
						if (enumType != null)
						{
							edmProperty = global::System.Data.Entity.Core.Metadata.Edm.EdmProperty.CreateEnum(propertyInfo.Name, enumType);
							edmProperty.Nullable = nullable;
						}
					}
				}
			}
			if (edmProperty != null)
			{
				edmProperty.SetClrPropertyInfo(propertyInfo);
				new global::System.Data.Entity.ModelConfiguration.Mappers.AttributeMapper(this._typeMapper.MappingContext.AttributeProvider).Map(propertyInfo, edmProperty.GetMetadataProperties());
				if (!edmProperty.IsComplexType)
				{
					this._typeMapper.MappingContext.ConventionsConfiguration.ApplyPropertyConfiguration(propertyInfo, () => structuralTypeConfiguration().Property(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), null), this._typeMapper.MappingContext.ModelConfiguration);
				}
			}
			return edmProperty;
		}

		// Token: 0x040009FD RID: 2557
		private readonly global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper _typeMapper;
	}
}
