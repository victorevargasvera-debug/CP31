using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000274 RID: 628
	public class ColumnLayoutTemplateRow : global::Infragistics.Controls.Grids.Row
	{
		// Token: 0x060014DF RID: 5343 RVA: 0x0004CE49 File Offset: 0x0004B049
		public ColumnLayoutTemplateRow(global::Infragistics.Controls.Grids.RowsManager manager, object data) : base(0, manager, data)
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0004CE54 File Offset: 0x0004B054
		protected internal override bool AllowKeyboardNavigation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x0004CE57 File Offset: 0x0004B057
		public override global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCell>(((global::Infragistics.Controls.Grids.RowsManager)base.Manager).ColumnLayoutTemplateColumn, base.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0004CE89 File Offset: 0x0004B089
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateRowCellsPanel);
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0004CE95 File Offset: 0x0004B095
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateRowCellsPanel();
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x0004CE9C File Offset: 0x0004B09C
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.ColumnLayoutTemplateRow;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
		protected internal override global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleCells
		{
			get
			{
				return new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>
				{
					this.Cells[0]
				};
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x0004CEC6 File Offset: 0x0004B0C6
		protected internal override bool CanBeDeleted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000659 RID: 1625
		private global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCell> _cells;
	}
}
