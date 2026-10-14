using System;

namespace SourceGrid
{
	// Token: 0x020003D3 RID: 979
	[global::System.Flags]
	internal enum EditableMode
	{
		// Token: 0x04000ECC RID: 3788
		None = 0,
		// Token: 0x04000ECD RID: 3789
		F2Key = 1,
		// Token: 0x04000ECE RID: 3790
		DoubleClick = 2,
		// Token: 0x04000ECF RID: 3791
		SingleClick = 4,
		// Token: 0x04000ED0 RID: 3792
		AnyKey = 9,
		// Token: 0x04000ED1 RID: 3793
		Focus = 16,
		// Token: 0x04000ED2 RID: 3794
		Default = 11
	}
}
