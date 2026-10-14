using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018B RID: 395
	public class ConcurrencyCheckAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.ConcurrencyCheckAttribute>
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x0003CA23 File Offset: 0x0003AC23
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.ConcurrencyCheckAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.ConcurrencyCheckAttribute>(attribute, "attribute");
			configuration.IsConcurrencyToken();
		}
	}
}
