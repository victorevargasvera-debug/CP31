using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000303 RID: 771
	public abstract class CertChainType
	{
		// Token: 0x060020F3 RID: 8435 RVA: 0x000924DF File Offset: 0x000906DF
		public static bool IsValid(byte certChainType)
		{
			return certChainType >= 0 && certChainType <= 1;
		}

		// Token: 0x04000B95 RID: 2965
		public const byte individual_certs = 0;

		// Token: 0x04000B96 RID: 2966
		public const byte pkipath = 1;
	}
}
