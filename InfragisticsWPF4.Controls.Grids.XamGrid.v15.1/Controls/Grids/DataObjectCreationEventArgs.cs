using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B7 RID: 439
	public class DataObjectCreationEventArgs : global::System.EventArgs
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002A52C File Offset: 0x0002872C
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0002A534 File Offset: 0x00028734
		public object NewObject { get; set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0002A53D File Offset: 0x0002873D
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0002A545 File Offset: 0x00028745
		public global::System.Type ObjectType { get; protected internal set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002A54E File Offset: 0x0002874E
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0002A556 File Offset: 0x00028756
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout { get; protected internal set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002A55F File Offset: 0x0002875F
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0002A567 File Offset: 0x00028767
		public global::Infragistics.Controls.Grids.Row ParentRow { get; protected internal set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0002A570 File Offset: 0x00028770
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0002A578 File Offset: 0x00028778
		public global::System.Type CollectionType { get; protected internal set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0002A581 File Offset: 0x00028781
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0002A589 File Offset: 0x00028789
		public global::Infragistics.Controls.Grids.RowType? RowTypeCreated { get; protected internal set; }
	}
}
