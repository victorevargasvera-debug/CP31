using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000186 RID: 390
	internal class TypeConventionWithHaving<T, TValue> : global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionWithHavingBase<TValue> where T : class where TValue : class
	{
		// Token: 0x06001713 RID: 5907 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		public TypeConventionWithHaving(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Func<global::System.Type, TValue> capturingPredicate, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>, TValue> entityConfigurationAction) : base(predicates.Prepend(global::System.Data.Entity.ModelConfiguration.Conventions.TypeConvention<T>.OfTypePredicate), capturingPredicate)
		{
			this._entityConfigurationAction = entityConfigurationAction;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x0003C7D3 File Offset: 0x0003A9D3
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>, TValue> EntityConfigurationAction
		{
			get
			{
				return this._entityConfigurationAction;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0003C7DB File Offset: 0x0003A9DB
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, TValue value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, modelConfiguration), value);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0003C7F0 File Offset: 0x0003A9F0
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, TValue value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, configuration, modelConfiguration), value);
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0003C807 File Offset: 0x0003AA07
		protected override void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, TValue value)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, configuration, modelConfiguration), value);
		}

		// Token: 0x04000A28 RID: 2600
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>, TValue> _entityConfigurationAction;
	}
}
