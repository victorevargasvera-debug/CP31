using System;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000554 RID: 1364
	public interface RecipientInfoGenerator
	{
		// Token: 0x06003457 RID: 13399
		global::Org.BouncyCastle.Asn1.Cms.RecipientInfo Generate(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey, global::Org.BouncyCastle.Security.SecureRandom random);
	}
}
