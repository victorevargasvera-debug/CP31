using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027D RID: 637
	public class SummaryRow : global::Infragistics.Controls.Grids.Row
	{
		// Token: 0x06001529 RID: 5417 RVA: 0x0004DA9D File Offset: 0x0004BC9D
		protected internal SummaryRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(-1, manager, null)
		{
			base.FixedPositionSortOrder = 4;
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0004DAAF File Offset: 0x0004BCAF
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHeight.Dynamic;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x0004DAB6 File Offset: 0x0004BCB6
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.SummaryRow;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0004DABA File Offset: 0x0004BCBA
		public override bool HasChildren
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x0004DABD File Offset: 0x0004BCBD
		protected internal override global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return global::Infragistics.Controls.Grids.EditingType.None;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		protected internal override bool AllowSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0004DAC3 File Offset: 0x0004BCC3
		protected internal override bool AllowKeyboardNavigation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0004DAC6 File Offset: 0x0004BCC6
		protected internal override bool RequiresFixedRowSeparator
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0004DACC File Offset: 0x0004BCCC
		protected internal virtual void InvalidateRow()
		{
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this.Cells)
			{
				cellBase.Refresh();
			}
		}
	}
}
