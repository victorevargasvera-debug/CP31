using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public enum SDTestFunctionData : byte
	{
		// Token: 0x0400006A RID: 106
		SDCardPresent = 1,
		// Token: 0x0400006B RID: 107
		SDCardLoopbackTestStart,
		// Token: 0x0400006C RID: 108
		SDCardLoopbackTestStOP,
		// Token: 0x0400006D RID: 109
		SDCardLoopbackresultQuery
	}
}
