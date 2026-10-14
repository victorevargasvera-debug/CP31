using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033C RID: 828
	public abstract class NameType
	{
		// Token: 0x0600223C RID: 8764 RVA: 0x00097838 File Offset: 0x00095A38
		public static bool IsValid(byte nameType)
		{
			return nameType == 0;
		}

		// Token: 0x04000DC3 RID: 3523
		public const byte host_name = 0;
	}
}
