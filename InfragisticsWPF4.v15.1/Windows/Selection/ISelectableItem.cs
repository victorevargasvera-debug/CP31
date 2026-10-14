using System;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000297 RID: 663
	public interface ISelectableItem
	{
		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001A33 RID: 6707
		bool IsSelected { get; }

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001A34 RID: 6708
		bool IsSelectable { get; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001A35 RID: 6709
		bool IsDraggable { get; }

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001A36 RID: 6710
		bool IsTabStop { get; }
	}
}
