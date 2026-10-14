using System;
using System.Text;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200064A RID: 1610
	public class CertificatePolicies : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003BA5 RID: 15269 RVA: 0x0011222E File Offset: 0x0011042E
		private static global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] Copy(global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policyInfo)
		{
			return (global::Org.BouncyCastle.Asn1.X509.PolicyInformation[])policyInfo.Clone();
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x0011223B File Offset: 0x0011043B
		public static global::Org.BouncyCastle.Asn1.X509.CertificatePolicies GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.CertificatePolicies)
			{
				return (global::Org.BouncyCastle.Asn1.X509.CertificatePolicies)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.CertificatePolicies(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x0011225C File Offset: 0x0011045C
		public static global::Org.BouncyCastle.Asn1.X509.CertificatePolicies GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.X509.CertificatePolicies.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x0011226A File Offset: 0x0011046A
		public static global::Org.BouncyCastle.Asn1.X509.CertificatePolicies FromExtensions(global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			return global::Org.BouncyCastle.Asn1.X509.CertificatePolicies.GetInstance(global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetExtensionParsedValue(extensions, global::Org.BouncyCastle.Asn1.X509.X509Extensions.CertificatePolicies));
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0011227C File Offset: 0x0011047C
		public CertificatePolicies(global::Org.BouncyCastle.Asn1.X509.PolicyInformation name)
		{
			this.policyInformation = new global::Org.BouncyCastle.Asn1.X509.PolicyInformation[]
			{
				name
			};
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00112294 File Offset: 0x00110494
		public CertificatePolicies(global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policyInformation)
		{
			this.policyInformation = global::Org.BouncyCastle.Asn1.X509.CertificatePolicies.Copy(policyInformation);
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x001122A8 File Offset: 0x001104A8
		private CertificatePolicies(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.policyInformation = new global::Org.BouncyCastle.Asn1.X509.PolicyInformation[seq.Count];
			for (int i = 0; i < seq.Count; i++)
			{
				this.policyInformation[i] = global::Org.BouncyCastle.Asn1.X509.PolicyInformation.GetInstance(seq[i]);
			}
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x001122F1 File Offset: 0x001104F1
		public virtual global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] GetPolicyInformation()
		{
			return global::Org.BouncyCastle.Asn1.X509.CertificatePolicies.Copy(this.policyInformation);
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00112300 File Offset: 0x00110500
		public virtual global::Org.BouncyCastle.Asn1.X509.PolicyInformation GetPolicyInformation(global::Org.BouncyCastle.Asn1.DerObjectIdentifier policyIdentifier)
		{
			for (int i = 0; i != this.policyInformation.Length; i++)
			{
				if (policyIdentifier.Equals(this.policyInformation[i].PolicyIdentifier))
				{
					return this.policyInformation[i];
				}
			}
			return null;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00112340 File Offset: 0x00110540
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable[] elements = this.policyInformation;
			return new global::Org.BouncyCastle.Asn1.DerSequence(elements);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x0011235C File Offset: 0x0011055C
		public override string ToString()
		{
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder("CertificatePolicies:");
			if (this.policyInformation != null && this.policyInformation.Length != 0)
			{
				sb.Append(' ');
				sb.Append(this.policyInformation[0]);
				for (int i = 1; i < this.policyInformation.Length; i++)
				{
					sb.Append(", ");
					sb.Append(this.policyInformation[i]);
				}
			}
			return sb.ToString();
		}

		// Token: 0x04001A42 RID: 6722
		private readonly global::Org.BouncyCastle.Asn1.X509.PolicyInformation[] policyInformation;
	}
}
