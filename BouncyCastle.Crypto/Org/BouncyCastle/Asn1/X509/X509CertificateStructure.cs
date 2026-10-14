using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200067B RID: 1659
	public class X509CertificateStructure : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003D30 RID: 15664 RVA: 0x00116ACF File Offset: 0x00114CCF
		public static global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00116ADD File Offset: 0x00114CDD
		public static global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure)
			{
				return (global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00116B00 File Offset: 0x00114D00
		public X509CertificateStructure(global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID, global::Org.BouncyCastle.Asn1.DerBitString sig)
		{
			if (tbsCert == null)
			{
				throw new global::System.ArgumentNullException("tbsCert");
			}
			if (sigAlgID == null)
			{
				throw new global::System.ArgumentNullException("sigAlgID");
			}
			if (sig == null)
			{
				throw new global::System.ArgumentNullException("sig");
			}
			this.tbsCert = tbsCert;
			this.sigAlgID = sigAlgID;
			this.sig = sig;
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00116B54 File Offset: 0x00114D54
		private X509CertificateStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("sequence wrong size for a certificate", "seq");
			}
			this.tbsCert = global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(seq[0]);
			this.sigAlgID = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.sig = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x00116BB6 File Offset: 0x00114DB6
		public global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure TbsCertificate
		{
			get
			{
				return this.tbsCert;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x00116BBE File Offset: 0x00114DBE
		public int Version
		{
			get
			{
				return this.tbsCert.Version;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x00116BCB File Offset: 0x00114DCB
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.tbsCert.SerialNumber;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x00116BD8 File Offset: 0x00114DD8
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.tbsCert.Issuer;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x00116BE5 File Offset: 0x00114DE5
		public global::Org.BouncyCastle.Asn1.X509.Time StartDate
		{
			get
			{
				return this.tbsCert.StartDate;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00116BF2 File Offset: 0x00114DF2
		public global::Org.BouncyCastle.Asn1.X509.Time EndDate
		{
			get
			{
				return this.tbsCert.EndDate;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00116BFF File Offset: 0x00114DFF
		public global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.tbsCert.Subject;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x00116C0C File Offset: 0x00114E0C
		public global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			get
			{
				return this.tbsCert.SubjectPublicKeyInfo;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00116C19 File Offset: 0x00114E19
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.sigAlgID;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x00116C21 File Offset: 0x00114E21
		public global::Org.BouncyCastle.Asn1.DerBitString Signature
		{
			get
			{
				return this.sig;
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00116C29 File Offset: 0x00114E29
		public byte[] GetSignatureOctets()
		{
			return this.sig.GetOctets();
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00116C36 File Offset: 0x00114E36
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.tbsCert,
				this.sigAlgID,
				this.sig
			});
		}

		// Token: 0x04001B0D RID: 6925
		private readonly global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert;

		// Token: 0x04001B0E RID: 6926
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID;

		// Token: 0x04001B0F RID: 6927
		private readonly global::Org.BouncyCastle.Asn1.DerBitString sig;
	}
}
