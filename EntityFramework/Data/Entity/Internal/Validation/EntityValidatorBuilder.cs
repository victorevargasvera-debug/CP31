using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000133 RID: 307
	internal class EntityValidatorBuilder
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x000352B0 File Offset: 0x000334B0
		public EntityValidatorBuilder(global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider)
		{
			this._attributeProvider = attributeProvider;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000352C0 File Offset: 0x000334C0
		public virtual global::System.Data.Entity.Internal.Validation.EntityValidator BuildEntityValidator(global::System.Data.Entity.Internal.InternalEntityEntry entityEntry)
		{
			return this.BuildTypeValidator<global::System.Data.Entity.Internal.Validation.EntityValidator>(entityEntry.EntityType, entityEntry.EdmEntityType.Properties, entityEntry.EdmEntityType.NavigationProperties, (global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> propertyValidators, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> typeLevelValidators) => new global::System.Data.Entity.Internal.Validation.EntityValidator(propertyValidators, typeLevelValidators));
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0003530E File Offset: 0x0003350E
		protected virtual global::System.Data.Entity.Internal.Validation.ComplexTypeValidator BuildComplexTypeValidator(global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType)
		{
			return this.BuildTypeValidator<global::System.Data.Entity.Internal.Validation.ComplexTypeValidator>(clrType, complexType.Properties, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(), (global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator> propertyValidators, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> typeLevelValidators) => new global::System.Data.Entity.Internal.Validation.ComplexTypeValidator(propertyValidators, typeLevelValidators));
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00035344 File Offset: 0x00033544
		private T BuildTypeValidator<T>(global::System.Type clrType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> edmProperties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> navigationProperties, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.PropertyValidator>, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator>, T> validatorFactoryFunc) where T : global::System.Data.Entity.Internal.Validation.TypeValidator
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Internal.Validation.PropertyValidator> list = this.BuildValidatorsForProperties(this.GetPublicInstanceProperties(clrType), edmProperties, navigationProperties);
			global::System.Collections.Generic.IEnumerable<global::System.Attribute> attributes = this._attributeProvider.GetAttributes(clrType);
			global::System.Collections.Generic.IList<global::System.Data.Entity.Internal.Validation.IValidator> list2 = this.BuildValidationAttributeValidators(attributes);
			if (typeof(global::System.ComponentModel.DataAnnotations.IValidatableObject).IsAssignableFrom(clrType))
			{
				list2.Add(new global::System.Data.Entity.Internal.Validation.ValidatableObjectValidator(attributes.OfType<global::System.ComponentModel.DataAnnotations.DisplayAttribute>().SingleOrDefault<global::System.ComponentModel.DataAnnotations.DisplayAttribute>()));
			}
			if (!list.Any<global::System.Data.Entity.Internal.Validation.PropertyValidator>() && !list2.Any<global::System.Data.Entity.Internal.Validation.IValidator>())
			{
				return default(T);
			}
			return validatorFactoryFunc(list, list2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000353C4 File Offset: 0x000335C4
		protected virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Internal.Validation.PropertyValidator> BuildValidatorsForProperties(global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> edmProperties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> navigationProperties)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Internal.Validation.PropertyValidator> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Internal.Validation.PropertyValidator>();
			using (global::System.Collections.Generic.IEnumerator<global::System.Reflection.PropertyInfo> enumerator = clrProperties.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Reflection.PropertyInfo property = enumerator.Current;
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (from p in edmProperties
					where p.Name == property.Name
					select p).SingleOrDefault<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					global::System.Data.Entity.Internal.Validation.PropertyValidator propertyValidator;
					if (edmProperty != null)
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint> source = from navigationProperty in navigationProperties
						let associationType = navigationProperty.RelationshipType as global::System.Data.Entity.Core.Metadata.Edm.AssociationType
						where associationType != null
						from constraint in associationType.ReferentialConstraints
						where constraint.ToProperties.Contains(edmProperty)
						select constraint;
						propertyValidator = this.BuildPropertyValidator(property, edmProperty, !source.Any<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>());
					}
					else
					{
						propertyValidator = this.BuildPropertyValidator(property);
					}
					if (propertyValidator != null)
					{
						list.Add(propertyValidator);
					}
				}
			}
			return list;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00035558 File Offset: 0x00033758
		protected virtual global::System.Data.Entity.Internal.Validation.PropertyValidator BuildPropertyValidator(global::System.Reflection.PropertyInfo clrProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty, bool buildFacetValidators)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Internal.Validation.IValidator> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Internal.Validation.IValidator>();
			global::System.Collections.Generic.IEnumerable<global::System.Attribute> attributes = this._attributeProvider.GetAttributes(clrProperty);
			list.AddRange(this.BuildValidationAttributeValidators(attributes));
			if (edmProperty.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmProperty.TypeUsage.EdmType;
				global::System.Data.Entity.Internal.Validation.ComplexTypeValidator complexTypeValidator = this.BuildComplexTypeValidator(clrProperty.PropertyType, complexType);
				if (!list.Any<global::System.Data.Entity.Internal.Validation.IValidator>() && complexTypeValidator == null)
				{
					return null;
				}
				return new global::System.Data.Entity.Internal.Validation.ComplexPropertyValidator(clrProperty.Name, list, complexTypeValidator);
			}
			else
			{
				if (buildFacetValidators)
				{
					list.AddRange(this.BuildFacetValidators(clrProperty, edmProperty, attributes));
				}
				if (!list.Any<global::System.Data.Entity.Internal.Validation.IValidator>())
				{
					return null;
				}
				return new global::System.Data.Entity.Internal.Validation.PropertyValidator(clrProperty.Name, list);
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000355FC File Offset: 0x000337FC
		protected virtual global::System.Data.Entity.Internal.Validation.PropertyValidator BuildPropertyValidator(global::System.Reflection.PropertyInfo clrProperty)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Internal.Validation.IValidator> list = this.BuildValidationAttributeValidators(this._attributeProvider.GetAttributes(clrProperty));
			if (list.Count <= 0)
			{
				return null;
			}
			return new global::System.Data.Entity.Internal.Validation.PropertyValidator(clrProperty.Name, list);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00035634 File Offset: 0x00033834
		protected virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Internal.Validation.IValidator> BuildValidationAttributeValidators(global::System.Collections.Generic.IEnumerable<global::System.Attribute> attributes)
		{
			return (from validationAttribute in attributes
			where validationAttribute is global::System.ComponentModel.DataAnnotations.ValidationAttribute
			select new global::System.Data.Entity.Internal.Validation.ValidationAttributeValidator((global::System.ComponentModel.DataAnnotations.ValidationAttribute)validationAttribute, attributes.OfType<global::System.ComponentModel.DataAnnotations.DisplayAttribute>().SingleOrDefault<global::System.ComponentModel.DataAnnotations.DisplayAttribute>())).ToList<global::System.Data.Entity.Internal.Validation.IValidator>();
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0003568E File Offset: 0x0003388E
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> GetPublicInstanceProperties(global::System.Type type)
		{
			return from p in type.GetInstanceProperties()
			where p.IsPublic() && p.GetIndexParameters().Length == 0 && p.Getter() != null
			select p;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000356BC File Offset: 0x000338BC
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.Validation.IValidator> BuildFacetValidators(global::System.Reflection.PropertyInfo clrProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmProperty, global::System.Collections.Generic.IEnumerable<global::System.Attribute> existingAttributes)
		{
			global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.ValidationAttribute> list = new global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.ValidationAttribute>();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty;
			edmProperty.MetadataProperties.TryGetValue("http://schemas.microsoft.com/ado/2009/02/edm/annotation:StoreGeneratedPattern", false, out metadataProperty);
			bool flag = metadataProperty != null && metadataProperty.Value != null;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			edmProperty.TypeUsage.Facets.TryGetValue("Nullable", false, out facet);
			if (facet != null && facet.Value != null && !(bool)facet.Value && !flag && clrProperty.PropertyType.IsNullable())
			{
				if (!existingAttributes.Any((global::System.Attribute a) => a is global::System.ComponentModel.DataAnnotations.RequiredAttribute))
				{
					list.Add(new global::System.ComponentModel.DataAnnotations.RequiredAttribute
					{
						AllowEmptyStrings = true
					});
				}
			}
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet2;
			edmProperty.TypeUsage.Facets.TryGetValue("MaxLength", false, out facet2);
			if (facet2 != null && facet2.Value != null && facet2.Value is int)
			{
				if (!existingAttributes.Any((global::System.Attribute a) => a is global::System.ComponentModel.DataAnnotations.MaxLengthAttribute))
				{
					if (!existingAttributes.Any((global::System.Attribute a) => a is global::System.ComponentModel.DataAnnotations.StringLengthAttribute))
					{
						list.Add(new global::System.ComponentModel.DataAnnotations.MaxLengthAttribute((int)facet2.Value));
					}
				}
			}
			return from attribute in list
			select new global::System.Data.Entity.Internal.Validation.ValidationAttributeValidator(attribute, existingAttributes.OfType<global::System.ComponentModel.DataAnnotations.DisplayAttribute>().SingleOrDefault<global::System.ComponentModel.DataAnnotations.DisplayAttribute>());
		}

		// Token: 0x040009BB RID: 2491
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider;
	}
}
