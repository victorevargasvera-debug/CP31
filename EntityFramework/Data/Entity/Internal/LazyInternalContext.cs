using System;
using System.Collections.Concurrent;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000124 RID: 292
	internal class LazyInternalContext : global::System.Data.Entity.Internal.InternalContext
	{
		// Token: 0x06001456 RID: 5206 RVA: 0x00033D6C File Offset: 0x00031F6C
		public LazyInternalContext(global::System.Data.Entity.DbContext owner, global::System.Data.Entity.Internal.IInternalConnection internalConnection, global::System.Data.Entity.Infrastructure.DbCompiledModel model, global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey> cacheKeyFactory = null, global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider = null, global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> dispatchers = null, global::System.Data.Entity.Core.Objects.ObjectContext objectContext = null) : base(owner, dispatchers)
		{
			this._internalConnection = internalConnection;
			this._model = model;
			this._cacheKeyFactory = (cacheKeyFactory ?? new global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>(new global::System.Data.Entity.Internal.DefaultModelCacheKeyFactory().Create));
			this._attributeProvider = (attributeProvider ?? new global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider());
			this._objectContext = objectContext;
			this._createdWithExistingModel = (model != null);
			base.LoadContextConfigs();
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00033DEA File Offset: 0x00031FEA
		public override global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				base.Initialize();
				return this.ObjectContextInUse;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00033DF8 File Offset: 0x00031FF8
		public override global::System.Data.Entity.Infrastructure.DbCompiledModel CodeFirstModel
		{
			get
			{
				this.InitializeContext();
				return this._model;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00033E06 File Offset: 0x00032006
		public override global::System.Data.Entity.Infrastructure.DbModel ModelBeingInitialized
		{
			get
			{
				this.InitializeContext();
				return this._modelBeingInitialized;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00033E14 File Offset: 0x00032014
		public override global::System.Data.Entity.Core.Objects.ObjectContext GetObjectContextWithoutDatabaseInitialization()
		{
			this.InitializeContext();
			return this.ObjectContextInUse;
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x00033E22 File Offset: 0x00032022
		public virtual global::System.Data.Entity.Core.Objects.ObjectContext ObjectContextInUse
		{
			get
			{
				return base.TempObjectContext ?? this._objectContext;
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00033E34 File Offset: 0x00032034
		public override int SaveChanges()
		{
			if (this.ObjectContextInUse != null)
			{
				return base.SaveChanges();
			}
			return 0;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00033E46 File Offset: 0x00032046
		public override global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (this.ObjectContextInUse != null)
			{
				return base.SaveChangesAsync(cancellationToken);
			}
			return global::System.Threading.Tasks.Task.FromResult<int>(0);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00033E65 File Offset: 0x00032065
		public override void DisposeContext(bool disposing)
		{
			if (!base.IsDisposed)
			{
				base.DisposeContext(disposing);
				if (disposing)
				{
					if (this._objectContext != null)
					{
						this._objectContext.Dispose();
					}
					this._internalConnection.Dispose();
				}
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00033E97 File Offset: 0x00032097
		public override global::System.Data.Common.DbConnection Connection
		{
			get
			{
				base.CheckContextNotDisposed();
				if (base.TempObjectContext != null)
				{
					return ((global::System.Data.Entity.Core.EntityClient.EntityConnection)base.TempObjectContext.Connection).StoreConnection;
				}
				return this._internalConnection.Connection;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00033EC8 File Offset: 0x000320C8
		public override string OriginalConnectionString
		{
			get
			{
				return this._internalConnection.OriginalConnectionString;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00033ED5 File Offset: 0x000320D5
		public override global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin
		{
			get
			{
				base.CheckContextNotDisposed();
				return this._internalConnection.ConnectionStringOrigin;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x00033EE8 File Offset: 0x000320E8
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x00033EF0 File Offset: 0x000320F0
		public override global::System.Data.Entity.Internal.AppConfig AppConfig
		{
			get
			{
				return base.AppConfig;
			}
			set
			{
				base.AppConfig = value;
				this._internalConnection.AppConfig = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00033F05 File Offset: 0x00032105
		public override string ConnectionStringName
		{
			get
			{
				base.CheckContextNotDisposed();
				return this._internalConnection.ConnectionStringName;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x00033F18 File Offset: 0x00032118
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x00033F26 File Offset: 0x00032126
		public override global::System.Data.Entity.Infrastructure.DbProviderInfo ModelProviderInfo
		{
			get
			{
				base.CheckContextNotDisposed();
				return this._modelProviderInfo;
			}
			set
			{
				base.CheckContextNotDisposed();
				this._modelProviderInfo = value;
				this._internalConnection.ProviderName = this._modelProviderInfo.ProviderInvariantName;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00033F4B File Offset: 0x0003214B
		public override string ProviderName
		{
			get
			{
				return this._internalConnection.ProviderName;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00033F58 File Offset: 0x00032158
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00033F66 File Offset: 0x00032166
		public override global::System.Action<global::System.Data.Entity.DbModelBuilder> OnModelCreating
		{
			get
			{
				base.CheckContextNotDisposed();
				return this._onModelCreating;
			}
			set
			{
				base.CheckContextNotDisposed();
				this._onModelCreating = value;
			}
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00033F78 File Offset: 0x00032178
		public override void OverrideConnection(global::System.Data.Entity.Internal.IInternalConnection connection)
		{
			connection.AppConfig = this.AppConfig;
			if (connection.ConnectionHasModel != this._internalConnection.ConnectionHasModel)
			{
				throw this._internalConnection.ConnectionHasModel ? global::System.Data.Entity.Resources.Error.LazyInternalContext_CannotReplaceEfConnectionWithDbConnection() : global::System.Data.Entity.Resources.Error.LazyInternalContext_CannotReplaceDbConnectionWithEfConnection();
			}
			this._internalConnection.Dispose();
			this._internalConnection = connection;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00033FD0 File Offset: 0x000321D0
		protected override void InitializeContext()
		{
			base.CheckContextNotDisposed();
			if (this._objectContext == null)
			{
				if (this._creatingModel)
				{
					throw global::System.Data.Entity.Resources.Error.DbContext_ContextUsedInModelCreating();
				}
				try
				{
					global::System.Data.Entity.Infrastructure.DbContextInfo currentInfo = global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo;
					if (currentInfo != null)
					{
						base.ApplyContextInfo(currentInfo);
					}
					this._creatingModel = true;
					if (this._createdWithExistingModel)
					{
						if (this._internalConnection.ConnectionHasModel)
						{
							throw global::System.Data.Entity.Resources.Error.DbContext_ConnectionHasModel();
						}
						this._objectContext = this._model.CreateObjectContext<global::System.Data.Entity.Core.Objects.ObjectContext>(this._internalConnection.Connection);
					}
					else if (this._internalConnection.ConnectionHasModel)
					{
						this._objectContext = this._internalConnection.CreateObjectContextFromConnectionModel();
					}
					else
					{
						global::System.Data.Entity.Infrastructure.IDbModelCacheKey key = this._cacheKeyFactory(base.Owner);
						global::System.Data.Entity.Infrastructure.DbCompiledModel value = global::System.Data.Entity.Internal.LazyInternalContext._cachedModels.GetOrAdd(key, (global::System.Data.Entity.Infrastructure.IDbModelCacheKey t) => new global::System.Data.Entity.Internal.RetryLazy<global::System.Data.Entity.Internal.LazyInternalContext, global::System.Data.Entity.Infrastructure.DbCompiledModel>(new global::System.Func<global::System.Data.Entity.Internal.LazyInternalContext, global::System.Data.Entity.Infrastructure.DbCompiledModel>(global::System.Data.Entity.Internal.LazyInternalContext.CreateModel))).GetValue(this);
						this._objectContext = value.CreateObjectContext<global::System.Data.Entity.Core.Objects.ObjectContext>(this._internalConnection.Connection);
						this._model = value;
					}
					this._objectContext.ContextOptions.EnsureTransactionsForFunctionsAndCommands = this._initialEnsureTransactionsForFunctionsAndCommands;
					this._objectContext.ContextOptions.LazyLoadingEnabled = this._initialLazyLoadingFlag;
					this._objectContext.ContextOptions.ProxyCreationEnabled = this._initialProxyCreationFlag;
					this._objectContext.ContextOptions.UseCSharpNullComparisonBehavior = !this._useDatabaseNullSemanticsFlag;
					this._objectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions = this._disableFilterOverProjectionSimplificationForCustomFunctions;
					this._objectContext.CommandTimeout = this._commandTimeout;
					this._objectContext.ContextOptions.UseConsistentNullReferenceBehavior = true;
					this._objectContext.InterceptionContext = this._objectContext.InterceptionContext.WithDbContext(base.Owner);
					base.ResetDbSets();
					this._objectContext.InitializeMappingViewCacheFactory(base.Owner);
				}
				finally
				{
					this._creatingModel = false;
				}
			}
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000341C4 File Offset: 0x000323C4
		public static global::System.Data.Entity.Infrastructure.DbCompiledModel CreateModel(global::System.Data.Entity.Internal.LazyInternalContext internalContext)
		{
			global::System.Type type = internalContext.Owner.GetType();
			global::System.Data.Entity.Infrastructure.DbModelStore dbModelStore = null;
			if (!(internalContext.Owner is global::System.Data.Entity.Migrations.History.HistoryContext))
			{
				dbModelStore = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.DbModelStore>();
				if (dbModelStore != null)
				{
					global::System.Data.Entity.Infrastructure.DbCompiledModel dbCompiledModel = dbModelStore.TryLoad(type);
					if (dbCompiledModel != null)
					{
						return dbCompiledModel;
					}
				}
			}
			global::System.Data.Entity.DbModelBuilder dbModelBuilder = internalContext.CreateModelBuilder();
			global::System.Data.Entity.Infrastructure.DbModel dbModel = (internalContext._modelProviderInfo == null) ? dbModelBuilder.Build(internalContext._internalConnection.Connection) : dbModelBuilder.Build(internalContext._modelProviderInfo);
			internalContext._modelBeingInitialized = dbModel;
			if (dbModelStore != null)
			{
				dbModelStore.Save(type, dbModel);
			}
			return dbModel.Compile();
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00034254 File Offset: 0x00032454
		public global::System.Data.Entity.DbModelBuilder CreateModelBuilder()
		{
			global::System.Data.Entity.DbModelBuilderVersionAttribute dbModelBuilderVersionAttribute = this._attributeProvider.GetAttributes(base.Owner.GetType()).OfType<global::System.Data.Entity.DbModelBuilderVersionAttribute>().FirstOrDefault<global::System.Data.Entity.DbModelBuilderVersionAttribute>();
			global::System.Data.Entity.DbModelBuilder dbModelBuilder = new global::System.Data.Entity.DbModelBuilder((dbModelBuilderVersionAttribute != null) ? dbModelBuilderVersionAttribute.Version : global::System.Data.Entity.DbModelBuilderVersion.Latest);
			string text = global::System.Data.Entity.Internal.LazyInternalContext.StripInvalidCharacters(base.Owner.GetType().Namespace);
			if (!string.IsNullOrWhiteSpace(text))
			{
				dbModelBuilder.Conventions.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
				{
					new global::System.Data.Entity.Infrastructure.ModelNamespaceConvention(text)
				});
			}
			string text2 = global::System.Data.Entity.Internal.LazyInternalContext.StripInvalidCharacters(base.Owner.GetType().Name);
			if (!string.IsNullOrWhiteSpace(text2))
			{
				dbModelBuilder.Conventions.Add(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
				{
					new global::System.Data.Entity.Infrastructure.ModelContainerConvention(text2)
				});
			}
			new global::System.Data.Entity.Internal.DbSetDiscoveryService(base.Owner).RegisterSets(dbModelBuilder);
			base.Owner.CallOnModelCreating(dbModelBuilder);
			if (this.OnModelCreating != null)
			{
				this.OnModelCreating(dbModelBuilder);
			}
			return dbModelBuilder;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00034338 File Offset: 0x00032538
		private static string StripInvalidCharacters(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				return string.Empty;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(value.Length);
			bool flag = true;
			foreach (char c in value)
			{
				if (c == '.')
				{
					if (!flag)
					{
						stringBuilder.Append(c);
					}
				}
				else
				{
					switch (char.GetUnicodeCategory(c))
					{
					case global::System.Globalization.UnicodeCategory.UppercaseLetter:
					case global::System.Globalization.UnicodeCategory.LowercaseLetter:
					case global::System.Globalization.UnicodeCategory.TitlecaseLetter:
					case global::System.Globalization.UnicodeCategory.ModifierLetter:
					case global::System.Globalization.UnicodeCategory.OtherLetter:
					case global::System.Globalization.UnicodeCategory.LetterNumber:
						flag = false;
						stringBuilder.Append(c);
						break;
					case global::System.Globalization.UnicodeCategory.NonSpacingMark:
					case global::System.Globalization.UnicodeCategory.SpacingCombiningMark:
					case global::System.Globalization.UnicodeCategory.DecimalDigitNumber:
					case global::System.Globalization.UnicodeCategory.ConnectorPunctuation:
						if (!flag)
						{
							stringBuilder.Append(c);
						}
						break;
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00034418 File Offset: 0x00032618
		public override void MarkDatabaseNotInitialized()
		{
			if (!base.InInitializationAction)
			{
				global::System.Data.Entity.Internal.RetryAction<global::System.Data.Entity.Internal.InternalContext> retryAction;
				global::System.Data.Entity.Internal.LazyInternalContext.InitializedDatabases.TryRemove(global::System.Tuple.Create<global::System.Data.Entity.Infrastructure.DbCompiledModel, string>(this._model, this._internalConnection.ConnectionKey), out retryAction);
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00034450 File Offset: 0x00032650
		public override void MarkDatabaseInitialized()
		{
			this.InitializeContext();
			this.InitializeDatabaseAction(delegate(global::System.Data.Entity.Internal.InternalContext c)
			{
			});
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x0003447D File Offset: 0x0003267D
		protected override void InitializeDatabase()
		{
			this.InitializeDatabaseAction(delegate(global::System.Data.Entity.Internal.InternalContext c)
			{
				c.PerformDatabaseInitialization();
			});
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000344A4 File Offset: 0x000326A4
		private void InitializeDatabaseAction(global::System.Action<global::System.Data.Entity.Internal.InternalContext> action)
		{
			if (!this._inDatabaseInitialization && !base.InitializerDisabled)
			{
				try
				{
					this._inDatabaseInitialization = true;
					global::System.Data.Entity.Internal.LazyInternalContext.InitializedDatabases.GetOrAdd(global::System.Tuple.Create<global::System.Data.Entity.Infrastructure.DbCompiledModel, string>(this._model, this._internalConnection.ConnectionKey), (global::System.Tuple<global::System.Data.Entity.Infrastructure.DbCompiledModel, string> t) => new global::System.Data.Entity.Internal.RetryAction<global::System.Data.Entity.Internal.InternalContext>(action)).PerformAction(this);
				}
				finally
				{
					this._inDatabaseInitialization = false;
					this._modelBeingInitialized = null;
				}
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x00034528 File Offset: 0x00032728
		public override global::System.Data.Entity.IDatabaseInitializer<global::System.Data.Entity.DbContext> DefaultInitializer
		{
			get
			{
				if (this._model == null)
				{
					return null;
				}
				return global::System.Data.Entity.Internal.LazyInternalContext._defaultCodeFirstInitializer;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0003453C File Offset: 0x0003273C
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00034568 File Offset: 0x00032768
		public override bool EnsureTransactionsForFunctionsAndCommands
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._initialEnsureTransactionsForFunctionsAndCommands;
				}
				return objectContextInUse.ContextOptions.EnsureTransactionsForFunctionsAndCommands;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.ContextOptions.EnsureTransactionsForFunctionsAndCommands = value;
					return;
				}
				this._initialEnsureTransactionsForFunctionsAndCommands = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00034594 File Offset: 0x00032794
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x000345C0 File Offset: 0x000327C0
		public override bool LazyLoadingEnabled
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._initialLazyLoadingFlag;
				}
				return objectContextInUse.ContextOptions.LazyLoadingEnabled;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.ContextOptions.LazyLoadingEnabled = value;
					return;
				}
				this._initialLazyLoadingFlag = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000345EC File Offset: 0x000327EC
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x00034618 File Offset: 0x00032818
		public override bool ProxyCreationEnabled
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._initialProxyCreationFlag;
				}
				return objectContextInUse.ContextOptions.ProxyCreationEnabled;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.ContextOptions.ProxyCreationEnabled = value;
					return;
				}
				this._initialProxyCreationFlag = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00034644 File Offset: 0x00032844
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00034670 File Offset: 0x00032870
		public override bool UseDatabaseNullSemantics
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._useDatabaseNullSemanticsFlag;
				}
				return !objectContextInUse.ContextOptions.UseCSharpNullComparisonBehavior;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.ContextOptions.UseCSharpNullComparisonBehavior = !value;
					return;
				}
				this._useDatabaseNullSemanticsFlag = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x000346A0 File Offset: 0x000328A0
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x000346CC File Offset: 0x000328CC
		public override bool DisableFilterOverProjectionSimplificationForCustomFunctions
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._disableFilterOverProjectionSimplificationForCustomFunctions;
				}
				return !objectContextInUse.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions = !value;
					return;
				}
				this._disableFilterOverProjectionSimplificationForCustomFunctions = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x000346FC File Offset: 0x000328FC
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x00034720 File Offset: 0x00032920
		public override int? CommandTimeout
		{
			get
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse == null)
				{
					return this._commandTimeout;
				}
				return objectContextInUse.CommandTimeout;
			}
			set
			{
				global::System.Data.Entity.Core.Objects.ObjectContext objectContextInUse = this.ObjectContextInUse;
				if (objectContextInUse != null)
				{
					objectContextInUse.CommandTimeout = value;
					return;
				}
				this._commandTimeout = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00034746 File Offset: 0x00032946
		public override string DefaultSchema
		{
			get
			{
				return this.CodeFirstModel.DefaultSchema;
			}
		}

		// Token: 0x0400098D RID: 2445
		private static readonly global::System.Data.Entity.CreateDatabaseIfNotExists<global::System.Data.Entity.DbContext> _defaultCodeFirstInitializer = new global::System.Data.Entity.CreateDatabaseIfNotExists<global::System.Data.Entity.DbContext>();

		// Token: 0x0400098E RID: 2446
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.IDbModelCacheKey, global::System.Data.Entity.Internal.RetryLazy<global::System.Data.Entity.Internal.LazyInternalContext, global::System.Data.Entity.Infrastructure.DbCompiledModel>> _cachedModels = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Data.Entity.Infrastructure.IDbModelCacheKey, global::System.Data.Entity.Internal.RetryLazy<global::System.Data.Entity.Internal.LazyInternalContext, global::System.Data.Entity.Infrastructure.DbCompiledModel>>();

		// Token: 0x0400098F RID: 2447
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Data.Entity.Infrastructure.DbCompiledModel, string>, global::System.Data.Entity.Internal.RetryAction<global::System.Data.Entity.Internal.InternalContext>> InitializedDatabases = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Data.Entity.Infrastructure.DbCompiledModel, string>, global::System.Data.Entity.Internal.RetryAction<global::System.Data.Entity.Internal.InternalContext>>();

		// Token: 0x04000990 RID: 2448
		private global::System.Data.Entity.Internal.IInternalConnection _internalConnection;

		// Token: 0x04000991 RID: 2449
		private bool _creatingModel;

		// Token: 0x04000992 RID: 2450
		private global::System.Data.Entity.Core.Objects.ObjectContext _objectContext;

		// Token: 0x04000993 RID: 2451
		private global::System.Data.Entity.Infrastructure.DbCompiledModel _model;

		// Token: 0x04000994 RID: 2452
		private readonly bool _createdWithExistingModel;

		// Token: 0x04000995 RID: 2453
		private bool _initialEnsureTransactionsForFunctionsAndCommands = true;

		// Token: 0x04000996 RID: 2454
		private bool _initialLazyLoadingFlag = true;

		// Token: 0x04000997 RID: 2455
		private bool _initialProxyCreationFlag = true;

		// Token: 0x04000998 RID: 2456
		private bool _useDatabaseNullSemanticsFlag;

		// Token: 0x04000999 RID: 2457
		private int? _commandTimeout;

		// Token: 0x0400099A RID: 2458
		private bool _inDatabaseInitialization;

		// Token: 0x0400099B RID: 2459
		private global::System.Action<global::System.Data.Entity.DbModelBuilder> _onModelCreating;

		// Token: 0x0400099C RID: 2460
		private readonly global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey> _cacheKeyFactory;

		// Token: 0x0400099D RID: 2461
		private readonly global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider _attributeProvider;

		// Token: 0x0400099E RID: 2462
		private global::System.Data.Entity.Infrastructure.DbModel _modelBeingInitialized;

		// Token: 0x0400099F RID: 2463
		private global::System.Data.Entity.Infrastructure.DbProviderInfo _modelProviderInfo;

		// Token: 0x040009A0 RID: 2464
		private bool _disableFilterOverProjectionSimplificationForCustomFunctions;
	}
}
