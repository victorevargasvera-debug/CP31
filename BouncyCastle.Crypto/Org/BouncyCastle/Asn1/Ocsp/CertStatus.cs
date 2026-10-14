using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006C7 RID: 1735
	public class CertStatus : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003F6E RID: 16238 RVA: 0x001203D5 File Offset: 0x0011E5D5
		public CertStatus()
		{
			this.tagNo = 0;
			this.value = global::Org.BouncyCastle.Asn1.DerNull.Instance;
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x001203EF File Offset: 0x0011E5EF
		public CertStatus(global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo info)
		{
			this.tagNo = 1;
			this.value = info;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00120405 File Offset: 0x0011E605
		public CertStatus(int tagNo, global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			this.tagNo = tagNo;
			this.value = value;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x0012041C File Offset: 0x0011E61C
		public CertStatus(global::Org.BouncyCastle.Asn1.Asn1TaggedObject choice)
		{
			this.tagNo = choice.TagNo;
			switch (choice.TagNo)
			{
			case 0:
			case 2:
				this.value = global::Org.BouncyCastle.Asn1.DerNull.Instance;
				return;
			case 1:
				this.value = global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo.GetInstance(choice, false);
				return;
			default:
				throw new global::System.ArgumentException("Unknown tag encountered: " + choice.TagNo.ToString());
			}
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00120490 File Offset: 0x0011E690
		public static global::Org.BouncyCastle.Asn1.Ocsp.CertStatus GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.CertStatus)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.CertStatus)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.CertStatus((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x001204DD File Offset: 0x0011E6DD
		public int TagNo
		{
			get
			{
				return this.tagNo;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003F74 RID: 16244 RVA: 0x001204E5 File Offset: 0x0011E6E5
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Status
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x001204ED File Offset: 0x0011E6ED
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, this.tagNo, this.value);
		}

		// Token: 0x04001D5D RID: 7517
		private readonly int tagNo;

		// Token: 0x04001D5E RID: 7518
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable value;
	}
}
