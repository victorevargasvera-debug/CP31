using System;
using System.Collections;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000120 RID: 288
	internal class InternalSqlSetQuery : global::System.Data.Entity.Internal.InternalSqlQuery
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x00033680 File Offset: 0x00031880
		internal InternalSqlSetQuery(global::System.Data.Entity.Internal.Linq.IInternalSet set, string sql, bool isNoTracking, object[] parameters) : this(set, sql, isNoTracking, null, parameters)
		{
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000336A1 File Offset: 0x000318A1
		private InternalSqlSetQuery(global::System.Data.Entity.Internal.Linq.IInternalSet set, string sql, bool isNoTracking, bool? streaming, object[] parameters) : base(sql, streaming, parameters)
		{
			this._set = set;
			this._isNoTracking = isNoTracking;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x000336BC File Offset: 0x000318BC
		public override global::System.Data.Entity.Internal.InternalSqlQuery AsNoTracking()
		{
			if (!this._isNoTracking)
			{
				return new global::System.Data.Entity.Internal.InternalSqlSetQuery(this._set, base.Sql, true, base.Streaming, base.Parameters);
			}
			return this;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000336E6 File Offset: 0x000318E6
		public bool IsNoTracking
		{
			get
			{
				return this._isNoTracking;
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x000336F0 File Offset: 0x000318F0
		public override global::System.Data.Entity.Internal.InternalSqlQuery AsStreaming()
		{
			if (base.Streaming == null || !base.Streaming.Value)
			{
				return new global::System.Data.Entity.Internal.InternalSqlSetQuery(this._set, base.Sql, this._isNoTracking, new bool?(true), base.Parameters);
			}
			return this;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00033742 File Offset: 0x00031942
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._set.ExecuteSqlQuery(base.Sql, this._isNoTracking, base.Streaming, base.Parameters);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00033767 File Offset: 0x00031967
		public override global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumerator()
		{
			return this._set.ExecuteSqlQueryAsync(base.Sql, this._isNoTracking, base.Streaming, base.Parameters);
		}

		// Token: 0x04000982 RID: 2434
		private readonly global::System.Data.Entity.Internal.Linq.IInternalSet _set;

		// Token: 0x04000983 RID: 2435
		private readonly bool _isNoTracking;
	}
}
