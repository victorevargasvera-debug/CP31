using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DevAge.Data.SqlClient
{
	// Token: 0x0200027F RID: 639
	internal class SqlCommandBuilder
	{
		// Token: 0x0600208A RID: 8330 RVA: 0x00074350 File Offset: 0x00072550
		public SqlCommandBuilder(global::System.Data.DataTable dataTable)
		{
			this.mDataTable = dataTable;
			this.mPrimaryKeys = this.mDataTable.PrimaryKey;
			if (this.mPrimaryKeys == null || this.mPrimaryKeys.Length == 0)
			{
				throw new global::System.ApplicationException("DataTable must have a primary key");
			}
			this.mNormalColumns = new global::System.Data.DataColumn[this.mDataTable.Columns.Count - this.mPrimaryKeys.Length];
			int num = 0;
			for (int i = 0; i < this.mDataTable.Columns.Count; i++)
			{
				bool flag = false;
				for (int j = 0; j < this.mPrimaryKeys.Length; j++)
				{
					if (this.mDataTable.Columns[i].AutoIncrement)
					{
						throw new global::System.ApplicationException("Autoincrement column not supported");
					}
					if (this.mDataTable.Columns[i].ColumnName == this.mPrimaryKeys[j].ColumnName)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.mNormalColumns[num] = this.mDataTable.Columns[i];
					num++;
				}
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00074488 File Offset: 0x00072688
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00074490 File Offset: 0x00072690
		public global::System.Data.DataTable DataTable
		{
			get
			{
				return this.mDataTable;
			}
			set
			{
				this.mDataTable = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0007449C File Offset: 0x0007269C
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x000744A4 File Offset: 0x000726A4
		public global::System.Data.DataColumn[] PrimaryKeyColumns
		{
			get
			{
				return this.mPrimaryKeys;
			}
			set
			{
				this.mPrimaryKeys = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x000744B0 File Offset: 0x000726B0
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x000744B8 File Offset: 0x000726B8
		public global::System.Data.DataColumn[] IdentityColumns
		{
			get
			{
				return this.mIdentityColumns;
			}
			set
			{
				this.mIdentityColumns = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x000744C4 File Offset: 0x000726C4
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x000744CC File Offset: 0x000726CC
		public global::System.Data.DataColumn[] NormalColumns
		{
			get
			{
				return this.mNormalColumns;
			}
			set
			{
				this.mNormalColumns = value;
			}
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000744D8 File Offset: 0x000726D8
		protected virtual string CreateSqlTableName()
		{
			return "[" + this.mDataTable.TableName + "]";
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x000744F4 File Offset: 0x000726F4
		protected virtual string CreateSqlColumnName(global::System.Data.DataColumn column)
		{
			return "[" + column.ColumnName + "]";
		}

		// Token: 0x06002095 RID: 8341 RVA: 0x0007450C File Offset: 0x0007270C
		protected virtual string CreateSqlInsertColumnName()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < this.mPrimaryKeys.Length; i++)
			{
				stringBuilder.Append(this.CreateSqlColumnName(this.mPrimaryKeys[i]));
				if (i < this.mPrimaryKeys.Length - 1 || this.mNormalColumns.Length > 0)
				{
					stringBuilder.Append(",");
				}
			}
			for (int j = 0; j < this.mNormalColumns.Length; j++)
			{
				stringBuilder.Append(this.CreateSqlColumnName(this.mNormalColumns[j]));
				if (j < this.mNormalColumns.Length - 1)
				{
					stringBuilder.Append(",");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x000745D0 File Offset: 0x000727D0
		protected virtual string CreateSqlInsertParameters(global::System.Data.SqlClient.SqlParameterCollection parameters)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < parameters.Count; i++)
			{
				stringBuilder.Append(parameters[i].ParameterName);
				if (i < parameters.Count - 1)
				{
					stringBuilder.Append(",");
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x00074630 File Offset: 0x00072830
		protected virtual string CreateSqlPKWhereColumn()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			for (int i = 0; i < this.mPrimaryKeys.Length; i++)
			{
				stringBuilder.Append(this.CreateSqlColumnName(this.mPrimaryKeys[i]));
				stringBuilder.Append(" = ");
				stringBuilder.Append("@p" + num.ToString());
				if (i < this.mPrimaryKeys.Length - 1)
				{
					stringBuilder.Append(" AND ");
				}
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000746C4 File Offset: 0x000728C4
		protected virtual string CreateSqlUpdateColumn()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = this.mPrimaryKeys.Length;
			for (int i = 0; i < this.mNormalColumns.Length; i++)
			{
				stringBuilder.Append(this.CreateSqlColumnName(this.mNormalColumns[i]));
				stringBuilder.Append(" = ");
				stringBuilder.Append("@p" + num.ToString());
				if (i < this.mNormalColumns.Length - 1)
				{
					stringBuilder.Append(",");
				}
				num++;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00074760 File Offset: 0x00072960
		protected virtual void PopulateAllParameters(global::System.Data.SqlClient.SqlParameterCollection parameters)
		{
			int num = 0;
			for (int i = 0; i < this.mPrimaryKeys.Length; i++)
			{
				parameters.Add("@p" + num.ToString(), this.SqlDbTypeFromDataType(this.mPrimaryKeys[i].DataType), 0, this.mPrimaryKeys[i].ColumnName);
				num++;
			}
			for (int j = 0; j < this.mNormalColumns.Length; j++)
			{
				parameters.Add("@p" + num.ToString(), this.SqlDbTypeFromDataType(this.mNormalColumns[j].DataType), 0, this.mNormalColumns[j].ColumnName);
				num++;
			}
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x0007482C File Offset: 0x00072A2C
		protected virtual global::System.Data.SqlDbType SqlDbTypeFromDataType(global::System.Type type)
		{
			if (type == typeof(string))
			{
				return global::System.Data.SqlDbType.VarChar;
			}
			if (type == typeof(int))
			{
				return global::System.Data.SqlDbType.Int;
			}
			if (type == typeof(long))
			{
				return global::System.Data.SqlDbType.BigInt;
			}
			if (type == typeof(double))
			{
				return global::System.Data.SqlDbType.Float;
			}
			if (type == typeof(float))
			{
				return global::System.Data.SqlDbType.Float;
			}
			if (type == typeof(bool))
			{
				return global::System.Data.SqlDbType.Bit;
			}
			if (type == typeof(global::System.DateTime))
			{
				return global::System.Data.SqlDbType.DateTime;
			}
			if (type == typeof(decimal))
			{
				return global::System.Data.SqlDbType.Decimal;
			}
			if (type == typeof(global::System.Guid))
			{
				return global::System.Data.SqlDbType.UniqueIdentifier;
			}
			if (type == typeof(byte[]))
			{
				return global::System.Data.SqlDbType.Image;
			}
			throw new global::System.ApplicationException("Type " + type.Name + " not supported");
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00074910 File Offset: 0x00072B10
		public virtual global::System.Data.SqlClient.SqlCommand GetInsertCommand()
		{
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand();
			sqlCommand.CommandType = global::System.Data.CommandType.Text;
			this.PopulateAllParameters(sqlCommand.Parameters);
			string commandText = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", this.CreateSqlTableName(), this.CreateSqlInsertColumnName(), this.CreateSqlInsertParameters(sqlCommand.Parameters));
			sqlCommand.CommandText = commandText;
			return sqlCommand;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00074968 File Offset: 0x00072B68
		public virtual global::System.Data.SqlClient.SqlCommand GetUpdateCommand()
		{
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand();
			sqlCommand.CommandType = global::System.Data.CommandType.Text;
			this.PopulateAllParameters(sqlCommand.Parameters);
			string commandText = string.Format("UPDATE {0} SET {1} WHERE {2}", this.CreateSqlTableName(), this.CreateSqlUpdateColumn(), this.CreateSqlPKWhereColumn());
			sqlCommand.CommandText = commandText;
			return sqlCommand;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000749B8 File Offset: 0x00072BB8
		public virtual global::System.Data.SqlClient.SqlCommand GetDeleteCommand()
		{
			global::System.Data.SqlClient.SqlCommand sqlCommand = new global::System.Data.SqlClient.SqlCommand();
			sqlCommand.CommandType = global::System.Data.CommandType.Text;
			this.PopulateAllParameters(sqlCommand.Parameters);
			string commandText = string.Format("DELETE {0} WHERE {1}", this.CreateSqlTableName(), this.CreateSqlPKWhereColumn());
			sqlCommand.CommandText = commandText;
			return sqlCommand;
		}

		// Token: 0x04000C07 RID: 3079
		private global::System.Data.DataTable mDataTable;

		// Token: 0x04000C08 RID: 3080
		private global::System.Data.DataColumn[] mPrimaryKeys;

		// Token: 0x04000C09 RID: 3081
		private global::System.Data.DataColumn[] mIdentityColumns;

		// Token: 0x04000C0A RID: 3082
		private global::System.Data.DataColumn[] mNormalColumns;
	}
}
