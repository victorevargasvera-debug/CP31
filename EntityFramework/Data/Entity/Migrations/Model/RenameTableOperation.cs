using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C9 RID: 201
	public class RenameTableOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000FD6 RID: 4054 RVA: 0x0002028C File Offset: 0x0001E48C
		public RenameTableOperation(string name, string newName, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this._name = name;
			this._newName = newName;
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000202BB File Offset: 0x0001E4BB
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000202C3 File Offset: 0x0001E4C3
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x000202CB File Offset: 0x0001E4CB
		public virtual string NewName
		{
			get
			{
				return this._newName;
			}
			internal set
			{
				this._newName = value;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000202D4 File Offset: 0x0001E4D4
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(this._name);
				return new global::System.Data.Entity.Migrations.Model.RenameTableOperation(new global::System.Data.Entity.Utilities.DatabaseName(global::System.Data.Entity.Utilities.DatabaseName.Parse(this._newName).Name, databaseName.Schema).ToString(), databaseName.Name, null);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00020319 File Offset: 0x0001E519
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000892 RID: 2194
		private readonly string _name;

		// Token: 0x04000893 RID: 2195
		private string _newName;
	}
}
