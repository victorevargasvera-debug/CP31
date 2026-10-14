using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000190 RID: 400
	public class KeyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.Convention
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x0003CC68 File Offset: 0x0003AE68
		internal override void ApplyPropertyTypeConfiguration<TStructuralTypeConfiguration>(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<TStructuralTypeConfiguration> structuralTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (typeof(TStructuralTypeConfiguration) == typeof(global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration) && this._attributeProvider.GetAttributes(propertyInfo).OfType<global::System.ComponentModel.DataAnnotations.KeyAttribute>().Any<global::System.ComponentModel.DataAnnotations.KeyAttribute>())
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)((object)structuralTypeConfiguration());
				if (propertyInfo.IsValidEdmScalarProperty())
				{
					entityTypeConfiguration.Key(propertyInfo);
				}
			}
		}

		// Token: 0x04000A2B RID: 2603
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
	}
}
