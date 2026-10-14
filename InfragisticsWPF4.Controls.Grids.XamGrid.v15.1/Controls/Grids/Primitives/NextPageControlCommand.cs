using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000121 RID: 289
	public class NextPageControlCommand : global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x000256F8 File Offset: 0x000238F8
		protected override void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			pager.OnNextPage();
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00025700 File Offset: 0x00023900
		protected override bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			return pager.CurrentPageIndex < pager.TotalPages;
		}
	}
}
