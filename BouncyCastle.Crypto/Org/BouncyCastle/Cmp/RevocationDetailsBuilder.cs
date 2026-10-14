using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000566 RID: 1382
	public class RevocationDetailsBuilder
	{
		// Token: 0x060034D6 RID: 13526 RVA: 0x000FBFD1 File Offset: 0x000FA1D1
		public global::Org.BouncyCastle.Cmp.RevocationDetailsBuilder SetPublicKey(global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey)
		{
			if (publicKey != null)
			{
				this._templateBuilder.SetPublicKey(publicKey);
			}
			return this;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x000FBFE4 File Offset: 0x000FA1E4
		public global::Org.BouncyCastle.Cmp.RevocationDetailsBuilder SetIssuer(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			if (issuer != null)
			{
				this._templateBuilder.SetIssuer(issuer);
			}
			return this;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000FBFF7 File Offset: 0x000FA1F7
		public global::Org.BouncyCastle.Cmp.RevocationDetailsBuilder SetSerialNumber(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			if (serialNumber != null)
			{
				this._templateBuilder.SetSerialNumber(new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
			}
			return this;
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000FC00F File Offset: 0x000FA20F
		public global::Org.BouncyCastle.Cmp.RevocationDetailsBuilder SetSubject(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			if (subject != null)
			{
				this._templateBuilder.SetSubject(subject);
			}
			return this;
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x000FC022 File Offset: 0x000FA222
		public global::Org.BouncyCastle.Cmp.RevocationDetails Build()
		{
			return new global::Org.BouncyCastle.Cmp.RevocationDetails(new global::Org.BouncyCastle.Asn1.Cmp.RevDetails(this._templateBuilder.Build()));
		}

		// Token: 0x04001798 RID: 6040
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder _templateBuilder = new global::Org.BouncyCastle.Asn1.Crmf.CertTemplateBuilder();
	}
}
