using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.ELinq
{
	// Token: 0x02000465 RID: 1125
	internal class ObjectQueryProvider : global::System.Linq.IQueryProvider, global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
	{
		// Token: 0x06003777 RID: 14199 RVA: 0x000B38F1 File Offset: 0x000B1AF1
		internal ObjectQueryProvider(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			this._context = context;
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x000B3900 File Offset: 0x000B1B00
		internal ObjectQueryProvider(global::System.Data.Entity.Core.Objects.ObjectQuery query) : this(query.Context)
		{
			this._query = query;
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x000B3915 File Offset: 0x000B1B15
		internal virtual global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> CreateQuery<TElement>(global::System.Linq.Expressions.Expression expression)
		{
			return this.GetObjectQueryState(this._query, expression, typeof(TElement)).CreateObjectQuery<TElement>();
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x000B3933 File Offset: 0x000B1B33
		internal virtual global::System.Data.Entity.Core.Objects.ObjectQuery CreateQuery(global::System.Linq.Expressions.Expression expression, global::System.Type ofType)
		{
			return this.GetObjectQueryState(this._query, expression, ofType).CreateQuery();
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x000B3948 File Offset: 0x000B1B48
		private global::System.Data.Entity.Core.Objects.Internal.ObjectQueryState GetObjectQueryState(global::System.Data.Entity.Core.Objects.ObjectQuery query, global::System.Linq.Expressions.Expression expression, global::System.Type ofType)
		{
			if (query != null)
			{
				return new global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState(ofType, this._query, expression, null);
			}
			return new global::System.Data.Entity.Core.Objects.ELinq.ELinqQueryState(ofType, this._context, expression, null);
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x000B396A File Offset: 0x000B1B6A
		global::System.Linq.IQueryable<TElement> global::System.Linq.IQueryProvider.CreateQuery<TElement>(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			if (!typeof(global::System.Linq.IQueryable<TElement>).IsAssignableFrom(expression.Type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ELinq_ExpressionMustBeIQueryable, "expression");
			}
			return this.CreateQuery<TElement>(expression);
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x000B39A6 File Offset: 0x000B1BA6
		TResult global::System.Linq.IQueryProvider.Execute<TResult>(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.ExecuteSingle<TResult>(this.CreateQuery<TResult>(expression), expression);
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x000B39C4 File Offset: 0x000B1BC4
		global::System.Linq.IQueryable global::System.Linq.IQueryProvider.CreateQuery(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			if (!typeof(global::System.Linq.IQueryable).IsAssignableFrom(expression.Type))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ELinq_ExpressionMustBeIQueryable, "expression");
			}
			global::System.Type elementType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetElementType(expression.Type);
			return this.CreateQuery(expression, elementType);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x000B3A18 File Offset: 0x000B1C18
		object global::System.Linq.IQueryProvider.Execute(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.ExecuteSingle<object>(this.CreateQuery(expression, expression.Type).Cast<object>(), expression);
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x000B3A3E File Offset: 0x000B1C3E
		global::System.Threading.Tasks.Task<TResult> global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider.ExecuteAsync<TResult>(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			cancellationToken.ThrowIfCancellationRequested();
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.ExecuteSingleAsync<TResult>(this.CreateQuery<TResult>(expression), expression, cancellationToken);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x000B3A61 File Offset: 0x000B1C61
		global::System.Threading.Tasks.Task<object> global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider.ExecuteAsync(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			cancellationToken.ThrowIfCancellationRequested();
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.ExecuteSingleAsync<object>(this.CreateQuery(expression, expression.Type).Cast<object>(), expression, cancellationToken);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x000B3A8F File Offset: 0x000B1C8F
		internal static TResult ExecuteSingle<TResult>(global::System.Collections.Generic.IEnumerable<TResult> query, global::System.Linq.Expressions.Expression queryRoot)
		{
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.GetElementFunction<TResult>(queryRoot)(query);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
		private static global::System.Func<global::System.Collections.Generic.IEnumerable<TResult>, TResult> GetElementFunction<TResult>(global::System.Linq.Expressions.Expression queryRoot)
		{
			global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod;
			if (global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryIdentifySequenceMethod(queryRoot, true, out sequenceMethod))
			{
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First <= 1)
				{
					return (global::System.Collections.Generic.IEnumerable<TResult> sequence) => sequence.First<TResult>();
				}
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault <= 1)
				{
					return (global::System.Collections.Generic.IEnumerable<TResult> sequence) => sequence.FirstOrDefault<TResult>();
				}
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault <= 1)
				{
					return (global::System.Collections.Generic.IEnumerable<TResult> sequence) => sequence.SingleOrDefault<TResult>();
				}
			}
			return (global::System.Collections.Generic.IEnumerable<TResult> sequence) => sequence.Single<TResult>();
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000B3B4E File Offset: 0x000B1D4E
		internal static global::System.Threading.Tasks.Task<TResult> ExecuteSingleAsync<TResult>(global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> query, global::System.Linq.Expressions.Expression queryRoot, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider.GetAsyncElementFunction<TResult>(queryRoot)(query, cancellationToken);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000B3B60 File Offset: 0x000B1D60
		private static global::System.Func<global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult>, global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<TResult>> GetAsyncElementFunction<TResult>(global::System.Linq.Expressions.Expression queryRoot)
		{
			global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod sequenceMethod;
			if (global::System.Data.Entity.Core.Objects.ELinq.ReflectionUtil.TryIdentifySequenceMethod(queryRoot, true, out sequenceMethod))
			{
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.First <= 1)
				{
					return (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> sequence, global::System.Threading.CancellationToken cancellationToken) => sequence.FirstAsync(cancellationToken);
				}
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.FirstOrDefault <= 1)
				{
					return (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> sequence, global::System.Threading.CancellationToken cancellationToken) => sequence.FirstOrDefaultAsync(cancellationToken);
				}
				if (sequenceMethod - global::System.Data.Entity.Core.Objects.ELinq.SequenceMethod.SingleOrDefault <= 1)
				{
					return (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> sequence, global::System.Threading.CancellationToken cancellationToken) => sequence.SingleOrDefaultAsync(cancellationToken);
				}
			}
			return (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> sequence, global::System.Threading.CancellationToken cancellationToken) => sequence.SingleAsync(cancellationToken);
		}

		// Token: 0x0400121F RID: 4639
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _context;

		// Token: 0x04001220 RID: 4640
		private readonly global::System.Data.Entity.Core.Objects.ObjectQuery _query;
	}
}
