using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001EC RID: 492
	public class DependentNavigationPropertyConfiguration<TDependentEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyNavigationPropertyConfiguration where TDependentEntityType : class
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x00044F4E File Offset: 0x0004314E
		internal DependentNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration) : base(navigationPropertyConfiguration)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00044F58 File Offset: 0x00043158
		public global::System.Data.Entity.ModelConfiguration.Configuration.CascadableNavigationPropertyConfiguration HasForeignKey<TKey>(global::System.Linq.Expressions.Expression<global::System.Func<TDependentEntityType, TKey>> foreignKeyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TDependentEntityType, TKey>>>(foreignKeyExpression, "foreignKeyExpression");
			base.NavigationPropertyConfiguration.Constraint = new global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ForeignKeyConstraintConfiguration(from p in foreignKeyExpression.GetSimplePropertyAccessList()
			select p.Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x00044FAC File Offset: 0x000431AC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x00044FB4 File Offset: 0x000431B4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00044FBD File Offset: 0x000431BD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00044FC5 File Offset: 0x000431C5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
