using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200017F RID: 383
	internal class PropertyConvention : global::System.Data.Entity.ModelConfiguration.Conventions.PropertyConventionBase
	{
		// Token: 0x060016EE RID: 5870 RVA: 0x0003C4A9 File Offset: 0x0003A6A9
		public PropertyConvention(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> predicates, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration> propertyConfigurationAction) : base(predicates)
		{
			this._propertyConfigurationAction = propertyConfigurationAction;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0003C4B9 File Offset: 0x0003A6B9
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration> PropertyConfigurationAction
		{
			get
			{
				return this._propertyConfigurationAction;
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x0003C4C1 File Offset: 0x0003A6C1
		protected override void ApplyCore(global::System.Reflection.PropertyInfo memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._propertyConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration(memberInfo, configuration));
		}

		// Token: 0x04000A20 RID: 2592
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration> _propertyConfigurationAction;
	}
}
