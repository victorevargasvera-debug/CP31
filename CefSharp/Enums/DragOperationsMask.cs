using System;

namespace CefSharp.Enums
{
	// Token: 0x0200011E RID: 286
	[global::System.Flags]
	public enum DragOperationsMask : uint
	{
		// Token: 0x04000457 RID: 1111
		None = 0U,
		// Token: 0x04000458 RID: 1112
		Copy = 1U,
		// Token: 0x04000459 RID: 1113
		Link = 2U,
		// Token: 0x0400045A RID: 1114
		Generic = 4U,
		// Token: 0x0400045B RID: 1115
		Private = 8U,
		// Token: 0x0400045C RID: 1116
		Move = 16U,
		// Token: 0x0400045D RID: 1117
		Delete = 32U,
		// Token: 0x0400045E RID: 1118
		Every = 4294967295U
	}
}
