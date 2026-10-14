using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000192 RID: 402
	public class NotMappedPropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x0003CD55 File Offset: 0x0003AF55
		public override void Apply(global::System.Reflection.PropertyInfo memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(memberInfo, "memberInfo");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute>(attribute, "attribute");
			configuration.Ignore(memberInfo);
		}
	}
}
