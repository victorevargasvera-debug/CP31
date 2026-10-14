using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Spatial;
using System.Data.Entity.SqlServer.Resources;
using System.Data.Entity.SqlServer.SqlGen;
using System.Data.Entity.SqlServer.Utilities;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.CSharp.RuntimeBinder;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x02000012 RID: 18
	public class SqlServerMigrationSqlGenerator : global::System.Data.Entity.Migrations.Sql.MigrationSqlGenerator
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006524 File Offset: 0x00004724
		public override bool IsPermissionDeniedError(global::System.Exception exception)
		{
			global::System.Data.SqlClient.SqlException ex = exception as global::System.Data.SqlClient.SqlException;
			return ex != null && ex.Number == 229;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000654C File Offset: 0x0000474C
		public override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> Generate(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> migrationOperations, string providerManifestToken)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(migrationOperations, "migrationOperations");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<string>(providerManifestToken, "providerManifestToken");
			this._statements = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement>();
			this._generatedSchemas = new global::System.Collections.Generic.HashSet<string>();
			this.InitializeProviderServices(providerManifestToken);
			this.GenerateStatements(migrationOperations);
			return this._statements;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000659B File Offset: 0x0000479B
		private void GenerateStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> migrationOperations)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(migrationOperations, "migrationOperations");
			global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.DetectHistoryRebuild(migrationOperations).Each(delegate(dynamic o)
			{
				if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__10.<>p__0 == null)
				{
					global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__10.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName | global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Generate", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__10.<>p__0.Target(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__10.<>p__0, this, o);
			});
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000065C0 File Offset: 0x000047C0
		public override string GenerateProcedureBody(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> commandTrees, string rowsAffectedParameter, string providerManifestToken)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>>(commandTrees, "commandTrees");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(providerManifestToken, "providerManifestToken");
			if (!commandTrees.Any<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>())
			{
				return "RETURN";
			}
			this.InitializeProviderServices(providerManifestToken);
			return this.GenerateFunctionSql(commandTrees, rowsAffectedParameter);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000065F8 File Offset: 0x000047F8
		private void InitializeProviderServices(string providerManifestToken)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(providerManifestToken, "providerManifestToken");
			this._providerManifestToken = providerManifestToken;
			using (global::System.Data.Common.DbConnection dbConnection = this.CreateConnection())
			{
				base.ProviderManifest = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(dbConnection).GetProviderManifest(providerManifestToken);
				this._sqlGenerator = new global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator(global::System.Data.Entity.SqlServer.SqlVersionUtils.GetSqlVersion(providerManifestToken));
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006660 File Offset: 0x00004860
		private string GenerateFunctionSql(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> commandTrees, string rowsAffectedParameter)
		{
			global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator dmlFunctionSqlGenerator = new global::System.Data.Entity.SqlServer.SqlGen.DmlFunctionSqlGenerator(this._sqlGenerator);
			switch (commandTrees.First<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree>().CommandTreeKind)
			{
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Update:
				return dmlFunctionSqlGenerator.GenerateUpdate(commandTrees.Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>(), rowsAffectedParameter);
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert:
				return dmlFunctionSqlGenerator.GenerateInsert(commandTrees.Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>());
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete:
				return dmlFunctionSqlGenerator.GenerateDelete(commandTrees.Cast<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>(), rowsAffectedParameter);
			default:
				return null;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000066D4 File Offset: 0x000048D4
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation updateDatabaseOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation>(updateDatabaseOperation, "updateDatabaseOperation");
			if (!updateDatabaseOperation.Migrations.Any<global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration>())
			{
				return;
			}
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.WriteLine("DECLARE @CurrentMigration [nvarchar](max)");
				indentedTextWriter.WriteLine();
				int indent;
				foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree tree in updateDatabaseOperation.HistoryQueryTrees)
				{
					global::System.Collections.Generic.HashSet<string> hashSet;
					string s = this._sqlGenerator.GenerateSql(tree, out hashSet);
					indentedTextWriter.Write("IF object_id('");
					indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this._sqlGenerator.Targets.Single<string>()));
					indentedTextWriter.WriteLine("') IS NOT NULL");
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = indentedTextWriter;
					indent = indentedTextWriter2.Indent;
					indentedTextWriter2.Indent = indent + 1;
					indentedTextWriter.WriteLine("SELECT @CurrentMigration =");
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter3 = indentedTextWriter;
					indent = indentedTextWriter3.Indent;
					indentedTextWriter3.Indent = indent + 1;
					indentedTextWriter.Write("(");
					indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Indent(s, indentedTextWriter.CurrentIndentation()));
					indentedTextWriter.WriteLine(")");
					indentedTextWriter.Indent -= 2;
					indentedTextWriter.WriteLine();
				}
				indentedTextWriter.WriteLine("IF @CurrentMigration IS NULL");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter4 = indentedTextWriter;
				indent = indentedTextWriter4.Indent;
				indentedTextWriter4.Indent = indent + 1;
				indentedTextWriter.WriteLine("SET @CurrentMigration = '0'");
				this.Statement(indentedTextWriter, null);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement> statements = this._statements;
			foreach (global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration migration in updateDatabaseOperation.Migrations)
			{
				using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter5 = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
				{
					this._statements = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement>();
					this.GenerateStatements(migration.Operations);
					if (this._statements.Count > 0)
					{
						indentedTextWriter5.Write("IF @CurrentMigration < '");
						indentedTextWriter5.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(migration.MigrationId));
						indentedTextWriter5.WriteLine("'");
						indentedTextWriter5.Write("BEGIN");
						using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter blockWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
						{
							blockWriter.WriteLine();
							global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter blockWriter4 = blockWriter;
							int indent = blockWriter4.Indent;
							blockWriter4.Indent = indent + 1;
							global::System.Action<string> <>9__0;
							foreach (global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement in this._statements)
							{
								if (string.IsNullOrWhiteSpace(migrationStatement.BatchTerminator))
								{
									migrationStatement.Sql.EachLine(new global::System.Action<string>(blockWriter.WriteLine));
								}
								else
								{
									blockWriter.WriteLine("EXECUTE('");
									global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter blockWriter2 = blockWriter;
									indent = blockWriter2.Indent;
									blockWriter2.Indent = indent + 1;
									string sql = migrationStatement.Sql;
									global::System.Action<string> action;
									if ((action = <>9__0) == null)
									{
										action = (<>9__0 = delegate(string l)
										{
											blockWriter.WriteLine(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(l));
										});
									}
									sql.EachLine(action);
									global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter blockWriter3 = blockWriter;
									indent = blockWriter3.Indent;
									blockWriter3.Indent = indent - 1;
									blockWriter.WriteLine("')");
								}
							}
							indentedTextWriter5.WriteLine(blockWriter.InnerWriter.ToString().TrimEnd(new char[0]));
						}
						indentedTextWriter5.WriteLine("END");
						statements.Add(new global::System.Data.Entity.Migrations.Sql.MigrationStatement
						{
							Sql = indentedTextWriter5.InnerWriter.ToString()
						});
					}
				}
			}
			this._statements = statements;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006AFC File Offset: 0x00004CFC
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MigrationOperation migrationOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MigrationOperation>(migrationOperation, "migrationOperation");
			throw global::System.Data.Entity.SqlServer.Resources.Error.SqlServerMigrationSqlGenerator_UnknownOperation(base.GetType().Name, migrationOperation.GetType().FullName);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006B25 File Offset: 0x00004D25
		protected virtual global::System.Data.Common.DbConnection CreateConnection()
		{
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService("System.Data.SqlClient").CreateConnection();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006B3B File Offset: 0x00004D3B
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateProcedureOperation createProcedureOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateProcedureOperation>(createProcedureOperation, "createProcedureOperation");
			this.Generate(createProcedureOperation, "CREATE");
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00006B55 File Offset: 0x00004D55
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterProcedureOperation alterProcedureOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterProcedureOperation>(alterProcedureOperation, "alterProcedureOperation");
			this.Generate(alterProcedureOperation, "ALTER");
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006B70 File Offset: 0x00004D70
		private void Generate(global::System.Data.Entity.Migrations.Model.ProcedureOperation procedureOperation, string modifier)
		{
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				writer.Write(modifier);
				writer.WriteLine(" PROCEDURE " + this.Name(procedureOperation.Name));
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer5 = writer;
				int indent = writer5.Indent;
				writer5.Indent = indent + 1;
				procedureOperation.Parameters.Each(delegate(global::System.Data.Entity.Migrations.Model.ParameterModel p, int i)
				{
					this.Generate(p, writer);
					writer.WriteLine((i < procedureOperation.Parameters.Count - 1) ? "," : string.Empty);
				});
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
				indent = writer2.Indent;
				writer2.Indent = indent - 1;
				writer.WriteLine("AS");
				writer.WriteLine("BEGIN");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
				indent = writer3.Indent;
				writer3.Indent = indent + 1;
				writer.WriteLine((!string.IsNullOrWhiteSpace(procedureOperation.BodySql)) ? global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Indent(procedureOperation.BodySql, writer.CurrentIndentation()) : "RETURN");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer4 = writer;
				indent = writer4.Indent;
				writer4.Indent = indent - 1;
				writer.Write("END");
				this.Statement(writer, "GO");
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006CF0 File Offset: 0x00004EF0
		private void Generate(global::System.Data.Entity.Migrations.Model.ParameterModel parameterModel, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			writer.Write("@");
			writer.Write(parameterModel.Name);
			writer.Write(" ");
			writer.Write(this.BuildPropertyType(parameterModel));
			if (parameterModel.IsOutParameter)
			{
				writer.Write(" OUT");
			}
			if (parameterModel.DefaultValue != null)
			{
				writer.Write(" = ");
				if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__1 == null)
				{
					global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object> target = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__1;
				if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__0 == null)
				{
					global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, writer, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__0.Target(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__20.<>p__0, this, parameterModel.DefaultValue));
				return;
			}
			if (!string.IsNullOrWhiteSpace(parameterModel.DefaultValueSql))
			{
				writer.Write(" = ");
				writer.Write(parameterModel.DefaultValueSql);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006E30 File Offset: 0x00005030
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropProcedureOperation dropProcedureOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropProcedureOperation>(dropProcedureOperation, "dropProcedureOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("DROP PROCEDURE ");
				indentedTextWriter.Write(this.Name(dropProcedureOperation.Name));
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006E90 File Offset: 0x00005090
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			global::System.Data.Entity.SqlServer.Utilities.DatabaseName databaseName = global::System.Data.Entity.SqlServer.Utilities.DatabaseName.Parse(createTableOperation.Name);
			if (!string.IsNullOrWhiteSpace(databaseName.Schema) && !databaseName.Schema.EqualsIgnoreCase("dbo") && !this._generatedSchemas.Contains(databaseName.Schema))
			{
				this.GenerateCreateSchema(databaseName.Schema);
				this._generatedSchemas.Add(databaseName.Schema);
			}
			this.WriteCreateTable(createTableOperation);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006F0C File Offset: 0x0000510C
		protected virtual void WriteCreateTable(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				this.WriteCreateTable(createTableOperation, indentedTextWriter);
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006F58 File Offset: 0x00005158
		protected virtual void WriteCreateTable(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("CREATE TABLE " + this.Name(createTableOperation.Name) + " (");
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer2 = writer;
			int indent = writer2.Indent;
			writer2.Indent = indent + 1;
			createTableOperation.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c, int i)
			{
				this.Generate(c, writer);
				if (i < createTableOperation.Columns.Count - 1)
				{
					writer.WriteLine(",");
				}
			});
			if (createTableOperation.PrimaryKey != null)
			{
				writer.WriteLine(",");
				writer.Write("CONSTRAINT ");
				writer.Write(this.Quote(createTableOperation.PrimaryKey.Name));
				writer.Write(" PRIMARY KEY ");
				if (!createTableOperation.PrimaryKey.IsClustered)
				{
					writer.Write("NONCLUSTERED ");
				}
				writer.Write("(");
				writer.Write(createTableOperation.PrimaryKey.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				writer.WriteLine(")");
			}
			else
			{
				writer.WriteLine();
			}
			global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer3 = writer;
			indent = writer3.Indent;
			writer3.Indent = indent - 1;
			writer.Write(")");
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007105 File Offset: 0x00005305
		protected internal virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterTableOperation alterTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterTableOperation>(alterTableOperation, "alterTableOperation");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00007114 File Offset: 0x00005314
		protected virtual void GenerateMakeSystemTable(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.WriteLine("BEGIN TRY");
			int indent = writer.Indent;
			writer.Indent = indent + 1;
			writer.WriteLine("EXECUTE sp_MS_marksystemobject '" + global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(createTableOperation.Name) + "'");
			indent = writer.Indent;
			writer.Indent = indent - 1;
			writer.WriteLine("END TRY");
			writer.WriteLine("BEGIN CATCH");
			writer.Write("END CATCH");
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000071A8 File Offset: 0x000053A8
		protected virtual void GenerateCreateSchema(string schema)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(schema, "schema");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("IF schema_id('");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(schema));
				indentedTextWriter.WriteLine("') IS NULL");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = indentedTextWriter;
				int indent = indentedTextWriter2.Indent;
				indentedTextWriter2.Indent = indent + 1;
				indentedTextWriter.Write("EXECUTE('CREATE SCHEMA ");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Quote(schema)));
				indentedTextWriter.Write("')");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007248 File Offset: 0x00005448
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(addForeignKeyOperation, "addForeignKeyOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(addForeignKeyOperation.DependentTable));
				indentedTextWriter.Write(" ADD CONSTRAINT ");
				indentedTextWriter.Write(this.Quote(addForeignKeyOperation.Name));
				indentedTextWriter.Write(" FOREIGN KEY (");
				indentedTextWriter.Write(addForeignKeyOperation.DependentColumns.Select(new global::System.Func<string, string>(this.Quote)).Join(null, ", "));
				indentedTextWriter.Write(") REFERENCES ");
				indentedTextWriter.Write(this.Name(addForeignKeyOperation.PrincipalTable));
				indentedTextWriter.Write(" (");
				indentedTextWriter.Write(addForeignKeyOperation.PrincipalColumns.Select(new global::System.Func<string, string>(this.Quote)).Join(null, ", "));
				indentedTextWriter.Write(")");
				if (addForeignKeyOperation.CascadeDelete)
				{
					indentedTextWriter.Write(" ON DELETE CASCADE");
				}
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007368 File Offset: 0x00005568
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation dropForeignKeyOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation>(dropForeignKeyOperation, "dropForeignKeyOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("IF object_id(N'");
				string schema = global::System.Data.Entity.SqlServer.Utilities.DatabaseName.Parse(dropForeignKeyOperation.DependentTable).Schema;
				if (schema != null)
				{
					indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Quote(schema)));
					indentedTextWriter.Write(".");
				}
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Quote(dropForeignKeyOperation.Name)));
				indentedTextWriter.WriteLine("', N'F') IS NOT NULL");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = indentedTextWriter;
				int indent = indentedTextWriter2.Indent;
				indentedTextWriter2.Indent = indent + 1;
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(dropForeignKeyOperation.DependentTable));
				indentedTextWriter.Write(" DROP CONSTRAINT ");
				indentedTextWriter.Write(this.Quote(dropForeignKeyOperation.Name));
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter3 = indentedTextWriter;
				indent = indentedTextWriter3.Indent;
				indentedTextWriter3.Indent = indent - 1;
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007464 File Offset: 0x00005664
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(createIndexOperation, "createIndexOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("CREATE ");
				if (createIndexOperation.IsUnique)
				{
					indentedTextWriter.Write("UNIQUE ");
				}
				if (createIndexOperation.IsClustered)
				{
					indentedTextWriter.Write("CLUSTERED ");
				}
				indentedTextWriter.Write("INDEX ");
				indentedTextWriter.Write(this.Quote(createIndexOperation.Name));
				indentedTextWriter.Write(" ON ");
				indentedTextWriter.Write(this.Name(createIndexOperation.Table));
				indentedTextWriter.Write("(");
				indentedTextWriter.Write(createIndexOperation.Columns.Join(new global::System.Func<string, string>(this.Quote), ", "));
				indentedTextWriter.Write(")");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000754C File Offset: 0x0000574C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropIndexOperation dropIndexOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropIndexOperation>(dropIndexOperation, "dropIndexOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("IF EXISTS (SELECT name FROM sys.indexes WHERE name = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(dropIndexOperation.Name));
				indentedTextWriter.Write("' AND object_id = object_id(N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Name(dropIndexOperation.Table)));
				indentedTextWriter.WriteLine("', N'U'))");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = indentedTextWriter;
				int indent = indentedTextWriter2.Indent;
				indentedTextWriter2.Indent = indent + 1;
				indentedTextWriter.Write("DROP INDEX ");
				indentedTextWriter.Write(this.Quote(dropIndexOperation.Name));
				indentedTextWriter.Write(" ON ");
				indentedTextWriter.Write(this.Name(dropIndexOperation.Table));
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter3 = indentedTextWriter;
				indent = indentedTextWriter3.Indent;
				indentedTextWriter3.Indent = indent - 1;
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007634 File Offset: 0x00005834
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation>(addPrimaryKeyOperation, "addPrimaryKeyOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(addPrimaryKeyOperation.Table));
				indentedTextWriter.Write(" ADD CONSTRAINT ");
				indentedTextWriter.Write(this.Quote(addPrimaryKeyOperation.Name));
				indentedTextWriter.Write(" PRIMARY KEY ");
				if (!addPrimaryKeyOperation.IsClustered)
				{
					indentedTextWriter.Write("NONCLUSTERED ");
				}
				indentedTextWriter.Write("(");
				indentedTextWriter.Write(addPrimaryKeyOperation.Columns.Select(new global::System.Func<string, string>(this.Quote)).Join(null, ", "));
				indentedTextWriter.Write(")");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007710 File Offset: 0x00005910
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation>(dropPrimaryKeyOperation, "dropPrimaryKeyOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(dropPrimaryKeyOperation.Table));
				indentedTextWriter.Write(" DROP CONSTRAINT ");
				indentedTextWriter.Write(this.Quote(dropPrimaryKeyOperation.Name));
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007790 File Offset: 0x00005990
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddColumnOperation>(addColumnOperation, "addColumnOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(addColumnOperation.Table));
				indentedTextWriter.Write(" ADD ");
				global::System.Data.Entity.Migrations.Model.ColumnModel column = addColumnOperation.Column;
				this.Generate(column, indentedTextWriter);
				if (column.IsNullable != null && !column.IsNullable.Value && column.DefaultValue == null && string.IsNullOrWhiteSpace(column.DefaultValueSql) && !column.IsIdentity && !column.IsTimestamp && !column.StoreType.EqualsIgnoreCase("rowversion") && !column.StoreType.EqualsIgnoreCase("timestamp"))
				{
					indentedTextWriter.Write(" DEFAULT ");
					if (column.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.DateTime)
					{
						indentedTextWriter.Write(this.Generate(global::System.DateTime.Parse("1900-01-01 00:00:00", global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					else
					{
						if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__1 == null)
						{
							global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
							}));
						}
						global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object> target = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__1.Target;
						global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__1;
						global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter arg = indentedTextWriter;
						if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__0 == null)
						{
							global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(<>p__, arg, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__0.Target(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__34.<>p__0, this, column.ClrDefaultValue));
					}
				}
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007984 File Offset: 0x00005B84
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropColumnOperation dropColumnOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropColumnOperation>(dropColumnOperation, "dropColumnOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				this.DropDefaultConstraint(dropColumnOperation.Table, dropColumnOperation.Name, indentedTextWriter);
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(dropColumnOperation.Table));
				indentedTextWriter.Write(" DROP COLUMN ");
				indentedTextWriter.Write(this.Quote(dropColumnOperation.Name));
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00007A14 File Offset: 0x00005C14
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.AlterColumnOperation alterColumnOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AlterColumnOperation>(alterColumnOperation, "alterColumnOperation");
			global::System.Data.Entity.Migrations.Model.ColumnModel column = alterColumnOperation.Column;
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				this.DropDefaultConstraint(alterColumnOperation.Table, column.Name, indentedTextWriter);
				indentedTextWriter.Write("ALTER TABLE ");
				indentedTextWriter.Write(this.Name(alterColumnOperation.Table));
				indentedTextWriter.Write(" ALTER COLUMN ");
				indentedTextWriter.Write(this.Quote(column.Name));
				indentedTextWriter.Write(" ");
				indentedTextWriter.Write(this.BuildColumnType(column));
				if (column.IsNullable != null && !column.IsNullable.Value)
				{
					indentedTextWriter.Write(" NOT");
				}
				indentedTextWriter.Write(" NULL");
				if (column.DefaultValue != null || !string.IsNullOrWhiteSpace(column.DefaultValueSql))
				{
					indentedTextWriter.WriteLine();
					indentedTextWriter.Write("ALTER TABLE ");
					indentedTextWriter.Write(this.Name(alterColumnOperation.Table));
					indentedTextWriter.Write(" ADD CONSTRAINT ");
					indentedTextWriter.Write(this.Quote("DF_" + alterColumnOperation.Table + "_" + column.Name));
					indentedTextWriter.Write(" DEFAULT ");
					if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__1 == null)
					{
						global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
						{
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
							global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
						}));
					}
					global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object> target = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__1.Target;
					global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__1;
					global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter arg = indentedTextWriter;
					object arg2;
					if (column.DefaultValue == null)
					{
						arg2 = column.DefaultValueSql;
					}
					else
					{
						if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__0 == null)
						{
							global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
							}));
						}
						arg2 = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__0.Target(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__36.<>p__0, this, column.DefaultValue);
					}
					target(<>p__, arg, arg2);
					indentedTextWriter.Write(" FOR ");
					indentedTextWriter.Write(this.Quote(column.Name));
				}
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00007C60 File Offset: 0x00005E60
		protected internal virtual void DropDefaultConstraint(string table, string column, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(column, "column");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			string str = "@var";
			int num = this._variableCounter;
			this._variableCounter = num + 1;
			string value = str + num.ToString();
			writer.Write("DECLARE ");
			writer.Write(value);
			writer.WriteLine(" nvarchar(128)");
			writer.Write("SELECT ");
			writer.Write(value);
			writer.WriteLine(" = name");
			writer.WriteLine("FROM sys.default_constraints");
			writer.Write("WHERE parent_object_id = object_id(N'");
			writer.Write(table);
			writer.WriteLine("')");
			writer.Write("AND col_name(parent_object_id, parent_column_id) = '");
			writer.Write(column);
			writer.WriteLine("';");
			writer.Write("IF ");
			writer.Write(value);
			writer.WriteLine(" IS NOT NULL");
			num = writer.Indent;
			writer.Indent = num + 1;
			writer.Write("EXECUTE('ALTER TABLE ");
			writer.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Name(table)));
			writer.Write(" DROP CONSTRAINT [' + ");
			writer.Write(value);
			writer.WriteLine(" + ']')");
			num = writer.Indent;
			writer.Indent = num - 1;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007DAC File Offset: 0x00005FAC
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.DropTableOperation dropTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.DropTableOperation>(dropTableOperation, "dropTableOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("DROP TABLE ");
				indentedTextWriter.Write(this.Name(dropTableOperation.Name));
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007E0C File Offset: 0x0000600C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.SqlOperation sqlOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.SqlOperation>(sqlOperation, "sqlOperation");
			this.StatementBatch(sqlOperation.Sql, sqlOperation.SuppressTransaction);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007E2C File Offset: 0x0000602C
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameColumnOperation renameColumnOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameColumnOperation>(renameColumnOperation, "renameColumnOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("EXECUTE sp_rename @objname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameColumnOperation.Table));
				indentedTextWriter.Write(".");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameColumnOperation.Name));
				indentedTextWriter.Write("', @newname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameColumnOperation.NewName));
				indentedTextWriter.Write("', @objtype = N'COLUMN'");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007ED0 File Offset: 0x000060D0
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameIndexOperation renameIndexOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameIndexOperation>(renameIndexOperation, "renameIndexOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("EXECUTE sp_rename @objname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameIndexOperation.Table));
				indentedTextWriter.Write(".");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameIndexOperation.Name));
				indentedTextWriter.Write("', @newname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameIndexOperation.NewName));
				indentedTextWriter.Write("', @objtype = N'INDEX'");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007F74 File Offset: 0x00006174
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameTableOperation renameTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameTableOperation>(renameTableOperation, "renameTableOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.WriteRenameTable(renameTableOperation, indentedTextWriter);
				string identifier = global::System.Data.Entity.Migrations.Model.PrimaryKeyOperation.BuildDefaultName(renameTableOperation.Name);
				string s = global::System.Data.Entity.Migrations.Model.PrimaryKeyOperation.BuildDefaultName(((global::System.Data.Entity.Migrations.Model.RenameTableOperation)renameTableOperation.Inverse).Name);
				indentedTextWriter.WriteLine();
				indentedTextWriter.Write("IF object_id('");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Quote(identifier)));
				indentedTextWriter.WriteLine("') IS NOT NULL BEGIN");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = indentedTextWriter;
				int indent = indentedTextWriter2.Indent;
				indentedTextWriter2.Indent = indent + 1;
				indentedTextWriter.Write("EXECUTE sp_rename @objname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(this.Quote(identifier)));
				indentedTextWriter.Write("', @newname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(s));
				indentedTextWriter.WriteLine("', @objtype = N'OBJECT'");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter3 = indentedTextWriter;
				indent = indentedTextWriter3.Indent;
				indentedTextWriter3.Indent = indent - 1;
				indentedTextWriter.Write("END");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00008078 File Offset: 0x00006278
		private static void WriteRenameTable(global::System.Data.Entity.Migrations.Model.RenameTableOperation renameTableOperation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			writer.Write("EXECUTE sp_rename @objname = N'");
			writer.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameTableOperation.Name));
			writer.Write("', @newname = N'");
			writer.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameTableOperation.NewName));
			writer.Write("', @objtype = N'OBJECT'");
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000080C8 File Offset: 0x000062C8
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.RenameProcedureOperation renameProcedureOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.RenameProcedureOperation>(renameProcedureOperation, "renameProcedureOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("EXECUTE sp_rename @objname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameProcedureOperation.Name));
				indentedTextWriter.Write("', @newname = N'");
				indentedTextWriter.Write(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Escape(renameProcedureOperation.NewName));
				indentedTextWriter.Write("', @objtype = N'OBJECT'");
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008150 File Offset: 0x00006350
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveProcedureOperation moveProcedureOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveProcedureOperation>(moveProcedureOperation, "moveProcedureOperation");
			string text = moveProcedureOperation.NewSchema ?? "dbo";
			if (!text.EqualsIgnoreCase("dbo") && !this._generatedSchemas.Contains(text))
			{
				this.GenerateCreateSchema(text);
				this._generatedSchemas.Add(text);
			}
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter.Write("ALTER SCHEMA ");
				indentedTextWriter.Write(this.Quote(text));
				indentedTextWriter.Write(" TRANSFER ");
				indentedTextWriter.Write(this.Name(moveProcedureOperation.Name));
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008208 File Offset: 0x00006408
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.MoveTableOperation moveTableOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MoveTableOperation>(moveTableOperation, "moveTableOperation");
			string text = moveTableOperation.NewSchema ?? "dbo";
			if (!text.EqualsIgnoreCase("dbo") && !this._generatedSchemas.Contains(text))
			{
				this.GenerateCreateSchema(text);
				this._generatedSchemas.Add(text);
			}
			if (!moveTableOperation.IsSystem)
			{
				using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
				{
					indentedTextWriter.Write("ALTER SCHEMA ");
					indentedTextWriter.Write(this.Quote(text));
					indentedTextWriter.Write(" TRANSFER ");
					indentedTextWriter.Write(this.Name(moveTableOperation.Name));
					this.Statement(indentedTextWriter, null);
					return;
				}
			}
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter2 = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				indentedTextWriter2.Write("IF object_id('");
				indentedTextWriter2.Write(moveTableOperation.CreateTableOperation.Name);
				indentedTextWriter2.WriteLine("') IS NULL BEGIN");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter3 = indentedTextWriter2;
				int indent = indentedTextWriter3.Indent;
				indentedTextWriter3.Indent = indent + 1;
				this.WriteCreateTable(moveTableOperation.CreateTableOperation, indentedTextWriter2);
				indentedTextWriter2.WriteLine();
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter4 = indentedTextWriter2;
				indent = indentedTextWriter4.Indent;
				indentedTextWriter4.Indent = indent - 1;
				indentedTextWriter2.WriteLine("END");
				indentedTextWriter2.Write("INSERT INTO ");
				indentedTextWriter2.WriteLine(this.Name(moveTableOperation.CreateTableOperation.Name));
				indentedTextWriter2.Write("SELECT * FROM ");
				indentedTextWriter2.WriteLine(this.Name(moveTableOperation.Name));
				indentedTextWriter2.Write("WHERE [ContextKey] = ");
				indentedTextWriter2.WriteLine(this.Generate(moveTableOperation.ContextKey));
				indentedTextWriter2.Write("DELETE ");
				indentedTextWriter2.WriteLine(this.Name(moveTableOperation.Name));
				indentedTextWriter2.Write("WHERE [ContextKey] = ");
				indentedTextWriter2.WriteLine(this.Generate(moveTableOperation.ContextKey));
				indentedTextWriter2.Write("IF NOT EXISTS(SELECT * FROM ");
				indentedTextWriter2.Write(this.Name(moveTableOperation.Name));
				indentedTextWriter2.WriteLine(")");
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter5 = indentedTextWriter2;
				indent = indentedTextWriter5.Indent;
				indentedTextWriter5.Indent = indent + 1;
				indentedTextWriter2.Write("DROP TABLE ");
				indentedTextWriter2.Write(this.Name(moveTableOperation.Name));
				global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter6 = indentedTextWriter2;
				indent = indentedTextWriter6.Indent;
				indentedTextWriter6.Indent = indent - 1;
				this.Statement(indentedTextWriter2, null);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00008468 File Offset: 0x00006668
		protected internal virtual void Generate(global::System.Data.Entity.Migrations.Model.ColumnModel column, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(column, "column");
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			writer.Write(this.Quote(column.Name));
			writer.Write(" ");
			writer.Write(this.BuildColumnType(column));
			if (column.IsNullable != null && !column.IsNullable.Value)
			{
				writer.Write(" NOT NULL");
			}
			if (column.DefaultValue != null)
			{
				writer.Write(" DEFAULT ");
				if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__1 == null)
				{
					global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__1 = global::System.Runtime.CompilerServices.CallSite<global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ResultDiscarded, "Write", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				global::System.Action<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter, object> target = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__1.Target;
				global::System.Runtime.CompilerServices.CallSite <>p__ = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__1;
				if (global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__0 == null)
				{
					global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__0 = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.InvokeSimpleName, "Generate", null, typeof(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
					{
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
						global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, writer, global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__0.Target(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.<>o__47.<>p__0, this, column.DefaultValue));
				return;
			}
			if (!string.IsNullOrWhiteSpace(column.DefaultValueSql))
			{
				writer.Write(" DEFAULT ");
				writer.Write(column.DefaultValueSql);
				return;
			}
			if (column.IsIdentity)
			{
				if (column.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Guid && column.DefaultValue == null)
				{
					writer.Write(" DEFAULT " + this.GuidColumnDefault);
					return;
				}
				writer.Write(" IDENTITY");
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000860F File Offset: 0x0000680F
		protected virtual string GuidColumnDefault
		{
			get
			{
				if (!(this._providerManifestToken != "2012.Azure") || !(this._providerManifestToken != "2000"))
				{
					return "newid()";
				}
				return "newsequentialid()";
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00008640 File Offset: 0x00006840
		protected virtual void Generate(global::System.Data.Entity.Migrations.Model.HistoryOperation historyOperation)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.HistoryOperation>(historyOperation, "historyOperation");
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				historyOperation.CommandTrees.Each(delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree commandTree)
				{
					global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind commandTreeKind = commandTree.CommandTreeKind;
					global::System.Collections.Generic.List<global::System.Data.SqlClient.SqlParameter> list;
					if (commandTreeKind == global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert)
					{
						writer.Write(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateInsertSql((global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)commandTree, this._sqlGenerator, out list, false, true, false));
						return;
					}
					if (commandTreeKind != global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete)
					{
						return;
					}
					writer.Write(global::System.Data.Entity.SqlServer.SqlGen.DmlSqlGenerator.GenerateDeleteSql((global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree)commandTree, this._sqlGenerator, out list, true, false));
				});
				this.Statement(writer, null);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000086BC File Offset: 0x000068BC
		protected virtual string Generate(byte[] defaultValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<byte[]>(defaultValue, "defaultValue");
			return "0x" + defaultValue.ToHexString();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000086DA File Offset: 0x000068DA
		protected virtual string Generate(bool defaultValue)
		{
			if (!defaultValue)
			{
				return "0";
			}
			return "1";
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000086EA File Offset: 0x000068EA
		protected virtual string Generate(global::System.DateTime defaultValue)
		{
			return "'" + defaultValue.ToString("yyyy-MM-ddTHH:mm:ss.fffK", global::System.Globalization.CultureInfo.InvariantCulture) + "'";
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000870C File Offset: 0x0000690C
		protected virtual string Generate(global::System.DateTimeOffset defaultValue)
		{
			return "'" + defaultValue.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz", global::System.Globalization.CultureInfo.InvariantCulture) + "'";
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00008730 File Offset: 0x00006930
		protected virtual string Generate(global::System.Guid defaultValue)
		{
			string str = "'";
			global::System.Guid guid = defaultValue;
			return str + guid.ToString() + "'";
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000875B File Offset: 0x0000695B
		protected virtual string Generate(string defaultValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<string>(defaultValue, "defaultValue");
			return "'" + defaultValue + "'";
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000877C File Offset: 0x0000697C
		protected virtual string Generate(global::System.TimeSpan defaultValue)
		{
			string str = "'";
			global::System.TimeSpan timeSpan = defaultValue;
			return str + timeSpan.ToString() + "'";
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000087A7 File Offset: 0x000069A7
		protected virtual string Generate(global::System.Data.Entity.Hierarchy.HierarchyId defaultValue)
		{
			return "cast('" + ((defaultValue != null) ? defaultValue.ToString() : null) + "' as hierarchyid)";
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000087C5 File Offset: 0x000069C5
		protected virtual string Generate(global::System.Data.Entity.Spatial.DbGeography defaultValue)
		{
			return "'" + ((defaultValue != null) ? defaultValue.ToString() : null) + "'";
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000087E3 File Offset: 0x000069E3
		protected virtual string Generate(global::System.Data.Entity.Spatial.DbGeometry defaultValue)
		{
			return "'" + ((defaultValue != null) ? defaultValue.ToString() : null) + "'";
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008801 File Offset: 0x00006A01
		protected virtual string Generate(object defaultValue)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<object>(defaultValue, "defaultValue");
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				defaultValue
			});
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00008828 File Offset: 0x00006A28
		protected virtual string BuildColumnType(global::System.Data.Entity.Migrations.Model.ColumnModel columnModel)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.ColumnModel>(columnModel, "columnModel");
			if (columnModel.IsTimestamp)
			{
				return "rowversion";
			}
			return this.BuildPropertyType(columnModel);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000884C File Offset: 0x00006A4C
		private string BuildPropertyType(global::System.Data.Entity.Migrations.Model.PropertyModel propertyModel)
		{
			string text = propertyModel.StoreType;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = base.ProviderManifest.GetStoreType(propertyModel.TypeUsage);
			if (string.IsNullOrWhiteSpace(text))
			{
				text = typeUsage.EdmType.Name;
			}
			else
			{
				typeUsage = (this.BuildStoreTypeUsage(text, propertyModel) ?? typeUsage);
			}
			string text2 = text;
			if (text2.EndsWith("(max)", global::System.StringComparison.Ordinal))
			{
				text2 = this.Quote(text2.Substring(0, text2.Length - "(max)".Length)) + "(max)";
			}
			else
			{
				text2 = this.Quote(text2);
			}
			if (text != null)
			{
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
				if (num <= 1761125480U)
				{
					if (num <= 923440646U)
					{
						if (num != 520654156U)
						{
							if (num != 923440646U)
							{
								return text2;
							}
							if (!(text == "datetime2"))
							{
								return text2;
							}
							goto IL_298;
						}
						else if (!(text == "decimal"))
						{
							return text2;
						}
					}
					else if (num != 1539863742U)
					{
						if (num != 1564253156U)
						{
							if (num != 1761125480U)
							{
								return text2;
							}
							if (!(text == "numeric"))
							{
								return text2;
							}
						}
						else
						{
							if (!(text == "time"))
							{
								return text2;
							}
							goto IL_298;
						}
					}
					else
					{
						if (!(text == "nvarchar"))
						{
							return text2;
						}
						goto IL_2D4;
					}
					return string.Concat(new string[]
					{
						text2,
						"(",
						(propertyModel.Precision ?? typeUsage.GetPrecision()).ToString(),
						", ",
						(propertyModel.Scale ?? typeUsage.GetScale()).ToString(),
						")"
					});
				}
				if (num <= 3347933383U)
				{
					if (num != 2336348659U)
					{
						if (num != 2823553821U)
						{
							if (num != 3347933383U)
							{
								return text2;
							}
							if (!(text == "varbinary"))
							{
								return text2;
							}
							goto IL_2D4;
						}
						else
						{
							if (!(text == "char"))
							{
								return text2;
							}
							goto IL_2D4;
						}
					}
					else if (!(text == "datetimeoffset"))
					{
						return text2;
					}
				}
				else if (num != 3716508924U)
				{
					if (num != 3761451113U)
					{
						if (num != 4163743794U)
						{
							return text2;
						}
						if (!(text == "varchar"))
						{
							return text2;
						}
						goto IL_2D4;
					}
					else
					{
						if (!(text == "nchar"))
						{
							return text2;
						}
						goto IL_2D4;
					}
				}
				else
				{
					if (!(text == "binary"))
					{
						return text2;
					}
					goto IL_2D4;
				}
				IL_298:
				return text2 + "(" + (propertyModel.Precision ?? typeUsage.GetPrecision()).ToString() + ")";
				IL_2D4:
				text2 = text2 + "(" + (propertyModel.MaxLength ?? typeUsage.GetMaxLength()).ToString() + ")";
			}
			return text2;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008B68 File Offset: 0x00006D68
		protected virtual string Name(string name)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.SqlServer.Utilities.DatabaseName databaseName = global::System.Data.Entity.SqlServer.Utilities.DatabaseName.Parse(name);
			return new string[]
			{
				databaseName.Schema,
				databaseName.Name
			}.Join(new global::System.Func<string, string>(this.Quote), ".");
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008BB7 File Offset: 0x00006DB7
		protected virtual string Quote(string identifier)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(identifier, "identifier");
			return global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator.QuoteIdentifier(identifier);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008BCB File Offset: 0x00006DCB
		private static string Escape(string s)
		{
			return s.Replace("'", "''");
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008BDD File Offset: 0x00006DDD
		private static string Indent(string s, string indentation)
		{
			return new global::System.Text.RegularExpressions.Regex("\\r?\\n *").Replace(s, global::System.Environment.NewLine + indentation);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008BFA File Offset: 0x00006DFA
		protected void Statement(string sql, bool suppressTransaction = false, string batchTerminator = null)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotEmpty(sql, "sql");
			this._statements.Add(new global::System.Data.Entity.Migrations.Sql.MigrationStatement
			{
				Sql = sql,
				SuppressTransaction = suppressTransaction,
				BatchTerminator = batchTerminator
			});
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008C2D File Offset: 0x00006E2D
		protected static global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter Writer()
		{
			return new global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter(new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008C3E File Offset: 0x00006E3E
		protected void Statement(global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer, string batchTerminator = null)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter>(writer, "writer");
			this.Statement(writer.InnerWriter.ToString(), false, batchTerminator);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008C60 File Offset: 0x00006E60
		protected void StatementBatch(string sqlBatch, bool suppressTransaction = false)
		{
			global::System.Data.Entity.SqlServer.Utilities.Check.NotNull<string>(sqlBatch, "sqlBatch");
			sqlBatch = global::System.Text.RegularExpressions.Regex.Replace(sqlBatch, "\\\\(\\r\\n|\\r|\\n)", "");
			string[] array = global::System.Text.RegularExpressions.Regex.Split(sqlBatch, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "^\\s*({0}[ \\t]+[0-9]+|{0})(?:\\s+|$)", new object[]
			{
				"GO"
			}), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase | global::System.Text.RegularExpressions.RegexOptions.Multiline);
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].StartsWith("GO", global::System.StringComparison.OrdinalIgnoreCase) && (i != array.Length - 1 || !string.IsNullOrWhiteSpace(array[i])))
				{
					if (array.Length > i + 1 && array[i + 1].StartsWith("GO", global::System.StringComparison.OrdinalIgnoreCase))
					{
						int num = 1;
						if (!array[i + 1].EqualsIgnoreCase("GO"))
						{
							num = int.Parse(global::System.Text.RegularExpressions.Regex.Match(array[i + 1], "([0-9]+)").Value, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						for (int j = 0; j < num; j++)
						{
							this.Statement(array[i], suppressTransaction, "GO");
						}
					}
					else
					{
						this.Statement(array[i], suppressTransaction, null);
					}
				}
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008D5D File Offset: 0x00006F5D
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> DetectHistoryRebuild(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Migrations.Model.MigrationOperation> enumerator = operations.GetEnumerator();
			while (enumerator.MoveNext())
			{
				global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.HistoryRebuildOperationSequence historyRebuildOperationSequence = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.HistoryRebuildOperationSequence.Detect(enumerator);
				yield return historyRebuildOperationSequence ?? enumerator.Current;
			}
			yield break;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008D70 File Offset: 0x00006F70
		private void Generate(global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.HistoryRebuildOperationSequence sequence)
		{
			global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = sequence.DropPrimaryKeyOperation.CreateTableOperation;
			global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation2 = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.ResolveNameConflicts(createTableOperation);
			global::System.Data.Entity.Migrations.Model.RenameTableOperation renameTableOperation = new global::System.Data.Entity.Migrations.Model.RenameTableOperation(createTableOperation2.Name, "__MigrationHistory", null);
			using (global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter indentedTextWriter = global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.Writer())
			{
				this.WriteCreateTable(createTableOperation2, indentedTextWriter);
				indentedTextWriter.WriteLine();
				indentedTextWriter.Write("INSERT INTO ");
				indentedTextWriter.WriteLine(this.Name(createTableOperation2.Name));
				indentedTextWriter.Write("SELECT ");
				bool flag = true;
				foreach (global::System.Data.Entity.Migrations.Model.ColumnModel columnModel in createTableOperation.Columns)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						indentedTextWriter.Write(", ");
					}
					indentedTextWriter.Write((columnModel.Name == sequence.AddColumnOperation.Column.Name) ? this.Generate((string)sequence.AddColumnOperation.Column.DefaultValue) : ((columnModel.Type == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String) ? string.Concat(new string[]
					{
						"LEFT(",
						this.Name(columnModel.Name),
						", ",
						columnModel.MaxLength.ToString(),
						")"
					}) : this.Name(columnModel.Name)));
				}
				indentedTextWriter.Write(" FROM ");
				indentedTextWriter.WriteLine(this.Name(createTableOperation.Name));
				indentedTextWriter.Write("DROP TABLE ");
				indentedTextWriter.WriteLine(this.Name(createTableOperation.Name));
				global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.WriteRenameTable(renameTableOperation, indentedTextWriter);
				this.Statement(indentedTextWriter, null);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008F5C File Offset: 0x0000715C
		private static global::System.Data.Entity.Migrations.Model.CreateTableOperation ResolveNameConflicts(global::System.Data.Entity.Migrations.Model.CreateTableOperation source)
		{
			global::System.Data.Entity.Migrations.Model.CreateTableOperation target = new global::System.Data.Entity.Migrations.Model.CreateTableOperation(source.Name + "2", null)
			{
				PrimaryKey = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(null)
				{
					IsClustered = source.PrimaryKey.IsClustered
				}
			};
			source.Columns.Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				target.Columns.Add(c);
			});
			source.PrimaryKey.Columns.Each(delegate(string c)
			{
				target.PrimaryKey.Columns.Add(c);
			});
			return target;
		}

		// Token: 0x0400001E RID: 30
		private const string BatchTerminator = "GO";

		// Token: 0x0400001F RID: 31
		internal const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffK";

		// Token: 0x04000020 RID: 32
		internal const string DateTimeOffsetFormat = "yyyy-MM-ddTHH:mm:ss.fffzzz";

		// Token: 0x04000021 RID: 33
		private global::System.Data.Entity.SqlServer.SqlGen.SqlGenerator _sqlGenerator;

		// Token: 0x04000022 RID: 34
		private global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Sql.MigrationStatement> _statements;

		// Token: 0x04000023 RID: 35
		private global::System.Collections.Generic.HashSet<string> _generatedSchemas;

		// Token: 0x04000024 RID: 36
		private string _providerManifestToken;

		// Token: 0x04000025 RID: 37
		private int _variableCounter;

		// Token: 0x02000057 RID: 87
		private class HistoryRebuildOperationSequence : global::System.Data.Entity.Migrations.Model.MigrationOperation
		{
			// Token: 0x06000643 RID: 1603 RVA: 0x0001AED8 File Offset: 0x000190D8
			private HistoryRebuildOperationSequence(global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation, global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation) : base(null)
			{
				this.AddColumnOperation = addColumnOperation;
				this.DropPrimaryKeyOperation = dropPrimaryKeyOperation;
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001AEEF File Offset: 0x000190EF
			public override bool IsDestructiveChange
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x0001AEF4 File Offset: 0x000190F4
			public static global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.HistoryRebuildOperationSequence Detect(global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Migrations.Model.MigrationOperation> enumerator)
			{
				global::System.Data.Entity.Migrations.Model.AddColumnOperation addColumnOperation = enumerator.Current as global::System.Data.Entity.Migrations.Model.AddColumnOperation;
				if (addColumnOperation == null || addColumnOperation.Table != "dbo.__MigrationHistory" || addColumnOperation.Column.Name != "ContextKey")
				{
					return null;
				}
				enumerator.MoveNext();
				global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation = (global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation)enumerator.Current;
				enumerator.MoveNext();
				global::System.Data.Entity.Migrations.Model.AlterColumnOperation alterColumnOperation = (global::System.Data.Entity.Migrations.Model.AlterColumnOperation)enumerator.Current;
				enumerator.MoveNext();
				global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = (global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation)enumerator.Current;
				return new global::System.Data.Entity.SqlServer.SqlServerMigrationSqlGenerator.HistoryRebuildOperationSequence(addColumnOperation, dropPrimaryKeyOperation);
			}

			// Token: 0x04000191 RID: 401
			public readonly global::System.Data.Entity.Migrations.Model.AddColumnOperation AddColumnOperation;

			// Token: 0x04000192 RID: 402
			public readonly global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation DropPrimaryKeyOperation;
		}
	}
}
