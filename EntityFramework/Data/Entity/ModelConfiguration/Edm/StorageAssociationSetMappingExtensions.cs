using System;
using System.Data.Entity.Core.Mapping;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000171 RID: 369
	internal static class StorageAssociationSetMappingExtensions
	{
		// Token: 0x060016A7 RID: 5799 RVA: 0x0003AC18 File Offset: 0x00038E18
		public static global::System.Data.Entity.Core.Mapping.AssociationSetMapping Initialize(this global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			associationSetMapping.SourceEndMapping = new global::System.Data.Entity.Core.Mapping.EndPropertyMapping();
			associationSetMapping.TargetEndMapping = new global::System.Data.Entity.Core.Mapping.EndPropertyMapping();
			return associationSetMapping;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0003AC31 File Offset: 0x00038E31
		public static object GetConfiguration(this global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping)
		{
			return associationSetMapping.Annotations.GetConfiguration();
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x0003AC3E File Offset: 0x00038E3E
		public static void SetConfiguration(this global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, object configuration)
		{
			associationSetMapping.Annotations.SetConfiguration(configuration);
		}
	}
}
