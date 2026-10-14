using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000565 RID: 1381
	public class RevocationDetails
	{
		// Token: 0x060034D1 RID: 13521 RVA: 0x000FBF7F File Offset: 0x000FA17F
		public RevocationDetails(global::Org.BouncyCastle.Asn1.Cmp.RevDetails revDetails)
		{
			this.revDetails = revDetails;
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x000FBF8E File Offset: 0x000FA18E
		public global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.revDetails.CertDetails.Subject;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x000FBFA0 File Offset: 0x000FA1A0
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.revDetails.CertDetails.Issuer;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x000FBFB2 File Offset: 0x000FA1B2
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.revDetails.CertDetails.SerialNumber.Value;
			}
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000FBFC9 File Offset: 0x000FA1C9
		public global::Org.BouncyCastle.Asn1.Cmp.RevDetails ToASN1Structure()
		{
			return this.revDetails;
		}

		// Token: 0x04001797 RID: 6039
		private readonly global::Org.BouncyCastle.Asn1.Cmp.RevDetails revDetails;
	}
}
