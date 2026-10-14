using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011A RID: 282
	public class PreviousPageCommand : global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00025529 File Offset: 0x00023729
		protected override void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			if (rowsBase.CurrentPageIndex > 1)
			{
				rowsBase.CurrentPageIndex--;
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00025542 File Offset: 0x00023742
		protected override bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			return rowsBase.CurrentPageIndex != 1;
		}
	}
}
