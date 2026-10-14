using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AC RID: 172
	public class AddPrimaryKeyOperation : global::System.Data.Entity.Migrations.Model.PrimaryKeyOperation
	{
		// Token: 0x06000F0D RID: 3853 RVA: 0x0001ECFF File Offset: 0x0001CEFF
		public AddPrimaryKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0001ED08 File Offset: 0x0001CF08
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation dropPrimaryKeyOperation = new global::System.Data.Entity.Migrations.Model.DropPrimaryKeyOperation(null)
				{
					Name = base.Name,
					Table = base.Table,
					IsClustered = base.IsClustered
				};
				base.Columns.Each(delegate(string c)
				{
					dropPrimaryKeyOperation.Columns.Add(c);
				});
				return dropPrimaryKeyOperation;
			}
		}
	}
}
