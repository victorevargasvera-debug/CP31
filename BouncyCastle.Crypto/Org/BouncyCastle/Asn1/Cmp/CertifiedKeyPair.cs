using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200076D RID: 1901
	public class CertifiedKeyPair : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060043D9 RID: 17369 RVA: 0x0012F2E0 File Offset: 0x0012D4E0
		private CertifiedKeyPair(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.certOrEncCert = global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert.GetInstance(seq[0]);
			if (seq.Count >= 2)
			{
				if (seq.Count == 2)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]);
					if (tagged.TagNo == 0)
					{
						this.privateKey = global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue.GetInstance(tagged.GetObject());
						return;
					}
					this.publicationInfo = global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo.GetInstance(tagged.GetObject());
					return;
				}
				else
				{
					this.privateKey = global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue.GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[1]));
					this.publicationInfo = global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[2]));
				}
			}
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0012F37E File Offset: 0x0012D57E
		public static global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x0012F3BD File Offset: 0x0012D5BD
		public CertifiedKeyPair(global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert certOrEncCert) : this(certOrEncCert, null, null)
		{
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0012F3C8 File Offset: 0x0012D5C8
		public CertifiedKeyPair(global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert certOrEncCert, global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue privateKey, global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo publicationInfo)
		{
			if (certOrEncCert == null)
			{
				throw new global::System.ArgumentNullException("certOrEncCert");
			}
			this.certOrEncCert = certOrEncCert;
			this.privateKey = privateKey;
			this.publicationInfo = publicationInfo;
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x0012F3F3 File Offset: 0x0012D5F3
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert CertOrEncCert
		{
			get
			{
				return this.certOrEncCert;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060043DE RID: 17374 RVA: 0x0012F3FB File Offset: 0x0012D5FB
		public virtual global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue PrivateKey
		{
			get
			{
				return this.privateKey;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x0012F403 File Offset: 0x0012D603
		public virtual global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo PublicationInfo
		{
			get
			{
				return this.publicationInfo;
			}
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x0012F40B File Offset: 0x0012D60B
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.certOrEncCert
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.privateKey);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.publicationInfo);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x0400209C RID: 8348
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert certOrEncCert;

		// Token: 0x0400209D RID: 8349
		private readonly global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue privateKey;

		// Token: 0x0400209E RID: 8350
		private readonly global::Org.BouncyCastle.Asn1.Crmf.PkiPublicationInfo publicationInfo;
	}
}
