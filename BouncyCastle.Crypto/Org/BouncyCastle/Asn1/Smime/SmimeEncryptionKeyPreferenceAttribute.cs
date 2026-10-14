using System;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Smime
{
	// Token: 0x020006A3 RID: 1699
	public class SmimeEncryptionKeyPreferenceAttribute : global::Org.BouncyCastle.Asn1.X509.AttributeX509
	{
		// Token: 0x06003E61 RID: 15969 RVA: 0x0011C881 File Offset: 0x0011AA81
		public SmimeEncryptionKeyPreferenceAttribute(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issAndSer) : base(global::Org.BouncyCastle.Asn1.Smime.SmimeAttributes.EncrypKeyPref, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, issAndSer)))
		{
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0011C89B File Offset: 0x0011AA9B
		public SmimeEncryptionKeyPreferenceAttribute(global::Org.BouncyCastle.Asn1.Cms.RecipientKeyIdentifier rKeyID) : base(global::Org.BouncyCastle.Asn1.Smime.SmimeAttributes.EncrypKeyPref, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, rKeyID)))
		{
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0011C8B5 File Offset: 0x0011AAB5
		public SmimeEncryptionKeyPreferenceAttribute(global::Org.BouncyCastle.Asn1.Asn1OctetString sKeyID) : base(global::Org.BouncyCastle.Asn1.Smime.SmimeAttributes.EncrypKeyPref, new global::Org.BouncyCastle.Asn1.DerSet(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, sKeyID)))
		{
		}
	}
}
