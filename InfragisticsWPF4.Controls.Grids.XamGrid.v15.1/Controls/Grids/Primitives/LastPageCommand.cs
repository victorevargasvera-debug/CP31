using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011B RID: 283
	public class LastPageCommand : global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x00025558 File Offset: 0x00023758
		protected override void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			if (rowsBase.CurrentPageIndex < rowsBase.PageCount)
			{
				rowsBase.CurrentPageIndex = rowsBase.PageCount;
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00025574 File Offset: 0x00023774
		protected override bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			return rowsBase.CurrentPageIndex < rowsBase.PageCount;
		}
	}
}
