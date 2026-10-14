using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000197 RID: 407
	public class StringLengthAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.StringLengthAttribute>
	{
		// Token: 0x0600173D RID: 5949 RVA: 0x0003CF94 File Offset: 0x0003B194
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.StringLengthAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.StringLengthAttribute>(attribute, "attribute");
			if (attribute.MaximumLength < 1)
			{
				global::System.Reflection.PropertyInfo clrPropertyInfo = configuration.ClrPropertyInfo;
				throw global::System.Data.Entity.Resources.Error.StringLengthAttributeConvention_InvalidMaximumLength(clrPropertyInfo.Name, clrPropertyInfo.ReflectedType);
			}
			configuration.HasMaxLength(attribute.MaximumLength);
		}
	}
}
