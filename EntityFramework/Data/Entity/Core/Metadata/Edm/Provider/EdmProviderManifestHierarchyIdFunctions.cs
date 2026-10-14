using System;

namespace System.Data.Entity.Core.Metadata.Edm.Provider
{
	// Token: 0x0200051C RID: 1308
	internal static class EdmProviderManifestHierarchyIdFunctions
	{
		// Token: 0x06004095 RID: 16533 RVA: 0x000D8700 File Offset: 0x000D6900
		internal static void AddFunctions(global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifestFunctionBuilder functions)
		{
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "HierarchyIdGetRoot");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "HierarchyIdParse", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "input");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "GetAncestor", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "hierarchyIdValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, "n");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "GetDescendant", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "hierarchyIdValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "child1", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "child2");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16, "GetLevel", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "hierarchyIdValue");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "IsDescendantOf", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "hierarchyIdValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "parent");
			functions.AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "GetReparentedValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "hierarchyIdValue", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "oldRoot", global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.HierarchyId, "newRoot");
		}
	}
}
