using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E7 RID: 487
	public class ManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x00044A9B File Offset: 0x00042C9B
		internal ManyNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			navigationPropertyConfiguration.Reset();
			this._navigationPropertyConfiguration = navigationPropertyConfiguration;
			this._navigationPropertyConfiguration.RelationshipMultiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00044AC1 File Offset: 0x00042CC1
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> WithMany(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithMany();
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00044AEB File Offset: 0x00042CEB
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> WithMany()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType>(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00044B09 File Offset: 0x00042D09
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType> WithRequired(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithRequired();
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00044B33 File Offset: 0x00042D33
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType> WithRequired()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType>(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00044B51 File Offset: 0x00042D51
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType> WithOptional(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithOptional();
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00044B7B File Offset: 0x00042D7B
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType> WithOptional()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TTargetEntityType>(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00044B99 File Offset: 0x00042D99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00044BA1 File Offset: 0x00042DA1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00044BAA File Offset: 0x00042DAA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00044BB2 File Offset: 0x00042DB2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A83 RID: 2691
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _navigationPropertyConfiguration;
	}
}
