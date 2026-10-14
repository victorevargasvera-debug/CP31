using System;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000041 RID: 65
	[global::System.Flags]
	internal enum AllowedDropLocations
	{
		// Token: 0x040001D1 RID: 465
		Left = 1,
		// Token: 0x040001D2 RID: 466
		Top = 2,
		// Token: 0x040001D3 RID: 467
		Right = 4,
		// Token: 0x040001D4 RID: 468
		Bottom = 8,
		// Token: 0x040001D5 RID: 469
		Floating = 16,
		// Token: 0x040001D6 RID: 470
		Document = 32,
		// Token: 0x040001D7 RID: 471
		Docked = 15,
		// Token: 0x040001D8 RID: 472
		All = 63
	}
}
