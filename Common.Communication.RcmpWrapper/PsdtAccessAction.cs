using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000020 RID: 32
	public enum PsdtAccessAction : byte
	{
		// Token: 0x0400008E RID: 142
		None,
		// Token: 0x0400008F RID: 143
		GetStartAddress,
		// Token: 0x04000090 RID: 144
		GetEndAddress,
		// Token: 0x04000091 RID: 145
		Lock,
		// Token: 0x04000092 RID: 146
		Unlock,
		// Token: 0x04000093 RID: 147
		Erase,
		// Token: 0x04000094 RID: 148
		Copy,
		// Token: 0x04000095 RID: 149
		ImageReorg
	}
}
