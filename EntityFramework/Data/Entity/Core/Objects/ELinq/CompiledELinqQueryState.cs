using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x0200045E RID: 1118
	internal sealed class CompiledELinqQueryState : global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x000B060C File Offset: 0x000AE80C
		internal CompiledELinqQueryState(global::System.Type elementType, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Linq.Expressions.LambdaExpression lambda, global::System.Guid cacheToken, object[] parameterValues, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory = null) : base(elementType, context, lambda, null)
		{
			this._cacheToken = cacheToken;
			this._parameterValues = parameterValues;
			base.EnsureParameters();
			base.Parameters.SetReadOnly(true);
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x000B0658 File Offset: 0x000AE858
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan GetExecutionPlan(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption)
		{
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan = null;
			global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry compiledQueryCacheEntry = this._cacheEntry;
			bool useCSharpNullComparisonBehavior = base.ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior;
			bool disableFilterOverProjectionSimplificationForCustomFunctions = base.ObjectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
			if (compiledQueryCacheEntry != null)
			{
				global::System.Data.Entity.Core.Objects.MergeOption mergeOption = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.EnsureMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
				{
					forMergeOption,
					base.UserSpecifiedMergeOption,
					compiledQueryCacheEntry.PropagatedMergeOption
				});
				objectQueryExecutionPlan = compiledQueryCacheEntry.GetExecutionPlan(mergeOption, useCSharpNullComparisonBehavior);
				if (objectQueryExecutionPlan == null)
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter expressionConverter = this.CreateExpressionConverter();
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = expressionConverter.Convert();
					global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> parameters = expressionConverter.GetParameters();
					global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(base.ObjectContext.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, query, !useCSharpNullComparisonBehavior, disableFilterOverProjectionSimplificationForCustomFunctions);
					objectQueryExecutionPlan = this._objectQueryExecutionPlanFactory.Prepare(base.ObjectContext, tree, base.ElementType, mergeOption, base.EffectiveStreamingBehavior, expressionConverter.PropagatedSpan, parameters, expressionConverter.AliasGenerator);
					objectQueryExecutionPlan = compiledQueryCacheEntry.SetExecutionPlan(objectQueryExecutionPlan, useCSharpNullComparisonBehavior);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager queryCacheManager = base.ObjectContext.MetadataWorkspace.GetQueryCacheManager();
				global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheKey compiledQueryCacheKey = new global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheKey(this._cacheToken);
				if (queryCacheManager.TryCacheLookup<global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheKey, global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry>(compiledQueryCacheKey, out compiledQueryCacheEntry))
				{
					this._cacheEntry = compiledQueryCacheEntry;
					global::System.Data.Entity.Core.Objects.MergeOption mergeOption2 = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.EnsureMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
					{
						forMergeOption,
						base.UserSpecifiedMergeOption,
						compiledQueryCacheEntry.PropagatedMergeOption
					});
					objectQueryExecutionPlan = compiledQueryCacheEntry.GetExecutionPlan(mergeOption2, useCSharpNullComparisonBehavior);
				}
				if (objectQueryExecutionPlan == null)
				{
					global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter expressionConverter2 = this.CreateExpressionConverter();
					global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query2 = expressionConverter2.Convert();
					global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> parameters2 = expressionConverter2.GetParameters();
					global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree2 = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(base.ObjectContext.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, query2, !useCSharpNullComparisonBehavior, disableFilterOverProjectionSimplificationForCustomFunctions);
					if (compiledQueryCacheEntry == null)
					{
						compiledQueryCacheEntry = new global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry(compiledQueryCacheKey, expressionConverter2.PropagatedMergeOption);
						global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry;
						if (queryCacheManager.TryLookupAndAdd(compiledQueryCacheEntry, out queryCacheEntry))
						{
							compiledQueryCacheEntry = (global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry)queryCacheEntry;
						}
						this._cacheEntry = compiledQueryCacheEntry;
					}
					global::System.Data.Entity.Core.Objects.MergeOption mergeOption3 = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.EnsureMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
					{
						forMergeOption,
						base.UserSpecifiedMergeOption,
						compiledQueryCacheEntry.PropagatedMergeOption
					});
					objectQueryExecutionPlan = compiledQueryCacheEntry.GetExecutionPlan(mergeOption3, useCSharpNullComparisonBehavior);
					if (objectQueryExecutionPlan == null)
					{
						objectQueryExecutionPlan = this._objectQueryExecutionPlanFactory.Prepare(base.ObjectContext, tree2, base.ElementType, mergeOption3, base.EffectiveStreamingBehavior, expressionConverter2.PropagatedSpan, parameters2, expressionConverter2.AliasGenerator);
						objectQueryExecutionPlan = compiledQueryCacheEntry.SetExecutionPlan(objectQueryExecutionPlan, useCSharpNullComparisonBehavior);
					}
				}
			}
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection = base.EnsureParameters();
			if (objectQueryExecutionPlan.CompiledQueryParameters != null && objectQueryExecutionPlan.CompiledQueryParameters.Any<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>>())
			{
				objectParameterCollection.SetReadOnly(false);
				objectParameterCollection.Clear();
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression> tuple in objectQueryExecutionPlan.CompiledQueryParameters)
				{
					global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter = tuple.Item1.ShallowCopy();
					global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression item = tuple.Item2;
					objectParameterCollection.Add(objectParameter);
					if (item != null)
					{
						objectParameter.Value = item.EvaluateParameter(this._parameterValues);
					}
				}
			}
			objectParameterCollection.SetReadOnly(true);
			return objectQueryExecutionPlan;
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x000B093C File Offset: 0x000AEB3C
		protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetResultType()
		{
			global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry cacheEntry = this._cacheEntry;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (cacheEntry != null && cacheEntry.TryGetResultType(out result))
			{
				return result;
			}
			return base.GetResultType();
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000B0965 File Offset: 0x000AEB65
		internal override global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				return global::System.Data.Entity.Core.Objects.ELinq.CompiledELinqQueryState.CreateDonateableExpressionVisitor.Replace((global::System.Linq.Expressions.LambdaExpression)base.Expression, base.ObjectContext, this._parameterValues);
			}
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x000B0984 File Offset: 0x000AEB84
		protected override global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter CreateExpressionConverter()
		{
			global::System.Linq.Expressions.LambdaExpression lambdaExpression = (global::System.Linq.Expressions.LambdaExpression)base.Expression;
			return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.CreateCompiledQueryEvaluationFuncletizer(base.ObjectContext, lambdaExpression.Parameters.First<global::System.Linq.Expressions.ParameterExpression>(), new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Linq.Expressions.ParameterExpression>(lambdaExpression.Parameters.Skip(1).ToList<global::System.Linq.Expressions.ParameterExpression>())), lambdaExpression.Body);
		}

		// Token: 0x040011D0 RID: 4560
		private readonly global::System.Guid _cacheToken;

		// Token: 0x040011D1 RID: 4561
		private readonly object[] _parameterValues;

		// Token: 0x040011D2 RID: 4562
		private global::System.Data.Entity.Core.Common.QueryCache.CompiledQueryCacheEntry _cacheEntry;

		// Token: 0x040011D3 RID: 4563
		private readonly global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory _objectQueryExecutionPlanFactory;

		// Token: 0x02000A71 RID: 2673
		private sealed class CreateDonateableExpressionVisitor : global::System.Linq.Expressions.EntityExpressionVisitor
		{
			// Token: 0x06006204 RID: 25092 RVA: 0x00153094 File Offset: 0x00151294
			private CreateDonateableExpressionVisitor(global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, object> parameterToValueLookup)
			{
				this._parameterToValueLookup = parameterToValueLookup;
			}

			// Token: 0x06006205 RID: 25093 RVA: 0x001530A4 File Offset: 0x001512A4
			internal static global::System.Linq.Expressions.Expression Replace(global::System.Linq.Expressions.LambdaExpression query, global::System.Data.Entity.Core.Objects.ObjectContext objectContext, object[] parameterValues)
			{
				global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, object> dictionary = query.Parameters.Skip(1).Zip(parameterValues).ToDictionary((global::System.Collections.Generic.KeyValuePair<global::System.Linq.Expressions.ParameterExpression, object> pair) => pair.Key, (global::System.Collections.Generic.KeyValuePair<global::System.Linq.Expressions.ParameterExpression, object> pair) => pair.Value);
				dictionary.Add(query.Parameters.First<global::System.Linq.Expressions.ParameterExpression>(), objectContext);
				return new global::System.Data.Entity.Core.Objects.ELinq.CompiledELinqQueryState.CreateDonateableExpressionVisitor(dictionary).Visit(query.Body);
			}

			// Token: 0x06006206 RID: 25094 RVA: 0x00153128 File Offset: 0x00151328
			internal override global::System.Linq.Expressions.Expression VisitParameter(global::System.Linq.Expressions.ParameterExpression p)
			{
				object value;
				global::System.Linq.Expressions.Expression result;
				if (this._parameterToValueLookup.TryGetValue(p, out value))
				{
					result = global::System.Linq.Expressions.Expression.Constant(value, p.Type);
				}
				else
				{
					result = base.VisitParameter(p);
				}
				return result;
			}

			// Token: 0x04002B26 RID: 11046
			private readonly global::System.Collections.Generic.Dictionary<global::System.Linq.Expressions.ParameterExpression, object> _parameterToValueLookup;
		}
	}
}
