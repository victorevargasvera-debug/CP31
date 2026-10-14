using System;
using System.Data.Common;

namespace System.Data.Entity.Migrations.History
{
	// Token: 0x020000DE RID: 222
	internal sealed class LegacyHistoryContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x060010E1 RID: 4321 RVA: 0x00026ABA File Offset: 0x00024CBA
		public LegacyHistoryContext(global::System.Data.Common.DbConnection existingConnection) : base(existingConnection, false)
		{
			this.InternalContext.InitializerDisabled = true;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00026AD0 File Offset: 0x00024CD0
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00026AD8 File Offset: 0x00024CD8
		public global::System.Data.Entity.IDbSet<global::System.Data.Entity.Migrations.History.LegacyHistoryRow> History { get; set; }
	}
}
