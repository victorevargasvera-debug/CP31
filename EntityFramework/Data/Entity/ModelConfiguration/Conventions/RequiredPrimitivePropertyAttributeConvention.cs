using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000196 RID: 406
	public class RequiredPrimitivePropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.RequiredAttribute>
	{
		// Token: 0x0600173B RID: 5947 RVA: 0x0003CF6A File Offset: 0x0003B16A
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.RequiredAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.RequiredAttribute>(attribute, "attribute");
			configuration.IsRequired();
		}
	}
}
