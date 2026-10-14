using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F0 RID: 496
	public class ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x06001A06 RID: 6662 RVA: 0x00045A45 File Offset: 0x00043C45
		internal ManyToManyNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			this._navigationPropertyConfiguration = navigationPropertyConfiguration;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00045A54 File Offset: 0x00043C54
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> Map(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration> configurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration>>(configurationAction, "configurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration manyToManyAssociationMappingConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyAssociationMappingConfiguration();
			configurationAction(manyToManyAssociationMappingConfiguration);
			this._navigationPropertyConfiguration.AssociationMappingConfiguration = manyToManyAssociationMappingConfiguration;
			return this;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00045A87 File Offset: 0x00043C87
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> MapToStoredProcedures()
		{
			if (this._navigationPropertyConfiguration.ModificationStoredProceduresConfiguration == null)
			{
				this._navigationPropertyConfiguration.ModificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration();
			}
			return this;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00045AA8 File Offset: 0x00043CA8
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyNavigationPropertyConfiguration<TEntityType, TTargetEntityType> MapToStoredProcedures(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType>> modificationStoredProcedureMappingConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType>>>(modificationStoredProcedureMappingConfigurationAction, "modificationStoredProcedureMappingConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType> manyToManyModificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProceduresConfiguration<TEntityType, TTargetEntityType>();
			modificationStoredProcedureMappingConfigurationAction(manyToManyModificationStoredProceduresConfiguration);
			if (this._navigationPropertyConfiguration.ModificationStoredProceduresConfiguration == null)
			{
				this._navigationPropertyConfiguration.ModificationStoredProceduresConfiguration = manyToManyModificationStoredProceduresConfiguration.Configuration;
			}
			else
			{
				this._navigationPropertyConfiguration.ModificationStoredProceduresConfiguration.Merge(manyToManyModificationStoredProceduresConfiguration.Configuration, true);
			}
			return this;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00045B06 File Offset: 0x00043D06
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00045B0E File Offset: 0x00043D0E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00045B17 File Offset: 0x00043D17
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00045B1F File Offset: 0x00043D1F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A8E RID: 2702
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _navigationPropertyConfiguration;
	}
}
