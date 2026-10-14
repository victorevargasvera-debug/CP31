using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C0 RID: 192
	public class MoveTableOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x0001FB66 File Offset: 0x0001DD66
		public MoveTableOperation(string name, string newSchema, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._newSchema = newSchema;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0001FB89 File Offset: 0x0001DD89
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x0001FB91 File Offset: 0x0001DD91
		public virtual string NewSchema
		{
			get
			{
				return this._newSchema;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(this._name);
				return new global::System.Data.Entity.Migrations.Model.MoveTableOperation(new global::System.Data.Entity.Utilities.DatabaseName(databaseName.Name, this.NewSchema).ToString(), databaseName.Schema, null)
				{
					IsSystem = this.IsSystem
				};
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x0001FBE3 File Offset: 0x0001DDE3
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0001FBE6 File Offset: 0x0001DDE6
		// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0001FBEE File Offset: 0x0001DDEE
		public string ContextKey { get; internal set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0001FBF7 File Offset: 0x0001DDF7
		// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0001FBFF File Offset: 0x0001DDFF
		public bool IsSystem { get; internal set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0001FC08 File Offset: 0x0001DE08
		// (set) Token: 0x06000F93 RID: 3987 RVA: 0x0001FC10 File Offset: 0x0001DE10
		public global::System.Data.Entity.Migrations.Model.CreateTableOperation CreateTableOperation { get; internal set; }

		// Token: 0x04000871 RID: 2161
		private readonly string _name;

		// Token: 0x04000872 RID: 2162
		private readonly string _newSchema;
	}
}
