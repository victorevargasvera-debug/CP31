using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000142 RID: 322
	[global::System.Flags]
	public enum TabControlStates : long
	{
		// Token: 0x04000527 RID: 1319
		AllowMinimized = 1L,
		// Token: 0x04000528 RID: 1320
		HasSelectedTab = 2L,
		// Token: 0x04000529 RID: 1321
		HasSelectableTab = 4L,
		// Token: 0x0400052A RID: 1322
		FirstTabSelected = 8L,
		// Token: 0x0400052B RID: 1323
		LastTabSelected = 16L,
		// Token: 0x0400052C RID: 1324
		Minimized = 32L,
		// Token: 0x0400052D RID: 1325
		SelectedTabAllowsClosing = 64L
	}
}
