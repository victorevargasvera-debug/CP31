using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000746 RID: 1862
	public class ContentInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042AB RID: 17067 RVA: 0x0012C1F4 File Offset: 0x0012A3F4
		public static global::Org.BouncyCastle.Asn1.Cms.ContentInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.ContentInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.ContentInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.ContentInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x0012C231 File Offset: 0x0012A431
		public static global::Org.BouncyCastle.Asn1.Cms.ContentInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x0012C240 File Offset: 0x0012A440
		private ContentInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.contentType = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			if (seq.Count > 1)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[1];
				if (!tagged.IsExplicit() || tagged.TagNo != 0)
				{
					throw new global::System.ArgumentException("Bad tag for 'content'", "seq");
				}
				this.content = tagged.GetObject();
			}
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0012C2DC File Offset: 0x0012A4DC
		public ContentInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.Asn1Encodable content)
		{
			this.contentType = contentType;
			this.content = content;
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x0012C2F2 File Offset: 0x0012A4F2
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x0012C2FA File Offset: 0x0012A4FA
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Content
		{
			get
			{
				return this.content;
			}
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0012C304 File Offset: 0x0012A504
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

		// Token: 0x04002026 RID: 8230
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;

		// Token: 0x04002027 RID: 8231
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable content;
	}
}
