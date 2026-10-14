using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020F RID: 527
	[global::System.Flags]
	public enum AllowClipboardOperations
	{
		// Token: 0x04000C4A RID: 3146
		None = 0,
		// Token: 0x04000C4B RID: 3147
		Cut = 1,
		// Token: 0x04000C4C RID: 3148
		Copy = 2,
		// Token: 0x04000C4D RID: 3149
		Paste = 4,
		// Token: 0x04000C4E RID: 3150
		ClearContents = 8,
		// Token: 0x04000C4F RID: 3151
		All = -1
	}
}
