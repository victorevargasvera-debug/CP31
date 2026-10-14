using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001D8 RID: 472
	internal class RenderMergeInfo
	{
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0002C421 File Offset: 0x0002A621
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0002C429 File Offset: 0x0002A629
		public object Key { get; set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0002C432 File Offset: 0x0002A632
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0002C43A File Offset: 0x0002A63A
		public global::Infragistics.Controls.Grids.CellBase Cell { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0002C443 File Offset: 0x0002A643
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x0002C44B File Offset: 0x0002A64B
		public global::Infragistics.Controls.Grids.CellBase LastVisibleCell { get; set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0002C454 File Offset: 0x0002A654
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x0002C45C File Offset: 0x0002A65C
		public bool LastCellIsExpanded { get; set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0002C465 File Offset: 0x0002A665
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x0002C46D File Offset: 0x0002A66D
		public global::Infragistics.MergedColumnInfo MergedColumnInfo { get; set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0002C476 File Offset: 0x0002A676
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0002C47E File Offset: 0x0002A67E
		public global::Infragistics.MergedColumnInfo ParentMergedColumnInfo { get; set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0002C487 File Offset: 0x0002A687
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> CellsAlreadyAccountedFor
		{
			get
			{
				if (this._cellsAlreadyAccountedFor == null)
				{
					this._cellsAlreadyAccountedFor = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
				}
				return this._cellsAlreadyAccountedFor;
			}
		}

		// Token: 0x04000412 RID: 1042
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> _cellsAlreadyAccountedFor;
	}
}
