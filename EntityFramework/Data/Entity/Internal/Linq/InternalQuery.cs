using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000146 RID: 326
	internal class InternalQuery<TElement> : global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement>, global::System.Data.Entity.Internal.Linq.IInternalQuery
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x00036639 File Offset: 0x00034839
		public InternalQuery(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			this._internalContext = internalContext;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00036648 File Offset: 0x00034848
		public InternalQuery(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery)
		{
			this._internalContext = internalContext;
			this._objectQuery = (global::System.Data.Entity.Core.Objects.ObjectQuery<TElement>)objectQuery;
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00036663 File Offset: 0x00034863
		public virtual void ResetQuery()
		{
			this._objectQuery = null;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x0003666C File Offset: 0x0003486C
		public virtual global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				return this._internalContext;
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00036674 File Offset: 0x00034874
		public virtual global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> Include(string path)
		{
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(this._internalContext, this._objectQuery.Include(path));
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0003668D File Offset: 0x0003488D
		public virtual global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> AsNoTracking()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(this._internalContext, (global::System.Data.Entity.Core.Objects.ObjectQuery)global::System.Data.Entity.Internal.DbHelpers.CreateNoTrackingQuery(this._objectQuery));
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000366AA File Offset: 0x000348AA
		public virtual global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> AsStreaming()
		{
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(this._internalContext, (global::System.Data.Entity.Core.Objects.ObjectQuery)global::System.Data.Entity.Internal.DbHelpers.CreateStreamingQuery(this._objectQuery));
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000366C7 File Offset: 0x000348C7
		public virtual global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			return new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(this._internalContext, (global::System.Data.Entity.Core.Objects.ObjectQuery)global::System.Data.Entity.Internal.DbHelpers.CreateQueryWithExecutionStrategy(this._objectQuery, executionStrategy));
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000366E5 File Offset: 0x000348E5
		public virtual global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> ObjectQuery
		{
			get
			{
				return this._objectQuery;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x000366ED File Offset: 0x000348ED
		global::System.Data.Entity.Core.Objects.ObjectQuery global::System.Data.Entity.Internal.Linq.IInternalQuery.ObjectQuery
		{
			get
			{
				return this.ObjectQuery;
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x000366F5 File Offset: 0x000348F5
		protected void InitializeQuery(global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> objectQuery)
		{
			this._objectQuery = objectQuery;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000366FE File Offset: 0x000348FE
		public virtual string ToTraceString()
		{
			return this._objectQuery.ToTraceString();
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0003670B File Offset: 0x0003490B
		public virtual global::System.Linq.Expressions.Expression Expression
		{
			get
			{
				return ((global::System.Linq.IQueryable)this._objectQuery).Expression;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00036718 File Offset: 0x00034918
		public virtual global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider ObjectQueryProvider
		{
			get
			{
				return this._objectQuery.ObjectQueryProvider;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00036725 File Offset: 0x00034925
		public global::System.Type ElementType
		{
			get
			{
				return typeof(TElement);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00036731 File Offset: 0x00034931
		public virtual global::System.Collections.Generic.IEnumerator<TElement> GetEnumerator()
		{
			this.InternalContext.Initialize();
			return ((global::System.Collections.Generic.IEnumerable<!0>)this._objectQuery).GetEnumerator();
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00036749 File Offset: 0x00034949
		global::System.Collections.IEnumerator global::System.Data.Entity.Internal.Linq.IInternalQuery.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00036751 File Offset: 0x00034951
		public virtual global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement> GetAsyncEnumerator()
		{
			this.InternalContext.Initialize();
			return ((global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TElement>)this._objectQuery).GetAsyncEnumerator();
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00036769 File Offset: 0x00034969
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Internal.Linq.IInternalQuery.GetAsyncEnumerator()
		{
			return this.GetAsyncEnumerator();
		}

		// Token: 0x040009CE RID: 2510
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x040009CF RID: 2511
		private global::System.Data.Entity.Core.Objects.ObjectQuery<TElement> _objectQuery;
	}
}
