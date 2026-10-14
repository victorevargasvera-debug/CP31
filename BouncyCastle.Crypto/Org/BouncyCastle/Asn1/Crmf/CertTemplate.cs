using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200072A RID: 1834
	public class CertTemplate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041D8 RID: 16856 RVA: 0x00129D04 File Offset: 0x00127F04
		private CertTemplate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.seq = seq;
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				switch (tObj.TagNo)
				{
				case 0:
					this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(tObj, false);
					break;
				case 1:
					this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(tObj, false);
					break;
				case 2:
					this.signingAlg = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(tObj, false);
					break;
				case 3:
					this.issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(tObj, true);
					break;
				case 4:
					this.validity = global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj, false));
					break;
				case 5:
					this.subject = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(tObj, true);
					break;
				case 6:
					this.publicKey = global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(tObj, false);
					break;
				case 7:
					this.issuerUID = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(tObj, false);
					break;
				case 8:
					this.subjectUID = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(tObj, false);
					break;
				case 9:
					this.extensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(tObj, false);
					break;
				default:
					throw new global::System.ArgumentException("unknown tag: " + tObj.TagNo.ToString(), "seq");
				}
			}
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x00129E78 File Offset: 0x00128078
		public static global::Org.BouncyCastle.Asn1.Crmf.CertTemplate GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Crmf.CertTemplate)
			{
				return (global::Org.BouncyCastle.Asn1.Crmf.CertTemplate)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Crmf.CertTemplate(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x00129E99 File Offset: 0x00128099
		public virtual int Version
		{
			get
			{
				return this.version.IntValueExact;
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x00129EA6 File Offset: 0x001280A6
		public virtual global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x00129EAE File Offset: 0x001280AE
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SigningAlg
		{
			get
			{
				return this.signingAlg;
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x00129EB6 File Offset: 0x001280B6
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x00129EBE File Offset: 0x001280BE
		public virtual global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity Validity
		{
			get
			{
				return this.validity;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x00129EC6 File Offset: 0x001280C6
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.subject;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00129ECE File Offset: 0x001280CE
		public virtual global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo PublicKey
		{
			get
			{
				return this.publicKey;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00129ED6 File Offset: 0x001280D6
		public virtual global::Org.BouncyCastle.Asn1.DerBitString IssuerUID
		{
			get
			{
				return this.issuerUID;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x00129EDE File Offset: 0x001280DE
		public virtual global::Org.BouncyCastle.Asn1.DerBitString SubjectUID
		{
			get
			{
				return this.subjectUID;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x00129EE6 File Offset: 0x001280E6
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00129EEE File Offset: 0x001280EE
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.seq;
		}

		// Token: 0x04001FA8 RID: 8104
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence seq;

		// Token: 0x04001FA9 RID: 8105
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001FAA RID: 8106
		private readonly global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001FAB RID: 8107
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signingAlg;

		// Token: 0x04001FAC RID: 8108
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001FAD RID: 8109
		private readonly global::Org.BouncyCastle.Asn1.Crmf.OptionalValidity validity;

		// Token: 0x04001FAE RID: 8110
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001FAF RID: 8111
		private readonly global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo publicKey;

		// Token: 0x04001FB0 RID: 8112
		private readonly global::Org.BouncyCastle.Asn1.DerBitString issuerUID;

		// Token: 0x04001FB1 RID: 8113
		private readonly global::Org.BouncyCastle.Asn1.DerBitString subjectUID;

		// Token: 0x04001FB2 RID: 8114
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
