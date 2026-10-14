using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200019F RID: 415
	public class ColumnLayoutAssignedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0002A176 File Offset: 0x00028376
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0002A17E File Offset: 0x0002837E
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout { get; set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0002A187 File Offset: 0x00028387
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0002A18F File Offset: 0x0002838F
		public int Level { get; protected internal set; }

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002A198 File Offset: 0x00028398
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0002A1A0 File Offset: 0x000283A0
		public string Key { get; protected internal set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002A1A9 File Offset: 0x000283A9
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0002A1B1 File Offset: 0x000283B1
		public global::System.Type DataType { get; protected internal set; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002A1BA File Offset: 0x000283BA
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0002A1C2 File Offset: 0x000283C2
		public global::Infragistics.Controls.Grids.RowCollection Rows { get; protected internal set; }
	}
}
