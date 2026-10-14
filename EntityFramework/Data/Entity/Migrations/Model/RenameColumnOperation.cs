using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C6 RID: 198
	public class RenameColumnOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000FC3 RID: 4035 RVA: 0x000200EC File Offset: 0x0001E2EC
		public RenameColumnOperation(string table, string name, string newName, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(table, "table");
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(newName, "newName");
			this._table = table;
			this._name = name;
			this._newName = newName;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0002013A File Offset: 0x0001E33A
		public virtual string Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00020142 File Offset: 0x0001E342
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0002014A File Offset: 0x0001E34A
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00020152 File Offset: 0x0001E352
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x0002015B File Offset: 0x0001E35B
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return new global::System.Data.Entity.Migrations.Model.RenameColumnOperation(this.Table, this.NewName, this.Name, null);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00020175 File Offset: 0x0001E375
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400088A RID: 2186
		private readonly string _table;

		// Token: 0x0400088B RID: 2187
		private readonly string _name;

		// Token: 0x0400088C RID: 2188
		private string _newName;
	}
}
