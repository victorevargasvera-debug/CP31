using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077B RID: 1915
	public class OobCertHash : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600442F RID: 17455 RVA: 0x00130344 File Offset: 0x0012E544
		private OobCertHash(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = seq.Count - 1;
			this.hashVal = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[index--]);
			for (int i = index; i >= 0; i--)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[i];
				if (tObj.TagNo == 0)
				{
					this.hashAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, true);
				}
				else
				{
					this.certId = global::Org.BouncyCastle.Asn1.Crmf.CertId.GetInstance(tObj, true);
				}
			}
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x001303B3 File Offset: 0x0012E5B3
		public static global::Org.BouncyCastle.Asn1.Cmp.OobCertHash GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.OobCertHash)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.OobCertHash)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.OobCertHash((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06004431 RID: 17457 RVA: 0x001303F2 File Offset: 0x0012E5F2
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlg
		{
			get
			{
				return this.hashAlg;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06004432 RID: 17458 RVA: 0x001303FA File Offset: 0x0012E5FA
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertId CertID
		{
			get
			{
				return this.certId;
			}
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x00130402 File Offset: 0x0012E602
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.hashAlg);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.certId);
			asn1EncodableVector.Add(this.hashVal);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x040020D5 RID: 8405
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlg;

		// Token: 0x040020D6 RID: 8406
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertId certId;

		// Token: 0x040020D7 RID: 8407
		private readonly global::Org.BouncyCastle.Asn1.DerBitString hashVal;
	}
}
