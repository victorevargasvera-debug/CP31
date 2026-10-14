using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000189 RID: 393
	internal class GridDefinitionLayoutItem : global::Infragistics.Windows.DataPresenter.LayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x00073941 File Offset: 0x00071B41
		internal GridDefinitionLayoutItem(global::System.Windows.Controls.RowDefinition row, int originY, bool usingCellPresenters) : this(row, 0, originY, usingCellPresenters)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0007394D File Offset: 0x00071B4D
		internal GridDefinitionLayoutItem(global::System.Windows.Controls.ColumnDefinition col, int originX, bool usingCellPresenters) : this(col, originX, 0, usingCellPresenters)
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0007395C File Offset: 0x00071B5C
		private GridDefinitionLayoutItem(global::System.Windows.Controls.DefinitionBase rowCol, int originX, int originY, bool usingCellPresenters)
		{
			if (usingCellPresenters)
			{
				originX *= 2;
				originY *= 2;
			}
			this._rowCol = rowCol;
			global::System.Windows.Controls.RowDefinition rowDefinition = this._rowCol as global::System.Windows.Controls.RowDefinition;
			global::System.Windows.Controls.ColumnDefinition columnDefinition = this._rowCol as global::System.Windows.Controls.ColumnDefinition;
			this._originX = originX;
			this._originY = originY;
			this._span = (usingCellPresenters ? 2 : 1);
			if (columnDefinition != null)
			{
				this._weightX = (columnDefinition.Width.IsStar ? ((float)columnDefinition.Width.Value) : 0f);
				this._preferredX = (columnDefinition.Width.IsAbsolute ? columnDefinition.Width.Value : 0.0);
				return;
			}
			this._weightY = (rowDefinition.Height.IsStar ? ((float)rowDefinition.Height.Value) : 0f);
			this._preferredY = (rowDefinition.Height.IsAbsolute ? rowDefinition.Height.Value : 0.0);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060018DD RID: 6365 RVA: 0x00073A78 File Offset: 0x00071C78
		public override double PreferredWidth
		{
			get
			{
				return this._preferredX;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00073A80 File Offset: 0x00071C80
		public override double PreferredHeight
		{
			get
			{
				return this._preferredY;
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00073A88 File Offset: 0x00071C88
		internal static bool IsItemNeeded(global::System.Windows.Controls.RowDefinition row)
		{
			return !row.Height.IsAuto || row.MinHeight != 0.0 || !double.IsPositiveInfinity(row.MaxHeight);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00073AC8 File Offset: 0x00071CC8
		internal static bool IsItemNeeded(global::System.Windows.Controls.ColumnDefinition col)
		{
			return !col.Width.IsAuto || col.MinWidth != 0.0 || !double.IsPositiveInfinity(col.MaxWidth);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00073B08 File Offset: 0x00071D08
		public override double GetSize(global::Infragistics.Windows.DataPresenter.LayoutItemSize size)
		{
			global::System.Windows.Controls.RowDefinition rowDefinition = this._rowCol as global::System.Windows.Controls.RowDefinition;
			global::System.Windows.Controls.ColumnDefinition columnDefinition = this._rowCol as global::System.Windows.Controls.ColumnDefinition;
			switch (size)
			{
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinWidth:
				if (columnDefinition == null)
				{
					return 0.0;
				}
				return columnDefinition.MinWidth;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth:
				return this.PreferredWidth;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxWidth:
				if (columnDefinition == null)
				{
					return double.PositiveInfinity;
				}
				return columnDefinition.MaxWidth;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MinHeight:
				if (rowDefinition == null)
				{
					return 0.0;
				}
				return rowDefinition.MinHeight;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight:
				return this.PreferredHeight;
			case global::Infragistics.Windows.DataPresenter.LayoutItemSize.MaxHeight:
				if (rowDefinition == null)
				{
					return double.PositiveInfinity;
				}
				return rowDefinition.MaxHeight;
			default:
				return 0.0;
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00073BB6 File Offset: 0x00071DB6
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00073BB9 File Offset: 0x00071DB9
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredY = value;
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00073BC2 File Offset: 0x00071DC2
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredX = value;
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00073BCB File Offset: 0x00071DCB
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this._originX;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00073BD3 File Offset: 0x00071DD3
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00073BDB File Offset: 0x00071DDB
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this._weightX;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00073BE3 File Offset: 0x00071DE3
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return global::System.Windows.HorizontalAlignment.Left;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00073BE6 File Offset: 0x00071DE6
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem.EmptyThickness;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00073BED File Offset: 0x00071DED
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this._originY;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00073BF5 File Offset: 0x00071DF5
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00073BFD File Offset: 0x00071DFD
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this._weightY;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00073C05 File Offset: 0x00071E05
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return global::System.Windows.VerticalAlignment.Top;
			}
		}

		// Token: 0x04000A30 RID: 2608
		private global::System.Windows.Controls.DefinitionBase _rowCol;

		// Token: 0x04000A31 RID: 2609
		private int _originX;

		// Token: 0x04000A32 RID: 2610
		private int _originY;

		// Token: 0x04000A33 RID: 2611
		private float _weightX;

		// Token: 0x04000A34 RID: 2612
		private float _weightY;

		// Token: 0x04000A35 RID: 2613
		private int _span;

		// Token: 0x04000A36 RID: 2614
		private static readonly global::System.Windows.Thickness EmptyThickness = default(global::System.Windows.Thickness);

		// Token: 0x04000A37 RID: 2615
		private double _preferredX;

		// Token: 0x04000A38 RID: 2616
		private double _preferredY;
	}
}
