using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B5 RID: 181
	public class DropForeignKeyOperation : global::System.Data.Entity.Migrations.Model.ForeignKeyOperation
	{
		// Token: 0x06000F4E RID: 3918 RVA: 0x0001F683 File Offset: 0x0001D883
		public DropForeignKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0001F68C File Offset: 0x0001D88C
		public DropForeignKeyOperation(global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation inverse, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation>(inverse, "inverse");
			this._inverse = inverse;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		public virtual global::System.Data.Entity.Migrations.Model.DropIndexOperation CreateDropIndexOperation()
		{
			global::System.Data.Entity.Migrations.Model.DropIndexOperation dropIndexOperation = new global::System.Data.Entity.Migrations.Model.DropIndexOperation(this._inverse.CreateCreateIndexOperation(), null)
			{
				Table = base.DependentTable
			};
			base.DependentColumns.Each(delegate(string c)
			{
				dropIndexOperation.Columns.Add(c);
			});
			return dropIndexOperation;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x0001F6FB File Offset: 0x0001D8FB
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return this._inverse;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x0001F703 File Offset: 0x0001D903
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400085E RID: 2142
		private readonly global::System.Data.Entity.Migrations.Model.AddForeignKeyOperation _inverse;
	}
}
