using System;
using System.Drawing;

namespace SourceGrid.Cells
{
	// Token: 0x02000357 RID: 855
	internal interface ICell : global::SourceGrid.Cells.ICellVirtual
	{
		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060029DC RID: 10716
		string DisplayText { get; }

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060029DD RID: 10717
		// (set) Token: 0x060029DE RID: 10718
		object Value { get; set; }

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060029DF RID: 10719
		// (set) Token: 0x060029E0 RID: 10720
		object Tag { get; set; }

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060029E1 RID: 10721
		// (set) Token: 0x060029E2 RID: 10722
		string ToolTipText { get; set; }

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060029E3 RID: 10723
		// (set) Token: 0x060029E4 RID: 10724
		global::System.Drawing.Image Image { get; set; }

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060029E5 RID: 10725
		global::SourceGrid.Grid Grid { get; }

		// Token: 0x060029E6 RID: 10726
		void BindToGrid(global::SourceGrid.Grid p_grid, global::SourceGrid.Position p_Position);

		// Token: 0x060029E7 RID: 10727
		void UnBindToGrid();

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060029E8 RID: 10728
		global::SourceGrid.Grid.GridColumn Column { get; }

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060029E9 RID: 10729
		global::SourceGrid.Grid.GridRow Row { get; }

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060029EA RID: 10730
		global::SourceGrid.Range Range { get; }

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060029EB RID: 10731
		// (set) Token: 0x060029EC RID: 10732
		int ColumnSpan { get; set; }

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060029ED RID: 10733
		// (set) Token: 0x060029EE RID: 10734
		int RowSpan { get; set; }
	}
}
