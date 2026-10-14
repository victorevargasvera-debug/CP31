using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x0200013C RID: 316
	internal class DbQueryProvider : global::System.Linq.IQueryProvider, global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x00035EC8 File Offset: 0x000340C8
		public DbQueryProvider(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Internal.Linq.IInternalQuery internalQuery)
		{
			this._internalContext = internalContext;
			this._internalQuery = internalQuery;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00035EE0 File Offset: 0x000340E0
		public virtual global::System.Linq.IQueryable<TElement> CreateQuery<TElement>(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = this.CreateObjectQuery(expression);
			if (typeof(TElement) != ((global::System.Linq.IQueryable)objectQuery).ElementType)
			{
				return (global::System.Linq.IQueryable<TElement>)this.CreateQuery(objectQuery);
			}
			return new global::System.Data.Entity.Infrastructure.DbQuery<TElement>(new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(this._internalContext, objectQuery));
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00035F36 File Offset: 0x00034136
		public virtual global::System.Linq.IQueryable CreateQuery(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			return this.CreateQuery(this.CreateObjectQuery(expression));
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00035F51 File Offset: 0x00034151
		public virtual TResult Execute<TResult>(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			this._internalContext.Initialize();
			return ((global::System.Linq.IQueryProvider)this._internalQuery.ObjectQueryProvider).Execute<TResult>(expression);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00035F7B File Offset: 0x0003417B
		public virtual object Execute(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			this._internalContext.Initialize();
			return ((global::System.Linq.IQueryProvider)this._internalQuery.ObjectQueryProvider).Execute(expression);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00035FA5 File Offset: 0x000341A5
		global::System.Threading.Tasks.Task<TResult> global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider.ExecuteAsync<TResult>(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			cancellationToken.ThrowIfCancellationRequested();
			this._internalContext.Initialize();
			return ((global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider)this._internalQuery.ObjectQueryProvider).ExecuteAsync<TResult>(expression, cancellationToken);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00035FD7 File Offset: 0x000341D7
		global::System.Threading.Tasks.Task<object> global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider.ExecuteAsync(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			cancellationToken.ThrowIfCancellationRequested();
			this._internalContext.Initialize();
			return ((global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider)this._internalQuery.ObjectQueryProvider).ExecuteAsync(expression, cancellationToken);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0003600C File Offset: 0x0003420C
		private global::System.Linq.IQueryable CreateQuery(global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery)
		{
			global::System.Data.Entity.Internal.Linq.IInternalQuery internalQuery = this.CreateInternalQuery(objectQuery);
			return (global::System.Linq.IQueryable)typeof(global::System.Data.Entity.Infrastructure.DbQuery<>).MakeGenericType(new global::System.Type[]
			{
				internalQuery.ElementType
			}).GetConstructors(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic).Single<global::System.Reflection.ConstructorInfo>().Invoke(new object[]
			{
				internalQuery
			});
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0003605F File Offset: 0x0003425F
		protected global::System.Data.Entity.Core.Objects.ObjectQuery CreateObjectQuery(global::System.Linq.Expressions.Expression expression)
		{
			expression = new global::System.Data.Entity.Internal.Linq.DbQueryVisitor().Visit(expression);
			return (global::System.Data.Entity.Core.Objects.ObjectQuery)((global::System.Linq.IQueryProvider)this._internalQuery.ObjectQueryProvider).CreateQuery(expression);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00036084 File Offset: 0x00034284
		protected global::System.Data.Entity.Internal.Linq.IInternalQuery CreateInternalQuery(global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery)
		{
			return (global::System.Data.Entity.Internal.Linq.IInternalQuery)typeof(global::System.Data.Entity.Internal.Linq.InternalQuery<>).MakeGenericType(new global::System.Type[]
			{
				((global::System.Linq.IQueryable)objectQuery).ElementType
			}).GetDeclaredConstructor(new global::System.Type[]
			{
				typeof(global::System.Data.Entity.Internal.InternalContext),
				typeof(global::System.Data.Entity.Core.Objects.ObjectQuery)
			}).Invoke(new object[]
			{
				this._internalContext,
				objectQuery
			});
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000360F1 File Offset: 0x000342F1
		public global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				return this._internalContext;
			}
		}

		// Token: 0x040009C8 RID: 2504
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x040009C9 RID: 2505
		private readonly global::System.Data.Entity.Internal.Linq.IInternalQuery _internalQuery;
	}
}
