using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000095 RID: 149
	public abstract class CertChainType
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00019E24 File Offset: 0x00018024
		public static string GetName(short certChainType)
		{
			if (certChainType == 0)
			{
				return "individual_certs";
			}
			if (certChainType != 1)
			{
				return "UNKNOWN";
			}
			return "pkipath";
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00019E40 File Offset: 0x00018040
		public static string GetText(short certChainType)
		{
			return global::Org.BouncyCastle.Tls.CertChainType.GetName(certChainType) + "(" + certChainType.ToString() + ")";
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00019E5E File Offset: 0x0001805E
		public static bool IsValid(short certChainType)
		{
			return certChainType >= 0 && certChainType <= 1;
		}

		// Token: 0x04000339 RID: 825
		public const short individual_certs = 0;

		// Token: 0x0400033A RID: 826
		public const short pkipath = 1;
	}
}
