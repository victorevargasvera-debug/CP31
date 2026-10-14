using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Migrations.Design;
using System.Data.Entity.Migrations.Edm;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Resources;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations
{
	// Token: 0x020000A0 RID: 160
	public class DbMigrator : global::System.Data.Entity.Migrations.Infrastructure.MigratorBase
	{
		// Token: 0x06000E83 RID: 3715 RVA: 0x0001C454 File Offset: 0x0001A654
		internal DbMigrator(global::System.Data.Entity.DbContext usersContext = null, global::System.Data.Common.DbProviderFactory providerFactory = null, global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly migrationAssembly = null) : base(null)
		{
			this._usersContext = usersContext;
			this._providerFactory = providerFactory;
			this._migrationAssembly = migrationAssembly;
			this._usersContextInfo = new global::System.Data.Entity.Infrastructure.DbContextInfo(typeof(global::System.Data.Entity.DbContext));
			this._configuration = new global::System.Data.Entity.Migrations.DbMigrationsConfiguration();
			this._calledByCreateDatabase = true;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0001C4A4 File Offset: 0x0001A6A4
		public DbMigrator(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration) : this(configuration, null, global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown, false)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.DbMigrationsConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(configuration.ContextType, "configuration.ContextType");
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0001C4CD File Offset: 0x0001A6CD
		public DbMigrator(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration, global::System.Data.Entity.DbContext context) : this(configuration, context, global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown, false)
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0001C4DC File Offset: 0x0001A6DC
		internal DbMigrator(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration, global::System.Data.Entity.DbContext usersContext, global::System.Data.Entity.Internal.DatabaseExistenceState existenceState, bool calledByCreateDatabase) : base(null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.DbMigrationsConfiguration>(configuration, "configuration");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(configuration.ContextType, "configuration.ContextType");
			this._configuration = configuration;
			this._calledByCreateDatabase = calledByCreateDatabase;
			this._existenceState = existenceState;
			if (usersContext != null)
			{
				this._usersContextInfo = new global::System.Data.Entity.Infrastructure.DbContextInfo(usersContext, null);
			}
			else
			{
				this._usersContextInfo = ((configuration.TargetDatabase == null) ? new global::System.Data.Entity.Infrastructure.DbContextInfo(configuration.ContextType) : new global::System.Data.Entity.Infrastructure.DbContextInfo(configuration.ContextType, configuration.TargetDatabase));
				if (!this._usersContextInfo.IsConstructible)
				{
					throw global::System.Data.Entity.Resources.Error.ContextNotConstructible(configuration.ContextType);
				}
			}
			this._modelDiffer = this._configuration.ModelDiffer;
			global::System.Data.Entity.DbContext dbContext = usersContext ?? this._usersContextInfo.CreateInstance();
			this._usersContext = dbContext;
			try
			{
				this._migrationAssembly = new global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly(this._configuration.MigrationsAssembly, this._configuration.MigrationsNamespace);
				this._currentModel = dbContext.GetModel();
				this._connection = dbContext.Database.Connection;
				this._providerFactory = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(this._connection);
				this._defaultSchema = (dbContext.InternalContext.DefaultSchema ?? "dbo");
				this._historyContextFactory = this._configuration.GetHistoryContextFactory(this._usersContextInfo.ConnectionProviderName);
				this._historyRepository = new global::System.Data.Entity.Migrations.History.HistoryRepository(dbContext.InternalContext, this._usersContextInfo.ConnectionString, this._providerFactory, this._configuration.ContextKey, this._configuration.CommandTimeout, this._historyContextFactory, new string[]
				{
					this._defaultSchema
				}.Concat(this.GetHistorySchemas()), this._usersContext, this._existenceState, (global::System.Exception e) => this.SqlGenerator.IsPermissionDeniedError(e));
				this._providerManifestToken = ((dbContext.InternalContext.ModelProviderInfo != null) ? dbContext.InternalContext.ModelProviderInfo.ProviderManifestToken : global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>().ResolveManifestToken(this._connection));
				global::System.Data.Entity.DbModelBuilder modelBuilder = dbContext.InternalContext.CodeFirstModel.CachedModelBuilder;
				this._modificationCommandTreeGenerator = new global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator>(() => new global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator(modelBuilder.BuildDynamicUpdateModel(new global::System.Data.Entity.Infrastructure.DbProviderInfo(this._usersContextInfo.ConnectionProviderName, this._providerManifestToken)), this.CreateConnection()));
				global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
				dbInterceptionContext = dbInterceptionContext.WithDbContext(this._usersContext);
				this._targetDatabase = global::System.Data.Entity.Resources.Strings.LoggingTargetDatabaseFormat(global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(this._connection, dbInterceptionContext), global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDatabase(this._connection, dbInterceptionContext), this._usersContextInfo.ConnectionProviderName, (this._usersContextInfo.ConnectionStringOrigin == global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.DbContextInfo) ? global::System.Data.Entity.Resources.Strings.LoggingExplicit : this._usersContextInfo.ConnectionStringOrigin.ToString());
				this._legacyContextKey = dbContext.InternalContext.DefaultContextKey;
				this._emptyModel = this.GetEmptyModel();
			}
			finally
			{
				if (usersContext == null)
				{
					this._usersContext = null;
					this._connection = null;
					dbContext.Dispose();
				}
			}
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		private global::System.Lazy<global::System.Xml.Linq.XDocument> GetEmptyModel()
		{
			return new global::System.Lazy<global::System.Xml.Linq.XDocument>(() => new global::System.Data.Entity.DbModelBuilder().Build(new global::System.Data.Entity.Infrastructure.DbProviderInfo(this._usersContextInfo.ConnectionProviderName, this._providerManifestToken)).GetModel());
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
		private global::System.Xml.Linq.XDocument GetHistoryModel(string defaultSchema)
		{
			global::System.Data.Common.DbConnection dbConnection = null;
			global::System.Xml.Linq.XDocument model;
			try
			{
				dbConnection = this.CreateConnection();
				using (global::System.Data.Entity.Migrations.History.HistoryContext historyContext = this._historyContextFactory(dbConnection, defaultSchema))
				{
					model = historyContext.GetModel();
				}
			}
			finally
			{
				if (dbConnection != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
				}
			}
			return model;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0001C868 File Offset: 0x0001AA68
		private global::System.Collections.Generic.IEnumerable<string> GetHistorySchemas()
		{
			return from migrationId in this._migrationAssembly.MigrationIds
			let migration = this._migrationAssembly.GetMigration(migrationId)
			select global::System.Data.Entity.Migrations.DbMigrator.GetDefaultSchema(migration);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0001C8B5 File Offset: 0x0001AAB5
		public override global::System.Data.Entity.Migrations.DbMigrationsConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0001C8BD File Offset: 0x0001AABD
		internal override string TargetDatabase
		{
			get
			{
				return this._targetDatabase;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0001C8C8 File Offset: 0x0001AAC8
		private global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator SqlGenerator
		{
			get
			{
				global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator result;
				if ((result = this._sqlGenerator) == null)
				{
					result = (this._sqlGenerator = this._configuration.GetSqlGenerator(this._usersContextInfo.ConnectionProviderName));
				}
				return result;
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0001C8FE File Offset: 0x0001AAFE
		public override global::System.Collections.Generic.IEnumerable<string> GetLocalMigrations()
		{
			return this._migrationAssembly.MigrationIds;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0001C90B File Offset: 0x0001AB0B
		public override global::System.Collections.Generic.IEnumerable<string> GetDatabaseMigrations()
		{
			return this._historyRepository.GetMigrationsSince("0");
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0001C91D File Offset: 0x0001AB1D
		public override global::System.Collections.Generic.IEnumerable<string> GetPendingMigrations()
		{
			return this._historyRepository.GetPendingMigrations(this._migrationAssembly.MigrationIds);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0001C938 File Offset: 0x0001AB38
		internal global::System.Data.Entity.Migrations.Design.ScaffoldedMigration ScaffoldInitialCreate(string @namespace)
		{
			string migrationId;
			string text;
			global::System.Xml.Linq.XDocument lastModel = this._historyRepository.GetLastModel(out migrationId, out text, this._legacyContextKey);
			if (lastModel == null || !migrationId.MigrationName().Equals(global::System.Data.Entity.Resources.Strings.InitialCreate))
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations = this._modelDiffer.Diff(this._emptyModel.Value, lastModel, this._modificationCommandTreeGenerator, this.SqlGenerator, null, null).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			global::System.Data.Entity.Migrations.Design.ScaffoldedMigration scaffoldedMigration = this._configuration.CodeGenerator.Generate(migrationId, operations, null, global::System.Convert.ToBase64String(new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Compress(this._currentModel)), @namespace, global::System.Data.Entity.Resources.Strings.InitialCreate);
			scaffoldedMigration.MigrationId = migrationId;
			scaffoldedMigration.Directory = this._configuration.MigrationsDirectory;
			scaffoldedMigration.Resources.Add("DefaultSchema", this._defaultSchema);
			return scaffoldedMigration;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0001C9FC File Offset: 0x0001ABFC
		internal global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(string migrationName, string @namespace, bool ignoreChanges)
		{
			global::System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass40_0 CS$<>8__locals1 = new global::System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass40_0();
			CS$<>8__locals1.<>4__this = this;
			string migrationId = null;
			bool flag = false;
			global::System.Collections.Generic.List<string> list = this.GetPendingMigrations().ToList<string>();
			if (list.Any<string>())
			{
				string text = list.Last<string>();
				if (!text.EqualsIgnoreCase(migrationName) && !text.MigrationName().EqualsIgnoreCase(migrationName))
				{
					throw global::System.Data.Entity.Resources.Error.MigrationsPendingException(list.Join(null, ", "));
				}
				flag = true;
				migrationId = text;
				migrationName = text.MigrationName();
			}
			CS$<>8__locals1.sourceModel = null;
			this.CheckLegacyCompatibility(delegate
			{
				CS$<>8__locals1.sourceModel = CS$<>8__locals1.<>4__this._currentModel;
			});
			string migrationId2 = null;
			string sourceModelVersion = null;
			global::System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass40_0 CS$<>8__locals2 = CS$<>8__locals1;
			global::System.Xml.Linq.XDocument sourceModel;
			if ((sourceModel = CS$<>8__locals1.sourceModel) == null)
			{
				sourceModel = (this._historyRepository.GetLastModel(out migrationId2, out sourceModelVersion, null) ?? this._emptyModel.Value);
			}
			CS$<>8__locals2.sourceModel = sourceModel;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> enumerable2;
			if (!ignoreChanges)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> enumerable = this._modelDiffer.Diff(CS$<>8__locals1.sourceModel, this._currentModel, this._modificationCommandTreeGenerator, this.SqlGenerator, sourceModelVersion, null).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
				enumerable2 = enumerable;
			}
			else
			{
				enumerable2 = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations = enumerable2;
			if (!flag)
			{
				migrationName = this._migrationAssembly.UniquifyName(migrationName);
				migrationId = global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly.CreateMigrationId(migrationName);
			}
			global::System.Data.Entity.Migrations.Edm.ModelCompressor modelCompressor = new global::System.Data.Entity.Migrations.Edm.ModelCompressor();
			global::System.Data.Entity.Migrations.Design.ScaffoldedMigration scaffoldedMigration = this._configuration.CodeGenerator.Generate(migrationId, operations, (CS$<>8__locals1.sourceModel == this._emptyModel.Value || CS$<>8__locals1.sourceModel == this._currentModel || !migrationId2.IsAutomaticMigration()) ? null : global::System.Convert.ToBase64String(modelCompressor.Compress(CS$<>8__locals1.sourceModel)), global::System.Convert.ToBase64String(modelCompressor.Compress(this._currentModel)), @namespace, migrationName);
			scaffoldedMigration.MigrationId = migrationId;
			scaffoldedMigration.Directory = this._configuration.MigrationsDirectory;
			scaffoldedMigration.IsRescaffold = flag;
			scaffoldedMigration.Resources.Add("DefaultSchema", this._defaultSchema);
			return scaffoldedMigration;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
		private void CheckLegacyCompatibility(global::System.Action onCompatible)
		{
			if (!this._calledByCreateDatabase && !this._historyRepository.Exists(null))
			{
				global::System.Data.Entity.DbContext dbContext = this._usersContext ?? this._usersContextInfo.CreateInstance();
				try
				{
					bool flag;
					try
					{
						flag = dbContext.Database.CompatibleWithModel(true);
					}
					catch
					{
						return;
					}
					if (!flag)
					{
						throw global::System.Data.Entity.Resources.Error.MetadataOutOfDate();
					}
					onCompatible();
				}
				finally
				{
					if (this._usersContext == null)
					{
						dbContext.Dispose();
					}
				}
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0001CC3C File Offset: 0x0001AE3C
		public override void Update(string targetMigration)
		{
			base.EnsureDatabaseExists(delegate
			{
				this.UpdateInternal(targetMigration);
			});
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0001CC70 File Offset: 0x0001AE70
		private void UpdateInternal(string targetMigration)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> upgradeOperations = this._historyRepository.GetUpgradeOperations();
			if (upgradeOperations.Any<global::System.Data.Entity.Migrations.Model.MigrationOperation>())
			{
				base.UpgradeHistory(upgradeOperations);
			}
			global::System.Collections.Generic.IEnumerable<string> enumerable = this.GetPendingMigrations();
			if (!enumerable.Any<string>())
			{
				this.CheckLegacyCompatibility(delegate
				{
					this.ExecuteOperations(global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly.CreateBootstrapMigrationId(), new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(this._currentModel, null), global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Model.MigrationOperation>(), this._modelDiffer.Diff(this._emptyModel.Value, this.GetHistoryModel(this._defaultSchema), this._modificationCommandTreeGenerator, this.SqlGenerator, null, null), false, false);
				});
			}
			string targetMigrationId = targetMigration;
			if (!string.IsNullOrWhiteSpace(targetMigrationId))
			{
				if (!targetMigrationId.IsValidMigrationId())
				{
					if (targetMigrationId == global::System.Data.Entity.Resources.Strings.AutomaticMigration)
					{
						throw global::System.Data.Entity.Resources.Error.AutoNotValidTarget(global::System.Data.Entity.Resources.Strings.AutomaticMigration);
					}
					targetMigrationId = this.GetMigrationId(targetMigration);
				}
				if (enumerable.Any((string m) => m.EqualsIgnoreCase(targetMigrationId)))
				{
					enumerable = from m in enumerable
					where string.CompareOrdinal(m.ToLowerInvariant(), targetMigrationId.ToLowerInvariant()) <= 0
					select m;
				}
				else
				{
					enumerable = this._historyRepository.GetMigrationsSince(targetMigrationId);
					if (enumerable.Any<string>())
					{
						base.Downgrade(enumerable.Concat(new string[]
						{
							targetMigrationId
						}));
						return;
					}
				}
			}
			base.Upgrade(enumerable, targetMigrationId, null);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0001CD84 File Offset: 0x0001AF84
		internal override void UpgradeHistory(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> upgradeOperations)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements = this.SqlGenerator.Generate(upgradeOperations, this._providerManifestToken);
			base.ExecuteStatements(migrationStatements);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0001CDAC File Offset: 0x0001AFAC
		internal override string GetMigrationId(string migration)
		{
			if (migration.IsValidMigrationId())
			{
				return migration;
			}
			string text = this.GetPendingMigrations().SingleOrDefault((string m) => m.MigrationName().EqualsIgnoreCase(migration)) ?? this._historyRepository.GetMigrationId(migration);
			if (text == null)
			{
				throw global::System.Data.Entity.Resources.Error.MigrationNotFound(migration);
			}
			return text;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0001CE18 File Offset: 0x0001B018
		internal override void Upgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations, string targetMigrationId, string lastMigrationId)
		{
			global::System.Data.Entity.Migrations.DbMigration lastMigration = null;
			if (lastMigrationId != null)
			{
				lastMigration = this._migrationAssembly.GetMigration(lastMigrationId);
			}
			foreach (string text in pendingMigrations)
			{
				global::System.Data.Entity.Migrations.DbMigration migration = this._migrationAssembly.GetMigration(text);
				base.ApplyMigration(migration, lastMigration);
				lastMigration = migration;
				this._emptyMigrationNeeded = false;
				if (text.EqualsIgnoreCase(targetMigrationId))
				{
					break;
				}
			}
			if (string.IsNullOrWhiteSpace(targetMigrationId) && ((this._emptyMigrationNeeded && this._configuration.AutomaticMigrationsEnabled) || this.IsModelOutOfDate(this._currentModel, lastMigration)))
			{
				if (!this._configuration.AutomaticMigrationsEnabled)
				{
					throw global::System.Data.Entity.Resources.Error.AutomaticDisabledException();
				}
				base.AutoMigrate(global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly.CreateMigrationId(this._calledByCreateDatabase ? global::System.Data.Entity.Resources.Strings.InitialCreate : global::System.Data.Entity.Resources.Strings.AutomaticMigration), this._calledByCreateDatabase ? new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(this._emptyModel.Value, null) : this.GetLastModel(lastMigration, null), new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(this._currentModel, null), false);
			}
			if (!this._calledByCreateDatabase && !this.IsModelOutOfDate(this._currentModel, lastMigration))
			{
				base.SeedDatabase();
			}
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0001CF44 File Offset: 0x0001B144
		internal override void SeedDatabase()
		{
			global::System.Data.Entity.DbContext dbContext = this._usersContext ?? this._usersContextInfo.CreateInstance();
			if (this._usersContext != null)
			{
				dbContext.InternalContext.UseTempObjectContext();
			}
			try
			{
				this._configuration.OnSeed(dbContext);
				dbContext.SaveChanges();
			}
			finally
			{
				if (this._usersContext == null)
				{
					dbContext.Dispose();
				}
				else
				{
					dbContext.InternalContext.DisposeTempObjectContext();
				}
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		internal virtual bool IsModelOutOfDate(global::System.Xml.Linq.XDocument model, global::System.Data.Entity.Migrations.DbMigration lastMigration)
		{
			global::System.Data.Entity.Migrations.Infrastructure.VersionedModel lastModel = this.GetLastModel(lastMigration, null);
			return this._modelDiffer.Diff(lastModel.Model, model, null, null, lastModel.Version, null).Any<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0001CFF4 File Offset: 0x0001B1F4
		private global::System.Data.Entity.Migrations.Infrastructure.VersionedModel GetLastModel(global::System.Data.Entity.Migrations.DbMigration lastMigration, string currentMigrationId = null)
		{
			if (lastMigration != null)
			{
				return lastMigration.GetTargetModel();
			}
			string strA;
			string version;
			global::System.Xml.Linq.XDocument lastModel = this._historyRepository.GetLastModel(out strA, out version, null);
			if (lastModel != null && (currentMigrationId == null || string.CompareOrdinal(strA, currentMigrationId) < 0))
			{
				return new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(lastModel, version);
			}
			return new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(this._emptyModel.Value, null);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0001D048 File Offset: 0x0001B248
		internal override void Downgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations)
		{
			for (int i = 0; i < pendingMigrations.Count<string>() - 1; i++)
			{
				string migrationId = pendingMigrations.ElementAt(i);
				global::System.Data.Entity.Migrations.DbMigration migration = this._migrationAssembly.GetMigration(migrationId);
				string text = pendingMigrations.ElementAt(i + 1);
				string version = null;
				global::System.Xml.Linq.XDocument xdocument = (text != "0") ? this._historyRepository.GetModel(text, out version) : this._emptyModel.Value;
				string text2;
				global::System.Xml.Linq.XDocument model = this._historyRepository.GetModel(migrationId, out text2);
				if (migration == null)
				{
					base.AutoMigrate(migrationId, new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(model, null), new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(xdocument, version), true);
				}
				else
				{
					base.RevertMigration(migrationId, migration, xdocument);
				}
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0001D0F4 File Offset: 0x0001B2F4
		internal override void RevertMigration(string migrationId, global::System.Data.Entity.Migrations.DbMigration migration, global::System.Xml.Linq.XDocument targetModel)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> systemOperations = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			string defaultSchema = global::System.Data.Entity.Migrations.DbMigrator.GetDefaultSchema(migration);
			global::System.Xml.Linq.XDocument historyModel = this.GetHistoryModel(defaultSchema);
			if (targetModel == this._emptyModel.Value && !this._historyRepository.IsShared())
			{
				systemOperations = this._modelDiffer.Diff(historyModel, this._emptyModel.Value, null, null, null, null);
			}
			else
			{
				string lastDefaultSchema = this.GetLastDefaultSchema(migrationId);
				if (!string.Equals(lastDefaultSchema, defaultSchema, global::System.StringComparison.Ordinal))
				{
					global::System.Xml.Linq.XDocument historyModel2 = this.GetHistoryModel(lastDefaultSchema);
					systemOperations = this._modelDiffer.Diff(historyModel, historyModel2, null, null, null, null);
				}
			}
			migration.Down();
			this.ExecuteOperations(migrationId, new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(targetModel, null), migration.Operations, systemOperations, true, false);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0001D19C File Offset: 0x0001B39C
		internal override void ApplyMigration(global::System.Data.Entity.Migrations.DbMigration migration, global::System.Data.Entity.Migrations.DbMigration lastMigration)
		{
			global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata migrationMetadata = (global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata)migration;
			global::System.Data.Entity.Migrations.Infrastructure.VersionedModel versionedModel = this.GetLastModel(lastMigration, migrationMetadata.Id);
			global::System.Data.Entity.Migrations.Infrastructure.VersionedModel sourceModel = migration.GetSourceModel();
			global::System.Data.Entity.Migrations.Infrastructure.VersionedModel targetModel = migration.GetTargetModel();
			if (sourceModel != null && this.IsModelOutOfDate(sourceModel.Model, lastMigration))
			{
				base.AutoMigrate(migrationMetadata.Id.ToAutomaticMigrationId(), versionedModel, sourceModel, false);
				versionedModel = sourceModel;
			}
			string defaultSchema = global::System.Data.Entity.Migrations.DbMigrator.GetDefaultSchema(migration);
			global::System.Xml.Linq.XDocument historyModel = this.GetHistoryModel(defaultSchema);
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> systemOperations = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			if (versionedModel.Model == this._emptyModel.Value && !base.HistoryExists())
			{
				systemOperations = this._modelDiffer.Diff(this._emptyModel.Value, historyModel, null, null, null, null);
			}
			else
			{
				string lastDefaultSchema = this.GetLastDefaultSchema(migrationMetadata.Id);
				if (!string.Equals(lastDefaultSchema, defaultSchema, global::System.StringComparison.Ordinal))
				{
					global::System.Xml.Linq.XDocument historyModel2 = this.GetHistoryModel(lastDefaultSchema);
					systemOperations = this._modelDiffer.Diff(historyModel2, historyModel, null, null, null, null);
				}
			}
			migration.Up();
			this.ExecuteOperations(migrationMetadata.Id, targetModel, migration.Operations, systemOperations, false, false);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		private static string GetDefaultSchema(global::System.Data.Entity.Migrations.DbMigration migration)
		{
			string result;
			try
			{
				string @string = new global::System.Resources.ResourceManager(migration.GetType()).GetString("DefaultSchema");
				result = ((!string.IsNullOrWhiteSpace(@string)) ? @string : "dbo");
			}
			catch (global::System.Resources.MissingManifestResourceException)
			{
				result = "dbo";
			}
			return result;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0001D2F0 File Offset: 0x0001B4F0
		private string GetLastDefaultSchema(string migrationId)
		{
			string text = this._migrationAssembly.MigrationIds.LastOrDefault((string m) => string.CompareOrdinal(m, migrationId) < 0);
			if (text != null)
			{
				return global::System.Data.Entity.Migrations.DbMigrator.GetDefaultSchema(this._migrationAssembly.GetMigration(text));
			}
			return "dbo";
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0001D341 File Offset: 0x0001B541
		internal override bool HistoryExists()
		{
			return this._historyRepository.Exists(null);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0001D350 File Offset: 0x0001B550
		internal override void AutoMigrate(string migrationId, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel sourceModel, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel targetModel, bool downgrading)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> systemOperations = global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			if (!this._historyRepository.IsShared())
			{
				if (targetModel.Model == this._emptyModel.Value)
				{
					systemOperations = this._modelDiffer.Diff(this.GetHistoryModel("dbo"), this._emptyModel.Value, null, null, null, null);
				}
				else if (sourceModel.Model == this._emptyModel.Value)
				{
					systemOperations = this._modelDiffer.Diff(this._emptyModel.Value, this._calledByCreateDatabase ? this.GetHistoryModel(this._defaultSchema) : this.GetHistoryModel("dbo"), null, null, null, null);
				}
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation> list = this._modelDiffer.Diff(sourceModel.Model, targetModel.Model, (targetModel.Model == this._currentModel) ? this._modificationCommandTreeGenerator : null, this.SqlGenerator, sourceModel.Version, targetModel.Version).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			if (!this._calledByCreateDatabase && targetModel.Model == this._currentModel && !string.Equals(this.GetLastDefaultSchema(migrationId), this._defaultSchema, global::System.StringComparison.Ordinal))
			{
				throw global::System.Data.Entity.Resources.Error.UnableToMoveHistoryTableWithAuto();
			}
			if (!this._configuration.AutomaticMigrationDataLossAllowed)
			{
				if (list.Any((global::System.Data.Entity.Migrations.Model.MigrationOperation o) => o.IsDestructiveChange))
				{
					throw global::System.Data.Entity.Resources.Error.AutomaticDataLoss();
				}
			}
			if (targetModel.Model != this._currentModel)
			{
				if (list.Any((global::System.Data.Entity.Migrations.Model.MigrationOperation o) => o is global::System.Data.Entity.Migrations.Model.ProcedureOperation))
				{
					throw global::System.Data.Entity.Resources.Error.AutomaticStaleFunctions(migrationId);
				}
			}
			this.ExecuteOperations(migrationId, targetModel, list, systemOperations, downgrading, true);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		private void ExecuteOperations(string migrationId, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel targetModel, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> systemOperations, bool downgrading, bool auto = false)
		{
			this.FillInForeignKeyOperations(operations, targetModel.Model);
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation> second = (from ct in operations.OfType<global::System.Data.Entity.Migrations.Model.CreateTableOperation>()
			from afk in operations.OfType<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>()
			where ct.Name.EqualsIgnoreCase(afk.DependentTable)
			select afk).ToList<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation> list = operations.Except(second).Concat(second).Concat(systemOperations).ToList<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
			global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = systemOperations.OfType<global::System.Data.Entity.Migrations.Model.CreateTableOperation>().FirstOrDefault<global::System.Data.Entity.Migrations.Model.CreateTableOperation>();
			if (createTableOperation != null)
			{
				this._historyRepository.CurrentSchema = global::System.Data.Entity.Utilities.DatabaseName.Parse(createTableOperation.Name).Schema;
			}
			global::System.Data.Entity.Migrations.Model.MoveTableOperation moveTableOperation = systemOperations.OfType<global::System.Data.Entity.Migrations.Model.MoveTableOperation>().FirstOrDefault<global::System.Data.Entity.Migrations.Model.MoveTableOperation>();
			if (moveTableOperation != null)
			{
				this._historyRepository.CurrentSchema = moveTableOperation.NewSchema;
				moveTableOperation.ContextKey = this._configuration.ContextKey;
				moveTableOperation.IsSystem = true;
			}
			if (!downgrading)
			{
				list.Add(this._historyRepository.CreateInsertOperation(migrationId, targetModel));
			}
			else if (!systemOperations.Any((global::System.Data.Entity.Migrations.Model.MigrationOperation o) => o is global::System.Data.Entity.Migrations.Model.DropTableOperation))
			{
				list.Add(this._historyRepository.CreateDeleteOperation(migrationId));
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> enumerable = base.GenerateStatements(list, migrationId);
			if (auto)
			{
				enumerable = enumerable.Distinct((global::System.Data.Entity.Migrations.Sql.MigrationStatement m1, global::System.Data.Entity.Migrations.Sql.MigrationStatement m2) => string.Equals(m1.Sql, m2.Sql, global::System.StringComparison.Ordinal));
			}
			base.ExecuteStatements(enumerable);
			this._historyRepository.ResetExists();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0001D6D1 File Offset: 0x0001B8D1
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> CreateDiscoveryQueryTrees()
		{
			return this._historyRepository.CreateDiscoveryQueryTrees();
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0001D6DE File Offset: 0x0001B8DE
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> GenerateStatements(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string migrationId)
		{
			return this.SqlGenerator.Generate(operations, this._providerManifestToken);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0001D6F2 File Offset: 0x0001B8F2
		internal override void ExecuteStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements)
		{
			this.ExecuteStatements(migrationStatements, null);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0001D6FC File Offset: 0x0001B8FC
		internal void ExecuteStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbTransaction existingTransaction)
		{
			global::System.Data.Common.DbConnection connection = null;
			try
			{
				if (existingTransaction != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
					dbInterceptionContext = dbInterceptionContext.WithDbContext(this._usersContext);
					this.ExecuteStatementsWithinTransaction(migrationStatements, existingTransaction, dbInterceptionContext);
				}
				else
				{
					connection = this.CreateConnection();
					global::System.Data.Entity.Core.Common.DbProviderServices.GetExecutionStrategy(connection).Execute(delegate()
					{
						this.ExecuteStatementsInternal(migrationStatements, connection);
					});
				}
			}
			finally
			{
				if (connection != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
				}
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		private void ExecuteStatementsInternal(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.DbContext dbContext = this._usersContext ?? this._usersContextInfo.CreateInstance();
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext dbInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
			dbInterceptionContext = dbInterceptionContext.WithDbContext(dbContext);
			global::System.Data.Entity.Infrastructure.TransactionHandler transactionHandler = null;
			try
			{
				if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, dbInterceptionContext) == global::System.Data.ConnectionState.Broken)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Close(connection, dbInterceptionContext);
				}
				if (global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetState(connection, dbInterceptionContext) == global::System.Data.ConnectionState.Closed)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Open(connection, dbInterceptionContext);
				}
				if (!(dbContext is global::System.Data.Entity.Infrastructure.TransactionContext))
				{
					string name = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection)).Name;
					string dataSource = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(connection, dbInterceptionContext);
					global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(new global::System.Data.Entity.Infrastructure.ExecutionStrategyKey(name, dataSource));
					if (service != null)
					{
						transactionHandler = service();
						transactionHandler.Initialize(dbContext, connection);
					}
				}
				this.ExecuteStatementsInternal(migrationStatements, connection, dbInterceptionContext);
				this._committedStatements = true;
			}
			finally
			{
				if (transactionHandler != null)
				{
					transactionHandler.Dispose();
				}
				if (this._usersContext == null)
				{
					dbContext.Dispose();
				}
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
		private void ExecuteStatementsInternal(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			foreach (global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement in migrationStatements)
			{
				base.ExecuteSql(migrationStatement, connection, transaction, interceptionContext);
			}
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0001D904 File Offset: 0x0001BB04
		private void ExecuteStatementsInternal(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement>();
			foreach (global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement in from s in migrationStatements
			where !string.IsNullOrEmpty(s.Sql)
			select s)
			{
				if (!migrationStatement.SuppressTransaction)
				{
					list.Add(migrationStatement);
				}
				else
				{
					if (list.Any<global::System.Data.Entity.Migrations.Sql.MigrationStatement>())
					{
						this.ExecuteStatementsWithinNewTransaction(list, connection, interceptionContext);
						list.Clear();
					}
					base.ExecuteSql(migrationStatement, connection, null, interceptionContext);
				}
			}
			if (list.Any<global::System.Data.Entity.Migrations.Sql.MigrationStatement>())
			{
				this.ExecuteStatementsWithinNewTransaction(list, connection, interceptionContext);
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		private void ExecuteStatementsWithinTransaction(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Common.DbConnection connection = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.GetConnection(transaction, interceptionContext);
			this.ExecuteStatementsInternal(migrationStatements, connection, transaction, interceptionContext);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0001D9E0 File Offset: 0x0001BBE0
		private void ExecuteStatementsWithinNewTransaction(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Data.Common.DbConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext interceptionContext2 = new global::System.Data.Entity.Infrastructure.Interception.BeginTransactionInterceptionContext(interceptionContext).WithIsolationLevel(global::System.Data.IsolationLevel.Serializable);
			global::System.Data.Common.DbTransaction dbTransaction = null;
			try
			{
				dbTransaction = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.BeginTransaction(connection, interceptionContext2);
				this.ExecuteStatementsWithinTransaction(migrationStatements, dbTransaction, interceptionContext);
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.Commit(dbTransaction, interceptionContext);
			}
			finally
			{
				if (dbTransaction != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Transaction.Dispose(dbTransaction, interceptionContext);
				}
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0001DA54 File Offset: 0x0001BC54
		internal override void ExecuteSql(global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement, global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			if (string.IsNullOrWhiteSpace(migrationStatement.Sql))
			{
				return;
			}
			global::System.Data.Common.DbCommand command = connection.CreateCommand();
			using (global::System.Data.Entity.Internal.InterceptableDbCommand interceptableDbCommand = this.ConfigureCommand(command, migrationStatement.Sql, interceptionContext))
			{
				if (transaction != null)
				{
					interceptableDbCommand.Transaction = transaction;
				}
				interceptableDbCommand.ExecuteNonQuery();
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		private global::System.Data.Entity.Internal.InterceptableDbCommand ConfigureCommand(global::System.Data.Common.DbCommand command, string commandText, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			command.CommandText = commandText;
			if (this._configuration.CommandTimeout != null)
			{
				command.CommandTimeout = this._configuration.CommandTimeout.Value;
			}
			return new global::System.Data.Entity.Internal.InterceptableDbCommand(command, interceptionContext, null);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0001DB00 File Offset: 0x0001BD00
		private void FillInForeignKeyOperations(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, global::System.Xml.Linq.XDocument targetModel)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation> enumerator = (from fk in operations.OfType<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>()
			where fk.PrincipalTable != null && !fk.PrincipalColumns.Any<string>()
			select fk).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass69_0 CS$<>8__locals1 = new global::System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass69_0();
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.foreignKeyOperation = enumerator.Current;
					string principalTable = this.GetStandardizedTableName(CS$<>8__locals1.foreignKeyOperation.PrincipalTable);
					string entitySetName = (from es in targetModel.Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.EntitySetNames)
					where new global::System.Data.Entity.Utilities.DatabaseName(es.TableAttribute(), es.SchemaAttribute()).ToString().EqualsIgnoreCase(principalTable)
					select es.NameAttribute()).SingleOrDefault<string>();
					if (entitySetName != null)
					{
						targetModel.Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.EntityTypeNames).Single((global::System.Xml.Linq.XElement et) => et.NameAttribute().EqualsIgnoreCase(entitySetName)).Descendants(global::System.Data.Entity.Migrations.Edm.EdmXNames.Ssdl.PropertyRefNames).Each(delegate(global::System.Xml.Linq.XElement pr)
						{
							CS$<>8__locals1.foreignKeyOperation.PrincipalColumns.Add(pr.NameAttribute());
						});
					}
					else
					{
						global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = operations.OfType<global::System.Data.Entity.Migrations.Model.CreateTableOperation>().SingleOrDefault((global::System.Data.Entity.Migrations.Model.CreateTableOperation ct) => CS$<>8__locals1.<>4__this.GetStandardizedTableName(ct.Name).EqualsIgnoreCase(principalTable));
						if (createTableOperation == null || createTableOperation.PrimaryKey == null)
						{
							throw global::System.Data.Entity.Resources.Error.PartialFkOperation(CS$<>8__locals1.foreignKeyOperation.DependentTable, CS$<>8__locals1.foreignKeyOperation.DependentColumns.Join(null, ", "));
						}
						createTableOperation.PrimaryKey.Columns.Each(delegate(string c)
						{
							CS$<>8__locals1.foreignKeyOperation.PrincipalColumns.Add(c);
						});
					}
				}
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
		private string GetStandardizedTableName(string tableName)
		{
			if (!string.IsNullOrWhiteSpace(global::System.Data.Entity.Utilities.DatabaseName.Parse(tableName).Schema))
			{
				return tableName;
			}
			return new global::System.Data.Entity.Utilities.DatabaseName(tableName, this._defaultSchema).ToString();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		internal override void EnsureDatabaseExists(global::System.Action mustSucceedToKeepDatabase)
		{
			bool flag = false;
			global::System.Data.Entity.Migrations.Utilities.DatabaseCreator databaseCreator = new global::System.Data.Entity.Migrations.Utilities.DatabaseCreator(this._configuration.CommandTimeout);
			global::System.Data.Common.DbConnection dbConnection = null;
			try
			{
				dbConnection = this.CreateConnection();
				if (this._existenceState == global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist || (this._existenceState == global::System.Data.Entity.Internal.DatabaseExistenceState.Unknown && !databaseCreator.Exists(dbConnection)))
				{
					databaseCreator.Create(dbConnection);
					flag = true;
				}
			}
			finally
			{
				if (dbConnection != null)
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
				}
			}
			this._emptyMigrationNeeded = flag;
			try
			{
				this._committedStatements = false;
				mustSucceedToKeepDatabase();
			}
			catch
			{
				if (flag && !this._committedStatements)
				{
					global::System.Data.Common.DbConnection dbConnection2 = null;
					try
					{
						dbConnection2 = this.CreateConnection();
						databaseCreator.Delete(dbConnection2);
					}
					catch
					{
					}
					finally
					{
						if (dbConnection2 != null)
						{
							global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(dbConnection2, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext());
						}
					}
				}
				throw;
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		private global::System.Data.Common.DbConnection CreateConnection()
		{
			global::System.Data.Common.DbConnection dbConnection = (this._connection == null) ? this._providerFactory.CreateConnection() : global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(this._connection).CloneDbConnection(this._connection, this._providerFactory);
			global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string> dbConnectionPropertyInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(this._usersContextInfo.ConnectionString);
			if (this._usersContext != null)
			{
				dbConnectionPropertyInterceptionContext = dbConnectionPropertyInterceptionContext.WithDbContext(this._usersContext);
			}
			global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, dbConnectionPropertyInterceptionContext);
			return dbConnection;
		}

		// Token: 0x0400081A RID: 2074
		public const string InitialDatabase = "0";

		// Token: 0x0400081B RID: 2075
		private const string DefaultSchemaResourceKey = "DefaultSchema";

		// Token: 0x0400081C RID: 2076
		private readonly global::System.Lazy<global::System.Xml.Linq.XDocument> _emptyModel;

		// Token: 0x0400081D RID: 2077
		private readonly global::System.Data.Entity.Migrations.DbMigrationsConfiguration _configuration;

		// Token: 0x0400081E RID: 2078
		private readonly global::System.Xml.Linq.XDocument _currentModel;

		// Token: 0x0400081F RID: 2079
		private readonly global::System.Data.Common.DbProviderFactory _providerFactory;

		// Token: 0x04000820 RID: 2080
		private readonly global::System.Data.Entity.Migrations.History.HistoryRepository _historyRepository;

		// Token: 0x04000821 RID: 2081
		private readonly global::System.Data.Entity.Migrations.Infrastructure.MigrationAssembly _migrationAssembly;

		// Token: 0x04000822 RID: 2082
		private readonly global::System.Data.Entity.Infrastructure.DbContextInfo _usersContextInfo;

		// Token: 0x04000823 RID: 2083
		private readonly global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer _modelDiffer;

		// Token: 0x04000824 RID: 2084
		private readonly global::System.Lazy<global::System.Data.Entity.Migrations.Infrastructure.ModificationCommandTreeGenerator> _modificationCommandTreeGenerator;

		// Token: 0x04000825 RID: 2085
		private readonly global::System.Data.Entity.DbContext _usersContext;

		// Token: 0x04000826 RID: 2086
		private readonly global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> _historyContextFactory;

		// Token: 0x04000827 RID: 2087
		private readonly global::System.Data.Common.DbConnection _connection;

		// Token: 0x04000828 RID: 2088
		private readonly bool _calledByCreateDatabase;

		// Token: 0x04000829 RID: 2089
		private readonly global::System.Data.Entity.Internal.DatabaseExistenceState _existenceState;

		// Token: 0x0400082A RID: 2090
		private readonly string _providerManifestToken;

		// Token: 0x0400082B RID: 2091
		private readonly string _targetDatabase;

		// Token: 0x0400082C RID: 2092
		private readonly string _legacyContextKey;

		// Token: 0x0400082D RID: 2093
		private readonly string _defaultSchema;

		// Token: 0x0400082E RID: 2094
		private global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator _sqlGenerator;

		// Token: 0x0400082F RID: 2095
		private bool _emptyMigrationNeeded;

		// Token: 0x04000830 RID: 2096
		private bool _committedStatements;
	}
}
