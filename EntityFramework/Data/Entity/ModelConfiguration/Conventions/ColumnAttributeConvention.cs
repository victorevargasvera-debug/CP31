using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018A RID: 394
	public class ColumnAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PrimitivePropertyAttributeConfigurationConvention<global::System.ComponentModel.DataAnnotations.Schema.ColumnAttribute>
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		public override void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.ComponentModel.DataAnnotations.Schema.ColumnAttribute attribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.ColumnAttribute>(attribute, "attribute");
			if (!string.IsNullOrWhiteSpace(attribute.Name))
			{
				configuration.HasColumnName(attribute.Name);
			}
			if (!string.IsNullOrWhiteSpace(attribute.TypeName))
			{
				configuration.HasColumnType(attribute.TypeName);
			}
			if (attribute.Order >= 0)
			{
				configuration.HasColumnOrder(attribute.Order);
			}
		}
	}
}
