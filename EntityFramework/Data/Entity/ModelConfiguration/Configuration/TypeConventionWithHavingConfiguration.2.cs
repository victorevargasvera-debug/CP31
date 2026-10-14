using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CE RID: 462
	public class TypeConventionWithHavingConfiguration<T, TValue> where T : class where TValue : class
	{
		// Token: 0x0600184B RID: 6219 RVA: 0x00040CD8 File Offset: 0x0003EED8
		internal TypeConventionWithHavingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Func<global::System.Type, TValue> capturingPredicate)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
			this._capturingPredicate = capturingPredicate;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00040CF5 File Offset: 0x0003EEF5
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00040CFD File Offset: 0x0003EEFD
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00040D05 File Offset: 0x0003EF05
		internal global::System.Func<global::System.Type, TValue> CapturingPredicate
		{
			get
			{
				return this._capturingPredicate;
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00040D0D File Offset: 0x0003EF0D
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>, TValue> entityConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>, TValue>>(entityConfigurationAction, "entityConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionWithHaving<T, TValue>(this._predicates, this._capturingPredicate, entityConfigurationAction)
			});
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00040D41 File Offset: 0x0003EF41
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00040D49 File Offset: 0x0003EF49
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00040D52 File Offset: 0x0003EF52
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00040D5A File Offset: 0x0003EF5A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A5D RID: 2653
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A5E RID: 2654
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> _predicates;

		// Token: 0x04000A5F RID: 2655
		private readonly global::System.Func<global::System.Type, TValue> _capturingPredicate;
	}
}
