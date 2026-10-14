using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x0200015A RID: 346
	internal sealed class NavigationPropertyMapper
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x00037E96 File Offset: 0x00036096
		public NavigationPropertyMapper(global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper typeMapper)
		{
			this._typeMapper = typeMapper;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00037EA8 File Offset: 0x000360A8
		public void Map(global::System.Reflection.PropertyInfo propertyInfo, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration)
		{
			global::System.Type propertyType = propertyInfo.PropertyType;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity relationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne;
			if (propertyType.IsCollection(out propertyType))
			{
				relationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this._typeMapper.MapEntityType(propertyType);
			if (entityType2 != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity sourceAssociationEndKind = relationshipMultiplicity.IsMany() ? global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne : global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = this._typeMapper.MappingContext.Model.AddAssociationType(entityType.Name + "_" + propertyInfo.Name, entityType, sourceAssociationEndKind, entityType2, relationshipMultiplicity, this._typeMapper.MappingContext.ModelConfiguration.ModelNamespace);
				associationType.SourceEnd.SetClrPropertyInfo(propertyInfo);
				this._typeMapper.MappingContext.Model.AddAssociationSet(associationType.Name, associationType);
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = entityType.AddNavigationProperty(propertyInfo.Name, associationType);
				navigationProperty.SetClrPropertyInfo(propertyInfo);
				this._typeMapper.MappingContext.ConventionsConfiguration.ApplyPropertyConfiguration(propertyInfo, () => entityTypeConfiguration().Navigation(propertyInfo), this._typeMapper.MappingContext.ModelConfiguration);
				new global::System.Data.Entity.ModelConfiguration.Mappers.AttributeMapper(this._typeMapper.MappingContext.AttributeProvider).Map(propertyInfo, navigationProperty.GetMetadataProperties());
			}
		}

		// Token: 0x040009FB RID: 2555
		private readonly global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper _typeMapper;
	}
}
