using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000633 RID: 1587
	internal static class CodeGenEmitter
	{
		// Token: 0x06004C72 RID: 19570 RVA: 0x0010C8BC File Offset: 0x0010AABC
		internal static bool BinaryEquals(byte[] left, byte[] right)
		{
			if (left == null)
			{
				return right == null;
			}
			if (right == null)
			{
				return false;
			}
			if (left.Length != right.Length)
			{
				return false;
			}
			for (int i = 0; i < left.Length; i++)
			{
				if (left[i] != right[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x0010C8F9 File Offset: 0x0010AAF9
		internal static global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TResult> Compile<TResult>(global::System.Linq.Expressions.Expression body)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.BuildShaperLambda<TResult>(body).Compile();
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x0010C906 File Offset: 0x0010AB06
		internal static global::System.Linq.Expressions.Expression<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TResult>> BuildShaperLambda<TResult>(global::System.Linq.Expressions.Expression body)
		{
			if (body != null)
			{
				return global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, TResult>>(body, new global::System.Linq.Expressions.ParameterExpression[]
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter
				});
			}
			return null;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x0010C921 File Offset: 0x0010AB21
		internal static object Compile(global::System.Type resultType, global::System.Linq.Expressions.Expression body)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.CodeGenEmitter_Compile.MakeGenericMethod(new global::System.Type[]
			{
				resultType
			}).Invoke(null, new object[]
			{
				body
			});
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x0010C948 File Offset: 0x0010AB48
		internal static global::System.Linq.Expressions.Expression Emit_AndAlso(global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> operands)
		{
			global::System.Linq.Expressions.Expression expression = null;
			foreach (global::System.Linq.Expressions.Expression expression2 in operands)
			{
				if (expression == null)
				{
					expression = expression2;
				}
				else
				{
					expression = global::System.Linq.Expressions.Expression.AndAlso(expression, expression2);
				}
			}
			return expression;
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x0010C99C File Offset: 0x0010AB9C
		internal static global::System.Linq.Expressions.Expression Emit_BitwiseOr(global::System.Collections.Generic.IEnumerable<global::System.Linq.Expressions.Expression> operands)
		{
			global::System.Linq.Expressions.Expression expression = null;
			foreach (global::System.Linq.Expressions.Expression expression2 in operands)
			{
				if (expression == null)
				{
					expression = expression2;
				}
				else
				{
					expression = global::System.Linq.Expressions.Expression.Or(expression, expression2);
				}
			}
			return expression;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x0010C9F0 File Offset: 0x0010ABF0
		internal static global::System.Linq.Expressions.Expression Emit_NullConstant(global::System.Type type)
		{
			global::System.Linq.Expressions.Expression result;
			if (type.IsNullable())
			{
				result = global::System.Linq.Expressions.Expression.Constant(null, type);
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.Constant(null, typeof(object)), type);
			}
			return result;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x0010CA27 File Offset: 0x0010AC27
		internal static global::System.Linq.Expressions.Expression Emit_WrappedNullConstant()
		{
			return global::System.Linq.Expressions.Expression.Property(null, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_NullWrapper);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x0010CA34 File Offset: 0x0010AC34
		internal static global::System.Linq.Expressions.Expression Emit_EnsureType(global::System.Linq.Expressions.Expression input, global::System.Type type)
		{
			global::System.Linq.Expressions.Expression result = input;
			if (input.Type != type && !typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).IsAssignableFrom(input.Type))
			{
				if (type.IsAssignableFrom(input.Type))
				{
					result = global::System.Linq.Expressions.Expression.Convert(input, type);
				}
				else
				{
					result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.CodeGenEmitter_CheckedConvert.MakeGenericMethod(new global::System.Type[]
					{
						input.Type,
						type
					}), input);
				}
			}
			return result;
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x0010CAA8 File Offset: 0x0010ACA8
		internal static global::System.Linq.Expressions.Expression Emit_EnsureTypeAndWrap(global::System.Linq.Expressions.Expression input, global::System.Linq.Expressions.Expression keyReader, global::System.Linq.Expressions.Expression entitySetReader, global::System.Type requestedType, global::System.Type identityType, global::System.Type actualType, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool isProxy)
		{
			global::System.Linq.Expressions.Expression input2 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(input, requestedType);
			if (!requestedType.IsClass())
			{
				input2 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(input, typeof(object));
			}
			input2 = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(input2, actualType);
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.CreateEntityWrapper(input2, keyReader, entitySetReader, actualType, identityType, mergeOption, isProxy);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x0010CAF0 File Offset: 0x0010ACF0
		internal static global::System.Linq.Expressions.Expression CreateEntityWrapper(global::System.Linq.Expressions.Expression input, global::System.Linq.Expressions.Expression keyReader, global::System.Linq.Expressions.Expression entitySetReader, global::System.Type actualType, global::System.Type identityType, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool isProxy)
		{
			bool flag = actualType.OverridesEqualsOrGetHashCode();
			bool flag2 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey).IsAssignableFrom(actualType);
			bool flag3 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).IsAssignableFrom(actualType);
			bool flag4 = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker).IsAssignableFrom(actualType);
			global::System.Linq.Expressions.Expression expression;
			if (flag3 && flag4 && flag2 && !isProxy)
			{
				expression = global::System.Linq.Expressions.Expression.New(typeof(global::System.Data.Entity.Core.Objects.Internal.LightweightEntityWrapper<>).MakeGenericType(new global::System.Type[]
				{
					actualType
				}).GetDeclaredConstructor(new global::System.Type[]
				{
					actualType,
					typeof(global::System.Data.Entity.Core.EntityKey),
					typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet),
					typeof(global::System.Data.Entity.Core.Objects.ObjectContext),
					typeof(global::System.Data.Entity.Core.Objects.MergeOption),
					typeof(global::System.Type),
					typeof(bool)
				}), new global::System.Linq.Expressions.Expression[]
				{
					input,
					keyReader,
					entitySetReader,
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Context,
					global::System.Linq.Expressions.Expression.Constant(mergeOption, typeof(global::System.Data.Entity.Core.Objects.MergeOption)),
					global::System.Linq.Expressions.Expression.Constant(identityType, typeof(global::System.Type)),
					global::System.Linq.Expressions.Expression.Constant(flag, typeof(bool))
				});
			}
			else
			{
				global::System.Linq.Expressions.Expression expression2 = (!flag3 || isProxy) ? global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetPocoPropertyAccessorStrategyFunc, new global::System.Linq.Expressions.Expression[0]) : global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetNullPropertyAccessorStrategyFunc, new global::System.Linq.Expressions.Expression[0]);
				global::System.Linq.Expressions.Expression expression3 = flag2 ? global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetEntityWithKeyStrategyStrategyFunc, new global::System.Linq.Expressions.Expression[0]) : global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetPocoEntityKeyStrategyFunc, new global::System.Linq.Expressions.Expression[0]);
				global::System.Linq.Expressions.Expression expression4 = flag4 ? global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetEntityWithChangeTrackerStrategyFunc, new global::System.Linq.Expressions.Expression[0]) : global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.EntityWrapperFactory_GetSnapshotChangeTrackingStrategyFunc, new global::System.Linq.Expressions.Expression[0]);
				expression = global::System.Linq.Expressions.Expression.New((flag3 ? typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperWithRelationships<>).MakeGenericType(new global::System.Type[]
				{
					actualType
				}) : typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperWithoutRelationships<>).MakeGenericType(new global::System.Type[]
				{
					actualType
				})).GetDeclaredConstructor(new global::System.Type[]
				{
					actualType,
					typeof(global::System.Data.Entity.Core.EntityKey),
					typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet),
					typeof(global::System.Data.Entity.Core.Objects.ObjectContext),
					typeof(global::System.Data.Entity.Core.Objects.MergeOption),
					typeof(global::System.Type),
					typeof(global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IPropertyAccessorStrategy>),
					typeof(global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IChangeTrackingStrategy>),
					typeof(global::System.Func<object, global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy>),
					typeof(bool)
				}), new global::System.Linq.Expressions.Expression[]
				{
					input,
					keyReader,
					entitySetReader,
					global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Context,
					global::System.Linq.Expressions.Expression.Constant(mergeOption, typeof(global::System.Data.Entity.Core.Objects.MergeOption)),
					global::System.Linq.Expressions.Expression.Constant(identityType, typeof(global::System.Type)),
					expression2,
					expression4,
					expression3,
					global::System.Linq.Expressions.Expression.Constant(flag, typeof(bool))
				});
			}
			return global::System.Linq.Expressions.Expression.Convert(expression, typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper));
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x0010CDEB File Offset: 0x0010AFEB
		internal static global::System.Linq.Expressions.Expression Emit_UnwrapAndEnsureType(global::System.Linq.Expressions.Expression input, global::System.Type type)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.Property(input, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.IEntityWrapper_Entity), type);
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x0010CE00 File Offset: 0x0010B000
		internal static TTarget CheckedConvert<TSource, TTarget>(TSource value)
		{
			TTarget result;
			try
			{
				result = (TTarget)((object)value);
			}
			catch (global::System.InvalidCastException)
			{
				global::System.Type type = value.GetType();
				if (type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CompensatingCollection<>))
				{
					type = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(type.GetGenericArguments());
				}
				throw global::System.Data.Entity.Core.EntityUtil.ValueInvalidCast(type, typeof(TTarget));
			}
			catch (global::System.NullReferenceException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_NullReferenceCast(typeof(TTarget).Name));
			}
			return result;
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x0010CEA8 File Offset: 0x0010B0A8
		internal static global::System.Linq.Expressions.Expression Emit_Equal(global::System.Linq.Expressions.Expression left, global::System.Linq.Expressions.Expression right)
		{
			global::System.Linq.Expressions.Expression result;
			if (typeof(byte[]) == left.Type)
			{
				result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.CodeGenEmitter_BinaryEquals, left, right);
			}
			else
			{
				result = global::System.Linq.Expressions.Expression.Equal(left, right);
			}
			return result;
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x0010CEE4 File Offset: 0x0010B0E4
		internal static global::System.Linq.Expressions.Expression Emit_EntityKey_HasValue(global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns)
		{
			return global::System.Linq.Expressions.Expression.Not(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(keyColumns[0]));
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x0010CEF3 File Offset: 0x0010B0F3
		internal static global::System.Linq.Expressions.Expression Emit_Reader_GetValue(int ordinal, global::System.Type type)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Reader, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetValue, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(ordinal)
			}), type);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x0010CF1E File Offset: 0x0010B11E
		internal static global::System.Linq.Expressions.Expression Emit_Reader_IsDBNull(int ordinal)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Reader, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_IsDBNull, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(ordinal)
			});
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x0010CF43 File Offset: 0x0010B143
		internal static global::System.Linq.Expressions.Expression Emit_Reader_IsDBNull(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(((global::System.Data.Entity.Core.Query.InternalTrees.ScalarColumnMap)columnMap).ColumnPos);
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x0010CF55 File Offset: 0x0010B155
		internal static global::System.Linq.Expressions.Expression Emit_Conditional_NotDBNull(global::System.Linq.Expressions.Expression result, int ordinal, global::System.Type columnType)
		{
			result = global::System.Linq.Expressions.Expression.Condition(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_Reader_IsDBNull(ordinal), global::System.Linq.Expressions.Expression.Constant(global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetDefaultValue(columnType), columnType), result);
			return result;
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x0010CF74 File Offset: 0x0010B174
		internal static global::System.Reflection.MethodInfo GetReaderMethod(global::System.Type type, out bool isNullable)
		{
			isNullable = false;
			global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(type);
			if (null != underlyingType)
			{
				isNullable = true;
				type = underlyingType;
			}
			global::System.Reflection.MethodInfo result;
			switch (global::System.Type.GetTypeCode(type))
			{
			case global::System.TypeCode.Boolean:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetBoolean;
			case global::System.TypeCode.Byte:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetByte;
			case global::System.TypeCode.Int16:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetInt16;
			case global::System.TypeCode.Int32:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetInt32;
			case global::System.TypeCode.Int64:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetInt64;
			case global::System.TypeCode.Single:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetFloat;
			case global::System.TypeCode.Double:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetDouble;
			case global::System.TypeCode.Decimal:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetDecimal;
			case global::System.TypeCode.DateTime:
				return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetDateTime;
			case global::System.TypeCode.String:
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetString;
				isNullable = true;
				return result;
			}
			if (typeof(global::System.Guid) == type)
			{
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetGuid;
			}
			else if (typeof(global::System.TimeSpan) == type || typeof(global::System.DateTimeOffset) == type)
			{
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetValue;
			}
			else if (typeof(object) == type)
			{
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetValue;
			}
			else
			{
				result = global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.DbDataReader_GetValue;
				isNullable = true;
			}
			return result;
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x0010D0C0 File Offset: 0x0010B2C0
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetPropertyValueWithErrorHandling(global::System.Type propertyType, int ordinal, string propertyName, string typeName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage columnType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			global::System.Linq.Expressions.Expression result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(columnType, out primitiveTypeKind))
			{
				result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetSpatialPropertyValueWithErrorHandling.MakeGenericMethod(new global::System.Type[]
				{
					propertyType
				}), new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(ordinal),
					global::System.Linq.Expressions.Expression.Constant(propertyName),
					global::System.Linq.Expressions.Expression.Constant(typeName),
					global::System.Linq.Expressions.Expression.Constant(primitiveTypeKind, typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind))
				});
			}
			else
			{
				result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetPropertyValueWithErrorHandling.MakeGenericMethod(new global::System.Type[]
				{
					propertyType
				}), global::System.Linq.Expressions.Expression.Constant(ordinal), global::System.Linq.Expressions.Expression.Constant(propertyName), global::System.Linq.Expressions.Expression.Constant(typeName));
			}
			return result;
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x0010D170 File Offset: 0x0010B370
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetColumnValueWithErrorHandling(global::System.Type resultType, int ordinal, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage columnType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			global::System.Linq.Expressions.Expression result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSpatialType(columnType, out primitiveTypeKind))
			{
				primitiveTypeKind = (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)columnType.EdmType) ? global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography : global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry);
				result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetSpatialColumnValueWithErrorHandling.MakeGenericMethod(new global::System.Type[]
				{
					resultType
				}), global::System.Linq.Expressions.Expression.Constant(ordinal), global::System.Linq.Expressions.Expression.Constant(primitiveTypeKind, typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind)));
			}
			else
			{
				result = global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetColumnValueWithErrorHandling.MakeGenericMethod(new global::System.Type[]
				{
					resultType
				}), new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(ordinal)
				});
			}
			return result;
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x0010D215 File Offset: 0x0010B415
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetHierarchyIdColumnValue(int ordinal)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetHierarchyIdColumnValue, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(ordinal)
			});
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x0010D23A File Offset: 0x0010B43A
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetGeographyColumnValue(int ordinal)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetGeographyColumnValue, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(ordinal)
			});
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x0010D25F File Offset: 0x0010B45F
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetGeometryColumnValue(int ordinal)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_GetGeometryColumnValue, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(ordinal)
			});
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x0010D284 File Offset: 0x0010B484
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_GetState(int stateSlotNumber, global::System.Type type)
		{
			return global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Emit_EnsureType(global::System.Linq.Expressions.Expression.ArrayIndex(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_State, global::System.Linq.Expressions.Expression.Constant(stateSlotNumber)), type);
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x0010D2A1 File Offset: 0x0010B4A1
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_SetState(int stateSlotNumber, global::System.Linq.Expressions.Expression value)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_SetState.MakeGenericMethod(new global::System.Type[]
			{
				value.Type
			}), global::System.Linq.Expressions.Expression.Constant(stateSlotNumber), value);
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x0010D2D2 File Offset: 0x0010B4D2
		internal static global::System.Linq.Expressions.Expression Emit_Shaper_SetStatePassthrough(int stateSlotNumber, global::System.Linq.Expressions.Expression value)
		{
			return global::System.Linq.Expressions.Expression.Call(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_SetStatePassthrough.MakeGenericMethod(new global::System.Type[]
			{
				value.Type
			}), global::System.Linq.Expressions.Expression.Constant(stateSlotNumber), value);
		}

		// Token: 0x04001ADB RID: 6875
		internal static readonly global::System.Reflection.MethodInfo CodeGenEmitter_BinaryEquals = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter).GetOnlyDeclaredMethod("BinaryEquals");

		// Token: 0x04001ADC RID: 6876
		internal static readonly global::System.Reflection.MethodInfo CodeGenEmitter_CheckedConvert = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter).GetOnlyDeclaredMethod("CheckedConvert");

		// Token: 0x04001ADD RID: 6877
		internal static readonly global::System.Reflection.MethodInfo CodeGenEmitter_Compile = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter).GetDeclaredMethod("Compile", new global::System.Type[]
		{
			typeof(global::System.Linq.Expressions.Expression)
		});

		// Token: 0x04001ADE RID: 6878
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetValue = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetValue");

		// Token: 0x04001ADF RID: 6879
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetString = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetString");

		// Token: 0x04001AE0 RID: 6880
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetInt16 = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetInt16");

		// Token: 0x04001AE1 RID: 6881
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetInt32 = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetInt32");

		// Token: 0x04001AE2 RID: 6882
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetInt64 = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetInt64");

		// Token: 0x04001AE3 RID: 6883
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetBoolean = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetBoolean");

		// Token: 0x04001AE4 RID: 6884
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetDecimal = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetDecimal");

		// Token: 0x04001AE5 RID: 6885
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetFloat = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetFloat");

		// Token: 0x04001AE6 RID: 6886
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetDouble = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetDouble");

		// Token: 0x04001AE7 RID: 6887
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetDateTime = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetDateTime");

		// Token: 0x04001AE8 RID: 6888
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetGuid = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetGuid");

		// Token: 0x04001AE9 RID: 6889
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_GetByte = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("GetByte");

		// Token: 0x04001AEA RID: 6890
		internal static readonly global::System.Reflection.MethodInfo DbDataReader_IsDBNull = typeof(global::System.Data.Common.DbDataReader).GetOnlyDeclaredMethod("IsDBNull");

		// Token: 0x04001AEB RID: 6891
		internal static readonly global::System.Reflection.ConstructorInfo EntityKey_ctor_SingleKey = typeof(global::System.Data.Entity.Core.EntityKey).GetDeclaredConstructor(new global::System.Type[]
		{
			typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase),
			typeof(object)
		});

		// Token: 0x04001AEC RID: 6892
		internal static readonly global::System.Reflection.ConstructorInfo EntityKey_ctor_CompositeKey = typeof(global::System.Data.Entity.Core.EntityKey).GetDeclaredConstructor(new global::System.Type[]
		{
			typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase),
			typeof(object[])
		});

		// Token: 0x04001AED RID: 6893
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetEntityWithChangeTrackerStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetEntityWithChangeTrackerStrategyFunc");

		// Token: 0x04001AEE RID: 6894
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetEntityWithKeyStrategyStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetEntityWithKeyStrategyStrategyFunc");

		// Token: 0x04001AEF RID: 6895
		internal static readonly global::System.Reflection.MethodInfo EntityProxyTypeInfo_SetEntityWrapper = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo).GetOnlyDeclaredMethod("SetEntityWrapper");

		// Token: 0x04001AF0 RID: 6896
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetNullPropertyAccessorStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetNullPropertyAccessorStrategyFunc");

		// Token: 0x04001AF1 RID: 6897
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetPocoEntityKeyStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetPocoEntityKeyStrategyFunc");

		// Token: 0x04001AF2 RID: 6898
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetPocoPropertyAccessorStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetPocoPropertyAccessorStrategyFunc");

		// Token: 0x04001AF3 RID: 6899
		internal static readonly global::System.Reflection.MethodInfo EntityWrapperFactory_GetSnapshotChangeTrackingStrategyFunc = typeof(global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory).GetOnlyDeclaredMethod("GetSnapshotChangeTrackingStrategyFunc");

		// Token: 0x04001AF4 RID: 6900
		internal static readonly global::System.Reflection.PropertyInfo EntityWrapperFactory_NullWrapper = typeof(global::System.Data.Entity.Core.Objects.Internal.NullEntityWrapper).GetDeclaredProperty("NullWrapper");

		// Token: 0x04001AF5 RID: 6901
		internal static readonly global::System.Reflection.PropertyInfo IEntityWrapper_Entity = typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).GetDeclaredProperty("Entity");

		// Token: 0x04001AF6 RID: 6902
		internal static readonly global::System.Reflection.MethodInfo IEqualityComparerOfString_Equals = typeof(global::System.Collections.Generic.IEqualityComparer<string>).GetDeclaredMethod("Equals", new global::System.Type[]
		{
			typeof(string),
			typeof(string)
		});

		// Token: 0x04001AF7 RID: 6903
		internal static readonly global::System.Reflection.ConstructorInfo MaterializedDataRecord_ctor = typeof(global::System.Data.Entity.Core.Objects.MaterializedDataRecord).GetDeclaredConstructor(new global::System.Type[]
		{
			typeof(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace),
			typeof(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage),
			typeof(object[])
		});

		// Token: 0x04001AF8 RID: 6904
		internal static readonly global::System.Reflection.MethodInfo RecordState_GatherData = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState).GetOnlyDeclaredMethod("GatherData");

		// Token: 0x04001AF9 RID: 6905
		internal static readonly global::System.Reflection.MethodInfo RecordState_SetNullRecord = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState).GetOnlyDeclaredMethod("SetNullRecord");

		// Token: 0x04001AFA RID: 6906
		internal static readonly global::System.Reflection.MethodInfo Shaper_Discriminate = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("Discriminate");

		// Token: 0x04001AFB RID: 6907
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetPropertyValueWithErrorHandling = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetPropertyValueWithErrorHandling");

		// Token: 0x04001AFC RID: 6908
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetColumnValueWithErrorHandling = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetColumnValueWithErrorHandling");

		// Token: 0x04001AFD RID: 6909
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetHierarchyIdColumnValue = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetHierarchyIdColumnValue");

		// Token: 0x04001AFE RID: 6910
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetGeographyColumnValue = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetGeographyColumnValue");

		// Token: 0x04001AFF RID: 6911
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetGeometryColumnValue = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetGeometryColumnValue");

		// Token: 0x04001B00 RID: 6912
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetSpatialColumnValueWithErrorHandling = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetSpatialColumnValueWithErrorHandling");

		// Token: 0x04001B01 RID: 6913
		internal static readonly global::System.Reflection.MethodInfo Shaper_GetSpatialPropertyValueWithErrorHandling = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("GetSpatialPropertyValueWithErrorHandling");

		// Token: 0x04001B02 RID: 6914
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleEntity = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleEntity");

		// Token: 0x04001B03 RID: 6915
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleEntityAppendOnly = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleEntityAppendOnly");

		// Token: 0x04001B04 RID: 6916
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleEntityNoTracking = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleEntityNoTracking");

		// Token: 0x04001B05 RID: 6917
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleFullSpanCollection = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleFullSpanCollection");

		// Token: 0x04001B06 RID: 6918
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleFullSpanElement = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleFullSpanElement");

		// Token: 0x04001B07 RID: 6919
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleIEntityWithKey = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleIEntityWithKey");

		// Token: 0x04001B08 RID: 6920
		internal static readonly global::System.Reflection.MethodInfo Shaper_HandleRelationshipSpan = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("HandleRelationshipSpan");

		// Token: 0x04001B09 RID: 6921
		internal static readonly global::System.Reflection.MethodInfo Shaper_SetColumnValue = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("SetColumnValue");

		// Token: 0x04001B0A RID: 6922
		internal static readonly global::System.Reflection.MethodInfo Shaper_SetEntityRecordInfo = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("SetEntityRecordInfo");

		// Token: 0x04001B0B RID: 6923
		internal static readonly global::System.Reflection.MethodInfo Shaper_SetState = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("SetState");

		// Token: 0x04001B0C RID: 6924
		internal static readonly global::System.Reflection.MethodInfo Shaper_SetStatePassthrough = typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetOnlyDeclaredMethod("SetStatePassthrough");

		// Token: 0x04001B0D RID: 6925
		internal static readonly global::System.Linq.Expressions.Expression DBNull_Value = global::System.Linq.Expressions.Expression.Constant(global::System.DBNull.Value, typeof(object));

		// Token: 0x04001B0E RID: 6926
		internal static readonly global::System.Linq.Expressions.ParameterExpression Shaper_Parameter = global::System.Linq.Expressions.Expression.Parameter(typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper), "shaper");

		// Token: 0x04001B0F RID: 6927
		internal static readonly global::System.Linq.Expressions.Expression Shaper_Reader = global::System.Linq.Expressions.Expression.Field(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetField("Reader"));

		// Token: 0x04001B10 RID: 6928
		internal static readonly global::System.Linq.Expressions.Expression Shaper_Workspace = global::System.Linq.Expressions.Expression.Field(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetField("Workspace"));

		// Token: 0x04001B11 RID: 6929
		internal static readonly global::System.Linq.Expressions.Expression Shaper_State = global::System.Linq.Expressions.Expression.Field(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetField("State"));

		// Token: 0x04001B12 RID: 6930
		internal static readonly global::System.Linq.Expressions.Expression Shaper_Context = global::System.Linq.Expressions.Expression.Field(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Parameter, typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper).GetField("Context"));

		// Token: 0x04001B13 RID: 6931
		internal static readonly global::System.Linq.Expressions.Expression Shaper_Context_Options = global::System.Linq.Expressions.Expression.Property(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Context, typeof(global::System.Data.Entity.Core.Objects.ObjectContext).GetDeclaredProperty("ContextOptions"));

		// Token: 0x04001B14 RID: 6932
		internal static readonly global::System.Linq.Expressions.Expression Shaper_ProxyCreationEnabled = global::System.Linq.Expressions.Expression.Property(global::System.Data.Entity.Core.Common.Internal.Materialization.CodeGenEmitter.Shaper_Context_Options, typeof(global::System.Data.Entity.Core.Objects.ObjectContextOptions).GetDeclaredProperty("ProxyCreationEnabled"));
	}
}
