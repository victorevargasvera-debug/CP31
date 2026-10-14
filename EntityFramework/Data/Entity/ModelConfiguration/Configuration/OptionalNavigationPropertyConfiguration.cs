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
	// Token: 0x020001E8 RID: 488
	public class OptionalNavigationPropertyConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x060019B9 RID: 6585 RVA: 0x00044BBA File Offset: 0x00042DBA
		internal OptionalNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			navigationPropertyConfiguration.Reset();
			this._navigationPropertyConfiguration = navigationPropertyConfiguration;
			this._navigationPropertyConfiguration.RelationshipMultiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00044BE0 File Offset: 0x00042DE0
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType> WithMany(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithMany();
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00044C0A File Offset: 0x00042E0A
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType> WithMany()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType>(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00044C28 File Offset: 0x00042E28
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequired(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithRequired();
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x00044C52 File Offset: 0x00042E52
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequired()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00044C70 File Offset: 0x00042E70
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptionalDependent(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithOptionalDependent();
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00044C9A File Offset: 0x00042E9A
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptionalDependent()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne);
			this._navigationPropertyConfiguration.Constraint = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration.Instance;
			this._navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal = new bool?(false);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00044CD9 File Offset: 0x00042ED9
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptionalPrincipal(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithOptionalPrincipal();
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00044D03 File Offset: 0x00042F03
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptionalPrincipal()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne);
			this._navigationPropertyConfiguration.Constraint = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration.Instance;
			this._navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal = new bool?(true);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00044D42 File Offset: 0x00042F42
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00044D4A File Offset: 0x00042F4A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00044D53 File Offset: 0x00042F53
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00044D5B File Offset: 0x00042F5B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A84 RID: 2692
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _navigationPropertyConfiguration;
	}
}
