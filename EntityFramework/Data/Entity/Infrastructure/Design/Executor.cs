using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Design;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x0200029C RID: 668
	public class Executor : global::System.MarshalByRefObject
	{
		// Token: 0x06002159 RID: 8537 RVA: 0x0005C830 File Offset: 0x0005AA30
		public Executor(string assemblyFile, global::System.Collections.Generic.IDictionary<string, object> anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(assemblyFile, "assemblyFile");
			this._reporter = new global::System.Data.Entity.Infrastructure.Design.Reporter(new global::System.Data.Entity.Infrastructure.Design.WrappedReportHandler((anonymousArguments != null) ? anonymousArguments["reportHandler"] : null));
			this._language = (string)((anonymousArguments != null) ? anonymousArguments["language"] : null);
			this._rootNamespace = (string)((anonymousArguments != null) ? anonymousArguments["rootNamespace"] : null);
			this._assembly = global::System.Reflection.Assembly.Load(global::System.Reflection.AssemblyName.GetAssemblyName(global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, assemblyFile)));
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		private global::System.Reflection.Assembly LoadAssembly(string assemblyName)
		{
			if (string.IsNullOrEmpty(assemblyName))
			{
				return null;
			}
			global::System.Reflection.Assembly result;
			try
			{
				result = global::System.Reflection.Assembly.Load(assemblyName);
			}
			catch (global::System.IO.FileNotFoundException ex)
			{
				throw new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(global::System.Data.Entity.Resources.Strings.ToolingFacade_AssemblyNotFound(ex.FileName), ex);
			}
			return result;
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0005C910 File Offset: 0x0005AB10
		private string GetContextTypeInternal(string contextTypeName, string contextAssemblyName)
		{
			return new global::System.Data.Entity.Utilities.TypeFinder(this.LoadAssembly(contextAssemblyName) ?? this._assembly).FindType(typeof(global::System.Data.Entity.DbContext), contextTypeName, (global::System.Collections.Generic.IEnumerable<global::System.Type> types) => from t in types
			where !typeof(global::System.Data.Entity.Migrations.History.HistoryContext).IsAssignableFrom(t) && !t.IsAbstract && !t.IsGenericType
			select t, new global::System.Func<string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_NoContext), delegate(string assembly, global::System.Collections.Generic.IEnumerable<global::System.Type> types)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(global::System.Data.Entity.Resources.Strings.EnableMigrations_MultipleContexts(assembly));
				foreach (global::System.Type type in types)
				{
					stringBuilder.AppendLine();
					stringBuilder.Append(global::System.Data.Entity.Resources.Strings.EnableMigrationsForContext(type.FullName));
				}
				return new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(stringBuilder.ToString());
			}, new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_NoContextWithName), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.EnableMigrations_MultipleContextsWithName)).FullName;
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0005C9AC File Offset: 0x0005ABAC
		internal virtual string GetProviderServicesInternal(string invariantName)
		{
			global::System.Data.Entity.DbConfiguration.LoadConfiguration(this._assembly);
			global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver dependencyResolver = global::System.Data.Entity.DbConfiguration.DependencyResolver;
			global::System.Data.Entity.Core.Common.DbProviderServices dbProviderServices = null;
			try
			{
				dbProviderServices = dependencyResolver.GetService(invariantName);
			}
			catch
			{
			}
			if (dbProviderServices == null)
			{
				return null;
			}
			return dbProviderServices.GetType().AssemblyQualifiedName;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0005C9FC File Offset: 0x0005ABFC
		private void OverrideConfiguration(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, bool force = false)
		{
			if (connectionInfo != null)
			{
				configuration.TargetDatabase = connectionInfo;
			}
			if (string.Equals(this._language, "VB", global::System.StringComparison.OrdinalIgnoreCase) && configuration.CodeGenerator is global::System.Data.Entity.Migrations.Design.CSharpMigrationCodeGenerator)
			{
				configuration.CodeGenerator = new global::System.Data.Entity.Migrations.Design.VisualBasicMigrationCodeGenerator();
			}
			if (force)
			{
				configuration.AutomaticMigrationDataLossAllowed = true;
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0005CA48 File Offset: 0x0005AC48
		private global::System.Data.Entity.Migrations.Design.MigrationScaffolder CreateMigrationScaffolder(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
		{
			global::System.Data.Entity.Migrations.Design.MigrationScaffolder migrationScaffolder = new global::System.Data.Entity.Migrations.Design.MigrationScaffolder(configuration);
			string text = configuration.MigrationsNamespace;
			if (string.Equals(this._language, "VB", global::System.StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(this._rootNamespace))
			{
				if (this._rootNamespace.EqualsIgnoreCase(text))
				{
					text = null;
				}
				else
				{
					if (text == null || !text.StartsWith(this._rootNamespace + ".", global::System.StringComparison.OrdinalIgnoreCase))
					{
						throw global::System.Data.Entity.Resources.Error.MigrationsNamespaceNotUnderRootNamespace(text, this._rootNamespace);
					}
					text = text.Substring(this._rootNamespace.Length + 1);
				}
			}
			migrationScaffolder.Namespace = text;
			return migrationScaffolder;
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0005CADC File Offset: 0x0005ACDC
		private static global::System.Collections.IDictionary ToHashtable(global::System.Data.Entity.Migrations.Design.ScaffoldedMigration result)
		{
			if (result != null)
			{
				global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
				object key = "MigrationId";
				hashtable[key] = result.MigrationId;
				object key2 = "UserCode";
				hashtable[key2] = result.UserCode;
				object key3 = "DesignerCode";
				hashtable[key3] = result.DesignerCode;
				object key4 = "Language";
				hashtable[key4] = result.Language;
				object key5 = "Directory";
				hashtable[key5] = result.Directory;
				object key6 = "Resources";
				hashtable[key6] = result.Resources;
				object key7 = "IsRescaffold";
				hashtable[key7] = result.IsRescaffold;
				return hashtable;
			}
			return null;
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0005CB88 File Offset: 0x0005AD88
		internal virtual global::System.Collections.IDictionary ScaffoldInitialCreateInternal(global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, string contextTypeName, string contextAssemblyName, string migrationsNamespace, bool auto, string migrationsDir)
		{
			global::System.Reflection.Assembly assembly = this.LoadAssembly(contextAssemblyName) ?? this._assembly;
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration = new global::System.Data.Entity.Migrations.DbMigrationsConfiguration
			{
				ContextType = assembly.GetType(contextTypeName, true),
				MigrationsAssembly = this._assembly,
				MigrationsNamespace = migrationsNamespace,
				AutomaticMigrationsEnabled = auto,
				MigrationsDirectory = migrationsDir
			};
			this.OverrideConfiguration(configuration, connectionInfo, false);
			return global::System.Data.Entity.Infrastructure.Design.Executor.ToHashtable(this.CreateMigrationScaffolder(configuration).ScaffoldInitialCreate());
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0005CBFC File Offset: 0x0005ADFC
		private global::System.Data.Entity.Migrations.DbMigrationsConfiguration GetMigrationsConfiguration(string migrationsConfigurationName)
		{
			return new global::System.Data.Entity.Migrations.Utilities.MigrationsConfigurationFinder(new global::System.Data.Entity.Utilities.TypeFinder(this._assembly)).FindMigrationsConfiguration(null, migrationsConfigurationName, new global::System.Func<string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_NoConfiguration), (string assembly, global::System.Collections.Generic.IEnumerable<global::System.Type> types) => global::System.Data.Entity.Resources.Error.AssemblyMigrator_MultipleConfigurations(assembly), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_NoConfigurationWithName), new global::System.Func<string, string, global::System.Exception>(global::System.Data.Entity.Resources.Error.AssemblyMigrator_MultipleConfigurationsWithName));
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0005CC64 File Offset: 0x0005AE64
		internal virtual global::System.Collections.IDictionary ScaffoldInternal(string name, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, string migrationsConfigurationName, bool ignoreChanges)
		{
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration migrationsConfiguration = this.GetMigrationsConfiguration(migrationsConfigurationName);
			this.OverrideConfiguration(migrationsConfiguration, connectionInfo, false);
			return global::System.Data.Entity.Infrastructure.Design.Executor.ToHashtable(this.CreateMigrationScaffolder(migrationsConfiguration).Scaffold(name, ignoreChanges));
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0005CC98 File Offset: 0x0005AE98
		internal global::System.Collections.Generic.IEnumerable<string> GetDatabaseMigrationsInternal(global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, string migrationsConfigurationName)
		{
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration migrationsConfiguration = this.GetMigrationsConfiguration(migrationsConfigurationName);
			this.OverrideConfiguration(migrationsConfiguration, connectionInfo, false);
			return this.CreateMigrator(migrationsConfiguration).GetDatabaseMigrations();
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0005CCC4 File Offset: 0x0005AEC4
		internal string ScriptUpdateInternal(string sourceMigration, string targetMigration, bool force, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, string migrationsConfigurationName)
		{
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration migrationsConfiguration = this.GetMigrationsConfiguration(migrationsConfigurationName);
			this.OverrideConfiguration(migrationsConfiguration, connectionInfo, force);
			return new global::System.Data.Entity.Migrations.Infrastructure.MigratorScriptingDecorator(this.CreateMigrator(migrationsConfiguration)).ScriptUpdate(sourceMigration, targetMigration);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
		internal void UpdateInternal(string targetMigration, bool force, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, string migrationsConfigurationName)
		{
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration migrationsConfiguration = this.GetMigrationsConfiguration(migrationsConfigurationName);
			this.OverrideConfiguration(migrationsConfiguration, connectionInfo, force);
			this.CreateMigrator(migrationsConfiguration).Update(targetMigration);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0005CD24 File Offset: 0x0005AF24
		private global::System.Data.Entity.Migrations.Infrastructure.MigratorBase CreateMigrator(global::System.Data.Entity.Migrations.DbMigrationsConfiguration configuration)
		{
			return new global::System.Data.Entity.Migrations.Infrastructure.MigratorLoggingDecorator(new global::System.Data.Entity.Migrations.DbMigrator(configuration), new global::System.Data.Entity.Infrastructure.Design.Executor.ToolLogger(this._reporter));
		}

		// Token: 0x04000B9A RID: 2970
		private readonly global::System.Reflection.Assembly _assembly;

		// Token: 0x04000B9B RID: 2971
		private readonly global::System.Data.Entity.Infrastructure.Design.Reporter _reporter;

		// Token: 0x04000B9C RID: 2972
		private readonly string _language;

		// Token: 0x04000B9D RID: 2973
		private readonly string _rootNamespace;

		// Token: 0x0200098D RID: 2445
		public class GetContextType : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005ED6 RID: 24278 RVA: 0x00145F6C File Offset: 0x0014416C
			public GetContextType(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string contextTypeName = (string)args["contextTypeName"];
				string contextAssemblyName = (string)args["contextAssemblyName"];
				this.Execute<string>(() => executor.GetContextTypeInternal(contextTypeName, contextAssemblyName));
			}
		}

		// Token: 0x0200098E RID: 2446
		internal class GetProviderServices : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005ED7 RID: 24279 RVA: 0x00145FF4 File Offset: 0x001441F4
			public GetProviderServices(global::System.Data.Entity.Infrastructure.Design.Executor executor, object handler, string invariantName, global::System.Collections.Generic.IDictionary<string, object> anonymousArguments) : base(handler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotEmpty(invariantName, "invariantName");
				this.Execute<string>(() => executor.GetProviderServicesInternal(invariantName));
			}
		}

		// Token: 0x0200098F RID: 2447
		public class ScaffoldInitialCreate : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005ED8 RID: 24280 RVA: 0x00146050 File Offset: 0x00144250
			public ScaffoldInitialCreate(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string connectionStringName = (string)args["connectionStringName"];
				string connectionString = (string)args["connectionString"];
				string connectionProviderName = (string)args["connectionProviderName"];
				string contextTypeName = (string)args["contextTypeName"];
				string contextAssemblyName = (string)args["contextAssemblyName"];
				string migrationsNamespace = (string)args["migrationsNamespace"];
				bool auto = (bool)args["auto"];
				string migrationsDir = (string)args["migrationsDir"];
				this.Execute<global::System.Collections.IDictionary>(() => executor.ScaffoldInitialCreateInternal(global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase.CreateConnectionInfo(connectionStringName, connectionString, connectionProviderName), contextTypeName, contextAssemblyName, migrationsNamespace, auto, migrationsDir));
			}
		}

		// Token: 0x02000990 RID: 2448
		public class Scaffold : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005ED9 RID: 24281 RVA: 0x0014615C File Offset: 0x0014435C
			public Scaffold(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string name = (string)args["name"];
				string connectionStringName = (string)args["connectionStringName"];
				string connectionString = (string)args["connectionString"];
				string connectionProviderName = (string)args["connectionProviderName"];
				string migrationsConfigurationName = (string)args["migrationsConfigurationName"];
				bool ignoreChanges = (bool)args["ignoreChanges"];
				this.Execute<global::System.Collections.IDictionary>(() => executor.ScaffoldInternal(name, global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase.CreateConnectionInfo(connectionStringName, connectionString, connectionProviderName), migrationsConfigurationName, ignoreChanges));
			}
		}

		// Token: 0x02000991 RID: 2449
		public class GetDatabaseMigrations : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005EDA RID: 24282 RVA: 0x0014623C File Offset: 0x0014443C
			public GetDatabaseMigrations(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string connectionStringName = (string)args["connectionStringName"];
				string connectionString = (string)args["connectionString"];
				string connectionProviderName = (string)args["connectionProviderName"];
				string migrationsConfigurationName = (string)args["migrationsConfigurationName"];
				this.Execute<string>(() => executor.GetDatabaseMigrationsInternal(global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase.CreateConnectionInfo(connectionStringName, connectionString, connectionProviderName), migrationsConfigurationName));
			}
		}

		// Token: 0x02000992 RID: 2450
		public class ScriptUpdate : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005EDB RID: 24283 RVA: 0x001462F0 File Offset: 0x001444F0
			public ScriptUpdate(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string sourceMigration = (string)args["sourceMigration"];
				string targetMigration = (string)args["targetMigration"];
				bool force = (bool)args["force"];
				string connectionStringName = (string)args["connectionStringName"];
				string connectionString = (string)args["connectionString"];
				string connectionProviderName = (string)args["connectionProviderName"];
				string migrationsConfigurationName = (string)args["migrationsConfigurationName"];
				this.Execute<string>(() => executor.ScriptUpdateInternal(sourceMigration, targetMigration, force, global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase.CreateConnectionInfo(connectionStringName, connectionString, connectionProviderName), migrationsConfigurationName));
			}
		}

		// Token: 0x02000993 RID: 2451
		public class Update : global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase
		{
			// Token: 0x06005EDC RID: 24284 RVA: 0x001463E8 File Offset: 0x001445E8
			public Update(global::System.Data.Entity.Infrastructure.Design.Executor executor, object resultHandler, global::System.Collections.IDictionary args) : base(resultHandler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Design.Executor>(executor, "executor");
				global::System.Data.Entity.Utilities.Check.NotNull<object>(resultHandler, "resultHandler");
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IDictionary>(args, "args");
				string targetMigration = (string)args["targetMigration"];
				bool force = (bool)args["force"];
				string connectionStringName = (string)args["connectionStringName"];
				string connectionString = (string)args["connectionString"];
				string connectionProviderName = (string)args["connectionProviderName"];
				string migrationsConfigurationName = (string)args["migrationsConfigurationName"];
				this.Execute(delegate()
				{
					executor.UpdateInternal(targetMigration, force, global::System.Data.Entity.Infrastructure.Design.Executor.OperationBase.CreateConnectionInfo(connectionStringName, connectionString, connectionProviderName), migrationsConfigurationName);
				});
			}
		}

		// Token: 0x02000994 RID: 2452
		public abstract class OperationBase : global::System.MarshalByRefObject
		{
			// Token: 0x06005EDD RID: 24285 RVA: 0x001464C8 File Offset: 0x001446C8
			protected OperationBase(object handler)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<object>(handler, "handler");
				this._handler = new global::System.Data.Entity.Infrastructure.Design.WrappedResultHandler(handler);
			}

			// Token: 0x06005EDE RID: 24286 RVA: 0x001464E8 File Offset: 0x001446E8
			protected static global::System.Data.Entity.Infrastructure.DbConnectionInfo CreateConnectionInfo(string connectionStringName, string connectionString, string connectionProviderName)
			{
				if (!string.IsNullOrWhiteSpace(connectionStringName))
				{
					return new global::System.Data.Entity.Infrastructure.DbConnectionInfo(connectionStringName);
				}
				if (!string.IsNullOrWhiteSpace(connectionString))
				{
					return new global::System.Data.Entity.Infrastructure.DbConnectionInfo(connectionString, connectionProviderName);
				}
				return null;
			}

			// Token: 0x06005EDF RID: 24287 RVA: 0x0014650C File Offset: 0x0014470C
			protected virtual void Execute(global::System.Action action)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action>(action, "action");
				try
				{
					action();
				}
				catch (global::System.Exception ex)
				{
					if (!this._handler.SetError(ex.GetType().FullName, ex.Message, ex.ToString()))
					{
						throw;
					}
				}
			}

			// Token: 0x06005EE0 RID: 24288 RVA: 0x00146568 File Offset: 0x00144768
			protected virtual void Execute<T>(global::System.Func<T> action)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<T>>(action, "action");
				this.Execute(delegate()
				{
					this._handler.SetResult(action());
				});
			}

			// Token: 0x06005EE1 RID: 24289 RVA: 0x001465AC File Offset: 0x001447AC
			protected virtual void Execute<T>(global::System.Func<global::System.Collections.Generic.IEnumerable<T>> action)
			{
				global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Collections.Generic.IEnumerable<T>>>(action, "action");
				this.Execute(delegate()
				{
					this._handler.SetResult(action().ToArray<T>());
				});
			}

			// Token: 0x04002791 RID: 10129
			private readonly global::System.Data.Entity.Infrastructure.Design.WrappedResultHandler _handler;
		}

		// Token: 0x02000995 RID: 2453
		private class ToolLogger : global::System.Data.Entity.Migrations.Infrastructure.MigrationsLogger
		{
			// Token: 0x06005EE2 RID: 24290 RVA: 0x001465F0 File Offset: 0x001447F0
			public ToolLogger(global::System.Data.Entity.Infrastructure.Design.Reporter reporter)
			{
				this._reporter = reporter;
			}

			// Token: 0x06005EE3 RID: 24291 RVA: 0x001465FF File Offset: 0x001447FF
			public override void Info(string message)
			{
				this._reporter.WriteInformation(message);
			}

			// Token: 0x06005EE4 RID: 24292 RVA: 0x0014660D File Offset: 0x0014480D
			public override void Warning(string message)
			{
				this._reporter.WriteWarning(message);
			}

			// Token: 0x06005EE5 RID: 24293 RVA: 0x0014661B File Offset: 0x0014481B
			public override void Verbose(string sql)
			{
				this._reporter.WriteVerbose(sql);
			}

			// Token: 0x04002792 RID: 10130
			private readonly global::System.Data.Entity.Infrastructure.Design.Reporter _reporter;
		}
	}
}
