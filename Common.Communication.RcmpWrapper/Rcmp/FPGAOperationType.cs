using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000031 RID: 49
	[global::System.Flags]
	public enum FPGAOperationType : byte
	{
		// Token: 0x040000EB RID: 235
		Reconfigure = 0,
		// Token: 0x040000EC RID: 236
		Erase = 32,
		// Token: 0x040000ED RID: 237
		EraseStatus = 64
	}
}
