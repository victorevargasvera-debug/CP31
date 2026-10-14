using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Mappers
{
	// Token: 0x0200015D RID: 349
	internal sealed class TypeMapper
	{
		// Token: 0x0600160A RID: 5642 RVA: 0x000383BC File Offset: 0x000365BC
		public TypeMapper(global::System.Data.Entity.ModelConfiguration.Mappers.MappingContext mappingContext)
		{
			this._mappingContext = mappingContext;
			this._knownTypes.AddRange((from t in mappingContext.ModelConfiguration.ConfiguredTypes
			select t.Assembly()).Distinct<global::System.Reflection.Assembly>().SelectMany((global::System.Reflection.Assembly a) => from type in a.GetAccessibleTypes()
			where type.IsValidStructuralType()
			select type));
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00038444 File Offset: 0x00036644
		public global::System.Data.Entity.ModelConfiguration.Mappers.MappingContext MappingContext
		{
			get
			{
				return this._mappingContext;
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0003844C File Offset: 0x0003664C
		public global::System.Data.Entity.Core.Metadata.Edm.EnumType MapEnumType(global::System.Type type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper.GetExistingEdmType<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(this._mappingContext.Model, type);
			if (enumType == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType underlyingType;
				if (!global::System.Enum.GetUnderlyingType(type).IsPrimitiveType(out underlyingType))
				{
					return null;
				}
				enumType = this._mappingContext.Model.AddEnumType(type.Name, this._mappingContext.ModelConfiguration.ModelNamespace);
				enumType.IsFlags = type.GetCustomAttributes(false).Any<global::System.FlagsAttribute>();
				enumType.SetClrType(type);
				enumType.UnderlyingType = underlyingType;
				foreach (string text in global::System.Enum.GetNames(type))
				{
					enumType.AddMember(new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(text, global::System.Convert.ChangeType(global::System.Enum.Parse(type, text), type.GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture)));
				}
			}
			return enumType;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x0003850C File Offset: 0x0003670C
		public global::System.Data.Entity.Core.Metadata.Edm.ComplexType MapComplexType(global::System.Type type, bool discoverNested = false)
		{
			if (!type.IsValidStructuralType())
			{
				return null;
			}
			this._mappingContext.ConventionsConfiguration.ApplyModelConfiguration(type, this._mappingContext.ModelConfiguration);
			if (this._mappingContext.ModelConfiguration.IsIgnoredType(type) || (!discoverNested && !this._mappingContext.ModelConfiguration.IsComplexType(type)))
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper.GetExistingEdmType<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(this._mappingContext.Model, type);
			if (complexType == null)
			{
				complexType = this._mappingContext.Model.AddComplexType(type.Name, this._mappingContext.ModelConfiguration.ModelNamespace);
				global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> complexTypeConfiguration = () => this._mappingContext.ModelConfiguration.ComplexType(type);
				this._mappingContext.ConventionsConfiguration.ApplyTypeConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>(type, complexTypeConfiguration, this._mappingContext.ModelConfiguration);
				this.MapStructuralElements<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>(type, complexType.GetMetadataProperties(), delegate(global::System.Data.Entity.ModelConfiguration.Mappers.PropertyMapper m, global::System.Reflection.PropertyInfo p)
				{
					m.Map(p, complexType, complexTypeConfiguration);
				}, complexTypeConfiguration);
			}
			return complexType;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00038680 File Offset: 0x00036880
		public global::System.Data.Entity.Core.Metadata.Edm.EntityType MapEntityType(global::System.Type type)
		{
			if (!type.IsValidStructuralType() || this._mappingContext.ModelConfiguration.IsIgnoredType(type) || this._mappingContext.ModelConfiguration.IsComplexType(type))
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = global::System.Data.Entity.ModelConfiguration.Mappers.TypeMapper.GetExistingEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(this._mappingContext.Model, type);
			if (entityType == null)
			{
				this._mappingContext.ConventionsConfiguration.ApplyModelConfiguration(type, this._mappingContext.ModelConfiguration);
				if (this._mappingContext.ModelConfiguration.IsIgnoredType(type) || this._mappingContext.ModelConfiguration.IsComplexType(type))
				{
					return null;
				}
				entityType = this._mappingContext.Model.AddEntityType(type.Name, this._mappingContext.ModelConfiguration.ModelNamespace);
				entityType.Abstract = type.IsAbstract();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this._mappingContext.Model.GetEntityType(type.BaseType().Name);
				if (entityType2 == null)
				{
					this._mappingContext.Model.AddEntitySet(entityType.Name, entityType, null);
				}
				else if (entityType2 == entityType)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.SimpleNameCollision(type.FullName, type.BaseType().FullName, type.Name));
				}
				entityType.BaseType = entityType2;
				global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration = () => this._mappingContext.ModelConfiguration.Entity(type);
				this._mappingContext.ConventionsConfiguration.ApplyTypeConfiguration<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>(type, entityTypeConfiguration, this._mappingContext.ModelConfiguration);
				global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> navigationProperties = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
				this.MapStructuralElements<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>(type, entityType.GetMetadataProperties(), delegate(global::System.Data.Entity.ModelConfiguration.Mappers.PropertyMapper m, global::System.Reflection.PropertyInfo p)
				{
					if (!m.MapIfNotNavigationProperty(p, entityType, entityTypeConfiguration))
					{
						navigationProperties.Add(p);
					}
				}, entityTypeConfiguration);
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable = navigationProperties;
				if (this._mappingContext.ModelBuilderVersion.IsEF6OrHigher())
				{
					enumerable = from p in enumerable
					orderby p.Name
					select p;
				}
				foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable)
				{
					new global::System.Data.Entity.ModelConfiguration.Mappers.NavigationPropertyMapper(this).Map(propertyInfo, entityType, entityTypeConfiguration);
				}
				if (entityType.BaseType != null)
				{
					this.LiftInheritedProperties(type, entityType);
				}
				this.MapDerivedTypes(type, entityType);
			}
			return entityType;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000389F0 File Offset: 0x00036BF0
		private static T GetExistingEdmType<T>(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Type type) where T : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType structuralOrEnumType = model.GetStructuralOrEnumType(type.Name);
			if (structuralOrEnumType != null && type != structuralOrEnumType.GetClrType())
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.SimpleNameCollision(type.FullName, structuralOrEnumType.GetClrType().FullName, type.Name));
			}
			return structuralOrEnumType as T;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00038A48 File Offset: 0x00036C48
		private void MapStructuralElements<TStructuralTypeConfiguration>(global::System.Type type, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> annotations, global::System.Action<global::System.Data.Entity.ModelConfiguration.Mappers.PropertyMapper, global::System.Reflection.PropertyInfo> propertyMappingAction, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration) where TStructuralTypeConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration
		{
			annotations.SetClrType(type);
			new global::System.Data.Entity.ModelConfiguration.Mappers.AttributeMapper(this._mappingContext.AttributeProvider).Map(type, annotations);
			global::System.Data.Entity.ModelConfiguration.Mappers.PropertyMapper arg = new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyMapper(this);
			global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> list = new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter(this._mappingContext.ModelBuilderVersion).GetProperties(type, false, this._mappingContext.ModelConfiguration.GetConfiguredProperties(type), this._mappingContext.ModelConfiguration.StructuralTypes, false).ToList<global::System.Reflection.PropertyInfo>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Reflection.PropertyInfo propertyInfo = list[i];
				this._mappingContext.ConventionsConfiguration.ApplyPropertyConfiguration(propertyInfo, this._mappingContext.ModelConfiguration);
				this._mappingContext.ConventionsConfiguration.ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(propertyInfo, structuralTypeConfiguration, this._mappingContext.ModelConfiguration);
				if (!this._mappingContext.ModelConfiguration.IsIgnoredProperty(type, propertyInfo))
				{
					propertyMappingAction(arg, propertyInfo);
				}
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00038B28 File Offset: 0x00036D28
		private void MapDerivedTypes(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (type.IsSealed())
			{
				return;
			}
			if (!this._knownTypes.Contains(type))
			{
				this._knownTypes.AddRange(from t in type.Assembly().GetAccessibleTypes()
				where t.IsValidStructuralType()
				select t);
			}
			global::System.Collections.Generic.IEnumerable<global::System.Type> source = from t in this._knownTypes
			where t.BaseType() == type
			select t;
			if (this._mappingContext.ModelBuilderVersion.IsEF6OrHigher())
			{
				source = from t in source
				orderby t.FullName
				select t;
			}
			global::System.Collections.Generic.List<global::System.Type> list = source.ToList<global::System.Type>();
			for (int i = 0; i < list.Count; i++)
			{
				global::System.Type type2 = list[i];
				global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this.MapEntityType(type2);
				if (entityType2 != null)
				{
					entityType2.BaseType = entityType;
					this.LiftDerivedType(type2, entityType2, entityType);
				}
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00038C34 File Offset: 0x00036E34
		private void LiftDerivedType(global::System.Type derivedType, global::System.Data.Entity.Core.Metadata.Edm.EntityType derivedEntityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			this._mappingContext.Model.ReplaceEntitySet(derivedEntityType, this._mappingContext.Model.GetEntitySet(entityType));
			this.LiftInheritedProperties(derivedType, derivedEntityType);
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x00038C60 File Offset: 0x00036E60
		private void LiftInheritedProperties(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = this._mappingContext.ModelConfiguration.GetStructuralTypeConfiguration(type) as global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration;
			if (entityTypeConfiguration != null)
			{
				entityTypeConfiguration.ClearKey();
				using (global::System.Collections.Generic.IEnumerator<global::System.Reflection.PropertyInfo> enumerator = type.BaseType().GetInstanceProperties().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Reflection.PropertyInfo property = enumerator.Current;
						if (!this._mappingContext.AttributeProvider.GetAttributes(property).OfType<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>().Any<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>() && entityTypeConfiguration.IgnoredProperties.Any((global::System.Reflection.PropertyInfo p) => p.IsSameAs(property)))
						{
							throw global::System.Data.Entity.Resources.Error.CannotIgnoreMappedBaseProperty(property.Name, type, property.DeclaringType);
						}
					}
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> list = entityType.DeclaredMembers.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			global::System.Collections.Generic.HashSet<global::System.Reflection.PropertyInfo> hashSet = new global::System.Collections.Generic.HashSet<global::System.Reflection.PropertyInfo>(new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter(this._mappingContext.ModelBuilderVersion).GetProperties(type, true, this._mappingContext.ModelConfiguration.GetConfiguredProperties(type), this._mappingContext.ModelConfiguration.StructuralTypes, false));
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in list)
			{
				global::System.Reflection.PropertyInfo clrPropertyInfo = edmMember.GetClrPropertyInfo();
				if (!hashSet.Contains(clrPropertyInfo))
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty;
					if (navigationProperty != null)
					{
						this._mappingContext.Model.RemoveAssociationType(navigationProperty.Association);
					}
					entityType.RemoveMember(edmMember);
				}
			}
		}

		// Token: 0x040009FE RID: 2558
		private readonly global::System.Data.Entity.ModelConfiguration.Mappers.MappingContext _mappingContext;

		// Token: 0x040009FF RID: 2559
		private readonly global::System.Collections.Generic.List<global::System.Type> _knownTypes = new global::System.Collections.Generic.List<global::System.Type>();
	}
}
