using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D0 RID: 208
	public abstract class IdentifierType
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x000205F5 File Offset: 0x0001E7F5
		public static string GetName(short identifierType)
		{
			switch (identifierType)
			{
			case 0:
				return "pre_agreed";
			case 1:
				return "key_sha1_hash";
			case 2:
				return "x509_name";
			case 3:
				return "cert_sha1_hash";
			default:
				return "UNKNOWN";
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002062C File Offset: 0x0001E82C
		public static string GetText(short identifierType)
		{
			return global::Org.BouncyCastle.Tls.IdentifierType.GetName(identifierType) + "(" + identifierType.ToString() + ")";
		}

		// Token: 0x04000592 RID: 1426
		public const short pre_agreed = 0;

		// Token: 0x04000593 RID: 1427
		public const short key_sha1_hash = 1;

		// Token: 0x04000594 RID: 1428
		public const short x509_name = 2;

		// Token: 0x04000595 RID: 1429
		public const short cert_sha1_hash = 3;
	}
}
