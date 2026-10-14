using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x02000700 RID: 1792
	public class SigningCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040C7 RID: 16583 RVA: 0x00125B08 File Offset: 0x00123D08
		public static global::Org.BouncyCastle.Asn1.Ess.SigningCertificate GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.SigningCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.SigningCertificate)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.SigningCertificate((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'SigningCertificate' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00125B58 File Offset: 0x00123D58
		public SigningCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.certs = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				this.policies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1]);
			}
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00125BC8 File Offset: 0x00123DC8
		public SigningCertificate(global::Org.BouncyCastle.Asn1.Ess.EssCertID essCertID)
		{
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(essCertID);
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00125BDC File Offset: 0x00123DDC
		public global::Org.BouncyCastle.Asn1.Ess.EssCertID[] GetCerts()
		{
			global::Org.BouncyCastle.Asn1.Ess.EssCertID[] cs = new global::Org.BouncyCastle.Asn1.Ess.EssCertID[this.certs.Count];
			for (int i = 0; i != this.certs.Count; i++)
			{
				cs[i] = global::Org.BouncyCastle.Asn1.Ess.EssCertID.GetInstance(this.certs[i]);
			}
			return cs;
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x00125C28 File Offset: 0x00123E28
		public global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] GetPolicies()
		{
			if (this.policies == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] ps = new global::Org.BouncyCastle.Asn1.X509.PolicyInformation[this.policies.Count];
			for (int i = 0; i != this.policies.Count; i++)
			{
				ps[i] = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(this.policies[i]);
			}
			return ps;
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00125C7C File Offset: 0x00123E7C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certs
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.policies
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F0D RID: 7949
		private global::Org.BouncyCastle.Asn1.Asn1Sequence certs;

		// Token: 0x04001F0E RID: 7950
		private global::Org.BouncyCastle.Asn1.Asn1Sequence policies;
	}
}
