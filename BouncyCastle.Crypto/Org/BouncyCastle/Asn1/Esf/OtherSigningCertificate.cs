using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000715 RID: 1813
	public class OtherSigningCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004149 RID: 16713 RVA: 0x00127880 File Offset: 0x00125A80
		public static global::Org.BouncyCastle.Asn1.Esf.OtherSigningCertificate GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherSigningCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherSigningCertificate)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherSigningCertificate((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OtherSigningCertificate' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x001278D0 File Offset: 0x00125AD0
		private OtherSigningCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
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

		// Token: 0x0600414B RID: 16715 RVA: 0x0012795D File Offset: 0x00125B5D
		public OtherSigningCertificate(params global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] certs) : this(certs, null)
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00127968 File Offset: 0x00125B68
		public OtherSigningCertificate(global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] certs, params global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policies)
		{
			if (certs == null)
			{
				throw new global::System.ArgumentNullException("certs");
			}
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(certs);
			if (policies != null)
			{
				this.policies = new global::Org.BouncyCastle.Asn1.DerSequence(policies);
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x001279A8 File Offset: 0x00125BA8
		public OtherSigningCertificate(global::System.Collections.IEnumerable certs) : this(certs, null)
		{
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x001279B4 File Offset: 0x00125BB4
		public OtherSigningCertificate(global::System.Collections.IEnumerable certs, global::System.Collections.IEnumerable policies)
		{
			if (certs == null)
			{
				throw new global::System.ArgumentNullException("certs");
			}
			if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(certs, typeof(global::Org.BouncyCastle.Asn1.Esf.OtherCertID)))
			{
				throw new global::System.ArgumentException("Must contain only 'OtherCertID' objects", "certs");
			}
			this.certs = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(certs));
			if (policies != null)
			{
				if (!global::Org.BouncyCastle.Utilities.Collections.CollectionUtilities.CheckElementsAreOfType(policies, typeof(global::Org.BouncyCastle.Asn1.X509.PolicyInformation)))
				{
					throw new global::System.ArgumentException("Must contain only 'PolicyInformation' objects", "policies");
				}
				this.policies = new global::Org.BouncyCastle.Asn1.DerSequence(global::Org.BouncyCastle.Asn1.Asn1EncodableVector.FromEnumerable(policies));
			}
		}

		// Token: 0x0600414F RID: 16719 RVA: 0x00127A40 File Offset: 0x00125C40
		public global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] GetCerts()
		{
			global::Org.BouncyCastle.Asn1.Esf.OtherCertID[] cs = new global::Org.BouncyCastle.Asn1.Esf.OtherCertID[this.certs.Count];
			for (int i = 0; i < this.certs.Count; i++)
			{
				cs[i] = global::Org.BouncyCastle.Asn1.Esf.OtherCertID.GetInstance(this.certs[i].ToAsn1Object());
			}
			return cs;
		}

		// Token: 0x06004150 RID: 16720 RVA: 0x00127A90 File Offset: 0x00125C90
		public global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] GetPolicies()
		{
			if (this.policies == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] ps = new global::Org.BouncyCastle.Asn1.X509.PolicyInformation[this.policies.Count];
			for (int i = 0; i < this.policies.Count; i++)
			{
				ps[i] = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(this.policies[i].ToAsn1Object());
			}
			return ps;
		}

		// Token: 0x06004151 RID: 16721 RVA: 0x00127AE8 File Offset: 0x00125CE8
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

		// Token: 0x04001F44 RID: 8004
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence certs;

		// Token: 0x04001F45 RID: 8005
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence policies;
	}
}
