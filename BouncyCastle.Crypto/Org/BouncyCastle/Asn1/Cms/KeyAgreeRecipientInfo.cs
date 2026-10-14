using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000752 RID: 1874
	public class KeyAgreeRecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042FF RID: 17151 RVA: 0x0012CF39 File Offset: 0x0012B139
		public KeyAgreeRecipientInfo(global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator, global::Org.BouncyCastle.Asn1.Asn1OctetString ukm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Sequence recipientEncryptedKeys)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(3);
			this.originator = originator;
			this.ukm = ukm;
			this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
			this.recipientEncryptedKeys = recipientEncryptedKeys;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x0012CF6C File Offset: 0x0012B16C
		public KeyAgreeRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[index++];
			this.originator = global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index++], true);
			if (seq[index] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.ukm = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index++], true);
			}
			this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[index++]);
			this.recipientEncryptedKeys = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[index++];
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x0012D009 File Offset: 0x0012B209
		public static global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x0012D017 File Offset: 0x0012B217
		public static global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Illegal object in KeyAgreeRecipientInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x0012D054 File Offset: 0x0012B254
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0012D05C File Offset: 0x0012B25C
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey Originator
		{
			get
			{
				return this.originator;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x0012D064 File Offset: 0x0012B264
		public global::Org.BouncyCastle.Asn1.Asn1OctetString UserKeyingMaterial
		{
			get
			{
				return this.ukm;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0012D06C File Offset: 0x0012B26C
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithm;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x0012D074 File Offset: 0x0012B274
		public global::Org.BouncyCastle.Asn1.Asn1Sequence RecipientEncryptedKeys
		{
			get
			{
				return this.recipientEncryptedKeys;
			}
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x0012D07C File Offset: 0x0012B27C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.originator)
			});
			v.AddOptionalTagged(true, 1, this.ukm);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyEncryptionAlgorithm,
				this.recipientEncryptedKeys
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002049 RID: 8265
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x0400204A RID: 8266
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey originator;

		// Token: 0x0400204B RID: 8267
		private global::Org.BouncyCastle.Asn1.Asn1OctetString ukm;

		// Token: 0x0400204C RID: 8268
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm;

		// Token: 0x0400204D RID: 8269
		private global::Org.BouncyCastle.Asn1.Asn1Sequence recipientEncryptedKeys;
	}
}
