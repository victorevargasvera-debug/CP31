using System;
using System.Windows.Media;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000254 RID: 596
	public class GroupDisplayColumn : global::Infragistics.Controls.Grids.UnboundColumn
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00047FB9 File Offset: 0x000461B9
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00047FBC File Offset: 0x000461BC
		public override bool IsResizable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsResizable = value;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00047FC5 File Offset: 0x000461C5
		protected internal override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00047FC8 File Offset: 0x000461C8
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00047FCB File Offset: 0x000461CB
		public override bool IsSortable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsSortable = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00047FD4 File Offset: 0x000461D4
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00047FD7 File Offset: 0x000461D7
		public override bool IsFilterable
		{
			get
			{
				return false;
			}
			set
			{
				base.IsFilterable = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x00047FE0 File Offset: 0x000461E0
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00047FE8 File Offset: 0x000461E8
		public global::System.Windows.Media.Brush AndColorBrush { get; set; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x00047FF1 File Offset: 0x000461F1
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x00047FF9 File Offset: 0x000461F9
		public global::System.Windows.Media.Brush OrColorBrush { get; set; }

		// Token: 0x06001320 RID: 4896 RVA: 0x00048002 File Offset: 0x00046202
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.GroupDisplayColumnContentProvider();
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00048009 File Offset: 0x00046209
		protected override global::Infragistics.Controls.Grids.CellBase GenerateDataCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
			{
				return new global::Infragistics.Controls.Grids.Primitives.GroupDisplayCell(row, this);
			}
			return base.GenerateDataCell(row);
		}
	}
}
