using System;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000010 RID: 16
	internal interface ISelectableItem
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006B RID: 107
		bool IsSelected { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600006C RID: 108
		bool IsSelectable { get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600006D RID: 109
		bool IsDraggable { get; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006E RID: 110
		bool IsTabStop { get; }
	}
}
