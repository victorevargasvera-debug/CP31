using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000B6 RID: 182
	public class DropIndexOperation : global::System.Data.Entity.Migrations.Model.IndexOperation
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x0001F706 File Offset: 0x0001D906
		public DropIndexOperation(object anonymousArguments = null) : base(anonymousArguments)
		{
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0001F70F File Offset: 0x0001D90F
		public DropIndexOperation(global::System.Data.Entity.Migrations.Model.CreateIndexOperation inverse, object anonymousArguments = null) : base(anonymousArguments)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Model.CreateIndexOperation>(inverse, "inverse");
			this._inverse = inverse;
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x0001F72B File Offset: 0x0001D92B
		public override global::System.Data.Entity.Migrations.Model.MigrationOperation Inverse
		{
			get
			{
				return this._inverse;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x0001F733 File Offset: 0x0001D933
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400085F RID: 2143
		private readonly global::System.Data.Entity.Migrations.Model.CreateIndexOperation _inverse;
	}
}
