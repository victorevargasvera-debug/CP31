using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000790 RID: 1936
	public class RevRepContentBuilder
	{
		// Token: 0x060044CA RID: 17610 RVA: 0x00131B12 File Offset: 0x0012FD12
		public virtual global::Org.BouncyCastle.Asn1.Cmp.RevRepContentBuilder Add(global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status)
		{
			this.status.Add(status);
			return this;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00131B21 File Offset: 0x0012FD21
		public virtual global::Org.BouncyCastle.Asn1.Cmp.RevRepContentBuilder Add(global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status, global::Org.BouncyCastle.Asn1.Crmf.CertId certId)
		{
			if (this.status.Count != this.revCerts.Count)
			{
				throw new global::System.InvalidOperationException("status and revCerts sequence must be in common order");
			}
			this.status.Add(status);
			this.revCerts.Add(certId);
			return this;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00131B5F File Offset: 0x0012FD5F
		public virtual global::Org.BouncyCastle.Asn1.Cmp.RevRepContentBuilder AddCrl(global::Org.BouncyCastle.Asn1.X509.CertificateList crl)
		{
			this.crls.Add(crl);
			return this;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00131B70 File Offset: 0x0012FD70
		public virtual global::Org.BouncyCastle.Asn1.Cmp.RevRepContent Build()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.Add(new global::Org.BouncyCastle.Asn1.DerSequence(this.status));
			if (this.revCerts.Count != 0)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, new global::Org.BouncyCastle.Asn1.DerSequence(this.revCerts)));
			}
			if (this.crls.Count != 0)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, new global::Org.BouncyCastle.Asn1.DerSequence(this.crls)));
			}
			return global::Org.BouncyCastle.Asn1.Cmp.RevRepContent.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v));
		}

		// Token: 0x0400215A RID: 8538
		private readonly global::Org.BouncyCastle.Asn1.Asn1EncodableVector status = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();

		// Token: 0x0400215B RID: 8539
		private readonly global::Org.BouncyCastle.Asn1.Asn1EncodableVector revCerts = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();

		// Token: 0x0400215C RID: 8540
		private readonly global::Org.BouncyCastle.Asn1.Asn1EncodableVector crls = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
	}
}
