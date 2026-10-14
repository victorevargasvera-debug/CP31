using System;

namespace Infragistics.Windows.Selection
{
	// Token: 0x0200025E RID: 606
	public interface ISelectableItem
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001823 RID: 6179
		bool IsSelected { get; }

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001824 RID: 6180
		bool IsSelectable { get; }

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001825 RID: 6181
		bool IsDraggable { get; }

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001826 RID: 6182
		bool IsTabStop { get; }
	}
}
