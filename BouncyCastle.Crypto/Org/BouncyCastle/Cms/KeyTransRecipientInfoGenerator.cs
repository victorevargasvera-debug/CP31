using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054A RID: 1354
	public class KeyTransRecipientInfoGenerator : global::Org.BouncyCastle.Cms.RecipientInfoGenerator
	{
		// Token: 0x06003429 RID: 13353 RVA: 0x000F9A4B File Offset: 0x000F7C4B
		public KeyTransRecipientInfoGenerator(global::Org.BouncyCastle.X509.X509Certificate recipCert, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper) : this(new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(recipCert.IssuerDN, new global::Org.BouncyCastle.Asn1.DerInteger(recipCert.SerialNumber)), keyWrapper)
		{
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000F9A6A File Offset: 0x000F7C6A
		public KeyTransRecipientInfoGenerator(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerAndSerial, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper)
		{
			this.issuerAndSerialNumber = issuerAndSerial;
			this.keyWrapper = keyWrapper;
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000F9A80 File Offset: 0x000F7C80
		public KeyTransRecipientInfoGenerator(byte[] subjectKeyID, global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper)
		{
			this.subjectKeyIdentifier = new global::Org.BouncyCastle.Asn1.DerOctetString(this.subjectKeyIdentifier);
			this.keyWrapper = keyWrapper;
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000F9AA0 File Offset: 0x000F7CA0
		public global::Org.BouncyCastle.Asn1.Cms.RecipientInfo Generate(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm = this.AlgorithmDetails;
			this.random = random;
			byte[] encryptedKeyBytes = this.GenerateWrappedKey(contentEncryptionKey);
			global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier recipId;
			if (this.issuerAndSerialNumber != null)
			{
				recipId = new global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier(this.issuerAndSerialNumber);
			}
			else
			{
				recipId = new global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier(this.subjectKeyIdentifier);
			}
			return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo(new global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo(recipId, keyEncryptionAlgorithm, new global::Org.BouncyCastle.Asn1.DerOctetString(encryptedKeyBytes)));
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x000F9AF7 File Offset: 0x000F7CF7
		protected virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmDetails
		{
			get
			{
				if (this.keyWrapper != null)
				{
					return (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)this.keyWrapper.AlgorithmDetails;
				}
				return this.info.AlgorithmID;
			}
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000F9B1D File Offset: 0x000F7D1D
		protected virtual byte[] GenerateWrappedKey(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter contentEncryptionKey)
		{
			return this.keyWrapper.Wrap(contentEncryptionKey.GetKey()).Collect();
		}

		// Token: 0x04001757 RID: 5975
		private static readonly global::Org.BouncyCastle.Cms.CmsEnvelopedHelper Helper = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance;

		// Token: 0x04001758 RID: 5976
		private global::Org.BouncyCastle.Asn1.Asn1OctetString subjectKeyIdentifier;

		// Token: 0x04001759 RID: 5977
		private global::Org.BouncyCastle.Crypto.IKeyWrapper keyWrapper;

		// Token: 0x0400175A RID: 5978
		private global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info;

		// Token: 0x0400175B RID: 5979
		private global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber issuerAndSerialNumber;

		// Token: 0x0400175C RID: 5980
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
