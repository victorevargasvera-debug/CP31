using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000414 RID: 1044
	public class ObjectContext : global::System.IDisposable, global::System.Data.Entity.Infrastructure.IObjectContextAdapter
	{
		// Token: 0x0600317D RID: 12669 RVA: 0x0009CBF0 File Offset: 0x0009ADF0
		public ObjectContext(global::System.Data.Entity.Core.EntityClient.EntityConnection connection) : this(connection, true, null, null, null)
		{
			this._contextOwnsConnection = false;
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x0009CC04 File Offset: 0x0009AE04
		public ObjectContext(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, bool contextOwnsConnection) : this(connection, true, null, null, null)
		{
			this._contextOwnsConnection = contextOwnsConnection;
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x0009CC18 File Offset: 0x0009AE18
		public ObjectContext(string connectionString) : this(global::System.Data.Entity.Core.Objects.ObjectContext.CreateEntityConnection(connectionString), false, null, null, null)
		{
			this._contextOwnsConnection = true;
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x0009CC31 File Offset: 0x0009AE31
		protected ObjectContext(string connectionString, string defaultContainerName) : this(connectionString)
		{
			this.DefaultContainerName = defaultContainerName;
			if (!string.IsNullOrEmpty(defaultContainerName))
			{
				this._disallowSettingDefaultContainerName = true;
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x0009CC50 File Offset: 0x0009AE50
		protected ObjectContext(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, string defaultContainerName) : this(connection)
		{
			this.DefaultContainerName = defaultContainerName;
			if (!string.IsNullOrEmpty(defaultContainerName))
			{
				this._disallowSettingDefaultContainerName = true;
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x0009CC70 File Offset: 0x0009AE70
		internal ObjectContext(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, bool isConnectionConstructor, global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory, global::System.Data.Entity.Core.Common.Internal.Materialization.Translator translator = null, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory columnMapFactory = null)
		{
			this._options = new global::System.Data.Entity.Core.Objects.ObjectContextOptions();
			this._asyncMonitor = new global::System.Data.Entity.Internal.ThrowingMonitor();
			base..ctor();
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.EntityClient.EntityConnection>(connection, "connection");
			this._interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithObjectContext(this);
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
			this._translator = (translator ?? new global::System.Data.Entity.Core.Common.Internal.Materialization.Translator());
			this._columnMapFactory = (columnMapFactory ?? new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory());
			this._adapter = new global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter(this);
			this._connection = connection;
			this._connection.AssociateContext(this);
			this._connection.StateChange += this.ConnectionStateChange;
			this._entityWrapperFactory = new global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory();
			string connectionString = connection.ConnectionString;
			if (connectionString == null || connectionString.Trim().Length == 0)
			{
				throw isConnectionConstructor ? new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidConnection, "connection", null) : new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidConnectionString, "connectionString", null);
			}
			try
			{
				this._workspace = this.RetrieveMetadataWorkspaceFromConnection();
			}
			catch (global::System.InvalidOperationException innerException)
			{
				throw isConnectionConstructor ? new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidConnection, "connection", innerException) : new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidConnectionString, "connectionString", innerException);
			}
			string value = global::System.Configuration.ConfigurationManager.AppSettings["EntityFramework_UseLegacyPreserveChangesBehavior"];
			bool useLegacyPreserveChangesBehavior = false;
			if (bool.TryParse(value, out useLegacyPreserveChangesBehavior))
			{
				this.ContextOptions.UseLegacyPreserveChangesBehavior = useLegacyPreserveChangesBehavior;
			}
			this.InitializeMappingViewCacheFactory(null);
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x0009CDDC File Offset: 0x0009AFDC
		internal ObjectContext(global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory objectQueryExecutionPlanFactory = null, global::System.Data.Entity.Core.Common.Internal.Materialization.Translator translator = null, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory columnMapFactory = null, global::System.Data.Entity.Core.EntityClient.Internal.IEntityAdapter adapter = null)
		{
			this._options = new global::System.Data.Entity.Core.Objects.ObjectContextOptions();
			this._asyncMonitor = new global::System.Data.Entity.Internal.ThrowingMonitor();
			base..ctor();
			this._interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithObjectContext(this);
			this._objectQueryExecutionPlanFactory = (objectQueryExecutionPlanFactory ?? new global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory(null));
			this._translator = (translator ?? new global::System.Data.Entity.Core.Common.Internal.Materialization.Translator());
			this._columnMapFactory = (columnMapFactory ?? new global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory());
			this._adapter = (adapter ?? new global::System.Data.Entity.Core.EntityClient.Internal.EntityAdapter(this));
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x0009CE59 File Offset: 0x0009B059
		public virtual global::System.Data.Common.DbConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					throw new global::System.ObjectDisposedException(null, global::System.Data.Entity.Resources.Strings.ObjectContext_ObjectDisposed);
				}
				return this._connection;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x0009CE78 File Offset: 0x0009B078
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x0009CEA0 File Offset: 0x0009B0A0
		public virtual string DefaultContainerName
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntityContainer defaultContainer = this.Perspective.GetDefaultContainer();
				if (defaultContainer == null)
				{
					return string.Empty;
				}
				return defaultContainer.Name;
			}
			set
			{
				if (!this._disallowSettingDefaultContainerName)
				{
					this.Perspective.SetDefaultContainer(value);
					return;
				}
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotSetDefaultContainerName);
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x0009CEC1 File Offset: 0x0009B0C1
		public virtual global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this._workspace;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x0009CEC9 File Offset: 0x0009B0C9
		public virtual global::System.Data.Entity.Core.Objects.ObjectStateManager ObjectStateManager
		{
			get
			{
				if (this._objectStateManager == null)
				{
					this._objectStateManager = new global::System.Data.Entity.Core.Objects.ObjectStateManager(this._workspace);
				}
				return this._objectStateManager;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0009CEEA File Offset: 0x0009B0EA
		internal bool ContextOwnsConnection
		{
			set
			{
				this._contextOwnsConnection = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x0009CEF3 File Offset: 0x0009B0F3
		internal global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective Perspective
		{
			get
			{
				if (this._perspective == null)
				{
					this._perspective = new global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective(this.MetadataWorkspace);
				}
				return this._perspective;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x0009CF14 File Offset: 0x0009B114
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x0009CF1C File Offset: 0x0009B11C
		public virtual int? CommandTimeout
		{
			get
			{
				return this._queryTimeout;
			}
			set
			{
				if (value != null)
				{
					int? num = value;
					int num2 = 0;
					if (num.GetValueOrDefault() < num2 & num != null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidCommandTimeout, "value");
					}
				}
				this._queryTimeout = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x0009CF61 File Offset: 0x0009B161
		protected internal virtual global::System.Linq.IQueryProvider QueryProvider
		{
			get
			{
				if (this._queryProvider == null)
				{
					this._queryProvider = new global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider(this);
				}
				return this._queryProvider;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x0009CF7D File Offset: 0x0009B17D
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0009CF85 File Offset: 0x0009B185
		internal bool InMaterialization { get; set; }

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x0009CF8E File Offset: 0x0009B18E
		internal global::System.Data.Entity.Internal.ThrowingMonitor AsyncMonitor
		{
			get
			{
				return this._asyncMonitor;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x0009CF96 File Offset: 0x0009B196
		public virtual global::System.Data.Entity.Core.Objects.ObjectContextOptions ContextOptions
		{
			get
			{
				return this._options;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x0009CF9E File Offset: 0x0009B19E
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x0009CFA6 File Offset: 0x0009B1A6
		internal global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap ColumnMapBuilder { get; set; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x0009CFAF File Offset: 0x0009B1AF
		internal virtual global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory EntityWrapperFactory
		{
			get
			{
				return this._entityWrapperFactory;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x0009CFB7 File Offset: 0x0009B1B7
		global::System.Data.Entity.Core.Objects.ObjectContext global::System.Data.Entity.Infrastructure.IObjectContextAdapter.ObjectContext
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x0009CFBA File Offset: 0x0009B1BA
		public global::System.Data.Entity.Infrastructure.TransactionHandler TransactionHandler
		{
			get
			{
				this.EnsureTransactionHandlerRegistered();
				return this._transactionHandler;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x0009CFC8 File Offset: 0x0009B1C8
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x0009CFD0 File Offset: 0x0009B1D0
		public global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext InterceptionContext
		{
			get
			{
				return this._interceptionContext;
			}
			internal set
			{
				this._interceptionContext = value;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06003199 RID: 12697 RVA: 0x0009CFD9 File Offset: 0x0009B1D9
		// (remove) Token: 0x0600319A RID: 12698 RVA: 0x0009CFF2 File Offset: 0x0009B1F2
		public event global::System.EventHandler SavingChanges
		{
			add
			{
				this._onSavingChanges = (global::System.EventHandler)global::System.Delegate.Combine(this._onSavingChanges, value);
			}
			remove
			{
				this._onSavingChanges = (global::System.EventHandler)global::System.Delegate.Remove(this._onSavingChanges, value);
			}
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x0009D00B File Offset: 0x0009B20B
		private void OnSavingChanges()
		{
			if (this._onSavingChanges != null)
			{
				this._onSavingChanges(this, new global::System.EventArgs());
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600319C RID: 12700 RVA: 0x0009D026 File Offset: 0x0009B226
		// (remove) Token: 0x0600319D RID: 12701 RVA: 0x0009D03F File Offset: 0x0009B23F
		public event global::System.Data.Entity.Core.Objects.ObjectMaterializedEventHandler ObjectMaterialized
		{
			add
			{
				this._onObjectMaterialized = (global::System.Data.Entity.Core.Objects.ObjectMaterializedEventHandler)global::System.Delegate.Combine(this._onObjectMaterialized, value);
			}
			remove
			{
				this._onObjectMaterialized = (global::System.Data.Entity.Core.Objects.ObjectMaterializedEventHandler)global::System.Delegate.Remove(this._onObjectMaterialized, value);
			}
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x0009D058 File Offset: 0x0009B258
		internal void OnObjectMaterialized(object entity)
		{
			if (this._onObjectMaterialized != null)
			{
				this._onObjectMaterialized(this, new global::System.Data.Entity.Core.Objects.ObjectMaterializedEventArgs(entity));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x0009D074 File Offset: 0x0009B274
		internal bool OnMaterializedHasHandlers
		{
			get
			{
				return this._onObjectMaterialized != null && this._onObjectMaterialized.GetInvocationList().Length != 0;
			}
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x0009D090 File Offset: 0x0009B290
		public virtual void AcceptAllChanges()
		{
			if (this.ObjectStateManager.SomeEntryWithConceptualNullExists())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CommitWithConceptualNull);
			}
			foreach (global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry in this.ObjectStateManager.GetObjectStateEntries(global::System.Data.Entity.EntityState.Deleted))
			{
				objectStateEntry.AcceptChanges();
			}
			foreach (global::System.Data.Entity.Core.Objects.ObjectStateEntry objectStateEntry2 in this.ObjectStateManager.GetObjectStateEntries(global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Modified))
			{
				objectStateEntry2.AcceptChanges();
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0009D138 File Offset: 0x0009B338
		private void VerifyRootForAdd(bool doAttach, string entitySetName, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Objects.EntityEntry existingEntry, out global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, out bool isNoOperation)
		{
			isNoOperation = false;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = null;
			if (doAttach)
			{
				if (!string.IsNullOrEmpty(entitySetName))
				{
					entitySet2 = this.GetEntitySetFromName(entitySetName);
				}
			}
			else
			{
				entitySet2 = this.GetEntitySetFromName(entitySetName);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet3 = null;
			global::System.Data.Entity.Core.EntityKey entityKey = (existingEntry != null) ? existingEntry.EntityKey : wrappedEntity.GetEntityKeyFromEntity();
			if (entityKey != null)
			{
				entitySet3 = entityKey.GetEntitySet(this.MetadataWorkspace);
				if (entitySet2 != null)
				{
					global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKey, entitySet2, "entitySetName");
				}
				entityKey.ValidateEntityKey(this._workspace, entitySet3);
			}
			entitySet = (entitySet3 ?? entitySet2);
			if (entitySet == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntitySetNameOrEntityKeyRequired);
			}
			this.ValidateEntitySet(entitySet, wrappedEntity.IdentityType);
			if (doAttach && existingEntry == null)
			{
				if (entityKey == null)
				{
					entityKey = this.ObjectStateManager.CreateEntityKey(entitySet, wrappedEntity.Entity);
				}
				existingEntry = this.ObjectStateManager.FindEntityEntry(entityKey);
			}
			if (existingEntry == null || (doAttach && existingEntry.IsKeyEntry))
			{
				return;
			}
			if (existingEntry.Entity != wrappedEntity.Entity)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ObjectStateManagerContainsThisEntityKey(wrappedEntity.IdentityType.FullName));
			}
			global::System.Data.Entity.EntityState entityState = doAttach ? global::System.Data.Entity.EntityState.Unchanged : global::System.Data.Entity.EntityState.Added;
			if (existingEntry.State != entityState)
			{
				throw doAttach ? new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityAlreadyExistsInObjectStateManager) : new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity(existingEntry.State));
			}
			isNoOperation = true;
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0009D274 File Offset: 0x0009B474
		public virtual void AddObject(string entitySetName, object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContextGettingEntry(entity, this, out entityEntry);
			if (entityEntry == null)
			{
				this.MetadataWorkspace.ImplicitLoadAssemblyForType(entityWrapper.IdentityType, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			bool flag;
			this.VerifyRootForAdd(false, entitySetName, entityWrapper, entityEntry, out entitySet, out flag);
			if (flag)
			{
				return;
			}
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.ObjectStateManager.TransactionManager;
			transactionManager.BeginAddTracking();
			try
			{
				global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = entityWrapper.RelationshipManager;
				bool flag2 = true;
				try
				{
					this.AddSingleObject(entitySet, entityWrapper, "entity");
					flag2 = false;
				}
				finally
				{
					if (flag2 && entityWrapper.Context == this)
					{
						global::System.Data.Entity.Core.Objects.EntityEntry entityEntry2 = this.ObjectStateManager.FindEntityEntry(entityWrapper.Entity);
						if (entityEntry2 != null && entityEntry2.EntityKey.IsTemporary)
						{
							relationshipManager.NodeVisited = true;
							global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemoveRelatedEntitiesFromObjectStateManager(entityWrapper);
							global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromObjectStateManager(entityWrapper);
						}
					}
				}
				relationshipManager.AddRelatedEntitiesToObjectStateManager(false);
			}
			finally
			{
				transactionManager.EndAddTracking();
			}
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x0009D36C File Offset: 0x0009B56C
		internal void AddSingleObject(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, string argumentName)
		{
			global::System.Data.Entity.Core.EntityKey entityKeyFromEntity = wrappedEntity.GetEntityKeyFromEntity();
			if (entityKeyFromEntity != null)
			{
				global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKeyFromEntity, entitySet);
				entityKeyFromEntity.ValidateEntityKey(this._workspace, entitySet);
			}
			this.VerifyContextForAddOrAttach(wrappedEntity);
			wrappedEntity.Context = this;
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.AddEntry(wrappedEntity, null, entitySet, argumentName, true);
			this.ObjectStateManager.TransactionManager.ProcessedEntities.Add(wrappedEntity);
			wrappedEntity.AttachContext(this, entitySet, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly);
			entityEntry.FixupFKValuesFromNonAddedReferences();
			this.ObjectStateManager.FixupReferencesByForeignKeys(entityEntry, false);
			wrappedEntity.TakeSnapshotOfRelationships(entityEntry);
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x0009D3F0 File Offset: 0x0009B5F0
		public virtual void LoadProperty(object entity, string navigationProperty)
		{
			this.WrapEntityAndCheckContext(entity, "property").RelationshipManager.GetRelatedEnd(navigationProperty, false).Load();
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x0009D40F File Offset: 0x0009B60F
		public virtual void LoadProperty(object entity, string navigationProperty, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this.WrapEntityAndCheckContext(entity, "property").RelationshipManager.GetRelatedEnd(navigationProperty, false).Load(mergeOption);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x0009D430 File Offset: 0x0009B630
		public virtual void LoadProperty<TEntity>(TEntity entity, global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>> selector)
		{
			bool throwArgumentException;
			string navigationProperty = global::System.Data.Entity.Core.Objects.ObjectContext.ParsePropertySelectorExpression<TEntity>(selector, out throwArgumentException);
			this.WrapEntityAndCheckContext(entity, "property").RelationshipManager.GetRelatedEnd(navigationProperty, throwArgumentException).Load();
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x0009D468 File Offset: 0x0009B668
		public virtual void LoadProperty<TEntity>(TEntity entity, global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>> selector, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			bool throwArgumentException;
			string navigationProperty = global::System.Data.Entity.Core.Objects.ObjectContext.ParsePropertySelectorExpression<TEntity>(selector, out throwArgumentException);
			this.WrapEntityAndCheckContext(entity, "property").RelationshipManager.GetRelatedEnd(navigationProperty, throwArgumentException).Load(mergeOption);
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x0009D4A1 File Offset: 0x0009B6A1
		private global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper WrapEntityAndCheckContext(object entity, string refType)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(entity, this);
			if (entityWrapper.Context == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotExplicitlyLoadDetachedRelationships(refType));
			}
			if (entityWrapper.Context != this)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotLoadReferencesUsingDifferentContext(refType));
			}
			return entityWrapper;
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x0009D4DC File Offset: 0x0009B6DC
		internal static string ParsePropertySelectorExpression<TEntity>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>> selector, out bool removedConvert)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>>>(selector, "selector");
			removedConvert = false;
			global::System.Linq.Expressions.Expression expression = selector.Body;
			while (expression.NodeType == global::System.Linq.Expressions.ExpressionType.Convert || expression.NodeType == global::System.Linq.Expressions.ExpressionType.ConvertChecked)
			{
				removedConvert = true;
				expression = ((global::System.Linq.Expressions.UnaryExpression)expression).Operand;
			}
			global::System.Linq.Expressions.MemberExpression memberExpression = expression as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression == null || !memberExpression.Member.DeclaringType.IsAssignableFrom(typeof(TEntity)) || memberExpression.Expression.NodeType != global::System.Linq.Expressions.ExpressionType.Parameter)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_SelectorExpressionMustBeMemberAccess);
			}
			return memberExpression.Member.Name;
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x0009D56F File Offset: 0x0009B76F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("Use ApplyCurrentValues instead")]
		public virtual void ApplyPropertyChanges(string entitySetName, object changed)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(changed, "changed");
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this.ApplyCurrentValues<object>(entitySetName, changed);
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x0009D594 File Offset: 0x0009B794
		public virtual TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(currentEntity, "currentEntity");
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(currentEntity, this);
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(entityWrapper.IdentityType, null);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetFromName = this.GetEntitySetFromName(entitySetName);
			global::System.Data.Entity.Core.EntityKey entityKey = entityWrapper.EntityKey;
			if (entityKey != null)
			{
				global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKey, entitySetFromName, "entitySetName");
				entityKey.ValidateEntityKey(this._workspace, entitySetFromName);
			}
			else
			{
				entityKey = this.ObjectStateManager.CreateEntityKey(entitySetFromName, currentEntity);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entityKey);
			if (entityEntry == null || entityEntry.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_EntityNotTracked);
			}
			entityEntry.ApplyCurrentValuesInternal(entityWrapper);
			return (TEntity)((object)entityEntry.Entity);
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x0009D654 File Offset: 0x0009B854
		public virtual TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(originalEntity, "originalEntity");
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContext(originalEntity, this);
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(entityWrapper.IdentityType, null);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetFromName = this.GetEntitySetFromName(entitySetName);
			global::System.Data.Entity.Core.EntityKey entityKey = entityWrapper.EntityKey;
			if (entityKey != null)
			{
				global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKey, entitySetFromName, "entitySetName");
				entityKey.ValidateEntityKey(this._workspace, entitySetFromName);
			}
			else
			{
				entityKey = this.ObjectStateManager.CreateEntityKey(entitySetFromName, originalEntity);
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entityKey);
			if (entityEntry == null || entityEntry.IsKeyEntry)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityNotTrackedOrHasTempKey);
			}
			if (entityEntry.State != global::System.Data.Entity.EntityState.Modified && entityEntry.State != global::System.Data.Entity.EntityState.Unchanged && entityEntry.State != global::System.Data.Entity.EntityState.Deleted)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted(entityEntry.State.ToString()));
			}
			if (entityEntry.WrappedEntity.IdentityType != entityWrapper.IdentityType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntitiesHaveDifferentType(entityEntry.Entity.GetType().FullName, originalEntity.GetType().FullName));
			}
			entityEntry.CompareKeyProperties(originalEntity);
			entityEntry.UpdateOriginalValues(entityWrapper.Entity);
			return (TEntity)((object)entityEntry.Entity);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0009D7A4 File Offset: 0x0009B9A4
		public virtual void AttachTo(string entitySetName, object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = this.EntityWrapperFactory.WrapEntityUsingContextGettingEntry(entity, this, out entityEntry);
			if (entityEntry == null)
			{
				this.MetadataWorkspace.ImplicitLoadAssemblyForType(entityWrapper.IdentityType, null);
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			bool flag;
			this.VerifyRootForAdd(true, entitySetName, entityWrapper, entityEntry, out entitySet, out flag);
			if (flag)
			{
				return;
			}
			global::System.Data.Entity.Core.Objects.Internal.TransactionManager transactionManager = this.ObjectStateManager.TransactionManager;
			transactionManager.BeginAttachTracking();
			try
			{
				this.ObjectStateManager.TransactionManager.OriginalMergeOption = new global::System.Data.Entity.Core.Objects.MergeOption?(entityWrapper.MergeOption);
				global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = entityWrapper.RelationshipManager;
				bool flag2 = true;
				try
				{
					this.AttachSingleObject(entityWrapper, entitySet);
					flag2 = false;
				}
				finally
				{
					if (flag2 && entityWrapper.Context == this)
					{
						relationshipManager.NodeVisited = true;
						global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager.RemoveRelatedEntitiesFromObjectStateManager(entityWrapper);
						global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd.RemoveEntityFromObjectStateManager(entityWrapper);
					}
				}
				relationshipManager.AddRelatedEntitiesToObjectStateManager(true);
			}
			finally
			{
				transactionManager.EndAttachTracking();
			}
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x0009D88C File Offset: 0x0009BA8C
		public virtual void Attach(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey>(entity, "entity");
			if (entity.EntityKey == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotAttachEntityWithoutKey);
			}
			this.AttachTo(null, entity);
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x0009D8B8 File Offset: 0x0009BAB8
		internal void AttachSingleObject(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager relationshipManager = wrappedEntity.RelationshipManager;
			global::System.Data.Entity.Core.EntityKey entityKey = wrappedEntity.GetEntityKeyFromEntity();
			if (entityKey != null)
			{
				global::System.Data.Entity.Core.EntityUtil.ValidateEntitySetInKey(entityKey, entitySet);
				entityKey.ValidateEntityKey(this._workspace, entitySet);
			}
			else
			{
				entityKey = this.ObjectStateManager.CreateEntityKey(entitySet, wrappedEntity.Entity);
			}
			if (entityKey.IsTemporary)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotAttachEntityWithTemporaryKey);
			}
			if (wrappedEntity.EntityKey != entityKey)
			{
				wrappedEntity.EntityKey = entityKey;
			}
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entityKey);
			if (entityEntry == null)
			{
				this.VerifyContextForAddOrAttach(wrappedEntity);
				wrappedEntity.Context = this;
				entityEntry = this.ObjectStateManager.AttachEntry(entityKey, wrappedEntity, entitySet);
				this.ObjectStateManager.TransactionManager.ProcessedEntities.Add(wrappedEntity);
				wrappedEntity.AttachContext(this, entitySet, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly);
				this.ObjectStateManager.FixupReferencesByForeignKeys(entityEntry, false);
				wrappedEntity.TakeSnapshotOfRelationships(entityEntry);
				relationshipManager.CheckReferentialConstraintProperties(entityEntry);
				return;
			}
			if (entityEntry.IsKeyEntry)
			{
				this.ObjectStateManager.PromoteKeyEntryInitialization(this, entityEntry, wrappedEntity, false);
				this.ObjectStateManager.TransactionManager.ProcessedEntities.Add(wrappedEntity);
				wrappedEntity.TakeSnapshotOfRelationships(entityEntry);
				this.ObjectStateManager.PromoteKeyEntry(entityEntry, wrappedEntity, false, false, true);
				this.ObjectStateManager.FixupReferencesByForeignKeys(entityEntry, false);
				relationshipManager.CheckReferentialConstraintProperties(entityEntry);
				return;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectStateManager_ObjectStateManagerContainsThisEntityKey(wrappedEntity.IdentityType.FullName));
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x0009D9FF File Offset: 0x0009BBFF
		private void VerifyContextForAddOrAttach(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			if (wrappedEntity.Context != null && wrappedEntity.Context != this && !wrappedEntity.Context.ObjectStateManager.IsDisposed && wrappedEntity.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Entity_EntityCantHaveMultipleChangeTrackers);
			}
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x0009DA38 File Offset: 0x0009BC38
		public virtual global::System.Data.Entity.Core.EntityKey CreateEntityKey(string entitySetName, object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(global::System.Data.Entity.Core.EntityUtil.GetEntityIdentityType(entity.GetType()), null);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetFromName = this.GetEntitySetFromName(entitySetName);
			return this.ObjectStateManager.CreateEntityKey(entitySetFromName, entity);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x0009DA8C File Offset: 0x0009BC8C
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetFromName(string entitySetName)
		{
			string entitySetName2;
			string entityContainerName;
			global::System.Data.Entity.Core.Objects.ObjectContext.GetEntitySetName(entitySetName, "entitySetName", this, out entitySetName2, out entityContainerName);
			return this.GetEntitySet(entitySetName2, entityContainerName);
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x0009DAB4 File Offset: 0x0009BCB4
		private void AddRefreshKey(object entityLike, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> entities, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>> currentKeys)
		{
			if (entityLike == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_NthElementIsNull(entities.Count));
			}
			global::System.Data.Entity.Core.EntityKey entityKey = this.EntityWrapperFactory.WrapEntityUsingContext(entityLike, this).EntityKey;
			this.RefreshCheck(entities, entityKey);
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = entityKey.GetEntitySet(this.MetadataWorkspace);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> list = null;
			if (!currentKeys.TryGetValue(entitySet, out list))
			{
				list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>();
				currentKeys.Add(entitySet, list);
			}
			list.Add(entityKey);
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0009DB24 File Offset: 0x0009BD24
		public virtual global::System.Data.Entity.Core.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class
		{
			return new global::System.Data.Entity.Core.Objects.ObjectSet<TEntity>(this.GetEntitySetForType(typeof(TEntity), "TEntity"), this);
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x0009DB41 File Offset: 0x0009BD41
		public virtual global::System.Data.Entity.Core.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class
		{
			return new global::System.Data.Entity.Core.Objects.ObjectSet<TEntity>(this.GetEntitySetForNameAndType(entitySetName, typeof(TEntity), "TEntity"), this);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x0009DB60 File Offset: 0x0009BD60
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetForType(global::System.Type entityCLRType, string exceptionParameterName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer defaultContainer = this.Perspective.GetDefaultContainer();
			if (defaultContainer == null)
			{
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer> enumerator = this.MetadataWorkspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container = enumerator.Current;
						global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetFromContainer = this.GetEntitySetFromContainer(container, entityCLRType, exceptionParameterName);
						if (entitySetFromContainer != null)
						{
							if (entitySet != null)
							{
								throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_MultipleEntitySetsFoundInAllContainers(entityCLRType.FullName), exceptionParameterName);
							}
							entitySet = entitySetFromContainer;
						}
					}
					goto IL_71;
				}
			}
			entitySet = this.GetEntitySetFromContainer(defaultContainer, entityCLRType, exceptionParameterName);
			IL_71:
			if (entitySet == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_NoEntitySetFoundForType(entityCLRType.FullName), exceptionParameterName);
			}
			return entitySet;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x0009DC04 File Offset: 0x0009BE04
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetFromContainer(global::System.Data.Entity.Core.Metadata.Edm.EntityContainer container, global::System.Type entityCLRType, string exceptionParameterName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.GetTypeUsage(entityCLRType).EdmType;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in container.BaseEntitySets)
			{
				if (entitySetBase.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet && entitySetBase.ElementType == edmType)
				{
					if (entitySet != null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_MultipleEntitySetsFoundInSingleContainer(entityCLRType.FullName, container.Name), exceptionParameterName);
					}
					entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)entitySetBase;
				}
			}
			return entitySet;
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x0009DC98 File Offset: 0x0009BE98
		private global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySetForNameAndType(string entitySetName, global::System.Type entityCLRType, string exceptionParameterName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySetFromName = this.GetEntitySetFromName(entitySetName);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.GetTypeUsage(entityCLRType).EdmType;
			if (entitySetFromName.ElementType != edmType)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidObjectSetTypeForEntitySet(entityCLRType.FullName, entitySetFromName.ElementType.FullName, entitySetName), exceptionParameterName);
			}
			return entitySetFromName;
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x0009DCE4 File Offset: 0x0009BEE4
		internal virtual void EnsureConnection(bool shouldMonitorTransactions)
		{
			if (shouldMonitorTransactions)
			{
				this.EnsureTransactionHandlerRegistered();
			}
			if (this.Connection.State == global::System.Data.ConnectionState.Broken)
			{
				this.Connection.Close();
			}
			if (this.Connection.State == global::System.Data.ConnectionState.Closed)
			{
				this.Connection.Open();
				this._openedConnection = true;
			}
			if (this._openedConnection)
			{
				this._connectionRequestCount++;
			}
			try
			{
				global::System.Transactions.Transaction transaction = global::System.Transactions.Transaction.Current;
				this.EnsureContextIsEnlistedInCurrentTransaction<bool>(transaction, delegate
				{
					this.Connection.Open();
					return true;
				}, false);
				this._lastTransaction = transaction;
			}
			catch (global::System.Exception)
			{
				this.ReleaseConnection();
				throw;
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0009DD88 File Offset: 0x0009BF88
		internal virtual async global::System.Threading.Tasks.Task EnsureConnectionAsync(bool shouldMonitorTransactions, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass107_0 CS$<>8__locals1 = new global::System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass107_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			CS$<>8__locals1.cancellationToken.ThrowIfCancellationRequested();
			if (shouldMonitorTransactions)
			{
				this.EnsureTransactionHandlerRegistered();
			}
			if (this.Connection.State == global::System.Data.ConnectionState.Broken)
			{
				this.Connection.Close();
			}
			if (this.Connection.State == global::System.Data.ConnectionState.Closed)
			{
				await this.Connection.OpenAsync(CS$<>8__locals1.cancellationToken).WithCurrentCulture();
				this._openedConnection = true;
			}
			if (this._openedConnection)
			{
				this._connectionRequestCount++;
			}
			try
			{
				global::System.Transactions.Transaction currentTransaction = global::System.Transactions.Transaction.Current;
				await this.EnsureContextIsEnlistedInCurrentTransaction<global::System.Threading.Tasks.Task<bool>>(currentTransaction, delegate
				{
					global::System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass107_0.<<EnsureConnectionAsync>b__0>d <<EnsureConnectionAsync>b__0>d;
					<<EnsureConnectionAsync>b__0>d.<>4__this = CS$<>8__locals1;
					<<EnsureConnectionAsync>b__0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
					<<EnsureConnectionAsync>b__0>d.<>1__state = -1;
					global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool> <>t__builder = <<EnsureConnectionAsync>b__0>d.<>t__builder;
					<>t__builder.Start<global::System.Data.Entity.Core.Objects.ObjectContext.<>c__DisplayClass107_0.<<EnsureConnectionAsync>b__0>d>(ref <<EnsureConnectionAsync>b__0>d);
					return <<EnsureConnectionAsync>b__0>d.<>t__builder.Task;
				}, global::System.Threading.Tasks.Task.FromResult<bool>(false)).WithCurrentCulture<bool>();
				this._lastTransaction = currentTransaction;
				currentTransaction = null;
			}
			catch (global::System.Exception)
			{
				this.ReleaseConnection();
				throw;
			}
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0009DDE0 File Offset: 0x0009BFE0
		private void EnsureTransactionHandlerRegistered()
		{
			if (this._transactionHandler == null)
			{
				if (!this.InterceptionContext.DbContexts.Any((global::System.Data.Entity.DbContext dbc) => dbc is global::System.Data.Entity.Infrastructure.TransactionContext))
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					string name = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderFactory).Name;
					global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(new global::System.Data.Entity.Infrastructure.ExecutionStrategyKey(name, this.Connection.DataSource));
					if (service != null)
					{
						this._transactionHandler = service();
						this._transactionHandler.Initialize(this);
					}
				}
			}
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x0009DE88 File Offset: 0x0009C088
		private T EnsureContextIsEnlistedInCurrentTransaction<T>(global::System.Transactions.Transaction currentTransaction, global::System.Func<T> openConnection, T defaultValue)
		{
			if (this.Connection.State != global::System.Data.ConnectionState.Open)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.BadConnectionWrapping);
			}
			if ((null != currentTransaction && !currentTransaction.Equals(this._lastTransaction)) || (null != this._lastTransaction && !this._lastTransaction.Equals(currentTransaction)))
			{
				if (!this._openedConnection)
				{
					if (currentTransaction != null)
					{
						this.Connection.EnlistTransaction(currentTransaction);
					}
				}
				else if (this._connectionRequestCount > 1)
				{
					if (!(null == this._lastTransaction))
					{
						this.Connection.Close();
						return openConnection();
					}
					this.Connection.EnlistTransaction(currentTransaction);
				}
			}
			return defaultValue;
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x0009DF41 File Offset: 0x0009C141
		private void ConnectionStateChange(object sender, global::System.Data.StateChangeEventArgs e)
		{
			if (e.CurrentState == global::System.Data.ConnectionState.Closed)
			{
				this._connectionRequestCount = 0;
				this._openedConnection = false;
			}
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x0009DF5C File Offset: 0x0009C15C
		internal virtual void ReleaseConnection()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException(null, global::System.Data.Entity.Resources.Strings.ObjectContext_ObjectDisposed);
			}
			if (this._openedConnection)
			{
				if (this._connectionRequestCount > 0)
				{
					this._connectionRequestCount--;
				}
				if (this._connectionRequestCount == 0)
				{
					this.Connection.Close();
					this._openedConnection = false;
				}
			}
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0009DFB8 File Offset: 0x0009C1B8
		public virtual global::System.Data.Entity.Core.Objects.ObjectQuery<T> CreateQuery<T>(string queryString, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(queryString, "queryString");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(T), global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Data.Entity.Core.Objects.ObjectQuery<T> objectQuery = new global::System.Data.Entity.Core.Objects.ObjectQuery<T>(queryString, this, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly);
			foreach (global::System.Data.Entity.Core.Objects.ObjectParameter item in parameters)
			{
				objectQuery.Parameters.Add(item);
			}
			return objectQuery;
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0009E021 File Offset: 0x0009C221
		private static global::System.Data.Entity.Core.EntityClient.EntityConnection CreateEntityConnection(string connectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(connectionString, "connectionString");
			return new global::System.Data.Entity.Core.EntityClient.EntityConnection(connectionString);
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0009E035 File Offset: 0x0009C235
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace RetrieveMetadataWorkspaceFromConnection()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException(null, global::System.Data.Entity.Resources.Strings.ObjectContext_ObjectDisposed);
			}
			return this._connection.GetMetadataWorkspace();
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0009E056 File Offset: 0x0009C256
		public virtual void DeleteObject(object entity)
		{
			this.DeleteObject(entity, null);
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x0009E060 File Offset: 0x0009C260
		internal void DeleteObject(object entity, global::System.Data.Entity.Core.Metadata.Edm.EntitySet expectedEntitySet)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entity);
			if (entityEntry == null || entityEntry.Entity != entity)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotDeleteEntityNotInObjectStateManager);
			}
			if (expectedEntitySet != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = entityEntry.EntitySet;
				if (entitySet != expectedEntitySet)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityNotInObjectSet_Delete(entitySet.EntityContainer.Name, entitySet.Name, expectedEntitySet.EntityContainer.Name, expectedEntitySet.Name));
				}
			}
			entityEntry.Delete();
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0009E0D2 File Offset: 0x0009C2D2
		public virtual void Detach(object entity)
		{
			this.Detach(entity, null);
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0009E0DC File Offset: 0x0009C2DC
		internal void Detach(object entity, global::System.Data.Entity.Core.Metadata.Edm.EntitySet expectedEntitySet)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entity);
			if (entityEntry == null || entityEntry.Entity != entity || entityEntry.Entity == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CannotDetachEntityNotInObjectStateManager);
			}
			if (expectedEntitySet != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet = entityEntry.EntitySet;
				if (entitySet != expectedEntitySet)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityNotInObjectSet_Detach(entitySet.EntityContainer.Name, entitySet.Name, expectedEntitySet.EntityContainer.Name, expectedEntitySet.Name));
				}
			}
			entityEntry.Detach();
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0009E158 File Offset: 0x0009C358
		~ObjectContext()
		{
			this.Dispose(false);
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x0009E188 File Offset: 0x0009C388
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0009E198 File Offset: 0x0009C398
		protected virtual void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (this._transactionHandler != null)
				{
					this._transactionHandler.Dispose();
				}
				if (disposing)
				{
					if (this._connection != null)
					{
						this._connection.StateChange -= this.ConnectionStateChange;
						if (this._contextOwnsConnection)
						{
							this._connection.Dispose();
						}
					}
					this._connection = null;
					if (this._objectStateManager != null)
					{
						this._objectStateManager.Dispose();
					}
				}
				this._disposed = true;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060031C9 RID: 12745 RVA: 0x0009E216 File Offset: 0x0009C416
		internal bool IsDisposed
		{
			get
			{
				return this._disposed;
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0009E220 File Offset: 0x0009C420
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetEntitySet(string entitySetName, string entityContainerName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = null;
			if (string.IsNullOrEmpty(entityContainerName))
			{
				entityContainer = this.Perspective.GetDefaultContainer();
			}
			else if (!this.MetadataWorkspace.TryGetEntityContainer(entityContainerName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, out entityContainer))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntityContainerNotFoundForName(entityContainerName));
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet result = null;
			if (!entityContainer.TryGetEntitySetByName(entitySetName, false, out result))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_EntitySetNotFoundForName(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(entityContainer.Name, entitySetName)));
			}
			return result;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x0009E288 File Offset: 0x0009C488
		private static void GetEntitySetName(string qualifiedName, string parameterName, global::System.Data.Entity.Core.Objects.ObjectContext context, out string entityset, out string container)
		{
			entityset = null;
			container = null;
			global::System.Data.Entity.Utilities.Check.NotEmpty(qualifiedName, parameterName);
			string[] array = qualifiedName.Split(new char[]
			{
				'.'
			});
			if (array.Length > 2)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_QualfiedEntitySetName, parameterName);
			}
			if (array.Length == 1)
			{
				entityset = array[0];
			}
			else
			{
				container = array[0];
				entityset = array[1];
				if (container == null || container.Length == 0)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_QualfiedEntitySetName, parameterName);
				}
			}
			if (entityset == null || entityset.Length == 0)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_QualfiedEntitySetName, parameterName);
			}
			if (context != null && string.IsNullOrEmpty(container) && context.Perspective.GetDefaultContainer() == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_ContainerQualifiedEntitySetNameRequired, parameterName);
			}
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x0009E33C File Offset: 0x0009C53C
		private void ValidateEntitySet(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Type entityType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = this.GetTypeUsage(entityType);
			if (!entitySet.ElementType.IsAssignableFrom(typeUsage.EdmType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntitySetOnEntity(entitySet.Name, entityType), "entity");
			}
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x0009E37C File Offset: 0x0009C57C
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage(global::System.Type entityCLRType)
		{
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(entityCLRType, global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = null;
			if (!this.Perspective.TryGetType(entityCLRType, out typeUsage) || !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(typeUsage))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_NoMappingForEntityType(entityCLRType.FullName));
			}
			return typeUsage;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x0009E3C8 File Offset: 0x0009C5C8
		public virtual object GetObjectByKey(global::System.Data.Entity.Core.EntityKey key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.EntityKey>(key, "key");
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = key.GetEntitySet(this.MetadataWorkspace);
			this.MetadataWorkspace.ImplicitLoadFromEntityType(entitySet.ElementType, global::System.Reflection.Assembly.GetCallingAssembly());
			object result;
			if (!this.TryGetObjectByKey(key, out result))
			{
				throw new global::System.Data.Entity.Core.ObjectNotFoundException(global::System.Data.Entity.Resources.Strings.ObjectContext_ObjectNotFound);
			}
			return result;
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x0009E41B File Offset: 0x0009C61B
		public virtual void Refresh(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.IEnumerable collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IEnumerable>(collection, "collection");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentRefreshMode(refreshMode);
			this.RefreshEntities(refreshMode, collection);
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x0009E437 File Offset: 0x0009C637
		public virtual void Refresh(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentRefreshMode(refreshMode);
			this.RefreshEntities(refreshMode, new object[]
			{
				entity
			});
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x0009E45C File Offset: 0x0009C65C
		public global::System.Threading.Tasks.Task RefreshAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.IEnumerable collection)
		{
			return this.RefreshAsync(refreshMode, collection, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0009E46B File Offset: 0x0009C66B
		public virtual global::System.Threading.Tasks.Task RefreshAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.IEnumerable collection, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IEnumerable>(collection, "collection");
			cancellationToken.ThrowIfCancellationRequested();
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentRefreshMode(refreshMode);
			return this.RefreshEntitiesAsync(refreshMode, collection, cancellationToken);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x0009E49A File Offset: 0x0009C69A
		public global::System.Threading.Tasks.Task RefreshAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, object entity)
		{
			return this.RefreshAsync(refreshMode, entity, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x0009E4A9 File Offset: 0x0009C6A9
		public virtual global::System.Threading.Tasks.Task RefreshAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, object entity, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			cancellationToken.ThrowIfCancellationRequested();
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentRefreshMode(refreshMode);
			return this.RefreshEntitiesAsync(refreshMode, new object[]
			{
				entity
			}, cancellationToken);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x0009E4E4 File Offset: 0x0009C6E4
		private void RefreshCheck(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> entities, global::System.Data.Entity.Core.EntityKey key)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(key);
			if (entityEntry == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_NthElementNotInObjectStateManager(entities.Count));
			}
			if (global::System.Data.Entity.EntityState.Added == entityEntry.State)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_NthElementInAddedState(entities.Count));
			}
			try
			{
				entities.Add(key, entityEntry);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_NthElementIsDuplicate(entities.Count));
			}
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x0009E568 File Offset: 0x0009C768
		private void RefreshEntities(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.IEnumerable collection)
		{
			this.AsyncMonitor.EnsureNotEntered();
			bool flag = false;
			try
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>(global::System.Data.Entity.Core.Objects.ObjectContext.RefreshEntitiesSize(collection));
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>> dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>>();
				foreach (object entityLike in collection)
				{
					this.AddRefreshKey(entityLike, dictionary, dictionary2);
				}
				if (dictionary2.Count > 0)
				{
					this.EnsureConnection(false);
					flag = true;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in dictionary2.Keys)
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> list = dictionary2[entitySet];
						for (int i = 0; i < list.Count; i = this.BatchRefreshEntitiesByKey(refreshMode, dictionary, entitySet, list, i))
						{
						}
					}
				}
				if (global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins == refreshMode)
				{
					using (global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>.Enumerator enumerator3 = dictionary.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair = enumerator3.Current;
							if (global::System.Data.Entity.EntityState.Detached != keyValuePair.Value.State)
							{
								this.ObjectStateManager.TransactionManager.BeginDetaching();
								try
								{
									keyValuePair.Value.Delete();
								}
								finally
								{
									this.ObjectStateManager.TransactionManager.EndDetaching();
								}
								keyValuePair.Value.AcceptChanges();
							}
						}
						return;
					}
				}
				if (global::System.Data.Entity.Core.Objects.RefreshMode.ClientWins == refreshMode && 0 < dictionary.Count)
				{
					string value = string.Empty;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair2 in dictionary)
					{
						if (keyValuePair2.Value.State == global::System.Data.Entity.EntityState.Deleted)
						{
							keyValuePair2.Value.AcceptChanges();
						}
						else
						{
							stringBuilder.Append(value).Append(global::System.Environment.NewLine);
							stringBuilder.Append('\'').Append(keyValuePair2.Value.WrappedEntity.IdentityType.FullName).Append('\'');
							value = ",";
						}
					}
					if (stringBuilder.Length > 0)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_ClientEntityRemovedFromStore(stringBuilder.ToString()));
					}
				}
			}
			finally
			{
				if (flag)
				{
					this.ReleaseConnection();
				}
			}
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x0009E824 File Offset: 0x0009CA24
		private int BatchRefreshEntitiesByKey(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> trackedEntities, global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> targetKeys, int startFrom)
		{
			global::System.Tuple<global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan, int> queryPlanAndNextPosition = this.PrepareRefreshQuery(refreshMode, targetSet, targetKeys, startFrom);
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<object>> <>9__1;
			global::System.Data.Entity.Core.Objects.ObjectResult<object> results = executionStrategy.Execute<global::System.Data.Entity.Core.Objects.ObjectResult<object>>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<object>> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => queryPlanAndNextPosition.Item1.Execute<object>(this, null)));
				}
				return <>4__this.ExecuteInTransaction<global::System.Data.Entity.Core.Objects.ObjectResult<object>>(func, executionStrategy, false, true);
			});
			this.ProcessRefreshedEntities(trackedEntities, results);
			return queryPlanAndNextPosition.Item2;
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x0009E894 File Offset: 0x0009CA94
		private async global::System.Threading.Tasks.Task RefreshEntitiesAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.IEnumerable collection, global::System.Threading.CancellationToken cancellationToken)
		{
			this.AsyncMonitor.Enter();
			bool openedConnection = false;
			try
			{
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> entities = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>(global::System.Data.Entity.Core.Objects.ObjectContext.RefreshEntitiesSize(collection));
				global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>> refreshKeys = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>>();
				foreach (object entityLike in collection)
				{
					this.AddRefreshKey(entityLike, entities, refreshKeys);
				}
				if (refreshKeys.Count > 0)
				{
					await this.EnsureConnectionAsync(false, cancellationToken).WithCurrentCulture();
					openedConnection = true;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet in refreshKeys.Keys)
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> setKeys = refreshKeys[targetSet];
						for (int i = 0; i < setKeys.Count; i = await this.BatchRefreshEntitiesByKeyAsync(refreshMode, entities, targetSet, setKeys, i, cancellationToken).WithCurrentCulture<int>())
						{
						}
						setKeys = null;
						targetSet = null;
					}
					global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>>.KeyCollection.Enumerator enumerator2 = default(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey>>.KeyCollection.Enumerator);
				}
				if (global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins == refreshMode)
				{
					using (global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry>.Enumerator enumerator3 = entities.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair = enumerator3.Current;
							if (global::System.Data.Entity.EntityState.Detached != keyValuePair.Value.State)
							{
								this.ObjectStateManager.TransactionManager.BeginDetaching();
								try
								{
									keyValuePair.Value.Delete();
								}
								finally
								{
									this.ObjectStateManager.TransactionManager.EndDetaching();
								}
								keyValuePair.Value.AcceptChanges();
							}
						}
						goto IL_3C5;
					}
				}
				if (global::System.Data.Entity.Core.Objects.RefreshMode.ClientWins == refreshMode && 0 < entities.Count)
				{
					string value = string.Empty;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> keyValuePair2 in entities)
					{
						if (keyValuePair2.Value.State == global::System.Data.Entity.EntityState.Deleted)
						{
							keyValuePair2.Value.AcceptChanges();
						}
						else
						{
							stringBuilder.Append(value).Append(global::System.Environment.NewLine);
							stringBuilder.Append('\'').Append(keyValuePair2.Value.WrappedEntity.IdentityType.FullName).Append('\'');
							value = ",";
						}
					}
					if (stringBuilder.Length > 0)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_ClientEntityRemovedFromStore(stringBuilder.ToString()));
					}
				}
				IL_3C5:
				entities = null;
				refreshKeys = null;
			}
			finally
			{
				if (openedConnection)
				{
					this.ReleaseConnection();
				}
				this.AsyncMonitor.Exit();
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x0009E8F4 File Offset: 0x0009CAF4
		private async global::System.Threading.Tasks.Task<int> BatchRefreshEntitiesByKeyAsync(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> trackedEntities, global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> targetKeys, int startFrom, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Tuple<global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan, int> queryPlanAndNextPosition = this.PrepareRefreshQuery(refreshMode, targetSet, targetKeys, startFrom);
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<object>>> <>9__1;
			global::System.Data.Entity.Core.Objects.ObjectResult<object> results = await executionStrategy.ExecuteAsync<global::System.Data.Entity.Core.Objects.ObjectResult<object>>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<object>>> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => queryPlanAndNextPosition.Item1.ExecuteAsync<object>(this, null, cancellationToken)));
				}
				return <>4__this.ExecuteInTransactionAsync<global::System.Data.Entity.Core.Objects.ObjectResult<object>>(func, executionStrategy, false, true, cancellationToken);
			}, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<object>>();
			this.ProcessRefreshedEntities(trackedEntities, results);
			return queryPlanAndNextPosition.Item2;
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x0009E96C File Offset: 0x0009CB6C
		internal virtual global::System.Tuple<global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan, int> PrepareRefreshQuery(global::System.Data.Entity.Core.Objects.RefreshMode refreshMode, global::System.Data.Entity.Core.Metadata.Edm.EntitySet targetSet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityKey> targetKeys, int startFrom)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionBinding dbExpressionBinding = targetSet.Scan().BindAs("EntitySet");
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression refKey = dbExpressionBinding.Variable.GetEntityRef().GetRefKey();
			int num = global::System.Math.Min(250, targetKeys.Count - startFrom);
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[] array = new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[num];
			for (int i = 0; i < num; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression right = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.NewRow(targetKeys[startFrom++].GetKeyValueExpressions(targetSet));
				array[i] = refKey.Equal(right);
			}
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression predicate = global::System.Data.Entity.Core.Common.Utils.Helpers.BuildBalancedTreeInPlace<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(array, new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.Or));
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression query = dbExpressionBinding.Filter(predicate);
			global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree = global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree.FromValidExpression(this.MetadataWorkspace, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, query, true, false);
			global::System.Data.Entity.Core.Objects.MergeOption mergeOption = (global::System.Data.Entity.Core.Objects.RefreshMode.StoreWins == refreshMode) ? global::System.Data.Entity.Core.Objects.MergeOption.OverwriteChanges : global::System.Data.Entity.Core.Objects.MergeOption.PreserveChanges;
			return new global::System.Tuple<global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlan, int>(this._objectQueryExecutionPlanFactory.Prepare(this, tree, typeof(object), mergeOption, false, null, null, global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.AliasGenerator), startFrom);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0009EA50 File Offset: 0x0009CC50
		private void ProcessRefreshedEntities(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.EntityKey, global::System.Data.Entity.Core.Objects.EntityEntry> trackedEntities, global::System.Data.Entity.Core.Objects.ObjectResult<object> results)
		{
			foreach (object entity in results)
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this.ObjectStateManager.FindEntityEntry(entity);
				if (entityEntry != null && entityEntry.State == global::System.Data.Entity.EntityState.Modified)
				{
					entityEntry.SetModifiedAll();
				}
				global::System.Data.Entity.Core.EntityKey entityKey = this.EntityWrapperFactory.WrapEntityUsingContext(entity, this).EntityKey;
				if (entityKey == null)
				{
					throw global::System.Data.Entity.Resources.Error.EntityKey_UnexpectedNull();
				}
				if (!trackedEntities.Remove(entityKey))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_StoreEntityNotPresentInClient);
				}
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
		private static int RefreshEntitiesSize(global::System.Collections.IEnumerable collection)
		{
			global::System.Collections.ICollection collection2 = collection as global::System.Collections.ICollection;
			if (collection2 == null)
			{
				return 0;
			}
			return collection2.Count;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x0009EB03 File Offset: 0x0009CD03
		public virtual int SaveChanges()
		{
			return this.SaveChanges(global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave);
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x0009EB0C File Offset: 0x0009CD0C
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync()
		{
			return this.SaveChangesAsync(global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0009EB1A File Offset: 0x0009CD1A
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.SaveChangesAsync(global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave, cancellationToken);
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0009EB24 File Offset: 0x0009CD24
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.Obsolete("Use SaveChanges(SaveOptions options) instead.")]
		public virtual int SaveChanges(bool acceptChangesDuringSave)
		{
			return this.SaveChanges(acceptChangesDuringSave ? (global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave | global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave) : global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0009EB33 File Offset: 0x0009CD33
		public virtual int SaveChanges(global::System.Data.Entity.Core.Objects.SaveOptions options)
		{
			return this.SaveChangesInternal(options, false);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x0009EB40 File Offset: 0x0009CD40
		internal int SaveChangesInternal(global::System.Data.Entity.Core.Objects.SaveOptions options, bool executeInExistingTransaction)
		{
			this.AsyncMonitor.EnsureNotEntered();
			this.PrepareToSaveChanges(options);
			int result = 0;
			if (this.ObjectStateManager.HasChanges())
			{
				if (executeInExistingTransaction)
				{
					result = this.SaveChangesToStore(options, null, false);
				}
				else
				{
					global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
					result = executionStrategy.Execute<int>(() => this.SaveChangesToStore(options, executionStrategy, true));
				}
			}
			return result;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0009EBCB File Offset: 0x0009CDCB
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Data.Entity.Core.Objects.SaveOptions options)
		{
			return this.SaveChangesAsync(options, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0009EBD9 File Offset: 0x0009CDD9
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Data.Entity.Core.Objects.SaveOptions options, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.AsyncMonitor.EnsureNotEntered();
			return this.SaveChangesInternalAsync(options, false, cancellationToken);
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x0009EBF8 File Offset: 0x0009CDF8
		internal async global::System.Threading.Tasks.Task<int> SaveChangesInternalAsync(global::System.Data.Entity.Core.Objects.SaveOptions options, bool executeInExistingTransaction, global::System.Threading.CancellationToken cancellationToken)
		{
			this.AsyncMonitor.Enter();
			int result;
			try
			{
				this.PrepareToSaveChanges(options);
				int num = 0;
				if (this.ObjectStateManager.HasChanges())
				{
					if (executeInExistingTransaction)
					{
						num = await this.SaveChangesToStoreAsync(options, null, false, cancellationToken).WithCurrentCulture<int>();
					}
					else
					{
						global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
						num = await executionStrategy.ExecuteAsync<int>(() => this.SaveChangesToStoreAsync(options, executionStrategy, true, cancellationToken), cancellationToken).WithCurrentCulture<int>();
					}
				}
				result = num;
			}
			finally
			{
				this.AsyncMonitor.Exit();
			}
			return result;
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x0009EC58 File Offset: 0x0009CE58
		private void PrepareToSaveChanges(global::System.Data.Entity.Core.Objects.SaveOptions options)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException(null, global::System.Data.Entity.Resources.Strings.ObjectContext_ObjectDisposed);
			}
			this.OnSavingChanges();
			if ((global::System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave & options) != global::System.Data.Entity.Core.Objects.SaveOptions.None)
			{
				this.ObjectStateManager.DetectChanges();
			}
			if (this.ObjectStateManager.SomeEntryWithConceptualNullExists())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_CommitWithConceptualNull);
			}
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x0009ECA8 File Offset: 0x0009CEA8
		private int SaveChangesToStore(global::System.Data.Entity.Core.Objects.SaveOptions options, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, bool startLocalTransaction)
		{
			this._adapter.AcceptChangesDuringUpdate = false;
			this._adapter.Connection = this.Connection;
			this._adapter.CommandTimeout = this.CommandTimeout;
			int result = this.ExecuteInTransaction<int>(() => this._adapter.Update(), executionStrategy, startLocalTransaction, true);
			if ((global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave & options) != global::System.Data.Entity.Core.Objects.SaveOptions.None)
			{
				try
				{
					this.AcceptAllChanges();
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_AcceptAllChangesFailure(ex.Message), ex);
				}
			}
			return result;
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x0009ED2C File Offset: 0x0009CF2C
		private async global::System.Threading.Tasks.Task<int> SaveChangesToStoreAsync(global::System.Data.Entity.Core.Objects.SaveOptions options, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, bool startLocalTransaction, global::System.Threading.CancellationToken cancellationToken)
		{
			this._adapter.AcceptChangesDuringUpdate = false;
			this._adapter.Connection = this.Connection;
			this._adapter.CommandTimeout = this.CommandTimeout;
			int result = await this.ExecuteInTransactionAsync<int>(() => this._adapter.UpdateAsync(cancellationToken), executionStrategy, startLocalTransaction, true, cancellationToken).WithCurrentCulture<int>();
			if ((global::System.Data.Entity.Core.Objects.SaveOptions.AcceptAllChangesAfterSave & options) != global::System.Data.Entity.Core.Objects.SaveOptions.None)
			{
				try
				{
					this.AcceptAllChanges();
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_AcceptAllChangesFailure(ex.Message), ex);
				}
			}
			return result;
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x0009ED94 File Offset: 0x0009CF94
		internal virtual T ExecuteInTransaction<T>(global::System.Func<T> func, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, bool startLocalTransaction, bool releaseConnectionOnSuccess)
		{
			this.EnsureConnection(startLocalTransaction);
			bool flag = false;
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection;
			if (entityConnection.CurrentTransaction == null && !entityConnection.EnlistedInUserTransaction && this._lastTransaction == null)
			{
				flag = startLocalTransaction;
			}
			else if (executionStrategy != null && executionStrategy.RetriesOnFailure)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_ExistingTransaction(executionStrategy.GetType().Name));
			}
			global::System.Data.Common.DbTransaction dbTransaction = null;
			T result;
			try
			{
				if (flag)
				{
					dbTransaction = entityConnection.BeginTransaction();
				}
				T t = func();
				if (dbTransaction != null)
				{
					dbTransaction.Commit();
				}
				if (releaseConnectionOnSuccess)
				{
					this.ReleaseConnection();
				}
				result = t;
			}
			catch (global::System.Exception)
			{
				this.ReleaseConnection();
				throw;
			}
			finally
			{
				if (dbTransaction != null)
				{
					dbTransaction.Dispose();
				}
			}
			return result;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x0009EE54 File Offset: 0x0009D054
		internal virtual async global::System.Threading.Tasks.Task<T> ExecuteInTransactionAsync<T>(global::System.Func<global::System.Threading.Tasks.Task<T>> func, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, bool startLocalTransaction, bool releaseConnectionOnSuccess, global::System.Threading.CancellationToken cancellationToken)
		{
			await this.EnsureConnectionAsync(startLocalTransaction, cancellationToken).WithCurrentCulture();
			bool flag = false;
			global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection;
			if (entityConnection.CurrentTransaction == null && !entityConnection.EnlistedInUserTransaction && this._lastTransaction == null)
			{
				flag = startLocalTransaction;
			}
			else if (executionStrategy.RetriesOnFailure)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_ExistingTransaction(executionStrategy.GetType().Name));
			}
			global::System.Data.Common.DbTransaction localTransaction = null;
			T result;
			try
			{
				if (flag)
				{
					localTransaction = entityConnection.BeginTransaction();
				}
				T t = await func().WithCurrentCulture<T>();
				if (localTransaction != null)
				{
					localTransaction.Commit();
				}
				if (releaseConnectionOnSuccess)
				{
					this.ReleaseConnection();
				}
				result = t;
			}
			catch (global::System.Exception)
			{
				this.ReleaseConnection();
				throw;
			}
			finally
			{
				if (localTransaction != null)
				{
					localTransaction.Dispose();
				}
			}
			return result;
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x0009EEC3 File Offset: 0x0009D0C3
		public virtual void DetectChanges()
		{
			this.ObjectStateManager.DetectChanges();
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x0009EED0 File Offset: 0x0009D0D0
		public virtual bool TryGetObjectByKey(global::System.Data.Entity.Core.EntityKey key, out object value)
		{
			global::System.Data.Entity.Core.Objects.EntityEntry entityEntry;
			this.ObjectStateManager.TryGetEntityEntry(key, out entityEntry);
			if (entityEntry != null && !entityEntry.IsKeyEntry)
			{
				value = entityEntry.Entity;
				return value != null;
			}
			if (key.IsTemporary)
			{
				value = null;
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = key.GetEntitySet(this.MetadataWorkspace);
			key.ValidateEntityKey(this._workspace, entitySet, true, "key");
			this.MetadataWorkspace.ImplicitLoadFromEntityType(entitySet.ElementType, global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendFormat("SELECT VALUE X FROM {0}.{1} AS X WHERE ", global::System.Data.Entity.Core.EntityUtil.QuoteIdentifier(entitySet.EntityContainer.Name), global::System.Data.Entity.Core.EntityUtil.QuoteIdentifier(entitySet.Name));
			global::System.Data.Entity.Core.EntityKeyMember[] entityKeyValues = key.EntityKeyValues;
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers = entitySet.ElementType.KeyMembers;
			global::System.Data.Entity.Core.Objects.ObjectParameter[] array = new global::System.Data.Entity.Core.Objects.ObjectParameter[entityKeyValues.Length];
			for (int i = 0; i < entityKeyValues.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(" AND ");
				}
				string text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "p{0}", new object[]
				{
					i.ToString(global::System.Globalization.CultureInfo.InvariantCulture)
				});
				stringBuilder.AppendFormat("X.{0} = @{1}", global::System.Data.Entity.Core.EntityUtil.QuoteIdentifier(entityKeyValues[i].Key), text);
				array[i] = new global::System.Data.Entity.Core.Objects.ObjectParameter(text, entityKeyValues[i].Value);
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
				if (keyMembers.TryGetValue(entityKeyValues[i].Key, true, out edmMember))
				{
					array[i].TypeUsage = edmMember.TypeUsage;
				}
			}
			object obj = null;
			using (global::System.Collections.Generic.IEnumerator<object> enumerator = this.CreateQuery<object>(stringBuilder.ToString(), array).Execute(global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					obj = enumerator.Current;
				}
			}
			value = obj;
			return value != null;
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x0009F098 File Offset: 0x0009D298
		public global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			return this.ExecuteFunction<TElement>(functionName, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, parameters);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x0009F0AF File Offset: 0x0009D2AF
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			global::System.Data.Entity.Utilities.Check.NotEmpty(functionName, "functionName");
			return this.ExecuteFunction<TElement>(functionName, new global::System.Data.Entity.Core.Objects.ExecutionOptions(mergeOption), parameters);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x0009F0D8 File Offset: 0x0009D2D8
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			global::System.Data.Entity.Utilities.Check.NotEmpty(functionName, "functionName");
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport;
			global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = this.CreateEntityCommandForFunctionImport(functionName, out functionImport, parameters);
			int num = global::System.Math.Max(1, functionImport.ReturnParameters.Count);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType[] expectedEdmTypes = new global::System.Data.Entity.Core.Metadata.Edm.EdmType[num];
			expectedEdmTypes[0] = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetAndCheckFunctionImportReturnType<TElement>(functionImport, 0, this.MetadataWorkspace);
			for (int i = 1; i < num; i++)
			{
				if (!global::System.Data.Entity.Core.Common.Utils.MetadataHelper.TryGetFunctionImportReturnType<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(functionImport, i, out expectedEdmTypes[i]))
				{
					throw global::System.Data.Entity.Core.EntityUtil.ExecuteFunctionCalledWithNonReaderFunction(functionImport);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			if (executionStrategy.RetriesOnFailure && executionOptions.UserSpecifiedStreaming != null && executionOptions.UserSpecifiedStreaming.Value)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(executionStrategy.GetType().Name));
			}
			if (executionOptions.UserSpecifiedStreaming == null)
			{
				executionOptions = new global::System.Data.Entity.Core.Objects.ExecutionOptions(executionOptions.MergeOption, !executionStrategy.RetriesOnFailure);
			}
			bool startLocalTransaction = !executionOptions.UserSpecifiedStreaming.Value && this._options.EnsureTransactionsForFunctionsAndCommands;
			global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> <>9__1;
			return executionStrategy.Execute<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => this.CreateFunctionObjectResult<TElement>(entityCommand, functionImport.EntitySets, expectedEdmTypes, executionOptions)));
				}
				return <>4__this.ExecuteInTransaction<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(func, executionStrategy, startLocalTransaction, !executionOptions.UserSpecifiedStreaming.Value);
			});
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0009F284 File Offset: 0x0009D484
		public virtual int ExecuteFunction(string functionName, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter[]>(parameters, "parameters");
			global::System.Data.Entity.Utilities.Check.NotEmpty(functionName, "functionName");
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction;
			global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = this.CreateEntityCommandForFunctionImport(functionName, out edmFunction, parameters);
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			global::System.Func<int> <>9__1;
			return executionStrategy.Execute<int>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<int> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => global::System.Data.Entity.Core.Objects.ObjectContext.ExecuteFunctionCommand(entityCommand)));
				}
				return <>4__this.ExecuteInTransaction<int>(func, executionStrategy, this._options.EnsureTransactionsForFunctionsAndCommands, true);
			});
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x0009F300 File Offset: 0x0009D500
		private static int ExecuteFunctionCommand(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand)
		{
			entityCommand.Prepare();
			int result;
			try
			{
				result = entityCommand.ExecuteNonQuery();
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableEntityExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandExecutionFailed, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x0009F344 File Offset: 0x0009D544
		private global::System.Data.Entity.Core.EntityClient.EntityCommand CreateEntityCommandForFunctionImport(string functionName, out global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, params global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				if (parameters[i] == null)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_ExecuteFunctionCalledWithNullParameter(i));
				}
			}
			string str;
			string str2;
			functionImport = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetFunctionImport(functionName, this.DefaultContainerName, this.MetadataWorkspace, out str, out str2);
			global::System.Data.Entity.Core.EntityClient.EntityConnection connection = (global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection;
			global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand = new global::System.Data.Entity.Core.EntityClient.EntityCommand(this.InterceptionContext);
			entityCommand.CommandType = global::System.Data.CommandType.StoredProcedure;
			entityCommand.CommandText = str + "." + str2;
			entityCommand.Connection = connection;
			if (this.CommandTimeout != null)
			{
				entityCommand.CommandTimeout = this.CommandTimeout.Value;
			}
			this.PopulateFunctionImportEntityCommandParameters(parameters, functionImport, entityCommand);
			return entityCommand;
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x0009F400 File Offset: 0x0009D600
		private global::System.Data.Entity.Core.Objects.ObjectResult<TElement> CreateFunctionObjectResult<TElement>(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Metadata.Edm.EdmType[] edmTypes, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions)
		{
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition commandDefinition = entityCommand.GetCommandDefinition();
			global::System.Data.Common.DbDataReader dbDataReader = null;
			try
			{
				dbDataReader = commandDefinition.ExecuteStoreCommands(entityCommand, executionOptions.UserSpecifiedStreaming.Value ? global::System.Data.CommandBehavior.Default : global::System.Data.CommandBehavior.SequentialAccess);
			}
			catch (global::System.Exception ex)
			{
				if (ex.IsCatchableEntityExceptionType())
				{
					throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_CommandExecutionFailed, ex);
				}
				throw;
			}
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory = null;
			if (!executionOptions.UserSpecifiedStreaming.Value)
			{
				global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader bufferedDataReader = null;
				try
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					global::System.Data.Entity.Core.Common.DbProviderServices service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderInvariantName);
					shaperFactory = this._translator.TranslateColumnMap<TElement>(commandDefinition.CreateColumnMap(dbDataReader, 0), this.MetadataWorkspace, null, executionOptions.MergeOption, false, false);
					bufferedDataReader = new global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader(dbDataReader);
					bufferedDataReader.Initialize(storeItemCollection.ProviderManifestToken, service, shaperFactory.ColumnTypes, shaperFactory.NullableColumns);
					dbDataReader = bufferedDataReader;
				}
				catch (global::System.Exception)
				{
					if (bufferedDataReader != null)
					{
						bufferedDataReader.Dispose();
					}
					throw;
				}
			}
			return this.MaterializedDataRecord<TElement>(entityCommand, dbDataReader, 0, entitySets, edmTypes, shaperFactory, executionOptions.MergeOption, executionOptions.UserSpecifiedStreaming.Value);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x0009F528 File Offset: 0x0009D728
		internal global::System.Data.Entity.Core.Objects.ObjectResult<TElement> MaterializedDataRecord<TElement>(global::System.Data.Entity.Core.EntityClient.EntityCommand entityCommand, global::System.Data.Common.DbDataReader storeReader, int resultSetIndex, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> entitySets, global::System.Data.Entity.Core.Metadata.Edm.EdmType[] edmTypes, global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming)
		{
			global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition commandDefinition = entityCommand.GetCommandDefinition();
			global::System.Data.Entity.Core.Objects.ObjectResult<TElement> result;
			try
			{
				bool flag = edmTypes.Length <= resultSetIndex + 1;
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet = (entitySets.Count > resultSetIndex) ? entitySets[resultSetIndex] : null;
				if (shaperFactory == null)
				{
					shaperFactory = this._translator.TranslateColumnMap<TElement>(commandDefinition.CreateColumnMap(storeReader, resultSetIndex), this.MetadataWorkspace, null, mergeOption, streaming, false);
				}
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<TElement> shaper = shaperFactory.Create(storeReader, this, this.MetadataWorkspace, mergeOption, flag, streaming);
				bool onReaderDisposeHasRun = false;
				global::System.Action<object, global::System.EventArgs> action = delegate(object sender, global::System.EventArgs e)
				{
					if (!onReaderDisposeHasRun)
					{
						onReaderDisposeHasRun = true;
						global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(storeReader);
						entityCommand.NotifyDataReaderClosing();
					}
				};
				global::System.Data.Entity.Core.Objects.NextResultGenerator nextResultGenerator;
				if (flag)
				{
					shaper.OnDone += action.Invoke;
					nextResultGenerator = null;
				}
				else
				{
					nextResultGenerator = new global::System.Data.Entity.Core.Objects.NextResultGenerator(this, entityCommand, edmTypes, entitySets, mergeOption, streaming, resultSetIndex + 1);
				}
				result = new global::System.Data.Entity.Core.Objects.ObjectResult<TElement>(shaper, singleEntitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmTypes[resultSetIndex]), true, streaming, nextResultGenerator, action, null);
			}
			catch
			{
				this.ReleaseConnection();
				storeReader.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x0009F64C File Offset: 0x0009D84C
		private void PopulateFunctionImportEntityCommandParameters(global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.EntityClient.EntityCommand command)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter = parameters[i];
				global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = new global::System.Data.Entity.Core.EntityClient.EntityParameter();
				global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = global::System.Data.Entity.Core.Objects.ObjectContext.FindParameterMetadata(functionImport, parameters, i);
				if (functionParameter != null)
				{
					entityParameter.Direction = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.ParameterModeToParameterDirection(functionParameter.Mode);
					entityParameter.ParameterName = functionParameter.Name;
				}
				else
				{
					entityParameter.ParameterName = objectParameter.Name;
				}
				entityParameter.Value = (objectParameter.Value ?? global::System.DBNull.Value);
				if (global::System.DBNull.Value == entityParameter.Value || entityParameter.Direction != global::System.Data.ParameterDirection.Input)
				{
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
					if (functionParameter != null)
					{
						typeUsage = functionParameter.TypeUsage;
					}
					else if (objectParameter.TypeUsage == null)
					{
						if (!this.Perspective.TryGetTypeByName(objectParameter.MappableType.FullNameWithNesting(), false, out typeUsage))
						{
							this.MetadataWorkspace.ImplicitLoadAssemblyForType(objectParameter.MappableType, null);
							this.Perspective.TryGetTypeByName(objectParameter.MappableType.FullNameWithNesting(), false, out typeUsage);
						}
					}
					else
					{
						typeUsage = objectParameter.TypeUsage;
					}
					global::System.Data.Entity.Core.EntityClient.Internal.EntityCommandDefinition.PopulateParameterFromTypeUsage(entityParameter, typeUsage, entityParameter.Direction != global::System.Data.ParameterDirection.Input);
				}
				if (entityParameter.Direction != global::System.Data.ParameterDirection.Input)
				{
					global::System.Data.Entity.Core.Objects.ObjectContext.ParameterBinder @object = new global::System.Data.Entity.Core.Objects.ObjectContext.ParameterBinder(entityParameter, objectParameter);
					command.OnDataReaderClosing += @object.OnDataReaderClosingHandler;
				}
				command.Parameters.Add(entityParameter);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0009F788 File Offset: 0x0009D988
		private static global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter FindParameterMetadata(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Objects.ObjectParameter[] parameters, int ordinal)
		{
			string name = parameters[ordinal].Name;
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter result;
			if (!functionImport.Parameters.TryGetValue(name, false, out result))
			{
				int num = 0;
				int num2 = 0;
				while (num2 < parameters.Length && num < 2)
				{
					if (global::System.StringComparer.OrdinalIgnoreCase.Equals(parameters[num2].Name, name))
					{
						num++;
					}
					num2++;
				}
				if (num == 1)
				{
					functionImport.Parameters.TryGetValue(name, true, out result);
				}
			}
			return result;
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0009F7F4 File Offset: 0x0009D9F4
		public virtual void CreateProxyTypes(global::System.Collections.Generic.IEnumerable<global::System.Type> types)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection ospaceItems = (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryCreateProxyTypes(from entityType in types.Select(delegate(global::System.Type type)
			{
				this.MetadataWorkspace.ImplicitLoadAssemblyForType(type, null);
				global::System.Data.Entity.Core.Metadata.Edm.EntityType result;
				ospaceItems.TryGetItem<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type.FullNameWithNesting(), out result);
				return result;
			})
			where entityType != null
			select entityType, this.MetadataWorkspace);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0009F866 File Offset: 0x0009DA66
		public static global::System.Collections.Generic.IEnumerable<global::System.Type> GetKnownProxyTypes()
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetKnownProxyTypes();
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x0009F86D File Offset: 0x0009DA6D
		public static global::System.Type GetObjectType(global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(type))
			{
				return type;
			}
			return type.BaseType();
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0009F88C File Offset: 0x0009DA8C
		public virtual T CreateObject<T>() where T : class
		{
			T t = default(T);
			global::System.Type typeFromHandle = typeof(T);
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeFromHandle, null);
			global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType item = this.MetadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType>(typeFromHandle.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyType;
			if (this.ContextOptions.ProxyCreationEnabled && (proxyType = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetProxyType(item, this.MetadataWorkspace)) != null)
			{
				t = (T)((object)proxyType.CreateProxyObject());
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory.CreateNewWrapper(t, null);
				entityWrapper.InitializingProxyRelatedEnds = true;
				try
				{
					entityWrapper.AttachContext(this, null, global::System.Data.Entity.Core.Objects.MergeOption.NoTracking);
					proxyType.SetEntityWrapper(entityWrapper);
					if (proxyType.InitializeEntityCollections != null)
					{
						proxyType.InitializeEntityCollections.Invoke(null, new object[]
						{
							entityWrapper
						});
					}
					return t;
				}
				finally
				{
					entityWrapper.InitializingProxyRelatedEnds = false;
					entityWrapper.DetachContext();
				}
			}
			t = (global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorDelegateForType(item)() as T);
			return t;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x0009F980 File Offset: 0x0009DB80
		public virtual int ExecuteStoreCommand(string commandText, params object[] parameters)
		{
			return this.ExecuteStoreCommand(this._options.EnsureTransactionsForFunctionsAndCommands ? global::System.Data.Entity.TransactionalBehavior.EnsureTransaction : global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, commandText, parameters);
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0009F99C File Offset: 0x0009DB9C
		public virtual int ExecuteStoreCommand(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string commandText, params object[] parameters)
		{
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Func<int> <>9__1;
			return executionStrategy.Execute<int>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<int> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => this.ExecuteStoreCommandInternal(commandText, parameters)));
				}
				return <>4__this.ExecuteInTransaction<int>(func, executionStrategy, transactionalBehavior != global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, true);
			});
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x0009FA04 File Offset: 0x0009DC04
		private int ExecuteStoreCommandInternal(string commandText, object[] parameters)
		{
			global::System.Data.Common.DbCommand dbCommand = this.CreateStoreCommand(commandText, parameters);
			int result;
			try
			{
				result = dbCommand.ExecuteNonQuery();
			}
			finally
			{
				dbCommand.Parameters.Clear();
				dbCommand.Dispose();
			}
			return result;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0009FA48 File Offset: 0x0009DC48
		public global::System.Threading.Tasks.Task<int> ExecuteStoreCommandAsync(string commandText, params object[] parameters)
		{
			return this.ExecuteStoreCommandAsync(this._options.EnsureTransactionsForFunctionsAndCommands ? global::System.Data.Entity.TransactionalBehavior.EnsureTransaction : global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, commandText, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0009FA68 File Offset: 0x0009DC68
		public global::System.Threading.Tasks.Task<int> ExecuteStoreCommandAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string commandText, params object[] parameters)
		{
			return this.ExecuteStoreCommandAsync(transactionalBehavior, commandText, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0009FA78 File Offset: 0x0009DC78
		public virtual global::System.Threading.Tasks.Task<int> ExecuteStoreCommandAsync(string commandText, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			return this.ExecuteStoreCommandAsync(this._options.EnsureTransactionsForFunctionsAndCommands ? global::System.Data.Entity.TransactionalBehavior.EnsureTransaction : global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, commandText, cancellationToken, parameters);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x0009FA94 File Offset: 0x0009DC94
		public virtual global::System.Threading.Tasks.Task<int> ExecuteStoreCommandAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string commandText, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.AsyncMonitor.EnsureNotEntered();
			return this.ExecuteStoreCommandInternalAsync(transactionalBehavior, commandText, cancellationToken, parameters);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0009FAB4 File Offset: 0x0009DCB4
		private async global::System.Threading.Tasks.Task<int> ExecuteStoreCommandInternalAsync(global::System.Data.Entity.TransactionalBehavior transactionalBehavior, string commandText, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			this.AsyncMonitor.Enter();
			int result;
			try
			{
				global::System.Func<global::System.Threading.Tasks.Task<int>> <>9__1;
				result = await executionStrategy.ExecuteAsync<int>(delegate()
				{
					global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
					global::System.Func<global::System.Threading.Tasks.Task<int>> func;
					if ((func = <>9__1) == null)
					{
						func = (<>9__1 = (() => this.ExecuteStoreCommandInternalAsync(commandText, cancellationToken, parameters)));
					}
					return <>4__this.ExecuteInTransactionAsync<int>(func, executionStrategy, transactionalBehavior != global::System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, true, cancellationToken);
				}, cancellationToken).WithCurrentCulture<int>();
			}
			finally
			{
				this.AsyncMonitor.Exit();
			}
			return result;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0009FB1C File Offset: 0x0009DD1C
		private async global::System.Threading.Tasks.Task<int> ExecuteStoreCommandInternalAsync(string commandText, global::System.Threading.CancellationToken cancellationToken, object[] parameters)
		{
			global::System.Data.Common.DbCommand command = this.CreateStoreCommand(commandText, parameters);
			int result;
			try
			{
				result = await command.ExecuteNonQueryAsync(cancellationToken).WithCurrentCulture<int>();
			}
			finally
			{
				command.Parameters.Clear();
				command.Dispose();
			}
			return result;
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x0009FB79 File Offset: 0x0009DD79
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters)
		{
			return this.ExecuteStoreQueryReliably<TElement>(commandText, null, global::System.Data.Entity.Core.Objects.ExecutionOptions.Default, parameters);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x0009FB89 File Offset: 0x0009DD89
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			return this.ExecuteStoreQueryReliably<TElement>(commandText, null, executionOptions, parameters);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x0009FB95 File Offset: 0x0009DD95
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			return this.ExecuteStoreQueryReliably<TElement>(commandText, entitySetName, new global::System.Data.Entity.Core.Objects.ExecutionOptions(mergeOption), parameters);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0009FBB3 File Offset: 0x0009DDB3
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			return this.ExecuteStoreQueryReliably<TElement>(commandText, entitySetName, executionOptions, parameters);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x0009FBCC File Offset: 0x0009DDCC
		private global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQueryReliably<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			this.AsyncMonitor.EnsureNotEntered();
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TElement), global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			if (executionStrategy.RetriesOnFailure && executionOptions.UserSpecifiedStreaming != null && executionOptions.UserSpecifiedStreaming.Value)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(executionStrategy.GetType().Name));
			}
			if (executionOptions.UserSpecifiedStreaming == null)
			{
				executionOptions = new global::System.Data.Entity.Core.Objects.ExecutionOptions(executionOptions.MergeOption, !executionStrategy.RetriesOnFailure);
			}
			global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> <>9__1;
			return executionStrategy.Execute<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(delegate()
			{
				global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
				global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> func;
				if ((func = <>9__1) == null)
				{
					func = (<>9__1 = (() => this.ExecuteStoreQueryInternal<TElement>(commandText, entitySetName, executionOptions, parameters)));
				}
				return <>4__this.ExecuteInTransaction<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(func, executionStrategy, false, !executionOptions.UserSpecifiedStreaming.Value);
			});
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x0009FCE4 File Offset: 0x0009DEE4
		private global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ExecuteStoreQueryInternal<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			global::System.Data.Common.DbDataReader dbDataReader = null;
			global::System.Data.Common.DbCommand dbCommand = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType;
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory;
			try
			{
				dbCommand = this.CreateStoreCommand(commandText, parameters);
				dbDataReader = dbCommand.ExecuteReader(executionOptions.UserSpecifiedStreaming.Value ? global::System.Data.CommandBehavior.Default : global::System.Data.CommandBehavior.SequentialAccess);
				shaperFactory = this.InternalTranslate<TElement>(dbDataReader, entitySetName, executionOptions.MergeOption, executionOptions.UserSpecifiedStreaming.Value, out entitySet, out edmType);
			}
			catch
			{
				if (dbDataReader != null)
				{
					dbDataReader.Dispose();
				}
				if (dbCommand != null)
				{
					dbCommand.Parameters.Clear();
					dbCommand.Dispose();
				}
				throw;
			}
			if (!executionOptions.UserSpecifiedStreaming.Value)
			{
				global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader bufferedDataReader = null;
				try
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					global::System.Data.Entity.Core.Common.DbProviderServices service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderInvariantName);
					bufferedDataReader = new global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader(dbDataReader);
					bufferedDataReader.Initialize(storeItemCollection.ProviderManifestToken, service, shaperFactory.ColumnTypes, shaperFactory.NullableColumns);
					dbDataReader = bufferedDataReader;
				}
				catch
				{
					if (bufferedDataReader != null)
					{
						bufferedDataReader.Dispose();
					}
					throw;
				}
			}
			return this.ShapeResult<TElement>(dbDataReader, executionOptions.MergeOption, true, executionOptions.UserSpecifiedStreaming.Value, shaperFactory, entitySet, edmType, dbCommand);
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x0009FE14 File Offset: 0x0009E014
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, params object[] parameters)
		{
			return this.ExecuteStoreQueryAsync<TElement>(commandText, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x0009FE24 File Offset: 0x0009E024
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			return this.ExecuteStoreQueryReliablyAsync<TElement>(commandText, null, global::System.Data.Entity.Core.Objects.ExecutionOptions.Default, cancellationToken, executionStrategy, parameters);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0009FE5E File Offset: 0x0009E05E
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			return this.ExecuteStoreQueryAsync<TElement>(commandText, executionOptions, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0009FE70 File Offset: 0x0009E070
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			if (executionStrategy.RetriesOnFailure && executionOptions.UserSpecifiedStreaming != null && executionOptions.UserSpecifiedStreaming.Value)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(executionStrategy.GetType().Name));
			}
			return this.ExecuteStoreQueryReliablyAsync<TElement>(commandText, null, executionOptions, cancellationToken, executionStrategy, parameters);
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x0009FEE5 File Offset: 0x0009E0E5
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, params object[] parameters)
		{
			return this.ExecuteStoreQueryAsync<TElement>(commandText, entitySetName, executionOptions, global::System.Threading.CancellationToken.None, parameters);
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x0009FEF8 File Offset: 0x0009E0F8
		public virtual global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryAsync<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this.AsyncMonitor.EnsureNotEntered();
			global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy = global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(this.Connection, this.MetadataWorkspace);
			if (executionStrategy.RetriesOnFailure && executionOptions.UserSpecifiedStreaming != null && executionOptions.UserSpecifiedStreaming.Value)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ExecutionStrategy_StreamingNotSupported(executionStrategy.GetType().Name));
			}
			return this.ExecuteStoreQueryReliablyAsync<TElement>(commandText, entitySetName, executionOptions, cancellationToken, executionStrategy, parameters);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x0009FF7C File Offset: 0x0009E17C
		private async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryReliablyAsync<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, global::System.Threading.CancellationToken cancellationToken, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy, params object[] parameters)
		{
			if (executionOptions.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
			{
				this.AsyncMonitor.Enter();
			}
			global::System.Data.Entity.Core.Objects.ObjectResult<TElement> result;
			try
			{
				this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TElement), global::System.Reflection.Assembly.GetCallingAssembly());
				if (executionOptions.UserSpecifiedStreaming == null)
				{
					executionOptions = new global::System.Data.Entity.Core.Objects.ExecutionOptions(executionOptions.MergeOption, !executionStrategy.RetriesOnFailure);
				}
				global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>> <>9__1;
				result = await executionStrategy.ExecuteAsync<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(delegate()
				{
					global::System.Data.Entity.Core.Objects.ObjectContext <>4__this = this;
					global::System.Func<global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>> func;
					if ((func = <>9__1) == null)
					{
						func = (<>9__1 = (() => this.ExecuteStoreQueryInternalAsync<TElement>(commandText, entitySetName, executionOptions, cancellationToken, parameters)));
					}
					return <>4__this.ExecuteInTransactionAsync<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>(func, executionStrategy, false, !executionOptions.UserSpecifiedStreaming.Value, cancellationToken);
				}, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>>();
			}
			finally
			{
				if (executionOptions.MergeOption != global::System.Data.Entity.Core.Objects.MergeOption.NoTracking)
				{
					this.AsyncMonitor.Exit();
				}
			}
			return result;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x0009FFF4 File Offset: 0x0009E1F4
		private async global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<TElement>> ExecuteStoreQueryInternalAsync<TElement>(string commandText, string entitySetName, global::System.Data.Entity.Core.Objects.ExecutionOptions executionOptions, global::System.Threading.CancellationToken cancellationToken, params object[] parameters)
		{
			global::System.Data.Common.DbDataReader reader = null;
			global::System.Data.Common.DbCommand command = null;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType;
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory;
			try
			{
				command = this.CreateStoreCommand(commandText, parameters);
				global::System.Data.Common.DbDataReader dbDataReader = await command.ExecuteReaderAsync(executionOptions.UserSpecifiedStreaming.Value ? global::System.Data.CommandBehavior.Default : global::System.Data.CommandBehavior.SequentialAccess, cancellationToken).WithCurrentCulture<global::System.Data.Common.DbDataReader>();
				reader = dbDataReader;
				shaperFactory = this.InternalTranslate<TElement>(reader, entitySetName, executionOptions.MergeOption, executionOptions.UserSpecifiedStreaming.Value, out entitySet, out edmType);
			}
			catch
			{
				if (reader != null)
				{
					reader.Dispose();
				}
				if (command != null)
				{
					command.Parameters.Clear();
					command.Dispose();
				}
				throw;
			}
			if (!executionOptions.UserSpecifiedStreaming.Value)
			{
				global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader bufferedReader = null;
				try
				{
					global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection storeItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
					global::System.Data.Entity.Core.Common.DbProviderServices service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(storeItemCollection.ProviderInvariantName);
					bufferedReader = new global::System.Data.Entity.Core.Objects.Internal.BufferedDataReader(reader);
					await bufferedReader.InitializeAsync(storeItemCollection.ProviderManifestToken, service, shaperFactory.ColumnTypes, shaperFactory.NullableColumns, cancellationToken).WithCurrentCulture();
					reader = bufferedReader;
				}
				catch
				{
					if (bufferedReader != null)
					{
						bufferedReader.Dispose();
					}
					throw;
				}
				bufferedReader = null;
			}
			return this.ShapeResult<TElement>(reader, executionOptions.MergeOption, true, executionOptions.UserSpecifiedStreaming.Value, shaperFactory, entitySet, edmType, command);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000A0064 File Offset: 0x0009E264
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TElement> Translate<TElement>(global::System.Data.Common.DbDataReader reader)
		{
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TElement), global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType;
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory = this.InternalTranslate<TElement>(reader, null, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, false, out entitySet, out edmType);
			return this.ShapeResult<TElement>(reader, global::System.Data.Entity.Core.Objects.MergeOption.AppendOnly, false, false, shaperFactory, entitySet, edmType, null);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000A00A8 File Offset: 0x0009E2A8
		public virtual global::System.Data.Entity.Core.Objects.ObjectResult<TEntity> Translate<TEntity>(global::System.Data.Common.DbDataReader reader, string entitySetName, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this.MetadataWorkspace.ImplicitLoadAssemblyForType(typeof(TEntity), global::System.Reflection.Assembly.GetCallingAssembly());
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType;
			global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TEntity> shaperFactory = this.InternalTranslate<TEntity>(reader, entitySetName, mergeOption, false, out entitySet, out edmType);
			return this.ShapeResult<TEntity>(reader, mergeOption, false, false, shaperFactory, entitySet, edmType, null);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000A00F8 File Offset: 0x0009E2F8
		private global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> InternalTranslate<TElement>(global::System.Data.Common.DbDataReader reader, string entitySetName, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool streaming, out global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType)
		{
			global::System.Data.Entity.Core.EntityUtil.CheckArgumentMergeOption(mergeOption);
			entitySet = null;
			if (!string.IsNullOrEmpty(entitySetName))
			{
				entitySet = this.GetEntitySetFromName(entitySetName);
			}
			global::System.Type type = global::System.Nullable.GetUnderlyingType(typeof(TElement)) ?? typeof(TElement);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2;
			global::System.Data.Entity.Core.Query.InternalTrees.CollectionColumnMap collectionColumnMap;
			if (this.MetadataWorkspace.TryDetermineCSpaceModelType<TElement>(out edmType2) || (type.IsEnum() && this.MetadataWorkspace.TryDetermineCSpaceModelType(type.GetEnumUnderlyingType(), out edmType2)))
			{
				if (entitySet != null && !entitySet.ElementType.IsAssignableFrom(edmType2))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_InvalidEntitySetForStoreQuery(entitySet.EntityContainer.Name, entitySet.Name, typeof(TElement)));
				}
				collectionColumnMap = this._columnMapFactory.CreateColumnMapFromReaderAndType(reader, edmType2, entitySet, null);
			}
			else
			{
				collectionColumnMap = this._columnMapFactory.CreateColumnMapFromReaderAndClrType(reader, typeof(TElement), this.MetadataWorkspace);
			}
			edmType = collectionColumnMap.Type;
			return this._translator.TranslateColumnMap<TElement>(collectionColumnMap, this.MetadataWorkspace, null, mergeOption, streaming, false);
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000A01FB File Offset: 0x0009E3FB
		private global::System.Data.Entity.Core.Objects.ObjectResult<TElement> ShapeResult<TElement>(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool readerOwned, bool streaming, global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory<TElement> shaperFactory, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmType, global::System.Data.Common.DbCommand command = null)
		{
			return new global::System.Data.Entity.Core.Objects.ObjectResult<TElement>(shaperFactory.Create(reader, this, this.MetadataWorkspace, mergeOption, readerOwned, streaming), entitySet, global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetElementType(edmType), readerOwned, streaming, command);
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000A0224 File Offset: 0x0009E424
		private global::System.Data.Common.DbCommand CreateStoreCommand(string commandText, params object[] parameters)
		{
			global::System.Data.Common.DbCommand dbCommand = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).StoreConnection.CreateCommand();
			dbCommand.CommandText = commandText;
			if (this.CommandTimeout != null)
			{
				dbCommand.CommandTimeout = this.CommandTimeout.Value;
			}
			global::System.Data.Entity.Core.EntityClient.EntityTransaction currentTransaction = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).CurrentTransaction;
			if (currentTransaction != null)
			{
				dbCommand.Transaction = currentTransaction.StoreTransaction;
			}
			if (parameters != null && parameters.Length != 0)
			{
				global::System.Data.Common.DbParameter[] array = new global::System.Data.Common.DbParameter[parameters.Length];
				if (parameters.All((object p) => p is global::System.Data.Common.DbParameter))
				{
					for (int i = 0; i < parameters.Length; i++)
					{
						array[i] = (global::System.Data.Common.DbParameter)parameters[i];
					}
				}
				else
				{
					if (parameters.Any((object p) => p is global::System.Data.Common.DbParameter))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues);
					}
					string[] array2 = new string[parameters.Length];
					string[] array3 = new string[parameters.Length];
					for (int j = 0; j < parameters.Length; j++)
					{
						array2[j] = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "p{0}", new object[]
						{
							j
						});
						array[j] = dbCommand.CreateParameter();
						array[j].ParameterName = array2[j];
						array[j].Value = (parameters[j] ?? global::System.DBNull.Value);
						array3[j] = "@" + array2[j];
					}
					global::System.Data.Common.DbCommand dbCommand2 = dbCommand;
					global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
					string commandText2 = dbCommand.CommandText;
					object[] args = array3;
					dbCommand2.CommandText = string.Format(invariantCulture, commandText2, args);
				}
				dbCommand.Parameters.AddRange(array);
			}
			return new global::System.Data.Entity.Internal.InterceptableDbCommand(dbCommand, this.InterceptionContext, null);
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000A03EC File Offset: 0x0009E5EC
		public virtual void CreateDatabase()
		{
			global::System.Data.Common.DbConnection storeConnection = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).StoreConnection;
			this.GetStoreItemCollection().ProviderFactory.GetProviderServices().CreateDatabase(storeConnection, this.CommandTimeout, this.GetStoreItemCollection());
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000A042C File Offset: 0x0009E62C
		public virtual void DeleteDatabase()
		{
			global::System.Data.Common.DbConnection storeConnection = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).StoreConnection;
			this.GetStoreItemCollection().ProviderFactory.GetProviderServices().DeleteDatabase(storeConnection, this.CommandTimeout, this.GetStoreItemCollection());
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000A046C File Offset: 0x0009E66C
		public virtual bool DatabaseExists()
		{
			global::System.Data.Common.DbConnection storeConnection = ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).StoreConnection;
			global::System.Data.Entity.Core.Common.DbProviderServices providerServices = this.GetStoreItemCollection().ProviderFactory.GetProviderServices();
			bool result;
			try
			{
				result = providerServices.DatabaseExists(storeConnection, this.CommandTimeout, this.GetStoreItemCollection());
			}
			catch (global::System.Exception)
			{
				if (this.Connection.State == global::System.Data.ConnectionState.Open)
				{
					result = true;
				}
				else
				{
					try
					{
						this.Connection.Open();
						result = true;
					}
					catch (global::System.Data.Entity.Core.EntityException)
					{
						result = false;
					}
					finally
					{
						this.Connection.Close();
					}
				}
			}
			return result;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000A0510 File Offset: 0x0009E710
		private global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection GetStoreItemCollection()
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)((global::System.Data.Entity.Core.EntityClient.EntityConnection)this.Connection).GetMetadataWorkspace().GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000A0530 File Offset: 0x0009E730
		public virtual string CreateDatabaseScript()
		{
			global::System.Data.Entity.Core.Common.DbProviderServices providerServices = this.GetStoreItemCollection().ProviderFactory.GetProviderServices();
			string providerManifestToken = this.GetStoreItemCollection().ProviderManifestToken;
			return providerServices.CreateDatabaseScript(providerManifestToken, this.GetStoreItemCollection());
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000A0568 File Offset: 0x0009E768
		internal void InitializeMappingViewCacheFactory(global::System.Data.Entity.DbContext owner = null)
		{
			global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection itemCollection = (global::System.Data.Entity.Core.Mapping.StorageMappingItemCollection)this.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace);
			if (itemCollection == null)
			{
				return;
			}
			global::System.Type key = (owner != null) ? owner.GetType() : base.GetType();
			global::System.Data.Entity.Core.Objects.ObjectContext._contextTypesWithViewCacheInitialized.GetOrAdd(key, delegate(global::System.Type t)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute> source = from a in t.Assembly().GetCustomAttributes<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute>()
				where a.ContextType == t
				select a;
				int num = source.Count<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute>();
				if (num > 1)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbMappingViewCacheTypeAttribute_MultipleInstancesWithSameContextType(t));
				}
				if (num == 1)
				{
					itemCollection.MappingViewCacheFactory = new global::System.Data.Entity.Infrastructure.MappingViews.DefaultDbMappingViewCacheFactory(source.First<global::System.Data.Entity.Infrastructure.MappingViews.DbMappingViewCacheTypeAttribute>().CacheType);
				}
				return true;
			});
		}

		// Token: 0x04001053 RID: 4179
		private bool _disposed;

		// Token: 0x04001054 RID: 4180
		private readonly global::System.Data.Entity.Core.EntityClient.Internal.IEntityAdapter _adapter;

		// Token: 0x04001055 RID: 4181
		private global::System.Data.Entity.Core.EntityClient.EntityConnection _connection;

		// Token: 0x04001056 RID: 4182
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

		// Token: 0x04001057 RID: 4183
		private global::System.Data.Entity.Core.Objects.ObjectStateManager _objectStateManager;

		// Token: 0x04001058 RID: 4184
		private global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective _perspective;

		// Token: 0x04001059 RID: 4185
		private bool _contextOwnsConnection;

		// Token: 0x0400105A RID: 4186
		private bool _openedConnection;

		// Token: 0x0400105B RID: 4187
		private int _connectionRequestCount;

		// Token: 0x0400105C RID: 4188
		private int? _queryTimeout;

		// Token: 0x0400105D RID: 4189
		private global::System.Transactions.Transaction _lastTransaction;

		// Token: 0x0400105E RID: 4190
		private readonly bool _disallowSettingDefaultContainerName;

		// Token: 0x0400105F RID: 4191
		private global::System.EventHandler _onSavingChanges;

		// Token: 0x04001060 RID: 4192
		private global::System.Data.Entity.Core.Objects.ObjectMaterializedEventHandler _onObjectMaterialized;

		// Token: 0x04001061 RID: 4193
		private global::System.Data.Entity.Core.Objects.ELinq.ObjectQueryProvider _queryProvider;

		// Token: 0x04001062 RID: 4194
		private readonly global::System.Data.Entity.Core.Objects.Internal.EntityWrapperFactory _entityWrapperFactory;

		// Token: 0x04001063 RID: 4195
		private readonly global::System.Data.Entity.Core.Objects.Internal.ObjectQueryExecutionPlanFactory _objectQueryExecutionPlanFactory;

		// Token: 0x04001064 RID: 4196
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Translator _translator;

		// Token: 0x04001065 RID: 4197
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapFactory _columnMapFactory;

		// Token: 0x04001066 RID: 4198
		private readonly global::System.Data.Entity.Core.Objects.ObjectContextOptions _options;

		// Token: 0x04001067 RID: 4199
		private const string UseLegacyPreserveChangesBehavior = "EntityFramework_UseLegacyPreserveChangesBehavior";

		// Token: 0x04001068 RID: 4200
		private readonly global::System.Data.Entity.Internal.ThrowingMonitor _asyncMonitor;

		// Token: 0x04001069 RID: 4201
		private global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext _interceptionContext;

		// Token: 0x0400106A RID: 4202
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool> _contextTypesWithViewCacheInitialized = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, bool>();

		// Token: 0x0400106B RID: 4203
		private global::System.Data.Entity.Infrastructure.TransactionHandler _transactionHandler;

		// Token: 0x02000A18 RID: 2584
		private class ParameterBinder
		{
			// Token: 0x06006111 RID: 24849 RVA: 0x0014C738 File Offset: 0x0014A938
			internal ParameterBinder(global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter, global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter)
			{
				this._entityParameter = entityParameter;
				this._objectParameter = objectParameter;
			}

			// Token: 0x06006112 RID: 24850 RVA: 0x0014C750 File Offset: 0x0014A950
			internal void OnDataReaderClosingHandler(object sender, global::System.EventArgs args)
			{
				if (this._entityParameter.Value != global::System.DBNull.Value && this._objectParameter.MappableType.IsEnum())
				{
					this._objectParameter.Value = global::System.Enum.ToObject(this._objectParameter.MappableType, this._entityParameter.Value);
					return;
				}
				this._objectParameter.Value = this._entityParameter.Value;
			}

			// Token: 0x04002948 RID: 10568
			private readonly global::System.Data.Entity.Core.EntityClient.EntityParameter _entityParameter;

			// Token: 0x04002949 RID: 10569
			private readonly global::System.Data.Entity.Core.Objects.ObjectParameter _objectParameter;
		}
	}
}
