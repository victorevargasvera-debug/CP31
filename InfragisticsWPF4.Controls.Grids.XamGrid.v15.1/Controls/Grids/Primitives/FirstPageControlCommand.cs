using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200011F RID: 287
	public class FirstPageControlCommand : global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x000256C2 File Offset: 0x000238C2
		protected override bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			return pager.CurrentPageIndex > 1;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x000256CD File Offset: 0x000238CD
		protected override void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			pager.OnFirstPage();
		}
	}
}
