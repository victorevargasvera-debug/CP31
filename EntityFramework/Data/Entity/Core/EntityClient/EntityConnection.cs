using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005DD RID: 1501
	public class EntityConnection : global::System.Data.Common.DbConnection
	{
		// Token: 0x06004906 RID: 18694 RVA: 0x0010298D File Offset: 0x00100B8D
		public EntityConnection() : this(string.Empty)
		{
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x0010299A File Offset: 0x00100B9A
		public EntityConnection(string connectionString)
		{
			this._connectionStringLock = new object();
			this._entityConnectionOwnsStoreConnection = true;
			this._associatedContexts = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectContext>();
			base..ctor();
			this.ChangeConnectionString(connectionString);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x001029C6 File Offset: 0x00100BC6
		public EntityConnection(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbConnection connection) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace>(workspace, "workspace"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection"), false, false)
		{
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x001029E6 File Offset: 0x00100BE6
		public EntityConnection(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbConnection connection, bool entityConnectionOwnsStoreConnection) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace>(workspace, "workspace"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection"), false, entityConnectionOwnsStoreConnection)
		{
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00102A08 File Offset: 0x00100C08
		internal EntityConnection(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Common.DbConnection connection, bool skipInitialization, bool entityConnectionOwnsStoreConnection)
		{
			this._connectionStringLock = new object();
			this._entityConnectionOwnsStoreConnection = true;
			this._associatedContexts = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectContext>();
			base..ctor();
			if (!skipInitialization)
			{
				if (!workspace.IsItemCollectionAlreadyRegistered(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ItemCollectionsNotRegisteredInWorkspace("EdmItemCollection"));
				}
				if (!workspace.IsItemCollectionAlreadyRegistered(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ItemCollectionsNotRegisteredInWorkspace("StoreItemCollection"));
				}
				if (!workspace.IsItemCollectionAlreadyRegistered(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ItemCollectionsNotRegisteredInWorkspace("StorageMappingItemCollection"));
				}
				if (connection.GetProviderFactory() == null)
				{
					throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_DbConnectionHasNoProvider(connection));
				}
				global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
				this._providerFactory = storeItemCollection.ProviderFactory;
				this._initialized = true;
			}
			this._metadataWorkspace = workspace;
			this._storeConnection = connection;
			this._entityConnectionOwnsStoreConnection = entityConnectionOwnsStoreConnection;
			if (this._storeConnection != null)
			{
				this._entityClientConnectionState = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext);
			}
			this.SubscribeToStoreConnectionStateChangeEvents();
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00102AFF File Offset: 0x00100CFF
		private void SubscribeToStoreConnectionStateChangeEvents()
		{
			if (this._storeConnection != null)
			{
				this._storeConnection.StateChange += this.StoreConnectionStateChangeHandler;
			}
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00102B21 File Offset: 0x00100D21
		private void UnsubscribeFromStoreConnectionStateChangeEvents()
		{
			if (this._storeConnection != null)
			{
				this._storeConnection.StateChange -= this.StoreConnectionStateChangeHandler;
			}
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00102B44 File Offset: 0x00100D44
		internal virtual void StoreConnectionStateChangeHandler(object sender, global::System.Data.StateChangeEventArgs stateChange)
		{
			global::System.Data.ConnectionState currentState = stateChange.CurrentState;
			if (this._entityClientConnectionState != currentState)
			{
				global::System.Data.ConnectionState entityClientConnectionState = this._entityClientConnectionState;
				this._entityClientConnectionState = stateChange.CurrentState;
				this.OnStateChange(new global::System.Data.StateChangeEventArgs(entityClientConnectionState, currentState));
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x00102B84 File Offset: 0x00100D84
		// (set) Token: 0x0600490F RID: 18703 RVA: 0x00102CC0 File Offset: 0x00100EC0
		public override string ConnectionString
		{
			get
			{
				if (this._userConnectionOptions == null)
				{
					return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}={3}{4};{1}={5};{2}=\"{6}\";", new object[]
					{
						"metadata",
						"provider",
						"provider connection string",
						"reader://",
						this._metadataWorkspace.MetadataWorkspaceId,
						this._storeConnection.GetProviderInvariantName(),
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(this._storeConnection, this.InterceptionContext)
					});
				}
				string usersConnectionString = this._userConnectionOptions.UsersConnectionString;
				if (this._userConnectionOptions == this._effectiveConnectionOptions && this._storeConnection != null)
				{
					string text = null;
					try
					{
						text = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(this._storeConnection, this.InterceptionContext);
					}
					catch (global::System.Exception ex)
					{
						if (ex.IsCatchableExceptionType())
						{
							throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("ConnectionString"), ex);
						}
						throw;
					}
					string text2 = this._userConnectionOptions["provider connection string"];
					if (text != text2 && (!string.IsNullOrEmpty(text) || !string.IsNullOrEmpty(text2)))
					{
						return new global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(usersConnectionString)
						{
							ProviderConnectionString = text
						}.ConnectionString;
					}
				}
				return usersConnectionString;
			}
			set
			{
				if (this._initialized)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_SettingsCannotBeChangedOnOpenConnection);
				}
				this.ChangeConnectionString(value);
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x00102CDC File Offset: 0x00100EDC
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectContext> AssociatedContexts
		{
			get
			{
				return this._associatedContexts;
			}
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00102CE4 File Offset: 0x00100EE4
		internal virtual void AssociateContext(global::System.Data.Entity.Core.Objects.ObjectContext context)
		{
			if (this._associatedContexts.Count != 0)
			{
				foreach (global::System.Data.Entity.Core.Objects.ObjectContext objectContext in this._associatedContexts.ToArray())
				{
					if (context == objectContext || objectContext.IsDisposed)
					{
						this._associatedContexts.Remove(objectContext);
					}
				}
			}
			this._associatedContexts.Add(context);
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x00102D41 File Offset: 0x00100F41
		internal global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext.Combine(from c in this.AssociatedContexts
				select c.InterceptionContext);
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x00102D74 File Offset: 0x00100F74
		public override int ConnectionTimeout
		{
			get
			{
				if (this._storeConnection == null)
				{
					return 0;
				}
				int connectionTimeout;
				try
				{
					connectionTimeout = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionTimeout(this._storeConnection, this.InterceptionContext);
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("ConnectionTimeout"), ex);
					}
					throw;
				}
				return connectionTimeout;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x00102DD8 File Offset: 0x00100FD8
		public override string Database
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x00102DE0 File Offset: 0x00100FE0
		public override global::System.Data.ConnectionState State
		{
			get
			{
				global::System.Data.ConnectionState? fakeConnectionState = this._fakeConnectionState;
				if (fakeConnectionState == null)
				{
					return this._entityClientConnectionState;
				}
				return fakeConnectionState.GetValueOrDefault();
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x00102E0C File Offset: 0x0010100C
		public override string DataSource
		{
			get
			{
				if (this._storeConnection == null)
				{
					return string.Empty;
				}
				string dataSource;
				try
				{
					dataSource = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(this._storeConnection, this.InterceptionContext);
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("DataSource"), ex);
					}
					throw;
				}
				return dataSource;
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x00102E74 File Offset: 0x00101074
		public override string ServerVersion
		{
			get
			{
				if (this._storeConnection == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
				}
				if (this.State != global::System.Data.ConnectionState.Open)
				{
					throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionNotOpen();
				}
				string serverVersion;
				try
				{
					serverVersion = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetServerVersion(this._storeConnection, this.InterceptionContext);
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("ServerVersion"), ex);
					}
					throw;
				}
				return serverVersion;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06004918 RID: 18712 RVA: 0x00102EEC File Offset: 0x001010EC
		protected override global::System.Data.Common.DbProviderFactory DbProviderFactory
		{
			get
			{
				return global::System.Data.Entity.Core.EntityClient.EntityProviderFactory.Instance;
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x00102EF3 File Offset: 0x001010F3
		internal virtual global::System.Data.Common.DbProviderFactory StoreProviderFactory
		{
			get
			{
				return this._providerFactory;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x00102EFB File Offset: 0x001010FB
		public virtual global::System.Data.Common.DbConnection StoreConnection
		{
			get
			{
				return this._storeConnection;
			}
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00102F03 File Offset: 0x00101103
		public virtual global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace()
		{
			if (this._metadataWorkspace != null)
			{
				return this._metadataWorkspace;
			}
			this._metadataWorkspace = global::System.Data.Entity.Core.Metadata.Edm.MetadataCache.Instance.GetMetadataWorkspace(this._effectiveConnectionOptions);
			this._initialized = true;
			return this._metadataWorkspace;
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x00102F37 File Offset: 0x00101137
		public virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction CurrentTransaction
		{
			get
			{
				if (this._currentTransaction != null && (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetConnection(this._currentTransaction.StoreTransaction, this.InterceptionContext) == null || this.State == global::System.Data.ConnectionState.Closed))
				{
					this.ClearCurrentTransaction();
				}
				return this._currentTransaction;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x00102F78 File Offset: 0x00101178
		internal virtual bool EnlistedInUserTransaction
		{
			get
			{
				bool result;
				try
				{
					result = (this._enlistedTransaction != null && this._enlistedTransaction.TransactionInformation.Status == global::System.Transactions.TransactionStatus.Active);
				}
				catch (global::System.ObjectDisposedException)
				{
					this._enlistedTransaction = null;
					result = false;
				}
				return result;
			}
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00102FCC File Offset: 0x001011CC
		public override void Open()
		{
			this._fakeConnectionState = null;
			if (!global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.CancelableEntityConnection.Opening(this, this.InterceptionContext))
			{
				this._fakeConnectionState = new global::System.Data.ConnectionState?(global::System.Data.ConnectionState.Open);
				return;
			}
			if (this._storeConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
			}
			if (this.State == global::System.Data.ConnectionState.Broken)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_CannotOpenBrokenConnection();
			}
			if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) != global::System.Data.ConnectionState.Open)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this.GetMetadataWorkspace();
				try
				{
					global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this._storeConnection, metadataWorkspace).Execute(delegate()
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Open(this._storeConnection, this.InterceptionContext);
					});
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("Open"), ex);
					}
					throw;
				}
				this.ClearTransactions();
			}
			if (this._storeConnection == null || global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) != global::System.Data.ConnectionState.Open)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionNotOpen();
			}
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x001030CC File Offset: 0x001012CC
		public override async global::System.Threading.Tasks.Task OpenAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (this._storeConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
			}
			if (this.State == global::System.Data.ConnectionState.Broken)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_CannotOpenBrokenConnection();
			}
			cancellationToken.ThrowIfCancellationRequested();
			if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) != global::System.Data.ConnectionState.Open)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this.GetMetadataWorkspace();
				try
				{
					await global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this._storeConnection, metadataWorkspace).ExecuteAsync(() => global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.OpenAsync(this._storeConnection, this.InterceptionContext, cancellationToken), cancellationToken).WithCurrentCulture();
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("Open"), ex);
					}
					throw;
				}
				this.ClearTransactions();
			}
			if (this._storeConnection == null || global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) != global::System.Data.ConnectionState.Open)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionNotOpen();
			}
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00103119 File Offset: 0x00101319
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityCommand CreateCommand()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityCommand(null, this);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00103122 File Offset: 0x00101322
		protected override global::System.Data.Common.DbCommand CreateDbCommand()
		{
			return this.CreateCommand();
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x0010312A File Offset: 0x0010132A
		public override void Close()
		{
			this._fakeConnectionState = null;
			if (this._storeConnection == null)
			{
				return;
			}
			this.StoreCloseHelper();
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00103147 File Offset: 0x00101347
		public override void ChangeDatabase(string databaseName)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x0010314E File Offset: 0x0010134E
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction BeginTransaction()
		{
			return base.BeginTransaction() as global::System.Data.Entity.Core.EntityClient.EntityTransaction;
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x0010315B File Offset: 0x0010135B
		public new virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction BeginTransaction(global::System.Data.IsolationLevel isolationLevel)
		{
			return base.BeginTransaction(isolationLevel) as global::System.Data.Entity.Core.EntityClient.EntityTransaction;
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x0010316C File Offset: 0x0010136C
		protected override global::System.Data.Common.DbTransaction BeginDbTransaction(global::System.Data.IsolationLevel isolationLevel)
		{
			if (this._fakeConnectionState != null)
			{
				return new global::System.Data.Entity.Core.EntityClient.EntityTransaction();
			}
			if (this.CurrentTransaction != null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityClient_TransactionAlreadyStarted);
			}
			if (this._storeConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
			}
			if (this.State != global::System.Data.ConnectionState.Open)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionNotOpen();
			}
			global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext(this.InterceptionContext);
			if (isolationLevel != global::System.Data.IsolationLevel.Unspecified)
			{
				interceptionContext = interceptionContext.WithIsolationLevel(isolationLevel);
			}
			global::System.Data.Common.DbTransaction dbTransaction = null;
			try
			{
				dbTransaction = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this._storeConnection, this.GetMetadataWorkspace()).Execute<global::System.Data.Common.DbTransaction>(delegate()
				{
					if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) == global::System.Data.ConnectionState.Broken)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(this._storeConnection, interceptionContext);
					}
					if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) == global::System.Data.ConnectionState.Closed)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Open(this._storeConnection, interceptionContext);
					}
					return global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.BeginTransaction(this._storeConnection, interceptionContext);
				});
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ErrorInBeginningTransaction, ex);
				}
				throw;
			}
			if (dbTransaction == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_ReturnedNullOnProviderMethod("BeginTransaction", this._storeConnection.GetType().Name));
			}
			this._currentTransaction = new global::System.Data.Entity.Core.EntityClient.EntityTransaction(this, dbTransaction);
			return this._currentTransaction;
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00103274 File Offset: 0x00101474
		internal virtual global::System.Data.Entity.Core.EntityClient.EntityTransaction UseStoreTransaction(global::System.Data.Common.DbTransaction storeTransaction)
		{
			if (storeTransaction == null)
			{
				this.ClearCurrentTransaction();
			}
			else
			{
				if (this.CurrentTransaction != null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_TransactionAlreadyStarted);
				}
				if (this.EnlistedInUserTransaction)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_TransactionAlreadyEnlistedInUserTransaction);
				}
				global::System.Data.Common.DbConnection connection = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetConnection(storeTransaction, this.InterceptionContext);
				if (connection == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_InvalidTransactionNoConnection);
				}
				if (connection != this.StoreConnection)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbContext_InvalidTransactionForConnection);
				}
				this._currentTransaction = new global::System.Data.Entity.Core.EntityClient.EntityTransaction(this, storeTransaction);
			}
			return this._currentTransaction;
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x001032FC File Offset: 0x001014FC
		public override void EnlistTransaction(global::System.Transactions.Transaction transaction)
		{
			if (this._storeConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionStringNeededBeforeOperation();
			}
			if (this.State != global::System.Data.ConnectionState.Open)
			{
				throw global::System.Data.Entity.Resources.Error.EntityClient_ConnectionNotOpen();
			}
			try
			{
				global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext enlistTransactionInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.EnlistTransactionInterceptionContext(this.InterceptionContext);
				enlistTransactionInterceptionContext = enlistTransactionInterceptionContext.WithTransaction(transaction);
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.EnlistTransaction(this._storeConnection, enlistTransactionInterceptionContext);
				if (transaction != null && !this.EnlistedInUserTransaction)
				{
					transaction.TransactionCompleted += this.EnlistedTransactionCompleted;
				}
				this._enlistedTransaction = transaction;
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("EnlistTransaction"), ex);
				}
				throw;
			}
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x001033AC File Offset: 0x001015AC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.ClearTransactions();
				if (this._storeConnection != null)
				{
					if (this._entityConnectionOwnsStoreConnection)
					{
						this.StoreCloseHelper();
					}
					this.UnsubscribeFromStoreConnectionStateChangeEvents();
					if (this._entityConnectionOwnsStoreConnection)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(this._storeConnection, this.InterceptionContext);
					}
					this._storeConnection = null;
				}
				this._entityClientConnectionState = global::System.Data.ConnectionState.Closed;
				this.ChangeConnectionString(string.Empty);
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00103421 File Offset: 0x00101621
		internal virtual void ClearCurrentTransaction()
		{
			this._currentTransaction = null;
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x0010342C File Offset: 0x0010162C
		private void ChangeConnectionString(string newConnectionString)
		{
			global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions dbConnectionOptions = global::System.Data.Entity.Core.EntityClient.EntityConnection._emptyConnectionOptions;
			if (!string.IsNullOrEmpty(newConnectionString))
			{
				dbConnectionOptions = new global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions(newConnectionString, global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder.ValidKeywords);
			}
			global::System.Data.Common.DbProviderFactory dbProviderFactory = null;
			global::System.Data.Common.DbConnection dbConnection = null;
			global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions dbConnectionOptions2 = dbConnectionOptions;
			if (!dbConnectionOptions.IsEmpty)
			{
				string text = dbConnectionOptions["name"];
				if (!string.IsNullOrEmpty(text))
				{
					if (1 < dbConnectionOptions.Parsetable.Count)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ExtraParametersWithNamedConnection);
					}
					global::System.Configuration.ConnectionStringSettings connectionStringSettings = global::System.Configuration.ConfigurationManager.ConnectionStrings[text];
					if (connectionStringSettings == null || connectionStringSettings.ProviderName != "System.Data.EntityClient")
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidNamedConnection);
					}
					dbConnectionOptions2 = new global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions(connectionStringSettings.ConnectionString, global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder.ValidKeywords);
					if (!string.IsNullOrEmpty(dbConnectionOptions2["name"]))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_NestedNamedConnection(text));
					}
				}
				global::System.Data.Entity.Core.EntityClient.EntityConnection.ValidateValueForTheKeyword(dbConnectionOptions2, "metadata");
				string key = global::System.Data.Entity.Core.EntityClient.EntityConnection.ValidateValueForTheKeyword(dbConnectionOptions2, "provider");
				dbProviderFactory = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(key);
				dbConnection = global::System.Data.Entity.Core.EntityClient.EntityConnection.GetStoreConnection(dbProviderFactory);
				try
				{
					string text2 = dbConnectionOptions2["provider connection string"];
					if (text2 != null)
					{
						global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>(this.InterceptionContext).WithValue(text2));
					}
				}
				catch (global::System.Exception ex)
				{
					if (ex.IsCatchableExceptionType())
					{
						throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ProviderSpecificError("ConnectionString"), ex);
					}
					throw;
				}
			}
			object connectionStringLock = this._connectionStringLock;
			lock (connectionStringLock)
			{
				this._providerFactory = dbProviderFactory;
				this._metadataWorkspace = null;
				this.ClearTransactions();
				this.UnsubscribeFromStoreConnectionStateChangeEvents();
				this._storeConnection = dbConnection;
				this.SubscribeToStoreConnectionStateChangeEvents();
				this._userConnectionOptions = dbConnectionOptions;
				this._effectiveConnectionOptions = dbConnectionOptions2;
			}
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x001035E8 File Offset: 0x001017E8
		private static string ValidateValueForTheKeyword(global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions effectiveConnectionOptions, string keywordName)
		{
			string text = effectiveConnectionOptions[keywordName];
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Trim();
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_ConnectionStringMissingInfo(keywordName));
			}
			return text;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00103621 File Offset: 0x00101821
		private void ClearTransactions()
		{
			this.ClearCurrentTransaction();
			this.ClearEnlistedTransaction();
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x0010362F File Offset: 0x0010182F
		private void ClearEnlistedTransaction()
		{
			if (this.EnlistedInUserTransaction)
			{
				this._enlistedTransaction.TransactionCompleted -= this.EnlistedTransactionCompleted;
			}
			this._enlistedTransaction = null;
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00103657 File Offset: 0x00101857
		private void EnlistedTransactionCompleted(object sender, global::System.Transactions.TransactionEventArgs e)
		{
			e.Transaction.TransactionCompleted -= this.EnlistedTransactionCompleted;
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x00103670 File Offset: 0x00101870
		private void StoreCloseHelper()
		{
			try
			{
				if (this._storeConnection != null && global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(this._storeConnection, this.InterceptionContext) != global::System.Data.ConnectionState.Closed)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(this._storeConnection, this.InterceptionContext);
				}
				this.ClearTransactions();
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityException(global::System.Data.Entity.Resources.Strings.EntityClient_ErrorInClosingConnection, ex);
				}
				throw;
			}
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x001036EC File Offset: 0x001018EC
		private static global::System.Data.Common.DbConnection GetStoreConnection(global::System.Data.Common.DbProviderFactory factory)
		{
			global::System.Data.Common.DbConnection dbConnection = factory.CreateConnection();
			if (dbConnection == null)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.EntityClient_ReturnedNullOnProviderMethod("CreateConnection", factory.GetType().Name));
			}
			return dbConnection;
		}

		// Token: 0x040019D4 RID: 6612
		private const string EntityClientProviderName = "System.Data.EntityClient";

		// Token: 0x040019D5 RID: 6613
		private const string ProviderInvariantName = "provider";

		// Token: 0x040019D6 RID: 6614
		private const string ProviderConnectionString = "provider connection string";

		// Token: 0x040019D7 RID: 6615
		private const string ReaderPrefix = "reader://";

		// Token: 0x040019D8 RID: 6616
		private readonly object _connectionStringLock;

		// Token: 0x040019D9 RID: 6617
		private static readonly global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions _emptyConnectionOptions = new global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions(string.Empty, new string[0]);

		// Token: 0x040019DA RID: 6618
		private global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions _userConnectionOptions;

		// Token: 0x040019DB RID: 6619
		private global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions _effectiveConnectionOptions;

		// Token: 0x040019DC RID: 6620
		private global::System.Data.ConnectionState _entityClientConnectionState;

		// Token: 0x040019DD RID: 6621
		private global::System.Data.Common.DbProviderFactory _providerFactory;

		// Token: 0x040019DE RID: 6622
		private global::System.Data.Common.DbConnection _storeConnection;

		// Token: 0x040019DF RID: 6623
		private readonly bool _entityConnectionOwnsStoreConnection;

		// Token: 0x040019E0 RID: 6624
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _metadataWorkspace;

		// Token: 0x040019E1 RID: 6625
		private global::System.Data.Entity.Core.EntityClient.EntityTransaction _currentTransaction;

		// Token: 0x040019E2 RID: 6626
		private global::System.Transactions.Transaction _enlistedTransaction;

		// Token: 0x040019E3 RID: 6627
		private bool _initialized;

		// Token: 0x040019E4 RID: 6628
		private global::System.Data.ConnectionState? _fakeConnectionState;

		// Token: 0x040019E5 RID: 6629
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectContext> _associatedContexts;
	}
}
