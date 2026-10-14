using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000094 RID: 148
	public abstract class CachedInformationType
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00019DE1 File Offset: 0x00017FE1
		public static string GetName(short cachedInformationType)
		{
			if (cachedInformationType == 1)
			{
				return "cert";
			}
			if (cachedInformationType != 2)
			{
				return "UNKNOWN";
			}
			return "cert_req";
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00019DFE File Offset: 0x00017FFE
		public static string GetText(short cachedInformationType)
		{
			return global::Org.BouncyCastle.Tls.CachedInformationType.GetName(cachedInformationType) + "(" + cachedInformationType.ToString() + ")";
		}

		// Token: 0x04000337 RID: 823
		public const short cert = 1;

		// Token: 0x04000338 RID: 824
		public const short cert_req = 2;
	}
}
