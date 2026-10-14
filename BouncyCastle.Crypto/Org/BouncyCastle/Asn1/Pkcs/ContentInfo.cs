using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AD RID: 1709
	public class ContentInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x0011DAD4 File Offset: 0x0011BCD4
		public static global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo existing = obj as global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x0011DAFD File Offset: 0x0011BCFD
		private ContentInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			if (seq.Count > 1)
			{
				this.content = ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1]).GetObject();
			}
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x0011DB37 File Offset: 0x0011BD37
		public ContentInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.Asn1Encodable content)
		{
			this.contentType = contentType;
			this.content = content;
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003EA8 RID: 16040 RVA: 0x0011DB4D File Offset: 0x0011BD4D
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x0011DB55 File Offset: 0x0011BD55
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x06003EAA RID: 16042 RVA: 0x0011DB60 File Offset: 0x0011BD60
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.contentType
			});
			if (this.content != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.BerTaggedObject(0, this.content));
			}
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x04001C6E RID: 7278
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;

		// Token: 0x04001C6F RID: 7279
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable content;
	}
}
