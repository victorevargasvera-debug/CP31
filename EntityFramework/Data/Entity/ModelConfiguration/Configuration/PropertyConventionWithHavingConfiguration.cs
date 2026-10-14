using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CA RID: 458
	public class PropertyConventionWithHavingConfiguration<T> where T : class
	{
		// Token: 0x06001823 RID: 6179 RVA: 0x00040A34 File Offset: 0x0003EC34
		internal PropertyConventionWithHavingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> predicates, global::System.Func<global::System.Reflection.PropertyInfo, T> capturingPredicate)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
			this._capturingPredicate = capturingPredicate;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x00040A51 File Offset: 0x0003EC51
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00040A59 File Offset: 0x0003EC59
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x00040A61 File Offset: 0x0003EC61
		internal global::System.Func<global::System.Reflection.PropertyInfo, T> CapturingPredicate
		{
			get
			{
				return this._capturingPredicate;
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00040A69 File Offset: 0x0003EC69
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration, T> propertyConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration, T>>(propertyConfigurationAction, "propertyConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.PropertyConventionWithHaving<T>(this._predicates, this._capturingPredicate, propertyConfigurationAction)
			});
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00040A9D File Offset: 0x0003EC9D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00040AA5 File Offset: 0x0003ECA5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00040AAE File Offset: 0x0003ECAE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00040AB6 File Offset: 0x0003ECB6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A53 RID: 2643
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A54 RID: 2644
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> _predicates;

		// Token: 0x04000A55 RID: 2645
		private readonly global::System.Func<global::System.Reflection.PropertyInfo, T> _capturingPredicate;
	}
}
