using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019B RID: 411
	public class TableAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.TypeAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.TableAttribute>
	{
		// Token: 0x06001745 RID: 5957 RVA: 0x0003D06C File Offset: 0x0003B26C
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.TableAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.TableAttribute>(attribute, "attribute");
			if (string.IsNullOrWhiteSpace(attribute.Schema))
			{
				configuration.ToTable(attribute.Name);
				return;
			}
			configuration.ToTable(attribute.Name, attribute.Schema);
		}
	}
}
