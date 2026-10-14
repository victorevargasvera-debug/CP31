using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000243 RID: 579
	[global::System.Flags]
	public enum AllowClipboardOperations
	{
		// Token: 0x04000E6A RID: 3690
		None = 0,
		// Token: 0x04000E6B RID: 3691
		Cut = 1,
		// Token: 0x04000E6C RID: 3692
		Copy = 2,
		// Token: 0x04000E6D RID: 3693
		Paste = 4,
		// Token: 0x04000E6E RID: 3694
		ClearContents = 8,
		// Token: 0x04000E6F RID: 3695
		All = -1
	}
}
