using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000652 RID: 1618
	internal static class FunctionOverloadResolver
	{
		// Token: 0x06004E02 RID: 19970 RVA: 0x001178F8 File Offset: 0x00115AF8
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ResolveFunctionOverloads(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionsMetadata, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, bool isGroupAggregateFunction, out bool isAmbiguous)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(functionsMetadata, argTypes, (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction) => edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter) => functionParameter.TypeUsage, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter) => functionParameter.Mode, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argType) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.FlattenType(argType), (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage paramType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage argType) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.FlattenType(paramType), (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPromotableTo(fromType, toType), (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(fromType, toType), isGroupAggregateFunction, out isAmbiguous);
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x001179E8 File Offset: 0x00115BE8
		internal static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction ResolveFunctionOverloads(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionsMetadata, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> flattenArgumentType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> flattenParameterType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isPromotableTo, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isStructurallyEqual, bool isGroupAggregateFunction, out bool isAmbiguous)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.ResolveFunctionOverloads<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(functionsMetadata, argTypes, (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction) => edmFunction.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter) => functionParameter.TypeUsage, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter) => functionParameter.Mode, flattenArgumentType, flattenParameterType, isPromotableTo, isStructurallyEqual, isGroupAggregateFunction, out isAmbiguous);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x00117A64 File Offset: 0x00115C64
		internal static TFunctionMetadata ResolveFunctionOverloads<TFunctionMetadata, TFunctionParameterMetadata>(global::System.Collections.Generic.IList<TFunctionMetadata> functionsMetadata, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes, global::System.Func<TFunctionMetadata, global::System.Collections.Generic.IList<TFunctionParameterMetadata>> getSignatureParams, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> getParameterTypeUsage, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode> getParameterMode, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> flattenArgumentType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> flattenParameterType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isPromotableTo, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isStructurallyEqual, bool isGroupAggregateFunction, out bool isAmbiguous) where TFunctionMetadata : class
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(argTypes.Count);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage arg in argTypes)
			{
				list.AddRange(flattenArgumentType(arg));
			}
			TFunctionMetadata tfunctionMetadata = default(TFunctionMetadata);
			isAmbiguous = false;
			global::System.Collections.Generic.List<int[]> list2 = new global::System.Collections.Generic.List<int[]>(functionsMetadata.Count);
			int[] bestCandidateRank = null;
			int i = 0;
			int num = int.MinValue;
			while (i < functionsMetadata.Count)
			{
				int num2;
				int[] array;
				if (global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.TryRankFunctionParameters<TFunctionParameterMetadata>(argTypes, list, getSignatureParams(functionsMetadata[i]), getParameterTypeUsage, getParameterMode, flattenParameterType, isPromotableTo, isStructurallyEqual, isGroupAggregateFunction, out num2, out array))
				{
					if (num2 == num)
					{
						isAmbiguous = true;
					}
					else if (num2 > num)
					{
						isAmbiguous = false;
						num = num2;
						tfunctionMetadata = functionsMetadata[i];
						bestCandidateRank = array;
					}
					list2.Add(array);
				}
				i++;
			}
			if (tfunctionMetadata != null && !isAmbiguous && list.Count > 1 && list2.Count > 1)
			{
				isAmbiguous = list2.Any(delegate(int[] rank)
				{
					if (bestCandidateRank != rank)
					{
						for (int j = 0; j < rank.Length; j++)
						{
							if (bestCandidateRank[j] < rank[j])
							{
								return true;
							}
						}
					}
					return false;
				});
			}
			if (!isAmbiguous)
			{
				return tfunctionMetadata;
			}
			return default(TFunctionMetadata);
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x00117BA8 File Offset: 0x00115DA8
		private static bool TryRankFunctionParameters<TFunctionParameterMetadata>(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argumentList, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> flatArgumentList, global::System.Collections.Generic.IList<TFunctionParameterMetadata> overloadParamList, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> getParameterTypeUsage, global::System.Func<TFunctionParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode> getParameterMode, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> flattenParameterType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isPromotableTo, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isStructurallyEqual, bool isGroupAggregateFunction, out int totalRank, out int[] parameterRanks)
		{
			totalRank = 0;
			parameterRanks = null;
			if (argumentList.Count != overloadParamList.Count)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(flatArgumentList.Count);
			for (int i = 0; i < overloadParamList.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = argumentList[i];
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = getParameterTypeUsage(overloadParamList[i]);
				global::System.Data.Entity.Core.Metadata.Edm.ParameterMode parameterMode = getParameterMode(overloadParamList[i]);
				if (parameterMode != global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In && parameterMode != global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut)
				{
					return false;
				}
				if (isGroupAggregateFunction)
				{
					if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(typeUsage2))
					{
						throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.InvalidArgumentTypeForAggregateFunction);
					}
					typeUsage2 = global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(typeUsage2);
				}
				if (!isPromotableTo(typeUsage, typeUsage2))
				{
					return false;
				}
				list.AddRange(flattenParameterType(typeUsage2, typeUsage));
			}
			parameterRanks = new int[list.Count];
			for (int j = 0; j < parameterRanks.Length; j++)
			{
				int promotionRank = global::System.Data.Entity.Core.Common.EntitySql.FunctionOverloadResolver.GetPromotionRank(flatArgumentList[j], list[j], isPromotableTo, isStructurallyEqual);
				totalRank += promotionRank;
				parameterRanks[j] = promotionRank;
			}
			return true;
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x00117CA4 File Offset: 0x00115EA4
		private static int GetPromotionRank(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isPromotableTo, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, bool> isStructurallyEqual)
		{
			if (isStructurallyEqual(fromType, toType))
			{
				return 0;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = fromType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType2 = toType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
			if (primitiveType != null && primitiveType2 != null)
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.AreSameSpatialUnionType(primitiveType, primitiveType2))
				{
					return 0;
				}
				int num = ((global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>)global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPromotionTypes(primitiveType)).IndexOf(primitiveType2);
				if (num < 0)
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.FailedToGeneratePromotionRank, 1, null);
				}
				return -num;
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = fromType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase;
				global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase2 = toType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase;
				if (entityTypeBase == null || entityTypeBase2 == null)
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.FailedToGeneratePromotionRank, 3, null);
				}
				int num2 = 0;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = entityTypeBase;
				while (edmType != entityTypeBase2 && edmType != null)
				{
					edmType = edmType.BaseType;
					num2++;
				}
				if (edmType == null)
				{
					throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.FailedToGeneratePromotionRank, 2, null);
				}
				return -num2;
			}
		}
	}
}
