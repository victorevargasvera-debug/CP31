using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration.Types;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C4 RID: 452
	internal class ConfigurationTypesFinder
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x0003FC4F File Offset: 0x0003DE4F
		public ConfigurationTypesFinder() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeActivator(), new global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeFilter())
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0003FC61 File Offset: 0x0003DE61
		public ConfigurationTypesFinder(global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeActivator activator, global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeFilter filter)
		{
			this._activator = activator;
			this._filter = filter;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0003FC78 File Offset: 0x0003DE78
		public virtual void AddConfigurationTypesToModel(global::System.Collections.Generic.IEnumerable<global::System.Type> types, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			foreach (global::System.Type type in types)
			{
				if (this._filter.IsEntityTypeConfiguration(type))
				{
					modelConfiguration.Add(this._activator.Activate<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>(type));
				}
				else if (this._filter.IsComplexTypeConfiguration(type))
				{
					modelConfiguration.Add(this._activator.Activate<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>(type));
				}
			}
		}

		// Token: 0x04000A48 RID: 2632
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeActivator _activator;

		// Token: 0x04000A49 RID: 2633
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConfigurationTypeFilter _filter;
	}
}
