using System;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000502 RID: 1282
	internal static class Util
	{
		// Token: 0x06003FAC RID: 16300 RVA: 0x000D3135 File Offset: 0x000D1335
		internal static void ThrowIfReadOnly(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (item.IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyItem);
			}
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x000D314A File Offset: 0x000D134A
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void AssertItemHasIdentity(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item, string argumentName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.MetadataItem>(item, argumentName);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x000D3154 File Offset: 0x000D1354
		internal static global::System.Data.Entity.Core.Mapping.ObjectTypeMapping GetObjectMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection;
			if (workspace.TryGetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, out itemCollection))
			{
				return (global::System.Data.Entity.Core.Mapping.ObjectTypeMapping)workspace.GetMap(type, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType cdmType;
			if (type.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type))
				{
					edmType = workspace.GetMappedPrimitiveType(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type).PrimitiveTypeKind, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
				}
				else
				{
					edmType = workspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(type.FullName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
				}
				cdmType = type;
			}
			else
			{
				edmType = type;
				cdmType = type;
			}
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType))
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Materializer_UnsupportedType);
			}
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType))
			{
				result = new global::System.Data.Entity.Core.Mapping.ObjectTypeMapping(edmType, cdmType);
			}
			else
			{
				result = global::System.Data.Entity.Core.Mapping.DefaultObjectMappingItemCollection.LoadObjectMapping(cdmType, edmType, null);
			}
			return result;
		}
	}
}
