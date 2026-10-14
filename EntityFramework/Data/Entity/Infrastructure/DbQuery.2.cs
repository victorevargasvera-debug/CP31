using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000232 RID: 562
	[global::System.Diagnostics.DebuggerDisplay("{DebuggerDisplay()}")]
	public class DbQuery<TResult> : global::System.Linq.IOrderedQueryable<TResult>, global::System.Linq.IQueryable<TResult>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Linq.IOrderedQueryable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06001D86 RID: 7558 RVA: 0x000528BB File Offset: 0x00050ABB
		internal DbQuery(global::System.Data.Entity.Internal.Linq.IInternalQuery<TResult> internalQuery)
		{
			this._internalQuery = internalQuery;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000528CA File Offset: 0x00050ACA
		public virtual global::System.Data.Entity.Infrastructure.DbQuery<TResult> Include(string path)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbQuery<TResult>(this._internalQuery.Include(path));
			}
			return this;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000528F3 File Offset: 0x00050AF3
		public virtual global::System.Data.Entity.Infrastructure.DbQuery<TResult> AsNoTracking()
		{
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbQuery<TResult>(this._internalQuery.AsNoTracking());
			}
			return this;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0005290F File Offset: 0x00050B0F
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public virtual global::System.Data.Entity.Infrastructure.DbQuery<TResult> AsStreaming()
		{
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbQuery<TResult>(this._internalQuery.AsStreaming());
			}
			return this;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0005292B File Offset: 0x00050B2B
		internal virtual global::System.Data.Entity.Infrastructure.DbQuery<TResult> WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbQuery<TResult>(this._internalQuery.WithExecutionStrategy(executionStrategy));
			}
			return this;
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00052948 File Offset: 0x00050B48
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0005294B File Offset: 0x00050B4B
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			throw global::System.Data.Entity.Resources.Error.DbQuery_BindingToDbQueryNotSupported();
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00052952 File Offset: 0x00050B52
		global::System.Collections.Generic.IEnumerator<TResult> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this.GetInternalQueryWithCheck("IEnumerable<TResult>.GetEnumerator").GetEnumerator();
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00052964 File Offset: 0x00050B64
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetInternalQueryWithCheck("IEnumerable.GetEnumerator").GetEnumerator();
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00052976 File Offset: 0x00050B76
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this.GetInternalQueryWithCheck("IDbAsyncEnumerable.GetAsyncEnumerator").GetAsyncEnumerator();
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00052988 File Offset: 0x00050B88
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TResult> global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>.GetAsyncEnumerator()
		{
			return this.GetInternalQueryWithCheck("IDbAsyncEnumerable<TResult>.GetAsyncEnumerator").GetAsyncEnumerator();
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0005299A File Offset: 0x00050B9A
		global::System.Type global::System.Linq.IQueryable.ElementType
		{
			get
			{
				return this.GetInternalQueryWithCheck("IQueryable.ElementType").ElementType;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000529AC File Offset: 0x00050BAC
		global::System.Linq.Expressions.Expression global::System.Linq.IQueryable.Expression
		{
			get
			{
				return this.GetInternalQueryWithCheck("IQueryable.Expression").Expression;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x000529C0 File Offset: 0x00050BC0
		global::System.Linq.IQueryProvider global::System.Linq.IQueryable.Provider
		{
			get
			{
				global::System.Linq.IQueryProvider result;
				if ((result = this._provider) == null)
				{
					result = (this._provider = new global::System.Data.Entity.Internal.Linq.DbQueryProvider(this.GetInternalQueryWithCheck("IQueryable.Provider").InternalContext, this.GetInternalQueryWithCheck("IQueryable.Provider")));
				}
				return result;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x00052A00 File Offset: 0x00050C00
		global::System.Data.Entity.Internal.Linq.IInternalQuery global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter.InternalQuery
		{
			get
			{
				return this._internalQuery;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00052A08 File Offset: 0x00050C08
		internal global::System.Data.Entity.Internal.Linq.IInternalQuery<TResult> InternalQuery
		{
			get
			{
				return this._internalQuery;
			}
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00052A10 File Offset: 0x00050C10
		private global::System.Data.Entity.Internal.Linq.IInternalQuery<TResult> GetInternalQueryWithCheck(string memberName)
		{
			if (this._internalQuery == null)
			{
				throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.DbSet<>).Name));
			}
			return this._internalQuery;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00052A46 File Offset: 0x00050C46
		public override string ToString()
		{
			if (this._internalQuery != null)
			{
				return this._internalQuery.ToTraceString();
			}
			return base.ToString();
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00052A62 File Offset: 0x00050C62
		private string DebuggerDisplay()
		{
			return base.ToString();
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00052A6A File Offset: 0x00050C6A
		public string Sql
		{
			get
			{
				return this.ToString();
			}
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00052A72 File Offset: 0x00050C72
		public static implicit operator global::System.Data.Entity.Infrastructure.DbQuery(global::System.Data.Entity.Infrastructure.DbQuery<TResult> entry)
		{
			if (entry._internalQuery == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.TestDoublesCannotBeConverted);
			}
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TResult>(entry._internalQuery);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00052A92 File Offset: 0x00050C92
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00052A9B File Offset: 0x00050C9B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00052AA3 File Offset: 0x00050CA3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B24 RID: 2852
		private readonly global::System.Data.Entity.Internal.Linq.IInternalQuery<TResult> _internalQuery;

		// Token: 0x04000B25 RID: 2853
		private global::System.Linq.IQueryProvider _provider;
	}
}
