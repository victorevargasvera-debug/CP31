using System;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000063 RID: 99
	[global::System.Flags]
	internal enum PaneFilterFlags
	{
		// Token: 0x0400025A RID: 602
		Docked = 1,
		// Token: 0x0400025B RID: 603
		Document = 2,
		// Token: 0x0400025C RID: 604
		FloatingOnly = 4,
		// Token: 0x0400025D RID: 605
		FloatingDockable = 8,
		// Token: 0x0400025E RID: 606
		Unpinned = 16,
		// Token: 0x0400025F RID: 607
		Hidden = 32,
		// Token: 0x04000260 RID: 608
		IgnoreFloatingWindowVisibility = 64,
		// Token: 0x04000261 RID: 609
		AllVisibleExceptDocument = -99,
		// Token: 0x04000262 RID: 610
		AllVisible = -97,
		// Token: 0x04000263 RID: 611
		All = -1
	}
}
