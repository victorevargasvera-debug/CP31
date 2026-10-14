using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000CC RID: 204
	internal class ItemLayoutInfo
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x00029866 File Offset: 0x00027A66
		internal ItemLayoutInfo() : this(0, 0)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00029870 File Offset: 0x00027A70
		internal ItemLayoutInfo(int column, int row) : this(column, row, 1, 1)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002987C File Offset: 0x00027A7C
		internal ItemLayoutInfo(int column, int row, int columnSpan, int rowSpan)
		{
			this.Column = column;
			this.Row = row;
			this.ColumnSpan = columnSpan;
			this.RowSpan = rowSpan;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x000298A1 File Offset: 0x00027AA1
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x000298A9 File Offset: 0x00027AA9
		public int Row
		{
			get
			{
				return this._row;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(value);
				this._row = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000298B8 File Offset: 0x00027AB8
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x000298C0 File Offset: 0x00027AC0
		public int Column
		{
			get
			{
				return this._column;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(value);
				this._column = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x000298CF File Offset: 0x00027ACF
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x000298D7 File Offset: 0x00027AD7
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(value);
				this._rowSpan = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x000298E6 File Offset: 0x00027AE6
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x000298EE File Offset: 0x00027AEE
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
			set
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegative(value);
				this._columnSpan = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x000298FD File Offset: 0x00027AFD
		internal int RowBottom
		{
			get
			{
				return this._row + this._rowSpan - 1;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0002990E File Offset: 0x00027B0E
		internal int ColumnRight
		{
			get
			{
				return this._column + this._columnSpan - 1;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002991F File Offset: 0x00027B1F
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0002992A File Offset: 0x00027B2A
		internal bool IsCollapsed
		{
			get
			{
				return global::System.Windows.Visibility.Collapsed == this._visibility;
			}
			set
			{
				if (this.IsCollapsed != value)
				{
					this._visibility = (value ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00029942 File Offset: 0x00027B42
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x0002994A File Offset: 0x00027B4A
		internal global::System.Windows.Visibility Visibility
		{
			get
			{
				return this._visibility;
			}
			set
			{
				this._visibility = value;
			}
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00029954 File Offset: 0x00027B54
		public static bool AreEqual(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x == y || (x != null && y != null && x._column == y._column && x._row == y._row && x._columnSpan == y._columnSpan && x._rowSpan == y._rowSpan && x._fixedLocation == y._fixedLocation && x.Visibility == y.Visibility);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000299C3 File Offset: 0x00027BC3
		public global::Infragistics.Windows.DataPresenter.ItemLayoutInfo Clone()
		{
			return (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)base.MemberwiseClone();
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000299D0 File Offset: 0x00027BD0
		public bool Contains(int column, int row)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._column, this._columnSpan, column, 1) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._row, this._rowSpan, row, 1);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000299FC File Offset: 0x00027BFC
		public static global::Infragistics.Windows.DataPresenter.ItemLayoutInfo Create(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPosition pos)
		{
			return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(pos.Column, pos.Row, pos.ColumnSpan, pos.RowSpan)
			{
				Visibility = field.VisibilityInCellArea,
				_fixedLocation = field.FixedLocation
			};
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00029A44 File Offset: 0x00027C44
		public static bool HasSamePosition(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x._column == y._column && x._row == y._row && x._columnSpan == y._columnSpan && x._rowSpan == y._rowSpan;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00029A80 File Offset: 0x00027C80
		public bool HasSamePosition(global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition position)
		{
			return position != null && position.Column == this._column && position.Row == this._row && position.ColumnSpan == this._columnSpan && position.RowSpan == this._rowSpan;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00029ABF File Offset: 0x00027CBF
		public void SetPosition(global::Infragistics.Windows.DataPresenter.FieldPosition position)
		{
			this.Column = position.Column;
			this.Row = position.Row;
			this.ColumnSpan = position.ColumnSpan;
			this.RowSpan = position.RowSpan;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00029AF5 File Offset: 0x00027CF5
		public void SetPosition(int column, int row, int columnSpan, int rowSpan)
		{
			this.Column = column;
			this.Row = row;
			this.ColumnSpan = columnSpan;
			this.RowSpan = rowSpan;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00029B14 File Offset: 0x00027D14
		internal static bool HasSameRowColumn(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x != null && y != null && x._column == y._column && x._row == y._row;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00029B3A File Offset: 0x00027D3A
		internal void UpdateExplicitSetPositionTimeStamp()
		{
			this._explicitSetPositionTimeStamp = ++global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.g_explicitSetPositionTimeStampCounter;
		}

		// Token: 0x040003DF RID: 991
		private int _row;

		// Token: 0x040003E0 RID: 992
		private int _column;

		// Token: 0x040003E1 RID: 993
		private int _rowSpan;

		// Token: 0x040003E2 RID: 994
		private int _columnSpan;

		// Token: 0x040003E3 RID: 995
		private global::System.Windows.Visibility _visibility;

		// Token: 0x040003E4 RID: 996
		internal global::Infragistics.Windows.DataPresenter.FixedFieldLocation _fixedLocation;

		// Token: 0x040003E5 RID: 997
		private static int g_explicitSetPositionTimeStampCounter;

		// Token: 0x040003E6 RID: 998
		internal int _explicitSetPositionTimeStamp;
	}
}
