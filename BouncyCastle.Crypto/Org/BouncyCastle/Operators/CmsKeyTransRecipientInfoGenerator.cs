using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Operators
{
	// Token: 0x020002B3 RID: 691
	public class CmsKeyTransRecipientInfoGenerator : global::Org.BouncyCastle.Cms.KeyTransRecipientInfoGenerator
	{
		// Token: 0x06001EE3 RID: 7907 RVA: 0x0008F10E File Offset: 0x0008D30E
		public CmsKeyTransRecipientInfoGenerator(global::Org.BouncyCastle.X509.X509Certificate recipCert, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper) : base(new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(recipCert.IssuerDN, new global::Org.BouncyCastle.Asn1.DerInteger(recipCert.SerialNumber)), keyWrapper)
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x0008F12D File Offset: 0x0008D32D
		public CmsKeyTransRecipientInfoGenerator(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerAndSerial, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper) : base(issuerAndSerial, keyWrapper)
		{
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x0008F137 File Offset: 0x0008D337
		public CmsKeyTransRecipientInfoGenerator(byte[] subjectKeyID, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper) : base(subjectKeyID, keyWrapper)
		{
		}
	}
}
