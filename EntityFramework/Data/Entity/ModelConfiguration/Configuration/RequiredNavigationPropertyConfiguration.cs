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
	// Token: 0x020001E9 RID: 489
	public class RequiredNavigationPropertyConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x00044D63 File Offset: 0x00042F63
		internal RequiredNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			navigationPropertyConfiguration.Reset();
			this._navigationPropertyConfiguration = navigationPropertyConfiguration;
			this._navigationPropertyConfiguration.RelationshipMultiplicity = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00044D89 File Offset: 0x00042F89
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType> WithMany(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithMany();
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00044DB3 File Offset: 0x00042FB3
		public global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType> WithMany()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DependentNavigationPropertyConfiguration<TEntityType>(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00044DD1 File Offset: 0x00042FD1
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptional(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithOptional();
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00044DFB File Offset: 0x00042FFB
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithOptional()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00044E19 File Offset: 0x00043019
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequiredDependent(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithRequiredDependent();
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00044E43 File Offset: 0x00043043
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequiredDependent()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
			this._navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal = new bool?(false);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00044E72 File Offset: 0x00043072
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequiredPrincipal(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>> navigationPropertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			this._navigationPropertyConfiguration.InverseNavigationProperty = navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>();
			return this.WithRequiredPrincipal();
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00044E9C File Offset: 0x0004309C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration WithRequiredPrincipal()
		{
			this._navigationPropertyConfiguration.InverseEndKind = new global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity?(global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One);
			this._navigationPropertyConfiguration.IsNavigationPropertyDeclaringTypePrincipal = new bool?(true);
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration(this._navigationPropertyConfiguration);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00044ECB File Offset: 0x000430CB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00044ED3 File Offset: 0x000430D3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00044EDC File Offset: 0x000430DC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00044EE4 File Offset: 0x000430E4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A85 RID: 2693
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _navigationPropertyConfiguration;
	}
}
