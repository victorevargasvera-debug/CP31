using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000500 RID: 1280
	internal static class TypeSemantics
	{
		// Token: 0x06003F4A RID: 16202 RVA: 0x000D1AEC File Offset: 0x000CFCEC
		internal static bool IsEqual(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.CompareTypes(type1, type2, false);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x000D1AF6 File Offset: 0x000CFCF6
		internal static bool IsStructurallyEqual(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.CompareTypes(fromType, toType, true);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x000D1B00 File Offset: 0x000CFD00
		internal static bool IsStructurallyEqualOrPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(fromType, toType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(fromType, toType);
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x000D1B14 File Offset: 0x000CFD14
		internal static bool IsStructurallyEqualOrPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.EdmType fromType, global::System.Data.Entity.Core.Metadata.Edm.EdmType toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(fromType), global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(toType));
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x000D1B27 File Offset: 0x000CFD27
		internal static bool IsSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage subType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage superType)
		{
			if (subType.EdmEquals(superType))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(subType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(superType.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveTypeSubTypeOf(subType, superType);
			}
			return subType.IsSubtypeOf(superType);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x000D1B5D File Offset: 0x000CFD5D
		internal static bool IsSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.EdmType subEdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType superEdmType)
		{
			return subEdmType.IsSubtypeOf(superEdmType);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x000D1B68 File Offset: 0x000CFD68
		internal static bool IsPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			if (toType.EdmType.EdmEquals(fromType.EdmType))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(toType.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveTypePromotableTo(fromType, toType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(toType.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(fromType), global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(toType));
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(toType.EdmType))
			{
				return fromType.EdmType.IsSubtypeOf(toType.EdmType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(toType.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(fromType), global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(toType));
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(toType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo((global::System.Data.Entity.Core.Metadata.Edm.RowType)fromType.EdmType, (global::System.Data.Entity.Core.Metadata.Edm.RowType)toType.EdmType);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x000D1C68 File Offset: 0x000CFE68
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> FlattenType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isLeaf = (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage t) => !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsTransientType(t.EdmType);
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> getImmediateSubNodes = delegate(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage t)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(t.EdmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(t.EdmType))
				{
					return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]
					{
						global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(t)
					};
				}
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(t.EdmType))
				{
					return from p in ((global::System.Data.Entity.Core.Metadata.Edm.RowType)t.EdmType).Properties
					select p.TypeUsage;
				}
				return new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[0];
			};
			return global::System.Data.Entity.Core.Common.Utils.Helpers.GetLeafNodes<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, isLeaf, getImmediateSubNodes);
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x000D1CC0 File Offset: 0x000CFEC0
		internal static bool IsCastAllowed(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(toType.EdmType)) || (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(toType.EdmType)) || (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(toType.EdmType)) || (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(fromType.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(toType.EdmType) && fromType.EdmType.Equals(toType.EdmType));
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x000D1D4C File Offset: 0x000CFF4C
		internal static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonType)
		{
			commonType = null;
			if (type1.EdmEquals(type2))
			{
				commonType = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.ForgetConstraints(type2);
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type1.EdmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type2.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonPrimitiveType(type1, type2, out commonType);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(type1.EdmType, type2.EdmType, out edmType))
			{
				commonType = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.ForgetConstraints(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType));
				return true;
			}
			commonType = null;
			return false;
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x000D1DBC File Offset: 0x000CFFBC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetCommonType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(type1, type2, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x000D1DD9 File Offset: 0x000CFFD9
		internal static bool IsAggregateFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return function.AggregateAttribute;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x000D1DE1 File Offset: 0x000CFFE1
		internal static bool IsValidPolymorphicCast(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(fromType) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(toType) && (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(fromType, toType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(fromType, toType) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(toType, fromType));
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x000D1E10 File Offset: 0x000D0010
		internal static bool IsValidPolymorphicCast(global::System.Data.Entity.Core.Metadata.Edm.EdmType fromEdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType toEdmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(fromEdmType), global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(toEdmType));
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x000D1E23 File Offset: 0x000D0023
		internal static bool IsNominalType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type);
		}

		// Token: 0x06003F59 RID: 16217 RVA: 0x000D1E35 File Offset: 0x000D0035
		internal static bool IsCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(type.EdmType);
		}

		// Token: 0x06003F5A RID: 16218 RVA: 0x000D1E42 File Offset: 0x000D0042
		internal static bool IsComplexType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType == type.EdmType.BuiltInTypeKind;
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x000D1E52 File Offset: 0x000D0052
		internal static bool IsEntityType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(type.EdmType);
		}

		// Token: 0x06003F5C RID: 16220 RVA: 0x000D1E5F File Offset: 0x000D005F
		internal static bool IsRelationshipType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType == type.EdmType.BuiltInTypeKind;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x000D1E6F File Offset: 0x000D006F
		internal static bool IsEnumerationType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(type.EdmType);
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x000D1E7C File Offset: 0x000D007C
		internal static bool IsScalarType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(type.EdmType);
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x000D1E89 File Offset: 0x000D0089
		internal static bool IsScalarType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(type);
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x000D1E9B File Offset: 0x000D009B
		internal static bool IsNumericType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsFixedPointNumericType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsFloatPointNumericType(type);
		}

		// Token: 0x06003F61 RID: 16225 RVA: 0x000D1EB8 File Offset: 0x000D00B8
		internal static bool IsIntegerNumericType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(type, out primitiveTypeKind) && (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte || primitiveTypeKind - global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte <= 3);
		}

		// Token: 0x06003F62 RID: 16226 RVA: 0x000D1EE0 File Offset: 0x000D00E0
		internal static bool IsFixedPointNumericType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(type, out primitiveTypeKind) && primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal;
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x000D1F00 File Offset: 0x000D0100
		internal static bool IsFloatPointNumericType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(type, out primitiveTypeKind) && (primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double || primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single);
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x000D1F24 File Offset: 0x000D0124
		internal static bool IsUnsignedNumericType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(type, out primitiveTypeKind) && primitiveTypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x000D1F44 File Offset: 0x000D0144
		internal static bool IsPolymorphicType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type);
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x000D1F56 File Offset: 0x000D0156
		internal static bool IsBooleanType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x000D1F5F File Offset: 0x000D015F
		internal static bool IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type.EdmType);
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x000D1F6C File Offset: 0x000D016C
		internal static bool IsPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind2;
			return global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(type, out primitiveTypeKind2) && primitiveTypeKind2 == primitiveTypeKind;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x000D1F89 File Offset: 0x000D0189
		internal static bool IsRowType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(type.EdmType);
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x000D1F96 File Offset: 0x000D0196
		internal static bool IsReferenceType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(type.EdmType);
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x000D1FA3 File Offset: 0x000D01A3
		internal static bool IsSpatialType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(type);
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x000D1FAB File Offset: 0x000D01AB
		internal static bool IsStrongSpatialType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongSpatialTypeKind(((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type.EdmType).PrimitiveTypeKind);
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x000D1FCC File Offset: 0x000D01CC
		internal static bool IsStructuralType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(type.EdmType);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x000D1FDC File Offset: 0x000D01DC
		internal static bool IsPartOfKey(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipEndMember(edmMember))
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)edmMember.DeclaringType).KeyMembers.Contains(edmMember);
			}
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty(edmMember) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(edmMember.DeclaringType) && ((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase)edmMember.DeclaringType).KeyMembers.Contains(edmMember);
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x000D2038 File Offset: 0x000D0238
		internal static bool IsNullable(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			return !type.Facets.TryGetValue("Nullable", false, out facet) || (bool)facet.Value;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x000D2067 File Offset: 0x000D0267
		internal static bool IsNullable(global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(edmMember.TypeUsage);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x000D2074 File Offset: 0x000D0274
		internal static bool IsEqualComparable(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(type.EdmType);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x000D2081 File Offset: 0x000D0281
		internal static bool IsEqualComparableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(type1) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(type2) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.HasCommonType(type1, type2);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x000D209C File Offset: 0x000D029C
		internal static bool IsOrderComparable(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparable(type.EdmType);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x000D20A9 File Offset: 0x000D02A9
		internal static bool IsOrderComparableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparable(type1) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparable(type2) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.HasCommonType(type1, type2);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x000D20C4 File Offset: 0x000D02C4
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ForgetConstraints(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(type.EdmType))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.ForgetScalarConstraints(type);
			}
			return type;
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x000D20E0 File Offset: 0x000D02E0
		[global::System.Diagnostics.Conditional("DEBUG")]
		internal static void AssertTypeInvariant(string message, global::System.Func<bool> assertPredicate)
		{
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x000D20E2 File Offset: 0x000D02E2
		private static bool IsPrimitiveTypeSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)fromType.EdmType, (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)toType.EdmType);
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x000D2104 File Offset: 0x000D0304
		private static bool IsSubTypeOf(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType subPrimitiveType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType superPrimitiveType)
		{
			if (subPrimitiveType == superPrimitiveType)
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.AreSameSpatialUnionType(subPrimitiveType, superPrimitiveType))
			{
				return true;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> promotionTypes = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPromotionTypes(subPrimitiveType);
			return -1 != promotionTypes.IndexOf(superPrimitiveType);
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x000D213C File Offset: 0x000D033C
		private static bool IsPromotableTo(global::System.Data.Entity.Core.Metadata.Edm.RowType fromRowType, global::System.Data.Entity.Core.Metadata.Edm.RowType toRowType)
		{
			if (fromRowType.Properties.Count != toRowType.Properties.Count)
			{
				return false;
			}
			for (int i = 0; i < fromRowType.Properties.Count; i++)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(fromRowType.Properties[i].TypeUsage, toRowType.Properties[i].TypeUsage))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x000D21A5 File Offset: 0x000D03A5
		private static bool IsPrimitiveTypePromotableTo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)fromType.EdmType, (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)toType.EdmType);
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x000D21C8 File Offset: 0x000D03C8
		private static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType1, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonEdmType)
		{
			if (edmType2 == edmType1)
			{
				commonEdmType = edmType1;
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType1) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType2))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType1, (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)edmType2, out commonEdmType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(edmType1) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(edmType2))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType1, (global::System.Data.Entity.Core.Metadata.Edm.CollectionType)edmType2, out commonEdmType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(edmType1) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityTypeBase(edmType2))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonBaseType(edmType1, edmType2, out commonEdmType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(edmType1) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(edmType2))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType((global::System.Data.Entity.Core.Metadata.Edm.RefType)edmType1, (global::System.Data.Entity.Core.Metadata.Edm.RefType)edmType2, out commonEdmType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType1) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType2))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType1, (global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType2, out commonEdmType);
			}
			commonEdmType = null;
			return false;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x000D2288 File Offset: 0x000D0488
		private static bool TryGetCommonPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonType)
		{
			commonType = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(type1, type2))
			{
				commonType = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.ForgetConstraints(type2);
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(type2, type1))
			{
				commonType = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.ForgetConstraints(type1);
				return true;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> primitiveCommonSuperTypes = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.GetPrimitiveCommonSuperTypes((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type1.EdmType, (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)type2.EdmType);
			if (primitiveCommonSuperTypes.Count == 0)
			{
				return false;
			}
			commonType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateDefaultTypeUsage(primitiveCommonSuperTypes[0]);
			return commonType != null;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x000D22F8 File Offset: 0x000D04F8
		private static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType1, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonType)
		{
			commonType = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(primitiveType1, primitiveType2))
			{
				commonType = primitiveType2;
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(primitiveType2, primitiveType1))
			{
				commonType = primitiveType1;
				return true;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> primitiveCommonSuperTypes = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.GetPrimitiveCommonSuperTypes(primitiveType1, primitiveType2);
			if (primitiveCommonSuperTypes.Count > 0)
			{
				commonType = primitiveCommonSuperTypes[0];
				return true;
			}
			return false;
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x000D2344 File Offset: 0x000D0544
		private static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType1, global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType = null;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(collectionType1.TypeUsage, collectionType2.TypeUsage, out elementType))
			{
				commonType = null;
				return false;
			}
			commonType = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(elementType);
			return true;
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x000D2376 File Offset: 0x000D0576
		private static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.RefType refType1, global::System.Data.Entity.Core.Metadata.Edm.RefType reftype2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonType)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(refType1.ElementType, reftype2.ElementType, out commonType))
			{
				return false;
			}
			commonType = new global::System.Data.Entity.Core.Metadata.Edm.RefType((global::System.Data.Entity.Core.Metadata.Edm.EntityType)commonType);
			return true;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x000D23A0 File Offset: 0x000D05A0
		private static bool TryGetCommonType(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType1, global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonRowType)
		{
			if (rowType1.Properties.Count != rowType2.Properties.Count || rowType1.InitializerMetadata != rowType2.InitializerMetadata)
			{
				commonRowType = null;
				return false;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			for (int i = 0; i < rowType1.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(rowType1.Properties[i].TypeUsage, rowType2.Properties[i].TypeUsage, out typeUsage))
				{
					commonRowType = null;
					return false;
				}
				list.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(rowType1.Properties[i].Name, typeUsage));
			}
			commonRowType = new global::System.Data.Entity.Core.Metadata.Edm.RowType(list, rowType1.InitializerMetadata);
			return true;
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x000D2450 File Offset: 0x000D0650
		internal static bool TryGetCommonBaseType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type1, global::System.Data.Entity.Core.Metadata.Edm.EdmType type2, out global::System.Data.Entity.Core.Metadata.Edm.EdmType commonBaseType)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, byte> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, byte>();
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = type2; edmType != null; edmType = edmType.BaseType)
			{
				dictionary.Add(edmType, 0);
			}
			for (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = type1; edmType2 != null; edmType2 = edmType2.BaseType)
			{
				if (dictionary.ContainsKey(edmType2))
				{
					commonBaseType = edmType2;
					return true;
				}
			}
			commonBaseType = null;
			return false;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x000D2499 File Offset: 0x000D0699
		private static bool HasCommonType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type1, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2)
		{
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(type1, type2) != null;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x000D24A8 File Offset: 0x000D06A8
		private static bool IsEqualComparable(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(edmType))
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)edmType).Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparable(enumerator.Current.TypeUsage))
						{
							return false;
						}
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x000D2538 File Offset: 0x000D0738
		private static bool IsOrderComparable(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Helper.IsScalarType(edmType);
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x000D2540 File Offset: 0x000D0740
		private static bool CompareTypes(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType, bool equivalenceOnly)
		{
			if (fromType == toType)
			{
				return true;
			}
			if (fromType.EdmType.BuiltInTypeKind != toType.EdmType.BuiltInTypeKind)
			{
				return false;
			}
			if (fromType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.CompareTypes(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)fromType.EdmType).TypeUsage, ((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)toType.EdmType).TypeUsage, equivalenceOnly);
			}
			if (fromType.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
			{
				return ((global::System.Data.Entity.Core.Metadata.Edm.RefType)fromType.EdmType).ElementType.EdmEquals(((global::System.Data.Entity.Core.Metadata.Edm.RefType)toType.EdmType).ElementType);
			}
			if (fromType.EdmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				return fromType.EdmType.EdmEquals(toType.EdmType);
			}
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)fromType.EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = (global::System.Data.Entity.Core.Metadata.Edm.RowType)toType.EdmType;
			if (rowType.Properties.Count != rowType2.Properties.Count)
			{
				return false;
			}
			for (int i = 0; i < rowType.Properties.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = rowType.Properties[i];
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = rowType2.Properties[i];
				if (!equivalenceOnly && edmProperty.Name != edmProperty2.Name)
				{
					return false;
				}
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.CompareTypes(edmProperty.TypeUsage, edmProperty2.TypeUsage, equivalenceOnly))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000D2690 File Offset: 0x000D0890
		private static void ComputeCommonTypeClosure()
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics._commonTypeClosure != null)
			{
				return;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[,] array = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[32, 32];
			for (int i = 0; i < 32; i++)
			{
				array[i, i] = global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyPrimitiveTypeReadOnlyCollection;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> storeTypes = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetStoreTypes();
			for (int j = 0; j < 32; j++)
			{
				for (int k = 0; k < j; k++)
				{
					array[j, k] = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.Intersect(global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPromotionTypes(storeTypes[j]), global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPromotionTypes(storeTypes[k]));
					array[k, j] = array[j, k];
				}
			}
			global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[,]>(ref global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics._commonTypeClosure, array, null);
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x000D2744 File Offset: 0x000D0944
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> Intersect(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> types1, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> types2)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>();
			for (int i = 0; i < types1.Count; i++)
			{
				if (types2.Contains(types1[i]))
				{
					list.Add(types1[i]);
				}
			}
			if (list.Count == 0)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyPrimitiveTypeReadOnlyCollection;
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(list);
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x000D2798 File Offset: 0x000D0998
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> GetPrimitiveCommonSuperTypes(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType1, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.ComputeCommonTypeClosure();
			return global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics._commonTypeClosure[(int)primitiveType1.PrimitiveTypeKind, (int)primitiveType2.PrimitiveTypeKind];
		}

		// Token: 0x04001597 RID: 5527
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>[,] _commonTypeClosure;
	}
}
