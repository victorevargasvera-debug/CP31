using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D0 RID: 720
	public class GridViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator
	{
		// Token: 0x0600223D RID: 8765 RVA: 0x0009596B File Offset: 0x00093B6B
		public GridViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation orientation) : base(fieldLayout)
		{
			this._orientation = orientation;
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0009597B File Offset: 0x00093B7B
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00095983 File Offset: 0x00093B83
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return this._orientation;
			}
			set
			{
				if (value != this._orientation)
				{
					this._orientation = value;
					base.InvalidateGeneratedTemplates();
				}
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0009599B File Offset: 0x00093B9B
		public override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				if (this._orientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
				}
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x000959A8 File Offset: 0x00093BA8
		protected override global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation DefaultAutoArrangePrimaryFieldReservation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstCell;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000959AB File Offset: 0x00093BAB
		public override global::Infragistics.Windows.DataPresenter.CellContentAlignment DefaultCellContentAlignment
		{
			get
			{
				if (this._orientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch;
				}
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000959B9 File Offset: 0x00093BB9
		public override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x000959BC File Offset: 0x00093BBC
		public override global::Infragistics.Windows.DataPresenter.PanelNavigationDirection GetRecordNavigationDirectionFromCellNavigationDirection(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection cellNavigationDirection)
		{
			switch (cellNavigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below;
				}
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				if (this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above;
				}
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left;
			}
			return cellNavigationDirection;
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00095A30 File Offset: 0x00093C30
		public override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return this._orientation;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00095A38 File Offset: 0x00093C38
		public override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040010C7 RID: 4295
		private global::System.Windows.Controls.Orientation _orientation;
	}
}
