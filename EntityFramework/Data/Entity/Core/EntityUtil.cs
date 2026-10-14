using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core
{
	// Token: 0x020002CB RID: 715
	internal static class EntityUtil
	{
		// Token: 0x06002289 RID: 8841 RVA: 0x00060853 File Offset: 0x0005EA53
		internal static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<T1, T2>> Zip<T1, T2>(this global::System.Collections.Generic.IEnumerable<T1> first, global::System.Collections.Generic.IEnumerable<T2> second)
		{
			if (first == null || second == null)
			{
				yield break;
			}
			using (global::System.Collections.Generic.IEnumerator<T1> firstEnumerator = first.GetEnumerator())
			{
				using (global::System.Collections.Generic.IEnumerator<T2> secondEnumerator = second.GetEnumerator())
				{
					while (firstEnumerator.MoveNext() && secondEnumerator.MoveNext())
					{
						yield return new global::System.Collections.Generic.KeyValuePair<T1, T2>(firstEnumerator.Current, secondEnumerator.Current);
					}
				}
				global::System.Collections.Generic.IEnumerator<T2> secondEnumerator = null;
			}
			global::System.Collections.Generic.IEnumerator<T1> firstEnumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x0006086A File Offset: 0x0005EA6A
		internal static bool IsAnICollection(global::System.Type type)
		{
			return typeof(global::System.Collections.Generic.ICollection<>).IsAssignableFrom(type.GetGenericTypeDefinition()) || type.GetInterface(typeof(global::System.Collections.Generic.ICollection<>).FullName) != null;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000608A0 File Offset: 0x0005EAA0
		internal static global::System.Type GetCollectionElementType(global::System.Type propertyType)
		{
			global::System.Type type = propertyType.TryGetElementType(typeof(global::System.Collections.Generic.ICollection<>));
			if (type == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.PocoEntityWrapper_UnexpectedTypeForNavigationProperty(propertyType.FullName, typeof(global::System.Collections.Generic.ICollection<>)));
			}
			return type;
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000608D8 File Offset: 0x0005EAD8
		internal static global::System.Type DetermineCollectionType(global::System.Type requestedType)
		{
			global::System.Type collectionElementType = global::System.Data.Entity.Core.EntityUtil.GetCollectionElementType(requestedType);
			if (requestedType.IsArray)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectQuery_UnableToMaterializeArray(requestedType, typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
				{
					collectionElementType
				})));
			}
			if (!requestedType.IsAbstract() && requestedType.GetPublicConstructor(new global::System.Type[0]) != null)
			{
				return requestedType;
			}
			global::System.Type type = typeof(global::System.Collections.Generic.HashSet<>).MakeGenericType(new global::System.Type[]
			{
				collectionElementType
			});
			if (requestedType.IsAssignableFrom(type))
			{
				return type;
			}
			global::System.Type type2 = typeof(global::System.Collections.Generic.List<>).MakeGenericType(new global::System.Type[]
			{
				collectionElementType
			});
			if (requestedType.IsAssignableFrom(type2))
			{
				return type2;
			}
			return null;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00060982 File Offset: 0x0005EB82
		internal static global::System.Type GetEntityIdentityType(global::System.Type entityType)
		{
			if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(entityType))
			{
				return entityType;
			}
			return entityType.BaseType();
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00060994 File Offset: 0x0005EB94
		internal static string QuoteIdentifier(string identifier)
		{
			return "[" + identifier.Replace("]", "]]") + "]";
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000609B5 File Offset: 0x0005EBB5
		internal static global::System.Data.Entity.Core.MetadataException InvalidSchemaEncountered(string errors)
		{
			return new global::System.Data.Entity.Core.MetadataException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::System.Data.Entity.Resources.EntityRes.GetString("InvalidSchemaEncountered"), new object[]
			{
				errors
			}));
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x000609DC File Offset: 0x0005EBDC
		internal static global::System.Exception InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode internalError, int location, object additionalInfo)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat("{0}, {1}", (int)internalError, location);
			if (additionalInfo != null)
			{
				stringBuilder.AppendFormat(", {0}", additionalInfo);
			}
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(stringBuilder.ToString()));
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00060A27 File Offset: 0x0005EC27
		internal static void CheckValidStateForChangeEntityState(global::System.Data.Entity.EntityState state)
		{
			if (state <= global::System.Data.Entity.EntityState.Added)
			{
				if (state - global::System.Data.Entity.EntityState.Detached <= 1 || state == global::System.Data.Entity.EntityState.Added)
				{
					return;
				}
			}
			else if (state == global::System.Data.Entity.EntityState.Deleted || state == global::System.Data.Entity.EntityState.Modified)
			{
				return;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntityState, "state");
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00060A52 File Offset: 0x0005EC52
		internal static void CheckValidStateForChangeRelationshipState(global::System.Data.Entity.EntityState state, string paramName)
		{
			if (state - global::System.Data.Entity.EntityState.Detached > 1 && state != global::System.Data.Entity.EntityState.Added && state != global::System.Data.Entity.EntityState.Deleted)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidRelationshipState, paramName);
			}
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00060A6E File Offset: 0x0005EC6E
		internal static void ThrowPropertyIsNotNullable(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
			{
				throw new global::System.Data.ConstraintException(global::System.Data.Entity.Resources.Strings.Materializer_PropertyIsNotNullable);
			}
			throw new global::System.Data.Entity.Core.PropertyConstraintException(global::System.Data.Entity.Resources.Strings.Materializer_PropertyIsNotNullableWithName(propertyName), propertyName);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00060A90 File Offset: 0x0005EC90
		internal static void ThrowSetInvalidValue(object value, global::System.Type destinationType, string className, string propertyName)
		{
			if (value == null)
			{
				throw new global::System.Data.ConstraintException(global::System.Data.Entity.Resources.Strings.Materializer_SetInvalidValue((global::System.Nullable.GetUnderlyingType(destinationType) ?? destinationType).Name, className, propertyName, "null"));
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_SetInvalidValue((global::System.Nullable.GetUnderlyingType(destinationType) ?? destinationType).Name, className, propertyName, value.GetType().Name));
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00060AEC File Offset: 0x0005ECEC
		internal static global::System.InvalidOperationException ValueInvalidCast(global::System.Type valueType, global::System.Type destinationType)
		{
			if (destinationType.IsValueType() && destinationType.IsGenericType() && typeof(global::System.Nullable<>) == destinationType.GetGenericTypeDefinition())
			{
				return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_InvalidCastNullable(valueType, destinationType.GetGenericArguments()[0]));
			}
			return new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_InvalidCastReference(valueType, destinationType));
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00060B40 File Offset: 0x0005ED40
		internal static void CheckArgumentMergeOption(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			if (mergeOption > global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				string name = typeof(global::System.Data.Entity.Core.Objects.MergeOption).Name;
				object name2 = typeof(global::System.Data.Entity.Core.Objects.MergeOption).Name;
				int num = (int)mergeOption;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name2, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00060B88 File Offset: 0x0005ED88
		internal static void CheckArgumentRefreshMode(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode)
		{
			if (refreshMode != global::System.Data.Entity.Core.Objects.RefreshMode.ClientWins && refreshMode != global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins)
			{
				string name = typeof(global::System.Data.Entity.Core.Objects.RefreshMode).Name;
				object name2 = typeof(global::System.Data.Entity.Core.Objects.RefreshMode).Name;
				int num = (int)refreshMode;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name2, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00060BD4 File Offset: 0x0005EDD4
		internal static global::System.InvalidOperationException ExecuteFunctionCalledWithNonReaderFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport)
		{
			string message;
			if (functionImport.ReturnParameter == null)
			{
				message = global::System.Data.Entity.Resources.Strings.ObjectContext_ExecuteFunctionCalledWithNonQueryFunction(functionImport.Name);
			}
			else
			{
				message = global::System.Data.Entity.Resources.Strings.ObjectContext_ExecuteFunctionCalledWithScalarFunction(functionImport.ReturnParameter.TypeUsage.EdmType.FullName, functionImport.Name);
			}
			return new global::System.InvalidOperationException(message);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00060C1E File Offset: 0x0005EE1E
		internal static void ValidateEntitySetInKey(global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(key, entitySet, null);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00060C28 File Offset: 0x0005EE28
		internal static void ValidateEntitySetInKey(global::System.Data.Entity.Core.EntityKey key, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, string argument)
		{
			string entityContainerName = key.EntityContainerName;
			string entitySetName = key.EntitySetName;
			string name = entitySet.EntityContainer.Name;
			string name2 = entitySet.Name;
			if (global::System.StringComparer.Ordinal.Equals(entityContainerName, name) && global::System.StringComparer.Ordinal.Equals(entitySetName, name2))
			{
				return;
			}
			if (string.IsNullOrEmpty(argument))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntitySetInKey(entityContainerName, entitySetName, name, name2));
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntitySetInKeyFromName(entityContainerName, entitySetName, name, name2, argument));
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00060C99 File Offset: 0x0005EE99
		internal static void ValidateNecessaryModificationFunctionMapping(global::System.Data.Entity.Core.Mapping.ModificationFunctionMapping mapping, string currentState, global::System.Data.Entity.Core.IEntityStateEntry stateEntry, string type, string typeName)
		{
			if (mapping == null)
			{
				throw new global::System.Data.Entity.Core.UpdateException(global::System.Data.Entity.Resources.Strings.Update_MissingFunctionMapping(currentState, type, typeName), null, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.IEntityStateEntry>
				{
					stateEntry
				}.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
			}
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00060CC4 File Offset: 0x0005EEC4
		internal static global::System.Data.Entity.Core.UpdateException Update(string message, global::System.Exception innerException, params global::System.Data.Entity.Core.IEntityStateEntry[] stateEntries)
		{
			return new global::System.Data.Entity.Core.UpdateException(message, innerException, stateEntries.Cast<global::System.Data.Entity.Core.Objects.ObjectStateEntry>().Distinct<global::System.Data.Entity.Core.Objects.ObjectStateEntry>());
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00060CD8 File Offset: 0x0005EED8
		internal static global::System.Data.Entity.Core.UpdateException UpdateRelationshipCardinalityConstraintViolation(string relationshipSetName, int minimumCount, int? maximumCount, string entitySetName, int actualCount, string otherEndPluralName, global::System.Data.Entity.Core.IEntityStateEntry stateEntry)
		{
			string text = global::System.Data.Entity.Core.EntityUtil.ConvertCardinalityToString(new int?(minimumCount));
			string text2 = global::System.Data.Entity.Core.EntityUtil.ConvertCardinalityToString(maximumCount);
			string p = global::System.Data.Entity.Core.EntityUtil.ConvertCardinalityToString(new int?(actualCount));
			if (minimumCount == 1 && text == text2)
			{
				return global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_RelationshipCardinalityConstraintViolationSingleValue(entitySetName, relationshipSetName, p, otherEndPluralName, text), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
				{
					stateEntry
				});
			}
			return global::System.Data.Entity.Core.EntityUtil.Update(global::System.Data.Entity.Resources.Strings.Update_RelationshipCardinalityConstraintViolation(entitySetName, relationshipSetName, p, otherEndPluralName, text, text2), null, new global::System.Data.Entity.Core.IEntityStateEntry[]
			{
				stateEntry
			});
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00060D4C File Offset: 0x0005EF4C
		private static string ConvertCardinalityToString(int? cardinality)
		{
			if (cardinality != null)
			{
				return cardinality.Value.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
			return "*";
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00060D7C File Offset: 0x0005EF7C
		internal static T CheckArgumentOutOfRange<T>(T[] values, int index, string parameterName)
		{
			if (values.Length <= index)
			{
				throw new global::System.ArgumentOutOfRangeException(parameterName);
			}
			return values[index];
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00060D94 File Offset: 0x0005EF94
		internal static global::System.Collections.Generic.IEnumerable<T> CheckArgumentContainsNull<T>(ref global::System.Collections.Generic.IEnumerable<T> enumerableArgument, string argumentName) where T : class
		{
			global::System.Data.Entity.Core.EntityUtil.GetCheapestSafeEnumerableAsCollection<T>(ref enumerableArgument);
			using (global::System.Collections.Generic.IEnumerator<T> enumerator = enumerableArgument.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CheckArgumentContainsNullFailed(argumentName));
					}
				}
			}
			return enumerableArgument;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00060DF4 File Offset: 0x0005EFF4
		internal static global::System.Collections.Generic.IEnumerable<T> CheckArgumentEmpty<T>(ref global::System.Collections.Generic.IEnumerable<T> enumerableArgument, global::System.Func<string, string> errorMessage, string argumentName)
		{
			int num;
			global::System.Data.Entity.Core.EntityUtil.GetCheapestSafeCountOfEnumerable<T>(ref enumerableArgument, out num);
			if (num <= 0)
			{
				throw new global::System.ArgumentException(errorMessage(argumentName));
			}
			return enumerableArgument;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00060E1C File Offset: 0x0005F01C
		private static void GetCheapestSafeCountOfEnumerable<T>(ref global::System.Collections.Generic.IEnumerable<T> enumerable, out int count)
		{
			global::System.Collections.Generic.ICollection<T> cheapestSafeEnumerableAsCollection = global::System.Data.Entity.Core.EntityUtil.GetCheapestSafeEnumerableAsCollection<T>(ref enumerable);
			count = cheapestSafeEnumerableAsCollection.Count;
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x00060E38 File Offset: 0x0005F038
		private static global::System.Collections.Generic.ICollection<T> GetCheapestSafeEnumerableAsCollection<T>(ref global::System.Collections.Generic.IEnumerable<T> enumerable)
		{
			global::System.Collections.Generic.ICollection<T> collection = enumerable as global::System.Collections.Generic.ICollection<T>;
			if (collection != null)
			{
				return collection;
			}
			enumerable = new global::System.Collections.Generic.List<T>(enumerable);
			return enumerable as global::System.Collections.Generic.ICollection<T>;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00060E64 File Offset: 0x0005F064
		internal static bool IsNull(object value)
		{
			if (value == null || global::System.DBNull.Value == value)
			{
				return true;
			}
			global::System.Data.SqlTypes.INullable nullable = value as global::System.Data.SqlTypes.INullable;
			return nullable != null && nullable.IsNull;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00060E90 File Offset: 0x0005F090
		internal static int SrcCompare(string strA, string strB)
		{
			if (!(strA == strB))
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00060E9E File Offset: 0x0005F09E
		internal static int DstCompare(string strA, string strB)
		{
			return global::System.Globalization.CultureInfo.CurrentCulture.CompareInfo.Compare(strA, strB, global::System.Globalization.CompareOptions.IgnoreCase | global::System.Globalization.CompareOptions.IgnoreKanaType | global::System.Globalization.CompareOptions.IgnoreWidth);
		}

		// Token: 0x04000BEE RID: 3054
		internal const int AssemblyQualifiedNameIndex = 3;

		// Token: 0x04000BEF RID: 3055
		internal const int InvariantNameIndex = 2;

		// Token: 0x04000BF0 RID: 3056
		internal const string Parameter = "Parameter";

		// Token: 0x04000BF1 RID: 3057
		internal const global::System.Globalization.CompareOptions StringCompareOptions = global::System.Globalization.CompareOptions.IgnoreCase | global::System.Globalization.CompareOptions.IgnoreKanaType | global::System.Globalization.CompareOptions.IgnoreWidth;

		// Token: 0x04000BF2 RID: 3058
		internal static global::System.Collections.Generic.Dictionary<string, string> COMPILER_VERSION = new global::System.Collections.Generic.Dictionary<string, string>
		{
			{
				"CompilerVersion",
				"V3.5"
			}
		};

		// Token: 0x020009AF RID: 2479
		internal enum InternalErrorCode
		{
			// Token: 0x040027D2 RID: 10194
			WrongNumberOfKeys = 1000,
			// Token: 0x040027D3 RID: 10195
			UnknownColumnMapKind,
			// Token: 0x040027D4 RID: 10196
			NestOverNest,
			// Token: 0x040027D5 RID: 10197
			ColumnCountMismatch,
			// Token: 0x040027D6 RID: 10198
			AssertionFailed,
			// Token: 0x040027D7 RID: 10199
			UnknownVar,
			// Token: 0x040027D8 RID: 10200
			WrongVarType,
			// Token: 0x040027D9 RID: 10201
			ExtentWithoutEntity,
			// Token: 0x040027DA RID: 10202
			UnnestWithoutInput,
			// Token: 0x040027DB RID: 10203
			UnnestMultipleCollections,
			// Token: 0x040027DC RID: 10204
			CodeGen_NoSuchProperty = 1011,
			// Token: 0x040027DD RID: 10205
			JoinOverSingleStreamNest,
			// Token: 0x040027DE RID: 10206
			InvalidInternalTree,
			// Token: 0x040027DF RID: 10207
			NameValuePairNext,
			// Token: 0x040027E0 RID: 10208
			InvalidParserState1,
			// Token: 0x040027E1 RID: 10209
			InvalidParserState2,
			// Token: 0x040027E2 RID: 10210
			SqlGenParametersNotPermitted,
			// Token: 0x040027E3 RID: 10211
			EntityKeyMissingKeyValue,
			// Token: 0x040027E4 RID: 10212
			UpdatePipelineResultRequestInvalid,
			// Token: 0x040027E5 RID: 10213
			InvalidStateEntry,
			// Token: 0x040027E6 RID: 10214
			InvalidPrimitiveTypeKind,
			// Token: 0x040027E7 RID: 10215
			UnknownLinqNodeType = 1023,
			// Token: 0x040027E8 RID: 10216
			CollectionWithNoColumns,
			// Token: 0x040027E9 RID: 10217
			UnexpectedLinqLambdaExpressionFormat,
			// Token: 0x040027EA RID: 10218
			CommandTreeOnStoredProcedureEntityCommand,
			// Token: 0x040027EB RID: 10219
			BoolExprAssert,
			// Token: 0x040027EC RID: 10220
			FailedToGeneratePromotionRank = 1029
		}
	}
}
