using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001B2 RID: 434
	public class PrimaryKeyNameForeignKeyDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyDiscoveryConvention
	{
		// Token: 0x0600178B RID: 6027 RVA: 0x0003EC04 File Offset: 0x0003CE04
		protected override bool MatchDependentKeyProperty(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember dependentAssociationEnd, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty dependentProperty, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty principalKeyProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(associationType, "associationType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>(dependentAssociationEnd, "dependentAssociationEnd");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(dependentProperty, "dependentProperty");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(principalEntityType, "principalEntityType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(principalKeyProperty, "principalKeyProperty");
			return string.Equals(dependentProperty.Name, principalKeyProperty.Name, global::System.StringComparison.OrdinalIgnoreCase);
		}
	}
}
