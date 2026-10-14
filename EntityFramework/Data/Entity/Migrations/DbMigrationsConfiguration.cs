using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Migrations.Design;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.IO;
using System.Reflection;

namespace System.Data.Entity.Migrations
{
	// Token: 0x0200009E RID: 158
	public class DbMigrationsConfiguration
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		public DbMigrationsConfiguration() : this(new global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(() => global::System.Data.Entity.DbConfiguration.DependencyResolver))
		{
			this.CodeGenerator = new global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator();
			this.ContextKey = base.GetType().ToString();
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0001C10B File Offset: 0x0001A30B
		internal DbMigrationsConfiguration(global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver)
		{
			this._resolver = resolver;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0001C146 File Offset: 0x0001A346
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x0001C14E File Offset: 0x0001A34E
		public bool AutomaticMigrationsEnabled { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0001C157 File Offset: 0x0001A357
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x0001C15F File Offset: 0x0001A35F
		public string ContextKey
		{
			get
			{
				return this._contextKey;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				this._contextKey = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0001C174 File Offset: 0x0001A374
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0001C17C File Offset: 0x0001A37C
		public bool AutomaticMigrationDataLossAllowed { get; set; }

		// Token: 0x06000E65 RID: 3685 RVA: 0x0001C185 File Offset: 0x0001A385
		public void SetSqlGenerator(string providerInvariantName, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator migrationSqlGenerator)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator>(migrationSqlGenerator, "migrationSqlGenerator");
			this._sqlGenerators[providerInvariantName] = migrationSqlGenerator;
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		public global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator GetSqlGenerator(string providerInvariantName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator result;
			if (!this._sqlGenerators.TryGetValue(providerInvariantName, out result))
			{
				global::System.Func<global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator> service = this._resolver.Value.GetService(providerInvariantName);
				if (service == null)
				{
					throw global::System.Data.Entity.Resources.Error.NoSqlGeneratorForProvider(providerInvariantName);
				}
				result = service();
			}
			return result;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0001C1F7 File Offset: 0x0001A3F7
		public void SetHistoryContextFactory(string providerInvariantName, global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> factory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>(factory, "factory");
			this._historyContextFactories[providerInvariantName] = factory;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0001C220 File Offset: 0x0001A420
		public global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> GetHistoryContextFactory(string providerInvariantName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext> result;
			if (!this._historyContextFactories.TryGetValue(providerInvariantName, out result))
			{
				return this._resolver.Value.GetService(providerInvariantName) ?? this._resolver.Value.GetService<global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>();
			}
			return result;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0001C270 File Offset: 0x0001A470
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0001C278 File Offset: 0x0001A478
		public global::System.Type ContextType
		{
			get
			{
				return this._contextType;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(value, "value");
				if (!typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(value))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbMigrationsConfiguration_ContextType(value.Name));
				}
				this._contextType = value;
				global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(this._contextType);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0001C2CB File Offset: 0x0001A4CB
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x0001C2D3 File Offset: 0x0001A4D3
		public string MigrationsNamespace { get; set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		public string MigrationsDirectory
		{
			get
			{
				return this._migrationsDirectory;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				if (global::System.IO.Path.IsPathRooted(value))
				{
					throw new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.DbMigrationsConfiguration_RootedPath(value));
				}
				this._migrationsDirectory = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0001C30D File Offset: 0x0001A50D
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x0001C315 File Offset: 0x0001A515
		public global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator CodeGenerator
		{
			get
			{
				return this._codeGenerator;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator>(value, "value");
				this._codeGenerator = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x0001C32A File Offset: 0x0001A52A
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x0001C332 File Offset: 0x0001A532
		public global::System.Reflection.Assembly MigrationsAssembly
		{
			get
			{
				return this._migrationsAssembly;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.Assembly>(value, "value");
				this._migrationsAssembly = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0001C347 File Offset: 0x0001A547
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x0001C34F File Offset: 0x0001A54F
		public global::System.Data.Entity.Infrastructure.DbConnectionInfo TargetDatabase
		{
			get
			{
				return this._connectionInfo;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbConnectionInfo>(value, "value");
				this._connectionInfo = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0001C364 File Offset: 0x0001A564
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x0001C36C File Offset: 0x0001A56C
		public int? CommandTimeout
		{
			get
			{
				return this._commandTimeout;
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
				this._commandTimeout = value;
			}
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		internal virtual void OnSeed(global::System.Data.Entity.DbContext context)
		{
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0001C3AE File Offset: 0x0001A5AE
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x0001C3B6 File Offset: 0x0001A5B6
		internal global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer ModelDiffer
		{
			get
			{
				return this._modelDiffer;
			}
			set
			{
				this._modelDiffer = value;
			}
		}

		// Token: 0x0400080B RID: 2059
		public const string DefaultMigrationsDirectory = "Migrations";

		// Token: 0x0400080C RID: 2060
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator> _sqlGenerators = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator>();

		// Token: 0x0400080D RID: 2061
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>> _historyContextFactories = new global::System.Collections.Generic.Dictionary<string, global::System.Func<global::System.Data.Common.DbConnection, string, global::System.Data.Entity.Migrations.History.HistoryContext>>();

		// Token: 0x0400080E RID: 2062
		private global::System.Data.Entity.Migrations.Design.MigrationCodeGenerator _codeGenerator;

		// Token: 0x0400080F RID: 2063
		private global::System.Type _contextType;

		// Token: 0x04000810 RID: 2064
		private global::System.Reflection.Assembly _migrationsAssembly;

		// Token: 0x04000811 RID: 2065
		private global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer _modelDiffer = new global::System.Data.Entity.Migrations.Infrastructure.EdmModelDiffer();

		// Token: 0x04000812 RID: 2066
		private global::System.Data.Entity.Infrastructure.DbConnectionInfo _connectionInfo;

		// Token: 0x04000813 RID: 2067
		private string _migrationsDirectory = "Migrations";

		// Token: 0x04000814 RID: 2068
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> _resolver;

		// Token: 0x04000815 RID: 2069
		private string _contextKey;

		// Token: 0x04000816 RID: 2070
		private int? _commandTimeout;
	}
}
