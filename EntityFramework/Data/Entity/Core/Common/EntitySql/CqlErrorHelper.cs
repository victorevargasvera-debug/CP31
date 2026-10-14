using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000646 RID: 1606
	internal static class CqlErrorHelper
	{
		// Token: 0x06004D4B RID: 19787 RVA: 0x00110208 File Offset: 0x0010E408
		internal static void ReportFunctionOverloadError(global::System.Data.Entity.Core.Common.EntitySql.AST.MethodExpr functionExpr, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> argTypes)
		{
			string value = "";
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(functionType.Name).Append("(");
			for (int i = 0; i < argTypes.Count; i++)
			{
				stringBuilder.Append(value);
				stringBuilder.Append((argTypes[i] != null) ? argTypes[i].EdmType.FullName : "NULL");
				value = ", ";
			}
			stringBuilder.Append(")");
			global::System.Func<object, object, object, string> func;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsAggregateFunction(functionType))
			{
				func = (global::System.Data.Entity.Core.Common.TypeHelpers.IsCanonicalFunction(functionType) ? new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.NoCanonicalAggrFunctionOverloadMatch) : new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.NoAggrFunctionOverloadMatch));
			}
			else
			{
				func = (global::System.Data.Entity.Core.Common.TypeHelpers.IsCanonicalFunction(functionType) ? new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.NoCanonicalFunctionOverloadMatch) : new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.NoFunctionOverloadMatch));
			}
			throw global::System.Data.Entity.Core.EntitySqlException.Create(functionExpr.ErrCtx.CommandText, func(functionType.NamespaceName, functionType.Name, stringBuilder.ToString()), functionExpr.ErrCtx.InputPosition, global::System.Data.Entity.Resources.Strings.CtxFunction(functionType.Name), false, null);
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x0011031B File Offset: 0x0010E51B
		internal static void ReportAliasAlreadyUsedError(string aliasName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string contextMessage)
		{
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0} {1}", new object[]
			{
				global::System.Data.Entity.Resources.Strings.AliasNameAlreadyUsed(aliasName),
				contextMessage
			}), null);
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00110346 File Offset: 0x0010E546
		internal static void ReportIncompatibleCommonType(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage leftType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage rightType)
		{
			global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportIncompatibleCommonType(errCtx, leftType, rightType, leftType, rightType);
			throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, global::System.Data.Entity.Resources.Strings.ArgumentTypesAreIncompatible(leftType.Identity, rightType.Identity), null);
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x0011036C File Offset: 0x0010E56C
		private static void ReportIncompatibleCommonType(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage rootLeftType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage rootRightType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage leftType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage rightType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			bool flag = rootLeftType == leftType;
			string errorMessage = string.Empty;
			if (leftType.EdmType.BuiltInTypeKind != rightType.EdmType.BuiltInTypeKind)
			{
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, global::System.Data.Entity.Resources.Strings.TypeKindMismatch(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(rightType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rightType)), null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = leftType.EdmType.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
					{
						goto IL_270;
					}
					global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)leftType.EdmType;
					global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType2 = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)rightType.EdmType;
					if (complexType.Members.Count != complexType2.Members.Count)
					{
						if (flag)
						{
							errorMessage = global::System.Data.Entity.Resources.Strings.InvalidRootComplexType(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(complexType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(complexType2));
						}
						else
						{
							errorMessage = global::System.Data.Entity.Resources.Strings.InvalidComplexType(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(complexType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootLeftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(complexType2), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootRightType));
						}
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					for (int i = 0; i < complexType.Members.Count; i++)
					{
						global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportIncompatibleCommonType(errCtx, rootLeftType, rootRightType, complexType.Members[i].TypeUsage, complexType2.Members[i].TypeUsage);
					}
					return;
				}
			}
			else if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
				{
					if (builtInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
					{
						goto IL_270;
					}
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)leftType.EdmType;
					global::System.Data.Entity.Core.Metadata.Edm.RowType rowType2 = (global::System.Data.Entity.Core.Metadata.Edm.RowType)rightType.EdmType;
					if (rowType.Members.Count != rowType2.Members.Count)
					{
						if (flag)
						{
							errorMessage = global::System.Data.Entity.Resources.Strings.InvalidRootRowType(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rowType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rowType2));
						}
						else
						{
							errorMessage = global::System.Data.Entity.Resources.Strings.InvalidRowType(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rowType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootLeftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rowType2), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootRightType));
						}
						throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
					}
					for (int j = 0; j < rowType.Members.Count; j++)
					{
						global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportIncompatibleCommonType(errCtx, rootLeftType, rootRightType, rowType.Members[j].TypeUsage, rowType2.Members[j].TypeUsage);
					}
					return;
				}
			}
			else
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(leftType, rightType, out typeUsage))
				{
					if (flag)
					{
						errorMessage = global::System.Data.Entity.Resources.Strings.InvalidEntityRootTypeArgument(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rightType));
					}
					else
					{
						errorMessage = global::System.Data.Entity.Resources.Strings.InvalidEntityTypeArgument(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootLeftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rightType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootRightType));
					}
					throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
				}
				return;
			}
			global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.ReportIncompatibleCommonType(errCtx, rootLeftType, rootRightType, global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(leftType), global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(rightType));
			return;
			IL_270:
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonType(leftType, rightType, out typeUsage))
			{
				if (flag)
				{
					errorMessage = global::System.Data.Entity.Resources.Strings.InvalidPlaceholderRootTypeArgument(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(rightType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rightType));
				}
				else
				{
					errorMessage = global::System.Data.Entity.Resources.Strings.InvalidPlaceholderTypeArgument(global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(leftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootLeftType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(rightType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rightType), global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(rootRightType));
				}
				throw global::System.Data.Entity.Core.EntitySqlException.Create(errCtx, errorMessage, null);
			}
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x0011064F File Offset: 0x0010E84F
		private static string GetReadableTypeName(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeName(type.EdmType);
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0011065C File Offset: 0x0010E85C
		private static string GetReadableTypeName(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			if (type.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType || type.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType || type.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
			{
				return type.Name;
			}
			return type.FullName;
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00110688 File Offset: 0x0010E888
		private static string GetReadableTypeKind(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Common.EntitySql.CqlErrorHelper.GetReadableTypeKind(type.EdmType);
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00110698 File Offset: 0x0010E898
		private static string GetReadableTypeKind(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			string str = string.Empty;
			global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind = type.BuiltInTypeKind;
			if (builtInTypeKind <= global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedCollection;
					goto IL_75;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedComplex;
					goto IL_75;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedEntity;
					goto IL_75;
				}
			}
			else
			{
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedPrimitive;
					goto IL_75;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedReference;
					goto IL_75;
				}
				if (builtInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					str = global::System.Data.Entity.Resources.Strings.LocalizedRow;
					goto IL_75;
				}
			}
			str = type.BuiltInTypeKind.ToString();
			IL_75:
			return str + " " + global::System.Data.Entity.Resources.Strings.LocalizedType;
		}
	}
}
