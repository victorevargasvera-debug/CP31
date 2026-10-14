using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Builders;
using System.Data.Entity.Migrations.Edm;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.IO;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Migrations
{
	// Token: 0x0200009D RID: 157
	public abstract class DbMigration : global::System.Data.Entity.Migrations.Infrastructure.IDbMigration
	{
		// Token: 0x06000E26 RID: 3622
		public abstract void Up();

		// Token: 0x06000E27 RID: 3623 RVA: 0x0001B48D File Offset: 0x0001968D
		public virtual void Down()
		{
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0001B48F File Offset: 0x0001968F
		public void CreateStoredProcedure(string name, string body, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.CreateStoredProcedure<object>(name, (global::System.Data.Entity.Migrations.Builders.ParameterBuilder _) => new
			{

			}, body, anonymousArguments);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public void CreateStoredProcedure<TParameters>(string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ParameterBuilder, TParameters> parametersAction, string body, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ParameterBuilder, TParameters>>(parametersAction, "parametersAction");
			global::System.Data.Entity.Migrations.Model.CreateProcedureOperation createProcedureOperation = new global::System.Data.Entity.Migrations.Model.CreateProcedureOperation(name, body, anonymousArguments);
			this.AddOperation(createProcedureOperation);
			TParameters parameters = parametersAction(new global::System.Data.Entity.Migrations.Builders.ParameterBuilder());
			parameters.GetType().GetNonIndexerProperties().Each(delegate(global::System.Reflection.PropertyInfo p, int i)
			{
				global::System.Data.Entity.Migrations.Model.ParameterModel parameterModel = p.GetValue(parameters, null) as global::System.Data.Entity.Migrations.Model.ParameterModel;
				if (parameterModel != null)
				{
					if (string.IsNullOrWhiteSpace(parameterModel.Name))
					{
						parameterModel.Name = p.Name;
					}
					createProcedureOperation.Parameters.Add(parameterModel);
				}
			});
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0001B546 File Offset: 0x00019746
		public void AlterStoredProcedure(string name, string body, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AlterStoredProcedure<object>(name, (global::System.Data.Entity.Migrations.Builders.ParameterBuilder _) => new
			{

			}, body, anonymousArguments);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0001B57C File Offset: 0x0001977C
		public void AlterStoredProcedure<TParameters>(string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ParameterBuilder, TParameters> parametersAction, string body, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ParameterBuilder, TParameters>>(parametersAction, "parametersAction");
			global::System.Data.Entity.Migrations.Model.AlterProcedureOperation alterProcedureOperation = new global::System.Data.Entity.Migrations.Model.AlterProcedureOperation(name, body, anonymousArguments);
			this.AddOperation(alterProcedureOperation);
			TParameters parameters = parametersAction(new global::System.Data.Entity.Migrations.Builders.ParameterBuilder());
			parameters.GetType().GetNonIndexerProperties().Each(delegate(global::System.Reflection.PropertyInfo p, int i)
			{
				global::System.Data.Entity.Migrations.Model.ParameterModel parameterModel = p.GetValue(parameters, null) as global::System.Data.Entity.Migrations.Model.ParameterModel;
				if (parameterModel != null)
				{
					if (string.IsNullOrWhiteSpace(parameterModel.Name))
					{
						parameterModel.Name = p.Name;
					}
					alterProcedureOperation.Parameters.Add(parameterModel);
				}
			});
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0001B5FA File Offset: 0x000197FA
		public void DropStoredProcedure(string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.DropProcedureOperation(name, anonymousArguments));
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0001B615 File Offset: 0x00019815
		protected internal global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns> CreateTable<TColumns>(string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns> columnsAction, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns>>(columnsAction, "columnsAction");
			return this.CreateTable<TColumns>(name, columnsAction, null, anonymousArguments);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0001B63C File Offset: 0x0001983C
		protected internal global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns> CreateTable<TColumns>(string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns> columnsAction, global::System.Collections.Generic.IDictionary<string, object> annotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns>>(columnsAction, "columnsAction");
			global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation = new global::System.Data.Entity.Migrations.Model.CreateTableOperation(name, annotations, anonymousArguments);
			this.AddOperation(createTableOperation);
			global::System.Data.Entity.Migrations.DbMigration.AddColumns<TColumns>(columnsAction(new global::System.Data.Entity.Migrations.Builders.ColumnBuilder()), createTableOperation.Columns);
			return new global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns>(createTableOperation, this);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0001B690 File Offset: 0x00019890
		protected internal void AlterTableAnnotations<TColumns>(string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns> columnsAction, global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Infrastructure.Annotations.AnnotationValues> annotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, TColumns>>(columnsAction, "columnsAction");
			global::System.Data.Entity.Migrations.Model.AlterTableOperation alterTableOperation = new global::System.Data.Entity.Migrations.Model.AlterTableOperation(name, annotations, anonymousArguments);
			global::System.Data.Entity.Migrations.DbMigration.AddColumns<TColumns>(columnsAction(new global::System.Data.Entity.Migrations.Builders.ColumnBuilder()), alterTableOperation.Columns);
			this.AddOperation(alterTableOperation);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0001B6DC File Offset: 0x000198DC
		private static void AddColumns<TColumns>(TColumns columns, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Migrations.Model.ColumnModel> columnModels)
		{
			columns.GetType().GetNonIndexerProperties().Each(delegate(global::System.Reflection.PropertyInfo p, int i)
			{
				global::System.Data.Entity.Migrations.Model.ColumnModel columnModel = p.GetValue(columns, null) as global::System.Data.Entity.Migrations.Model.ColumnModel;
				if (columnModel != null)
				{
					columnModel.ApiPropertyInfo = p;
					if (string.IsNullOrWhiteSpace(columnModel.Name))
					{
						columnModel.Name = p.Name;
					}
					columnModels.Add(columnModel);
				}
			});
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0001B724 File Offset: 0x00019924
		protected internal void AddForeignKey(string dependentTable, string dependentColumn, string principalTable, string principalColumn = null, bool cascadeDelete = false, string name = null, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentColumn, "dependentColumn");
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			string[] dependentColumns = new string[]
			{
				dependentColumn
			};
			object principalColumns;
			if (principalColumn == null)
			{
				principalColumns = null;
			}
			else
			{
				(principalColumns = new string[1])[0] = principalColumn;
			}
			this.AddForeignKey(dependentTable, dependentColumns, principalTable, principalColumns, cascadeDelete, name, anonymousArguments);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0001B780 File Offset: 0x00019980
		protected internal void AddForeignKey(string dependentTable, string[] dependentColumns, string principalTable, string[] principalColumns = null, bool cascadeDelete = false, string name = null, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(dependentColumns, "dependentColumns");
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			if (!dependentColumns.Any<string>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("dependentColumns", "AddForeignKey"));
			}
			global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation(anonymousArguments)
			{
				DependentTable = dependentTable,
				PrincipalTable = principalTable,
				CascadeDelete = cascadeDelete,
				Name = name
			};
			dependentColumns.Each(delegate(string c)
			{
				addForeignKeyOperation.DependentColumns.Add(c);
			});
			if (principalColumns != null)
			{
				principalColumns.Each(delegate(string c)
				{
					addForeignKeyOperation.PrincipalColumns.Add(c);
				});
			}
			this.AddOperation(addForeignKeyOperation);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0001B834 File Offset: 0x00019A34
		protected internal void DropForeignKey(string dependentTable, string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation migrationOperation = new global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation(anonymousArguments)
			{
				DependentTable = dependentTable,
				Name = name
			};
			this.AddOperation(migrationOperation);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0001B875 File Offset: 0x00019A75
		protected internal void DropForeignKey(string dependentTable, string dependentColumn, string principalTable, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentColumn, "dependentColumn");
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			this.DropForeignKey(dependentTable, new string[]
			{
				dependentColumn
			}, principalTable, anonymousArguments);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0001B8AF File Offset: 0x00019AAF
		[global::System.Obsolete("The principalColumn parameter is no longer required and can be removed.")]
		protected internal void DropForeignKey(string dependentTable, string dependentColumn, string principalTable, string principalColumn, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentColumn, "dependentColumn");
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			this.DropForeignKey(dependentTable, new string[]
			{
				dependentColumn
			}, principalTable, anonymousArguments);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0001B8EC File Offset: 0x00019AEC
		protected internal void DropForeignKey(string dependentTable, string[] dependentColumns, string principalTable, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(dependentTable, "dependentTable");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(dependentColumns, "dependentColumns");
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			if (!dependentColumns.Any<string>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("dependentColumns", "DropForeignKey"));
			}
			global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation dropForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation(anonymousArguments)
			{
				DependentTable = dependentTable,
				PrincipalTable = principalTable
			};
			dependentColumns.Each(delegate(string c)
			{
				dropForeignKeyOperation.DependentColumns.Add(c);
			});
			this.AddOperation(dropForeignKeyOperation);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0001B979 File Offset: 0x00019B79
		protected internal void DropTable(string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.DropTable(name, null, null, anonymousArguments);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0001B991 File Offset: 0x00019B91
		protected internal void DropTable(string name, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> removedColumnAnnotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.DropTable(name, null, removedColumnAnnotations, anonymousArguments);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0001B9A9 File Offset: 0x00019BA9
		protected internal void DropTable(string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.DropTable(name, removedAnnotations, null, anonymousArguments);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0001B9C1 File Offset: 0x00019BC1
		protected internal void DropTable(string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IDictionary<string, object>> removedColumnAnnotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.DropTableOperation(name, removedAnnotations, removedColumnAnnotations, anonymousArguments));
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0001B9DF File Offset: 0x00019BDF
		protected internal void MoveTable(string name, string newSchema, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.MoveTableOperation(name, newSchema, anonymousArguments));
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0001B9FB File Offset: 0x00019BFB
		protected internal void MoveStoredProcedure(string name, string newSchema, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.MoveProcedureOperation(name, newSchema, anonymousArguments));
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0001BA17 File Offset: 0x00019C17
		protected internal void RenameTable(string name, string newName, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.RenameTableOperation(name, newName, anonymousArguments));
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0001BA3F File Offset: 0x00019C3F
		protected internal void RenameStoredProcedure(string name, string newName, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.RenameProcedureOperation(name, newName, anonymousArguments));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0001BA67 File Offset: 0x00019C67
		protected internal void RenameColumn(string table, string name, string newName, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(table, name, newName, anonymousArguments));
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0001BAA0 File Offset: 0x00019CA0
		protected internal void AddColumn(string table, string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, global::System.Data.Entity.Migrations.Model.ColumnModel> columnAction, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, global::System.Data.Entity.Migrations.Model.ColumnModel>>(columnAction, "columnAction");
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel = columnAction(new global::System.Data.Entity.Migrations.Builders.ColumnBuilder());
			columnModel.Name = name;
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.AddColumnOperation(table, columnModel, anonymousArguments));
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0001BAF3 File Offset: 0x00019CF3
		protected internal void DropColumn(string table, string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.DropColumn(table, name, null, anonymousArguments);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0001BB17 File Offset: 0x00019D17
		protected internal void DropColumn(string table, string name, global::System.Collections.Generic.IDictionary<string, object> removedAnnotations, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.DropColumnOperation(table, name, removedAnnotations, anonymousArguments));
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0001BB44 File Offset: 0x00019D44
		protected internal void AlterColumn(string table, string name, global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, global::System.Data.Entity.Migrations.Model.ColumnModel> columnAction, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Migrations.Builders.ColumnBuilder, global::System.Data.Entity.Migrations.Model.ColumnModel>>(columnAction, "columnAction");
			global::System.Data.Entity.Migrations.Model.ColumnModel columnModel = columnAction(new global::System.Data.Entity.Migrations.Builders.ColumnBuilder());
			columnModel.Name = name;
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.AlterColumnOperation(table, columnModel, false, anonymousArguments));
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0001BB98 File Offset: 0x00019D98
		protected internal void AddPrimaryKey(string table, string column, string name = null, bool clustered = true, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(column, "column");
			this.AddPrimaryKey(table, new string[]
			{
				column
			}, name, clustered, anonymousArguments);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0001BBC8 File Offset: 0x00019DC8
		protected internal void AddPrimaryKey(string table, string[] columns, string name = null, bool clustered = true, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(columns, "columns");
			if (!columns.Any<string>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("columns", "AddPrimaryKey"));
			}
			global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(anonymousArguments)
			{
				Table = table,
				Name = name,
				IsClustered = clustered
			};
			columns.Each(delegate(string c)
			{
				addPrimaryKeyOperation.Columns.Add(c);
			});
			this.AddOperation(addPrimaryKeyOperation);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0001BC54 File Offset: 0x00019E54
		protected internal void DropPrimaryKey(string table, string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation migrationOperation = new global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation(anonymousArguments)
			{
				Table = table,
				Name = name
			};
			this.AddOperation(migrationOperation);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0001BC98 File Offset: 0x00019E98
		protected internal void DropPrimaryKey(string table, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation migrationOperation = new global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation(anonymousArguments)
			{
				Table = table
			};
			this.AddOperation(migrationOperation);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0001BCC6 File Offset: 0x00019EC6
		protected internal void CreateIndex(string table, string column, bool unique = false, string name = null, bool clustered = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(column, "column");
			this.CreateIndex(table, new string[]
			{
				column
			}, unique, name, clustered, anonymousArguments);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		protected internal void CreateIndex(string table, string[] columns, bool unique = false, string name = null, bool clustered = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(columns, "columns");
			if (!columns.Any<string>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("columns", "CreateIndex"));
			}
			global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation = new global::System.Data.Entity.Migrations.Model.CreateIndexOperation(anonymousArguments)
			{
				Table = table,
				IsUnique = unique,
				Name = name,
				IsClustered = clustered
			};
			columns.Each(delegate(string c)
			{
				createIndexOperation.Columns.Add(c);
			});
			this.AddOperation(createIndexOperation);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0001BD8C File Offset: 0x00019F8C
		protected internal void DropIndex(string table, string name, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Migrations.Model.DropIndexOperation migrationOperation = new global::System.Data.Entity.Migrations.Model.DropIndexOperation(anonymousArguments)
			{
				Table = table,
				Name = name
			};
			this.AddOperation(migrationOperation);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0001BDD0 File Offset: 0x00019FD0
		protected internal void DropIndex(string table, string[] columns, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotNull<string[]>(columns, "columns");
			if (!columns.Any<string>())
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.CollectionEmpty("columns", "DropIndex"));
			}
			global::System.Data.Entity.Migrations.Model.DropIndexOperation dropIndexOperation = new global::System.Data.Entity.Migrations.Model.DropIndexOperation(anonymousArguments)
			{
				Table = table
			};
			columns.Each(delegate(string c)
			{
				dropIndexOperation.Columns.Add(c);
			});
			this.AddOperation(dropIndexOperation);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x0001BE49 File Offset: 0x0001A049
		protected internal void RenameIndex(string table, string name, string newName, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.RenameIndexOperation(table, name, newName, anonymousArguments));
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0001BE7F File Offset: 0x0001A07F
		protected internal void Sql(string sql, bool suppressTransaction = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.SqlOperation(sql, anonymousArguments)
			{
				SuppressTransaction = suppressTransaction
			});
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
		protected internal void SqlFile(string sqlFile, bool suppressTransaction = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sqlFile, "sqlFile");
			if (!global::System.IO.Path.IsPathRooted(sqlFile))
			{
				sqlFile = global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, sqlFile);
			}
			this.AddOperation(new global::System.Data.Entity.Migrations.Model.SqlOperation(global::System.IO.File.ReadAllText(sqlFile), anonymousArguments)
			{
				SuppressTransaction = suppressTransaction
			});
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0001BEF0 File Offset: 0x0001A0F0
		protected internal void SqlResource(string sqlResource, global::System.Reflection.Assembly resourceAssembly = null, bool suppressTransaction = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sqlResource, "sqlResource");
			resourceAssembly = (resourceAssembly ?? global::System.Reflection.Assembly.GetCallingAssembly());
			if (!resourceAssembly.GetManifestResourceNames().Contains(sqlResource))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.UnableToLoadEmbeddedResource(resourceAssembly.FullName, sqlResource));
			}
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(resourceAssembly.GetManifestResourceStream(sqlResource)))
			{
				this.AddOperation(new global::System.Data.Entity.Migrations.Model.SqlOperation(streamReader.ReadToEnd(), anonymousArguments)
				{
					SuppressTransaction = suppressTransaction
				});
			}
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0001BF78 File Offset: 0x0001A178
		void global::System.Data.Entity.Migrations.Infrastructure.IDbMigration.AddOperation(global::System.Data.Entity.Migrations.Model.MigrationOperation migrationOperation)
		{
			this.AddOperation(migrationOperation);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x0001BF81 File Offset: 0x0001A181
		internal void AddOperation(global::System.Data.Entity.Migrations.Model.MigrationOperation migrationOperation)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.MigrationOperation>(migrationOperation, "migrationOperation");
			this._operations.Add(migrationOperation);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0001BF9B File Offset: 0x0001A19B
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> Operations
		{
			get
			{
				return this._operations;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0001BFA3 File Offset: 0x0001A1A3
		internal void Reset()
		{
			this._operations.Clear();
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		internal global::System.Data.Entity.Migrations.Infrastructure.VersionedModel GetSourceModel()
		{
			return this.GetModel((global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata mm) => mm.Source);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x0001BFD7 File Offset: 0x0001A1D7
		internal global::System.Data.Entity.Migrations.Infrastructure.VersionedModel GetTargetModel()
		{
			return this.GetModel((global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata mm) => mm.Target);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0001C000 File Offset: 0x0001A200
		private global::System.Data.Entity.Migrations.Infrastructure.VersionedModel GetModel(global::System.Func<global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata, string> modelAccessor)
		{
			global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata arg = (global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata)this;
			string text = modelAccessor(arg);
			if (string.IsNullOrWhiteSpace(text))
			{
				return null;
			}
			global::System.CodeDom.Compiler.GeneratedCodeAttribute generatedCodeAttribute = this.GetType().GetCustomAttributes(false).SingleOrDefault<global::System.CodeDom.Compiler.GeneratedCodeAttribute>();
			string version = (generatedCodeAttribute != null && !string.IsNullOrWhiteSpace(generatedCodeAttribute.Version)) ? generatedCodeAttribute.Version : typeof(global::System.Data.Entity.Migrations.DbMigration).Assembly().GetInformationalVersion();
			return new global::System.Data.Entity.Migrations.Infrastructure.VersionedModel(new global::System.Data.Entity.Migrations.Edm.ModelCompressor().Decompress(global::System.Convert.FromBase64String(text)), version);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0001C07B File Offset: 0x0001A27B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001C083 File Offset: 0x0001A283
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0001C08C File Offset: 0x0001A28C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0001C094 File Offset: 0x0001A294
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0001C09C File Offset: 0x0001A29C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x0400080A RID: 2058
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation> _operations = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.MigrationOperation>();
	}
}
