using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200003C RID: 60
	public class GridBagLayoutItemDimensions
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000AE15 File Offset: 0x00009015
		internal GridBagLayoutItemDimensions(int column, int row, int columnSpan, int rowSpan, global::System.Windows.Rect bounds)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = columnSpan;
			this._rowSpan = rowSpan;
			this._bounds = bounds;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000AE4D File Offset: 0x0000904D
		public global::System.Windows.Rect Bounds
		{
			get
			{
				return this._bounds;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000AE55 File Offset: 0x00009055
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000AE5D File Offset: 0x0000905D
		internal int ColumnRight
		{
			get
			{
				return this._column + this._columnSpan;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000AE6C File Offset: 0x0000906C
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000AE74 File Offset: 0x00009074
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000AE7C File Offset: 0x0000907C
		internal int RowBottom
		{
			get
			{
				return this._row + this._rowSpan;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000AE8B File Offset: 0x0000908B
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000AE93 File Offset: 0x00009093
		internal global::System.Windows.Size Size
		{
			get
			{
				return this._bounds.Size;
			}
		}

		// Token: 0x0400009E RID: 158
		private int _column;

		// Token: 0x0400009F RID: 159
		private int _row;

		// Token: 0x040000A0 RID: 160
		private int _columnSpan;

		// Token: 0x040000A1 RID: 161
		private int _rowSpan;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Rect _bounds = global::System.Windows.Rect.Empty;
	}
}
