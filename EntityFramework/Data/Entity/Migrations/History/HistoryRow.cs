using System;

namespace System.Data.Entity.Migrations.History
{
	// Token: 0x020000DD RID: 221
	public class HistoryRow
	{
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00026A6E File Offset: 0x00024C6E
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00026A76 File Offset: 0x00024C76
		public string MigrationId { get; set; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00026A7F File Offset: 0x00024C7F
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00026A87 File Offset: 0x00024C87
		public string ContextKey { get; set; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00026A90 File Offset: 0x00024C90
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00026A98 File Offset: 0x00024C98
		public byte[] Model { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00026AA1 File Offset: 0x00024CA1
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00026AA9 File Offset: 0x00024CA9
		public string ProductVersion { get; set; }
	}
}
