using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000184 RID: 388
	internal class TypeConventionWithHaving<T> : global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionWithHavingBase<T> where T : class
	{
		// Token: 0x06001706 RID: 5894 RVA: 0x0003C6BD File Offset: 0x0003A8BD
		public TypeConventionWithHaving(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Func<global::System.Type, T> capturingPredicate, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration, T> entityConfigurationAction) : base(predicates, capturingPredicate)
		{
			this._entityConfigurationAction = entityConfigurationAction;
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0003C6CE File Offset: 0x0003A8CE
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration, T> EntityConfigurationAction
		{
			get
			{
				return this._entityConfigurationAction;
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0003C6D6 File Offset: 0x0003A8D6
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, T value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, modelConfiguration), value);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0003C6EB File Offset: 0x0003A8EB
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, T value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, configuration, modelConfiguration), value);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0003C702 File Offset: 0x0003A902
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, T value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, configuration, modelConfiguration), value);
		}

		// Token: 0x04000A26 RID: 2598
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration, T> _entityConfigurationAction;
	}
}
