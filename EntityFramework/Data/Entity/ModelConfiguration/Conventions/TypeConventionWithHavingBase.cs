using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Types;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000185 RID: 389
	internal abstract class TypeConventionWithHavingBase<T> : global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionBase where T : class
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x0003C719 File Offset: 0x0003A919
		public TypeConventionWithHavingBase(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Func<global::System.Type, T> capturingPredicate) : base(predicates)
		{
			this._capturingPredicate = capturingPredicate;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x0003C729 File Offset: 0x0003A929
		internal global::System.Func<global::System.Type, T> CapturingPredicate
		{
			get
			{
				return this._capturingPredicate;
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0003C734 File Offset: 0x0003A934
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			T t = this._capturingPredicate(memberInfo);
			if (t != null)
			{
				this.InvokeAction(memberInfo, modelConfiguration, t);
			}
		}

		// Token: 0x0600170E RID: 5902
		protected abstract void InvokeAction(global::System.Type memberInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration configuration, T value);

		// Token: 0x0600170F RID: 5903 RVA: 0x0003C760 File Offset: 0x0003A960
		protected sealed override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			T t = this._capturingPredicate(memberInfo);
			if (t != null)
			{
				this.InvokeAction(memberInfo, configuration, modelConfiguration, t);
			}
		}

		// Token: 0x06001710 RID: 5904
		protected abstract void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, T value);

		// Token: 0x06001711 RID: 5905 RVA: 0x0003C78C File Offset: 0x0003A98C
		protected override void ApplyCore(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			T t = this._capturingPredicate(memberInfo);
			if (t != null)
			{
				this.InvokeAction(memberInfo, configuration, modelConfiguration, t);
			}
		}

		// Token: 0x06001712 RID: 5906
		protected abstract void InvokeAction(global::System.Type memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration, T value);

		// Token: 0x04000A27 RID: 2599
		private readonly global::System.Func<global::System.Type, T> _capturingPredicate;
	}
}
