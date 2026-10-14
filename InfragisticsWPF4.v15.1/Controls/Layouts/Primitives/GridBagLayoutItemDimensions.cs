using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000050 RID: 80
	public class GridBagLayoutItemDimensions
	{
		// Token: 0x0600031A RID: 794 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
		internal GridBagLayoutItemDimensions(int column, int row, int columnSpan, int rowSpan, global::System.Windows.Rect bounds)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = columnSpan;
			this._rowSpan = rowSpan;
			this._bounds = bounds;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000C8D9 File Offset: 0x0000AAD9
		public global::System.Windows.Rect Bounds
		{
			get
			{
				return this._bounds;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000C8E1 File Offset: 0x0000AAE1
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000C8E9 File Offset: 0x0000AAE9
		internal int ColumnRight
		{
			get
			{
				return this._column + this._columnSpan;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000C8F8 File Offset: 0x0000AAF8
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000C900 File Offset: 0x0000AB00
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000C908 File Offset: 0x0000AB08
		internal int RowBottom
		{
			get
			{
				return this._row + this._rowSpan;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000C917 File Offset: 0x0000AB17
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000C91F File Offset: 0x0000AB1F
		internal global::System.Windows.Size Size
		{
			get
			{
				return this._bounds.Size;
			}
		}

		// Token: 0x040000F9 RID: 249
		private int _column;

		// Token: 0x040000FA RID: 250
		private int _row;

		// Token: 0x040000FB RID: 251
		private int _columnSpan;

		// Token: 0x040000FC RID: 252
		private int _rowSpan;

		// Token: 0x040000FD RID: 253
		private global::System.Windows.Rect _bounds = global::System.Windows.Rect.Empty;
	}
}
