using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CB RID: 459
	public class TypeConventionConfiguration
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x00040ABE File Offset: 0x0003ECBE
		internal TypeConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration) : this(conventionsConfiguration, global::System.Linq.Enumerable.Empty<global::System.Func<global::System.Type, bool>>())
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00040ACC File Offset: 0x0003ECCC
		private TypeConventionConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration conventionsConfiguration, global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> predicates)
		{
			this._conventionsConfiguration = conventionsConfiguration;
			this._predicates = predicates;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x0600182E RID: 6190 RVA: 0x00040AE2 File Offset: 0x0003ECE2
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration ConventionsConfiguration
		{
			get
			{
				return this._conventionsConfiguration;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00040AEA File Offset: 0x0003ECEA
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00040AF2 File Offset: 0x0003ECF2
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration Where(global::System.Func<global::System.Type, bool> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Type, bool>>(predicate, "predicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionConfiguration(this._conventionsConfiguration, this._predicates.Append(predicate));
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00040B17 File Offset: 0x0003ED17
		public global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionWithHavingConfiguration<T> Having<T>(global::System.Func<global::System.Type, T> capturingPredicate) where T : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Type, T>>(capturingPredicate, "capturingPredicate");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.TypeConventionWithHavingConfiguration<T>(this._conventionsConfiguration, this._predicates, capturingPredicate);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00040B37 File Offset: 0x0003ED37
		public void Configure(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration> entityConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration>>(entityConfigurationAction, "entityConfigurationAction");
			this._conventionsConfiguration.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
			{
				new global::System.Data.Entity.ModelConfiguration.Conventions.TypeConvention(this._predicates, entityConfigurationAction)
			});
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00040B65 File Offset: 0x0003ED65
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00040B6D File Offset: 0x0003ED6D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00040B76 File Offset: 0x0003ED76
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00040B7E File Offset: 0x0003ED7E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A56 RID: 2646
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionsConfiguration _conventionsConfiguration;

		// Token: 0x04000A57 RID: 2647
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Type, bool>> _predicates;
	}
}
