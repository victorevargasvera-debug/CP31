using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.SqlServer.Utilities;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x0200000C RID: 12
	internal sealed class SqlDdlBuilder
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000026A0 File Offset: 0x000008A0
		internal static string CreateObjectsScript(global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection itemCollection, bool createSchemas)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in itemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>())
			{
				global::System.Linq.IOrderedEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> source = from s in entityContainer.BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>()
				orderby s.Name
				select s;
				if (createSchemas)
				{
					foreach (string text in from s in new global::System.Collections.Generic.HashSet<string>(from s in source
					select global::System.Data.Entity.SqlServer.SqlDdlBuilder.GetSchemaName(s))
					orderby s
					select s)
					{
						if (text != "dbo")
						{
							sqlDdlBuilder.AppendCreateSchema(text);
						}
					}
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet in from s in entityContainer.BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>()
				orderby s.Name
				select s)
				{
					sqlDdlBuilder.AppendCreateTable(entitySet);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in from s in entityContainer.BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>()
				orderby s.Name
				select s)
				{
					sqlDdlBuilder.AppendCreateForeignKeys(associationSet);
				}
			}
			return sqlDdlBuilder.GetCommandText();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000028D0 File Offset: 0x00000AD0
		internal static string CreateDatabaseScript(string databaseName, string dataFileName, string logFileName)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("create database ");
			sqlDdlBuilder.AppendIdentifier(databaseName);
			if (dataFileName != null)
			{
				sqlDdlBuilder.AppendSql(" on primary ");
				sqlDdlBuilder.AppendFileName(dataFileName);
				sqlDdlBuilder.AppendSql(" log on ");
				sqlDdlBuilder.AppendFileName(logFileName);
			}
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002927 File Offset: 0x00000B27
		internal static string SetDatabaseOptionsScript(global::System.Data.Entity.SqlServer.SqlVersion sqlVersion, string databaseName)
		{
			if (sqlVersion < global::System.Data.Entity.SqlServer.SqlVersion.Sql9)
			{
				return string.Empty;
			}
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("if serverproperty('EngineEdition') <> 5 execute sp_executesql ");
			sqlDdlBuilder.AppendStringLiteral(global::System.Data.Entity.SqlServer.SqlDdlBuilder.SetReadCommittedSnapshotScript(databaseName));
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000295A File Offset: 0x00000B5A
		private static string SetReadCommittedSnapshotScript(string databaseName)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("alter database ");
			sqlDdlBuilder.AppendIdentifier(databaseName);
			sqlDdlBuilder.AppendSql(" set read_committed_snapshot on");
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002988 File Offset: 0x00000B88
		internal static string CreateDatabaseExistsScript(string databaseName)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("IF db_id(");
			sqlDdlBuilder.AppendStringLiteral(databaseName);
			sqlDdlBuilder.AppendSql(") IS NOT NULL SELECT 1 ELSE SELECT Count(*) FROM sys.databases WHERE [name]=");
			sqlDdlBuilder.AppendStringLiteral(databaseName);
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000029BD File Offset: 0x00000BBD
		private static void AppendSysDatabases(global::System.Data.Entity.SqlServer.SqlDdlBuilder builder, bool useDeprecatedSystemTable)
		{
			if (useDeprecatedSystemTable)
			{
				builder.AppendSql("sysdatabases");
				return;
			}
			builder.AppendSql("sys.databases");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000029DC File Offset: 0x00000BDC
		internal static string CreateGetDatabaseNamesBasedOnFileNameScript(string databaseFileName, bool useDeprecatedSystemTable)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("SELECT [d].[name] FROM ");
			global::System.Data.Entity.SqlServer.SqlDdlBuilder.AppendSysDatabases(sqlDdlBuilder, useDeprecatedSystemTable);
			sqlDdlBuilder.AppendSql(" AS [d] ");
			if (!useDeprecatedSystemTable)
			{
				sqlDdlBuilder.AppendSql("INNER JOIN sys.master_files AS [f] ON [f].[database_id] = [d].[database_id]");
			}
			sqlDdlBuilder.AppendSql(" WHERE [");
			if (useDeprecatedSystemTable)
			{
				sqlDdlBuilder.AppendSql("filename");
			}
			else
			{
				sqlDdlBuilder.AppendSql("f].[physical_name");
			}
			sqlDdlBuilder.AppendSql("]=");
			sqlDdlBuilder.AppendStringLiteral(databaseFileName);
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002A60 File Offset: 0x00000C60
		internal static string CreateCountDatabasesBasedOnFileNameScript(string databaseFileName, bool useDeprecatedSystemTable)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("SELECT Count(*) FROM ");
			if (useDeprecatedSystemTable)
			{
				sqlDdlBuilder.AppendSql("sysdatabases");
			}
			if (!useDeprecatedSystemTable)
			{
				sqlDdlBuilder.AppendSql("sys.master_files");
			}
			sqlDdlBuilder.AppendSql(" WHERE [");
			if (useDeprecatedSystemTable)
			{
				sqlDdlBuilder.AppendSql("filename");
			}
			else
			{
				sqlDdlBuilder.AppendSql("physical_name");
			}
			sqlDdlBuilder.AppendSql("]=");
			sqlDdlBuilder.AppendStringLiteral(databaseFileName);
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002ADD File Offset: 0x00000CDD
		internal static string DropDatabaseScript(string databaseName)
		{
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("drop database ");
			sqlDdlBuilder.AppendIdentifier(databaseName);
			return sqlDdlBuilder.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002B00 File Offset: 0x00000D00
		internal string GetCommandText()
		{
			return this.unencodedStringBuilder.ToString();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B0D File Offset: 0x00000D0D
		internal static string GetSchemaName(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return entitySet.GetMetadataPropertyValue("Schema") ?? entitySet.EntityContainer.Name;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002B29 File Offset: 0x00000D29
		internal static string GetTableName(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return entitySet.GetMetadataPropertyValue("Table") ?? entitySet.Name;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002B40 File Offset: 0x00000D40
		private void AppendCreateForeignKeys(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint = associationSet.ElementType.ReferentialConstraints.Single<global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint>();
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd = associationSet.AssociationSetEnds[referentialConstraint.FromRole.Name];
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSetEnd associationSetEnd2 = associationSet.AssociationSetEnds[referentialConstraint.ToRole.Name];
			if (this.ignoredEntitySets.Contains(associationSetEnd.EntitySet) || this.ignoredEntitySets.Contains(associationSetEnd2.EntitySet))
			{
				this.AppendSql("-- Ignoring association set with participating entity set with defining query: ");
				this.AppendIdentifierEscapeNewLine(associationSet.Name);
			}
			else
			{
				this.AppendSql("alter table ");
				this.AppendIdentifier(associationSetEnd2.EntitySet);
				this.AppendSql(" add constraint ");
				this.AppendIdentifier(associationSet.Name);
				this.AppendSql(" foreign key (");
				this.AppendIdentifiers(referentialConstraint.ToProperties);
				this.AppendSql(") references ");
				this.AppendIdentifier(associationSetEnd.EntitySet);
				this.AppendSql("(");
				this.AppendIdentifiers(referentialConstraint.FromProperties);
				this.AppendSql(")");
				if (associationSetEnd.CorrespondingAssociationEndMember.DeleteBehavior == global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade)
				{
					this.AppendSql(" on delete cascade");
				}
				this.AppendSql(";");
			}
			this.AppendNewLine();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002C78 File Offset: 0x00000E78
		private void AppendCreateTable(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			if (entitySet.GetMetadataPropertyValue("DefiningQuery") != null)
			{
				this.AppendSql("-- Ignoring entity set with defining query: ");
				this.AppendIdentifier(entitySet, new global::System.Action<string>(this.AppendIdentifierEscapeNewLine));
				this.ignoredEntitySets.Add(entitySet);
			}
			else
			{
				this.AppendSql("create table ");
				this.AppendIdentifier(entitySet);
				this.AppendSql(" (");
				this.AppendNewLine();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in entitySet.ElementType.Properties)
				{
					this.AppendSql("    ");
					this.AppendIdentifier(edmProperty.Name);
					this.AppendSql(" ");
					this.AppendType(edmProperty);
					this.AppendSql(",");
					this.AppendNewLine();
				}
				this.AppendSql("    primary key (");
				this.AppendJoin<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(entitySet.ElementType.KeyMembers, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmMember k)
				{
					this.AppendIdentifier(k.Name);
				}, ", ");
				this.AppendSql(")");
				this.AppendNewLine();
				this.AppendSql(");");
			}
			this.AppendNewLine();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void AppendCreateSchema(string schema)
		{
			this.AppendSql("if (schema_id(");
			this.AppendStringLiteral(schema);
			this.AppendSql(") is null) exec(");
			global::System.Data.Entity.SqlServer.SqlDdlBuilder sqlDdlBuilder = new global::System.Data.Entity.SqlServer.SqlDdlBuilder();
			sqlDdlBuilder.AppendSql("create schema ");
			sqlDdlBuilder.AppendIdentifier(schema);
			this.AppendStringLiteral(sqlDdlBuilder.unencodedStringBuilder.ToString());
			this.AppendSql(");");
			this.AppendNewLine();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002E18 File Offset: 0x00001018
		private void AppendIdentifier(global::System.Data.Entity.Core.Metadata.Edm.EntitySet table)
		{
			this.AppendIdentifier(table, new global::System.Action<string>(this.AppendIdentifier));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002E30 File Offset: 0x00001030
		private void AppendIdentifier(global::System.Data.Entity.Core.Metadata.Edm.EntitySet table, global::System.Action<string> AppendIdentifierEscape)
		{
			string schemaName = global::System.Data.Entity.SqlServer.SqlDdlBuilder.GetSchemaName(table);
			string tableName = global::System.Data.Entity.SqlServer.SqlDdlBuilder.GetTableName(table);
			if (schemaName != null)
			{
				AppendIdentifierEscape(schemaName);
				this.AppendSql(".");
			}
			AppendIdentifierEscape(tableName);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E67 File Offset: 0x00001067
		private void AppendStringLiteral(string literalValue)
		{
			this.AppendSql("N'" + literalValue.Replace("'", "''") + "'");
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002E8E File Offset: 0x0000108E
		private void AppendIdentifiers(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			this.AppendJoin<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(properties, delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p)
			{
				this.AppendIdentifier(p.Name);
			}, ", ");
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002EA8 File Offset: 0x000010A8
		private void AppendIdentifier(string identifier)
		{
			this.AppendSql("[" + identifier.Replace("]", "]]") + "]");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002ECF File Offset: 0x000010CF
		private void AppendIdentifierEscapeNewLine(string identifier)
		{
			this.AppendIdentifier(identifier.Replace("\r", "\r--").Replace("\n", "\n--"));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002EF6 File Offset: 0x000010F6
		private void AppendFileName(string path)
		{
			this.AppendSql("(name=");
			this.AppendStringLiteral(global::System.IO.Path.GetFileName(path));
			this.AppendSql(", filename=");
			this.AppendStringLiteral(path);
			this.AppendSql(")");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002F2C File Offset: 0x0000112C
		private void AppendJoin<T>(global::System.Collections.Generic.IEnumerable<T> elements, global::System.Action<T> appendElement, string unencodedSeparator)
		{
			bool flag = true;
			foreach (T obj in elements)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					this.AppendSql(unencodedSeparator);
				}
				appendElement(obj);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002F84 File Offset: 0x00001184
		private void AppendType(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = column.TypeUsage;
			bool flag = false;
			global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
			if (typeUsage.EdmType.Name == "binary" && 8 == typeUsage.GetMaxLength() && column.TypeUsage.Facets.TryGetValue("StoreGeneratedPattern", false, out facet) && facet.Value != null && global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Computed == (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)facet.Value)
			{
				flag = true;
				this.AppendIdentifier("rowversion");
			}
			else
			{
				string name = typeUsage.EdmType.Name;
				if (typeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType && name.EndsWith("(max)", global::System.StringComparison.Ordinal))
				{
					this.AppendIdentifier(name.Substring(0, name.Length - "(max)".Length));
					this.AppendSql("(max)");
				}
				else
				{
					this.AppendIdentifier(name);
				}
				string name2 = typeUsage.EdmType.Name;
				if (name2 != null)
				{
					uint num = global::<PrivateImplementationDetails>.ComputeStringHash(name2);
					if (num <= 1761125480U)
					{
						if (num <= 923440646U)
						{
							if (num != 520654156U)
							{
								if (num != 923440646U)
								{
									goto IL_2E5;
								}
								if (!(name2 == "datetime2"))
								{
									goto IL_2E5;
								}
								goto IL_2A5;
							}
							else if (!(name2 == "decimal"))
							{
								goto IL_2E5;
							}
						}
						else if (num != 1539863742U)
						{
							if (num != 1564253156U)
							{
								if (num != 1761125480U)
								{
									goto IL_2E5;
								}
								if (!(name2 == "numeric"))
								{
									goto IL_2E5;
								}
							}
							else
							{
								if (!(name2 == "time"))
								{
									goto IL_2E5;
								}
								goto IL_2A5;
							}
						}
						else
						{
							if (!(name2 == "nvarchar"))
							{
								goto IL_2E5;
							}
							goto IL_2C6;
						}
						this.AppendSqlInvariantFormat("({0}, {1})", new object[]
						{
							typeUsage.GetPrecision(),
							typeUsage.GetScale()
						});
						goto IL_2E5;
					}
					if (num <= 3347933383U)
					{
						if (num != 2336348659U)
						{
							if (num != 2823553821U)
							{
								if (num != 3347933383U)
								{
									goto IL_2E5;
								}
								if (!(name2 == "varbinary"))
								{
									goto IL_2E5;
								}
								goto IL_2C6;
							}
							else
							{
								if (!(name2 == "char"))
								{
									goto IL_2E5;
								}
								goto IL_2C6;
							}
						}
						else if (!(name2 == "datetimeoffset"))
						{
							goto IL_2E5;
						}
					}
					else if (num != 3716508924U)
					{
						if (num != 3761451113U)
						{
							if (num != 4163743794U)
							{
								goto IL_2E5;
							}
							if (!(name2 == "varchar"))
							{
								goto IL_2E5;
							}
							goto IL_2C6;
						}
						else
						{
							if (!(name2 == "nchar"))
							{
								goto IL_2E5;
							}
							goto IL_2C6;
						}
					}
					else
					{
						if (!(name2 == "binary"))
						{
							goto IL_2E5;
						}
						goto IL_2C6;
					}
					IL_2A5:
					this.AppendSqlInvariantFormat("({0})", new object[]
					{
						typeUsage.GetPrecision()
					});
					goto IL_2E5;
					IL_2C6:
					this.AppendSqlInvariantFormat("({0})", new object[]
					{
						typeUsage.GetMaxLength()
					});
				}
			}
			IL_2E5:
			this.AppendSql(column.Nullable ? " null" : " not null");
			if (!flag && column.TypeUsage.Facets.TryGetValue("StoreGeneratedPattern", false, out facet) && facet.Value != null && (global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern)facet.Value == global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity)
			{
				if (typeUsage.EdmType.Name == "uniqueidentifier")
				{
					this.AppendSql(" default newid()");
					return;
				}
				this.AppendSql(" identity");
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000032F1 File Offset: 0x000014F1
		private void AppendSql(string text)
		{
			this.unencodedStringBuilder.Append(text);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003300 File Offset: 0x00001500
		private void AppendNewLine()
		{
			this.unencodedStringBuilder.Append("\r\n");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003313 File Offset: 0x00001513
		private void AppendSqlInvariantFormat(string format, params object[] args)
		{
			this.unencodedStringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, format, args);
		}

		// Token: 0x04000008 RID: 8
		private readonly global::System.Text.StringBuilder unencodedStringBuilder = new global::System.Text.StringBuilder();

		// Token: 0x04000009 RID: 9
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> ignoredEntitySets = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
	}
}
