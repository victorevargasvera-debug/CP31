using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011D RID: 285
	public class GoToPageCommand : global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x000255C2 File Offset: 0x000237C2
		protected override void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase, int pageIndex)
		{
			if (rowsBase.PageCount >= pageIndex && rowsBase.CurrentPageIndex != pageIndex)
			{
				rowsBase.CurrentPageIndex = pageIndex;
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000255DD File Offset: 0x000237DD
		protected override bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase, int rowIndex)
		{
			return rowsBase.CurrentPageIndex != rowIndex && rowIndex > 0 && rowsBase.PageCount >= rowIndex;
		}
	}
}
