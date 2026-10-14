using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000120 RID: 288
	public class PreviousPageControlCommand : global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x000256DD File Offset: 0x000238DD
		protected override void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			pager.OnPreviousPage();
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000256E5 File Offset: 0x000238E5
		protected override bool CanExecutePagingControl(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager)
		{
			return pager.CurrentPageIndex > 1;
		}
	}
}
