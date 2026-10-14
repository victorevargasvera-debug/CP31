using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000144 RID: 324
	internal class InternalDbQuery<TElement> : global::System.Data.Entity.Infrastructure.DbQuery, global::System.Linq.IOrderedQueryable<TElement>, global::System.Linq.IQueryable<TElement>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Linq.IOrderedQueryable, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TElement>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x0003644C File Offset: 0x0003464C
		public InternalDbQuery(global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> internalQuery)
		{
			this._internalQuery = internalQuery;
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0003645B File Offset: 0x0003465B
		internal override global::System.Data.Entity.Internal.Linq.IInternalQuery InternalQuery
		{
			get
			{
				return this._internalQuery;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00036463 File Offset: 0x00034663
		public override global::System.Data.Entity.Infrastructure.DbQuery Include(string path)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TElement>(this._internalQuery.Include(path));
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00036482 File Offset: 0x00034682
		public override global::System.Data.Entity.Infrastructure.DbQuery AsNoTracking()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TElement>(this._internalQuery.AsNoTracking());
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00036494 File Offset: 0x00034694
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public override global::System.Data.Entity.Infrastructure.DbQuery AsStreaming()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TElement>(this._internalQuery.AsStreaming());
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000364A6 File Offset: 0x000346A6
		internal override global::System.Data.Entity.Infrastructure.DbQuery WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TElement>(this._internalQuery.WithExecutionStrategy(executionStrategy));
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000364B9 File Offset: 0x000346B9
		internal override global::System.Data.Entity.Internal.Linq.IInternalQuery GetInternalQueryWithCheck(string memberName)
		{
			return this._internalQuery;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000364C1 File Offset: 0x000346C1
		public global::System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
		{
			return this._internalQuery.GetEnumerator();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000364CE File Offset: 0x000346CE
		public global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement> GetAsyncEnumerator()
		{
			return this._internalQuery.GetAsyncEnumerator();
		}

		// Token: 0x040009CC RID: 2508
		private readonly global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> _internalQuery;
	}
}
