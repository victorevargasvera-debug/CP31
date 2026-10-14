using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Mappers;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018F RID: 399
	public class InversePropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute>
	{
		// Token: 0x0600172A RID: 5930 RVA: 0x0003CB7C File Offset: 0x0003AD7C
		public override void Apply(global::System.Reflection.PropertyInfo memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(memberInfo, "memberInfo");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.InversePropertyAttribute>(attribute, "attribute");
			if (!memberInfo.IsValidEdmNavigationProperty())
			{
				return;
			}
			global::System.Type targetType = memberInfo.PropertyType.GetTargetType();
			global::System.Reflection.PropertyInfo inverseNavigationProperty = new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter(global::System.Data.Entity.DbModelBuilderVersion.Latest).GetProperties(targetType, false, null, null, false).SingleOrDefault((global::System.Reflection.PropertyInfo p) => string.Equals(p.Name, attribute.Property, global::System.StringComparison.OrdinalIgnoreCase));
			if (inverseNavigationProperty == null)
			{
				throw global::System.Data.Entity.Resources.Error.InversePropertyAttributeConvention_PropertyNotFound(attribute.Property, targetType, memberInfo.Name, memberInfo.ReflectedType);
			}
			if (memberInfo == inverseNavigationProperty)
			{
				throw global::System.Data.Entity.Resources.Error.InversePropertyAttributeConvention_SelfInverseDetected(memberInfo.Name, memberInfo.ReflectedType);
			}
			configuration.NavigationProperty(memberInfo).HasInverseNavigationProperty((global::System.Reflection.PropertyInfo p) => inverseNavigationProperty);
		}
	}
}
