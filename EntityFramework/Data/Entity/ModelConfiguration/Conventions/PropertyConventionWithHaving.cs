using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000181 RID: 385
	internal class PropertyConventionWithHaving<T> : global::System.Data.Entity.ModelConfiguration.Conventions.PropertyConventionBase where T : class
	{
		// Token: 0x060016F5 RID: 5877 RVA: 0x0003C52D File Offset: 0x0003A72D
		public PropertyConventionWithHaving(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> predicates, global::System.Func<global::System.Reflection.PropertyInfo, T> capturingPredicate, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration, T> propertyConfigurationAction) : base(predicates)
		{
			this._capturingPredicate = capturingPredicate;
			this._propertyConfigurationAction = propertyConfigurationAction;
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0003C544 File Offset: 0x0003A744
		internal global::System.Func<global::System.Reflection.PropertyInfo, T> CapturingPredicate
		{
			get
			{
				return this._capturingPredicate;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0003C54C File Offset: 0x0003A74C
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration, T> PropertyConfigurationAction
		{
			get
			{
				return this._propertyConfigurationAction;
			}
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0003C554 File Offset: 0x0003A754
		protected override void ApplyCore(global::System.Reflection.PropertyInfo memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			T t = this._capturingPredicate(memberInfo);
			if (t != null)
			{
				this._propertyConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration(memberInfo, configuration), t);
			}
		}

		// Token: 0x04000A22 RID: 2594
		private readonly global::System.Func<global::System.Reflection.PropertyInfo, T> _capturingPredicate;

		// Token: 0x04000A23 RID: 2595
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration, T> _propertyConfigurationAction;
	}
}
