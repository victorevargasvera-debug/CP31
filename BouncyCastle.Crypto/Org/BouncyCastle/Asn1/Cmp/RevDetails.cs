using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078E RID: 1934
	public class RevDetails : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044BD RID: 17597 RVA: 0x00131870 File Offset: 0x0012FA70
		private RevDetails(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certDetails = global::Org.BouncyCastle.Asn1.Crmf.CertTemplate.GetInstance(seq[0]);
			this.crlEntryDetails = ((seq.Count <= 1) ? null : global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(seq[1]));
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x001318A8 File Offset: 0x0012FAA8
		public static global::Org.BouncyCastle.Asn1.Cmp.RevDetails GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.RevDetails)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.RevDetails)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.RevDetails((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x001318E7 File Offset: 0x0012FAE7
		public RevDetails(global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certDetails) : this(certDetails, null)
		{
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x001318F1 File Offset: 0x0012FAF1
		public RevDetails(global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certDetails, global::Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryDetails)
		{
			this.certDetails = certDetails;
			this.crlEntryDetails = crlEntryDetails;
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x00131907 File Offset: 0x0012FB07
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertTemplate CertDetails
		{
			get
			{
				return this.certDetails;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x0013190F File Offset: 0x0012FB0F
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Extensions CrlEntryDetails
		{
			get
			{
				return this.crlEntryDetails;
			}
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x00131918 File Offset: 0x0012FB18
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certDetails
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crlEntryDetails
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002155 RID: 8533
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertTemplate certDetails;

		// Token: 0x04002156 RID: 8534
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions crlEntryDetails;
	}
}
