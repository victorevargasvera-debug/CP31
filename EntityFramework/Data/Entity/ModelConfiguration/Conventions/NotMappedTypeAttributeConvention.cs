using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019A RID: 410
	public class NotMappedTypeAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.TypeAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>
	{
		// Token: 0x06001743 RID: 5955 RVA: 0x0003D042 File Offset: 0x0003B242
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>(attribute, "attribute");
			configuration.Ignore();
		}
	}
}
