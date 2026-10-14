using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000AB RID: 171
	public class AddForeignKeyOperation : global::System.Data.Entity.Migrations.Model.ForeignKeyOperation
	{
		// Token: 0x06000F06 RID: 3846 RVA: 0x0001EC27 File Offset: 0x0001CE27
		public AddForeignKeyOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0001EC3B File Offset: 0x0001CE3B
		public global::System.Collections.Generic.IList<string> PrincipalColumns
		{
			get
			{
				return this._principalColumns;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0001EC43 File Offset: 0x0001CE43
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x0001EC4B File Offset: 0x0001CE4B
		public bool CascadeDelete { get; set; }

		// Token: 0x06000F0A RID: 3850 RVA: 0x0001EC54 File Offset: 0x0001CE54
		public virtual global::System.Data.Entity.Migrations.Model.CreateIndexOperation CreateCreateIndexOperation()
		{
			global::System.Data.Entity.Migrations.Model.CreateIndexOperation createIndexOperation = new global::System.Data.Entity.Migrations.Model.CreateIndexOperation(null)
			{
				Table = base.DependentTable
			};
			base.DependentColumns.Each(delegate(string c)
			{
				createIndexOperation.Columns.Add(c);
			});
			return createIndexOperation;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation dropForeignKeyOperation = new global::System.Data.Entity.Migrations.Model.DropForeignKeyOperation(null)
				{
					Name = base.Name,
					PrincipalTable = base.PrincipalTable,
					DependentTable = base.DependentTable
				};
				base.DependentColumns.Each(delegate(string c)
				{
					dropForeignKeyOperation.DependentColumns.Add(c);
				});
				return dropForeignKeyOperation;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0001ECFC File Offset: 0x0001CEFC
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000844 RID: 2116
		private readonly global::System.Collections.Generic.List<string> _principalColumns = new global::System.Collections.Generic.List<string>();
	}
}
