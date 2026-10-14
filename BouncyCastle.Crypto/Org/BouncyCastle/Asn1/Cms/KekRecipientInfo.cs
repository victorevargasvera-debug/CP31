using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000750 RID: 1872
	public class KekRecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042EF RID: 17135 RVA: 0x0012CD42 File Offset: 0x0012AF42
		public KekRecipientInfo(global::Org.BouncyCastle.Asn1.Cms.KekIdentifier kekID, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(4);
			this.kekID = kekID;
			this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
			this.encryptedKey = encryptedKey;
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x0012CD6C File Offset: 0x0012AF6C
		public KekRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			this.kekID = global::Org.BouncyCastle.Asn1.Cms.KekIdentifier.GetInstance(seq[1]);
			this.keyEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[2]);
			this.encryptedKey = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[3];
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x0012CDC7 File Offset: 0x0012AFC7
		public static global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x0012CDD5 File Offset: 0x0012AFD5
		public static global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid KekRecipientInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x0012CE12 File Offset: 0x0012B012
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x0012CE1A File Offset: 0x0012B01A
		public global::Org.BouncyCastle.Asn1.Cms.KekIdentifier KekID
		{
			get
			{
				return this.kekID;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x0012CE22 File Offset: 0x0012B022
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier KeyEncryptionAlgorithm
		{
			get
			{
				return this.keyEncryptionAlgorithm;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x0012CE2A File Offset: 0x0012B02A
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedKey
		{
			get
			{
				return this.encryptedKey;
			}
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x0012CE32 File Offset: 0x0012B032
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.kekID,
				this.keyEncryptionAlgorithm,
				this.encryptedKey
			});
		}

		// Token: 0x04002043 RID: 8259
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002044 RID: 8260
		private global::Org.BouncyCastle.Asn1.Cms.KekIdentifier kekID;

		// Token: 0x04002045 RID: 8261
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyEncryptionAlgorithm;

		// Token: 0x04002046 RID: 8262
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedKey;
	}
}
