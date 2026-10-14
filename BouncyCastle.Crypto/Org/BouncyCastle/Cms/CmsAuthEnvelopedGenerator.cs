using System;
using Org.BouncyCastle.Asn1.Nist;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000522 RID: 1314
	internal class CmsAuthEnvelopedGenerator
	{
		// Token: 0x040016AE RID: 5806
		public static readonly string Aes128Ccm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ccm.Id;

		// Token: 0x040016AF RID: 5807
		public static readonly string Aes192Ccm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ccm.Id;

		// Token: 0x040016B0 RID: 5808
		public static readonly string Aes256Ccm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ccm.Id;

		// Token: 0x040016B1 RID: 5809
		public static readonly string Aes128Gcm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Gcm.Id;

		// Token: 0x040016B2 RID: 5810
		public static readonly string Aes192Gcm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Gcm.Id;

		// Token: 0x040016B3 RID: 5811
		public static readonly string Aes256Gcm = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Gcm.Id;
	}
}
