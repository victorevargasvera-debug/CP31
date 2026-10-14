using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000119 RID: 281
	public class FirstPageCommand : global::Infragistics.Controls.Grids.Primitives.PagingBaseCommand
	{
		// Token: 0x06000972 RID: 2418 RVA: 0x00025501 File Offset: 0x00023701
		protected override void ExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			if (rowsBase.CurrentPageIndex > 1)
			{
				rowsBase.CurrentPageIndex = 1;
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00025513 File Offset: 0x00023713
		protected override bool CanExecutePaging(global::Infragistics.Controls.Grids.RowsManager rowsBase)
		{
			return rowsBase.CurrentPageIndex != 1;
		}
	}
}
