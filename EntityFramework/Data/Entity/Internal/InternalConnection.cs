using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200011C RID: 284
	internal abstract class InternalConnection : global::System.Data.Entity.Internal.IInternalConnection, global::System.IDisposable
	{
		// Token: 0x06001395 RID: 5013 RVA: 0x00031FED File Offset: 0x000301ED
		public InternalConnection(global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			this.InterceptionContext = (interceptionContext ?? new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00032005 File Offset: 0x00030205
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x0003200D File Offset: 0x0003020D
		private protected global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext { protected get; private set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00032018 File Offset: 0x00030218
		public virtual global::System.Data.Common.DbConnection Connection
		{
			get
			{
				global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = this.UnderlyingConnection as global::System.Data.Entity.Core.EntityClient.EntityConnection;
				if (entityConnection == null)
				{
					return this.UnderlyingConnection;
				}
				return entityConnection.StoreConnection;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00032044 File Offset: 0x00030244
		public virtual string ConnectionKey
		{
			get
			{
				string result;
				if ((result = this._key) == null)
				{
					result = (this._key = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0};{1}", new object[]
					{
						this.UnderlyingConnection.GetType(),
						this.OriginalConnectionString
					}));
				}
				return result;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00032090 File Offset: 0x00030290
		public virtual bool ConnectionHasModel
		{
			get
			{
				return this.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600139B RID: 5019
		public abstract global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin { get; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000320A0 File Offset: 0x000302A0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000320A8 File Offset: 0x000302A8
		public virtual global::System.Data.Entity.Internal.AppConfig AppConfig { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000320B4 File Offset: 0x000302B4
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x000320EA File Offset: 0x000302EA
		public virtual string ProviderName
		{
			get
			{
				string result;
				if ((result = this._providerName) == null)
				{
					result = (this._providerName = ((this.UnderlyingConnection == null) ? null : this.Connection.GetProviderInvariantName()));
				}
				return result;
			}
			set
			{
				this._providerName = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000320F3 File Offset: 0x000302F3
		public virtual string ConnectionStringName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000320F8 File Offset: 0x000302F8
		public virtual string OriginalConnectionString
		{
			get
			{
				string b = (this.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection) ? this.UnderlyingConnection.Database : global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDatabase(this.UnderlyingConnection, this.InterceptionContext);
				string b2 = (this.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection) ? this.UnderlyingConnection.DataSource : global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(this.UnderlyingConnection, this.InterceptionContext);
				if (!string.Equals(this._originalDatabaseName, b, global::System.StringComparison.OrdinalIgnoreCase) || !string.Equals(this._originalDataSource, b2, global::System.StringComparison.OrdinalIgnoreCase))
				{
					this.OnConnectionInitialized();
				}
				return this._originalConnectionString;
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x0003219C File Offset: 0x0003039C
		public virtual global::System.Data.Entity.Core.Objects.ObjectContext CreateObjectContextFromConnectionModel()
		{
			global::System.Data.Entity.Core.Objects.ObjectContext objectContext = new global::System.Data.Entity.Core.Objects.ObjectContext((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.UnderlyingConnection);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> items = objectContext.MetadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			if (items.Count == 1)
			{
				objectContext.DefaultContainerName = items.Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Name;
			}
			return objectContext;
		}

		// Token: 0x060013A3 RID: 5027
		public abstract void Dispose();

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000321E2 File Offset: 0x000303E2
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x000321EA File Offset: 0x000303EA
		protected global::System.Data.Common.DbConnection UnderlyingConnection { get; set; }

		// Token: 0x060013A6 RID: 5030 RVA: 0x000321F4 File Offset: 0x000303F4
		protected void OnConnectionInitialized()
		{
			this._originalConnectionString = global::System.Data.Entity.Internal.InternalConnection.GetStoreConnectionString(this.UnderlyingConnection);
			try
			{
				this._originalDatabaseName = ((this.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection) ? this.UnderlyingConnection.Database : global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDatabase(this.UnderlyingConnection, this.InterceptionContext));
			}
			catch (global::System.NotImplementedException)
			{
			}
			try
			{
				this._originalDataSource = ((this.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection) ? this.UnderlyingConnection.DataSource : global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(this.UnderlyingConnection, this.InterceptionContext));
			}
			catch (global::System.NotImplementedException)
			{
			}
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x000322B0 File Offset: 0x000304B0
		public static string GetStoreConnectionString(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = connection as global::System.Data.Entity.Core.EntityClient.EntityConnection;
			string result;
			if (entityConnection != null)
			{
				connection = entityConnection.StoreConnection;
				result = ((connection != null) ? global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext()) : null);
			}
			else
			{
				result = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
			}
			return result;
		}

		// Token: 0x04000958 RID: 2392
		private string _key;

		// Token: 0x04000959 RID: 2393
		private string _providerName;

		// Token: 0x0400095A RID: 2394
		private string _originalConnectionString;

		// Token: 0x0400095B RID: 2395
		private string _originalDatabaseName;

		// Token: 0x0400095C RID: 2396
		private string _originalDataSource;
	}
}
