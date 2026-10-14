using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200025C RID: 604
	internal sealed class PagerColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x00048C84 File Offset: 0x00046E84
		internal PagerColumn()
		{
			this._width = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, true);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00048CA1 File Offset: 0x00046EA1
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00048CAC File Offset: 0x00046EAC
		protected internal override global::Infragistics.Controls.Grids.CellBase GenerateCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			global::Infragistics.Controls.Grids.CellBase result = null;
			if (row is global::Infragistics.Controls.Grids.Primitives.PagerRow)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.PagerCell(row, this);
			}
			return result;
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00048CCC File Offset: 0x00046ECC
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00048CCF File Offset: 0x00046ECF
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x040005F4 RID: 1524
		private global::Infragistics.Controls.Grids.ColumnWidth _width;
	}
}
