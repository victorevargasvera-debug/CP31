using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CC RID: 460
	public class TypeConventionConfiguration<T> where T : class
	{
		// Token: 0x06001837 RID: 6199 RVA: 0x00040B86 File Offset: 0x0003ED86
		internal TypeConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration) : this(conventionsConfiguration, global::System.Linq.Enumerable.Empty<global::System.Func<global::System.Type, bool>>())
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00040B94 File Offset: 0x0003ED94
		private TypeConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00040BAA File Offset: 0x0003EDAA
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x00040BB2 File Offset: 0x0003EDB2
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00040BBA File Offset: 0x0003EDBA
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T> Where(global::System.Func<global::System.Type, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Type, bool>>(predicate, "predicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration<T>(this._conventionsConfiguration, this._predicates.Append(predicate));
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00040BDF File Offset: 0x0003EDDF
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionWithHavingConfiguration<T, TValue> Having<TValue>(global::System.Func<global::System.Type, TValue> capturingPredicate) where TValue : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Type, TValue>>(capturingPredicate, "capturingPredicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionWithHavingConfiguration<T, TValue>(this._conventionsConfiguration, this._predicates, capturingPredicate);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00040BFF File Offset: 0x0003EDFF
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>> entityConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T>>>(entityConfigurationAction, "entityConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.TypeConvention<T>(this._predicates, entityConfigurationAction)
			});
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00040C2D File Offset: 0x0003EE2D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00040C35 File Offset: 0x0003EE35
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00040C3E File Offset: 0x0003EE3E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00040C46 File Offset: 0x0003EE46
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A58 RID: 2648
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A59 RID: 2649
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> _predicates;
	}
}
