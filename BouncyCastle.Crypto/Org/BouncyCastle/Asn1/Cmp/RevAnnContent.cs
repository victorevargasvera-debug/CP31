using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078D RID: 1933
	public class RevAnnContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044B5 RID: 17589 RVA: 0x00131738 File Offset: 0x0012F938
		private RevAnnContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable.GetInstance(seq[0]);
			this.certId = global::Org.BouncyCastle.Asn1.Crmf.CertId.GetInstance(seq[1]);
			this.willBeRevokedAt = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(seq[2]);
			this.badSinceDate = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(seq[3]);
			if (seq.Count > 4)
			{
				this.crlDetails = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(seq[4]);
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x001317AE File Offset: 0x0012F9AE
		public static global::Org.BouncyCastle.Asn1.Cmp.RevAnnContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.RevAnnContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.RevAnnContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.RevAnnContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060044B7 RID: 17591 RVA: 0x001317ED File Offset: 0x0012F9ED
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x001317F5 File Offset: 0x0012F9F5
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertId CertID
		{
			get
			{
				return this.certId;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060044B9 RID: 17593 RVA: 0x001317FD File Offset: 0x0012F9FD
		public virtual global::Org.BouncyCastle.Asn1.DerGeneralizedTime WillBeRevokedAt
		{
			get
			{
				return this.willBeRevokedAt;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x00131805 File Offset: 0x0012FA05
		public virtual global::Org.BouncyCastle.Asn1.DerGeneralizedTime BadSinceDate
		{
			get
			{
				return this.badSinceDate;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x060044BB RID: 17595 RVA: 0x0013180D File Offset: 0x0012FA0D
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Extensions CrlDetails
		{
			get
			{
				return this.crlDetails;
			}
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00131818 File Offset: 0x0012FA18
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.status,
				this.certId,
				this.willBeRevokedAt,
				this.badSinceDate
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crlDetails
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002150 RID: 8528
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable status;

		// Token: 0x04002151 RID: 8529
		private readonly global::Org.BouncyCastle.Asn1.Crmf.CertId certId;

		// Token: 0x04002152 RID: 8530
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime willBeRevokedAt;

		// Token: 0x04002153 RID: 8531
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime badSinceDate;

		// Token: 0x04002154 RID: 8532
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions crlDetails;
	}
}
