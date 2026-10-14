using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal
{
	// Token: 0x020006FB RID: 1787
	internal static class ArgumentValidation
	{
		// Token: 0x06005448 RID: 21576 RVA: 0x0012DCF9 File Offset: 0x0012BEF9
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<TElement> NewReadOnlyCollection<TElement>(global::System.Collections.Generic.IList<TElement> list)
		{
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<TElement>(list);
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x0012DD01 File Offset: 0x0012BF01
		internal static void RequirePolymorphicType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPolymorphicType(type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_PolymorphicTypeRequired(type.ToString()), "type");
			}
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x0012DD21 File Offset: 0x0012BF21
		internal static void RequireCompatibleType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage requiredResultType, string argumentName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(expression, requiredResultType, argumentName, -1);
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x0012DD2C File Offset: 0x0012BF2C
		private static void RequireCompatibleType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage requiredResultType, string argumentName, int argumentIndex)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(expression.ResultType, requiredResultType))
			{
				if (argumentIndex != -1)
				{
					argumentName = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, argumentIndex);
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_ExpressionLink_TypeMismatch(expression.ResultType.ToString(), requiredResultType.ToString()), argumentName);
			}
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0012DD66 File Offset: 0x0012BF66
		internal static void RequireCompatibleType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind requiredResultType, string argumentName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(expression, requiredResultType, argumentName, -1);
		}

		// Token: 0x0600544D RID: 21581 RVA: 0x0012DD74 File Offset: 0x0012BF74
		private static void RequireCompatibleType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind requiredResultType, string argumentName, int index)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			bool flag = global::System.Data.Entity.Core.Common.TypeHelpers.TryGetPrimitiveTypeKind(expression.ResultType, out primitiveTypeKind);
			if (!flag || primitiveTypeKind != requiredResultType)
			{
				if (index != -1)
				{
					argumentName = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, index);
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_ExpressionLink_TypeMismatch(flag ? global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), primitiveTypeKind) : expression.ResultType.ToString(), global::System.Enum.GetName(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind), requiredResultType)), argumentName);
			}
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0012DDEC File Offset: 0x0012BFEC
		private static void RequireCompatibleType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression from, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember end, bool allowAllRelationshipsInSameTypeHierarchy)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = end.TypeUsage;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage))
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceTypeUsage(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(typeUsage));
			}
			if (allowAllRelationshipsInSameTypeHierarchy)
			{
				if (global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(typeUsage, from.ResultType) == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelNav_WrongSourceType(typeUsage.ToString()), "from");
				}
			}
			else if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqualOrPromotableTo(from.ResultType.EdmType, typeUsage.EdmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_RelNav_WrongSourceType(typeUsage.ToString()), "from");
			}
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x0012DE69 File Offset: 0x0012C069
		internal static void RequireCollectionArgument<TExpressionType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(argument.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Unary_CollectionRequired(typeof(TExpressionType).Name), "argument");
			}
		}

		// Token: 0x06005450 RID: 21584 RVA: 0x0012DE98 File Offset: 0x0012C098
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage RequireCollectionArguments<TExpressionType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(left.ResultType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(right.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Binary_CollectionsRequired(typeof(TExpressionType).Name));
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(left.ResultType, right.ResultType);
			if (commonTypeUsage == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Binary_CollectionsRequired(typeof(TExpressionType).Name));
			}
			return commonTypeUsage;
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x0012DF0C File Offset: 0x0012C10C
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage RequireComparableCollectionArguments<TExpressionType>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArguments<TExpressionType>(left, right);
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(left.ResultType)))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_InvalidTypeForSetOperation(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(left.ResultType).Identity, typeof(TExpressionType).Name), "left");
			}
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsSetComparableOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(right.ResultType)))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_InvalidTypeForSetOperation(global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(right.ResultType).Identity, typeof(TExpressionType).Name), "right");
			}
			return result;
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x0012DFA2 File Offset: 0x0012C1A2
		private static global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<TElementIn, TElementOut, TResult> CreateValidator<TElementIn, TElementOut, TResult>(global::System.Collections.Generic.IEnumerable<TElementIn> argument, string argumentName, global::System.Func<TElementIn, int, TElementOut> convertElement, global::System.Func<global::System.Collections.Generic.List<TElementOut>, TResult> createResult)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<TElementIn, TElementOut, TResult>(argument, argumentName)
			{
				ConvertElement = convertElement,
				CreateResult = createResult
			};
		}

		// Token: 0x06005453 RID: 21587 RVA: 0x0012DFB9 File Offset: 0x0012C1B9
		internal static global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList CreateExpressionList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, string argumentName, global::System.Action<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, int> validationCallback)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(arguments, argumentName, false, validationCallback);
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0012DFC4 File Offset: 0x0012C1C4
		private static global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList CreateExpressionList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, string argumentName, bool allowEmpty, global::System.Action<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, int> validationCallback)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList>(arguments, argumentName, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				if (validationCallback != null)
				{
					validationCallback(exp, idx);
				}
				return exp;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expList) => new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(expList));
			enumerableValidator.AllowEmpty = allowEmpty;
			return enumerableValidator.Validate();
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x0012E01C File Offset: 0x0012C21C
		private static global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList CreateExpressionList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, string argumentName, int expectedElementCount, global::System.Action<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, int> validationCallback)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList>(arguments, argumentName, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				if (validationCallback != null)
				{
					validationCallback(exp, idx);
				}
				return exp;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expList) => new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(expList));
			enumerableValidator.ExpectedElementCount = expectedElementCount;
			enumerableValidator.AllowEmpty = false;
			return enumerableValidator.Validate();
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x0012E07B File Offset: 0x0012C27B
		private static global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] GetExpectedParameters(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return (from p in function.Parameters
			where p.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In || p.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut
			select p).ToArray<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x0012E0AC File Offset: 0x0012C2AC
		internal static global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList ValidateFunctionAggregate(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> args)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckFunction(function);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsAggregateFunction(function) || function.ReturnParameter == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Aggregate_InvalidFunction, "function");
			}
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] expectedParams = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.GetExpectedParameters(function);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(args, "argument", expectedParams.Length, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = expectedParams[idx].TypeUsage;
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = null;
				if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(typeUsage, out typeUsage2))
				{
					typeUsage = typeUsage2;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, typeUsage, "argument");
			});
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x0012E110 File Offset: 0x0012C310
		internal static void ValidateSortClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key)
		{
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidSortOpKeyType(key.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Sort_OrderComparable, "key");
			}
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x0012E12F File Offset: 0x0012C32F
		internal static void ValidateSortClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key, string collation)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortClause(key);
			global::System.Data.Entity.Utilities.Check.NotEmpty(collation, "collation");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(key.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Sort_NonStringCollationInvalid, "collation");
			}
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x0012E164 File Offset: 0x0012C364
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> ValidateLambda(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>>(variables, "variables", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varExp, int idx)
			{
				if (varExp == null)
				{
					throw new global::System.ArgumentNullException(global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex("variables", idx));
				}
				return varExp;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> varList) => new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>(varList));
			enumerableValidator.AllowEmpty = true;
			enumerableValidator.GetName = ((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varDef, int idx) => varDef.VariableName);
			return enumerableValidator.Validate();
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x0012E1EB File Offset: 0x0012C3EB
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateQuantifier(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(predicate, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "predicate");
			return predicate.ResultType;
		}

		// Token: 0x0600545C RID: 21596 RVA: 0x0012E200 File Offset: 0x0012C400
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateApply(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			if (input.VariableName.Equals(apply.VariableName, global::System.StringComparison.Ordinal))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Apply_DuplicateVariableNames);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateCollectionOfRowResultType(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(input.VariableName, input.VariableType),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(apply.VariableName, apply.VariableType)
			});
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x0012E264 File Offset: 0x0012C464
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> ValidateCrossJoin(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> enumerator = inputs.GetEnumerator();
			int num = 0;
			while (enumerator.MoveNext())
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = enumerator.Current;
				string paramName = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex("inputs", num);
				if (dbExpressionBinding == null)
				{
					throw new global::System.ArgumentNullException(paramName);
				}
				int num2 = -1;
				if (dictionary.TryGetValue(dbExpressionBinding.VariableName, out num2))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_CrossJoin_DuplicateVariableNames(num2, num, dbExpressionBinding.VariableName));
				}
				list.Add(dbExpressionBinding);
				dictionary.Add(dbExpressionBinding.VariableName, num);
				list2.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(dbExpressionBinding.VariableName, dbExpressionBinding.VariableType));
				num++;
			}
			if (list.Count < 2)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_CrossJoin_AtLeastTwoInputs, "inputs");
			}
			resultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateCollectionOfRowResultType(list2);
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(list);
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x0012E350 File Offset: 0x0012C550
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateJoin(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition)
		{
			if (left.VariableName.Equals(right.VariableName, global::System.StringComparison.Ordinal))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Join_DuplicateVariableNames);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(joinCondition, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "joinCondition");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateCollectionOfRowResultType(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>(2)
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(left.VariableName, left.VariableType),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(right.VariableName, right.VariableType)
			});
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0012E3C1 File Offset: 0x0012C5C1
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateFilter(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(predicate, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "predicate");
			return input.Expression.ResultType;
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0012E3DC File Offset: 0x0012C5DC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateGroupBy(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> keys, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> aggregates, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validKeys, out global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> validAggregates)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columns = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			global::System.Collections.Generic.HashSet<string> keyNames = new global::System.Collections.Generic.HashSet<string>();
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList>(keys, "keys", delegate(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyInfo, int index)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckNamed<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyInfo, "keys", index);
				if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidGroupKeyType(keyInfo.Value.ResultType))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GroupBy_KeyNotEqualityComparable(keyInfo.Key));
				}
				keyNames.Add(keyInfo.Key);
				columns.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(keyInfo.Key, keyInfo.Value.ResultType));
				return keyInfo.Value;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expList) => new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(expList));
			enumerableValidator.AllowEmpty = true;
			enumerableValidator.GetName = ((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyInfo, int idx) => keyInfo.Key);
			validKeys = enumerableValidator.Validate();
			bool hasGroupAggregate = false;
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> enumerableValidator2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>(aggregates, "aggregates", delegate(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggInfo, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckNamed<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(aggInfo, "aggregates", idx);
				if (keyNames.Contains(aggInfo.Key))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GroupBy_AggregateColumnExistsAsGroupColumn(aggInfo.Key));
				}
				if (aggInfo.Value is global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate)
				{
					if (hasGroupAggregate)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GroupBy_MoreThanOneGroupAggregate);
					}
					hasGroupAggregate = true;
				}
				columns.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(aggInfo.Key, aggInfo.Value.ResultType));
				return aggInfo.Value;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggList) => global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.NewReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(aggList));
			enumerableValidator2.AllowEmpty = true;
			enumerableValidator2.GetName = ((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggInfo, int idx) => aggInfo.Key);
			validAggregates = enumerableValidator2.Validate();
			if (validKeys.Count == 0 && validAggregates.Count == 0)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GroupBy_AtLeastOneKeyOrAggregate);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateCollectionOfRowResultType(columns);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0012E50C File Offset: 0x0012C70C
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> ValidateSortArguments(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause, global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>>(sortOrder, "sortOrder", (global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause key, int idx) => key, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> keyList) => global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.NewReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(keyList));
			enumerableValidator.AllowEmpty = false;
			return enumerableValidator.Validate();
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0012E56E File Offset: 0x0012C76E
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> ValidateSort(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortArguments(sortOrder);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0012E578 File Offset: 0x0012C778
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateConstant(global::System.Type type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.TryGetPrimitiveTypeKind(type, out primitiveTypeKind))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Constant_InvalidType, "type");
			}
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetLiteralTypeUsage(primitiveTypeKind);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0012E5A5 File Offset: 0x0012C7A5
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateConstant(object value)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateConstant(value.GetType());
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x0012E5B4 File Offset: 0x0012C7B4
		internal static void ValidateConstant(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage constantType, object value)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(constantType, "constantType");
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EnumType>(constantType, out enumType))
			{
				global::System.Type clrEquivalentType = enumType.UnderlyingType.ClrEquivalentType;
				if (clrEquivalentType != value.GetType() && (!value.GetType().IsEnum() || !global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ClrEdmEnumTypesMatch(enumType, value.GetType())))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType(value.GetType().Name, enumType.Name, clrEquivalentType.Name), "value");
				}
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
				if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(constantType, out primitiveType))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Constant_InvalidConstantType(constantType.ToString()), "constantType");
				}
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
				if ((!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.TryGetPrimitiveTypeKind(value.GetType(), out primitiveTypeKind) || primitiveType.PrimitiveTypeKind != primitiveTypeKind) && (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeographicType(primitiveType) || primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography) && (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsGeometricType(primitiveType) || primitiveTypeKind != global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Constant_InvalidValueForType(constantType.ToString()), "value");
				}
			}
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x0012E6A0 File Offset: 0x0012C8A0
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateCreateRef(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression keyConstructor)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckEntitySet(entitySet, "entitySet");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(entityType, "entityType");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(entitySet.ElementType, entityType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Ref_PolymorphicArgRequired);
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entityType.KeyMembers;
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>>(keyValues, "keyValues", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression valueExp, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(valueExp, keyMembers[idx].TypeUsage, "keyValues", idx);
				return new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyMembers[idx].Name, valueExp);
			}, (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> columnList) => columnList);
			enumerableValidator.ExpectedElementCount = keyMembers.Count;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> columnValues = enumerableValidator.Validate();
			keyConstructor = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(columnValues);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateReferenceResultType(entityType);
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x0012E74C File Offset: 0x0012C94C
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateRefFromKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression keyValues, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckEntitySet(entitySet, "entitySet");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(entityType);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(entitySet.ElementType, entityType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Ref_PolymorphicArgRequired);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage requiredResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateResultType(global::System.Data.Entity.Core.Common.TypeHelpers.CreateKeyRowType(entitySet.ElementType));
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(keyValues, requiredResultType, "keyValues");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateReferenceResultType(entityType);
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x0012E7A8 File Offset: 0x0012C9A8
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNavigate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom, global::System.Data.Entity.Core.Metadata.Edm.RelationshipType type, string fromEndName, string toEndName, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type);
			if (!type.RelationshipEndMembers.TryGetValue(fromEndName, false, out fromEnd))
			{
				throw new global::System.ArgumentOutOfRangeException(fromEndName, global::System.Data.Entity.Resources.Strings.Cqt_Factory_NoSuchRelationEnd);
			}
			if (!type.RelationshipEndMembers.TryGetValue(toEndName, false, out toEnd))
			{
				throw new global::System.ArgumentOutOfRangeException(toEndName, global::System.Data.Entity.Resources.Strings.Cqt_Factory_NoSuchRelationEnd);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(navigateFrom, fromEnd, false);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateResultType(toEnd);
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x0012E808 File Offset: 0x0012CA08
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNavigate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd, out global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType, bool allowAllRelationshipsInSameTypeHierarchy)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckMember(fromEnd, "fromEnd");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckMember(toEnd, "toEnd");
			relType = (fromEnd.DeclaringType as global::System.Data.Entity.Core.Metadata.Edm.RelationshipType);
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(relType);
			if (!relType.Equals(toEnd.DeclaringType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Factory_IncompatibleRelationEnds, "toEnd");
			}
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(navigateFrom, fromEnd, allowAllRelationshipsInSameTypeHierarchy);
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateResultType(toEnd);
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x0012E86D File Offset: 0x0012CA6D
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateElement(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArgument<global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression>(argument);
			return global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(argument.ResultType).TypeUsage;
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x0012E888 File Offset: 0x0012CA88
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateCase(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> whenExpressions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> thenExpressions, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression elseExpression, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validWhens, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validThens)
		{
			validWhens = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(whenExpressions, "whenExpressions", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, "whenExpressions", idx);
			});
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonResultType = null;
			validThens = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(thenExpressions, "thenExpressions", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				if (commonResultType == null)
				{
					commonResultType = exp.ResultType;
					return;
				}
				commonResultType = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(exp.ResultType, commonResultType);
				if (commonResultType == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Case_InvalidResultType);
				}
			});
			commonResultType = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(elseExpression.ResultType, commonResultType);
			if (commonResultType == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Case_InvalidResultType);
			}
			if (validWhens.Count != validThens.Count)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Case_WhensMustEqualThens);
			}
			return commonResultType;
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x0012E934 File Offset: 0x0012CB34
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validArgs)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckFunction(function);
			if (!function.IsComposableAttribute)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Function_NonComposableInExpression, "function");
			}
			if (!string.IsNullOrEmpty(function.CommandTextAttribute) && !function.HasUserDefinedBody)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Function_CommandTextInExpression, "function");
			}
			if (function.ReturnParameter == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Function_VoidResultInvalid, "function");
			}
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] expectedParams = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.GetExpectedParameters(function);
			validArgs = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(arguments, "arguments", expectedParams.Length, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, expectedParams[idx].TypeUsage, "arguments", idx);
			});
			return function.ReturnParameter.TypeUsage;
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x0012E9DC File Offset: 0x0012CBDC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateInvoke(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validArguments)
		{
			validArguments = null;
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList>(arguments, "arguments", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, lambda.Variables[idx].ResultType, "arguments", idx);
				return exp;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expList) => new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(expList));
			enumerableValidator.ExpectedElementCount = lambda.Variables.Count;
			validArguments = enumerableValidator.Validate();
			return lambda.Body.ResultType;
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x0012EA5E File Offset: 0x0012CC5E
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNewEmptyCollection(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionType, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validElements)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(collectionType, "collectionType");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(collectionType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_NewInstance_CollectionTypeRequired, "collectionType");
			}
			validElements = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
			return collectionType;
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x0012EA94 File Offset: 0x0012CC94
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNewRow(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> columnValues, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validElements)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columnTypes = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>();
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.EnumerableValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList> enumerableValidator = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateValidator<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList>(columnValues, "columnValues", delegate(global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> columnValue, int idx)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckNamed<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(columnValue, "columnValues", idx);
				columnTypes.Add(new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(columnValue.Key, columnValue.Value.ResultType));
				return columnValue.Value;
			}, (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> expList) => new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(expList));
			enumerableValidator.GetName = ((global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> columnValue, int idx) => columnValue.Key);
			validElements = enumerableValidator.Validate();
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateResultType(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(columnTypes));
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x0012EB28 File Offset: 0x0012CD28
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNew(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validArguments)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(instanceType, "instanceType");
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(instanceType, out collectionType) && collectionType != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType = collectionType.TypeUsage;
				validArguments = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(arguments, "arguments", true, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, elementType, "arguments", idx);
				});
			}
			else
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> expectedTypes = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.GetStructuralMemberTypes(instanceType);
				int pos = 0;
				validArguments = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(arguments, "arguments", expectedTypes.Count, delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> expectedTypes = expectedTypes;
					int pos = pos;
					pos++;
					global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(exp, expectedTypes[pos], "arguments", idx);
				});
			}
			return instanceType;
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x0012EBBC File Offset: 0x0012CDBC
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> GetStructuralMemberTypes(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = instanceType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType;
			if (structuralType == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_NewInstance_StructuralTypeRequired, "instanceType");
			}
			if (structuralType.Abstract)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_NewInstance_CannotInstantiateAbstractType(instanceType.ToString()), "instanceType");
			}
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(structuralType);
			if (allStructuralMembers == null || allStructuralMembers.Count < 1)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_NewInstance_CannotInstantiateMemberlessType(instanceType.ToString()), "instanceType");
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(allStructuralMembers.Count);
			for (int i = 0; i < allStructuralMembers.Count; i++)
			{
				list.Add(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(allStructuralMembers[i]));
			}
			return list;
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x0012EC60 File Offset: 0x0012CE60
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateNewEntityWithRelationships(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> attributeValues, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relationships, out global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList validArguments, out global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> validRelatedRefs)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateResultType(entityType);
			typeUsage = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNew(typeUsage, attributeValues, out validArguments);
			if (relationships.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(relationships.Count);
				for (int i = 0; i < relationships.Count; i++)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef dbRelatedEntityRef = relationships[i];
					global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase elementType = global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(dbRelatedEntityRef.SourceEnd.TypeUsage).ElementType;
					if (!entityType.EdmEquals(elementType) && !entityType.IsSubtypeOf(elementType))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid, global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex("relationships", i));
					}
					list.Add(dbRelatedEntityRef);
				}
				validRelatedRefs = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(list);
			}
			else
			{
				validRelatedRefs = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef>(new global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef[0]);
			}
			return typeUsage;
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x0012ED10 File Offset: 0x0012CF10
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ValidateProperty(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, string propertyName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmMember foundMember)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(instance.ResultType, out structuralType) && structuralType.Members.TryGetValue(propertyName, ignoreCase, out foundMember) && foundMember != null && (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipEndMember(foundMember) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty(foundMember) || global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty(foundMember)))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(foundMember);
			}
			throw new global::System.ArgumentOutOfRangeException("propertyName", global::System.Data.Entity.Resources.Strings.NoSuchProperty(propertyName, instance.ResultType.ToString()));
		}

		// Token: 0x06005474 RID: 21620 RVA: 0x0012ED80 File Offset: 0x0012CF80
		private static void CheckNamed<T>(global::System.Collections.Generic.KeyValuePair<string, T> element, string argumentName, int index)
		{
			if (string.IsNullOrEmpty(element.Key))
			{
				if (index != -1)
				{
					argumentName = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, index);
				}
				throw new global::System.ArgumentNullException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.Key", new object[]
				{
					argumentName
				}));
			}
			if (element.Value == null)
			{
				if (index != -1)
				{
					argumentName = global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex(argumentName, index);
				}
				throw new global::System.ArgumentNullException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.Value", new object[]
				{
					argumentName
				}));
			}
		}

		// Token: 0x06005475 RID: 21621 RVA: 0x0012EE01 File Offset: 0x0012D001
		private static void CheckReadOnly(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item, string varName)
		{
			if (!item.IsReadOnly)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_MetadataNotReadOnly, varName);
			}
		}

		// Token: 0x06005476 RID: 21622 RVA: 0x0012EE17 File Offset: 0x0012D017
		private static void CheckReadOnly(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage item, string varName)
		{
			if (!item.IsReadOnly)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_MetadataNotReadOnly, varName);
			}
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x0012EE2D File Offset: 0x0012D02D
		private static void CheckReadOnly(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase item, string varName)
		{
			if (!item.IsReadOnly)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_MetadataNotReadOnly, varName);
			}
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x0012EE43 File Offset: 0x0012D043
		private static void CheckType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type, "type");
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x0012EE50 File Offset: 0x0012D050
		private static void CheckType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type, string argumentName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(type, argumentName);
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x0012EE59 File Offset: 0x0012D059
		internal static void CheckType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type, "type");
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0012EE66 File Offset: 0x0012D066
		internal static void CheckType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string varName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(type, varName);
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_TypeUsageIncorrectSpace, "type");
			}
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0012EE87 File Offset: 0x0012D087
		internal static void CheckMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember memberMeta, string varName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(memberMeta.DeclaringType, varName);
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(memberMeta.TypeUsage) || !global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(memberMeta.DeclaringType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EdmMemberIncorrectSpace, varName);
			}
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0012EEBB File Offset: 0x0012D0BB
		private static void CheckParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter paramMeta, string varName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(paramMeta.DeclaringFunction, varName);
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(paramMeta.TypeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_FunctionParameterIncorrectSpace, varName);
			}
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x0012EEE4 File Offset: 0x0012D0E4
		private static void CheckFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(function, "function");
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(function))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_FunctionIncorrectSpace, "function");
			}
			if (function.IsComposableAttribute && function.ReturnParameter == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_FunctionReturnParameterNull, "function");
			}
			if (function.ReturnParameter != null && !global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(function.ReturnParameter.TypeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_FunctionParameterIncorrectSpace, "function.ReturnParameter");
			}
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> parameters = function.Parameters;
			for (int i = 0; i < parameters.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckParameter(parameters[i], global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatIndex("function.Parameters", i));
			}
		}

		// Token: 0x0600547F RID: 21631 RVA: 0x0012EF90 File Offset: 0x0012D190
		internal static void CheckEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, string varName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckReadOnly(entitySet, varName);
			if (entitySet.EntityContainer == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EntitySetEntityContainerNull, varName);
			}
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(entitySet.EntityContainer))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EntitySetIncorrectSpace, varName);
			}
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(entitySet.ElementType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Metadata_EntitySetIncorrectSpace, varName);
			}
		}

		// Token: 0x06005480 RID: 21632 RVA: 0x0012EFEA File Offset: 0x0012D1EA
		private static bool CheckDataSpace(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(type.EdmType);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x0012EFF8 File Offset: 0x0012D1F8
		private static bool CheckDataSpace(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType == item.BuiltInTypeKind || (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction == item.BuiltInTypeKind && global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace == item.DataSpace))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRowType(item))
			{
				using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = ((global::System.Data.Entity.Core.Metadata.Edm.RowType)item).Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(enumerator.Current.TypeUsage))
						{
							return false;
						}
					}
				}
				return true;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(item))
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)item).TypeUsage);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(item))
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckDataSpace(((global::System.Data.Entity.Core.Metadata.Edm.RefType)item).ElementType);
			}
			return item.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace || item.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x0012F0CC File Offset: 0x0012D2CC
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateCollectionOfRowResultType(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>> columns)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateRowType(columns))));
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x0012F0E3 File Offset: 0x0012D2E3
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateResultType(global::System.Data.Entity.Core.Metadata.Edm.EdmType resultType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(resultType);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x0012F0EC File Offset: 0x0012D2EC
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateResultType(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember end)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = end.TypeUsage;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage))
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceTypeUsage(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(typeUsage));
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many == end.RelationshipMultiplicity)
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(typeUsage);
			}
			return typeUsage;
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x0012F125 File Offset: 0x0012D325
		internal static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateReferenceResultType(global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase referencedEntityType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateReferenceType(referencedEntityType));
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x0012F132 File Offset: 0x0012D332
		private static bool TryGetPrimitiveTypeKind(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.TryGetPrimitiveTypeKind(clrType, out primitiveTypeKind);
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x0012F13C File Offset: 0x0012D33C
		private static bool ClrEdmEnumTypesMatch(global::System.Data.Entity.Core.Metadata.Edm.EnumType edmEnumType, global::System.Type clrEnumType)
		{
			if (clrEnumType.Name != edmEnumType.Name || clrEnumType.GetEnumNames().Length < edmEnumType.Members.Count)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			if (!global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.TryGetPrimitiveTypeKind(clrEnumType.GetEnumUnderlyingType(), out primitiveTypeKind) || primitiveTypeKind != edmEnumType.UnderlyingType.PrimitiveTypeKind)
			{
				return false;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember in edmEnumType.Members)
			{
				if (!clrEnumType.GetEnumNames().Contains(enumMember.Name) || !enumMember.Value.Equals(global::System.Convert.ChangeType(global::System.Enum.Parse(clrEnumType, enumMember.Name), clrEnumType.GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture)))
				{
					return false;
				}
			}
			return true;
		}
	}
}
