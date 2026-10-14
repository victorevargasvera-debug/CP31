using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011C RID: 284
	public class NextPageCommand : global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x0002558C File Offset: 0x0002378C
		protected override void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			if (rowsBase.CurrentPageIndex < rowsBase.PageCount)
			{
				rowsBase.CurrentPageIndex++;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000255AA File Offset: 0x000237AA
		protected override bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			return rowsBase.CurrentPageIndex < rowsBase.PageCount;
		}
	}
}
