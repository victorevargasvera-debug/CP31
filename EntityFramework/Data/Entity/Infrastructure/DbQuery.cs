using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Resources;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000231 RID: 561
	[global::System.Diagnostics.DebuggerDisplay("{DebuggerDisplay()}")]
	public abstract class DbQuery : global::System.Linq.IOrderedQueryable, global::System.Linq.IQueryable, global::System.Collections.IEnumerable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06001D70 RID: 7536 RVA: 0x0005271B File Offset: 0x0005091B
		internal DbQuery()
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00052723 File Offset: 0x00050923
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00052726 File Offset: 0x00050926
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			throw global::System.Data.Entity.Resources.Error.DbQuery_BindingToDbQueryNotSupported();
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0005272D File Offset: 0x0005092D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetInternalQueryWithCheck("IEnumerable.GetEnumerator").GetEnumerator();
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0005273F File Offset: 0x0005093F
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this.GetInternalQueryWithCheck("IDbAsyncEnumerable.GetAsyncEnumerator").GetAsyncEnumerator();
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00052751 File Offset: 0x00050951
		public virtual global::System.Type ElementType
		{
			get
			{
				return this.GetInternalQueryWithCheck("ElementType").ElementType;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00052763 File Offset: 0x00050963
		global::System.Linq.Expressions.Expression global::System.Linq.IQueryable.Expression
		{
			get
			{
				return this.GetInternalQueryWithCheck("IQueryable.Expression").Expression;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00052778 File Offset: 0x00050978
		global::System.Linq.IQueryProvider global::System.Linq.IQueryable.Provider
		{
			get
			{
				global::System.Linq.IQueryProvider result;
				if ((result = this._provider) == null)
				{
					result = (this._provider = new global::System.Data.Entity.Internal.Linq.NonGenericDbQueryProvider(this.GetInternalQueryWithCheck("IQueryable.Provider").InternalContext, this.GetInternalQueryWithCheck("IQueryable.Provider")));
				}
				return result;
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x000527B8 File Offset: 0x000509B8
		public virtual global::System.Data.Entity.Infrastructure.DbQuery Include(string path)
		{
			return this;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x000527BB File Offset: 0x000509BB
		public virtual global::System.Data.Entity.Infrastructure.DbQuery AsNoTracking()
		{
			return this;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x000527BE File Offset: 0x000509BE
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public virtual global::System.Data.Entity.Infrastructure.DbQuery AsStreaming()
		{
			return this;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x000527C1 File Offset: 0x000509C1
		internal virtual global::System.Data.Entity.Infrastructure.DbQuery WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			return this;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x000527C4 File Offset: 0x000509C4
		public global::System.Data.Entity.Infrastructure.DbQuery<TElement> Cast<TElement>()
		{
			if (this.InternalQuery == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.TestDoublesCannotBeConverted);
			}
			if (typeof(TElement) != this.InternalQuery.ElementType)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntity_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbQuery).Name, typeof(TElement).Name, this.InternalQuery.ElementType.Name);
			}
			return new global::System.Data.Entity.Infrastructure.DbQuery<TElement>((global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement>)this.InternalQuery);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00052844 File Offset: 0x00050A44
		public override string ToString()
		{
			if (this.InternalQuery != null)
			{
				return this.InternalQuery.ToTraceString();
			}
			return base.ToString();
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00052860 File Offset: 0x00050A60
		private string DebuggerDisplay()
		{
			return base.ToString();
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00052868 File Offset: 0x00050A68
		public string Sql
		{
			get
			{
				return this.ToString();
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00052870 File Offset: 0x00050A70
		internal virtual global::System.Data.Entity.Internal.Linq.IInternalQuery InternalQuery
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x00052873 File Offset: 0x00050A73
		internal virtual global::System.Data.Entity.Internal.Linq.IInternalQuery GetInternalQueryWithCheck(string memberName)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0005289A File Offset: 0x00050A9A
		global::System.Data.Entity.Internal.Linq.IInternalQuery global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter.InternalQuery
		{
			get
			{
				return this.InternalQuery;
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000528A2 File Offset: 0x00050AA2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000528AB File Offset: 0x00050AAB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000528B3 File Offset: 0x00050AB3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B23 RID: 2851
		private global::System.Linq.IQueryProvider _provider;
	}
}
