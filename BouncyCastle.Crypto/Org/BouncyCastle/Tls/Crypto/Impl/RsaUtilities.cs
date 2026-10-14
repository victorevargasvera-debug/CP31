using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015B RID: 347
	public abstract class RsaUtilities
	{
		// Token: 0x06000D93 RID: 3475 RVA: 0x00032824 File Offset: 0x00030A24
		static RsaUtilities()
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA256Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha256Identifier_A);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA384Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha384Identifier_A);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA512Identifier_A = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha512Identifier_A);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA256Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha256Identifier_B);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA384Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha384Identifier_B);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier mgf1SHA512Identifier_B = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, sha512Identifier_B);
			global::Org.BouncyCastle.Asn1.DerInteger sha256Size = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(4));
			global::Org.BouncyCastle.Asn1.DerInteger sha384Size = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(5));
			global::Org.BouncyCastle.Asn1.DerInteger sha512Size = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(6));
			global::Org.BouncyCastle.Asn1.DerInteger trailerField = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			try
			{
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_256_A = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha256Identifier_A, mgf1SHA256Identifier_A, sha256Size, trailerField).GetEncoded("DER");
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_384_A = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha384Identifier_A, mgf1SHA384Identifier_A, sha384Size, trailerField).GetEncoded("DER");
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_512_A = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha512Identifier_A, mgf1SHA512Identifier_A, sha512Size, trailerField).GetEncoded("DER");
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_256_B = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha256Identifier_B, mgf1SHA256Identifier_B, sha256Size, trailerField).GetEncoded("DER");
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_384_B = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha384Identifier_B, mgf1SHA384Identifier_B, sha384Size, trailerField).GetEncoded("DER");
				global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_512_B = new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(sha512Identifier_B, mgf1SHA512Identifier_B, sha512Size, trailerField).GetEncoded("DER");
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::System.InvalidOperationException(ex.Message);
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000329C4 File Offset: 0x00030BC4
		public static bool SupportsPkcs1(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pubKeyAlgID)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
			return global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Equals(oid) || global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdEARsa.Equals(oid);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000329F4 File Offset: 0x00030BF4
		public static bool SupportsPss_Pss(short signatureAlgorithm, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pubKeyAlgID)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
			if (!global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Equals(oid))
			{
				return false;
			}
			global::Org.BouncyCastle.Asn1.Asn1Encodable pssParams = pubKeyAlgID.Parameters;
			if (pssParams == null || pssParams is global::Org.BouncyCastle.Asn1.DerNull)
			{
				return signatureAlgorithm - 9 <= 2;
			}
			byte[] encoded;
			try
			{
				encoded = pssParams.ToAsn1Object().GetEncoded("DER");
			}
			catch (global::System.Exception)
			{
				return false;
			}
			byte[] expected_A;
			byte[] expected_B;
			switch (signatureAlgorithm)
			{
			case 9:
				expected_A = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_256_A;
				expected_B = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_256_B;
				break;
			case 10:
				expected_A = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_384_A;
				expected_B = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_384_B;
				break;
			case 11:
				expected_A = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_512_A;
				expected_B = global::Org.BouncyCastle.Tls.Crypto.Impl.RsaUtilities.RSAPSSParams_512_B;
				break;
			default:
				return false;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.AreEqual(expected_A, encoded) || global::Org.BouncyCastle.Utilities.Arrays.AreEqual(expected_B, encoded);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00032ABC File Offset: 0x00030CBC
		public static bool SupportsPss_Rsae(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier pubKeyAlgID)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = pubKeyAlgID.Algorithm;
			return global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption.Equals(oid);
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly byte[] RSAPSSParams_256_A;

		// Token: 0x040007D8 RID: 2008
		private static readonly byte[] RSAPSSParams_384_A;

		// Token: 0x040007D9 RID: 2009
		private static readonly byte[] RSAPSSParams_512_A;

		// Token: 0x040007DA RID: 2010
		private static readonly byte[] RSAPSSParams_256_B;

		// Token: 0x040007DB RID: 2011
		private static readonly byte[] RSAPSSParams_384_B;

		// Token: 0x040007DC RID: 2012
		private static readonly byte[] RSAPSSParams_512_B;
	}
}
