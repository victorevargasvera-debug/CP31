using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B7 RID: 183
	public class DropPrimaryKeyOperation : global::System.Data.Entity.Migrations.Model.PrimaryKeyOperation
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x0001F736 File Offset: 0x0001D936
		public DropPrimaryKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x0001F740 File Offset: 0x0001D940
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation addPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.AddPrimaryKeyOperation(null)
				{
					Name = base.Name,
					Table = base.Table,
					IsClustered = base.IsClustered
				};
				base.Columns.Each(delegate(string c)
				{
					addPrimaryKeyOperation.Columns.Add(c);
				});
				return addPrimaryKeyOperation;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x0001F7A8 File Offset: 0x0001D9A8
		public global::System.Data.Entity.Migrations.Model.CreateTableOperation CreateTableOperation { get; internal set; }
	}
}
