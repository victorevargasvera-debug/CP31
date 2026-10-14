using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E7 RID: 231
	[global::System.Obsolete("Use System.Data.Entity.Infrastructure.Design.Executor instead.")]
	public class ToolingFacade : global::System.IDisposable
	{
		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00029C7E File Offset: 0x00027E7E
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00029C86 File Offset: 0x00027E86
		public global::System.Action<string> LogInfoDelegate { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00029C8F File Offset: 0x00027E8F
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00029C97 File Offset: 0x00027E97
		public global::System.Action<string> LogWarningDelegate { get; set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x00029CA0 File Offset: 0x00027EA0
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00029CA8 File Offset: 0x00027EA8
		public global::System.Action<string> LogVerboseDelegate { get; set; }

		// Token: 0x0600116A RID: 4458 RVA: 0x00029CB4 File Offset: 0x00027EB4
		public ToolingFacade(string migrationsAssemblyName, string contextAssemblyName, string configurationTypeName, string workingDirectory, string configurationFilePath, string dataDirectory, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionStringInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationsAssemblyName, "migrationsAssemblyName");
			this._migrationsAssemblyName = migrationsAssemblyName;
			this._contextAssemblyName = contextAssemblyName;
			this._configurationTypeName = configurationTypeName;
			this._connectionStringInfo = connectionStringInfo;
			global::System.AppDomainSetup appDomainSetup = new global::System.AppDomainSetup
			{
				ShadowCopyFiles = "true"
			};
			if (!string.IsNullOrWhiteSpace(workingDirectory))
			{
				appDomainSetup.ApplicationBase = workingDirectory;
			}
			this._configurationFile = new global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater().Update(configurationFilePath);
			appDomainSetup.ConfigurationFile = this._configurationFile;
			string friendlyName = "MigrationsToolingFacade" + global::System.Convert.ToBase64String(global::System.Guid.NewGuid().ToByteArray());
			this._appDomain = global::System.AppDomain.CreateDomain(friendlyName, null, appDomainSetup);
			if (!string.IsNullOrWhiteSpace(dataDirectory))
			{
				this._appDomain.SetData("DataDirectory", dataDirectory);
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00029D76 File Offset: 0x00027F76
		internal ToolingFacade()
		{
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00029D80 File Offset: 0x00027F80
		~ToolingFacade()
		{
			this.Dispose(false);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00029DB0 File Offset: 0x00027FB0
		public global::System.Collections.Generic.IEnumerable<string> GetContextTypes()
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.GetContextTypesRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.GetContextTypesRunner();
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (global::System.Collections.Generic.IEnumerable<string>)this._appDomain.GetData("result");
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00029DE8 File Offset: 0x00027FE8
		public string GetContextType(string contextTypeName)
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.GetContextTypeRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.GetContextTypeRunner
			{
				ContextTypeName = contextTypeName
			};
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (string)this._appDomain.GetData("result");
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00029E28 File Offset: 0x00028028
		public virtual global::System.Collections.Generic.IEnumerable<string> GetDatabaseMigrations()
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.GetDatabaseMigrationsRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.GetDatabaseMigrationsRunner();
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (global::System.Collections.Generic.IEnumerable<string>)this._appDomain.GetData("result");
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00029E60 File Offset: 0x00028060
		public virtual global::System.Collections.Generic.IEnumerable<string> GetPendingMigrations()
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.GetPendingMigrationsRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.GetPendingMigrationsRunner();
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (global::System.Collections.Generic.IEnumerable<string>)this._appDomain.GetData("result");
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00029E98 File Offset: 0x00028098
		public void Update(string targetMigration, bool force)
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.UpdateRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.UpdateRunner
			{
				TargetMigration = targetMigration,
				Force = force
			};
			this.ConfigureRunner(runner);
			this.Run(runner);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00029EC8 File Offset: 0x000280C8
		public string ScriptUpdate(string sourceMigration, string targetMigration, bool force)
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.ScriptUpdateRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.ScriptUpdateRunner
			{
				SourceMigration = sourceMigration,
				TargetMigration = targetMigration,
				Force = force
			};
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (string)this._appDomain.GetData("result");
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00029F14 File Offset: 0x00028114
		public virtual global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(string migrationName, string language, string rootNamespace, bool ignoreChanges)
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.ScaffoldRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.ScaffoldRunner
			{
				MigrationName = migrationName,
				Language = language,
				RootNamespace = rootNamespace,
				IgnoreChanges = ignoreChanges
			};
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (global::System.Data.Entity.Migrations.Design.ScaffoldedMigration)this._appDomain.GetData("result");
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00029F68 File Offset: 0x00028168
		public global::System.Data.Entity.Migrations.Design.ScaffoldedMigration ScaffoldInitialCreate(string language, string rootNamespace)
		{
			global::System.Data.Entity.Migrations.Design.ToolingFacade.InitialCreateScaffoldRunner runner = new global::System.Data.Entity.Migrations.Design.ToolingFacade.InitialCreateScaffoldRunner
			{
				Language = language,
				RootNamespace = rootNamespace
			};
			this.ConfigureRunner(runner);
			this.Run(runner);
			return (global::System.Data.Entity.Migrations.Design.ScaffoldedMigration)this._appDomain.GetData("result");
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00029FAC File Offset: 0x000281AC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00029FBB File Offset: 0x000281BB
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this._appDomain != null)
			{
				global::System.AppDomain.Unload(this._appDomain);
				this._appDomain = null;
			}
			if (this._configurationFile != null)
			{
				global::System.IO.File.Delete(this._configurationFile);
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00029FED File Offset: 0x000281ED
		private void ConfigureRunner(global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner runner)
		{
			runner.MigrationsAssemblyName = this._migrationsAssemblyName;
			runner.ContextAssemblyName = this._contextAssemblyName;
			runner.ConfigurationTypeName = this._configurationTypeName;
			runner.ConnectionStringInfo = this._connectionStringInfo;
			runner.Log = new global::System.Data.Entity.Migrations.Design.ToolingFacade.ToolLogger(this);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0002A02C File Offset: 0x0002822C
		private void Run(global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner runner)
		{
			this._appDomain.SetData("error", null);
			this._appDomain.SetData("typeName", null);
			this._appDomain.SetData("stackTrace", null);
			this._appDomain.DoCallBack(new global::System.CrossAppDomainDelegate(runner.Run));
			string text = (string)this._appDomain.GetData("error");
			if (text != null)
			{
				string innerType = (string)this._appDomain.GetData("typeName");
				string innerStackTrace = (string)this._appDomain.GetData("stackTrace");
				throw new global::System.Data.Entity.Migrations.Design.ToolingException(text, innerType, innerStackTrace);
			}
		}

		// Token: 0x040008E1 RID: 2273
		private readonly string _migrationsAssemblyName;

		// Token: 0x040008E2 RID: 2274
		private readonly string _contextAssemblyName;

		// Token: 0x040008E3 RID: 2275
		private readonly string _configurationTypeName;

		// Token: 0x040008E4 RID: 2276
		private readonly string _configurationFile;

		// Token: 0x040008E5 RID: 2277
		private readonly global::System.Data.Entity.Infrastructure.DbConnectionInfo _connectionStringInfo;

		// Token: 0x040008E6 RID: 2278
		private global::System.AppDomain _appDomain;

		// Token: 0x020007CD RID: 1997
		private class ToolLogger : global::System.Data.Entity.Migrations.Infrastructure.MigrationsLogger
		{
			// Token: 0x06005886 RID: 22662 RVA: 0x0013869A File Offset: 0x0013689A
			public ToolLogger(global::System.Data.Entity.Migrations.Design.ToolingFacade facade)
			{
				this._facade = facade;
			}

			// Token: 0x06005887 RID: 22663 RVA: 0x001386A9 File Offset: 0x001368A9
			public override void Info(string message)
			{
				if (this._facade.LogInfoDelegate != null)
				{
					this._facade.LogInfoDelegate(message);
				}
			}

			// Token: 0x06005888 RID: 22664 RVA: 0x001386C9 File Offset: 0x001368C9
			public override void Warning(string message)
			{
				if (this._facade.LogWarningDelegate != null)
				{
					this._facade.LogWarningDelegate(message);
				}
			}

			// Token: 0x06005889 RID: 22665 RVA: 0x001386E9 File Offset: 0x001368E9
			public override void Verbose(string sql)
			{
				if (this._facade.LogVerboseDelegate != null)
				{
					this._facade.LogVerboseDelegate(sql);
				}
			}

			// Token: 0x04002172 RID: 8562
			private readonly global::System.Data.Entity.Migrations.Design.ToolingFacade _facade;
		}

		// Token: 0x020007CE RID: 1998
		[global::System.Serializable]
		private abstract class BaseRunner
		{
			// Token: 0x1700104D RID: 4173
			// (get) Token: 0x0600588A RID: 22666 RVA: 0x00138709 File Offset: 0x00136909
			// (set) Token: 0x0600588B RID: 22667 RVA: 0x00138711 File Offset: 0x00136911
			public string MigrationsAssemblyName { get; set; }

			// Token: 0x1700104E RID: 4174
			// (get) Token: 0x0600588C RID: 22668 RVA: 0x0013871A File Offset: 0x0013691A
			// (set) Token: 0x0600588D RID: 22669 RVA: 0x00138722 File Offset: 0x00136922
			public string ContextAssemblyName { get; set; }

			// Token: 0x1700104F RID: 4175
			// (get) Token: 0x0600588E RID: 22670 RVA: 0x0013872B File Offset: 0x0013692B
			// (set) Token: 0x0600588F RID: 22671 RVA: 0x00138733 File Offset: 0x00136933
			public string ConfigurationTypeName { get; set; }

			// Token: 0x17001050 RID: 4176
			// (get) Token: 0x06005890 RID: 22672 RVA: 0x0013873C File Offset: 0x0013693C
			// (set) Token: 0x06005891 RID: 22673 RVA: 0x00138744 File Offset: 0x00136944
			public global::System.Data.Entity.Infrastructure.DbConnectionInfo ConnectionStringInfo { get; set; }

			// Token: 0x17001051 RID: 4177
			// (get) Token: 0x06005892 RID: 22674 RVA: 0x0013874D File Offset: 0x0013694D
			// (set) Token: 0x06005893 RID: 22675 RVA: 0x00138755 File Offset: 0x00136955
			public global::System.Data.Entity.Migrations.Design.ToolingFacade.ToolLogger Log { get; set; }

			// Token: 0x06005894 RID: 22676 RVA: 0x00138760 File Offset: 0x00136960
			public void Run()
			{
				try
				{
					this.RunCore();
				}
				catch (global::System.Exception ex)
				{
					global::System.AppDomain.CurrentDomain.SetData("error", ex.Message);
					global::System.AppDomain.CurrentDomain.SetData("typeName", ex.GetType().FullName);
					global::System.AppDomain.CurrentDomain.SetData("stackTrace", ex.ToString());
				}
			}

			// Token: 0x06005895 RID: 22677
			protected abstract void RunCore();

			// Token: 0x06005896 RID: 22678 RVA: 0x001387CC File Offset: 0x001369CC
			protected global::System.Data.Entity.Migrations.Infrastructure.MigratorBase GetMigrator()
			{
				return this.DecorateMigrator(new global::System.Data.Entity.Migrations.DbMigrator(this.GetConfiguration()));
			}

			// Token: 0x06005897 RID: 22679 RVA: 0x001387E0 File Offset: 0x001369E0
			protected global::System.Data.Entity.Migrations.DbMigrationsConfiguration GetConfiguration()
			{
				global::System.Data.Entity.Migrations.DbMigrationsConfiguration dbMigrationsConfiguration = this.FindConfiguration();
				this.OverrideConfiguration(dbMigrationsConfiguration);
				return dbMigrationsConfiguration;
			}

			// Token: 0x06005898 RID: 22680 RVA: 0x001387FC File Offset: 0x001369FC
			protected virtual void OverrideConfiguration(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
			{
				if (this.ConnectionStringInfo != null)
				{
					configuration.TargetDatabase = this.ConnectionStringInfo;
				}
			}

			// Token: 0x06005899 RID: 22681 RVA: 0x00138812 File Offset: 0x00136A12
			private global::System.Data.Entity.Migrations.Infrastructure.MigratorBase DecorateMigrator(global::System.Data.Entity.Migrations.DbMigrator migrator)
			{
				return new global::System.Data.Entity.Migrations.Infrastructure.MigratorLoggingDecorator(migrator, this.Log);
			}

			// Token: 0x0600589A RID: 22682 RVA: 0x00138820 File Offset: 0x00136A20
			private global::System.Data.Entity.Migrations.DbMigrationsConfiguration FindConfiguration()
			{
				return new global::System.Data.Entity.Migrations.Utilities.MigrationsConfigurationFinder(new global::System.Data.Entity.Utilities.TypeFinder(this.LoadMigrationsAssembly())).FindMigrationsConfiguration(null, this.ConfigurationTypeName, new global::System.Func<string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_NoConfiguration), (string assembly, global::System.Collections.Generic.IEnumerable<global::System.Type> types) => global::System.Data.Entity.Resources.Error.AssemblyMigrator_MultipleConfigurations(assembly), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_NoConfigurationWithName), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_MultipleConfigurationsWithName));
			}

			// Token: 0x0600589B RID: 22683 RVA: 0x0013888C File Offset: 0x00136A8C
			protected global::System.Reflection.Assembly LoadMigrationsAssembly()
			{
				return global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner.LoadAssembly(this.MigrationsAssemblyName);
			}

			// Token: 0x0600589C RID: 22684 RVA: 0x00138899 File Offset: 0x00136A99
			protected global::System.Reflection.Assembly LoadContextAssembly()
			{
				return global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner.LoadAssembly(this.ContextAssemblyName);
			}

			// Token: 0x0600589D RID: 22685 RVA: 0x001388A8 File Offset: 0x00136AA8
			private static global::System.Reflection.Assembly LoadAssembly(string name)
			{
				global::System.Reflection.Assembly result;
				try
				{
					result = global::System.Reflection.Assembly.Load(name);
				}
				catch (global::System.IO.FileNotFoundException ex)
				{
					throw new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.ToolingFacade_AssemblyNotFound(ex.FileName), ex);
				}
				return result;
			}
		}

		// Token: 0x020007CF RID: 1999
		[global::System.Serializable]
		private class GetDatabaseMigrationsRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x0600589F RID: 22687 RVA: 0x001388EC File Offset: 0x00136AEC
			protected override void RunCore()
			{
				global::System.Collections.Generic.IEnumerable<string> databaseMigrations = base.GetMigrator().GetDatabaseMigrations();
				global::System.AppDomain.CurrentDomain.SetData("result", databaseMigrations);
			}
		}

		// Token: 0x020007D0 RID: 2000
		[global::System.Serializable]
		private class GetPendingMigrationsRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x060058A1 RID: 22689 RVA: 0x00138920 File Offset: 0x00136B20
			protected override void RunCore()
			{
				global::System.Collections.Generic.IEnumerable<string> pendingMigrations = base.GetMigrator().GetPendingMigrations();
				global::System.AppDomain.CurrentDomain.SetData("result", pendingMigrations);
			}
		}

		// Token: 0x020007D1 RID: 2001
		[global::System.Serializable]
		private class UpdateRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x17001052 RID: 4178
			// (get) Token: 0x060058A3 RID: 22691 RVA: 0x00138951 File Offset: 0x00136B51
			// (set) Token: 0x060058A4 RID: 22692 RVA: 0x00138959 File Offset: 0x00136B59
			public string TargetMigration { get; set; }

			// Token: 0x17001053 RID: 4179
			// (get) Token: 0x060058A5 RID: 22693 RVA: 0x00138962 File Offset: 0x00136B62
			// (set) Token: 0x060058A6 RID: 22694 RVA: 0x0013896A File Offset: 0x00136B6A
			public bool Force { get; set; }

			// Token: 0x060058A7 RID: 22695 RVA: 0x00138973 File Offset: 0x00136B73
			protected override void RunCore()
			{
				base.GetMigrator().Update(this.TargetMigration);
			}

			// Token: 0x060058A8 RID: 22696 RVA: 0x00138986 File Offset: 0x00136B86
			protected override void OverrideConfiguration(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
			{
				base.OverrideConfiguration(configuration);
				if (this.Force)
				{
					configuration.AutomaticMigrationDataLossAllowed = true;
				}
			}
		}

		// Token: 0x020007D2 RID: 2002
		[global::System.Serializable]
		private class ScriptUpdateRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x17001054 RID: 4180
			// (get) Token: 0x060058AA RID: 22698 RVA: 0x001389A6 File Offset: 0x00136BA6
			// (set) Token: 0x060058AB RID: 22699 RVA: 0x001389AE File Offset: 0x00136BAE
			public string SourceMigration { get; set; }

			// Token: 0x17001055 RID: 4181
			// (get) Token: 0x060058AC RID: 22700 RVA: 0x001389B7 File Offset: 0x00136BB7
			// (set) Token: 0x060058AD RID: 22701 RVA: 0x001389BF File Offset: 0x00136BBF
			public string TargetMigration { get; set; }

			// Token: 0x17001056 RID: 4182
			// (get) Token: 0x060058AE RID: 22702 RVA: 0x001389C8 File Offset: 0x00136BC8
			// (set) Token: 0x060058AF RID: 22703 RVA: 0x001389D0 File Offset: 0x00136BD0
			public bool Force { get; set; }

			// Token: 0x060058B0 RID: 22704 RVA: 0x001389DC File Offset: 0x00136BDC
			protected override void RunCore()
			{
				string data = new global::System.Data.Entity.Migrations.Infrastructure.MigratorScriptingDecorator(base.GetMigrator()).ScriptUpdate(this.SourceMigration, this.TargetMigration);
				global::System.AppDomain.CurrentDomain.SetData("result", data);
			}

			// Token: 0x060058B1 RID: 22705 RVA: 0x00138A16 File Offset: 0x00136C16
			protected override void OverrideConfiguration(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
			{
				base.OverrideConfiguration(configuration);
				if (this.Force)
				{
					configuration.AutomaticMigrationDataLossAllowed = true;
				}
			}
		}

		// Token: 0x020007D3 RID: 2003
		[global::System.Serializable]
		private class ScaffoldRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x17001057 RID: 4183
			// (get) Token: 0x060058B3 RID: 22707 RVA: 0x00138A36 File Offset: 0x00136C36
			// (set) Token: 0x060058B4 RID: 22708 RVA: 0x00138A3E File Offset: 0x00136C3E
			public string MigrationName { get; set; }

			// Token: 0x17001058 RID: 4184
			// (get) Token: 0x060058B5 RID: 22709 RVA: 0x00138A47 File Offset: 0x00136C47
			// (set) Token: 0x060058B6 RID: 22710 RVA: 0x00138A4F File Offset: 0x00136C4F
			public string Language { get; set; }

			// Token: 0x17001059 RID: 4185
			// (get) Token: 0x060058B7 RID: 22711 RVA: 0x00138A58 File Offset: 0x00136C58
			// (set) Token: 0x060058B8 RID: 22712 RVA: 0x00138A60 File Offset: 0x00136C60
			public string RootNamespace { get; set; }

			// Token: 0x1700105A RID: 4186
			// (get) Token: 0x060058B9 RID: 22713 RVA: 0x00138A69 File Offset: 0x00136C69
			// (set) Token: 0x060058BA RID: 22714 RVA: 0x00138A71 File Offset: 0x00136C71
			public bool IgnoreChanges { get; set; }

			// Token: 0x060058BB RID: 22715 RVA: 0x00138A7C File Offset: 0x00136C7C
			protected override void RunCore()
			{
				global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration = base.GetConfiguration();
				global::System.Data.Entity.Migrations.Design.MigrationScaffolder migrationScaffolder = new global::System.Data.Entity.Migrations.Design.MigrationScaffolder(configuration);
				string text = configuration.MigrationsNamespace;
				if (this.Language == "vb" && !string.IsNullOrWhiteSpace(this.RootNamespace))
				{
					if (this.RootNamespace.EqualsIgnoreCase(text))
					{
						text = null;
					}
					else
					{
						if (text == null || !text.StartsWith(this.RootNamespace + ".", global::System.StringComparison.OrdinalIgnoreCase))
						{
							throw global::System.Data.Entity.Resources.Error.MigrationsNamespaceNotUnderRootNamespace(text, this.RootNamespace);
						}
						text = text.Substring(this.RootNamespace.Length + 1);
					}
				}
				migrationScaffolder.Namespace = text;
				global::System.Data.Entity.Migrations.Design.ScaffoldedMigration data = this.Scaffold(migrationScaffolder);
				global::System.AppDomain.CurrentDomain.SetData("result", data);
			}

			// Token: 0x060058BC RID: 22716 RVA: 0x00138B2B File Offset: 0x00136D2B
			protected virtual global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(global::System.Data.Entity.Migrations.Design.MigrationScaffolder scaffolder)
			{
				return scaffolder.Scaffold(this.MigrationName, this.IgnoreChanges);
			}

			// Token: 0x060058BD RID: 22717 RVA: 0x00138B3F File Offset: 0x00136D3F
			protected override void OverrideConfiguration(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
			{
				base.OverrideConfiguration(configuration);
				if (this.Language == "vb" && configuration.CodeGenerator is global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator)
				{
					configuration.CodeGenerator = new global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator();
				}
			}
		}

		// Token: 0x020007D4 RID: 2004
		[global::System.Serializable]
		private class InitialCreateScaffoldRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.ScaffoldRunner
		{
			// Token: 0x060058BF RID: 22719 RVA: 0x00138B7A File Offset: 0x00136D7A
			protected override global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(global::System.Data.Entity.Migrations.Design.MigrationScaffolder scaffolder)
			{
				return scaffolder.ScaffoldInitialCreate();
			}
		}

		// Token: 0x020007D5 RID: 2005
		[global::System.Serializable]
		private class GetContextTypesRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x060058C1 RID: 22721 RVA: 0x00138B8C File Offset: 0x00136D8C
			protected override void RunCore()
			{
				global::System.Collections.Generic.List<string> data = (from t in base.LoadContextAssembly().GetAccessibleTypes()
				where !t.IsAbstract && !t.IsGenericType && typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(t)
				select t.FullName).ToList<string>();
				global::System.AppDomain.CurrentDomain.SetData("result", data);
			}
		}

		// Token: 0x020007D6 RID: 2006
		[global::System.Serializable]
		private class GetContextTypeRunner : global::System.Data.Entity.Migrations.Design.ToolingFacade.BaseRunner
		{
			// Token: 0x1700105B RID: 4187
			// (get) Token: 0x060058C3 RID: 22723 RVA: 0x00138C0A File Offset: 0x00136E0A
			// (set) Token: 0x060058C4 RID: 22724 RVA: 0x00138C12 File Offset: 0x00136E12
			public string ContextTypeName { get; set; }

			// Token: 0x060058C5 RID: 22725 RVA: 0x00138C1C File Offset: 0x00136E1C
			protected override void RunCore()
			{
				global::System.Type type = new global::System.Data.Entity.Utilities.TypeFinder(base.LoadContextAssembly()).FindType(typeof(global::System.Data.Entity.DbContext), this.ContextTypeName, (global::System.Collections.Generic.IEnumerable<global::System.Type> types) => from t in types
				where !typeof(global::System.Data.Entity.Migrations.History.HistoryContext).IsAssignableFrom(t) && !t.IsAbstract && !t.IsGenericType
				select t, new global::System.Func<string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_NoContext), delegate(string assembly, global::System.Collections.Generic.IEnumerable<global::System.Type> types)
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.Append(global::System.Data.Entity.Resources.Strings.EnableMigrations_MultipleContexts(assembly));
					foreach (global::System.Type type2 in types)
					{
						stringBuilder.AppendLine();
						stringBuilder.Append(global::System.Data.Entity.Resources.Strings.EnableMigrationsForContext(type2.FullName));
					}
					return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(stringBuilder.ToString());
				}, new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_NoContextWithName), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_MultipleContextsWithName));
				global::System.AppDomain.CurrentDomain.SetData("result", type.FullName);
			}
		}
	}
}
