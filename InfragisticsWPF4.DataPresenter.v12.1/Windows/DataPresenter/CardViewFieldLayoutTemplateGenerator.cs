using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D2 RID: 722
	public class CardViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator
	{
		// Token: 0x06002249 RID: 8777 RVA: 0x00095A48 File Offset: 0x00093C48
		public CardViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : this(fieldLayout, null, false)
		{
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00095A66 File Offset: 0x00093C66
		public CardViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation? orientation, bool recordsArrangedInRowsAndCols) : base(fieldLayout)
		{
			this._orientation = orientation;
			this._recordsArrangedInRowsAndCols = recordsArrangedInRowsAndCols;
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00095A7D File Offset: 0x00093C7D
		internal override bool AreRecordsArrangedInRowsAndCols
		{
			get
			{
				return this._recordsArrangedInRowsAndCols;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00095A85 File Offset: 0x00093C85
		public override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x00095A88 File Offset: 0x00093C88
		public override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00095A8C File Offset: 0x00093C8C
		public override global::Infragistics.Windows.DataPresenter.PanelNavigationDirection GetRecordNavigationDirectionFromCellNavigationDirection(global::Infragistics.Windows.DataPresenter.PanelNavigationDirection cellNavigationDirection)
		{
			if (!this.HasLogicalOrientation)
			{
				return cellNavigationDirection;
			}
			switch (cellNavigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				return global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below;
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
			default:
				return cellNavigationDirection;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x00095AE8 File Offset: 0x00093CE8
		public override bool HasLogicalOrientation
		{
			get
			{
				return this._orientation != null;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00095AF5 File Offset: 0x00093CF5
		public override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				if (this._orientation == null)
				{
					return global::System.Windows.Controls.Orientation.Vertical;
				}
				return this._orientation.Value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00095B11 File Offset: 0x00093D11
		public override global::Infragistics.Windows.DataPresenter.CellContentAlignment PrimaryFieldDefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
		}

		// Token: 0x040010C8 RID: 4296
		private global::System.Windows.Controls.Orientation? _orientation;

		// Token: 0x040010C9 RID: 4297
		private bool _recordsArrangedInRowsAndCols;
	}
}
