using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000233 RID: 563
	public class DbRawSqlQuery : global::System.Collections.IEnumerable, global::System.ComponentModel.IListSource, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06001D9E RID: 7582 RVA: 0x00052AAB File Offset: 0x00050CAB
		internal DbRawSqlQuery(global::System.Data.Entity.Internal.InternalSqlQuery internalQuery)
		{
			this._internalQuery = internalQuery;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00052ABA File Offset: 0x00050CBA
		[global::System.Obsolete("Queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public virtual global::System.Data.Entity.Infrastructure.DbRawSqlQuery AsStreaming()
		{
			if (this._internalQuery != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbRawSqlQuery(this._internalQuery.AsStreaming());
			}
			return this;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00052AD6 File Offset: 0x00050CD6
		public virtual global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.GetInternalQueryWithCheck("GetEnumerator").GetEnumerator();
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00052AE8 File Offset: 0x00050CE8
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
		{
			return this.GetInternalQueryWithCheck("IDbAsyncEnumerable.GetAsyncEnumerator").GetAsyncEnumerator();
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x00052AFA File Offset: 0x00050CFA
		public virtual global::System.Threading.Tasks.Task ForEachAsync(global::System.Action<object> action)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<object>>(action, "action");
			return this.ForEachAsync(action, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00052B14 File Offset: 0x00050D14
		public virtual global::System.Threading.Tasks.Task ForEachAsync(global::System.Action<object> action, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<object>>(action, "action");
			return this.ForEachAsync(action, cancellationToken);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00052B2A File Offset: 0x00050D2A
		public virtual global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<object>> ToListAsync()
		{
			return this.ToListAsync<object>();
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00052B32 File Offset: 0x00050D32
		public virtual global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<object>> ToListAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ToListAsync(cancellationToken);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00052B3B File Offset: 0x00050D3B
		public override string ToString()
		{
			if (this._internalQuery != null)
			{
				return this._internalQuery.ToString();
			}
			return base.ToString();
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00052B57 File Offset: 0x00050D57
		internal global::System.Data.Entity.Internal.InternalSqlQuery InternalQuery
		{
			get
			{
				return this._internalQuery;
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00052B5F File Offset: 0x00050D5F
		private global::System.Data.Entity.Internal.InternalSqlQuery GetInternalQueryWithCheck(string memberName)
		{
			if (this._internalQuery == null)
			{
				throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.Infrastructure.DbSqlQuery).Name));
			}
			return this._internalQuery;
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00052B95 File Offset: 0x00050D95
		bool global::System.ComponentModel.IListSource.ContainsListCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x00052B98 File Offset: 0x00050D98
		global::System.Collections.IList global::System.ComponentModel.IListSource.GetList()
		{
			throw global::System.Data.Entity.Resources.Error.DbQuery_BindingToDbQueryNotSupported();
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00052B9F File Offset: 0x00050D9F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00052BA8 File Offset: 0x00050DA8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x00052BB0 File Offset: 0x00050DB0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B26 RID: 2854
		private readonly global::System.Data.Entity.Internal.InternalSqlQuery _internalQuery;
	}
}
