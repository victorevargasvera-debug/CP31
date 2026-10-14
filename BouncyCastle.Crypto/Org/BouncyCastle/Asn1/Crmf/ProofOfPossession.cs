using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000738 RID: 1848
	public class ProofOfPossession : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004244 RID: 16964 RVA: 0x0012ACE0 File Offset: 0x00128EE0
		private ProofOfPossession(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			this.tagNo = tagged.TagNo;
			switch (this.tagNo)
			{
			case 0:
				this.obj = global::Org.BouncyCastle.Asn1.DerNull.Instance;
				return;
			case 1:
				this.obj = global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey.GetInstance(tagged, false);
				return;
			case 2:
			case 3:
				this.obj = global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey.GetInstance(tagged, false);
				return;
			default:
				throw new global::System.ArgumentException("unknown tag: " + this.tagNo.ToString(), "tagged");
			}
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x0012AD65 File Offset: 0x00128F65
		public static global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.ProofOfPossession((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x0012ADA4 File Offset: 0x00128FA4
		public ProofOfPossession()
		{
			this.tagNo = 0;
			this.obj = global::Org.BouncyCastle.Asn1.DerNull.Instance;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x0012ADBE File Offset: 0x00128FBE
		public ProofOfPossession(global::Org.BouncyCastle.Asn1.Crmf.PopoSigningKey Poposk)
		{
			this.tagNo = 1;
			this.obj = Poposk;
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x0012ADD4 File Offset: 0x00128FD4
		public ProofOfPossession(int type, global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey privkey)
		{
			this.tagNo = type;
			this.obj = privkey;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06004249 RID: 16969 RVA: 0x0012ADEA File Offset: 0x00128FEA
		public virtual int Type
		{
			get
			{
				return this.tagNo;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600424A RID: 16970 RVA: 0x0012ADF2 File Offset: 0x00128FF2
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Object
		{
			get
			{
				return this.obj;
			}
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x0012ADFA File Offset: 0x00128FFA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, this.tagNo, this.obj);
		}

		// Token: 0x04001FE7 RID: 8167
		public const int TYPE_RA_VERIFIED = 0;

		// Token: 0x04001FE8 RID: 8168
		public const int TYPE_SIGNING_KEY = 1;

		// Token: 0x04001FE9 RID: 8169
		public const int TYPE_KEY_ENCIPHERMENT = 2;

		// Token: 0x04001FEA RID: 8170
		public const int TYPE_KEY_AGREEMENT = 3;

		// Token: 0x04001FEB RID: 8171
		private readonly int tagNo;

		// Token: 0x04001FEC RID: 8172
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable obj;
	}
}
