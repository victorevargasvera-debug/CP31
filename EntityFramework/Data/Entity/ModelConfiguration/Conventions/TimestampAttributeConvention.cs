using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000198 RID: 408
	public class TimestampAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.TimestampAttribute>
	{
		// Token: 0x0600173F RID: 5951 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.TimestampAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.TimestampAttribute>(attribute, "attribute");
			configuration.IsRowVersion();
		}
	}
}
