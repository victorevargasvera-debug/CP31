using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000195 RID: 405
	public class RequiredNavigationPropertyAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.Convention
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x0003CEF0 File Offset: 0x0003B0F0
		internal override void ApplyPropertyConfiguration(global::System.Reflection.PropertyInfo propertyInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.PropertyConfiguration> propertyConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (propertyInfo.IsValidEdmNavigationProperty() && !propertyInfo.PropertyType.IsCollection() && this._attributeProvider.GetAttributes(propertyInfo).OfType<global::System.ComponentModel.DataAnnotations.RequiredAttribute>().Any<global::System.ComponentModel.DataAnnotations.RequiredAttribute>())
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration)propertyConfiguration();
				if (navigationPropertyConfiguration.RelationshipMultiplicity == null)
				{
					navigationPropertyConfiguration.RelationshipMultiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
				}
			}
		}

		// Token: 0x04000A2F RID: 2607
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
	}
}
