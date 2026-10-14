using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000199 RID: 409
	public class ComplexTypeAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.TypeAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute>
	{
		// Token: 0x06001741 RID: 5953 RVA: 0x0003D019 File Offset: 0x0003B219
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.ComplexTypeAttribute>(attribute, "attribute");
			configuration.IsComplexType();
		}
	}
}
