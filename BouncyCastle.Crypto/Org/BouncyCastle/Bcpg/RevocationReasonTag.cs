using System;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000594 RID: 1428
	public enum RevocationReasonTag : byte
	{
		// Token: 0x0400187B RID: 6267
		NoReason,
		// Token: 0x0400187C RID: 6268
		KeySuperseded,
		// Token: 0x0400187D RID: 6269
		KeyCompromised,
		// Token: 0x0400187E RID: 6270
		KeyRetired,
		// Token: 0x0400187F RID: 6271
		UserNoLongerValid = 32
	}
}
