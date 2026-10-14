using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200030F RID: 783
	public class GridViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator
	{
		// Token: 0x060025D1 RID: 9681 RVA: 0x000A8DCB File Offset: 0x000A6FCB
		public GridViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation orientation) : base(fieldLayout)
		{
			this._orientation = orientation;
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x060025D2 RID: 9682 RVA: 0x000A8DDB File Offset: 0x000A6FDB
		// (set) Token: 0x060025D3 RID: 9683 RVA: 0x000A8DE3 File Offset: 0x000A6FE3
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

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000A8DFB File Offset: 0x000A6FFB
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

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000A8E08 File Offset: 0x000A7008
		protected override global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation DefaultAutoArrangePrimaryFieldReservation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangePrimaryFieldReservation.ReserveFirstCell;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000A8E0B File Offset: 0x000A700B
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

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000A8E19 File Offset: 0x000A7019
		public override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x000A8E1C File Offset: 0x000A701C
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

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000A8E90 File Offset: 0x000A7090
		public override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return this._orientation;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A8E98 File Offset: 0x000A7098
		public override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040012DD RID: 4829
		private global::System.Windows.Controls.Orientation _orientation;
	}
}
