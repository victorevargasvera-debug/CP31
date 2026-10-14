using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000122 RID: 290
	public class LastPageControlCommand : global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00025718 File Offset: 0x00023918
		protected override bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			return pager.CurrentPageIndex < pager.TotalPages;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00025728 File Offset: 0x00023928
		protected override void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			pager.OnLastPage();
		}
	}
}
