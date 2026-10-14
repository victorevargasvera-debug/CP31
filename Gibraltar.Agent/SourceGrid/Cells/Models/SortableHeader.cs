using System;
using DevAge.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003B0 RID: 944
	internal class SortableHeader : global::SourceGrid.Cells.Models.ISortableHeader, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B83 RID: 11139 RVA: 0x00092424 File Offset: 0x00090624
		public global::SourceGrid.Cells.Models.SortStatus GetSortStatus(global::SourceGrid.CellContext cellContext)
		{
			return this.m_SortStatus;
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x0009242C File Offset: 0x0009062C
		public void SetSortMode(global::SourceGrid.CellContext cellContext, global::DevAge.Drawing.HeaderSortStyle pStyle)
		{
			this.m_SortStatus.Style = pStyle;
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x0009243C File Offset: 0x0009063C
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00092444 File Offset: 0x00090644
		public global::SourceGrid.Cells.Models.SortStatus SortStatus
		{
			get
			{
				return this.m_SortStatus;
			}
			set
			{
				this.m_SortStatus = value;
			}
		}

		// Token: 0x04000E97 RID: 3735
		private global::SourceGrid.Cells.Models.SortStatus m_SortStatus = new global::SourceGrid.Cells.Models.SortStatus(global::DevAge.Drawing.HeaderSortStyle.None, null);
	}
}
