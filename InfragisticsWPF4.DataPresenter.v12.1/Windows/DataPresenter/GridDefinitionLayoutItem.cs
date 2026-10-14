using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200016D RID: 365
	internal class GridDefinitionLayoutItem : global::Infragistics.Windows.DataPresenter.LayoutItem, global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x00061825 File Offset: 0x0005FA25
		internal GridDefinitionLayoutItem(global::System.Windows.Controls.RowDefinition row, int originY, bool usingCellPresenters) : this(row, 0, originY, usingCellPresenters)
		{
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00061831 File Offset: 0x0005FA31
		internal GridDefinitionLayoutItem(global::System.Windows.Controls.ColumnDefinition col, int originX, bool usingCellPresenters) : this(col, originX, 0, usingCellPresenters)
		{
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00061840 File Offset: 0x0005FA40
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0006195C File Offset: 0x0005FB5C
		public override double PreferredWidth
		{
			get
			{
				return this._preferredX;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00061964 File Offset: 0x0005FB64
		public override double PreferredHeight
		{
			get
			{
				return this._preferredY;
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0006196C File Offset: 0x0005FB6C
		internal static bool IsItemNeeded(global::System.Windows.Controls.RowDefinition row)
		{
			return !row.Height.IsAuto || row.MinHeight != 0.0 || !double.IsPositiveInfinity(row.MaxHeight);
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x000619AC File Offset: 0x0005FBAC
		internal static bool IsItemNeeded(global::System.Windows.Controls.ColumnDefinition col)
		{
			return !col.Width.IsAuto || col.MinWidth != 0.0 || !double.IsPositiveInfinity(col.MaxWidth);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000619EC File Offset: 0x0005FBEC
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

		// Token: 0x06001562 RID: 5474 RVA: 0x00061A9A File Offset: 0x0005FC9A
		protected override global::System.Windows.Visibility GetVisibility()
		{
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00061A9D File Offset: 0x0005FC9D
		public override void SetPreferredHeight(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredY = value;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00061AA6 File Offset: 0x0005FCA6
		public override void SetPreferredWidth(double value, global::Infragistics.Windows.DataPresenter.ItemSizeType type)
		{
			this._preferredX = value;
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00061AAF File Offset: 0x0005FCAF
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Column
		{
			get
			{
				return this._originX;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00061AB7 File Offset: 0x0005FCB7
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnSpan
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00061ABF File Offset: 0x0005FCBF
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.ColumnWeight
		{
			get
			{
				return this._weightX;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00061AC7 File Offset: 0x0005FCC7
		global::System.Windows.HorizontalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.HorizontalAlignment
		{
			get
			{
				return global::System.Windows.HorizontalAlignment.Left;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00061ACA File Offset: 0x0005FCCA
		global::System.Windows.Thickness global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Margin
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.GridDefinitionLayoutItem.EmptyThickness;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00061AD1 File Offset: 0x0005FCD1
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.Row
		{
			get
			{
				return this._originY;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00061AD9 File Offset: 0x0005FCD9
		int global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowSpan
		{
			get
			{
				return this._span;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00061AE1 File Offset: 0x0005FCE1
		float global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.RowWeight
		{
			get
			{
				return this._weightY;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00061AE9 File Offset: 0x0005FCE9
		global::System.Windows.VerticalAlignment global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint.VerticalAlignment
		{
			get
			{
				return global::System.Windows.VerticalAlignment.Top;
			}
		}

		// Token: 0x0400087A RID: 2170
		private global::System.Windows.Controls.DefinitionBase _rowCol;

		// Token: 0x0400087B RID: 2171
		private int _originX;

		// Token: 0x0400087C RID: 2172
		private int _originY;

		// Token: 0x0400087D RID: 2173
		private float _weightX;

		// Token: 0x0400087E RID: 2174
		private float _weightY;

		// Token: 0x0400087F RID: 2175
		private int _span;

		// Token: 0x04000880 RID: 2176
		private static readonly global::System.Windows.Thickness EmptyThickness = default(global::System.Windows.Thickness);

		// Token: 0x04000881 RID: 2177
		private double _preferredX;

		// Token: 0x04000882 RID: 2178
		private double _preferredY;
	}
}
