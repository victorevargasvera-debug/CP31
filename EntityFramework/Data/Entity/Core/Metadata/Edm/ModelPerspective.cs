using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004E2 RID: 1250
	internal class ModelPerspective : global::System.Data.Entity.Core.Metadata.Edm.Perspective
	{
		// Token: 0x06003E61 RID: 15969 RVA: 0x000CE4AD File Offset: 0x000CC6AD
		internal ModelPerspective(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace) : base(metadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x000CE4B8 File Offset: 0x000CC6B8
		internal override bool TryGetTypeByName(string fullName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(fullName, "fullName");
			typeUsage = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			if (base.MetadataWorkspace.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(fullName, ignoreCase, base.TargetDataspace, out edmType))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType))
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetCanonicalModelTypeUsage(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType).PrimitiveTypeKind);
				}
				else
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
				}
			}
			return typeUsage != null;
		}
	}
}
