using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Core.Common.QueryCache;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200040D RID: 1037
	internal sealed class EntitySqlQueryState : global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState
	{
		// Token: 0x0600313A RID: 12602 RVA: 0x0009C068 File Offset: 0x0009A268
		internal EntitySqlQueryState(global::System.Type elementType, string commandText, bool allowsLimit, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameters, global::System.Data.Entity.Core.Objects.Span span) : this(elementType, commandText, null, allowsLimit, context, parameters, span, null)
		{
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0009C088 File Offset: 0x0009A288
		internal EntitySqlQueryState(global::System.Type elementType, string commandText, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, bool allowsLimit, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.ObjectParameterCollection parameters, global::System.Data.Entity.Core.Objects.Span span, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory = null) : base(elementType, context, parameters, span)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(commandText, "commandText");
			this._queryText = commandText;
			this._queryExpression = expression;
			this._allowsLimit = allowsLimit;
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x0009C0D6 File Offset: 0x0009A2D6
		internal bool AllowsLimitSubclause
		{
			get
			{
				return this._allowsLimit;
			}
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x0009C0DE File Offset: 0x0009A2DE
		internal override bool TryGetCommandText(out string commandText)
		{
			commandText = this._queryText;
			return true;
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x0009C0E9 File Offset: 0x0009A2E9
		internal override bool TryGetExpression(out global::System.Linq.Expressions.Expression expression)
		{
			expression = null;
			return false;
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x0009C0EF File Offset: 0x0009A2EF
		protected override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetResultType()
		{
			return this.Parse().ResultType;
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0009C0FC File Offset: 0x0009A2FC
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState Include<TElementType>(global::System.Data.Entity.Core.Objects.ObjectQuery<TElementType> sourceQuery, string includePath)
		{
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState objectQueryState = new global::System.Data.Entity.Core.Objects.EntitySqlQueryState(base.ElementType, this._queryText, this._queryExpression, this._allowsLimit, base.ObjectContext, global::System.Data.Entity.Core.Objects.ObjectParameterCollection.DeepCopy(base.Parameters), global::System.Data.Entity.Core.Objects.Span.IncludeIn(base.Span, includePath), null);
			base.ApplySettingsTo(objectQueryState);
			return objectQueryState;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0009C150 File Offset: 0x0009A350
		internal override global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan GetExecutionPlan(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption)
		{
			global::System.Data.Entity.Core.Objects.MergeOption mergeOption = global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState.EnsureMergeOption(new global::System.Data.Entity.Core.Objects.MergeOption?[]
			{
				forMergeOption,
				base.UserSpecifiedMergeOption
			});
			global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan = this._cachedPlan;
			if (objectQueryExecutionPlan != null)
			{
				if (objectQueryExecutionPlan.MergeOption == mergeOption && objectQueryExecutionPlan.Streaming == base.EffectiveStreamingBehavior)
				{
					return objectQueryExecutionPlan;
				}
				objectQueryExecutionPlan = null;
			}
			global::System.Data.Entity.Core.Common.QueryCache.QueryCacheManager queryCacheManager = null;
			global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey entitySqlQueryCacheKey = null;
			if (base.PlanCachingEnabled)
			{
				entitySqlQueryCacheKey = new global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey(base.ObjectContext.DefaultContainerName, this._queryText, (base.Parameters == null) ? 0 : base.Parameters.Count, (base.Parameters == null) ? null : base.Parameters.GetCacheKey(), (base.Span == null) ? null : base.Span.GetCacheKey(), mergeOption, base.EffectiveStreamingBehavior, base.ElementType);
				queryCacheManager = base.ObjectContext.MetadataWorkspace.GetQueryCacheManager();
				global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan objectQueryExecutionPlan2 = null;
				if (queryCacheManager.TryCacheLookup<global::System.Data.Entity.Core.Common.QueryCache.EntitySqlQueryCacheKey, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan>(entitySqlQueryCacheKey, out objectQueryExecutionPlan2))
				{
					objectQueryExecutionPlan = objectQueryExecutionPlan2;
				}
			}
			if (objectQueryExecutionPlan == null)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = this.Parse();
				global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(base.ObjectContext.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, query, true, false);
				objectQueryExecutionPlan = this._objectQueryExecutionPlanFactory.Prepare(base.ObjectContext, tree, base.ElementType, mergeOption, base.EffectiveStreamingBehavior, base.Span, null, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.AliasGenerator);
				if (entitySqlQueryCacheKey != null)
				{
					global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry inQueryCacheEntry = new global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry(entitySqlQueryCacheKey, objectQueryExecutionPlan);
					global::System.Data.Entity.Core.Common.QueryCache.QueryCacheEntry queryCacheEntry = null;
					if (queryCacheManager.TryLookupAndAdd(inQueryCacheEntry, out queryCacheEntry))
					{
						objectQueryExecutionPlan = (global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan)queryCacheEntry.GetTarget();
					}
				}
			}
			if (base.Parameters != null)
			{
				base.Parameters.SetReadOnly(true);
			}
			this._cachedPlan = objectQueryExecutionPlan;
			return objectQueryExecutionPlan;
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Parse()
		{
			if (this._queryExpression != null)
			{
				return this._queryExpression;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression> list = null;
			if (base.Parameters != null)
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.DbParameterReferenceExpression>(base.Parameters.Count);
				foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in base.Parameters)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = objectParameter.TypeUsage;
					if (typeUsage == null)
					{
						base.ObjectContext.Perspective.TryGetTypeByName(objectParameter.MappableType.FullNameWithNesting(), false, out typeUsage);
					}
					list.Add(typeUsage.Parameter(objectParameter.Name));
				}
			}
			return global::System.Data.Entity.Core.Common.EntitySql.CqlQuery.CompileQueryCommandLambda(this._queryText, base.ObjectContext.Perspective, null, list, null).Body;
		}

		// Token: 0x0400103B RID: 4155
		private readonly string _queryText;

		// Token: 0x0400103C RID: 4156
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _queryExpression;

		// Token: 0x0400103D RID: 4157
		private readonly bool _allowsLimit;

		// Token: 0x0400103E RID: 4158
		private readonly global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory _objectQueryExecutionPlanFactory;
	}
}
