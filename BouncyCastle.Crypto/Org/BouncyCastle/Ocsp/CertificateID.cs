using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001DC RID: 476
	public class CertificateID
	{
		// Token: 0x060011A8 RID: 4520 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		public CertificateID(global::Org.BouncyCastle.Asn1.Ocsp.CertID id)
		{
			if (id == null)
			{
				throw new global::System.ArgumentNullException("id");
			}
			this.id = id;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0004E0E0 File Offset: 0x0004C2E0
		public CertificateID(string hashAlgorithm, global::Org.BouncyCastle.X509.X509Certificate issuerCert, global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlg = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(hashAlgorithm), global::Org.BouncyCastle.Asn1.DerNull.Instance);
			this.id = global::Org.BouncyCastle.Ocsp.CertificateID.CreateCertID(hashAlg, issuerCert, new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0004E117 File Offset: 0x0004C317
		public string HashAlgOid
		{
			get
			{
				return this.id.HashAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0004E12E File Offset: 0x0004C32E
		public byte[] GetIssuerNameHash()
		{
			return this.id.IssuerNameHash.GetOctets();
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0004E140 File Offset: 0x0004C340
		public byte[] GetIssuerKeyHash()
		{
			return this.id.IssuerKeyHash.GetOctets();
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0004E152 File Offset: 0x0004C352
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.id.SerialNumber.Value;
			}
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0004E164 File Offset: 0x0004C364
		public bool MatchesIssuer(global::Org.BouncyCastle.X509.X509Certificate issuerCert)
		{
			return global::Org.BouncyCastle.Ocsp.CertificateID.CreateCertID(this.id.HashAlgorithm, issuerCert, this.id.SerialNumber).Equals(this.id);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0004E18D File Offset: 0x0004C38D
		public global::Org.BouncyCastle.Asn1.Ocsp.CertID ToAsn1Object()
		{
			return this.id;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0004E198 File Offset: 0x0004C398
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Ocsp.CertificateID other = obj as global::Org.BouncyCastle.Ocsp.CertificateID;
			return other != null && this.id.ToAsn1Object().Equals(other.id.ToAsn1Object());
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0004E1D2 File Offset: 0x0004C3D2
		public override int GetHashCode()
		{
			return this.id.ToAsn1Object().GetHashCode();
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0004E1E4 File Offset: 0x0004C3E4
		public static global::Org.BouncyCastle.Ocsp.CertificateID DeriveCertificateID(global::Org.BouncyCastle.Ocsp.CertificateID original, global::Org.BouncyCastle.Math.BigInteger newSerialNumber)
		{
			return new global::Org.BouncyCastle.Ocsp.CertificateID(new global::Org.BouncyCastle.Asn1.Ocsp.CertID(original.id.HashAlgorithm, original.id.IssuerNameHash, original.id.IssuerKeyHash, new global::Org.BouncyCastle.Asn1.DerInteger(newSerialNumber)));
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0004E218 File Offset: 0x0004C418
		private static global::Org.BouncyCastle.Asn1.Ocsp.CertID CreateCertID(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlg, global::Org.BouncyCastle.X509.X509Certificate issuerCert, global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			global::Org.BouncyCastle.Asn1.Ocsp.CertID result;
			try
			{
				string algorithm = hashAlg.Algorithm.Id;
				global::Org.BouncyCastle.Asn1.X509.X509Name issuerName = global::Org.BouncyCastle.X509.PrincipalUtilities.GetSubjectX509Principal(issuerCert);
				byte[] issuerNameHash = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(algorithm, issuerName.GetEncoded());
				global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo info = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(issuerCert.GetPublicKey());
				byte[] issuerKeyHash = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(algorithm, info.PublicKeyData.GetBytes());
				result = new global::Org.BouncyCastle.Asn1.Ocsp.CertID(hashAlg, new global::Org.BouncyCastle.Asn1.DerOctetString(issuerNameHash), new global::Org.BouncyCastle.Asn1.DerOctetString(issuerKeyHash), serialNumber);
			}
			catch (global::System.Exception e)
			{
				string str = "problem creating ID: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Ocsp.OcspException(str + ((ex != null) ? ex.ToString() : null), e);
			}
			return result;
		}

		// Token: 0x040008E5 RID: 2277
		public const string HashSha1 = "1.3.14.3.2.26";

		// Token: 0x040008E6 RID: 2278
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.CertID id;
	}
}
