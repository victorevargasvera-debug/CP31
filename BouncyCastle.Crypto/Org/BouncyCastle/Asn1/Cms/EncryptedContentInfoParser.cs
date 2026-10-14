using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000749 RID: 1865
	public class EncryptedContentInfoParser
	{
		// Token: 0x060042BC RID: 17084 RVA: 0x0012C4AC File Offset: 0x0012A6AC
		public EncryptedContentInfoParser(global::Org.BouncyCastle.Asn1.Asn1SequenceParser seq)
		{
			this._contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq.ReadObject();
			this._contentEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq.ReadObject().ToAsn1Object());
			this._encryptedContent = (global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser)seq.ReadObject();
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060042BD RID: 17085 RVA: 0x0012C4EC File Offset: 0x0012A6EC
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this._contentType;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x0012C4F4 File Offset: 0x0012A6F4
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentEncryptionAlgorithm
		{
			get
			{
				return this._contentEncryptionAlgorithm;
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0012C4FC File Offset: 0x0012A6FC
		public global::Org.BouncyCastle.Asn1.IAsn1Convertible GetEncryptedContent(int tag)
		{
			return this._encryptedContent.GetObjectParser(tag, false);
		}

		// Token: 0x0400202D RID: 8237
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier _contentType;

		// Token: 0x0400202E RID: 8238
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier _contentEncryptionAlgorithm;

		// Token: 0x0400202F RID: 8239
		private global::Org.BouncyCastle.Asn1.Asn1TaggedObjectParser _encryptedContent;
	}
}
