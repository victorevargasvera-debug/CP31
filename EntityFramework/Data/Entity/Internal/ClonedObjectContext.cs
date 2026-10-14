using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal.MockingProxies;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000ED RID: 237
	internal class ClonedObjectContext : global::System.IDisposable
	{
		// Token: 0x060011FD RID: 4605 RVA: 0x0002DA50 File Offset: 0x0002BC50
		protected ClonedObjectContext()
		{
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0002DA58 File Offset: 0x0002BC58
		public ClonedObjectContext(global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy objectContext, global::System.Data.Common.DbConnection connection, string connectionString, bool transferLoadedAssemblies = true)
		{
			if (connection == null || connection.State != global::System.Data.ConnectionState.Open)
			{
				connection = (connection ?? objectContext.Connection.StoreConnection);
				connection = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection).CloneDbConnection(connection);
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(connection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(connectionString));
				this._connectionCloned = true;
			}
			this._clonedEntityConnection = objectContext.Connection.CreateNew(connection);
			this._objectContext = objectContext.CreateNew(this._clonedEntityConnection);
			this._objectContext.CopyContextOptions(objectContext);
			if (!string.IsNullOrWhiteSpace(objectContext.DefaultContainerName))
			{
				this._objectContext.DefaultContainerName = objectContext.DefaultContainerName;
			}
			if (transferLoadedAssemblies)
			{
				this.TransferLoadedAssemblies(objectContext);
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0002DB12 File Offset: 0x0002BD12
		public virtual global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy ObjectContext
		{
			get
			{
				return this._objectContext;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x0002DB1A File Offset: 0x0002BD1A
		public virtual global::System.Data.Common.DbConnection Connection
		{
			get
			{
				return this._objectContext.Connection.StoreConnection;
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0002DB2C File Offset: 0x0002BD2C
		private void TransferLoadedAssemblies(global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy source)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> objectItemCollection = source.GetObjectItemCollection();
			foreach (global::System.Reflection.Assembly assembly in (from i in objectItemCollection
			where i is global::System.Data.Entity.Core.Metadata.Edm.EntityType || i is global::System.Data.Entity.Core.Metadata.Edm.ComplexType
			select source.GetClrType((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)i).Assembly()).Union(from i in objectItemCollection.OfType<global::System.Data.Entity.Core.Metadata.Edm.EnumType>()
			select source.GetClrType(i).Assembly()).Distinct<global::System.Reflection.Assembly>())
			{
				this._objectContext.LoadFromAssembly(assembly);
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0002DBE8 File Offset: 0x0002BDE8
		public void Dispose()
		{
			if (this._objectContext != null)
			{
				global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy objectContext = this._objectContext;
				global::System.Data.Common.DbConnection connection = this.Connection;
				this._objectContext = null;
				objectContext.Dispose();
				this._clonedEntityConnection.Dispose();
				if (this._connectionCloned)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
				}
			}
		}

		// Token: 0x040008F7 RID: 2295
		private global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy _objectContext;

		// Token: 0x040008F8 RID: 2296
		private readonly bool _connectionCloned;

		// Token: 0x040008F9 RID: 2297
		private readonly global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy _clonedEntityConnection;
	}
}
