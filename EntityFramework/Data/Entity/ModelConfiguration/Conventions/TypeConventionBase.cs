using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000183 RID: 387
	internal abstract class TypeConventionBase : global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention, global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type, global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration>, global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Type>
	{
		// Token: 0x060016FE RID: 5886 RVA: 0x0003C5DF File Offset: 0x0003A7DF
		protected TypeConventionBase(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates)
		{
			this._predicates = predicates;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x0003C5EE File Offset: 0x0003A7EE
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0003C5F8 File Offset: 0x0003A7F8
		public void Apply(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (this._predicates.All((global::System.Func<global::System.Type, bool> p) => p(memberInfo)))
			{
				this.ApplyCore(memberInfo, modelConfiguration);
			}
		}

		// Token: 0x06001701 RID: 5889
		protected abstract void ApplyCore(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);

		// Token: 0x06001702 RID: 5890 RVA: 0x0003C638 File Offset: 0x0003A838
		public void Apply(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (this._predicates.All((global::System.Func<global::System.Type, bool> p) => p(memberInfo)))
			{
				this.ApplyCore(memberInfo, configuration, modelConfiguration);
			}
		}

		// Token: 0x06001703 RID: 5891
		protected abstract void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);

		// Token: 0x06001704 RID: 5892 RVA: 0x0003C67C File Offset: 0x0003A87C
		public void Apply(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (this._predicates.All((global::System.Func<global::System.Type, bool> p) => p(memberInfo)))
			{
				this.ApplyCore(memberInfo, configuration, modelConfiguration);
			}
		}

		// Token: 0x06001705 RID: 5893
		protected abstract void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);

		// Token: 0x04000A25 RID: 2597
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> _predicates;
	}
}
