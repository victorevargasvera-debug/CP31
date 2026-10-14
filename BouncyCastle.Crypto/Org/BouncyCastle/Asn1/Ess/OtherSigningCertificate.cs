using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FF RID: 1791
	[global::System.Obsolete("Use version in Asn1.Esf instead")]
	public class OtherSigningCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040C1 RID: 16577 RVA: 0x00125954 File Offset: 0x00123B54
		public static global::Org.BouncyCastle.Asn1.Ess.OtherSigningCertificate GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.OtherSigningCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.OtherSigningCertificate)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.OtherSigningCertificate((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'OtherSigningCertificate' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x001259A4 File Offset: 0x00123BA4
		public OtherSigningCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
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

		// Token: 0x060040C3 RID: 16579 RVA: 0x00125A14 File Offset: 0x00123C14
		public OtherSigningCertificate(global::Org.BouncyCastle.Asn1.Ess.OtherCertID otherCertID)
		{
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(otherCertID);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00125A28 File Offset: 0x00123C28
		public global::Org.BouncyCastle.Asn1.Ess.OtherCertID[] GetCerts()
		{
			global::Org.BouncyCastle.Asn1.Ess.OtherCertID[] cs = new global::Org.BouncyCastle.Asn1.Ess.OtherCertID[this.certs.Count];
			for (int i = 0; i != this.certs.Count; i++)
			{
				cs[i] = global::Org.BouncyCastle.Asn1.Ess.OtherCertID.GetInstance(this.certs[i]);
			}
			return cs;
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00125A74 File Offset: 0x00123C74
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

		// Token: 0x060040C6 RID: 16582 RVA: 0x00125AC8 File Offset: 0x00123CC8
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

		// Token: 0x04001F0B RID: 7947
		private global::Org.BouncyCastle.Asn1.Asn1Sequence certs;

		// Token: 0x04001F0C RID: 7948
		private global::Org.BouncyCastle.Asn1.Asn1Sequence policies;
	}
}
