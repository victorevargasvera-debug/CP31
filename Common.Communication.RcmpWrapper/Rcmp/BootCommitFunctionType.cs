using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002C RID: 44
	public enum BootCommitFunctionType : byte
	{
		// Token: 0x040000DC RID: 220
		None,
		// Token: 0x040000DD RID: 221
		QueryStatus,
		// Token: 0x040000DE RID: 222
		CommitToFlash,
		// Token: 0x040000DF RID: 223
		CommitToControllerFPGA,
		// Token: 0x040000E0 RID: 224
		CommitToWirelineFPGA
	}
}
