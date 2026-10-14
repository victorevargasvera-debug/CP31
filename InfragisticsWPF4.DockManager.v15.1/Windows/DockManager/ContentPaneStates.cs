using System;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000051 RID: 81
	[global::System.Flags]
	public enum ContentPaneStates : long
	{
		// Token: 0x040001F9 RID: 505
		IsActiveDocument = 1L,
		// Token: 0x040001FA RID: 506
		IsActivePane = 2L,
		// Token: 0x040001FB RID: 507
		AllowClose = 4L,
		// Token: 0x040001FC RID: 508
		IsDocument = 8L,
		// Token: 0x040001FD RID: 509
		IsFloating = 16L,
		// Token: 0x040001FE RID: 510
		IsFloatingDockable = 32L,
		// Token: 0x040001FF RID: 511
		IsFloatingOnly = 64L,
		// Token: 0x04000200 RID: 512
		IsUnpinned = 128L,
		// Token: 0x04000201 RID: 513
		IsDocked = 256L
	}
}
