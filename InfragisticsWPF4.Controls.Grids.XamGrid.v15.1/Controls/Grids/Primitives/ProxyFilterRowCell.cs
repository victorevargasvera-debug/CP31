using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000261 RID: 609
	internal class ProxyFilterRowCell : global::Infragistics.Controls.Grids.Primitives.FilterRowCell
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x00049A55 File Offset: 0x00047C55
		protected internal ProxyFilterRowCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x00049A60 File Offset: 0x00047C60
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x00049AA0 File Offset: 0x00047CA0
		public override object FilterCellValue
		{
			get
			{
				if (base.Row != null && base.Row.Data != null)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)base.Row.Data;
					return xamGridConditionInfo.FilterValue;
				}
				return this._filterCellValue;
			}
			set
			{
				if (base.Row != null && base.Row.Data != null)
				{
					global::Infragistics.Controls.Grids.XamGridConditionInfo xamGridConditionInfo = (global::Infragistics.Controls.Grids.XamGridConditionInfo)base.Row.Data;
					xamGridConditionInfo.FilterValue = value;
				}
				this._filterCellValue = value;
			}
		}

		// Token: 0x04000601 RID: 1537
		private object _filterCellValue;
	}
}
