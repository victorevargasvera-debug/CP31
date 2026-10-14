using System;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000785 RID: 1925
	public enum PkiStatus
	{
		// Token: 0x04002136 RID: 8502
		Granted,
		// Token: 0x04002137 RID: 8503
		GrantedWithMods,
		// Token: 0x04002138 RID: 8504
		Rejection,
		// Token: 0x04002139 RID: 8505
		Waiting,
		// Token: 0x0400213A RID: 8506
		RevocationWarning,
		// Token: 0x0400213B RID: 8507
		RevocationNotification,
		// Token: 0x0400213C RID: 8508
		KeyUpdateWarning
	}
}
