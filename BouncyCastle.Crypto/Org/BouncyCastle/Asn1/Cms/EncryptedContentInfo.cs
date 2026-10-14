using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000748 RID: 1864
	public class EncryptedContentInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042B5 RID: 17077 RVA: 0x0012C391 File Offset: 0x0012A591
		public EncryptedContentInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier contentEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedContent)
		{
			this.contentType = contentType;
			this.contentEncryptionAlgorithm = contentEncryptionAlgorithm;
			this.encryptedContent = encryptedContent;
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x0012C3B0 File Offset: 0x0012A5B0
		public EncryptedContentInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.contentEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			if (seq.Count > 2)
			{
				this.encryptedContent = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[2], false);
			}
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0012C408 File Offset: 0x0012A608
		public static global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid EncryptedContentInfo: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x0012C445 File Offset: 0x0012A645
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060042B9 RID: 17081 RVA: 0x0012C44D File Offset: 0x0012A64D
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier ContentEncryptionAlgorithm
		{
			get
			{
				return this.contentEncryptionAlgorithm;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x0012C455 File Offset: 0x0012A655
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedContent
		{
			get
			{
				return this.encryptedContent;
			}
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0012C460 File Offset: 0x0012A660
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.contentType,
				this.contentEncryptionAlgorithm
			});
			if (this.encryptedContent != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 0, this.encryptedContent));
			}
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x0400202A RID: 8234
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;

		// Token: 0x0400202B RID: 8235
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier contentEncryptionAlgorithm;

		// Token: 0x0400202C RID: 8236
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedContent;
	}
}
