using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019C RID: 412
	public abstract class TypeAttributeConfigurationConvention<TAttribute> : global::System.Data.Entity.ModelConfiguration.Conventions.Convention where TAttribute : global::System.Attribute
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x0003D0C7 File Offset: 0x0003B2C7
		protected TypeAttributeConfigurationConvention()
		{
			base.Types().Having<global::System.Collections.Generic.IEnumerable<TAttribute>>((global::System.Type t) => this._attributeProvider.GetAttributes(t).OfType<TAttribute>()).Configure(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, global::System.Collections.Generic.IEnumerable<TAttribute> attributes)
			{
				foreach (TAttribute attribute in attributes)
				{
					this.Apply(configuration, attribute);
				}
			});
		}

		// Token: 0x06001748 RID: 5960
		public abstract void Apply(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, TAttribute attribute);

		// Token: 0x04000A30 RID: 2608
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
	}
}
