using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006C0 RID: 1728
	public class SafeBag : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F33 RID: 16179 RVA: 0x0011FA9C File Offset: 0x0011DC9C
		public static global::Org.BouncyCastle.Asn1.Pkcs.SafeBag GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.SafeBag)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.SafeBag)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.SafeBag(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0011FABD File Offset: 0x0011DCBD
		public SafeBag(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			this.bagID = oid;
			this.bagValue = obj;
			this.bagAttributes = null;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0011FADA File Offset: 0x0011DCDA
		public SafeBag(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.Asn1Object obj, global::Org.BouncyCastle.Asn1.Asn1Set bagAttributes)
		{
			this.bagID = oid;
			this.bagValue = obj;
			this.bagAttributes = bagAttributes;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x0011FAF8 File Offset: 0x0011DCF8
		private SafeBag(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.bagID = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)seq[0];
			this.bagValue = ((global::Org.BouncyCastle.Asn1.DerTaggedObject)seq[1]).GetObject();
			if (seq.Count == 3)
			{
				this.bagAttributes = (global::Org.BouncyCastle.Asn1.Asn1Set)seq[2];
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06003F37 RID: 16183 RVA: 0x0011FB4F File Offset: 0x0011DD4F
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier BagID
		{
			get
			{
				return this.bagID;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06003F38 RID: 16184 RVA: 0x0011FB57 File Offset: 0x0011DD57
		public global::Org.BouncyCastle.Asn1.Asn1Object BagValue
		{
			get
			{
				return this.bagValue;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06003F39 RID: 16185 RVA: 0x0011FB5F File Offset: 0x0011DD5F
		public global::Org.BouncyCastle.Asn1.Asn1Set BagAttributes
		{
			get
			{
				return this.bagAttributes;
			}
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x0011FB68 File Offset: 0x0011DD68
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.bagID,
				new global::Org.BouncyCastle.Asn1.DerTaggedObject(0, this.bagValue)
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.bagAttributes
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D37 RID: 7479
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier bagID;

		// Token: 0x04001D38 RID: 7480
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object bagValue;

		// Token: 0x04001D39 RID: 7481
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set bagAttributes;
	}
}
