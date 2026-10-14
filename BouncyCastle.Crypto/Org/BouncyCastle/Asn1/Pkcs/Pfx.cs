using System;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B8 RID: 1720
	public class Pfx : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EED RID: 16109 RVA: 0x0011E5F8 File Offset: 0x0011C7F8
		public static global::Org.BouncyCastle.Asn1.Pkcs.Pfx GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.Pfx)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.Pfx)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.Pfx(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x0011E61C File Offset: 0x0011C81C
		private Pfx(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (!global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).HasValue(3))
			{
				throw new global::System.ArgumentException("wrong version for PFX PDU");
			}
			this.contentInfo = global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo.GetInstance(seq[1]);
			if (seq.Count == 3)
			{
				this.macData = global::Org.BouncyCastle.Asn1.Pkcs.MacData.GetInstance(seq[2]);
			}
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x0011E67B File Offset: 0x0011C87B
		public Pfx(global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo, global::Org.BouncyCastle.Asn1.Pkcs.MacData macData)
		{
			this.contentInfo = contentInfo;
			this.macData = macData;
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003EF0 RID: 16112 RVA: 0x0011E691 File Offset: 0x0011C891
		public global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo AuthSafe
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x0011E699 File Offset: 0x0011C899
		public global::Org.BouncyCastle.Asn1.Pkcs.MacData MacData
		{
			get
			{
				return this.macData;
			}
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0011E6A4 File Offset: 0x0011C8A4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(3),
				this.contentInfo
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.macData
			});
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x04001C84 RID: 7300
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.ContentInfo contentInfo;

		// Token: 0x04001C85 RID: 7301
		private readonly global::Org.BouncyCastle.Asn1.Pkcs.MacData macData;
	}
}
