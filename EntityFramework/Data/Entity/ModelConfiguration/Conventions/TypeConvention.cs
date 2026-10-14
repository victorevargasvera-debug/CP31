using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000182 RID: 386
	internal class TypeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionBase
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x0003C589 File Offset: 0x0003A789
		public TypeConvention(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration> entityConfigurationAction) : base(predicates)
		{
			this._entityConfigurationAction = entityConfigurationAction;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0003C599 File Offset: 0x0003A799
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration> EntityConfigurationAction
		{
			get
			{
				return this._entityConfigurationAction;
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0003C5A1 File Offset: 0x0003A7A1
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, modelConfiguration));
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0003C5B5 File Offset: 0x0003A7B5
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, configuration, modelConfiguration));
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0003C5CA File Offset: 0x0003A7CA
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(memberInfo, configuration, modelConfiguration));
		}

		// Token: 0x04000A24 RID: 2596
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration> _entityConfigurationAction;
	}
}
