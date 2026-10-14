using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FB RID: 251
	internal class EagerInternalConnection : global::System.Data.Entity.Internal.InternalConnection
	{
		// Token: 0x06001258 RID: 4696 RVA: 0x0002F467 File Offset: 0x0002D667
		public EagerInternalConnection(global::System.Data.Entity.DbContext context, global::System.Data.Common.DbConnection existingConnection, bool connectionOwned) : base(new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithDbContext(context))
		{
			base.UnderlyingConnection = existingConnection;
			this._connectionOwned = connectionOwned;
			base.OnConnectionInitialized();
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0002F48E File Offset: 0x0002D68E
		public override global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.UserCode;
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0002F491 File Offset: 0x0002D691
		public override void Dispose()
		{
			if (this._connectionOwned)
			{
				if (base.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection)
				{
					base.UnderlyingConnection.Dispose();
					return;
				}
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(base.UnderlyingConnection, base.InterceptionContext);
			}
		}

		// Token: 0x04000919 RID: 2329
		private readonly bool _connectionOwned;
	}
}
