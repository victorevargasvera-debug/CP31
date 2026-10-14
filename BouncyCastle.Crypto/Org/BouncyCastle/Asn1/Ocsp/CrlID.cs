using System;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006C8 RID: 1736
	public class CrlID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F76 RID: 16246 RVA: 0x00120504 File Offset: 0x0011E704
		public CrlID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				switch (o.TagNo)
				{
				case 0:
					this.crlUrl = global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(o, true);
					break;
				case 1:
					this.crlNum = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o, true);
					break;
				case 2:
					this.crlTime = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(o, true);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag number: " + o.TagNo.ToString());
				}
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x001205C0 File Offset: 0x0011E7C0
		public global::Org.BouncyCastle.Asn1.DerIA5String CrlUrl
		{
			get
			{
				return this.crlUrl;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003F78 RID: 16248 RVA: 0x001205C8 File Offset: 0x0011E7C8
		public global::Org.BouncyCastle.Asn1.DerInteger CrlNum
		{
			get
			{
				return this.crlNum;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003F79 RID: 16249 RVA: 0x001205D0 File Offset: 0x0011E7D0
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime CrlTime
		{
			get
			{
				return this.crlTime;
			}
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x001205D8 File Offset: 0x0011E7D8
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.crlUrl);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.crlNum);
			asn1EncodableVector.AddOptionalTagged(true, 2, this.crlTime);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D5F RID: 7519
		private readonly global::Org.BouncyCastle.Asn1.DerIA5String crlUrl;

		// Token: 0x04001D60 RID: 7520
		private readonly global::Org.BouncyCastle.Asn1.DerInteger crlNum;

		// Token: 0x04001D61 RID: 7521
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime crlTime;
	}
}
