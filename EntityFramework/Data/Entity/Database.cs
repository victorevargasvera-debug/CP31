using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity
{
	// Token: 0x02000058 RID: 88
	public class Database
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00008207 File Offset: 0x00006407
		internal Database(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			this._internalContext = internalContext;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00008218 File Offset: 0x00006418
		public global::System.Data.Entity.DbContextTransaction CurrentTransaction
		{
			get
			{
				global::System.Data.Entity.Core.EntityClient.EntityTransaction currentTransaction = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this._internalContext.ObjectContext.Connection).CurrentTransaction;
				if (this._dbContextTransaction == null || this._entityTransaction != currentTransaction)
				{
					this._entityTransaction = currentTransaction;
					if (currentTransaction != null)
					{
						this._dbContextTransaction = new global::System.Data.Entity.DbContextTransaction(currentTransaction);
					}
					else
					{
						this._dbContextTransaction = null;
					}
				}
				return this._dbContextTransaction;
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00008276 File Offset: 0x00006476
		public void UseTransaction(global::System.Data.Common.DbTransaction transaction)
		{
			this._entityTransaction = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this._internalContext.GetObjectContextWithoutDatabaseInitialization().Connection).UseStoreTransaction(transaction);
			this._dbContextTransaction = null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000082A0 File Offset: 0x000064A0
		public global::System.Data.Entity.DbContextTransaction BeginTransaction()
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)this._internalContext.ObjectContext.Connection;
			this._dbContextTransaction = new global::System.Data.Entity.DbContextTransaction(entityConnection);
			this._entityTransaction = entityConnection.CurrentTransaction;
			return this._dbContextTransaction;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000082E4 File Offset: 0x000064E4
		public global::System.Data.Entity.DbContextTransaction BeginTransaction(global::System.Data.IsolationLevel isolationLevel)
		{
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)this._internalContext.ObjectContext.Connection;
			this._dbContextTransaction = new global::System.Data.Entity.DbContextTransaction(entityConnection, isolationLevel);
			this._entityTransaction = entityConnection.CurrentTransaction;
			return this._dbContextTransaction;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00008326 File Offset: 0x00006526
		public global::System.Data.Common.DbConnection Connection
		{
			get
			{
				return this._internalContext.Connection;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008333 File Offset: 0x00006533
		public static void SetInitializer<TContext>(global::System.Data.Entity.IDatabaseInitializer<TContext> strategy) where TContext : global::System.Data.Entity.DbContext
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
			global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration.Instance.RootResolver.DatabaseInitializerResolver.SetInitializer(typeof(TContext), strategy ?? new global::System.Data.Entity.NullDatabaseInitializer<TContext>());
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00008371 File Offset: 0x00006571
		public void Initialize(bool force)
		{
			if (force)
			{
				this._internalContext.MarkDatabaseInitialized();
				this._internalContext.PerformDatabaseInitialization();
				return;
			}
			this._internalContext.Initialize();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00008398 File Offset: 0x00006598
		public bool CompatibleWithModel(bool throwIfNoMetadata)
		{
			return this.CompatibleWithModel(throwIfNoMetadata, global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000083A2 File Offset: 0x000065A2
		internal bool CompatibleWithModel(bool throwIfNoMetadata, global::System.Data.Entity.Internal.DatabaseExistenceState existenceState)
		{
			return this._internalContext.CompatibleWithModel(throwIfNoMetadata, existenceState);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000083B1 File Offset: 0x000065B1
		public void Create()
		{
			this.Create(global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000083BC File Offset: 0x000065BC
		internal void Create(global::System.Data.Entity.Internal.DatabaseExistenceState existenceState)
		{
			if (existenceState == global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown)
			{
				if (this._internalContext.DatabaseOperations.Exists(this._internalContext.Connection, this._internalContext.CommandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(this.CreateStoreItemCollection))))
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
					dbInterceptionContext = dbInterceptionContext.WithDbContext(this._internalContext.Owner);
					throw global::System.Data.Entity.Resources.Error.Database_DatabaseAlreadyExists(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDatabase(this._internalContext.Connection, dbInterceptionContext));
				}
				existenceState = global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist;
			}
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = this._internalContext.CreateObjectContextForDdlOps())
			{
				this._internalContext.CreateDatabase(clonedObjectContext.ObjectContext, existenceState);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00008480 File Offset: 0x00006680
		public bool CreateIfNotExists()
		{
			if (this._internalContext.DatabaseOperations.Exists(this._internalContext.Connection, this._internalContext.CommandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(this.CreateStoreItemCollection))))
			{
				return false;
			}
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = this._internalContext.CreateObjectContextForDdlOps())
			{
				this._internalContext.CreateDatabase(clonedObjectContext.ObjectContext, global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist);
			}
			return true;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00008508 File Offset: 0x00006708
		public bool Exists()
		{
			return this._internalContext.DatabaseOperations.Exists(this._internalContext.Connection, this._internalContext.CommandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(this.CreateStoreItemCollection)));
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00008544 File Offset: 0x00006744
		public bool Delete()
		{
			if (!this._internalContext.DatabaseOperations.Exists(this._internalContext.Connection, this._internalContext.CommandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(this.CreateStoreItemCollection))))
			{
				return false;
			}
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = this._internalContext.CreateObjectContextForDdlOps())
			{
				this._internalContext.DatabaseOperations.Delete(clonedObjectContext.ObjectContext);
				this._internalContext.MarkDatabaseNotInitialized();
			}
			return true;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000085DC File Offset: 0x000067DC
		public static bool Exists(string nameOrConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			bool result;
			using (global::System.Data.Entity.Internal.LazyInternalConnection lazyInternalConnection = new global::System.Data.Entity.Internal.LazyInternalConnection(nameOrConnectionString))
			{
				result = new global::System.Data.Entity.Internal.DatabaseOperations().Exists(lazyInternalConnection.Connection, null, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(() => new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection()));
			}
			return result;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00008658 File Offset: 0x00006858
		public static bool Delete(string nameOrConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			if (!global::System.Data.Entity.Database.Exists(nameOrConnectionString))
			{
				return false;
			}
			using (global::System.Data.Entity.Internal.LazyInternalConnection lazyInternalConnection = new global::System.Data.Entity.Internal.LazyInternalConnection(nameOrConnectionString))
			{
				using (global::System.Data.Entity.Core.Objects.ObjectContext objectContext = global::System.Data.Entity.Database.CreateEmptyObjectContext(lazyInternalConnection.Connection))
				{
					new global::System.Data.Entity.Internal.DatabaseOperations().Delete(objectContext);
				}
			}
			return true;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000086CC File Offset: 0x000068CC
		public static bool Exists(global::System.Data.Common.DbConnection existingConnection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(existingConnection, "existingConnection");
			return new global::System.Data.Entity.Internal.DatabaseOperations().Exists(existingConnection, null, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(() => new global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection()));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008720 File Offset: 0x00006920
		public static bool Delete(global::System.Data.Common.DbConnection existingConnection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(existingConnection, "existingConnection");
			if (!global::System.Data.Entity.Database.Exists(existingConnection))
			{
				return false;
			}
			using (global::System.Data.Entity.Core.Objects.ObjectContext objectContext = global::System.Data.Entity.Database.CreateEmptyObjectContext(existingConnection))
			{
				new global::System.Data.Entity.Internal.DatabaseOperations().Delete(objectContext);
			}
			return true;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00008774 File Offset: 0x00006974
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00008780 File Offset: 0x00006980
		[global::System.Obsolete("The default connection factory should be set in the config file or using the DbConfiguration class. (See http://go.microsoft.com/fwlink/?LinkId=260883)")]
		public static global::System.Data.Entity.Infrastructure.IDbConnectionFactory DefaultConnectionFactory
		{
			get
			{
				return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>();
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(value, "value");
				global::System.Data.Entity.Database._defaultConnectionFactory = new global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(() => value, true);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000087B7 File Offset: 0x000069B7
		internal static global::System.Data.Entity.Infrastructure.IDbConnectionFactory SetDefaultConnectionFactory
		{
			get
			{
				return global::System.Data.Entity.Database._defaultConnectionFactory.Value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000087C5 File Offset: 0x000069C5
		internal static bool DefaultConnectionFactoryChanged
		{
			get
			{
				return global::System.Data.Entity.Database._defaultConnectionFactory != global::System.Data.Entity.Database._defaultDefaultConnectionFactory;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000087D8 File Offset: 0x000069D8
		internal static void ResetDefaultConnectionFactory()
		{
			global::System.Data.Entity.Database._defaultConnectionFactory = global::System.Data.Entity.Database._defaultDefaultConnectionFactory;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000087E6 File Offset: 0x000069E6
		private static global::System.Data.Entity.Core.Objects.ObjectContext CreateEmptyObjectContext(global::System.Data.Common.DbConnection connection)
		{
			return new global::System.Data.Entity.DbModelBuilder().Build(connection).Compile().CreateObjectContext<global::System.Data.Entity.Core.Objects.ObjectContext>(connection);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000087FE File Offset: 0x000069FE
		public global::System.Data.Entity.Infrastructure.DbRawSqlQuery<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			return new global::System.Data.Entity.Infrastructure.DbRawSqlQuery<TElement>(new global::System.Data.Entity.Internal.InternalSqlNonSetQuery(this._internalContext, typeof(TElement), sql, parameters));
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00008834 File Offset: 0x00006A34
		public global::System.Data.Entity.Infrastructure.DbRawSqlQuery SqlQuery(global::System.Type elementType, string sql, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(elementType, "elementType");
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			return new global::System.Data.Entity.Infrastructure.DbRawSqlQuery(new global::System.Data.Entity.Internal.InternalSqlNonSetQuery(this._internalContext, elementType, sql, parameters));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000886D File Offset: 0x00006A6D
		public int ExecuteSqlCommand(string sql, params object[] parameters)
		{
			return this.ExecuteSqlCommand(this._internalContext.EnsureTransactionsForFunctionsAndCommands ? global::System.Data.Entity.TransactionalBehavior.EnsureTransaction : global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, sql, parameters);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008888 File Offset: 0x00006A88
		public int ExecuteSqlCommand(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string sql, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			return this._internalContext.ExecuteSqlCommand(transactionalBehavior, sql, parameters);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000088B0 File Offset: 0x00006AB0
		public global::System.Threading.Tasks.Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
		{
			return this.ExecuteSqlCommandAsync(sql, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000088BF File Offset: 0x00006ABF
		public global::System.Threading.Tasks.Task<int> ExecuteSqlCommandAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string sql, params object[] parameters)
		{
			return this.ExecuteSqlCommandAsync(transactionalBehavior, sql, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000088CF File Offset: 0x00006ACF
		public global::System.Threading.Tasks.Task<int> ExecuteSqlCommandAsync(string sql, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			return this.ExecuteSqlCommandAsync(this._internalContext.EnsureTransactionsForFunctionsAndCommands ? global::System.Data.Entity.TransactionalBehavior.EnsureTransaction : global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, sql, cancellationToken, parameters);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000088EB File Offset: 0x00006AEB
		public global::System.Threading.Tasks.Task<int> ExecuteSqlCommandAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string sql, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			cancellationToken.ThrowIfCancellationRequested();
			return this._internalContext.ExecuteSqlCommandAsync(transactionalBehavior, sql, cancellationToken, parameters);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000891D File Offset: 0x00006B1D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008925 File Offset: 0x00006B25
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000892E File Offset: 0x00006B2E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008936 File Offset: 0x00006B36
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008940 File Offset: 0x00006B40
		private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection CreateStoreItemCollection()
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection result;
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = this._internalContext.CreateObjectContextForDdlOps())
			{
				result = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)clonedObjectContext.ObjectContext.Connection.GetMetadataWorkspace().GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			}
			return result;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00008998 File Offset: 0x00006B98
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000089A8 File Offset: 0x00006BA8
		public int? CommandTimeout
		{
			get
			{
				return this._internalContext.CommandTimeout;
			}
			set
			{
				if (value != null)
				{
					int? num = value;
					int num2 = 0;
					if (num.GetValueOrDefault() < num2 & num != null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidCommandTimeout);
					}
				}
				this._internalContext.CommandTimeout = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000089ED File Offset: 0x00006BED
		// (set) Token: 0x0600024B RID: 587 RVA: 0x000089FA File Offset: 0x00006BFA
		public global::System.Action<string> Log
		{
			get
			{
				return this._internalContext.Log;
			}
			set
			{
				this._internalContext.Log = value;
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory> _defaultDefaultConnectionFactory = new global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(() => global::System.Data.Entity.Internal.AppConfig.DefaultInstance.TryGetDefaultConnectionFactory() ?? new global::System.Data.Entity.Infrastructure.LocalDbConnectionFactory(), true);

		// Token: 0x040000AA RID: 170
		private static volatile global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory> _defaultConnectionFactory = global::System.Data.Entity.Database._defaultDefaultConnectionFactory;

		// Token: 0x040000AB RID: 171
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x040000AC RID: 172
		private global::System.Data.Entity.Core.EntityClient.EntityTransaction _entityTransaction;

		// Token: 0x040000AD RID: 173
		private global::System.Data.Entity.DbContextTransaction _dbContextTransaction;
	}
}
