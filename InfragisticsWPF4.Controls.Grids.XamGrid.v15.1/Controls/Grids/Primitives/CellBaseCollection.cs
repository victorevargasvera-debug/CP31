using System;
using System.Collections.Generic;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F1 RID: 497
	public class CellBaseCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.CellBase>
	{
		// Token: 0x06000E01 RID: 3585 RVA: 0x000346BB File Offset: 0x000328BB
		public CellBaseCollection(global::Infragistics.Controls.Grids.ColumnBaseCollection columns, global::Infragistics.Controls.Grids.RowBase row)
		{
			this._row = row;
			this._columns = columns;
			this._auxColumns = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnBase, global::Infragistics.Controls.Grids.CellBase>();
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000346DC File Offset: 0x000328DC
		protected override int GetCount()
		{
			int result = 0;
			if (this._row != null)
			{
				result = this._columns.DataColumns.Count;
			}
			return result;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00034705 File Offset: 0x00032905
		public override int IndexOf(global::Infragistics.Controls.Grids.CellBase item)
		{
			return this._columns.DataColumns.IndexOf(item.Column);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003471D File Offset: 0x0003291D
		protected override global::Infragistics.Controls.Grids.CellBase GetItem(int index)
		{
			return this[this._columns.DataColumns[index]];
		}

		// Token: 0x1700041B RID: 1051
		public global::Infragistics.Controls.Grids.CellBase this[global::Infragistics.Controls.Grids.Column column]
		{
			get
			{
				if (this._auxColumns.ContainsKey(column))
				{
					return this._auxColumns[column];
				}
				global::Infragistics.Controls.Grids.CellBase cellBase = column.GenerateCell(this._row);
				this.Items.Add(cellBase);
				this._auxColumns.Add(column, cellBase);
				return cellBase;
			}
		}

		// Token: 0x1700041C RID: 1052
		public global::Infragistics.Controls.Grids.CellBase this[string key]
		{
			get
			{
				return this[this._columns.DataColumns[key]];
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x000347A0 File Offset: 0x000329A0
		protected global::Infragistics.Controls.Grids.RowBase Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000347A8 File Offset: 0x000329A8
		internal void Reset()
		{
			this._auxColumns.Clear();
			this.Items.Clear();
		}

		// Token: 0x04000490 RID: 1168
		private global::Infragistics.Controls.Grids.RowBase _row;

		// Token: 0x04000491 RID: 1169
		private global::Infragistics.Controls.Grids.ColumnBaseCollection _columns;

		// Token: 0x04000492 RID: 1170
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnBase, global::Infragistics.Controls.Grids.CellBase> _auxColumns;
	}
}
