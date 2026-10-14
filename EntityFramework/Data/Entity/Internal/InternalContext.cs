using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Internal.MockingProxies;
using System.Data.Entity.Internal.Validation;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200011D RID: 285
	internal abstract class InternalContext : global::System.IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060013A8 RID: 5032 RVA: 0x00032304 File Offset: 0x00030504
		// (remove) Token: 0x060013A9 RID: 5033 RVA: 0x0003233C File Offset: 0x0003053C
		public event global::System.EventHandler<global::System.EventArgs> OnDisposing;

		// Token: 0x060013AA RID: 5034 RVA: 0x00032374 File Offset: 0x00030574
		protected InternalContext(global::System.Data.Entity.DbContext owner, global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> dispatchers = null)
		{
			this._owner = owner;
			global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> dispatchers2 = dispatchers;
			if (dispatchers == null)
			{
				dispatchers2 = new global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers>(() => global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch);
			}
			this._dispatchers = dispatchers2;
			this.AutoDetectChangesEnabled = true;
			this.ValidateOnSaveEnabled = true;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00032402 File Offset: 0x00030602
		protected InternalContext()
		{
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00032441 File Offset: 0x00030641
		public global::System.Data.Entity.DbContext Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x060013AD RID: 5037
		public abstract global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext { get; }

		// Token: 0x060013AE RID: 5038
		public abstract global::System.Data.Entity.Core.Objects.ObjectContext GetObjectContextWithoutDatabaseInitialization();

		// Token: 0x060013AF RID: 5039 RVA: 0x00032449 File Offset: 0x00030649
		public virtual global::System.Data.Entity.Internal.ClonedObjectContext CreateObjectContextForDdlOps()
		{
			this.InitializeContext();
			return new global::System.Data.Entity.Internal.ClonedObjectContext(new global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy(this.GetObjectContextWithoutDatabaseInitialization()), this.Connection, this.OriginalConnectionString, false);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0003246E File Offset: 0x0003066E
		protected global::System.Data.Entity.Core.Objects.ObjectContext TempObjectContext
		{
			get
			{
				return (this._tempObjectContext == null) ? null : this._tempObjectContext.ObjectContext;
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003248C File Offset: 0x0003068C
		public virtual void UseTempObjectContext()
		{
			this._tempObjectContextCount++;
			if (this._tempObjectContext == null)
			{
				this._tempObjectContext = new global::System.Data.Entity.Internal.ClonedObjectContext(new global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy(this.GetObjectContextWithoutDatabaseInitialization()), this.Connection, this.OriginalConnectionString, true);
				this.ResetDbSets();
			}
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000324D8 File Offset: 0x000306D8
		public virtual void DisposeTempObjectContext()
		{
			if (this._tempObjectContextCount > 0)
			{
				int num = this._tempObjectContextCount - 1;
				this._tempObjectContextCount = num;
				if (num == 0 && this._tempObjectContext != null)
				{
					this._tempObjectContext.Dispose();
					this._tempObjectContext = null;
					this.ResetDbSets();
				}
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060013B3 RID: 5043 RVA: 0x00032521 File Offset: 0x00030721
		public virtual global::System.Data.Entity.Infrastructure.DbCompiledModel CodeFirstModel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x00032524 File Offset: 0x00030724
		public virtual global::System.Data.Entity.Infrastructure.DbModel ModelBeingInitialized
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00032528 File Offset: 0x00030728
		public virtual void CreateDatabase(global::System.Data.Entity.Core.Objects.ObjectContext objectContext, global::System.Data.Entity.Internal.DatabaseExistenceState existenceState)
		{
			new global::System.Data.Entity.Internal.DatabaseCreator().CreateDatabase(this, (global::System.Data.Entity.Migrations.DbMigrationsConfiguration config, global::System.Data.Entity.DbContext context) => new global::System.Data.Entity.Migrations.DbMigrator(config, context, existenceState, true), objectContext);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0003255A File Offset: 0x0003075A
		public virtual bool CompatibleWithModel(bool throwIfNoMetadata, global::System.Data.Entity.Internal.DatabaseExistenceState existenceState)
		{
			return new global::System.Data.Entity.Internal.ModelCompatibilityChecker().CompatibleWithModel(this, new global::System.Data.Entity.Internal.ModelHashCalculator(), throwIfNoMetadata, existenceState);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0003256E File Offset: 0x0003076E
		public virtual bool ModelMatches(global::System.Data.Entity.Migrations.Infrastructure.VersionedModel model)
		{
			return !new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer().Diff(model.Model, this.Owner.GetModel(), null, null, model.Version, null).Any<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0003259C File Offset: 0x0003079C
		public virtual string QueryForModelHash()
		{
			return new global::System.Data.Entity.Internal.EdmMetadataRepository(this, this.OriginalConnectionString, this.ProviderFactory).QueryForModelHash((global::System.Data.Common.DbConnection c) => new global::System.Data.Entity.Internal.EdmMetadataContext(c));
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000325D4 File Offset: 0x000307D4
		public virtual global::System.Data.Entity.Migrations.Infrastructure.VersionedModel QueryForModel(global::System.Data.Entity.Internal.DatabaseExistenceState existenceState)
		{
			string text;
			string version;
			global::System.Xml.Linq.XDocument lastModel = this.CreateHistoryRepository(existenceState).GetLastModel(out text, out version, null);
			if (lastModel == null)
			{
				return null;
			}
			return new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(lastModel, version);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000325FF File Offset: 0x000307FF
		public virtual void SaveMetadataToDatabase()
		{
			if (this.CodeFirstModel != null)
			{
				this.PerformInitializationAction(delegate
				{
					this.CreateHistoryRepository(global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown).BootstrapUsingEFProviderDdl(new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(this.Owner.GetModel(), null));
				});
			}
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x0003261B File Offset: 0x0003081B
		public virtual bool HasHistoryTableEntry()
		{
			return this.CreateHistoryRepository(global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown).HasMigrations();
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x0003262C File Offset: 0x0003082C
		private global::System.Data.Entity.Migrations.History.HistoryRepository CreateHistoryRepository(global::System.Data.Entity.Internal.DatabaseExistenceState existenceState = global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown)
		{
			this.DiscoverMigrationsConfiguration();
			string originalConnectionString = this.OriginalConnectionString;
			global::System.Data.Common.DbProviderFactory providerFactory = this.ProviderFactory;
			string contextKey = this._migrationsConfiguration().ContextKey;
			int? commandTimeout = this.CommandTimeout;
			global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> historyContextFactory = this.HistoryContextFactory;
			global::System.Collections.Generic.IEnumerable<string> schemas;
			if (this.DefaultSchema == null)
			{
				schemas = global::System.Linq.Enumerable.Empty<string>();
			}
			else
			{
				global::System.Collections.Generic.IEnumerable<string> enumerable = new string[]
				{
					this.DefaultSchema
				};
				schemas = enumerable;
			}
			return new global::System.Data.Entity.Migrations.History.HistoryRepository(this, originalConnectionString, providerFactory, contextKey, commandTimeout, historyContextFactory, schemas, this.Owner, existenceState, null);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00032698 File Offset: 0x00030898
		public virtual global::System.Data.Common.DbTransaction TryGetCurrentStoreTransaction()
		{
			global::System.Data.Entity.Core.EntityClient.EntityTransaction currentTransaction = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.GetObjectContextWithoutDatabaseInitialization().Connection).CurrentTransaction;
			if (currentTransaction == null)
			{
				return null;
			}
			return currentTransaction.StoreTransaction;
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x000326C6 File Offset: 0x000308C6
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x000326CE File Offset: 0x000308CE
		protected bool InInitializationAction { get; set; }

		// Token: 0x060013C0 RID: 5056 RVA: 0x000326D8 File Offset: 0x000308D8
		public void PerformInitializationAction(global::System.Action action)
		{
			if (this.InInitializationAction)
			{
				action();
				return;
			}
			try
			{
				this.InInitializationAction = true;
				action();
			}
			catch (global::System.Data.DataException innerException)
			{
				throw new global::System.Data.DataException(global::System.Data.Entity.Resources.Strings.Database_InitializationException, innerException);
			}
			finally
			{
				this.InInitializationAction = false;
			}
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00032738 File Offset: 0x00030938
		public virtual void RegisterObjectStateManagerChangedEvent(global::System.ComponentModel.CollectionChangeEventHandler handler)
		{
			this.ObjectContext.ObjectStateManager.ObjectStateManagerChanged += handler;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x0003274C File Offset: 0x0003094C
		public virtual bool EntityInContextAndNotDeleted(object entity)
		{
			global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry;
			return this.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(entity, out objectStateEntry) && objectStateEntry.State != global::System.Data.Entity.EntityState.Deleted;
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x0003277C File Offset: 0x0003097C
		public virtual int SaveChanges()
		{
			int result;
			try
			{
				if (this.ValidateOnSaveEnabled)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> validationErrors = this.Owner.GetValidationErrors();
					if (validationErrors.Any<global::System.Data.Entity.Validation.DbEntityValidationResult>())
					{
						throw new global::System.Data.Entity.Validation.DbEntityValidationException(global::System.Data.Entity.Resources.Strings.DbEntityValidationException_ValidationFailed, validationErrors);
					}
				}
				bool flag = this.AutoDetectChangesEnabled && !this.ValidateOnSaveEnabled;
				global::System.Data.Entity.Core.Objects.SaveOptions options = global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | (flag ? global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave : global::System.Data.Entity.Core.Objects.SaveOptions.None);
				result = this.ObjectContext.SaveChanges(options);
			}
			catch (global::System.Data.Entity.Core.UpdateException updateException)
			{
				throw this.WrapUpdateException(updateException);
			}
			return result;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x000327FC File Offset: 0x000309FC
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (this.ValidateOnSaveEnabled)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> validationErrors = this.Owner.GetValidationErrors();
				if (validationErrors.Any<global::System.Data.Entity.Validation.DbEntityValidationResult>())
				{
					throw new global::System.Data.Entity.Validation.DbEntityValidationException(global::System.Data.Entity.Resources.Strings.DbEntityValidationException_ValidationFailed, validationErrors);
				}
			}
			global::System.Threading.Tasks.TaskCompletionSource<int> tcs = new global::System.Threading.Tasks.TaskCompletionSource<int>();
			bool flag = this.AutoDetectChangesEnabled && !this.ValidateOnSaveEnabled;
			global::System.Data.Entity.Core.Objects.SaveOptions options = global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | (flag ? global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave : global::System.Data.Entity.Core.Objects.SaveOptions.None);
			global::System.Func<global::System.Exception, global::System.Exception> <>9__1;
			this.ObjectContext.SaveChangesAsync(options, cancellationToken).ContinueWith(delegate(global::System.Threading.Tasks.Task<int> t)
			{
				if (t.IsFaulted)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Exception> innerExceptions = t.Exception.InnerExceptions;
					global::System.Func<global::System.Exception, global::System.Exception> selector;
					if ((selector = <>9__1) == null)
					{
						selector = (<>9__1 = delegate(global::System.Exception ex)
						{
							global::System.Data.Entity.Core.UpdateException ex2 = ex as global::System.Data.Entity.Core.UpdateException;
							if (ex2 != null)
							{
								return this.WrapUpdateException(ex2);
							}
							return ex;
						});
					}
					global::System.Collections.Generic.IEnumerable<global::System.Exception> exceptions = innerExceptions.Select(selector);
					tcs.TrySetException(exceptions);
					return;
				}
				if (t.IsCanceled)
				{
					tcs.TrySetCanceled();
					return;
				}
				tcs.TrySetResult(t.Result);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			return tcs.Task;
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x0003289E File Offset: 0x00030A9E
		public void Initialize()
		{
			global::System.Diagnostics.Debugger.NotifyOfCrossThreadDependency();
			this.InitializeContext();
			this.InitializeDatabase();
		}

		// Token: 0x060013C6 RID: 5062
		protected abstract void InitializeContext();

		// Token: 0x060013C7 RID: 5063
		public abstract void MarkDatabaseNotInitialized();

		// Token: 0x060013C8 RID: 5064
		protected abstract void InitializeDatabase();

		// Token: 0x060013C9 RID: 5065
		public abstract void MarkDatabaseInitialized();

		// Token: 0x060013CA RID: 5066 RVA: 0x000328B4 File Offset: 0x00030AB4
		public void PerformDatabaseInitialization()
		{
			object obj;
			if ((obj = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(typeof(global::System.Data.Entity.IDatabaseInitializer<>).MakeGenericType(new global::System.Type[]
			{
				this.Owner.GetType()
			}))) == null)
			{
				obj = (this.DefaultInitializer ?? new global::System.Data.Entity.NullDatabaseInitializer<global::System.Data.Entity.DbContext>());
			}
			object obj2 = obj;
			global::System.Action action = (global::System.Action)global::System.Data.Entity.Internal.InternalContext.CreateInitializationActionMethod.MakeGenericMethod(new global::System.Type[]
			{
				this.Owner.GetType()
			}).Invoke(this, new object[]
			{
				obj2
			});
			bool autoDetectChangesEnabled = this.AutoDetectChangesEnabled;
			bool validateOnSaveEnabled = this.ValidateOnSaveEnabled;
			try
			{
				if (!(this.Owner is global::System.Data.Entity.Infrastructure.TransactionContext))
				{
					this.UseTempObjectContext();
				}
				this.PerformInitializationAction(action);
			}
			finally
			{
				if (!(this.Owner is global::System.Data.Entity.Infrastructure.TransactionContext))
				{
					this.DisposeTempObjectContext();
				}
				this.AutoDetectChangesEnabled = autoDetectChangesEnabled;
				this.ValidateOnSaveEnabled = validateOnSaveEnabled;
			}
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00032994 File Offset: 0x00030B94
		private global::System.Action CreateInitializationAction<TContext>(global::System.Data.Entity.IDatabaseInitializer<TContext> initializer) where TContext : global::System.Data.Entity.DbContext
		{
			return delegate()
			{
				initializer.InitializeDatabase((TContext)((object)this.Owner));
			};
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x060013CC RID: 5068
		public abstract global::System.Data.Entity.IDatabaseInitializer<global::System.Data.Entity.DbContext> DefaultInitializer { get; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x060013CD RID: 5069
		// (set) Token: 0x060013CE RID: 5070
		public abstract bool EnsureTransactionsForFunctionsAndCommands { get; set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x060013CF RID: 5071
		// (set) Token: 0x060013D0 RID: 5072
		public abstract bool LazyLoadingEnabled { get; set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060013D1 RID: 5073
		// (set) Token: 0x060013D2 RID: 5074
		public abstract bool ProxyCreationEnabled { get; set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060013D3 RID: 5075
		// (set) Token: 0x060013D4 RID: 5076
		public abstract bool UseDatabaseNullSemantics { get; set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060013D5 RID: 5077
		// (set) Token: 0x060013D6 RID: 5078
		public abstract bool DisableFilterOverProjectionSimplificationForCustomFunctions { get; set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060013D7 RID: 5079
		// (set) Token: 0x060013D8 RID: 5080
		public abstract int? CommandTimeout { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000329B4 File Offset: 0x00030BB4
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x000329BC File Offset: 0x00030BBC
		public bool AutoDetectChangesEnabled { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x000329C5 File Offset: 0x00030BC5
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x000329CD File Offset: 0x00030BCD
		public bool ValidateOnSaveEnabled { get; set; }

		// Token: 0x060013DD RID: 5085 RVA: 0x000329D8 File Offset: 0x00030BD8
		protected void LoadContextConfigs()
		{
			int? num = this.AppConfig.ContextConfigs.TryGetCommandTimeout(this.Owner.GetType());
			if (num != null)
			{
				this.CommandTimeout = new int?(num.Value);
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00032A1C File Offset: 0x00030C1C
		~InternalContext()
		{
			this.DisposeContext(false);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00032A4C File Offset: 0x00030C4C
		public void Dispose()
		{
			this.DisposeContext(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00032A5C File Offset: 0x00030C5C
		public virtual void DisposeContext(bool disposing)
		{
			if (!this.IsDisposed)
			{
				if (disposing && this.OnDisposing != null)
				{
					this.OnDisposing(this, new global::System.EventArgs());
					this.OnDisposing = null;
				}
				if (this._tempObjectContext != null)
				{
					this._tempObjectContext.Dispose();
				}
				this.Log = null;
				this.IsDisposed = true;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00032AB5 File Offset: 0x00030CB5
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x00032ABD File Offset: 0x00030CBD
		public bool IsDisposed { get; private set; }

		// Token: 0x060013E3 RID: 5091 RVA: 0x00032AC6 File Offset: 0x00030CC6
		public virtual void DetectChanges(bool force = false)
		{
			if (this.AutoDetectChangesEnabled || force)
			{
				this.ObjectContext.DetectChanges();
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00032AE0 File Offset: 0x00030CE0
		public virtual global::System.Data.Entity.IDbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			if (typeof(TEntity) != global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(typeof(TEntity)))
			{
				throw global::System.Data.Entity.Resources.Error.CannotCallGenericSetWithProxyType();
			}
			global::System.Data.Entity.Internal.Linq.IInternalSetAdapter internalSetAdapter;
			if (!this._genericSets.TryGetValue(typeof(TEntity), out internalSetAdapter))
			{
				global::System.Data.Entity.Internal.Linq.IInternalSet internalSet2;
				if (!this._nonGenericSets.TryGetValue(typeof(TEntity), out internalSetAdapter))
				{
					global::System.Data.Entity.Internal.Linq.IInternalSet internalSet = new global::System.Data.Entity.Internal.Linq.InternalSet<TEntity>(this);
					internalSet2 = internalSet;
				}
				else
				{
					internalSet2 = internalSetAdapter.InternalSet;
				}
				internalSetAdapter = new global::System.Data.Entity.DbSet<TEntity>((global::System.Data.Entity.Internal.Linq.InternalSet<TEntity>)internalSet2);
				this._genericSets.Add(typeof(TEntity), internalSetAdapter);
			}
			return (global::System.Data.Entity.IDbSet<TEntity>)internalSetAdapter;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00032B7C File Offset: 0x00030D7C
		public virtual global::System.Data.Entity.Internal.Linq.IInternalSetAdapter Set(global::System.Type entityType)
		{
			entityType = global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(entityType);
			global::System.Data.Entity.Internal.Linq.IInternalSetAdapter internalSetAdapter;
			if (!this._nonGenericSets.TryGetValue(entityType, out internalSetAdapter))
			{
				internalSetAdapter = this.CreateInternalSet(entityType, this._genericSets.TryGetValue(entityType, out internalSetAdapter) ? internalSetAdapter.InternalSet : null);
				this._nonGenericSets.Add(entityType, internalSetAdapter);
			}
			return internalSetAdapter;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00032BD0 File Offset: 0x00030DD0
		private global::System.Data.Entity.Internal.Linq.IInternalSetAdapter CreateInternalSet(global::System.Type entityType, global::System.Data.Entity.Internal.Linq.IInternalSet internalSet)
		{
			global::System.Func<global::System.Data.Entity.Internal.InternalContext, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter> func;
			if (!global::System.Data.Entity.Internal.InternalContext._setFactories.TryGetValue(entityType, out func))
			{
				if (entityType.IsValueType())
				{
					throw global::System.Data.Entity.Resources.Error.DbSet_EntityTypeNotInModel(entityType.Name);
				}
				global::System.Reflection.MethodInfo declaredMethod = typeof(global::System.Data.Entity.Internal.Linq.InternalDbSet<>).MakeGenericType(new global::System.Type[]
				{
					entityType
				}).GetDeclaredMethod("Create", new global::System.Type[]
				{
					typeof(global::System.Data.Entity.Internal.InternalContext),
					typeof(global::System.Data.Entity.Internal.Linq.IInternalSet)
				});
				func = (global::System.Func<global::System.Data.Entity.Internal.InternalContext, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Internal.InternalContext, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>), declaredMethod);
				global::System.Data.Entity.Internal.InternalContext._setFactories.TryAdd(entityType, func);
			}
			return func(this, internalSet);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00032C6F File Offset: 0x00030E6F
		public virtual global::System.Data.Entity.Internal.EntitySetTypePair GetEntitySetAndBaseTypeForType(global::System.Type entityType)
		{
			this.Initialize();
			this.UpdateEntitySetMappingsForType(entityType);
			return this.GetEntitySetMappingForType(entityType);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00032C85 File Offset: 0x00030E85
		public virtual global::System.Data.Entity.Internal.EntitySetTypePair TryGetEntitySetAndBaseTypeForType(global::System.Type entityType)
		{
			this.Initialize();
			if (!this.TryUpdateEntitySetMappingsForType(entityType))
			{
				return null;
			}
			return this.GetEntitySetMappingForType(entityType);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00032C9F File Offset: 0x00030E9F
		public virtual bool IsEntityTypeMapped(global::System.Type entityType)
		{
			this.Initialize();
			return this.TryUpdateEntitySetMappingsForType(entityType);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00032CB0 File Offset: 0x00030EB0
		public virtual global::System.Collections.Generic.IEnumerable<TEntity> GetLocalEntities<TEntity>()
		{
			return from e in this.ObjectContext.ObjectStateManager.GetObjectStateEntries(global::System.Data.Entity.EntityState.Unchanged | global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Modified)
			where e.Entity is TEntity
			select (TEntity)((object)e.Entity);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x00032D18 File Offset: 0x00030F18
		public virtual global::System.Collections.Generic.IEnumerator<TElement> ExecuteSqlQuery<TElement>(string sql, bool? streaming, object[] parameters)
		{
			this.ObjectContext.AsyncMonitor.EnsureNotEntered();
			return new global::System.Data.Entity.Internal.LazyEnumerator<TElement>(delegate()
			{
				this.Initialize();
				return this.ObjectContext.ExecuteStoreQuery<TElement>(sql, new global::System.Data.Entity.Core.Objects.ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, streaming), parameters);
			});
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00032D68 File Offset: 0x00030F68
		public virtual global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement> ExecuteSqlQueryAsync<TElement>(string sql, bool? streaming, object[] parameters)
		{
			this.ObjectContext.AsyncMonitor.EnsureNotEntered();
			return new global::System.Data.Entity.Internal.LazyAsyncEnumerator<TElement>(delegate(global::System.Threading.CancellationToken cancellationToken)
			{
				this.Initialize();
				return this.ObjectContext.ExecuteStoreQueryAsync<TElement>(sql, new global::System.Data.Entity.Core.Objects.ExecutionOptions(global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, streaming), cancellationToken, parameters);
			});
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00032DB8 File Offset: 0x00030FB8
		public virtual global::System.Collections.IEnumerator ExecuteSqlQuery(global::System.Type elementType, string sql, bool? streaming, object[] parameters)
		{
			global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Collections.IEnumerator> func;
			if (!global::System.Data.Entity.Internal.InternalContext._queryExecutors.TryGetValue(elementType, out func))
			{
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.InternalContext.ExecuteSqlQueryAsIEnumeratorMethod.MakeGenericMethod(new global::System.Type[]
				{
					elementType
				});
				func = (global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Collections.IEnumerator>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Collections.IEnumerator>), method);
				global::System.Data.Entity.Internal.InternalContext._queryExecutors.TryAdd(elementType, func);
			}
			return func(this, sql, streaming, parameters);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00032E17 File Offset: 0x00031017
		private global::System.Collections.IEnumerator ExecuteSqlQueryAsIEnumerator<TElement>(string sql, bool? streaming, object[] parameters)
		{
			return this.ExecuteSqlQuery<TElement>(sql, streaming, parameters);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00032E24 File Offset: 0x00031024
		public virtual global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator ExecuteSqlQueryAsync(global::System.Type elementType, string sql, bool? streaming, object[] parameters)
		{
			global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator> func;
			if (!global::System.Data.Entity.Internal.InternalContext._asyncQueryExecutors.TryGetValue(elementType, out func))
			{
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.InternalContext.ExecuteSqlQueryAsIDbAsyncEnumeratorMethod.MakeGenericMethod(new global::System.Type[]
				{
					elementType
				});
				func = (global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator>), method);
				global::System.Data.Entity.Internal.InternalContext._asyncQueryExecutors.TryAdd(elementType, func);
			}
			return func(this, sql, streaming, parameters);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00032E83 File Offset: 0x00031083
		private global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator ExecuteSqlQueryAsIDbAsyncEnumerator<TElement>(string sql, bool? streaming, object[] parameters)
		{
			return this.ExecuteSqlQueryAsync<TElement>(sql, streaming, parameters);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00032E8E File Offset: 0x0003108E
		public virtual int ExecuteSqlCommand(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string sql, object[] parameters)
		{
			this.Initialize();
			return this.ObjectContext.ExecuteStoreCommand(transactionalBehavior, sql, parameters);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00032EA4 File Offset: 0x000310A4
		public virtual global::System.Threading.Tasks.Task<int> ExecuteSqlCommandAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string sql, global::System.Threading.CancellationToken cancellationToken, object[] parameters)
		{
			this.Initialize();
			return this.ObjectContext.ExecuteStoreCommandAsync(transactionalBehavior, sql, cancellationToken, parameters);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00032EBC File Offset: 0x000310BC
		public virtual global::System.Data.Entity.Internal.IEntityStateEntry GetStateEntry(object entity)
		{
			this.DetectChanges(false);
			global::System.Data.Entity.Core.Objects.ObjectStateEntry stateEntry;
			if (!this.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(entity, out stateEntry))
			{
				return null;
			}
			return new global::System.Data.Entity.Internal.StateEntryAdapter(stateEntry);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00032EED File Offset: 0x000310ED
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.IEntityStateEntry> GetStateEntries()
		{
			return this.GetStateEntries((global::System.Data.Entity.Core.Objects.ObjectStateEntry e) => e.Entity != null);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00032F14 File Offset: 0x00031114
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.IEntityStateEntry> GetStateEntries<TEntity>() where TEntity : class
		{
			return this.GetStateEntries((global::System.Data.Entity.Core.Objects.ObjectStateEntry e) => e.Entity is TEntity);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00032F3C File Offset: 0x0003113C
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.IEntityStateEntry> GetStateEntries(global::System.Func<global::System.Data.Entity.Core.Objects.ObjectStateEntry, bool> predicate)
		{
			this.DetectChanges(false);
			return from e in this.ObjectContext.ObjectStateManager.GetObjectStateEntries(~global::System.Data.Entity.EntityState.Detached).Where(predicate)
			select new global::System.Data.Entity.Internal.StateEntryAdapter(e);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x00032F8C File Offset: 0x0003118C
		public virtual global::System.Data.Entity.Infrastructure.DbUpdateException WrapUpdateException(global::System.Data.Entity.Core.UpdateException updateException)
		{
			if (updateException.StateEntries != null)
			{
				if (updateException.StateEntries.Any((global::System.Data.Entity.Core.Objects.ObjectStateEntry e) => e.Entity == null))
				{
					return new global::System.Data.Entity.Infrastructure.DbUpdateException(this, updateException, true);
				}
			}
			global::System.Data.Entity.Core.OptimisticConcurrencyException ex = updateException as global::System.Data.Entity.Core.OptimisticConcurrencyException;
			if (ex == null)
			{
				return new global::System.Data.Entity.Infrastructure.DbUpdateException(this, updateException, false);
			}
			return new global::System.Data.Entity.Infrastructure.DbUpdateConcurrencyException(this, ex);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x00032FF0 File Offset: 0x000311F0
		public virtual TEntity CreateObject<TEntity>() where TEntity : class
		{
			return this.ObjectContext.CreateObject<TEntity>();
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00033000 File Offset: 0x00031200
		public virtual object CreateObject(global::System.Type type)
		{
			global::System.Func<global::System.Data.Entity.Internal.InternalContext, object> func;
			if (!global::System.Data.Entity.Internal.InternalContext._entityFactories.TryGetValue(type, out func))
			{
				global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.InternalContext.CreateObjectAsObjectMethod.MakeGenericMethod(new global::System.Type[]
				{
					type
				});
				func = (global::System.Func<global::System.Data.Entity.Internal.InternalContext, object>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Internal.InternalContext, object>), method);
				global::System.Data.Entity.Internal.InternalContext._entityFactories.TryAdd(type, func);
			}
			return func(this);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0003305B File Offset: 0x0003125B
		private object CreateObjectAsObject<TEntity>() where TEntity : class
		{
			return this.CreateObject<TEntity>();
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x060013FB RID: 5115
		public abstract global::System.Data.Common.DbConnection Connection { get; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x060013FC RID: 5116
		public abstract string OriginalConnectionString { get; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060013FD RID: 5117
		public abstract global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin { get; }

		// Token: 0x060013FE RID: 5118
		public abstract void OverrideConnection(global::System.Data.Entity.Internal.IInternalConnection connection);

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00033068 File Offset: 0x00031268
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x00033076 File Offset: 0x00031276
		public virtual global::System.Data.Entity.Internal.AppConfig AppConfig
		{
			get
			{
				this.CheckContextNotDisposed();
				return this._appConfig;
			}
			set
			{
				this.CheckContextNotDisposed();
				this._appConfig = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00033085 File Offset: 0x00031285
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x00033088 File Offset: 0x00031288
		public virtual global::System.Data.Entity.Infrastructure.DbProviderInfo ModelProviderInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0003308A File Offset: 0x0003128A
		public virtual string ConnectionStringName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x0003308D File Offset: 0x0003128D
		public virtual string ProviderName
		{
			get
			{
				return this.Connection.GetProviderInvariantName();
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x0003309C File Offset: 0x0003129C
		public global::System.Data.Common.DbProviderFactory ProviderFactory
		{
			get
			{
				global::System.Data.Common.DbProviderFactory result;
				if ((result = this._providerFactory) == null)
				{
					result = (this._providerFactory = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(this.Connection));
				}
				return result;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x000330C7 File Offset: 0x000312C7
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x000330CA File Offset: 0x000312CA
		public virtual global::System.Action<global::System.Data.Entity.DbModelBuilder> OnModelCreating
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000330CC File Offset: 0x000312CC
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x000330D4 File Offset: 0x000312D4
		public bool InitializerDisabled { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000330DD File Offset: 0x000312DD
		public virtual global::System.Data.Entity.Internal.DatabaseOperations DatabaseOperations
		{
			get
			{
				return new global::System.Data.Entity.Internal.DatabaseOperations();
			}
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x000330E4 File Offset: 0x000312E4
		protected void CheckContextNotDisposed()
		{
			if (this.IsDisposed)
			{
				throw global::System.Data.Entity.Resources.Error.DbContext_Disposed();
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x000330F4 File Offset: 0x000312F4
		protected void ResetDbSets()
		{
			foreach (global::System.Data.Entity.Internal.Linq.IInternalSetAdapter internalSetAdapter in this._genericSets.Values.Union(this._nonGenericSets.Values))
			{
				internalSetAdapter.InternalSet.ResetQuery();
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00033158 File Offset: 0x00031358
		public void ForceOSpaceLoadingForKnownEntityTypes()
		{
			if (!this._oSpaceLoadingForced)
			{
				this._oSpaceLoadingForced = true;
				this.Initialize();
				foreach (global::System.Data.Entity.Internal.Linq.IInternalSetAdapter internalSetAdapter in this._genericSets.Values.Union(this._nonGenericSets.Values))
				{
					internalSetAdapter.InternalSet.TryInitialize();
				}
			}
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x000331D4 File Offset: 0x000313D4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private bool TryUpdateEntitySetMappingsForType(global::System.Type entityType)
		{
			return this.GetObjectContextWithoutDatabaseInitialization().MetadataWorkspace.MetadataOptimization.TryUpdateEntitySetMappingsForType(entityType);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x000331EC File Offset: 0x000313EC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private global::System.Data.Entity.Internal.EntitySetTypePair GetEntitySetMappingForType(global::System.Type entityType)
		{
			return this.GetObjectContextWithoutDatabaseInitialization().MetadataWorkspace.MetadataOptimization.EntitySetMappingCache[entityType];
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00033209 File Offset: 0x00031409
		private void UpdateEntitySetMappingsForType(global::System.Type entityType)
		{
			if (this.TryUpdateEntitySetMappingsForType(entityType))
			{
				return;
			}
			if (this.IsComplexType(entityType))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_DbSetUsedWithComplexType(entityType.Name);
			}
			if (global::System.Data.Entity.Internal.InternalContext.IsPocoTypeInNonPocoAssembly(entityType))
			{
				throw global::System.Data.Entity.Resources.Error.DbSet_PocoAndNonPocoMixedInSameAssembly(entityType.Name);
			}
			throw global::System.Data.Entity.Resources.Error.DbSet_EntityTypeNotInModel(entityType.Name);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00033249 File Offset: 0x00031449
		private static bool IsPocoTypeInNonPocoAssembly(global::System.Type entityType)
		{
			return entityType.Assembly().GetCustomAttributes<global::System.Data.Entity.Core.Objects.DataClasses.EdmSchemaAttribute>().Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmSchemaAttribute>() && !entityType.GetCustomAttributes(true).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmEntityTypeAttribute>();
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00033270 File Offset: 0x00031470
		private bool IsComplexType(global::System.Type clrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = this.GetObjectContextWithoutDatabaseInitialization().MetadataWorkspace;
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)metadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			return metadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace).Any((global::System.Data.Entity.Core.Metadata.Edm.ComplexType t) => objectItemCollection.GetClrType(t) == clrType);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000332C0 File Offset: 0x000314C0
		public void ApplyContextInfo(global::System.Data.Entity.Infrastructure.DbContextInfo info)
		{
			if (this._contextInfo != null)
			{
				return;
			}
			this.InitializerDisabled = true;
			this._contextInfo = info;
			this._contextInfo.ConfigureContext(this.Owner);
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x000332EA File Offset: 0x000314EA
		public virtual global::System.Data.Entity.Internal.Validation.ValidationProvider ValidationProvider
		{
			get
			{
				return this._validationProvider;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000332F2 File Offset: 0x000314F2
		public virtual string DefaultSchema
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x000332F5 File Offset: 0x000314F5
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x00033307 File Offset: 0x00031507
		public string DefaultContextKey
		{
			get
			{
				return this._defaultContextKey ?? this.OwnerShortTypeName;
			}
			set
			{
				this._defaultContextKey = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00033310 File Offset: 0x00031510
		public global::System.Data.Entity.Migrations.DbMigrationsConfiguration MigrationsConfiguration
		{
			get
			{
				this.DiscoverMigrationsConfiguration();
				return this._migrationsConfiguration();
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001419 RID: 5145 RVA: 0x00033323 File Offset: 0x00031523
		public global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> HistoryContextFactory
		{
			get
			{
				this.DiscoverMigrationsConfiguration();
				return this._migrationsConfiguration().GetHistoryContextFactory(this.ProviderName);
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x00033341 File Offset: 0x00031541
		public virtual bool MigrationsConfigurationDiscovered
		{
			get
			{
				this.DiscoverMigrationsConfiguration();
				return this._migrationsConfigurationDiscovered.Value;
			}
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00033354 File Offset: 0x00031554
		private void DiscoverMigrationsConfiguration()
		{
			if (this._migrationsConfigurationDiscovered == null)
			{
				global::System.Type contextType = this.Owner.GetType();
				global::System.Data.Entity.Migrations.DbMigrationsConfiguration discoveredConfig = new global::System.Data.Entity.Migrations.Utilities.MigrationsConfigurationFinder(new global::System.Data.Entity.Utilities.TypeFinder(contextType.Assembly)).FindMigrationsConfiguration(contextType, null, null, null, null, null);
				if (discoveredConfig != null)
				{
					this._migrationsConfiguration = (() => discoveredConfig);
					this._migrationsConfigurationDiscovered = new bool?(true);
					return;
				}
				global::System.Func<global::System.Data.Entity.Migrations.DbMigrationsConfiguration> <>9__2;
				this._migrationsConfiguration = delegate()
				{
					global::System.Func<global::System.Data.Entity.Migrations.DbMigrationsConfiguration> valueFactory;
					if ((valueFactory = <>9__2) == null)
					{
						valueFactory = (<>9__2 = (() => new global::System.Data.Entity.Migrations.DbMigrationsConfiguration
						{
							ContextType = contextType,
							AutomaticMigrationsEnabled = true,
							MigrationsAssembly = contextType.Assembly,
							MigrationsNamespace = contextType.Namespace,
							ContextKey = this.DefaultContextKey,
							TargetDatabase = new global::System.Data.Entity.Infrastructure.DbConnectionInfo(this.OriginalConnectionString, this.ProviderName),
							CommandTimeout = this.CommandTimeout
						}));
					}
					return new global::System.Lazy<global::System.Data.Entity.Migrations.DbMigrationsConfiguration>(valueFactory).Value;
				};
				this._migrationsConfigurationDiscovered = new bool?(false);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000333FF File Offset: 0x000315FF
		internal virtual string OwnerShortTypeName
		{
			get
			{
				return this.Owner.GetType().ToString();
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00033411 File Offset: 0x00031611
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00033428 File Offset: 0x00031628
		public virtual global::System.Action<string> Log
		{
			get
			{
				if (this._logFormatter == null)
				{
					return null;
				}
				return this._logFormatter.WriteAction;
			}
			set
			{
				if (this._logFormatter == null || this._logFormatter.WriteAction != value)
				{
					if (this._logFormatter != null)
					{
						this._dispatchers.Value.RemoveInterceptor(this._logFormatter);
						this._logFormatter = null;
					}
					if (value != null)
					{
						this._logFormatter = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter>>()(this.Owner, value);
						this._dispatchers.Value.AddInterceptor(this._logFormatter);
					}
				}
			}
		}

		// Token: 0x04000960 RID: 2400
		public static readonly global::System.Reflection.MethodInfo CreateObjectAsObjectMethod = typeof(global::System.Data.Entity.Internal.InternalContext).GetOnlyDeclaredMethod("CreateObjectAsObject");

		// Token: 0x04000961 RID: 2401
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, object>> _entityFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, object>>();

		// Token: 0x04000962 RID: 2402
		public static readonly global::System.Reflection.MethodInfo ExecuteSqlQueryAsIEnumeratorMethod = typeof(global::System.Data.Entity.Internal.InternalContext).GetOnlyDeclaredMethod("ExecuteSqlQueryAsIEnumerator");

		// Token: 0x04000963 RID: 2403
		public static readonly global::System.Reflection.MethodInfo ExecuteSqlQueryAsIDbAsyncEnumeratorMethod = typeof(global::System.Data.Entity.Internal.InternalContext).GetOnlyDeclaredMethod("ExecuteSqlQueryAsIDbAsyncEnumerator");

		// Token: 0x04000964 RID: 2404
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Collections.IEnumerator>> _queryExecutors = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Collections.IEnumerator>>();

		// Token: 0x04000965 RID: 2405
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator>> _asyncQueryExecutors = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, string, bool?, object[], global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator>>();

		// Token: 0x04000966 RID: 2406
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>> _setFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Internal.InternalContext, global::System.Data.Entity.Internal.Linq.IInternalSet, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>>();

		// Token: 0x04000967 RID: 2407
		public static readonly global::System.Reflection.MethodInfo CreateInitializationActionMethod = typeof(global::System.Data.Entity.Internal.InternalContext).GetOnlyDeclaredMethod("CreateInitializationAction");

		// Token: 0x04000968 RID: 2408
		private global::System.Data.Entity.Internal.AppConfig _appConfig = global::System.Data.Entity.Internal.AppConfig.DefaultInstance;

		// Token: 0x04000969 RID: 2409
		private readonly global::System.Data.Entity.DbContext _owner;

		// Token: 0x0400096A RID: 2410
		private global::System.Data.Entity.Internal.ClonedObjectContext _tempObjectContext;

		// Token: 0x0400096B RID: 2411
		private int _tempObjectContextCount;

		// Token: 0x0400096C RID: 2412
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter> _genericSets = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>();

		// Token: 0x0400096D RID: 2413
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter> _nonGenericSets = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter>();

		// Token: 0x0400096E RID: 2414
		private readonly global::System.Data.Entity.Internal.Validation.ValidationProvider _validationProvider = new global::System.Data.Entity.Internal.Validation.ValidationProvider(null, global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>());

		// Token: 0x0400096F RID: 2415
		private bool _oSpaceLoadingForced;

		// Token: 0x04000970 RID: 2416
		private global::System.Data.Common.DbProviderFactory _providerFactory;

		// Token: 0x04000971 RID: 2417
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> _dispatchers;

		// Token: 0x04000973 RID: 2419
		private global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter _logFormatter;

		// Token: 0x04000974 RID: 2420
		private global::System.Func<global::System.Data.Entity.Migrations.DbMigrationsConfiguration> _migrationsConfiguration;

		// Token: 0x04000975 RID: 2421
		private bool? _migrationsConfigurationDiscovered;

		// Token: 0x04000976 RID: 2422
		private global::System.Data.Entity.Infrastructure.DbContextInfo _contextInfo;

		// Token: 0x04000977 RID: 2423
		private string _defaultContextKey;
	}
}
