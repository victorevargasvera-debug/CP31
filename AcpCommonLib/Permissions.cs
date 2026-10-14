using System;

namespace AcpCommonLib
{
	// Token: 0x02000024 RID: 36
	public enum Permissions
	{
		// Token: 0x0400008D RID: 141
		None,
		// Token: 0x0400008E RID: 142
		Undeletable,
		// Token: 0x0400008F RID: 143
		DragDisabled,
		// Token: 0x04000090 RID: 144
		DropBeforeDisabled = 4,
		// Token: 0x04000091 RID: 145
		InsertBeforeDisabeled = 8,
		// Token: 0x04000092 RID: 146
		DropAfterDisabled = 16,
		// Token: 0x04000093 RID: 147
		InsertAfterDisabled = 32,
		// Token: 0x04000094 RID: 148
		RefernceDisabled = 64,
		// Token: 0x04000095 RID: 149
		CopyDisabled = 128,
		// Token: 0x04000096 RID: 150
		AddDefaultDisabled = 256,
		// Token: 0x04000097 RID: 151
		AddCurrentDisabled = 512
	}
}
