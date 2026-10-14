using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace System.Data.Entity.Migrations.History
{
	// Token: 0x020000DF RID: 223
	[global::System.ComponentModel.DataAnnotations.Schema.Table("__MigrationHistory")]
	internal sealed class LegacyHistoryRow
	{
		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00026AE1 File Offset: 0x00024CE1
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00026AE9 File Offset: 0x00024CE9
		public int Id { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00026AF2 File Offset: 0x00024CF2
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00026AFA File Offset: 0x00024CFA
		public global::System.DateTime CreatedOn { get; set; }
	}
}
