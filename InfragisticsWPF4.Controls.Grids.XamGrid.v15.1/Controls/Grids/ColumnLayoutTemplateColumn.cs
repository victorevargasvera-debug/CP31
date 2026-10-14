using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200023F RID: 575
	internal class ColumnLayoutTemplateColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x00043A8C File Offset: 0x00041C8C
		internal ColumnLayoutTemplateColumn()
		{
			this._width = new global::Infragistics.Controls.Grids.ColumnWidth(1.0, true);
			base.AddNewRowItemTemplateHorizontalContentAlignment = (base.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Stretch);
			base.AddNewRowItemTemplateVerticalContentAlignment = (base.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Stretch);
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00043AD4 File Offset: 0x00041CD4
		public override global::Infragistics.Controls.Grids.ColumnWidth WidthResolved
		{
			get
			{
				return this._width;
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00043ADC File Offset: 0x00041CDC
		protected internal override global::Infragistics.Controls.Grids.CellBase GenerateCell(global::Infragistics.Controls.Grids.RowBase row)
		{
			global::Infragistics.Controls.Grids.CellBase result = null;
			if (row is global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateRow)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateCell(row, this);
			}
			return result;
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x00043AFC File Offset: 0x00041CFC
		public override bool IsResizable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x00043AFF File Offset: 0x00041CFF
		public override bool IsFixable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x00043B02 File Offset: 0x00041D02
		public override bool IsSortable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00043B05 File Offset: 0x00041D05
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return null;
		}

		// Token: 0x040005B0 RID: 1456
		private global::Infragistics.Controls.Grids.ColumnWidth _width;
	}
}
