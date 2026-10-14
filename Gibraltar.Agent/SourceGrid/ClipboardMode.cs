using System;

namespace SourceGrid
{
	// Token: 0x020003DE RID: 990
	[global::System.Flags]
	internal enum ClipboardMode
	{
		// Token: 0x04000F0C RID: 3852
		None = 0,
		// Token: 0x04000F0D RID: 3853
		Copy = 1,
		// Token: 0x04000F0E RID: 3854
		Cut = 2,
		// Token: 0x04000F0F RID: 3855
		Paste = 4,
		// Token: 0x04000F10 RID: 3856
		Delete = 8,
		// Token: 0x04000F11 RID: 3857
		All = 15
	}
}
