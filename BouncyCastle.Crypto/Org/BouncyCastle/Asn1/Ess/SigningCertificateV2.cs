using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x02000701 RID: 1793
	public class SigningCertificateV2 : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040CD RID: 16589 RVA: 0x00125CBC File Offset: 0x00123EBC
		public static global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2 GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2)
			{
				return (global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in 'SigningCertificateV2' factory : " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o) + ".");
		}

		// Token: 0x060040CE RID: 16590 RVA: 0x00125D0C File Offset: 0x00123F0C
		private SigningCertificateV2(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.certs = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[0].ToAsn1Object());
			if (seq.Count > 1)
			{
				this.policies = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[1].ToAsn1Object());
			}
		}

		// Token: 0x060040CF RID: 16591 RVA: 0x00125D8B File Offset: 0x00123F8B
		public SigningCertificateV2(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 cert)
		{
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(cert);
		}

		// Token: 0x060040D0 RID: 16592 RVA: 0x00125DA0 File Offset: 0x00123FA0
		public SigningCertificateV2(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2[] certs)
		{
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(certs);
		}

		// Token: 0x060040D1 RID: 16593 RVA: 0x00125DC4 File Offset: 0x00123FC4
		public SigningCertificateV2(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2[] certs, global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policies)
		{
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(certs);
			if (policies != null)
			{
				this.policies = new global::Org.BouncyCastle.Asn1.DerSequence(policies);
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x00125DF8 File Offset: 0x00123FF8
		public global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2[] GetCerts()
		{
			global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2[] certIds = new global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2[this.certs.Count];
			for (int i = 0; i != this.certs.Count; i++)
			{
				certIds[i] = global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.GetInstance(this.certs[i]);
			}
			return certIds;
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x00125E44 File Offset: 0x00124044
		public global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] GetPolicies()
		{
			if (this.policies == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policyInformations = new global::Org.BouncyCastle.Asn1.X509.PolicyInformation[this.policies.Count];
			for (int i = 0; i != this.policies.Count; i++)
			{
				policyInformations[i] = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(this.policies[i]);
			}
			return policyInformations;
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x00125E98 File Offset: 0x00124098
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

		// Token: 0x04001F0F RID: 7951
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence certs;

		// Token: 0x04001F10 RID: 7952
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence policies;
	}
}
