using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000022 RID: 34
	internal static class TypeUsageExtensions
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x0000EF9A File Offset: 0x0000D19A
		internal static byte GetPrecision(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("Precision");
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000EFA7 File Offset: 0x0000D1A7
		internal static byte GetScale(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("Scale");
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		internal static int GetMaxLength(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.GetFacetValue("MaxLength");
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EFC1 File Offset: 0x0000D1C1
		internal static T GetFacetValue<T>(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName)
		{
			return (T)((object)type.Facets[facetName].Value);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		internal static bool IsFixedLength(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet = type.Facets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f.Name == "FixedLength");
			return facet != null && facet.Value != null && (bool)facet.Value;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000F02C File Offset: 0x0000D22C
		internal static bool TryGetPrecision(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out byte precision)
		{
			if (!type.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal))
			{
				precision = 0;
				return false;
			}
			return type.TryGetFacetValue("Precision", out precision);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000F048 File Offset: 0x0000D248
		internal static bool TryGetScale(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out byte scale)
		{
			if (!type.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal))
			{
				scale = 0;
				return false;
			}
			return type.TryGetFacetValue("Scale", out scale);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000F064 File Offset: 0x0000D264
		internal static bool TryGetFacetValue<T>(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName, out T value)
		{
			value = default(T);
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue(facetName, false, out facet) && facet.Value is T)
			{
				value = (T)((object)facet.Value);
				return true;
			}
			return false;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		internal static bool IsPrimitiveType(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			return type.IsPrimitiveType() && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind == primitiveTypeKind;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F0C9 File Offset: 0x0000D2C9
		internal static bool IsPrimitiveType(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type != null && type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
		internal static bool IsNullable(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet = type.Facets.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.Facet f) => f.Name == "Nullable");
			return facet != null && facet.Value != null && (bool)facet.Value;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F130 File Offset: 0x0000D330
		internal static global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind GetPrimitiveTypeKind(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F142 File Offset: 0x0000D342
		internal static bool TryGetIsUnicode(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out bool isUnicode)
		{
			if (!type.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				isUnicode = false;
				return false;
			}
			return type.TryGetFacetValue("Unicode", out isUnicode);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000F15F File Offset: 0x0000D35F
		internal static bool TryGetMaxLength(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out int maxLength)
		{
			if (!type.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) && !type.IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
			{
				maxLength = 0;
				return false;
			}
			return type.TryGetFacetValue("MaxLength", out maxLength);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000F188 File Offset: 0x0000D388
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetProperties(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = type.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType).Properties;
			}
			if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType).Properties;
			}
			if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			}
			return ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).Properties;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetElementTypeUsage(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = type.EdmType;
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType == edmType.BuiltInTypeKind)
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType).TypeUsage;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType == edmType.BuiltInTypeKind)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(((global::System.Data.Entity.Core.Metadata.Edm.RefType)edmType).ElementType);
			}
			return null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000F224 File Offset: 0x0000D424
		internal static bool MustFacetBeConstant(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).FacetDescriptions.Single((global::System.Data.Entity.Core.Metadata.Edm.FacetDescription f) => f.FacetName == facetName).IsConstant;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000F264 File Offset: 0x0000D464
		internal static bool IsHierarchyIdType(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).IsHierarchyIdType();
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000F287 File Offset: 0x0000D487
		internal static bool IsSpatialType(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).IsSpatialType();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000F2AA File Offset: 0x0000D4AA
		internal static bool IsSpatialType(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind spatialType)
		{
			if (type.IsSpatialType())
			{
				spatialType = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind;
				return true;
			}
			spatialType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
			return false;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ForceNonUnicode(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)typeUsage.EdmType, false, false);
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(typeUsage.EdmType, (from f in typeUsage.Facets
			where f.Name != "Unicode"
			select f).Union(from f in typeUsage2.Facets
			where f.Name == "Unicode"
			select f));
		}
	}
}
