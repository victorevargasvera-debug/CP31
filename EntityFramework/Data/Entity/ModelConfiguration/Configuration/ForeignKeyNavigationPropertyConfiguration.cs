using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001EE RID: 494
	public class ForeignKeyNavigationPropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.CascadableNavigationPropertyConfiguration
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x00045509 File Offset: 0x00043709
		internal ForeignKeyNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration) : base(navigationPropertyConfiguration)
		{
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00045514 File Offset: 0x00043714
		public global::System.Data.Entity.ModelConfiguration.Configuration.CascadableNavigationPropertyConfiguration Map(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration> configurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration>>(configurationAction, "configurationAction");
			base.NavigationPropertyConfiguration.Constraint = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.IndependentConstraintConfiguration.Instance;
			global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration foreignKeyAssociationMappingConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ForeignKeyAssociationMappingConfiguration();
			configurationAction(foreignKeyAssociationMappingConfiguration);
			base.NavigationPropertyConfiguration.AssociationMappingConfiguration = foreignKeyAssociationMappingConfiguration;
			return this;
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00045557 File Offset: 0x00043757
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0004555F File Offset: 0x0004375F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00045568 File Offset: 0x00043768
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00045570 File Offset: 0x00043770
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
