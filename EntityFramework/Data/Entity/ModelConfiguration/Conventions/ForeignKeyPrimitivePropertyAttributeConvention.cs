using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Mappers;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018D RID: 397
	public class ForeignKeyPrimitivePropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute>
	{
		// Token: 0x06001727 RID: 5927 RVA: 0x0003CA7C File Offset: 0x0003AC7C
		public override void Apply(global::System.Reflection.PropertyInfo memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(memberInfo, "memberInfo");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute>(attribute, "attribute");
			if (memberInfo.IsValidEdmScalarProperty())
			{
				global::System.Reflection.PropertyInfo propertyInfo = (from pi in new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter(global::System.Data.Entity.DbModelBuilderVersion.Latest).GetProperties(configuration.ClrType, false, null, null, false)
				where pi.Name.Equals(attribute.Name, global::System.StringComparison.Ordinal)
				select pi).SingleOrDefault<global::System.Reflection.PropertyInfo>();
				if (propertyInfo == null)
				{
					throw global::System.Data.Entity.Resources.Error.ForeignKeyAttributeConvention_InvalidNavigationProperty(memberInfo.Name, configuration.ClrType, attribute.Name);
				}
				configuration.NavigationProperty(propertyInfo).HasConstraint<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration>(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration fk)
				{
					fk.AddColumn(memberInfo);
				});
			}
		}
	}
}
