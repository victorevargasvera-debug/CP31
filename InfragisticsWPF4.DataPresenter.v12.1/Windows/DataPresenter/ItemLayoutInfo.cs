using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000C3 RID: 195
	internal class ItemLayoutInfo
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x00025D7E File Offset: 0x00023F7E
		internal ItemLayoutInfo() : this(0, 0)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00025D88 File Offset: 0x00023F88
		internal ItemLayoutInfo(int column, int row) : this(column, row, 1, 1)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00025D94 File Offset: 0x00023F94
		internal ItemLayoutInfo(int column, int row, int columnSpan, int rowSpan)
		{
			this.Column = column;
			this.Row = row;
			this.ColumnSpan = columnSpan;
			this.RowSpan = rowSpan;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00025DB9 File Offset: 0x00023FB9
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00025DC1 File Offset: 0x00023FC1
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

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00025DD0 File Offset: 0x00023FD0
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00025DD8 File Offset: 0x00023FD8
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00025DE7 File Offset: 0x00023FE7
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00025DEF File Offset: 0x00023FEF
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00025DFE File Offset: 0x00023FFE
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00025E06 File Offset: 0x00024006
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00025E15 File Offset: 0x00024015
		internal int RowBottom
		{
			get
			{
				return this._row + this._rowSpan - 1;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00025E26 File Offset: 0x00024026
		internal int ColumnRight
		{
			get
			{
				return this._column + this._columnSpan - 1;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00025E37 File Offset: 0x00024037
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x00025E42 File Offset: 0x00024042
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

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00025E5A File Offset: 0x0002405A
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x00025E62 File Offset: 0x00024062
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

		// Token: 0x0600091F RID: 2335 RVA: 0x00025E6C File Offset: 0x0002406C
		public static bool AreEqual(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x == y || (x != null && y != null && x._column == y._column && x._row == y._row && x._columnSpan == y._columnSpan && x._rowSpan == y._rowSpan && x._fixedLocation == y._fixedLocation && x.Visibility == y.Visibility);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00025EDB File Offset: 0x000240DB
		public global::Infragistics.Windows.DataPresenter.ItemLayoutInfo Clone()
		{
			return (global::Infragistics.Windows.DataPresenter.ItemLayoutInfo)base.MemberwiseClone();
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00025EE8 File Offset: 0x000240E8
		public bool Contains(int column, int row)
		{
			return global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._column, this._columnSpan, column, 1) && global::Infragistics.Windows.DataPresenter.LayoutInfo.Intersects(this._row, this._rowSpan, row, 1);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00025F14 File Offset: 0x00024114
		public static global::Infragistics.Windows.DataPresenter.ItemLayoutInfo Create(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldPosition pos)
		{
			return new global::Infragistics.Windows.DataPresenter.ItemLayoutInfo(pos.Column, pos.Row, pos.ColumnSpan, pos.RowSpan)
			{
				Visibility = field.VisibilityInCellArea,
				_fixedLocation = field.FixedLocation
			};
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00025F5C File Offset: 0x0002415C
		public static bool HasSamePosition(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x._column == y._column && x._row == y._row && x._columnSpan == y._columnSpan && x._rowSpan == y._rowSpan;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00025F98 File Offset: 0x00024198
		public bool HasSamePosition(global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition position)
		{
			return position != null && position.Column == this._column && position.Row == this._row && position.ColumnSpan == this._columnSpan && position.RowSpan == this._rowSpan;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00025FD7 File Offset: 0x000241D7
		public void SetPosition(global::Infragistics.Windows.DataPresenter.FieldPosition position)
		{
			this.Column = position.Column;
			this.Row = position.Row;
			this.ColumnSpan = position.ColumnSpan;
			this.RowSpan = position.RowSpan;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0002600D File Offset: 0x0002420D
		internal static bool HasSameRowColumn(global::Infragistics.Windows.DataPresenter.ItemLayoutInfo x, global::Infragistics.Windows.DataPresenter.ItemLayoutInfo y)
		{
			return x != null && y != null && x._column == y._column && x._row == y._row;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00026033 File Offset: 0x00024233
		internal void UpdateExplicitSetPositionTimeStamp()
		{
			this._explicitSetPositionTimeStamp = ++global::Infragistics.Windows.DataPresenter.ItemLayoutInfo.g_explicitSetPositionTimeStampCounter;
		}

		// Token: 0x04000383 RID: 899
		private int _row;

		// Token: 0x04000384 RID: 900
		private int _column;

		// Token: 0x04000385 RID: 901
		private int _rowSpan;

		// Token: 0x04000386 RID: 902
		private int _columnSpan;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Visibility _visibility;

		// Token: 0x04000388 RID: 904
		internal global::Infragistics.Windows.DataPresenter.FixedFieldLocation _fixedLocation;

		// Token: 0x04000389 RID: 905
		private static int g_explicitSetPositionTimeStampCounter;

		// Token: 0x0400038A RID: 906
		internal int _explicitSetPositionTimeStamp;
	}
}
