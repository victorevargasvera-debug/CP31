using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000145 RID: 325
	internal class InternalDbSet<TEntity> : global::System.Data.Entity.DbSet, global::System.Linq.IQueryable<TEntity>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable where TEntity : class
	{
		// Token: 0x06001527 RID: 5415 RVA: 0x000364DB File Offset: 0x000346DB
		public InternalDbSet(global::System.Data.Entity.Internal.Linq.IInternalSet<TEntity> internalSet)
		{
			this._internalSet = internalSet;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000364EA File Offset: 0x000346EA
		public static global::System.Data.Entity.Internal.Linq.InternalDbSet<TEntity> Create(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Internal.Linq.IInternalSet internalSet)
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbSet<TEntity>(((global::System.Data.Entity.Internal.Linq.IInternalSet<TEntity>)internalSet) ?? new global::System.Data.Entity.Internal.Linq.InternalSet<TEntity>(internalContext));
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00036501 File Offset: 0x00034701
		internal override global::System.Data.Entity.Internal.Linq.IInternalQuery InternalQuery
		{
			get
			{
				return this._internalSet;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00036509 File Offset: 0x00034709
		internal override global::System.Data.Entity.Internal.Linq.IInternalSet InternalSet
		{
			get
			{
				return this._internalSet;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00036511 File Offset: 0x00034711
		public override global::System.Data.Entity.Infrastructure.DbQuery Include(string path)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TEntity>(this._internalSet.Include(path));
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00036530 File Offset: 0x00034730
		public override global::System.Data.Entity.Infrastructure.DbQuery AsNoTracking()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TEntity>(this._internalSet.AsNoTracking());
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00036542 File Offset: 0x00034742
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public override global::System.Data.Entity.Infrastructure.DbQuery AsStreaming()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TEntity>(this._internalSet.AsStreaming());
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00036554 File Offset: 0x00034754
		internal override global::System.Data.Entity.Infrastructure.DbQuery WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TEntity>(this._internalSet.WithExecutionStrategy(executionStrategy));
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00036567 File Offset: 0x00034767
		public override object Find(params object[] keyValues)
		{
			return this._internalSet.Find(keyValues);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003657A File Offset: 0x0003477A
		internal override global::System.Data.Entity.Internal.Linq.IInternalQuery GetInternalQueryWithCheck(string memberName)
		{
			return this._internalSet;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00036582 File Offset: 0x00034782
		internal override global::System.Data.Entity.Internal.Linq.IInternalSet GetInternalSetWithCheck(string memberName)
		{
			return this._internalSet;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0003658C File Offset: 0x0003478C
		public override async global::System.Threading.Tasks.Task<object> FindAsync(global::System.Threading.CancellationToken cancellationToken, params object[] keyValues)
		{
			global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity> cultureAwaiter = this._internalSet.FindAsync(cancellationToken, keyValues).WithCurrentCulture<TEntity>().GetAwaiter();
			if (!cultureAwaiter.IsCompleted)
			{
				await cultureAwaiter;
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity> cultureAwaiter2;
				cultureAwaiter = cultureAwaiter2;
				cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<TEntity>);
			}
			return cultureAwaiter.GetResult();
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x000365E1 File Offset: 0x000347E1
		public override global::System.Collections.IList Local
		{
			get
			{
				return this._internalSet.Local;
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x000365EE File Offset: 0x000347EE
		public override object Create()
		{
			return this._internalSet.Create();
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00036600 File Offset: 0x00034800
		public override object Create(global::System.Type derivedEntityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(derivedEntityType, "derivedEntityType");
			return this._internalSet.Create(derivedEntityType);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0003661F File Offset: 0x0003481F
		public global::System.Collections.Generic.IEnumerator<TEntity> GetEnumerator()
		{
			return this._internalSet.GetEnumerator();
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0003662C File Offset: 0x0003482C
		public global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> GetAsyncEnumerator()
		{
			return this._internalSet.GetAsyncEnumerator();
		}

		// Token: 0x040009CD RID: 2509
		private readonly global::System.Data.Entity.Internal.Linq.IInternalSet<TEntity> _internalSet;
	}
}
