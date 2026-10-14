using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000187 RID: 391
	internal class TypeConvention<T> : global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionBase where T : class
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x0003C81E File Offset: 0x0003AA1E
		public TypeConvention(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>> entityConfigurationAction) : base(predicates.Prepend(global::System.Data.Entity.ModelConfiguration.Conventions.TypeConvention<T>._ofTypePredicate))
		{
			this._entityConfigurationAction = entityConfigurationAction;
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0003C838 File Offset: 0x0003AA38
		internal global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>> EntityConfigurationAction
		{
			get
			{
				return this._entityConfigurationAction;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0003C840 File Offset: 0x0003AA40
		internal static global::System.Func<global::System.Type, bool> OfTypePredicate
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Conventions.TypeConvention<T>._ofTypePredicate;
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0003C847 File Offset: 0x0003AA47
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, modelConfiguration));
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0003C85B File Offset: 0x0003AA5B
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, configuration, modelConfiguration));
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0003C870 File Offset: 0x0003AA70
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._entityConfigurationAction(new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>(memberInfo, configuration, modelConfiguration));
		}

		// Token: 0x04000A29 RID: 2601
		private static readonly global::System.Func<global::System.Type, bool> _ofTypePredicate = (global::System.Type t) => typeof(T).IsAssignableFrom(t);

		// Token: 0x04000A2A RID: 2602
		private readonly global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>> _entityConfigurationAction;
	}
}
