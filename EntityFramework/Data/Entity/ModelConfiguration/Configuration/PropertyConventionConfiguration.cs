using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001C9 RID: 457
	public class PropertyConventionConfiguration
	{
		// Token: 0x06001818 RID: 6168 RVA: 0x0004096C File Offset: 0x0003EB6C
		internal PropertyConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration) : this(conventionsConfiguration, global::System.Linq.Enumerable.Empty<global::System.Func<global::System.Reflection.PropertyInfo, bool>>())
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0004097A File Offset: 0x0003EB7A
		private PropertyConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> predicates)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00040990 File Offset: 0x0003EB90
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00040998 File Offset: 0x0003EB98
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000409A0 File Offset: 0x0003EBA0
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration Where(global::System.Func<global::System.Reflection.PropertyInfo, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Reflection.PropertyInfo, bool>>(predicate, "predicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionConfiguration(this._conventionsConfiguration, this._predicates.Append(predicate));
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x000409C5 File Offset: 0x0003EBC5
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionWithHavingConfiguration<T> Having<T>(global::System.Func<global::System.Reflection.PropertyInfo, T> capturingPredicate) where T : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Reflection.PropertyInfo, T>>(capturingPredicate, "capturingPredicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyConventionWithHavingConfiguration<T>(this._conventionsConfiguration, this._predicates, capturingPredicate);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x000409E5 File Offset: 0x0003EBE5
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration> propertyConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration>>(propertyConfigurationAction, "propertyConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.PropertyConvention(this._predicates, propertyConfigurationAction)
			});
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00040A13 File Offset: 0x0003EC13
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00040A1B File Offset: 0x0003EC1B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00040A24 File Offset: 0x0003EC24
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00040A2C File Offset: 0x0003EC2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A51 RID: 2641
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A52 RID: 2642
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> _predicates;
	}
}
