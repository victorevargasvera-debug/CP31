using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000194 RID: 404
	public abstract class PropertyAttributeConfigurationConvention<TAttribute> : global::System.Data.Entity.ModelConfiguration.Conventions.Convention where TAttribute : global::System.Attribute
	{
		// Token: 0x06001736 RID: 5942 RVA: 0x0003CE2C File Offset: 0x0003B02C
		protected PropertyAttributeConfigurationConvention()
		{
			base.Types().Configure(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration ec)
			{
				foreach (global::System.Reflection.PropertyInfo propertyInfo in ec.ClrType.GetInstanceProperties())
				{
					global::System.Collections.Generic.IList<global::System.Attribute> list = (global::System.Collections.Generic.IList<global::System.Attribute>)this._attributeProvider.GetAttributes(propertyInfo);
					for (int i = 0; i < list.Count; i++)
					{
						TAttribute tattribute = list[i] as TAttribute;
						if (tattribute != null)
						{
							this.Apply(propertyInfo, ec, tattribute);
						}
					}
				}
			});
		}

		// Token: 0x06001737 RID: 5943
		public abstract void Apply(global::System.Reflection.PropertyInfo memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration configuration, TAttribute attribute);

		// Token: 0x04000A2E RID: 2606
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
	}
}
