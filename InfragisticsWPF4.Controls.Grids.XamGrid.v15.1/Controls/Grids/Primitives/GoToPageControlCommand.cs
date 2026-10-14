using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000123 RID: 291
	public class GoToPageControlCommand : global::Infragistics.Controls.Grids.Primitives.PagingControlCommandBase
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x00025738 File Offset: 0x00023938
		protected override void ExecutePagingCommand(global::Infragistics.Controls.Grids.Primitives.PagerControlBase pager, int rowIndex)
		{
			pager.OnGoToPage(rowIndex);
		}
	}
}
