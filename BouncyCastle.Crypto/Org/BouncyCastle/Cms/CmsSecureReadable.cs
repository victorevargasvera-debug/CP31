using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000535 RID: 1333
	internal interface CmsSecureReadable
	{
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600335B RID: 13147
		global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Algorithm { get; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600335C RID: 13148
		object CryptoObject { get; }

		// Token: 0x0600335D RID: 13149
		global::Org.BouncyCastle.Cms.CmsReadable GetReadable(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key);
	}
}
