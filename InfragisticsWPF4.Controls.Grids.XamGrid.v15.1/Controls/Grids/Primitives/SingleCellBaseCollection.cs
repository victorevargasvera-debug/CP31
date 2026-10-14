using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200022B RID: 555
	public class SingleCellBaseCollection<T> : global::Infragistics.Controls.Grids.Primitives.CellBaseCollection
	{
		// Token: 0x06000F9C RID: 3996 RVA: 0x0003B2C4 File Offset: 0x000394C4
		public SingleCellBaseCollection(global::Infragistics.Controls.Grids.Column owningColumn, global::Infragistics.Controls.Grids.ColumnBaseCollection columns, global::Infragistics.Controls.Grids.RowBase row) : base(columns, row)
		{
			this._owningColumn = owningColumn;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0003B2D5 File Offset: 0x000394D5
		protected override int GetCount()
		{
			return 1;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0003B2D8 File Offset: 0x000394D8
		public override int IndexOf(global::Infragistics.Controls.Grids.CellBase item)
		{
			if (item is T)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0003B2E5 File Offset: 0x000394E5
		protected override global::Infragistics.Controls.Grids.CellBase GetItem(int index)
		{
			if (index == 0)
			{
				return base[this._owningColumn];
			}
			return null;
		}

		// Token: 0x040004E8 RID: 1256
		private global::Infragistics.Controls.Grids.Column _owningColumn;
	}
}
