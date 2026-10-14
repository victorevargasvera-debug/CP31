using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CD RID: 461
	public class TypeConventionWithHavingConfiguration<T> where T : class
	{
		// Token: 0x06001842 RID: 6210 RVA: 0x00040C4E File Offset: 0x0003EE4E
		internal TypeConventionWithHavingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates, global::System.Func<global::System.Type, T> capturingPredicate)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
			this._capturingPredicate = capturingPredicate;
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00040C6B File Offset: 0x0003EE6B
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00040C73 File Offset: 0x0003EE73
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00040C7B File Offset: 0x0003EE7B
		internal global::System.Func<global::System.Type, T> CapturingPredicate
		{
			get
			{
				return this._capturingPredicate;
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00040C83 File Offset: 0x0003EE83
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration, T> entityConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration, T>>(entityConfigurationAction, "entityConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.TypeConventionWithHaving<T>(this._predicates, this._capturingPredicate, entityConfigurationAction)
			});
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00040CB7 File Offset: 0x0003EEB7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00040CBF File Offset: 0x0003EEBF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00040CC8 File Offset: 0x0003EEC8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00040CD0 File Offset: 0x0003EED0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A5A RID: 2650
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A5B RID: 2651
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> _predicates;

		// Token: 0x04000A5C RID: 2652
		private readonly global::System.Func<global::System.Type, T> _capturingPredicate;
	}
}
