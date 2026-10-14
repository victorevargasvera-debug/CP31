using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder
{
	// Token: 0x020006F7 RID: 1783
	public static class DbExpressionBuilder
	{
		// Token: 0x060052FA RID: 21242 RVA: 0x00129A49 File Offset: 0x00127C49
		public static global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> As(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value, string alias)
		{
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(alias, value);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x00129A52 File Offset: 0x00127C52
		public static global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> As(this global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate value, string alias)
		{
			return new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>(alias, value);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00129A5B File Offset: 0x00127C5B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding Bind(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(input, "input");
			return input.BindAs(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._bindingAliases.Next());
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x00129A7C File Offset: 0x00127C7C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding BindAs(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, string varName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(varName, "varName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(varName, "varName");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = null;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(input.ResultType, out type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Binding_CollectionRequired, "input");
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(type, varName);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding(input, varRef);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00129AE0 File Offset: 0x00127CE0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding GroupBind(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(input, "input");
			string text = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._bindingAliases.Next();
			return input.GroupBindAs(text, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Group{0}", new object[]
			{
				text
			}));
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00129B24 File Offset: 0x00127D24
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding GroupBindAs(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, string varName, string groupVarName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(varName, "varName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(varName, "varName");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(groupVarName, "groupVarName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(groupVarName, "groupVarName");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = null;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(input.ResultType, out type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GroupBinding_CollectionRequired, "input");
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression inputRef = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(type, varName);
			global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression groupRef = new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(type, groupVarName);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding(input, inputRef, groupRef);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00129BA6 File Offset: 0x00127DA6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate Aggregate(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateFunctionAggregate(function, argument, false);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00129BC8 File Offset: 0x00127DC8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate AggregateDistinct(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateFunctionAggregate(function, argument, true);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x00129BEC File Offset: 0x00127DEC
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate CreateFunctionAggregate(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, bool isDistinct)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateFunctionAggregate(function, new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				argument
			});
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate(function.ReturnParameter.TypeUsage, arguments, function, isDistinct);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00129C1D File Offset: 0x00127E1D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate Aggregate(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(arguments, "argument");
			if (!arguments.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>())
			{
				throw new global::System.ArgumentNullException("arguments");
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateFunctionAggregate(function, arguments, false);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x00129C52 File Offset: 0x00127E52
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate AggregateDistinct(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(arguments, "argument");
			if (!arguments.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>())
			{
				throw new global::System.ArgumentNullException("arguments");
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateFunctionAggregate(function, arguments, true);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00129C88 File Offset: 0x00127E88
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate CreateFunctionAggregate(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments, bool isDistinct)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateFunctionAggregate(function, arguments);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionAggregate(function.ReturnParameter.TypeUsage, arguments2, function, isDistinct);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00129CB0 File Offset: 0x00127EB0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate GroupAggregate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				argument
			});
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(argument.ResultType), arguments);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x00129CEA File Offset: 0x00127EEA
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Lambda(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(body, "body");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression>>(variables, "variables");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateLambda(body, variables);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00129D0B File Offset: 0x00127F0B
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda Lambda(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body, params global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[] variables)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(body, "body");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression[]>(variables, "variables");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateLambda(body, variables);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00129D2C File Offset: 0x00127F2C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbLambda CreateLambda(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression body, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression> variables)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbLambda(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateLambda(variables), body);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00129D3A File Offset: 0x00127F3A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause ToSortClause(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(key, "key");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortClause(key);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause(key, true, string.Empty);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x00129D5A File Offset: 0x00127F5A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause ToSortClauseDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(key, "key");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortClause(key);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause(key, false, string.Empty);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00129D7A File Offset: 0x00127F7A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause ToSortClause(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(key, "key");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(collation, "collation");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortClause(key, collation);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause(key, true, collation);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x00129DA3 File Offset: 0x00127FA3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause ToSortClauseDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(key, "key");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(collation, "collation");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortClause(key, collation);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause(key, false, collation);
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x00129DCC File Offset: 0x00127FCC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression All(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(predicate, "predicate");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateQuantifier(predicate);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.All, booleanResultType, input, predicate);
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00129E04 File Offset: 0x00128004
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression Any(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(predicate, "predicate");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage booleanResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateQuantifier(predicate);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Any, booleanResultType, input, predicate);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00129E3C File Offset: 0x0012803C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression CrossApply(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(apply, "apply");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateApply(input, apply);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultRowCollectionTypeUsage = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApplyResultType(input, apply);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply, resultRowCollectionTypeUsage, input, apply);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00129E7C File Offset: 0x0012807C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression OuterApply(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(apply, "apply");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateApply(input, apply);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultRowCollectionTypeUsage = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApplyResultType(input, apply);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply, resultRowCollectionTypeUsage, input, apply);
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x00129EBA File Offset: 0x001280BA
		private static void ValidateApply(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			if (input.VariableName.Equals(apply.VariableName, global::System.StringComparison.Ordinal))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Apply_DuplicateVariableNames);
			}
		}

		// Token: 0x06005313 RID: 21267 RVA: 0x00129EDB File Offset: 0x001280DB
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateApplyResultType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateCollectionOfRowResultType(new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>>
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(input.VariableName, input.VariableType),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(apply.VariableName, apply.VariableType)
			});
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x00129F18 File Offset: 0x00128118
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression CrossJoin(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>>(inputs, "inputs");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding> inputs2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateCrossJoin(inputs, out collectionOfRowResultType);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbCrossJoinExpression(collectionOfRowResultType, inputs2);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x00129F44 File Offset: 0x00128144
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression InnerJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateJoin(left, right, joinCondition);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin, collectionOfRowResultType, left, right, joinCondition);
		}

		// Token: 0x06005316 RID: 21270 RVA: 0x00129F8C File Offset: 0x0012818C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateJoin(left, right, joinCondition);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin, collectionOfRowResultType, left, right, joinCondition);
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00129FD4 File Offset: 0x001281D4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression FullOuterJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionOfRowResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateJoin(left, right, joinCondition);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin, collectionOfRowResultType, left, right, joinCondition);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x0012A019 File Offset: 0x00128219
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression Filter(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(predicate, "predicate");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateFilter(input, predicate), input, predicate);
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x0012A044 File Offset: 0x00128244
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression GroupBy(this global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding input, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> keys, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>> aggregates)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbGroupExpressionBinding>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>>(keys, "keys");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate>>>(aggregates, "aggregates");
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList groupKeys;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate> aggregates2;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbGroupByExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateGroupBy(keys, aggregates, out groupKeys, out aggregates2), input, groupKeys, aggregates2);
		}

		// Token: 0x0600531A RID: 21274 RVA: 0x0012A088 File Offset: 0x00128288
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression Project(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(projection, "projection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateCollectionResultType(projection.ResultType), input, projection);
		}

		// Token: 0x0600531B RID: 21275 RVA: 0x0012A0B4 File Offset: 0x001282B4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression Skip(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>>(sortOrder, "sortOrder");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(count, "count");
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSortArguments(sortOrder);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(count.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Skip_IntegerRequired, "count");
			}
			if (count.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && count.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Skip_ConstantOrParameterRefRequired, "count");
			}
			if (global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsConstantNegativeInteger(count))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Skip_NonNegativeCountRequired, "count");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression(input.Expression.ResultType, input, sortOrder2, count);
		}

		// Token: 0x0600531C RID: 21276 RVA: 0x0012A158 File Offset: 0x00128358
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression Sort(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding>(input, "input");
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> sortOrder2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateSort(sortOrder);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression(input.Expression.ResultType, input, sortOrder2);
		}

		// Token: 0x0600531D RID: 21277 RVA: 0x0012A18A File Offset: 0x0012838A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression Null(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage nullType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(nullType, "nullType");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(nullType, "nullType");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression(nullType);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x0012A1A9 File Offset: 0x001283A9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression True
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._boolTrue;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600531F RID: 21279 RVA: 0x0012A1B0 File Offset: 0x001283B0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression False
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._boolFalse;
			}
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x0012A1B7 File Offset: 0x001283B7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression Constant(object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateConstant(value), value);
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x0012A1D1 File Offset: 0x001283D1
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression Constant(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage constantType, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(constantType, "constantType");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateConstant(constantType, value);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression(constantType, value);
		}

		// Token: 0x06005322 RID: 21282 RVA: 0x0012A1F9 File Offset: 0x001283F9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression Parameter(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type);
			if (!global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree.IsValidParameterName(name))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_CommandTree_InvalidParameterName(name), "name");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression(type, name);
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x0012A239 File Offset: 0x00128439
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression Variable(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression(type, name);
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x0012A26C File Offset: 0x0012846C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression Scan(this global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase targetSet)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>(targetSet, "targetSet");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckEntitySet(targetSet, "targetSet");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbScanExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateCollectionResultType(targetSet.ElementType), targetSet);
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x0012A298 File Offset: 0x00128498
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression And(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(left.ResultType, right.ResultType);
			if (commonTypeUsage == null || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(commonTypeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_And_BooleanArgumentsRequired);
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbAndExpression(commonTypeUsage, left, right);
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x0012A2F0 File Offset: 0x001284F0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression Or(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(left.ResultType, right.ResultType);
			if (commonTypeUsage == null || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(commonTypeUsage, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Or_BooleanArgumentsRequired);
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbOrExpression(commonTypeUsage, left, right);
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x0012A348 File Offset: 0x00128548
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression In(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression> list)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(expression, "expression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression>>(list, "list");
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(list.Count);
			foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression dbConstantExpression in list)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqual(expression.ResultType, dbConstantExpression.ResultType))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_In_SameResultTypeRequired);
				}
				list2.Add(dbConstantExpression);
			}
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateInExpression(expression, list2);
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x0012A3DC File Offset: 0x001285DC
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression CreateInExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> list)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbInExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, item, new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(list));
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x0012A3EF File Offset: 0x001285EF
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression Not(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(argument.ResultType, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Not_BooleanArgumentRequired);
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNotExpression(argument.ResultType, argument);
		}

		// Token: 0x0600532A RID: 21290 RVA: 0x0012A424 File Offset: 0x00128624
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(left.ResultType, right.ResultType);
			if (commonTypeUsage == null || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(commonTypeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Arithmetic_NumericCommonType);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args = new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				left,
				right
			});
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression(kind, commonTypeUsage, args);
		}

		// Token: 0x0600532B RID: 21291 RVA: 0x0012A475 File Offset: 0x00128675
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Divide(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Divide, left, right);
		}

		// Token: 0x0600532C RID: 21292 RVA: 0x0012A498 File Offset: 0x00128698
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Minus(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Minus, left, right);
		}

		// Token: 0x0600532D RID: 21293 RVA: 0x0012A4BB File Offset: 0x001286BB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Modulo(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Modulo, left, right);
		}

		// Token: 0x0600532E RID: 21294 RVA: 0x0012A4DE File Offset: 0x001286DE
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Multiply(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Multiply, left, right);
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x0012A501 File Offset: 0x00128701
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Plus(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateArithmetic(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Plus, left, right);
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x0012A524 File Offset: 0x00128724
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression UnaryMinus(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = argument.ResultType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNumericType(typeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Arithmetic_NumericCommonType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsUnsignedNumericType(argument.ResultType))
			{
				typeUsage = null;
				if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetClosestPromotableType(argument.ResultType, out typeUsage))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus(argument.ResultType.EdmType.FullName));
				}
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.UnaryMinus, typeUsage, new global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				argument
			}));
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x0012A5A7 File Offset: 0x001287A7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbArithmeticExpression Negate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			return argument.UnaryMinus();
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x0012A5B0 File Offset: 0x001287B0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			bool flag = true;
			bool flag2 = true;
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals == kind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals == kind)
			{
				flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparableTo(left.ResultType, right.ResultType);
				flag2 = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparableTo(left.ResultType, right.ResultType);
			}
			else if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals == kind || global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals == kind)
			{
				flag = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEqualComparableTo(left.ResultType, right.ResultType);
			}
			else
			{
				flag2 = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsOrderComparableTo(left.ResultType, right.ResultType);
			}
			if (!flag || !flag2)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Comparison_ComparableRequired);
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression(kind, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, left, right);
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x0012A63F File Offset: 0x0012883F
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression Equal(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Equals, left, right);
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x0012A662 File Offset: 0x00128862
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression NotEqual(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NotEquals, left, right);
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x0012A685 File Offset: 0x00128885
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression GreaterThan(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThan, left, right);
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x0012A6A8 File Offset: 0x001288A8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression LessThan(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThan, left, right);
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0012A6CB File Offset: 0x001288CB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression GreaterThanOrEqual(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.GreaterThanOrEquals, left, right);
		}

		// Token: 0x06005338 RID: 21304 RVA: 0x0012A6EE File Offset: 0x001288EE
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbComparisonExpression LessThanOrEqual(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateComparison(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LessThanOrEquals, left, right);
		}

		// Token: 0x06005339 RID: 21305 RVA: 0x0012A711 File Offset: 0x00128911
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression IsNull(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateIsNull(argument);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbIsNullExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument);
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x0012A730 File Offset: 0x00128930
		private static void ValidateIsNull(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(argument.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_IsNull_CollectionNotAllowed);
			}
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidIsNullOpType(argument.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_IsNull_InvalidType);
			}
		}

		// Token: 0x0600533B RID: 21307 RVA: 0x0012A764 File Offset: 0x00128964
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression Like(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pattern, "pattern");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateLike(argument, pattern);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression escape = pattern.ResultType.Null();
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument, pattern, escape);
		}

		// Token: 0x0600533C RID: 21308 RVA: 0x0012A7A9 File Offset: 0x001289A9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression Like(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression escape)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(pattern, "pattern");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(escape, "escape");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateLike(argument, pattern, escape);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbLikeExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument, pattern, escape);
		}

		// Token: 0x0600533D RID: 21309 RVA: 0x0012A7E4 File Offset: 0x001289E4
		private static void ValidateLike(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression escape)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateLike(argument, pattern);
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(escape, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "escape");
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x0012A7FA File Offset: 0x001289FA
		private static void ValidateLike(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression pattern)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(argument, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "argument");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(pattern, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, "pattern");
		}

		// Token: 0x0600533F RID: 21311 RVA: 0x0012A818 File Offset: 0x00128A18
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression CastTo(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage toType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(toType, "toType");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(toType, "toType");
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCastAllowed(argument.ResultType, toType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Cast_InvalidCast(argument.ResultType.ToString(), toType.ToString()));
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbCastExpression(toType, argument);
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x0012A87C File Offset: 0x00128A7C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression TreatAs(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage treatType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(treatType, "treatType");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(treatType, "treatType");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequirePolymorphicType(treatType);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(argument.ResultType, treatType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_PolymorphicArgRequired(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression).Name));
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbTreatExpression(treatType, argument);
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x0012A8E4 File Offset: 0x00128AE4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression OfType(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateOfType(argument, type);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateCollectionResultType(type);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfType, collectionResultType, argument, type);
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x0012A924 File Offset: 0x00128B24
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression OfTypeOnly(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateOfType(argument, type);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionResultType = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateCollectionResultType(type);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OfTypeOnly, collectionResultType, argument, type);
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x0012A961 File Offset: 0x00128B61
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression IsOf(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateIsOf(argument, type);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOf, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument, type);
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x0012A990 File Offset: 0x00128B90
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression IsOfOnly(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ValidateIsOf(argument, type);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.IsOfOnly, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument, type);
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x0012A9C0 File Offset: 0x00128BC0
		private static void ValidateOfType(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequirePolymorphicType(type);
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArgument<global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression>(argument);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage fromType = null;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetCollectionElementType(argument.ResultType, out fromType) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(fromType, type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_PolymorphicArgRequired(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbOfTypeExpression).Name));
			}
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x0012AA18 File Offset: 0x00128C18
		private static void ValidateIsOf(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckType(type, "type");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequirePolymorphicType(type);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsValidPolymorphicCast(argument.ResultType, type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_General_PolymorphicArgRequired(typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbIsOfExpression).Name));
			}
		}

		// Token: 0x06005347 RID: 21319 RVA: 0x0012AA54 File Offset: 0x00128C54
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression Deref(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Metadata.Edm.EntityType edmType;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetRefEntityType(argument.ResultType, out edmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_DeRef_RefRequired, "argument");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbDerefExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType), argument);
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x0012AA98 File Offset: 0x00128C98
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression GetEntityRef(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Metadata.Edm.EntityType referencedEntityType = null;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(argument.ResultType, out referencedEntityType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GetEntityRef_EntityRequired, "argument");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbEntityRefExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateReferenceResultType(referencedEntityType), argument);
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x0012AADE File Offset: 0x00128CDE
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRef(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(keyValues, "keyValues");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRefExpression(entitySet, keyValues);
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x0012AAFF File Offset: 0x00128CFF
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRef(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] keyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]>(keyValues, "keyValues");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRefExpression(entitySet, keyValues);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x0012AB20 File Offset: 0x00128D20
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRef(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(keyValues, "keyValues");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRefExpression(entitySet, entityType, keyValues);
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x0012AB4E File Offset: 0x00128D4E
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRef(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] keyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]>(keyValues, "keyValues");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateRefExpression(entitySet, entityType, keyValues);
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x0012AB7C File Offset: 0x00128D7C
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRefExpression(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression refKeys;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateCreateRef(entitySet, entitySet.ElementType, keyValues, out refKeys), entitySet, refKeys);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x0012ABA0 File Offset: 0x00128DA0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression CreateRefExpression(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression refKeys;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateCreateRef(entitySet, entityType, keyValues, out refKeys), entitySet, refKeys);
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x0012ABD6 File Offset: 0x00128DD6
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression RefFromKey(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression keyRow)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyRow, "keyRow");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateRefFromKey(entitySet, keyRow, entitySet.ElementType), entitySet, keyRow);
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x0012AC04 File Offset: 0x00128E04
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression RefFromKey(this global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression keyRow, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(entitySet, "entitySet");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(keyRow, "keyRow");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRefExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateRefFromKey(entitySet, keyRow, entityType), entitySet, keyRow);
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x0012AC3C File Offset: 0x00128E3C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression GetRefKey(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = null;
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(argument.ResultType, out refType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_GetRefKey_RefRequired, "argument");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRefKeyExpression(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateKeyRowType(refType.ElementType)), argument);
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x0012AC8C File Offset: 0x00128E8C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(navigateFrom, "navigateFrom");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(fromEnd, "fromEnd");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(toEnd, "toEnd");
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNavigate(navigateFrom, fromEnd, toEnd, out relType, false), relType, fromEnd, toEnd, navigateFrom);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x0012ACD4 File Offset: 0x00128ED4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this global::System.Data.Entity.Core.Metadata.Edm.RelationshipType type, string fromEndName, string toEndName, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipType>(type, "type");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(fromEndName, "fromEndName");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(toEndName, "toEndName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(navigateFrom, "navigateFrom");
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd;
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNavigate(navigateFrom, type, fromEndName, toEndName, out fromEnd, out toEnd), type, fromEnd, toEnd, navigateFrom);
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x0012AD28 File Offset: 0x00128F28
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression Distinct(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArgument<global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression>(argument);
			if (!global::System.Data.Entity.Core.Common.TypeHelpers.IsValidDistinctOpType(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(argument.ResultType).TypeUsage))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Distinct_InvalidCollection, "argument");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbDistinctExpression(argument.ResultType, argument);
		}

		// Token: 0x06005355 RID: 21333 RVA: 0x0012AD7A File Offset: 0x00128F7A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression Element(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateElement(argument), argument);
		}

		// Token: 0x06005356 RID: 21334 RVA: 0x0012AD94 File Offset: 0x00128F94
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression IsEmpty(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArgument<global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression>(argument);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbIsEmptyExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._booleanType, argument);
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0012ADB3 File Offset: 0x00128FB3
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression Except(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireComparableCollectionArguments<global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression>(left, right);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbExceptExpression(left.ResultType, left, right);
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x0012ADE2 File Offset: 0x00128FE2
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression Intersect(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireComparableCollectionArguments<global::System.Data.Entity.Core.Common.CommandTrees.DbIntersectExpression>(left, right), left, right);
		}

		// Token: 0x06005359 RID: 21337 RVA: 0x0012AE0A File Offset: 0x0012900A
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression UnionAll(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArguments<global::System.Data.Entity.Core.Common.CommandTrees.DbUnionAllExpression>(left, right), left, right);
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x0012AE34 File Offset: 0x00129034
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression Limit(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(count, "count");
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCollectionArgument<global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression>(argument);
			if (!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(count.ResultType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Limit_IntegerRequired, "count");
			}
			if (count.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && count.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.ParameterReference)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Limit_ConstantOrParameterRefRequired, "count");
			}
			if (global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.IsConstantNegativeInteger(count))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Limit_NonNegativeLimitRequired, "count");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression(argument.ResultType, argument, count, false);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x0012AEC8 File Offset: 0x001290C8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression Case(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> whenExpressions, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> thenExpressions, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression elseExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(whenExpressions, "whenExpressions");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(thenExpressions, "thenExpressions");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(elseExpression, "elseExpression");
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList whens;
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList thens;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateCase(whenExpressions, thenExpressions, elseExpression, out whens, out thens), whens, thens, elseExpression);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0012AF0D File Offset: 0x0012910D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Invoke(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.InvokeFunction(function, arguments);
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x0012AF22 File Offset: 0x00129122
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression Invoke(this global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(function, "function");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.InvokeFunction(function, arguments);
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x0012AF38 File Offset: 0x00129138
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression InvokeFunction(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments2;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateFunction(function, arguments, out arguments2), function, arguments2);
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x0012AF55 File Offset: 0x00129155
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression Invoke(this global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(lambda, "lambda");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(arguments, "arguments");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.InvokeLambda(lambda, arguments);
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x0012AF76 File Offset: 0x00129176
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression Invoke(this global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbLambda>(lambda, "lambda");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]>(arguments, "arguments");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.InvokeLambda(lambda, arguments);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x0012AF98 File Offset: 0x00129198
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression InvokeLambda(global::System.Data.Entity.Core.Common.CommandTrees.DbLambda lambda, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbLambdaExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateInvoke(lambda, arguments, out args), lambda, args);
		}

		// Token: 0x06005362 RID: 21346 RVA: 0x0012AFB5 File Offset: 0x001291B5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression New(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(instanceType, "instanceType");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewInstance(instanceType, arguments);
		}

		// Token: 0x06005363 RID: 21347 RVA: 0x0012AFCA File Offset: 0x001291CA
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression New(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType, params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] arguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(instanceType, "instanceType");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewInstance(instanceType, arguments);
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x0012AFE0 File Offset: 0x001291E0
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression NewInstance(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage instanceType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> arguments)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNew(instanceType, arguments, out args), args);
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x0012AFFC File Offset: 0x001291FC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression NewCollection(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> elements)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewCollection(elements);
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x0012B004 File Offset: 0x00129204
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression NewCollection(params global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] elements)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]>(elements, "elements");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateNewCollection(elements);
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x0012B018 File Offset: 0x00129218
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression CreateNewCollection(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> elements)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonElementType = null;
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CreateExpressionList(elements, "elements", delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression exp, int idx)
			{
				if (commonElementType == null)
				{
					commonElementType = exp.ResultType;
				}
				else
				{
					commonElementType = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.GetCommonType(commonElementType, exp.ResultType);
				}
				if (commonElementType == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Factory_NewCollectionInvalidCommonType, "collectionElements");
				}
			});
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateCollectionResultType(commonElementType), args);
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x0012B05C File Offset: 0x0012925C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression NewEmptyCollection(this global::System.Data.Entity.Core.Metadata.Edm.TypeUsage collectionType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(collectionType, "collectionType");
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNewEmptyCollection(collectionType, out args), args);
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x0012B084 File Offset: 0x00129284
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression NewRow(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> columnValues)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>>(columnValues, "columnValues");
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList args;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNewRow(columnValues, out args), args);
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x0012B0AB File Offset: 0x001292AB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression Property(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyMetadata)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(instance, "instance");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(propertyMetadata, "propertyMetadata");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.PropertyFromMember(instance, propertyMetadata, "propertyMetadata");
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x0012B0D1 File Offset: 0x001292D1
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression Property(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(instance, "instance");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.PropertyFromMember(instance, navigationProperty, "navigationProperty");
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x0012B0F7 File Offset: 0x001292F7
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression Property(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEnd)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(instance, "instance");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>(relationshipEnd, "relationshipEnd");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.PropertyFromMember(instance, relationshipEnd, "relationshipEnd");
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x0012B11D File Offset: 0x0012931D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression Property(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, string propertyName)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.PropertyByName(instance, propertyName, false);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x0012B128 File Offset: 0x00129328
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression PropertyFromMember(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.EdmMember property, string propertyArgumentName)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.CheckMember(property, propertyArgumentName);
			if (instance == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Property_InstanceRequiredForInstance, "instance");
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage requiredResultType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(property.DeclaringType);
			global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.RequireCompatibleType(instance, requiredResultType, "instance");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property), property, instance);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x0012B174 File Offset: 0x00129374
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression PropertyByName(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, string propertyName, bool ignoreCase)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(instance, "instance");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(propertyName, "propertyName");
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember property;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateProperty(instance, propertyName, ignoreCase, out property), property, instance);
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x0012B1AA File Offset: 0x001293AA
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause SetClause(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression property, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(property, "property");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(value, "value");
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause(property, value);
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x0012B1CB File Offset: 0x001293CB
		private static string ExtractAlias(global::System.Reflection.MethodInfo method)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ExtractAliases(method)[0];
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x0012B1D8 File Offset: 0x001293D8
		internal static string[] ExtractAliases(global::System.Reflection.MethodInfo method)
		{
			global::System.Reflection.ParameterInfo[] parameters = method.GetParameters();
			int num;
			int num2;
			if (method.IsStatic && "System.Runtime.CompilerServices.Closure" == parameters[0].ParameterType.FullName)
			{
				num = 1;
				num2 = parameters.Length - 1;
			}
			else
			{
				num = 0;
				num2 = parameters.Length;
			}
			string[] array = new string[num2];
			bool flag = parameters.Skip(num).Any((global::System.Reflection.ParameterInfo p) => p.Name == null);
			for (int i = num; i < parameters.Length; i++)
			{
				array[i - num] = (flag ? global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._bindingAliases.Next() : parameters[i].Name);
			}
			return array;
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x0012B284 File Offset: 0x00129484
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding ConvertToBinding<TResult>(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TResult> argument, out TResult argumentResult)
		{
			string varName = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ExtractAlias(argument.Method);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = source.BindAs(varName);
			argumentResult = argument(dbExpressionBinding.Variable);
			return dbExpressionBinding;
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x0012B2B8 File Offset: 0x001294B8
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[] ConvertToBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> argument, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argumentExp)
		{
			string[] array = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ExtractAliases(argument.Method);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = left.BindAs(array[0]);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = right.BindAs(array[1]);
			argumentExp = argument(dbExpressionBinding.Variable, dbExpressionBinding2.Variable);
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[]
			{
				dbExpressionBinding,
				dbExpressionBinding2
			};
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x0012B308 File Offset: 0x00129508
		internal static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, TRequired>> TryGetAnonymousTypeValues<TInstance, TRequired>(object instance)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> instanceProperties = typeof(TInstance).GetInstanceProperties();
			if (!(typeof(TInstance).BaseType() != typeof(object)))
			{
				if (!instanceProperties.Any((global::System.Reflection.PropertyInfo p) => !p.IsPublic()))
				{
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, TRequired>> list = null;
					foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in instanceProperties
					where p.IsPublic()
					select p)
					{
						if (!propertyInfo.CanRead || !typeof(TRequired).IsAssignableFrom(propertyInfo.PropertyType))
						{
							return null;
						}
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, TRequired>>();
						}
						list.Add(new global::System.Collections.Generic.KeyValuePair<string, TRequired>(propertyInfo.Name, (TRequired)((object)propertyInfo.GetValue(instance, null))));
					}
					return list;
				}
			}
			return null;
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x0012B41C File Offset: 0x0012961C
		private static bool TryResolveToConstant(global::System.Type type, object value, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression constantOrNullExpression)
		{
			constantOrNullExpression = null;
			global::System.Type clrType = type;
			if (type.IsGenericType() && typeof(global::System.Nullable<>).Equals(type.GetGenericTypeDefinition()))
			{
				clrType = type.GetGenericArguments()[0];
			}
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind;
			if (global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.TryGetPrimitiveTypeKind(clrType, out primitiveTypeKind))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage literalTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetLiteralTypeUsage(primitiveTypeKind);
				if (value == null)
				{
					constantOrNullExpression = literalTypeUsage.Null();
				}
				else
				{
					constantOrNullExpression = literalTypeUsage.Constant(value);
				}
			}
			return constantOrNullExpression != null;
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x0012B484 File Offset: 0x00129684
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ResolveToExpression<TArgument>(TArgument argument)
		{
			object obj = argument;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result;
			if (global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.TryResolveToConstant(typeof(TArgument), obj, out result))
			{
				return result;
			}
			if (obj == null)
			{
				return null;
			}
			if (typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression).IsAssignableFrom(typeof(TArgument)))
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression)obj;
			}
			if (typeof(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Row).Equals(typeof(TArgument)))
			{
				return ((global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Row)obj).ToExpression();
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> list = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.TryGetAnonymousTypeValues<TArgument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(obj);
			if (list != null)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(list);
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Cqt_Factory_MethodResultTypeNotSupported(typeof(TArgument).FullName));
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x0012B528 File Offset: 0x00129728
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression CreateApply(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> apply, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression> resultBuilder)
		{
			global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> keyValuePair;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding arg = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(source, apply, out keyValuePair);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding arg2 = keyValuePair.Value.BindAs(keyValuePair.Key);
			return resultBuilder(arg, arg2);
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x0012B55C File Offset: 0x0012975C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression All(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(predicate, "predicate");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate2;
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, predicate, out predicate2).All(predicate2);
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x0012B590 File Offset: 0x00129790
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Any(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source)
		{
			return source.Exists();
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x0012B598 File Offset: 0x00129798
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Exists(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			return argument.IsEmpty().Not();
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x0012B5A8 File Offset: 0x001297A8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbQuantifierExpression Any(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(predicate, "predicate");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate2;
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, predicate, out predicate2).Any(predicate2);
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x0012B5DC File Offset: 0x001297DC
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression CrossApply(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> apply)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>>(apply, "apply");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApply(source, apply, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CrossApply));
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x0012B609 File Offset: 0x00129809
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression OuterApply(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> apply)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>>(apply, "apply");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateApply(source, apply, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding, global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.OuterApply));
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x0012B638 File Offset: 0x00129838
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression FullOuterJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[] array = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding(left, right, joinCondition, out joinCondition2);
			return array[0].FullOuterJoin(array[1], joinCondition2);
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x0012B680 File Offset: 0x00129880
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression InnerJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[] array = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding(left, right, joinCondition, out joinCondition2);
			return array[0].InnerJoin(array[1], joinCondition2);
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x0012B6C8 File Offset: 0x001298C8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> joinCondition)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(left, "left");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(right, "right");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(joinCondition, "joinCondition");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[] array = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding(left, right, joinCondition, out joinCondition2);
			return array[0].LeftOuterJoin(array[1], joinCondition2);
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x0012B710 File Offset: 0x00129910
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression Join(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression outer, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inner, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> outerKey, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> innerKey)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(outer, "outer");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(inner, "inner");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(outerKey, "outerKey");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(innerKey, "innerKey");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding left = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(outer, outerKey, out left2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding right = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(inner, innerKey, out right2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition = left2.Equal(right2);
			return left.InnerJoin(right, joinCondition);
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x0012B770 File Offset: 0x00129970
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression Join<TSelector>(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression outer, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression inner, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> outerKey, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> innerKey, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TSelector> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TSelector>>(selector, "selector");
			global::System.Data.Entity.Core.Common.CommandTrees.DbJoinExpression dbJoinExpression = outer.Join(inner, outerKey, innerKey);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = dbJoinExpression.Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression arg = dbExpressionBinding.Variable.Property(dbJoinExpression.Left.VariableName);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression arg2 = dbExpressionBinding.Variable.Property(dbJoinExpression.Right.VariableName);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ResolveToExpression<TSelector>(selector(arg, arg2));
			return dbExpressionBinding.Project(projection);
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x0012B7E0 File Offset: 0x001299E0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression OrderBy(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, sortKey, out key);
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause = key.ToSortClause();
			return input.Sort(new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause[]
			{
				dbSortClause
			});
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x0012B824 File Offset: 0x00129A24
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression OrderBy(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, sortKey, out key);
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause = key.ToSortClause(collation);
			return input.Sort(new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause[]
			{
				dbSortClause
			});
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x0012B86C File Offset: 0x00129A6C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression OrderByDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, sortKey, out key);
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause = key.ToSortClauseDescending();
			return input.Sort(new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause[]
			{
				dbSortClause
			});
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x0012B8B0 File Offset: 0x00129AB0
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression OrderByDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, sortKey, out key);
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause dbSortClause = key.ToSortClauseDescending(collation);
			return input.Sort(new global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause[]
			{
				dbSortClause
			});
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x0012B8F8 File Offset: 0x00129AF8
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression Select<TProjection>(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TProjection> projection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TProjection>>(projection, "projection");
			TProjection argument;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<TProjection>(source, projection, out argument);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection2 = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ResolveToExpression<TProjection>(argument);
			return input.Project(projection2);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x0012B934 File Offset: 0x00129B34
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression SelectMany(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> apply)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(apply, "apply");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input2;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, apply, out input2);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = input2.Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = input.CrossApply(dbExpressionBinding).Bind();
			return dbExpressionBinding2.Project(dbExpressionBinding2.Variable.Property(dbExpressionBinding.VariableName));
		}

		// Token: 0x0600538A RID: 21386 RVA: 0x0012B98C File Offset: 0x00129B8C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression SelectMany<TSelector>(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> apply, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TSelector> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(apply, "apply");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, TSelector>>(selector, "selector");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input;
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, apply, out input);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding2 = input.Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding3 = dbExpressionBinding.CrossApply(dbExpressionBinding2).Bind();
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression arg = dbExpressionBinding3.Variable.Property(dbExpressionBinding.VariableName);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression arg2 = dbExpressionBinding3.Variable.Property(dbExpressionBinding2.VariableName);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression projection = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ResolveToExpression<TSelector>(selector(arg, arg2));
			return dbExpressionBinding3.Project(projection);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x0012BA16 File Offset: 0x00129C16
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSkipExpression Skip(this global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(argument, "argument");
			return argument.Input.Skip(argument.SortOrder, count);
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x0012BA36 File Offset: 0x00129C36
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbLimitExpression Take(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression count)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(argument, "argument");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(count, "count");
			return argument.Limit(count);
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x0012BA58 File Offset: 0x00129C58
		private static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression CreateThenBy(global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey, bool ascending, string collation, bool useCollation)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression key = sortKey(source.Input.Variable);
			global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause item;
			if (useCollation)
			{
				item = (ascending ? key.ToSortClause(collation) : key.ToSortClauseDescending(collation));
			}
			else
			{
				item = (ascending ? key.ToSortClause() : key.ToSortClauseDescending());
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbSortClause>(source.SortOrder.Count + 1);
			list.AddRange(source.SortOrder);
			list.Add(item);
			return source.Input.Sort(list);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x0012BAD5 File Offset: 0x00129CD5
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression ThenBy(this global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateThenBy(source, sortKey, true, null, false);
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x0012BAF9 File Offset: 0x00129CF9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression ThenBy(this global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateThenBy(source, sortKey, true, collation, true);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x0012BB1D File Offset: 0x00129D1D
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression ThenByDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateThenBy(source, sortKey, false, null, false);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x0012BB41 File Offset: 0x00129D41
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression ThenByDescending(this global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> sortKey, string collation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSortExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(sortKey, "sortKey");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CreateThenBy(source, sortKey, false, collation, true);
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x0012BB68 File Offset: 0x00129D68
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression Where(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression source, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>>(predicate, "predicate");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate2;
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.ConvertToBinding<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(source, predicate, out predicate2).Filter(predicate2);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x0012BB9C File Offset: 0x00129D9C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Union(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression left, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right)
		{
			return left.UnionAll(right).Distinct();
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06005394 RID: 21396 RVA: 0x0012BBAA File Offset: 0x00129DAA
		internal static global::System.Data.Entity.Core.Common.Utils.AliasGenerator AliasGenerator
		{
			get
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._bindingAliases;
			}
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x0012BBB4 File Offset: 0x00129DB4
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression CreatePrimitiveNullExpression(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveType)
		{
			switch (primitiveType)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._binaryNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._boolNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._byteNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._dateTimeNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._decimalNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._doubleNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._guidNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._singleNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._sbyteNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._int16Null;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._int32Null;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._int64Null;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._stringNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._timeNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._dateTimeOffsetNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._geometryNull;
			case global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography:
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder._geographyNull;
			default:
			{
				string name = typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind).Name;
				int num = (int)primitiveType;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			}
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x0012BC9C File Offset: 0x00129E9C
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbApplyExpression CreateApplyExpressionByKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind applyKind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding apply)
		{
			if (applyKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossApply)
			{
				return input.CrossApply(apply);
			}
			if (applyKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.OuterApply)
			{
				string name = typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind).Name;
				int num = (int)applyKind;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			return input.OuterApply(apply);
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x0012BCEC File Offset: 0x00129EEC
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbExpression CreateJoinExpressionByKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind joinKind, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression joinCondition, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding input2)
		{
			if (global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.CrossJoin == joinKind)
			{
				return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.CrossJoin(new global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding[]
				{
					input1,
					input2
				});
			}
			if (joinKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.FullOuterJoin)
			{
				return input1.FullOuterJoin(input2, joinCondition);
			}
			if (joinKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.InnerJoin)
			{
				return input1.InnerJoin(input2, joinCondition);
			}
			if (joinKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.LeftOuterJoin)
			{
				string name = typeof(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind).Name;
				int num = (int)joinKind;
				throw new global::System.ArgumentOutOfRangeException(name, global::System.Data.Entity.Resources.Strings.ADP_InvalidEnumerationValue(name, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			return input1.LeftOuterJoin(input2, joinCondition);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x0012BD68 File Offset: 0x00129F68
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression CreateElementExpressionUnwrapSingleProperty(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties = global::System.Data.Entity.Core.Common.TypeHelpers.GetProperties(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateElement(argument));
			if (properties == null || properties.Count != 1)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.Cqt_Element_InvalidArgumentForUnwrapSingleProperty, "argument");
			}
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbElementExpression(properties[0].TypeUsage, argument, true);
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x0012BDB0 File Offset: 0x00129FB0
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef CreateRelatedEntityRef(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember sourceEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember targetEnd, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression targetEntity)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef(sourceEnd, targetEnd, targetEntity);
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x0012BDBC File Offset: 0x00129FBC
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression CreateNewEntityWithRelationshipsExpression(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> attributeValues, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relationships)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList attributeValues2;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.DbRelatedEntityRef> relationships2;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNewEntityWithRelationships(entityType, attributeValues, relationships, out attributeValues2, out relationships2), attributeValues2, relationships2);
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x0012BDDC File Offset: 0x00129FDC
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression NavigateAllowingAllRelationshipsInSameTypeHierarchy(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression navigateFrom, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember fromEnd, global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember toEnd)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relType;
			return new global::System.Data.Entity.Core.Common.CommandTrees.DbRelationshipNavigationExpression(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Internal.ArgumentValidation.ValidateNavigate(navigateFrom, fromEnd, toEnd, out relType, true), relType, fromEnd, toEnd, navigateFrom);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x0012BDFD File Offset: 0x00129FFD
		internal static global::System.Data.Entity.Core.Common.CommandTrees.DbPropertyExpression CreatePropertyExpressionFromMember(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression instance, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.PropertyFromMember(instance, member, "member");
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x0012BE0B File Offset: 0x0012A00B
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateCollectionResultType(global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(type)));
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x0012BE1D File Offset: 0x0012A01D
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage CreateCollectionResultType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionType(elementType));
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x0012BE2A File Offset: 0x0012A02A
		private static bool IsConstantNegativeInteger(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			return expression.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Constant && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsIntegerNumericType(expression.ResultType) && global::System.Convert.ToInt64(((global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression)expression).Value, global::System.Globalization.CultureInfo.InvariantCulture) < 0L;
		}

		// Token: 0x04001DF9 RID: 7673
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _booleanType = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean);

		// Token: 0x04001DFA RID: 7674
		private static readonly global::System.Data.Entity.Core.Common.Utils.AliasGenerator _bindingAliases = new global::System.Data.Entity.Core.Common.Utils.AliasGenerator("Var_", 0);

		// Token: 0x04001DFB RID: 7675
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _binaryNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Binary).Null();

		// Token: 0x04001DFC RID: 7676
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _boolNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean).Null();

		// Token: 0x04001DFD RID: 7677
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _byteNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Byte).Null();

		// Token: 0x04001DFE RID: 7678
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _dateTimeNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime).Null();

		// Token: 0x04001DFF RID: 7679
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _dateTimeOffsetNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTimeOffset).Null();

		// Token: 0x04001E00 RID: 7680
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _decimalNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Decimal).Null();

		// Token: 0x04001E01 RID: 7681
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _doubleNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Double).Null();

		// Token: 0x04001E02 RID: 7682
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _geographyNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography).Null();

		// Token: 0x04001E03 RID: 7683
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _geometryNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry).Null();

		// Token: 0x04001E04 RID: 7684
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _guidNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid).Null();

		// Token: 0x04001E05 RID: 7685
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _int16Null = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16).Null();

		// Token: 0x04001E06 RID: 7686
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _int32Null = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32).Null();

		// Token: 0x04001E07 RID: 7687
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _int64Null = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64).Null();

		// Token: 0x04001E08 RID: 7688
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _sbyteNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.SByte).Null();

		// Token: 0x04001E09 RID: 7689
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _singleNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Single).Null();

		// Token: 0x04001E0A RID: 7690
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _stringNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String).Null();

		// Token: 0x04001E0B RID: 7691
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression _timeNull = global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetCanonicalModelTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Time).Null();

		// Token: 0x04001E0C RID: 7692
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression _boolTrue = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(true);

		// Token: 0x04001E0D RID: 7693
		private static readonly global::System.Data.Entity.Core.Common.CommandTrees.DbConstantExpression _boolFalse = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Constant(false);
	}
}
