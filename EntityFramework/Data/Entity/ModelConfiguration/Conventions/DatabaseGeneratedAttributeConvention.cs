using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018C RID: 396
	public class DatabaseGeneratedAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute>
	{
		// Token: 0x06001725 RID: 5925 RVA: 0x0003CA4C File Offset: 0x0003AC4C
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute>(attribute, "attribute");
			configuration.HasDatabaseGeneratedOption(attribute.DatabaseGeneratedOption);
		}
	}
}
