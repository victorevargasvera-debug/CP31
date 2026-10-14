using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B1 RID: 177
	public class CreateIndexOperation : global::System.Data.Entity.Migrations.Model.IndexOperation
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x0001F3BA File Offset: 0x0001D5BA
		public CreateIndexOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0001F3C3 File Offset: 0x0001D5C3
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x0001F3CB File Offset: 0x0001D5CB
		public bool IsUnique { get; set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.DropIndexOperation dropIndexOperation = new global::System.Data.Entity.Migrations.Model.DropIndexOperation(this, null)
				{
					Name = base.Name,
					Table = base.Table
				};
				base.Columns.Each(delegate(string c)
				{
					dropIndexOperation.Columns.Add(c);
				});
				return dropIndexOperation;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x0001F429 File Offset: 0x0001D629
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x0001F42C File Offset: 0x0001D62C
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x0001F434 File Offset: 0x0001D634
		public bool IsClustered { get; set; }
	}
}
