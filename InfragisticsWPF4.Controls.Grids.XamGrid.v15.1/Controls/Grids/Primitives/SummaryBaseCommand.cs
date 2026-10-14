using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000152 RID: 338
	public abstract class SummaryBaseCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00028FF8 File Offset: 0x000271F8
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Column column = parameter as global::Infragistics.Controls.Grids.Column;
			return column != null && column.IsSummable;
		}
	}
}
