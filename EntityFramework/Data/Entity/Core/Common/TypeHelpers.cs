using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Globalization;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005F0 RID: 1520
	internal static class TypeHelpers
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x00106BD0 File Offset: 0x00104DD0
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void AssertEdmType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = typeUsage.EdmType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(typeUsage))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructuralType(typeUsage) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(typeUsage.EdmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(typeUsage.EdmType))
				{
					using (global::System.Collections.IEnumerator enumerator = global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(typeUsage).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
						}
						return;
					}
				}
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(typeUsage))
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = edmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
					if (primitiveType != null && primitiveType.DataSpace != global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
					{
						throw new global::System.NotSupportedException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "PrimitiveType must be CSpace '{0}'", new object[]
						{
							typeUsage
						}));
					}
				}
			}
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00106C90 File Offset: 0x00104E90
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void AssertEdmType(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree dbQueryCommandTree = commandTree as global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree;
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00106CA8 File Offset: 0x00104EA8
		internal static bool IsValidSortOpKeyType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(typeUsage))
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)typeUsage.EdmType).Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidSortOpKeyType(enumerator.Current.TypeUsage))
						{
							return false;
						}
					}
				}
				return true;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparable(typeUsage);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00106D20 File Offset: 0x00104F20
		internal static bool IsValidGroupKeyType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(typeUsage);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x00106D28 File Offset: 0x00104F28
		internal static bool IsValidDistinctOpType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(typeUsage);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00106D30 File Offset: 0x00104F30
		internal static bool IsSetComparableOpType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(typeUsage.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(typeUsage.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(typeUsage.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(typeUsage.EdmType))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(typeUsage))
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)typeUsage.EdmType).Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(enumerator.Current.TypeUsage))
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00106DD8 File Offset: 0x00104FD8
		internal static bool IsValidIsNullOpType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(typeUsage);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00106DFA File Offset: 0x00104FFA
		internal static bool IsValidInOpType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(typeUsage);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00106E14 File Offset: 0x00105014
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCommonTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.GetCommonType(typeUsage1, typeUsage2);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00106E20 File Offset: 0x00105020
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCommonTypeUsage(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> types)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 in types)
			{
				if (typeUsage2 == null)
				{
					return null;
				}
				if (typeUsage == null)
				{
					typeUsage = typeUsage2;
				}
				else
				{
					typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.GetCommonType(typeUsage, typeUsage2);
					if (typeUsage == null)
					{
						break;
					}
				}
			}
			return typeUsage;
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00106E84 File Offset: 0x00105084
		internal static bool TryGetClosestPromotableType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage promotableType)
		{
			promotableType = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(fromType.EdmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)fromType.EdmType;
				global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> promotionTypes = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPromotionTypes(primitiveType);
				int num = promotionTypes.IndexOf(primitiveType);
				if (-1 != num && num + 1 < promotionTypes.Count)
				{
					promotableType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(promotionTypes[num + 1]);
				}
			}
			return promotableType != null;
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x00106EE8 File Offset: 0x001050E8
		internal static bool TryGetBooleanFacetValue(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName, out bool boolValue)
		{
			boolValue = false;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue(facetName, false, out facet) && facet.Value != null)
			{
				boolValue = (bool)facet.Value;
				return true;
			}
			return false;
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00106F24 File Offset: 0x00105124
		internal static bool TryGetByteFacetValue(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName, out byte byteValue)
		{
			byteValue = 0;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue(facetName, false, out facet) && facet.Value != null && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet))
			{
				byteValue = (byte)facet.Value;
				return true;
			}
			return false;
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x00106F68 File Offset: 0x00105168
		internal static bool TryGetIntFacetValue(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName, out int intValue)
		{
			intValue = 0;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (type.Facets.TryGetValue(facetName, false, out facet) && facet.Value != null && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsUnboundedFacetValue(facet) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsVariableFacetValue(facet))
			{
				intValue = (int)facet.Value;
				return true;
			}
			return false;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00106FB1 File Offset: 0x001051B1
		internal static bool TryGetIsFixedLength(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out bool isFixedLength)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
			{
				isFixedLength = false;
				return false;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetBooleanFacetValue(type, "FixedLength", out isFixedLength);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00106FD7 File Offset: 0x001051D7
		internal static bool TryGetIsUnicode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out bool isUnicode)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				isUnicode = false;
				return false;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetBooleanFacetValue(type, "Unicode", out isUnicode);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00106FF4 File Offset: 0x001051F4
		internal static bool IsFacetValueConstant(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string facetName)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetFacet(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).FacetDescriptions, facetName).IsConstant;
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00107011 File Offset: 0x00105211
		internal static bool TryGetMaxLength(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out int maxLength)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary))
			{
				maxLength = 0;
				return false;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetIntFacetValue(type, "MaxLength", out maxLength);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00107037 File Offset: 0x00105237
		internal static bool TryGetPrecision(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out byte precision)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal))
			{
				precision = 0;
				return false;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetByteFacetValue(type, "Precision", out precision);
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00107053 File Offset: 0x00105253
		internal static bool TryGetScale(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out byte scale)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal))
			{
				scale = 0;
				return false;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetByteFacetValue(type, "Scale", out scale);
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x0010706F File Offset: 0x0010526F
		internal static bool TryGetPrimitiveTypeKind(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind typeKind)
		{
			if (type != null && type.EdmType != null && type.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
			{
				typeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind;
				return true;
			}
			typeKind = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary;
			return false;
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x001070A3 File Offset: 0x001052A3
		internal static global::System.Data.Entity.Core.Metadata.Edm.CollectionType CreateCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(elementType);
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x001070AB File Offset: 0x001052AB
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateCollectionTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(elementType));
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x001070B8 File Offset: 0x001052B8
		internal static global::System.Data.Entity.Core.Metadata.Edm.RowType CreateRowType(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columns)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(columns, null);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x001070C4 File Offset: 0x001052C4
		internal static global::System.Data.Entity.Core.Metadata.Edm.RowType CreateRowType(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columns, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> keyValuePair in columns)
			{
				list.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(keyValuePair.Key, keyValuePair.Value));
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.RowType(list, initializerMetadata);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x0010712C File Offset: 0x0010532C
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateRowTypeUsage(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columns)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(columns));
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x00107139 File Offset: 0x00105339
		internal static global::System.Data.Entity.Core.Metadata.Edm.RefType CreateReferenceType(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.RefType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)entityType);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x00107146 File Offset: 0x00105346
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateReferenceTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceType(entityType));
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x00107154 File Offset: 0x00105354
		internal static global::System.Data.Entity.Core.Metadata.Edm.RowType CreateKeyRowType(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityType)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entityType.KeyMembers;
			if (keyMembers == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EntityTypeNullKeyMembersInvalid, "entityType");
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in keyMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
				list.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(edmProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmProperty)));
			}
			if (list.Count < 1)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid, "entityType");
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(list);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x001071F0 File Offset: 0x001053F0
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetPrimitiveTypeUsageForScalar(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage scalarType)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(scalarType))
			{
				return scalarType;
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(scalarType);
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x00107202 File Offset: 0x00105402
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateEnumUnderlyingTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage enumTypeUsage)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(enumTypeUsage.EdmType), enumTypeUsage.Facets);
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x0010721A File Offset: 0x0010541A
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateSpatialUnionTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage spatialTypeUsage)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetSpatialNormalizedPrimitiveType(spatialTypeUsage.EdmType), spatialTypeUsage.Facets);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x00107232 File Offset: 0x00105432
		internal static global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> GetAllStructuralMembers(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(type.EdmType);
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x00107240 File Offset: 0x00105440
		internal static global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> GetAllStructuralMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
				{
					return (global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType).AssociationEndMembers;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
				{
					return (global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType).Properties;
				}
			}
			else
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					return (global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType).Properties;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					return (global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>)((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).Properties;
				}
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.EmptyArrayEdmProperty;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001072B7 File Offset: 0x001054B7
		internal static global::System.Collections.IEnumerable GetDeclaredStructuralMembers(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetDeclaredStructuralMembers(type.EdmType);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x001072C4 File Offset: 0x001054C4
		internal static global::System.Collections.IEnumerable GetDeclaredStructuralMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = edmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType).GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>();
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)edmType).GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				}
			}
			else
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType).GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					return ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				}
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.EmptyArrayEdmProperty;
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x00107327 File Offset: 0x00105527
		internal static global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetProperties(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(typeUsage.EdmType);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x00107334 File Offset: 0x00105534
		internal static global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetProperties(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
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
				return global::System.Data.Entity.Core.Common.TypeHelpers.EmptyArrayEdmProperty;
			}
			return ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).Properties;
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00107381 File Offset: 0x00105581
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetElementTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(type))
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)type.EdmType).TypeUsage;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(type))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(((global::System.Data.Entity.Core.Metadata.Edm.RefType)type.EdmType).ElementType);
			}
			return null;
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x001073BC File Offset: 0x001055BC
		internal static global::System.Data.Entity.Core.Metadata.Edm.RowType GetTvfReturnType(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction tvf)
		{
			if (tvf.ReturnParameter != null && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(tvf.ReturnParameter.TypeUsage))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)tvf.ReturnParameter.TypeUsage.EdmType).TypeUsage;
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(typeUsage))
				{
					return (global::System.Data.Entity.Core.Metadata.Edm.RowType)typeUsage.EdmType;
				}
			}
			return null;
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00107414 File Offset: 0x00105614
		internal static bool TryGetCollectionElementType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(type, out collectionType))
			{
				elementType = collectionType.TypeUsage;
				return elementType != null;
			}
			elementType = null;
			return false;
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x00107440 File Offset: 0x00105640
		internal static bool TryGetRefEntityType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, out global::System.Data.Entity.Core.Metadata.Edm.EntityType referencedEntityType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(type, out refType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(refType.ElementType))
			{
				referencedEntityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)refType.ElementType;
				return true;
			}
			referencedEntityType = null;
			return false;
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x00107477 File Offset: 0x00105677
		internal static TEdmType GetEdmType<TEdmType>(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage) where TEdmType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			return (TEdmType)((object)typeUsage.EdmType);
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x00107484 File Offset: 0x00105684
		internal static bool TryGetEdmType<TEdmType>(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, out TEdmType type) where TEdmType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
		{
			type = (typeUsage.EdmType as TEdmType);
			return type != null;
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x001074AA File Offset: 0x001056AA
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetReadOnlyType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (!type.IsReadOnly)
			{
				type.SetReadOnly();
			}
			return type;
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x001074BC File Offset: 0x001056BC
		internal static string GetFullName(string qualifier, string name)
		{
			if (!string.IsNullOrEmpty(qualifier))
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
				{
					qualifier,
					name
				});
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				name
			});
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00107508 File Offset: 0x00105708
		internal static global::System.Data.DbType ConvertClrTypeToDbType(global::System.Type clrType)
		{
			switch (global::System.Type.GetTypeCode(clrType))
			{
			case global::System.TypeCode.Empty:
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataType(global::System.TypeCode.Empty.ToString()));
			case global::System.TypeCode.Object:
				if (clrType == typeof(byte[]))
				{
					return global::System.Data.DbType.Binary;
				}
				if (clrType == typeof(char[]))
				{
					return global::System.Data.DbType.String;
				}
				if (clrType == typeof(global::System.Guid))
				{
					return global::System.Data.DbType.Guid;
				}
				if (clrType == typeof(global::System.TimeSpan))
				{
					return global::System.Data.DbType.Time;
				}
				if (clrType == typeof(global::System.DateTimeOffset))
				{
					return global::System.Data.DbType.DateTimeOffset;
				}
				return global::System.Data.DbType.Object;
			case global::System.TypeCode.DBNull:
				return global::System.Data.DbType.Object;
			case global::System.TypeCode.Boolean:
				return global::System.Data.DbType.Boolean;
			case global::System.TypeCode.Char:
				return global::System.Data.DbType.String;
			case global::System.TypeCode.SByte:
				return global::System.Data.DbType.SByte;
			case global::System.TypeCode.Byte:
				return global::System.Data.DbType.Byte;
			case global::System.TypeCode.Int16:
				return global::System.Data.DbType.Int16;
			case global::System.TypeCode.UInt16:
				return global::System.Data.DbType.UInt16;
			case global::System.TypeCode.Int32:
				return global::System.Data.DbType.Int32;
			case global::System.TypeCode.UInt32:
				return global::System.Data.DbType.UInt32;
			case global::System.TypeCode.Int64:
				return global::System.Data.DbType.Int64;
			case global::System.TypeCode.UInt64:
				return global::System.Data.DbType.UInt64;
			case global::System.TypeCode.Single:
				return global::System.Data.DbType.Single;
			case global::System.TypeCode.Double:
				return global::System.Data.DbType.Double;
			case global::System.TypeCode.Decimal:
				return global::System.Data.DbType.Decimal;
			case global::System.TypeCode.DateTime:
				return global::System.Data.DbType.DateTime;
			case global::System.TypeCode.String:
				return global::System.Data.DbType.String;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_UnknownDataTypeCode(((int)global::System.Type.GetTypeCode(clrType)).ToString(global::System.Globalization.CultureInfo.InvariantCulture), clrType.FullName));
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x00107648 File Offset: 0x00105848
		internal static bool IsIntegerConstant(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage valueType, object value, long expectedValue)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(valueType))
			{
				return false;
			}
			if (value == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)valueType.EdmType).PrimitiveTypeKind;
			if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte)
			{
				return expectedValue == (long)((ulong)((byte)value));
			}
			switch (primitiveTypeKind)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				return expectedValue == (long)((sbyte)value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return expectedValue == (long)((short)value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return expectedValue == (long)((int)value);
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return expectedValue == (long)value;
			default:
				return false;
			}
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x001076CA File Offset: 0x001058CA
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetLiteralTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetLiteralTypeUsage(primitiveTypeKind, true);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x001076D4 File Offset: 0x001058D4
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetLiteralTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind, bool isUnicode)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(primitiveTypeKind);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Unicode = new bool?(isUnicode),
					MaxLength = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.DefaultMaxLengthFacetValue,
					FixedLength = new bool?(false),
					Nullable = new bool?(false)
				});
			}
			else
			{
				result = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(false)
				});
			}
			return result;
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x00107761 File Offset: 0x00105961
		internal static bool IsCanonicalFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return function.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace && function.NamespaceName == "Edm";
		}

		// Token: 0x04001A39 RID: 6713
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> EmptyArrayEdmMember = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>().SetReadOnly());

		// Token: 0x04001A3A RID: 6714
		internal static readonly global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember> EmptyArrayEdmProperty = new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Common.TypeHelpers.EmptyArrayEdmMember, null);
	}
}
