using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000277 RID: 631
	public class FooterRow : global::Infragistics.Controls.Grids.RowBase
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x0004D41B File Offset: 0x0004B61B
		protected internal FooterRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(manager)
		{
			base.FixedPositionSortOrder = 1;
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0004D42B File Offset: 0x0004B62B
		protected internal override global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHoverType.Cell;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0004D42E File Offset: 0x0004B62E
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.FooterRow;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0004D434 File Offset: 0x0004B634
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.FooterRowHeightResolved;
			}
		}
	}
}
