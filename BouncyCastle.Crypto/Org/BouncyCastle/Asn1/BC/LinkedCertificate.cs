using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.BC
{
	// Token: 0x02000794 RID: 1940
	public class LinkedCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044D8 RID: 17624 RVA: 0x0013218C File Offset: 0x0013038C
		public LinkedCertificate(global::Org.BouncyCastle.Asn1.X509.DigestInfo digest, global::Org.BouncyCastle.Asn1.X509.GeneralName certLocation) : this(digest, certLocation, null, null)
		{
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x00132198 File Offset: 0x00130398
		public LinkedCertificate(global::Org.BouncyCastle.Asn1.X509.DigestInfo digest, global::Org.BouncyCastle.Asn1.X509.GeneralName certLocation, global::Org.BouncyCastle.Asn1.X509.X509Name certIssuer, global::Org.BouncyCastle.Asn1.X509.GeneralNames caCerts)
		{
			this.mDigest = digest;
			this.mCertLocation = certLocation;
			this.mCertIssuer = certIssuer;
			this.mCACerts = caCerts;
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x001321C0 File Offset: 0x001303C0
		private LinkedCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.mDigest = global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(seq[0]);
			this.mCertLocation = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[1]);
			for (int i = 2; i < seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				int tagNo = tagged.TagNo;
				if (tagNo != 0)
				{
					if (tagNo != 1)
					{
						throw new global::System.ArgumentException("unknown tag in tagged field");
					}
					this.mCACerts = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(tagged, false);
				}
				else
				{
					this.mCertIssuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(tagged, false);
				}
			}
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x0013224E File Offset: 0x0013044E
		public static global::Org.BouncyCastle.Asn1.BC.LinkedCertificate GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.BC.LinkedCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.BC.LinkedCertificate)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.BC.LinkedCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0013226F File Offset: 0x0013046F
		public virtual global::Org.BouncyCastle.Asn1.X509.DigestInfo Digest
		{
			get
			{
				return this.mDigest;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x060044DD RID: 17629 RVA: 0x00132277 File Offset: 0x00130477
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralName CertLocation
		{
			get
			{
				return this.mCertLocation;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x0013227F File Offset: 0x0013047F
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name CertIssuer
		{
			get
			{
				return this.mCertIssuer;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x060044DF RID: 17631 RVA: 0x00132287 File Offset: 0x00130487
		public virtual global::Org.BouncyCastle.Asn1.X509.GeneralNames CACerts
		{
			get
			{
				return this.mCACerts;
			}
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x0013228F File Offset: 0x0013048F
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.mDigest,
				this.mCertLocation
			});
			asn1EncodableVector.AddOptionalTagged(false, 0, this.mCertIssuer);
			asn1EncodableVector.AddOptionalTagged(false, 1, this.mCACerts);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002199 RID: 8601
		private readonly global::Org.BouncyCastle.Asn1.X509.DigestInfo mDigest;

		// Token: 0x0400219A RID: 8602
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName mCertLocation;

		// Token: 0x0400219B RID: 8603
		private global::Org.BouncyCastle.Asn1.X509.X509Name mCertIssuer;

		// Token: 0x0400219C RID: 8604
		private global::Org.BouncyCastle.Asn1.X509.GeneralNames mCACerts;
	}
}
