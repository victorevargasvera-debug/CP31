using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000239 RID: 569
	public sealed class ChildBandColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x0003EB81 File Offset: 0x0003CD81
		internal ChildBandColumn()
		{
			this._width = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, true);
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x0003EB9E File Offset: 0x0003CD9E
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0003EBA8 File Offset: 0x0003CDA8
		protected internal override global::Infragistics.Controls.Grids.CellBase GenerateCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			global::Infragistics.Controls.Grids.CellBase result = null;
			if (row is global::Infragistics.Controls.Grids.Primitives.ChildBand)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ChildBandCell(row, this);
			}
			return result;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0003EBC8 File Offset: 0x0003CDC8
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x0400054F RID: 1359
		private global::Infragistics.Controls.Grids.ColumnWidth _width;
	}
}
