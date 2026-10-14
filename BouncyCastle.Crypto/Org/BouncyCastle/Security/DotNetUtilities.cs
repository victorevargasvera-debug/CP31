using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C3 RID: 451
	public sealed class DotNetUtilities
	{
		// Token: 0x060010D0 RID: 4304 RVA: 0x00046876 File Offset: 0x00044A76
		private DotNetUtilities()
		{
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0004687E File Offset: 0x00044A7E
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509Struct)
		{
			return new global::System.Security.Cryptography.X509Certificates.X509Certificate(x509Struct.GetDerEncoded());
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0004688B File Offset: 0x00044A8B
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(global::Org.BouncyCastle.X509.X509Certificate x509Cert)
		{
			return new global::System.Security.Cryptography.X509Certificates.X509Certificate(x509Cert.GetEncoded());
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00046898 File Offset: 0x00044A98
		public static global::Org.BouncyCastle.X509.X509Certificate FromX509Certificate(global::System.Security.Cryptography.X509Certificates.X509Certificate x509Cert)
		{
			return new global::Org.BouncyCastle.X509.X509CertificateParser().ReadCertificate(x509Cert.GetRawCertData());
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000468AA File Offset: 0x00044AAA
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GetDsaKeyPair(global::System.Security.Cryptography.DSA dsa)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.GetDsaKeyPair(dsa.ExportParameters(true));
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000468B8 File Offset: 0x00044AB8
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GetDsaKeyPair(global::System.Security.Cryptography.DSAParameters dp)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validationParameters = (dp.Seed != null) ? new global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters(dp.Seed, dp.Counter) : null;
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(new global::Org.BouncyCastle.Math.BigInteger(1, dp.P), new global::Org.BouncyCastle.Math.BigInteger(1, dp.Q), new global::Org.BouncyCastle.Math.BigInteger(1, dp.G), validationParameters);
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter = new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(new global::Org.BouncyCastle.Math.BigInteger(1, dp.Y), parameters);
			global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters privKey = new global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(new global::Org.BouncyCastle.Math.BigInteger(1, dp.X), parameters);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter, privKey);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00046938 File Offset: 0x00044B38
		public static global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters GetDsaPublicKey(global::System.Security.Cryptography.DSA dsa)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.GetDsaPublicKey(dsa.ExportParameters(false));
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00046948 File Offset: 0x00044B48
		public static global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters GetDsaPublicKey(global::System.Security.Cryptography.DSAParameters dp)
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validationParameters = (dp.Seed != null) ? new global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters(dp.Seed, dp.Counter) : null;
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.DsaParameters(new global::Org.BouncyCastle.Math.BigInteger(1, dp.P), new global::Org.BouncyCastle.Math.BigInteger(1, dp.Q), new global::Org.BouncyCastle.Math.BigInteger(1, dp.G), validationParameters);
			return new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(new global::Org.BouncyCastle.Math.BigInteger(1, dp.Y), parameters);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x000469AF File Offset: 0x00044BAF
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GetRsaKeyPair(global::System.Security.Cryptography.RSA rsa)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.GetRsaKeyPair(rsa.ExportParameters(true));
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x000469C0 File Offset: 0x00044BC0
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GetRsaKeyPair(global::System.Security.Cryptography.RSAParameters rp)
		{
			global::Org.BouncyCastle.Math.BigInteger modulus = new global::Org.BouncyCastle.Math.BigInteger(1, rp.Modulus);
			global::Org.BouncyCastle.Math.BigInteger pubExp = new global::Org.BouncyCastle.Math.BigInteger(1, rp.Exponent);
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicParameter = new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, modulus, pubExp);
			global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters privKey = new global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters(modulus, pubExp, new global::Org.BouncyCastle.Math.BigInteger(1, rp.D), new global::Org.BouncyCastle.Math.BigInteger(1, rp.P), new global::Org.BouncyCastle.Math.BigInteger(1, rp.Q), new global::Org.BouncyCastle.Math.BigInteger(1, rp.DP), new global::Org.BouncyCastle.Math.BigInteger(1, rp.DQ), new global::Org.BouncyCastle.Math.BigInteger(1, rp.InverseQ));
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(publicParameter, privKey);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00046A45 File Offset: 0x00044C45
		public static global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters GetRsaPublicKey(global::System.Security.Cryptography.RSA rsa)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.GetRsaPublicKey(rsa.ExportParameters(false));
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00046A53 File Offset: 0x00044C53
		public static global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters GetRsaPublicKey(global::System.Security.Cryptography.RSAParameters rp)
		{
			return new global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters(false, new global::Org.BouncyCastle.Math.BigInteger(1, rp.Modulus), new global::Org.BouncyCastle.Math.BigInteger(1, rp.Exponent));
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00046A73 File Offset: 0x00044C73
		public static global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GetKeyPair(global::System.Security.Cryptography.AsymmetricAlgorithm privateKey)
		{
			if (privateKey is global::System.Security.Cryptography.DSA)
			{
				return global::Org.BouncyCastle.Security.DotNetUtilities.GetDsaKeyPair((global::System.Security.Cryptography.DSA)privateKey);
			}
			if (privateKey is global::System.Security.Cryptography.RSA)
			{
				return global::Org.BouncyCastle.Security.DotNetUtilities.GetRsaKeyPair((global::System.Security.Cryptography.RSA)privateKey);
			}
			throw new global::System.ArgumentException("Unsupported algorithm specified", "privateKey");
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00046AAC File Offset: 0x00044CAC
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaKey)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(rsaKey));
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x00046AB9 File Offset: 0x00044CB9
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaKey, global::System.Security.Cryptography.CspParameters csp)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(rsaKey), csp);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x00046AC7 File Offset: 0x00044CC7
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters privKey)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(privKey));
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x00046AD4 File Offset: 0x00044CD4
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters privKey, global::System.Security.Cryptography.CspParameters csp)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(privKey), csp);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x00046AE2 File Offset: 0x00044CE2
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure privKey)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(privKey));
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00046AEF File Offset: 0x00044CEF
		public static global::System.Security.Cryptography.RSA ToRSA(global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure privKey, global::System.Security.Cryptography.CspParameters csp)
		{
			return global::Org.BouncyCastle.Security.DotNetUtilities.CreateRSAProvider(global::Org.BouncyCastle.Security.DotNetUtilities.ToRSAParameters(privKey), csp);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00046B00 File Offset: 0x00044D00
		public static global::System.Security.Cryptography.RSAParameters ToRSAParameters(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaKey)
		{
			global::System.Security.Cryptography.RSAParameters rp = default(global::System.Security.Cryptography.RSAParameters);
			rp.Modulus = rsaKey.Modulus.ToByteArrayUnsigned();
			if (rsaKey.IsPrivate)
			{
				rp.D = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(rsaKey.Exponent, rp.Modulus.Length);
			}
			else
			{
				rp.Exponent = rsaKey.Exponent.ToByteArrayUnsigned();
			}
			return rp;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00046B60 File Offset: 0x00044D60
		public static global::System.Security.Cryptography.RSAParameters ToRSAParameters(global::Org.BouncyCastle.Crypto.Parameters.RsaPrivateCrtKeyParameters privKey)
		{
			global::System.Security.Cryptography.RSAParameters rp = default(global::System.Security.Cryptography.RSAParameters);
			rp.Modulus = privKey.Modulus.ToByteArrayUnsigned();
			rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned();
			rp.P = privKey.P.ToByteArrayUnsigned();
			rp.Q = privKey.Q.ToByteArrayUnsigned();
			rp.D = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.Exponent, rp.Modulus.Length);
			rp.DP = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.DP, rp.P.Length);
			rp.DQ = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.DQ, rp.Q.Length);
			rp.InverseQ = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.QInv, rp.Q.Length);
			return rp;
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00046C28 File Offset: 0x00044E28
		public static global::System.Security.Cryptography.RSAParameters ToRSAParameters(global::Org.BouncyCastle.Asn1.Pkcs.RsaPrivateKeyStructure privKey)
		{
			global::System.Security.Cryptography.RSAParameters rp = default(global::System.Security.Cryptography.RSAParameters);
			rp.Modulus = privKey.Modulus.ToByteArrayUnsigned();
			rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned();
			rp.P = privKey.Prime1.ToByteArrayUnsigned();
			rp.Q = privKey.Prime2.ToByteArrayUnsigned();
			rp.D = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.PrivateExponent, rp.Modulus.Length);
			rp.DP = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.Exponent1, rp.P.Length);
			rp.DQ = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.Exponent2, rp.Q.Length);
			rp.InverseQ = global::Org.BouncyCastle.Security.DotNetUtilities.ConvertRSAParametersField(privKey.Coefficient, rp.Q.Length);
			return rp;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00046CF0 File Offset: 0x00044EF0
		private static byte[] ConvertRSAParametersField(global::Org.BouncyCastle.Math.BigInteger n, int size)
		{
			byte[] bs = n.ToByteArrayUnsigned();
			if (bs.Length == size)
			{
				return bs;
			}
			if (bs.Length > size)
			{
				throw new global::System.ArgumentException("Specified size too small", "size");
			}
			byte[] padded = new byte[size];
			global::System.Array.Copy(bs, 0, padded, size - bs.Length, bs.Length);
			return padded;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00046D3A File Offset: 0x00044F3A
		private static global::System.Security.Cryptography.RSA CreateRSAProvider(global::System.Security.Cryptography.RSAParameters rp)
		{
			global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(new global::System.Security.Cryptography.CspParameters
			{
				KeyContainerName = string.Format("BouncyCastle-{0}", global::System.Guid.NewGuid())
			});
			rsacryptoServiceProvider.ImportParameters(rp);
			return rsacryptoServiceProvider;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00046D67 File Offset: 0x00044F67
		private static global::System.Security.Cryptography.RSA CreateRSAProvider(global::System.Security.Cryptography.RSAParameters rp, global::System.Security.Cryptography.CspParameters csp)
		{
			global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(csp);
			rsacryptoServiceProvider.ImportParameters(rp);
			return rsacryptoServiceProvider;
		}
	}
}
