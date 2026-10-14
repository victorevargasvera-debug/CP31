using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041B RID: 1051
	public class ObjectQuery<T> : global::System.Data.Entity.Core.Objects.ObjectQuery, global::System.Linq.IOrderedQueryable<T>, global::System.Linq.IQueryable<T>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Linq.IOrderedQueryable, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x000A0DB9 File Offset: 0x0009EFB9
		private static bool IsLinqQuery(global::System.Data.Entity.Core.Objects.ObjectQuery query)
		{
			return query.QueryState is global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState;
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000A0DC9 File Offset: 0x0009EFC9
		public ObjectQuery(string commandText, global::System.Data.Entity.Core.Objects.ObjectContext context) : this(new global::System.Data.Entity.Core.Objects.EntitySqlQueryState(typeof(T), commandText, false, context, null, null))
		{
			context.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(T), global::System.Reflection.Assembly.GetCallingAssembly());
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000A0E00 File Offset: 0x0009F000
		public ObjectQuery(string commandText, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption) : this(new global::System.Data.Entity.Core.Objects.EntitySqlQueryState(typeof(T), commandText, false, context, null, null))
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			base.QueryState.UserSpecifiedMergeOption = new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption);
			context.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(T), global::System.Reflection.Assembly.GetCallingAssembly());
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000A0E58 File Offset: 0x0009F058
		internal ObjectQuery(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Objects.MergeOption mergeOption) : this(new global::System.Data.Entity.Core.Objects.EntitySqlQueryState(typeof(T), global::System.Data.Entity.Core.Objects.ObjectQuery<T>.BuildScanEntitySetEsql(entitySet), entitySet.Scan(), false, context, null, null, null))
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			base.QueryState.UserSpecifiedMergeOption = new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption);
			context.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(T), global::System.Reflection.Assembly.GetCallingAssembly());
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000A0EBC File Offset: 0x0009F0BC
		private static string BuildScanEntitySetEsql(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				global::System.Data.Entity.Core.EntityUtil.QuoteIdentifier(entitySet.EntityContainer.Name),
				global::System.Data.Entity.Core.EntityUtil.QuoteIdentifier(entitySet.Name)
			});
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000A0EF4 File Offset: 0x0009F0F4
		internal ObjectQuery(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState queryState)
		{
			this._name = "it";
			base..ctor(queryState);
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000A0F08 File Offset: 0x0009F108
		internal ObjectQuery()
		{
			this._name = "it";
			base..ctor();
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x000A0F1B File Offset: 0x0009F11B
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x000A0F23 File Offset: 0x0009F123
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<string>(value, "value");
				if (!global::System.Data.Entity.Core.Objects.ObjectParameter.ValidateParameterName(value))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectQuery_InvalidQueryName(value), "value");
				}
				this._name = value;
			}
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000A0F51 File Offset: 0x0009F151
		public new global::System.Data.Entity.Core.Objects.ObjectResult<T> Execute(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			return this.GetResults(new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption));
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000A0F65 File Offset: 0x0009F165
		public new global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>> ExecuteAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			return this.ExecuteAsync(mergeOption, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000A0F73 File Offset: 0x0009F173
		public new global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>> ExecuteAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			return this.GetResultsAsync(new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption), cancellationToken);
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000A0F88 File Offset: 0x0009F188
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Include(string path)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(base.QueryState.Include<T>(this, path));
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000A0FA8 File Offset: 0x0009F1A8
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Distinct()
		{
			if (global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(this))
			{
				return (global::System.Data.Entity.Core.Objects.ObjectQuery<T>)this.Distinct<T>();
			}
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Distinct(base.QueryState));
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000A0FD0 File Offset: 0x0009F1D0
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Except(global::System.Data.Entity.Core.Objects.ObjectQuery<T> query)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectQuery<T>>(query, "query");
			if (global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(this) || global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(query))
			{
				return (global::System.Data.Entity.Core.Objects.ObjectQuery<T>)this.Except(query);
			}
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Except(base.QueryState, query.QueryState));
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000A101C File Offset: 0x0009F21C
		public global::System.Data.Entity.Core.Objects.ObjectQuery<global::System.Data.Common.DbDataRecord> GroupBy(string keys, string projection, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(keys, "keys");
			global::System.Data.Entity.Utilities.Check.NotEmpty(projection, "projection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<global::System.Data.Common.DbDataRecord>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.GroupBy(base.QueryState, this.Name, keys, projection, parameters));
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000A105C File Offset: 0x0009F25C
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Intersect(global::System.Data.Entity.Core.Objects.ObjectQuery<T> query)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectQuery<T>>(query, "query");
			if (global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(this) || global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(query))
			{
				return (global::System.Data.Entity.Core.Objects.ObjectQuery<T>)this.Intersect(query);
			}
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Intersect(base.QueryState, query.QueryState));
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000A10A8 File Offset: 0x0009F2A8
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType> OfType<TResultType>()
		{
			if (global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(this))
			{
				return (global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType>)this.OfType<TResultType>();
			}
			base.QueryState.ObjectContext.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResultType), global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Type typeFromHandle = typeof(TResultType);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!base.QueryState.ObjectContext.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace).TryGetType(typeFromHandle.Name, typeFromHandle.NestingNamespace() ?? string.Empty, out edmType) || (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType) && !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(edmType)))
			{
				throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.ObjectQuery_QueryBuilder_InvalidResultType(typeof(TResultType).FullName));
			}
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.OfType(base.QueryState, edmType, typeFromHandle));
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x000A1168 File Offset: 0x0009F368
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> OrderBy(string keys, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(keys, "keys");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.OrderBy(base.QueryState, this.Name, keys, parameters));
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000A119A File Offset: 0x0009F39A
		public global::System.Data.Entity.Core.Objects.ObjectQuery<global::System.Data.Common.DbDataRecord> Select(string projection, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(projection, "projection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<global::System.Data.Common.DbDataRecord>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Select(base.QueryState, this.Name, projection, parameters));
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000A11CC File Offset: 0x0009F3CC
		public global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType> SelectValue<TResultType>(string projection, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(projection, "projection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			base.QueryState.ObjectContext.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TResultType), global::System.Reflection.Assembly.GetCallingAssembly());
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<TResultType>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.SelectValue(base.QueryState, this.Name, projection, parameters, typeof(TResultType)));
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000A1237 File Offset: 0x0009F437
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Skip(string keys, string count, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(keys, "keys");
			global::System.Data.Entity.Utilities.Check.NotEmpty(count, "count");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Skip(base.QueryState, this.Name, keys, count, parameters));
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000A1276 File Offset: 0x0009F476
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Top(string count, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(count, "count");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Top(base.QueryState, this.Name, count, parameters));
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000A129C File Offset: 0x0009F49C
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Union(global::System.Data.Entity.Core.Objects.ObjectQuery<T> query)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectQuery<T>>(query, "query");
			if (global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(this) || global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IsLinqQuery(query))
			{
				return (global::System.Data.Entity.Core.Objects.ObjectQuery<T>)this.Union(query);
			}
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Union(base.QueryState, query.QueryState));
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000A12E8 File Offset: 0x0009F4E8
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> UnionAll(global::System.Data.Entity.Core.Objects.ObjectQuery<T> query)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectQuery<T>>(query, "query");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.UnionAll(base.QueryState, query.QueryState));
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000A130C File Offset: 0x0009F50C
		public global::System.Data.Entity.Core.Objects.ObjectQuery<T> Where(string predicate, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(predicate, "predicate");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(global::System.Data.Entity.Core.Objects.Internal.EntitySqlQueryBuilder.Where(base.QueryState, this.Name, predicate, parameters));
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000A133E File Offset: 0x0009F53E
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			base.QueryState.ObjectContext.AsyncMonitor.EnsureNotEntered();
			return new global::System.Data.Entity.Internal.LazyEnumerator<T>(() => this.GetResults(null));
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000A1366 File Offset: 0x0009F566
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>.GetAsyncEnumerator()
		{
			base.QueryState.ObjectContext.AsyncMonitor.EnsureNotEntered();
			return new global::System.Data.Entity.Internal.LazyAsyncEnumerator<T>((global::System.Threading.CancellationToken cancellationToken) => this.GetResultsAsync(null, cancellationToken));
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000A138E File Offset: 0x0009F58E
		internal override global::System.Collections.IEnumerator GetEnumeratorInternal()
		{
			return ((global::System.Collections.Generic.IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000A1396 File Offset: 0x0009F596
		internal override global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumeratorInternal()
		{
			return ((global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>)this).GetAsyncEnumerator();
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000A13A0 File Offset: 0x0009F5A0
		internal override global::System.Collections.IList GetIListSourceListInternal()
		{
			return ((global::System.ComponentModel.IListSource)this.GetResults(null)).GetList();
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000A13C1 File Offset: 0x0009F5C1
		internal override global::System.Data.Entity.Core.Objects.ObjectResult ExecuteInternal(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			return this.GetResults(new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption));
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000A13D0 File Offset: 0x0009F5D0
		internal override async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult> ExecuteInternalAsync(global::System.Data.Entity.Core.Objects.MergeOption mergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			return await this.GetResultsAsync(new global::System.Data.Entity.Core.Objects.MergeOption?(mergeOption), cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<T>>();
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000A1428 File Offset: 0x0009F628
		internal override global::System.Linq.Expressions.Expression GetExpression()
		{
			global::System.Linq.Expressions.Expression expression;
			if (!base.QueryState.TryGetExpression(out expression))
			{
				expression = global::System.Linq.Expressions.Expression.Constant(this);
			}
			if (base.QueryState.UserSpecifiedMergeOption != null)
			{
				expression = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.EnsureType(expression, typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<T>));
				expression = global::System.Linq.Expressions.Expression.Call(expression, global::System.Data.Entity.Core.Objects.ObjectQuery<T>.MergeAsMethod, new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(base.QueryState.UserSpecifiedMergeOption.Value)
				});
			}
			if (base.QueryState.Span != null)
			{
				expression = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.EnsureType(expression, typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<T>));
				expression = global::System.Linq.Expressions.Expression.Call(expression, global::System.Data.Entity.Core.Objects.ObjectQuery<T>.IncludeSpanMethod, new global::System.Linq.Expressions.Expression[]
				{
					global::System.Linq.Expressions.Expression.Constant(base.QueryState.Span)
				});
			}
			return expression;
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000A14E7 File Offset: 0x0009F6E7
		internal global::System.Data.Entity.Core.Objects.ObjectQuery<T> MergeAs(global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_MethodNotDirectlyCallable);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000A14F3 File Offset: 0x0009F6F3
		internal global::System.Data.Entity.Core.Objects.ObjectQuery<T> IncludeSpan(global::System.Data.Entity.Core.Objects.Span span)
		{
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ELinq_MethodNotDirectlyCallable);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000A1500 File Offset: 0x0009F700
		private global::System.Data.Entity.Core.Objects.ObjectResult<T> GetResults(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption)
		{
			base.QueryState.ObjectContext.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = base.ExecutionStrategy ?? global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(base.QueryState.ObjectContext.Connection, base.QueryState.ObjectContext.MetadataWorkspace);
			if (executionStrategy.RetriesOnFailure && base.QueryState.EffectiveStreamingBehavior)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(executionStrategy.GetType().Name));
			}
			global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<T>> <>9__1;
			return executionStrategy.Execute<global::System.Data.Entity.Core.Objects.ObjectResult<T>>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContext = this.QueryState.ObjectContext;
				global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<T>> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => this.QueryState.GetExecutionPlan(forMergeOption).Execute<T>(this.QueryState.ObjectContext, this.QueryState.Parameters)));
				}
				return objectContext.ExecuteInTransaction<global::System.Data.Entity.Core.Objects.ObjectResult<T>>(func, executionStrategy, false, !this.QueryState.EffectiveStreamingBehavior);
			});
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000A15B8 File Offset: 0x0009F7B8
		private global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>> GetResultsAsync(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			base.QueryState.ObjectContext.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy dbExecutionStrategy = base.ExecutionStrategy ?? global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(base.QueryState.ObjectContext.Connection, base.QueryState.ObjectContext.MetadataWorkspace);
			if (dbExecutionStrategy.RetriesOnFailure && base.QueryState.EffectiveStreamingBehavior)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(dbExecutionStrategy.GetType().Name));
			}
			return this.GetResultsAsync(forMergeOption, dbExecutionStrategy, cancellationToken);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000A1648 File Offset: 0x0009F848
		private async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>> GetResultsAsync(global::System.Data.Entity.Core.Objects.MergeOption? forMergeOption, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Objects.MergeOption mergeOption = (forMergeOption != null) ? forMergeOption.Value : base.QueryState.EffectiveMergeOption;
			if (mergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				base.QueryState.ObjectContext.AsyncMonitor.Enter();
			}
			global::System.Data.Entity.Core.Objects.ObjectResult<T> result;
			try
			{
				global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>>> <>9__1;
				result = await executionStrategy.ExecuteAsync<global::System.Data.Entity.Core.Objects.ObjectResult<T>>(delegate()
				{
					global::System.Data.Entity.Core.Objects.ObjectContext objectContext = this.QueryState.ObjectContext;
					global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>>> func;
					if ((func = <>9__1) == null)
					{
						func = (<>9__1 = (() => this.QueryState.GetExecutionPlan(forMergeOption).ExecuteAsync<T>(this.QueryState.ObjectContext, this.QueryState.Parameters, cancellationToken)));
					}
					return objectContext.ExecuteInTransactionAsync<global::System.Data.Entity.Core.Objects.ObjectResult<T>>(func, executionStrategy, false, !this.QueryState.EffectiveStreamingBehavior, cancellationToken);
				}, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<T>>();
			}
			finally
			{
				if (mergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
				{
					base.QueryState.ObjectContext.AsyncMonitor.Exit();
				}
			}
			return result;
		}

		// Token: 0x04001082 RID: 4226
		internal static readonly global::System.Reflection.MethodInfo MergeAsMethod = typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<T>).GetOnlyDeclaredMethod("MergeAs");

		// Token: 0x04001083 RID: 4227
		internal static readonly global::System.Reflection.MethodInfo IncludeSpanMethod = typeof(global::System.Data.Entity.Core.Objects.ObjectQuery<T>).GetOnlyDeclaredMethod("IncludeSpan");

		// Token: 0x04001084 RID: 4228
		private const string DefaultName = "it";

		// Token: 0x04001085 RID: 4229
		private string _name;
	}
}
