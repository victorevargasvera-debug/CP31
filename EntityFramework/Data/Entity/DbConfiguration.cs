using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Resources;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity
{
	// Token: 0x02000059 RID: 89
	public class DbConfiguration
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00008A31 File Offset: 0x00006C31
		protected internal DbConfiguration() : this(new global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration(null, null, null, null, null))
		{
			this._internalConfiguration.Owner = this;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00008A4F File Offset: 0x00006C4F
		internal DbConfiguration(global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration internalConfiguration)
		{
			this._internalConfiguration = internalConfiguration;
			this._internalConfiguration.Owner = this;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00008A6A File Offset: 0x00006C6A
		public static void SetConfiguration(global::System.Data.Entity.DbConfiguration configuration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration.Instance = configuration.InternalConfiguration;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00008A83 File Offset: 0x00006C83
		public static void LoadConfiguration(global::System.Type contextType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType");
			if (!typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(contextType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.BadContextTypeForDiscovery(contextType.Name));
			}
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(contextType);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00008ABF File Offset: 0x00006CBF
		public static void LoadConfiguration(global::System.Reflection.Assembly assemblyHint)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(assemblyHint, "assemblyHint");
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForAssembly(assemblyHint, null);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000252 RID: 594 RVA: 0x00008AD9 File Offset: 0x00006CD9
		// (remove) Token: 0x06000253 RID: 595 RVA: 0x00008AF2 File Offset: 0x00006CF2
		public static event global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs> Loaded
		{
			add
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs>>(value, "value");
				global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.AddLoadedHandler(value);
			}
			remove
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs>>(value, "value");
				global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.RemoveLoadedHandler(value);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00008B0B File Offset: 0x00006D0B
		protected internal void AddDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._internalConfiguration.CheckNotLocked("AddDependencyResolver");
			this._internalConfiguration.AddDependencyResolver(resolver, false);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00008B36 File Offset: 0x00006D36
		protected internal void AddDefaultResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._internalConfiguration.CheckNotLocked("AddDefaultResolver");
			this._internalConfiguration.AddDefaultResolver(resolver);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00008B60 File Offset: 0x00006D60
		public static global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver DependencyResolver
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration.Instance.DependencyResolver;
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00008B6C File Offset: 0x00006D6C
		protected internal void SetProviderServices(string providerInvariantName, global::System.Data.Entity.Core.Common.DbProviderServices provider)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.DbProviderServices>(provider, "provider");
			this._internalConfiguration.CheckNotLocked("SetProviderServices");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Core.Common.DbProviderServices>(provider, providerInvariantName);
			this.AddDefaultResolver(provider);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00008BAC File Offset: 0x00006DAC
		protected internal void SetProviderFactory(string providerInvariantName, global::System.Data.Common.DbProviderFactory providerFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbProviderFactory>(providerFactory, "providerFactory");
			this._internalConfiguration.CheckNotLocked("SetProviderFactory");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Common.DbProviderFactory>(providerFactory, providerInvariantName);
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.InvariantNameResolver(providerFactory, providerInvariantName), false);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00008C01 File Offset: 0x00006E01
		protected internal void SetExecutionStrategy(string providerInvariantName, global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy> getExecutionStrategy)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>>(getExecutionStrategy, "getExecutionStrategy");
			this._internalConfiguration.CheckNotLocked("SetExecutionStrategy");
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.ExecutionStrategyResolver<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>(providerInvariantName, null, getExecutionStrategy), false);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00008C40 File Offset: 0x00006E40
		protected internal void SetExecutionStrategy(string providerInvariantName, global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy> getExecutionStrategy, string serverName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(serverName, "serverName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>>(getExecutionStrategy, "getExecutionStrategy");
			this._internalConfiguration.CheckNotLocked("SetExecutionStrategy");
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.ExecutionStrategyResolver<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>(providerInvariantName, serverName, getExecutionStrategy), false);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00008C95 File Offset: 0x00006E95
		protected internal void SetDefaultTransactionHandler(global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> transactionHandlerFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>>(transactionHandlerFactory, "transactionHandlerFactory");
			this._internalConfiguration.CheckNotLocked("SetTransactionHandler");
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionHandlerResolver(transactionHandlerFactory, null, null), false);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00008CC7 File Offset: 0x00006EC7
		protected internal void SetTransactionHandler(string providerInvariantName, global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> transactionHandlerFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>>(transactionHandlerFactory, "transactionHandlerFactory");
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			this._internalConfiguration.CheckNotLocked("SetTransactionHandler");
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionHandlerResolver(transactionHandlerFactory, providerInvariantName, null), false);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00008D08 File Offset: 0x00006F08
		protected internal void SetTransactionHandler(string providerInvariantName, global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> transactionHandlerFactory, string serverName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>>(transactionHandlerFactory, "transactionHandlerFactory");
			global::System.Data.Entity.Utilities.Check.NotEmpty(serverName, "serverName");
			this._internalConfiguration.CheckNotLocked("SetTransactionHandler");
			this._internalConfiguration.AddDependencyResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionHandlerResolver(transactionHandlerFactory, providerInvariantName, serverName), false);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00008D5D File Offset: 0x00006F5D
		protected internal void SetDefaultConnectionFactory(global::System.Data.Entity.Infrastructure.IDbConnectionFactory connectionFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(connectionFactory, "connectionFactory");
			this._internalConfiguration.CheckNotLocked("SetDefaultConnectionFactory");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(connectionFactory);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00008D87 File Offset: 0x00006F87
		protected internal void SetPluralizationService(global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService pluralizationService)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>(pluralizationService, "pluralizationService");
			this._internalConfiguration.CheckNotLocked("SetPluralizationService");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>(pluralizationService);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00008DB1 File Offset: 0x00006FB1
		protected internal void SetDatabaseInitializer<TContext>(global::System.Data.Entity.IDatabaseInitializer<TContext> initializer) where TContext : global::System.Data.Entity.DbContext
		{
			this._internalConfiguration.CheckNotLocked("SetDatabaseInitializer");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.IDatabaseInitializer<TContext>>(initializer ?? new global::System.Data.Entity.NullDatabaseInitializer<TContext>());
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00008DD8 File Offset: 0x00006FD8
		protected internal void SetMigrationSqlGenerator(string providerInvariantName, global::System.Func<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator> sqlGenerator)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator>>(sqlGenerator, "sqlGenerator");
			this._internalConfiguration.CheckNotLocked("SetMigrationSqlGenerator");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator>>(sqlGenerator, providerInvariantName);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00008E0F File Offset: 0x0000700F
		protected internal void SetManifestTokenResolver(global::System.Data.Entity.Infrastructure.IManifestTokenResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>(resolver, "resolver");
			this._internalConfiguration.CheckNotLocked("SetManifestTokenResolver");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>(resolver);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008E39 File Offset: 0x00007039
		protected internal void SetMetadataAnnotationSerializer(string annotationName, global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer> serializerFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(annotationName, "annotationName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer>>(serializerFactory, "serializerFactory");
			this._internalConfiguration.CheckNotLocked("SetMetadataAnnotationSerializer");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer>>(serializerFactory, annotationName);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00008E70 File Offset: 0x00007070
		protected internal void SetProviderFactoryResolver(global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver providerFactoryResolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver>(providerFactoryResolver, "providerFactoryResolver");
			this._internalConfiguration.CheckNotLocked("SetProviderFactoryResolver");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver>(providerFactoryResolver);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00008E9A File Offset: 0x0000709A
		protected internal void SetModelCacheKey(global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey> keyFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>>(keyFactory, "keyFactory");
			this._internalConfiguration.CheckNotLocked("SetModelCacheKey");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>>(keyFactory);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00008EC4 File Offset: 0x000070C4
		protected internal void SetDefaultHistoryContext(global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> factory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(factory, "factory");
			this._internalConfiguration.CheckNotLocked("SetDefaultHistoryContext");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(factory);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00008EEE File Offset: 0x000070EE
		protected internal void SetHistoryContext(string providerInvariantName, global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> factory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(factory, "factory");
			this._internalConfiguration.CheckNotLocked("SetHistoryContext");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(factory, providerInvariantName);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00008F25 File Offset: 0x00007125
		protected internal void SetDefaultSpatialServices(global::System.Data.Entity.Spatial.DbSpatialServices spatialProvider)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider, "spatialProvider");
			this._internalConfiguration.CheckNotLocked("SetDefaultSpatialServices");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00008F4F File Offset: 0x0000714F
		protected internal void SetSpatialServices(global::System.Data.Entity.Infrastructure.DbProviderInfo key, global::System.Data.Entity.Spatial.DbSpatialServices spatialProvider)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbProviderInfo>(key, "key");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider, "spatialProvider");
			this._internalConfiguration.CheckNotLocked("SetSpatialServices");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider, key);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00008F86 File Offset: 0x00007186
		protected internal void SetSpatialServices(string providerInvariantName, global::System.Data.Entity.Spatial.DbSpatialServices spatialProvider)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider, "spatialProvider");
			this._internalConfiguration.CheckNotLocked("SetSpatialServices");
			this.RegisterSpatialServices(providerInvariantName, spatialProvider);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00008FB8 File Offset: 0x000071B8
		private void RegisterSpatialServices(string providerInvariantName, global::System.Data.Entity.Spatial.DbSpatialServices spatialProvider)
		{
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Spatial.DbSpatialServices>(spatialProvider, delegate(object k)
			{
				global::System.Data.Entity.Infrastructure.DbProviderInfo dbProviderInfo = k as global::System.Data.Entity.Infrastructure.DbProviderInfo;
				return dbProviderInfo != null && dbProviderInfo.ProviderInvariantName == providerInvariantName;
			});
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00008FEA File Offset: 0x000071EA
		protected internal void SetDatabaseLogFormatter(global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter> logFormatterFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter>>(logFormatterFactory, "logFormatterFactory");
			this._internalConfiguration.CheckNotLocked("SetDatabaseLogFormatter");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter>>(logFormatterFactory);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00009014 File Offset: 0x00007214
		protected internal void AddInterceptor(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(interceptor, "interceptor");
			this._internalConfiguration.CheckNotLocked("AddInterceptor");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(interceptor);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00009040 File Offset: 0x00007240
		protected internal void SetContextFactory(global::System.Type contextType, global::System.Func<global::System.Data.Entity.DbContext> factory)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.DbContext>>(factory, "factory");
			if (!typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(contextType))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ContextFactoryContextType(contextType.FullName));
			}
			this._internalConfiguration.CheckNotLocked("SetContextFactory");
			this._internalConfiguration.RegisterSingleton<global::System.Func<global::System.Data.Entity.DbContext>>(factory, contextType);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000090A5 File Offset: 0x000072A5
		protected internal void SetContextFactory<TContext>(global::System.Func<TContext> factory) where TContext : global::System.Data.Entity.DbContext
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TContext>>(factory, "factory");
			this.SetContextFactory(typeof(TContext), factory);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000090C4 File Offset: 0x000072C4
		protected internal void SetModelStore(global::System.Data.Entity.Infrastructure.DbModelStore modelStore)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModelStore>(modelStore, "modelStore");
			this._internalConfiguration.CheckNotLocked("SetModelStore");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.DbModelStore>(modelStore);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000090EE File Offset: 0x000072EE
		protected internal void SetTableExistenceChecker(string providerInvariantName, global::System.Data.Entity.Infrastructure.TableExistenceChecker tableExistenceChecker)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.TableExistenceChecker>(tableExistenceChecker, "tableExistenceChecker");
			this._internalConfiguration.CheckNotLocked("SetTableExistenceChecker");
			this._internalConfiguration.RegisterSingleton<global::System.Data.Entity.Infrastructure.TableExistenceChecker>(tableExistenceChecker, providerInvariantName);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00009125 File Offset: 0x00007325
		internal virtual global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration InternalConfiguration
		{
			get
			{
				return this._internalConfiguration;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000912D File Offset: 0x0000732D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00009135 File Offset: 0x00007335
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000913E File Offset: 0x0000733E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009146 File Offset: 0x00007346
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000914E File Offset: 0x0000734E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x040000AE RID: 174
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration _internalConfiguration;
	}
}
