using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure.Interception;

namespace System.Data.Entity.Internal.MockingProxies
{
	// Token: 0x0200013A RID: 314
	internal class EntityConnectionProxy
	{
		// Token: 0x060014D8 RID: 5336 RVA: 0x00035C52 File Offset: 0x00033E52
		protected EntityConnectionProxy()
		{
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x00035C5A File Offset: 0x00033E5A
		public EntityConnectionProxy(global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection)
		{
			this._entityConnection = entityConnection;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x00035C69 File Offset: 0x00033E69
		public static implicit operator global::System.Data.Entity.Core.EntityClient.EntityConnection(global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy proxy)
		{
			return proxy._entityConnection;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00035C71 File Offset: 0x00033E71
		public virtual global::System.Data.Common.DbConnection StoreConnection
		{
			get
			{
				return this._entityConnection.StoreConnection;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00035C7E File Offset: 0x00033E7E
		public virtual void Dispose()
		{
			this._entityConnection.Dispose();
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00035C8C File Offset: 0x00033E8C
		public virtual global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy CreateNew(global::System.Data.Common.DbConnection storeConnection)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = new global::System.Data.Entity.Core.EntityClient.EntityConnection(this._entityConnection.GetMetadataWorkspace(), storeConnection);
			global::System.Data.Entity.Core.EntityClient.EntityTransaction currentTransaction = this._entityConnection.CurrentTransaction;
			if (currentTransaction != null && global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetConnection(currentTransaction.StoreTransaction, this._entityConnection.InterceptionContext) == storeConnection)
			{
				entityConnection.UseStoreTransaction(currentTransaction.StoreTransaction);
			}
			return new global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy(entityConnection);
		}

		// Token: 0x040009C5 RID: 2501
		private readonly global::System.Data.Entity.Core.EntityClient.EntityConnection _entityConnection;
	}
}
