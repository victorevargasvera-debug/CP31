using System;

namespace System.Data.Entity.Migrations.Sql
{
	// Token: 0x020000A9 RID: 169
	public class MigrationStatement
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0001EB24 File Offset: 0x0001CD24
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0001EB2C File Offset: 0x0001CD2C
		public string Sql { get; set; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0001EB35 File Offset: 0x0001CD35
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x0001EB3D File Offset: 0x0001CD3D
		public bool SuppressTransaction { get; set; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0001EB46 File Offset: 0x0001CD46
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x0001EB4E File Offset: 0x0001CD4E
		public string BatchTerminator { get; set; }
	}
}
