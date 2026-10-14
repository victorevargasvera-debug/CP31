using System;
using System.ComponentModel;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Migrations.Builders
{
	// Token: 0x020000EB RID: 235
	public class TableBuilder<TColumns>
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x0002D5B5 File Offset: 0x0002B7B5
		public TableBuilder(global::System.Data.Entity.Migrations.Model.CreateTableOperation createTableOperation, global::System.Data.Entity.Migrations.DbMigration migration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateTableOperation>(createTableOperation, "createTableOperation");
			this._createTableOperation = createTableOperation;
			this._migration = migration;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		public global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns> PrimaryKey(global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>> keyExpression, string name = null, bool clustered = true, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>>>(keyExpression, "keyExpression");
			global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(anonymousArguments)
			{
				Name = name,
				IsClustered = clustered
			};
			(from p in keyExpression.GetSimplePropertyAccessList()
			select this._createTableOperation.Columns.Single((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.ApiPropertyInfo == p.Single<global::System.Reflection.PropertyInfo>())).Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				addPrimaryKeyOperation.Columns.Add(c.Name);
			});
			this._createTableOperation.PrimaryKey = addPrimaryKeyOperation;
			return this;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0002D654 File Offset: 0x0002B854
		public global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns> Index(global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>> indexExpression, string name = null, bool unique = false, bool clustered = false, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>>>(indexExpression, "indexExpression");
			global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation = new global::System.Data.Entity.Migrations.Model.CreateIndexOperation(anonymousArguments)
			{
				Name = name,
				Table = this._createTableOperation.Name,
				IsUnique = unique,
				IsClustered = clustered
			};
			(from p in indexExpression.GetSimplePropertyAccessList()
			select this._createTableOperation.Columns.Single((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.ApiPropertyInfo == p.Single<global::System.Reflection.PropertyInfo>())).Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				createIndexOperation.Columns.Add(c.Name);
			});
			this._migration.AddOperation(createIndexOperation);
			return this;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0002D6E8 File Offset: 0x0002B8E8
		public global::System.Data.Entity.Migrations.Builders.TableBuilder<TColumns> ForeignKey(string principalTable, global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>> dependentKeyExpression, bool cascadeDelete = false, string name = null, object anonymousArguments = null)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(principalTable, "principalTable");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TColumns, object>>>(dependentKeyExpression, "dependentKeyExpression");
			global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation addForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation(anonymousArguments)
			{
				Name = name,
				PrincipalTable = principalTable,
				DependentTable = this._createTableOperation.Name,
				CascadeDelete = cascadeDelete
			};
			(from p in dependentKeyExpression.GetSimplePropertyAccessList()
			select this._createTableOperation.Columns.Single((global::System.Data.Entity.Migrations.Model.ColumnModel c) => c.ApiPropertyInfo == p.Single<global::System.Reflection.PropertyInfo>())).Each(delegate(global::System.Data.Entity.Migrations.Model.ColumnModel c)
			{
				addForeignKeyOperation.DependentColumns.Add(c.Name);
			});
			this._migration.AddOperation(addForeignKeyOperation);
			return this;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0002D788 File Offset: 0x0002B988
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0002D790 File Offset: 0x0002B990
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0002D799 File Offset: 0x0002B999
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0002D7A1 File Offset: 0x0002B9A1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0002D7A9 File Offset: 0x0002B9A9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected new object MemberwiseClone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x040008EC RID: 2284
		private readonly global::System.Data.Entity.Migrations.Model.CreateTableOperation _createTableOperation;

		// Token: 0x040008ED RID: 2285
		private readonly global::System.Data.Entity.Migrations.DbMigration _migration;
	}
}
