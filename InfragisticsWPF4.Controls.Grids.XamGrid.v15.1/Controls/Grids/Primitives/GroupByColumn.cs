using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200024F RID: 591
	internal sealed class GroupByColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x00045D2D File Offset: 0x00043F2D
		internal GroupByColumn()
		{
			this._width = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, true);
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00045D4A File Offset: 0x00043F4A
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00045D54 File Offset: 0x00043F54
		protected internal override global::Infragistics.Controls.Grids.CellBase GenerateCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			global::Infragistics.Controls.Grids.CellBase result = null;
			if (row is global::Infragistics.Controls.Grids.Primitives.GroupByRow)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.GroupByCell(row, this);
			}
			else if (row is global::Infragistics.Controls.Grids.Primitives.GroupByAreaRow)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.GroupByAreaCell(row, this);
			}
			return result;
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00045D86 File Offset: 0x00043F86
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00045D89 File Offset: 0x00043F89
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x00045D8C File Offset: 0x00043F8C
		public override bool IsSortable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00045D8F File Offset: 0x00043F8F
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x040005D7 RID: 1495
		private global::Infragistics.Controls.Grids.ColumnWidth _width;
	}
}
