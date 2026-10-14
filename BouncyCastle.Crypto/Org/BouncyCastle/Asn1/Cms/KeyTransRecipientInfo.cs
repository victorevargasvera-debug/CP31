using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000753 RID: 1875
	public class KeyTransRecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004309 RID: 17161 RVA: 0x0012D0E0 File Offset: 0x0012B2E0
		public KeyTransRecipientInfo(global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier rid, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey)
		{
			if (rid.ToAsn1Object() is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.version = new global::Org.BouncyCastle.Asn1.DerInteger(2);
			}
			else
			{
				this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			}
			this.rid = rid;
			this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x0012D130 File Offset: 0x0012B330
		public KeyTransRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			this.rid = global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier.GetInstance(seq[1]);
			this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[2]);
			this.encryptedKey = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[3];
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x0012D18B File Offset: 0x0012B38B
		public static global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Illegal object in KeyTransRecipientInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x0012D1C8 File Offset: 0x0012B3C8
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x0012D1D0 File Offset: 0x0012B3D0
		public global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier RecipientIdentifier
		{
			get
			{
				return this.rid;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x0012D1D8 File Offset: 0x0012B3D8
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithm;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x0012D1E0 File Offset: 0x0012B3E0
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey
		{
			get
			{
				return this.encryptedKey;
			}
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x0012D1E8 File Offset: 0x0012B3E8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.rid,
				this.keyEncryptionAlgorithm,
				this.encryptedKey
			});
		}

		// Token: 0x0400204E RID: 8270
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x0400204F RID: 8271
		private global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier rid;

		// Token: 0x04002050 RID: 8272
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm;

		// Token: 0x04002051 RID: 8273
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey;
	}
}
