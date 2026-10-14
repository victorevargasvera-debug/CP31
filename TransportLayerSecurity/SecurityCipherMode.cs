using System;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000008 RID: 8
	[global::System.Flags]
	public enum SecurityCipherMode
	{
		// Token: 0x04000011 RID: 17
		SEC_MODE_NULL_NULL_NULL = 0,
		// Token: 0x04000012 RID: 18
		SEC_MODE_PSK_AES128_CBC_SHA = 1,
		// Token: 0x04000013 RID: 19
		SEC_MODE_PSK_NULL_SHA = 2,
		// Token: 0x04000014 RID: 20
		SEC_MODE_CER_AES256_CBC_SHA = 4,
		// Token: 0x04000015 RID: 21
		SEC_MODE_PSK_AES256_CBC_SHA = 8,
		// Token: 0x04000016 RID: 22
		SEC_MODE_CER_PSK_AES256_CBC_SHA = 16
	}
}
