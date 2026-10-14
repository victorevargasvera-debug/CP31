using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000191 RID: 401
	public class MaxLengthAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.MaxLengthAttribute>
	{
		// Token: 0x0600172E RID: 5934 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.MaxLengthAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.MaxLengthAttribute>(attribute, "attribute");
			global::System.Reflection.PropertyInfo clrPropertyInfo = configuration.ClrPropertyInfo;
			if (attribute.Length == 0 || attribute.Length < -1)
			{
				throw global::System.Data.Entity.Resources.Error.MaxLengthAttributeConvention_InvalidMaxLength(clrPropertyInfo.Name, clrPropertyInfo.ReflectedType);
			}
			if (attribute.Length == -1)
			{
				configuration.IsMaxLength();
				return;
			}
			configuration.HasMaxLength(attribute.Length);
		}

		// Token: 0x04000A2C RID: 2604
		private const int MaxLengthIndicator = -1;
	}
}
