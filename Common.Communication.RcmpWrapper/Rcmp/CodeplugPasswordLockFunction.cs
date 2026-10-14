using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000062 RID: 98
	public enum CodeplugPasswordLockFunction : byte
	{
		// Token: 0x040001C3 RID: 451
		RequestStatus,
		// Token: 0x040001C4 RID: 452
		VerifyPassword,
		// Token: 0x040001C5 RID: 453
		PairDevice,
		// Token: 0x040001C6 RID: 454
		UnpairDevice,
		// Token: 0x040001C7 RID: 455
		VerifyPair
	}
}
