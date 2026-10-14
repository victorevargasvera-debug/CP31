using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C7 RID: 199
	public class RenameIndexOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x00020178 File Offset: 0x0001E378
		public RenameIndexOperation(string table, string name, string newName, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this._table = table;
			this._name = name;
			this._newName = newName;
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000201C6 File Offset: 0x0001E3C6
		public virtual string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x000201CE File Offset: 0x0001E3CE
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x000201D6 File Offset: 0x0001E3D6
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000201DE File Offset: 0x0001E3DE
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x000201E7 File Offset: 0x0001E3E7
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return new global::System.Data.Entity.Migrations.Model.RenameIndexOperation(this.Table, this.NewName, this.Name, null);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00020201 File Offset: 0x0001E401
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400088D RID: 2189
		private readonly string _table;

		// Token: 0x0400088E RID: 2190
		private readonly string _name;

		// Token: 0x0400088F RID: 2191
		private string _newName;
	}
}
