using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Interception;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000129 RID: 297
	internal abstract class RepositoryBase
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00034D45 File Offset: 0x00032F45
		protected RepositoryBase(global::System.Data.Entity.Internal.InternalContext usersContext, string connectionString, global::System.Data.Common.DbProviderFactory providerFactory)
		{
			this._usersContext = usersContext;
			this._connectionString = connectionString;
			this._providerFactory = providerFactory;
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00034D64 File Offset: 0x00032F64
		protected global::System.Data.Common.DbConnection CreateConnection()
		{
			global::System.Data.Common.DbConnection dbConnection;
			if (!this._usersContext.IsDisposed && (dbConnection = this._usersContext.Connection) != null)
			{
				if (dbConnection.State == global::System.Data.ConnectionState.Open)
				{
					return dbConnection;
				}
				dbConnection = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(dbConnection).CloneDbConnection(dbConnection, this._providerFactory);
			}
			else
			{
				dbConnection = this._providerFactory.CreateConnection();
			}
			global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(this._connectionString));
			return dbConnection;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00034DDA File Offset: 0x00032FDA
		protected void DisposeConnection(global::System.Data.Common.DbConnection connection)
		{
			if (connection != null && (this._usersContext.IsDisposed || connection != this._usersContext.Connection))
			{
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
			}
		}

		// Token: 0x040009AA RID: 2474
		private readonly global::System.Data.Entity.Internal.InternalContext _usersContext;

		// Token: 0x040009AB RID: 2475
		private readonly string _connectionString;

		// Token: 0x040009AC RID: 2476
		private readonly global::System.Data.Common.DbProviderFactory _providerFactory;
	}
}
