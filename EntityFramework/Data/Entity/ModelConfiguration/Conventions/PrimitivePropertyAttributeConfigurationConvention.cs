using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000193 RID: 403
	public abstract class PrimitivePropertyAttributeConfigurationConvention<TAttribute> : global::System.Data.Entity.ModelConfiguration.Conventions.Convention where TAttribute : global::System.Attribute
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x0003CD8B File Offset: 0x0003AF8B
		protected PrimitivePropertyAttributeConfigurationConvention()
		{
			base.Properties().Having<global::System.Collections.Generic.IEnumerable<TAttribute>>((global::System.Reflection.PropertyInfo pi) => this._attributeProvider.GetAttributes(pi).OfType<TAttribute>()).Configure(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, global::System.Collections.Generic.IEnumerable<TAttribute> attributes)
			{
				foreach (TAttribute attribute in attributes)
				{
					this.Apply(configuration, attribute);
				}
			});
		}

		// Token: 0x06001733 RID: 5939
		public abstract void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration configuration, TAttribute attribute);

		// Token: 0x04000A2D RID: 2605
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
	}
}
