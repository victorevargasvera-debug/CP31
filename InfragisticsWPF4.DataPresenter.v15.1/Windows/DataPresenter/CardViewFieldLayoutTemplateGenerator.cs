using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000311 RID: 785
	public class CardViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator
	{
		// Token: 0x060025DD RID: 9693 RVA: 0x000A8EA8 File Offset: 0x000A70A8
		public CardViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout) : this(fieldLayout, null, false)
		{
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x000A8EC6 File Offset: 0x000A70C6
		public CardViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation? orientation, bool recordsArrangedInRowsAndCols) : base(fieldLayout)
		{
			this._orientation = orientation;
			this._recordsArrangedInRowsAndCols = recordsArrangedInRowsAndCols;
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000A8EDD File Offset: 0x000A70DD
		internal override bool AreRecordsArrangedInRowsAndCols
		{
			get
			{
				return this._recordsArrangedInRowsAndCols;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000A8EE5 File Offset: 0x000A70E5
		public override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000A8EE8 File Offset: 0x000A70E8
		public override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.CardView;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x000A8EEC File Offset: 0x000A70EC
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

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000A8F48 File Offset: 0x000A7148
		public override bool HasLogicalOrientation
		{
			get
			{
				return this._orientation != null;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000A8F55 File Offset: 0x000A7155
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

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000A8F71 File Offset: 0x000A7171
		public override global::Infragistics.Windows.DataPresenter.CellContentAlignment PrimaryFieldDefaultCellContentAlignment
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch;
			}
		}

		// Token: 0x040012DE RID: 4830
		private global::System.Windows.Controls.Orientation? _orientation;

		// Token: 0x040012DF RID: 4831
		private bool _recordsArrangedInRowsAndCols;
	}
}
