using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AE RID: 430
	public class NavigationPropertyNameForeignKeyDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyDiscoveryConvention
	{
		// Token: 0x06001781 RID: 6017 RVA: 0x0003E91C File Offset: 0x0003CB1C
		protected override bool MatchDependentKeyProperty(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentAssociationEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dependentProperty, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty principalKeyProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationType, "associationType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(dependentAssociationEnd, "dependentAssociationEnd");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(dependentProperty, "dependentProperty");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(principalEntityType, "principalEntityType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(principalKeyProperty, "principalKeyProperty");
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember otherEnd = associationType.GetOtherEnd(dependentAssociationEnd);
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = dependentAssociationEnd.GetEntityType().NavigationProperties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty n) => n.ResultEnd == otherEnd);
			return navigationProperty != null && string.Equals(dependentProperty.Name, navigationProperty.Name + principalKeyProperty.Name, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x0003E9BA File Offset: 0x0003CBBA
		protected override bool SupportsMultipleAssociations
		{
			get
			{
				return true;
			}
		}
	}
}
