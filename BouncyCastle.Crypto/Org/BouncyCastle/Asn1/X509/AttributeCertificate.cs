using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000642 RID: 1602
	public class AttributeCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B53 RID: 15187 RVA: 0x00111554 File Offset: 0x0010F754
		public static global::Org.BouncyCastle.Asn1.X509.AttributeCertificate GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AttributeCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AttributeCertificate)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AttributeCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x00111575 File Offset: 0x0010F775
		public AttributeCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo acinfo, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm, global::Org.BouncyCastle.Asn1.DerBitString signatureValue)
		{
			this.acinfo = acinfo;
			this.signatureAlgorithm = signatureAlgorithm;
			this.signatureValue = signatureValue;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00111594 File Offset: 0x0010F794
		private AttributeCertificate(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.acinfo = global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo.GetInstance(seq[0]);
			this.signatureAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[1]);
			this.signatureValue = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(seq[2]);
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06003B56 RID: 15190 RVA: 0x00111604 File Offset: 0x0010F804
		public global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo ACInfo
		{
			get
			{
				return this.acinfo;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x0011160C File Offset: 0x0010F80C
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.signatureAlgorithm;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06003B58 RID: 15192 RVA: 0x00111614 File Offset: 0x0010F814
		public global::Org.BouncyCastle.Asn1.DerBitString SignatureValue
		{
			get
			{
				return this.signatureValue;
			}
		}

		// Token: 0x06003B59 RID: 15193 RVA: 0x0011161C File Offset: 0x0010F81C
		public byte[] GetSignatureOctets()
		{
			return this.signatureValue.GetOctets();
		}

		// Token: 0x06003B5A RID: 15194 RVA: 0x00111629 File Offset: 0x0010F829
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.acinfo,
				this.signatureAlgorithm,
				this.signatureValue
			});
		}

		// Token: 0x04001A2A RID: 6698
		private readonly global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo acinfo;

		// Token: 0x04001A2B RID: 6699
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm;

		// Token: 0x04001A2C RID: 6700
		private readonly global::Org.BouncyCastle.Asn1.DerBitString signatureValue;
	}
}
