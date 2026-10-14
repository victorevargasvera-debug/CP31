using System;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000C1 RID: 193
	public class NotSupportedOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000F94 RID: 3988 RVA: 0x0001FC19 File Offset: 0x0001DE19
		private NotSupportedOperation() : base(null)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x0001FC22 File Offset: 0x0001DE22
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000876 RID: 2166
		internal static readonly global::System.Data.Entity.Migrations.Model.NotSupportedOperation Instance = new global::System.Data.Entity.Migrations.Model.NotSupportedOperation();
	}
}
