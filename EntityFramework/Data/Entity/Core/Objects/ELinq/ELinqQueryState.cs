using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x0200045F RID: 1119
	internal class ELinqQueryState : global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState
	{
		// Token: 0x060036F2 RID: 14066 RVA: 0x000B09D4 File Offset: 0x000AEBD4
		internal ELinqQueryState(global::System.Type elementType, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Linq.Expressions.Expression expression, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory = null) : base(elementType, context, null, null)
		{
			this._expression = expression;
			this._useCSharpNullComparisonBehavior = context.ContextOptions.UseCSharpNullComparisonBehavior;
			this._disableFilterOverProjectionSimplificationForCustomFunctions = context.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x000B0A26 File Offset: 0x000AEC26
		internal ELinqQueryState(global::System.Type elementType, global::System.Data.Entity.Core.Objects.ObjectQuery query, global::System.Linq.Expressions.Expression expression, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory = null) : base(elementType, query)
		{
			this._expression = expression;
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x000B0A49 File Offset: 0x000AEC49
		protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetResultType()
		{
			return this.CreateExpressionConverter().Convert().ResultType;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x000B0A5C File Offset: 0x000AEC5C
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan GetExecutionPlan(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption)
		{
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan = this._cachedPlan;
			if (objectQueryExecutionPlan != null)
			{
				global::System.Data.Entity.Core.Objects.MergeOption? mergeOption = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.GetMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
				{
					forMergeOption,
					base.UserSpecifiedMergeOption
				});
				if ((mergeOption != null && mergeOption.Value != objectQueryExecutionPlan.MergeOption) || this._recompileRequired() || base.ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior != this._useCSharpNullComparisonBehavior || base.ObjectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions != this._disableFilterOverProjectionSimplificationForCustomFunctions)
				{
					objectQueryExecutionPlan = null;
				}
			}
			if (objectQueryExecutionPlan == null)
			{
				this._recompileRequired = null;
				this.ResetParameters();
				global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter expressionConverter = this.CreateExpressionConverter();
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = expressionConverter.Convert();
				this._recompileRequired = expressionConverter.RecompileRequired;
				global::System.Data.Entity.Core.Objects.MergeOption mergeOption2 = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.EnsureMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
				{
					forMergeOption,
					base.UserSpecifiedMergeOption,
					expressionConverter.PropagatedMergeOption
				});
				this._useCSharpNullComparisonBehavior = base.ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior;
				this._disableFilterOverProjectionSimplificationForCustomFunctions = base.ObjectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
				this._linqParameters = expressionConverter.GetParameters();
				if (this._linqParameters != null && this._linqParameters.Any<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>>())
				{
					global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection = base.EnsureParameters();
					objectParameterCollection.SetReadOnly(false);
					foreach (global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression> tuple in this._linqParameters)
					{
						global::System.Data.Entity.Core.Objects.ObjectParameter item = tuple.Item1;
						objectParameterCollection.Add(item);
					}
					objectParameterCollection.SetReadOnly(true);
				}
				global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager queryCacheManager = null;
				global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey linqQueryCacheKey = null;
				string expressionKey;
				if (base.PlanCachingEnabled && !this._recompileRequired() && global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionKeyGen.TryGenerateKey(dbExpression, out expressionKey))
				{
					linqQueryCacheKey = new global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey(expressionKey, (base.Parameters == null) ? 0 : base.Parameters.Count, (base.Parameters == null) ? null : base.Parameters.GetCacheKey(), (expressionConverter.PropagatedSpan == null) ? null : expressionConverter.PropagatedSpan.GetCacheKey(), mergeOption2, base.EffectiveStreamingBehavior, this._useCSharpNullComparisonBehavior, base.ElementType);
					queryCacheManager = base.ObjectContext.MetadataWorkspace.GetQueryCacheManager();
					global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan2 = null;
					if (queryCacheManager.TryCacheLookup<global::System.Data.Entity.Core.Common.QueryCache.LinqQueryCacheKey, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan>(linqQueryCacheKey, out objectQueryExecutionPlan2))
					{
						objectQueryExecutionPlan = objectQueryExecutionPlan2;
					}
				}
				if (objectQueryExecutionPlan == null)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(base.ObjectContext.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, dbExpression, !this._useCSharpNullComparisonBehavior, this._disableFilterOverProjectionSimplificationForCustomFunctions);
					objectQueryExecutionPlan = this._objectQueryExecutionPlanFactory.Prepare(base.ObjectContext, tree, base.ElementType, mergeOption2, base.EffectiveStreamingBehavior, expressionConverter.PropagatedSpan, null, expressionConverter.AliasGenerator);
					if (linqQueryCacheKey != null)
					{
						global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry inQueryCacheEntry = new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry(linqQueryCacheKey, objectQueryExecutionPlan);
						global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry = null;
						if (queryCacheManager.TryLookupAndAdd(inQueryCacheEntry, out queryCacheEntry))
						{
							objectQueryExecutionPlan = (global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan)queryCacheEntry.GetTarget();
						}
					}
				}
				this._cachedPlan = objectQueryExecutionPlan;
			}
			if (this._linqParameters != null)
			{
				foreach (global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression> tuple2 in this._linqParameters)
				{
					global::System.Data.Entity.Core.Objects.ObjectParameter item2 = tuple2.Item1;
					global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression item3 = tuple2.Item2;
					if (item3 != null)
					{
						item2.Value = item3.EvaluateParameter(null);
					}
				}
			}
			return objectQueryExecutionPlan;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x000B0D98 File Offset: 0x000AEF98
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Include<TElementType>(global::System.Data.Entity.Core.Objects.ObjectQuery<TElementType> sourceQuery, string includePath)
		{
			global::System.Reflection.MethodInfo includeMethod = global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState.GetIncludeMethod<TElementType>(sourceQuery);
			global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Constant(sourceQuery), includeMethod, new global::System.Linq.Expressions.Expression[]
			{
				global::System.Linq.Expressions.Expression.Constant(includePath, typeof(string))
			});
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState objectQueryState = new global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState(base.ElementType, base.ObjectContext, expression, null);
			base.ApplySettingsTo(objectQueryState);
			return objectQueryState;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x000B0DEE File Offset: 0x000AEFEE
		internal static global::System.Reflection.MethodInfo GetIncludeMethod<TElementType>(global::System.Data.Entity.Core.Objects.ObjectQuery<TElementType> sourceQuery)
		{
			return sourceQuery.GetType().GetOnlyDeclaredMethod("Include");
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x000B0E00 File Offset: 0x000AF000
		internal override bool TryGetCommandText(out string commandText)
		{
			commandText = null;
			return false;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x000B0E06 File Offset: 0x000AF006
		internal override bool TryGetExpression(out global::System.Linq.Expressions.Expression expression)
		{
			expression = this.Expression;
			return true;
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000B0E11 File Offset: 0x000AF011
		internal virtual global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				return this._expression;
			}
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x000B0E19 File Offset: 0x000AF019
		protected virtual global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter CreateExpressionConverter()
		{
			return new global::System.Data.Entity.Core.Objects.ELinq.ExpressionConverter(global::System.Data.Entity.Core.Objects.ELinq.Funcletizer.CreateQueryFuncletizer(base.ObjectContext), this._expression);
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x000B0E34 File Offset: 0x000AF034
		private void ResetParameters()
		{
			if (base.Parameters != null)
			{
				bool isReadOnly = ((global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Objects.ObjectParameter>)base.Parameters).IsReadOnly;
				if (isReadOnly)
				{
					base.Parameters.SetReadOnly(false);
				}
				base.Parameters.Clear();
				if (isReadOnly)
				{
					base.Parameters.SetReadOnly(true);
				}
			}
			this._linqParameters = null;
		}

		// Token: 0x040011D4 RID: 4564
		private readonly global::System.Linq.Expressions.Expression _expression;

		// Token: 0x040011D5 RID: 4565
		private global::System.Func<bool> _recompileRequired;

		// Token: 0x040011D6 RID: 4566
		private global::System.Collections.Generic.IEnumerable<global::System.Tuple<global::System.Data.Entity.Core.Objects.ObjectParameter, global::System.Data.Entity.Core.Objects.ELinq.QueryParameterExpression>> _linqParameters;

		// Token: 0x040011D7 RID: 4567
		private bool _useCSharpNullComparisonBehavior;

		// Token: 0x040011D8 RID: 4568
		private bool _disableFilterOverProjectionSimplificationForCustomFunctions;

		// Token: 0x040011D9 RID: 4569
		private readonly global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory _objectQueryExecutionPlanFactory;
	}
}
