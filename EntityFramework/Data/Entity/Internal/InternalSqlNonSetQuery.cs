using System;
using System.Collections;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200011E RID: 286
	internal class InternalSqlNonSetQuery : global::System.Data.Entity.Internal.InternalSqlQuery
	{
		// Token: 0x06001421 RID: 5153 RVA: 0x00033564 File Offset: 0x00031764
		internal InternalSqlNonSetQuery(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Type elementType, string sql, object[] parameters) : this(internalContext, elementType, sql, null, parameters)
		{
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x00033585 File Offset: 0x00031785
		private InternalSqlNonSetQuery(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Type elementType, string sql, bool? streaming, object[] parameters) : base(sql, streaming, parameters)
		{
			this._internalContext = internalContext;
			this._elementType = elementType;
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000335A0 File Offset: 0x000317A0
		public override global::System.Data.Entity.Internal.InternalSqlQuery AsNoTracking()
		{
			return this;
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x000335A4 File Offset: 0x000317A4
		public override global::System.Data.Entity.Internal.InternalSqlQuery AsStreaming()
		{
			if (base.Streaming == null || !base.Streaming.Value)
			{
				return new global::System.Data.Entity.Internal.InternalSqlNonSetQuery(this._internalContext, this._elementType, base.Sql, new bool?(true), base.Parameters);
			}
			return this;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x000335F6 File Offset: 0x000317F6
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._internalContext.ExecuteSqlQuery(this._elementType, base.Sql, base.Streaming, base.Parameters);
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003361B File Offset: 0x0003181B
		public override global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumerator()
		{
			return this._internalContext.ExecuteSqlQueryAsync(this._elementType, base.Sql, base.Streaming, base.Parameters);
		}

		// Token: 0x0400097D RID: 2429
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x0400097E RID: 2430
		private readonly global::System.Type _elementType;
	}
}
