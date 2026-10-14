using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001C RID: 28
	internal class X509SignatureUtilities
	{
		// Token: 0x06000132 RID: 306 RVA: 0x00008806 File Offset: 0x00006A06
		internal static void SetSignatureParameters(global::Org.BouncyCastle.Crypto.ISigner signature, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters)
		{
			if (parameters != null)
			{
				global::Org.BouncyCastle.X509.X509SignatureUtilities.derNull.Equals(parameters);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00008818 File Offset: 0x00006A18
		internal static string GetSignatureName(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = sigAlgId.Parameters;
			if (parameters != null && !global::Org.BouncyCastle.X509.X509SignatureUtilities.derNull.Equals(parameters))
			{
				if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
				{
					return global::Org.BouncyCastle.X509.X509SignatureUtilities.GetDigestAlgName(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(parameters).HashAlgorithm.Algorithm) + "withRSAandMGF1";
				}
				if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2))
				{
					return global::Org.BouncyCastle.X509.X509SignatureUtilities.GetDigestAlgName((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(parameters)[0]) + "withECDSA";
				}
			}
			string sigName = global::Org.BouncyCastle.Security.SignerUtilities.GetEncodingName(sigAlgId.Algorithm);
			if (sigName != null)
			{
				return sigName;
			}
			return sigAlgId.Algorithm.Id;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000088C0 File Offset: 0x00006AC0
		private static string GetDigestAlgName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestAlgOID)
		{
			if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Equals(digestAlgOID))
			{
				return "MD5";
			}
			if (global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Equals(digestAlgOID))
			{
				return "SHA1";
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Equals(digestAlgOID))
			{
				return "SHA224";
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Equals(digestAlgOID))
			{
				return "SHA256";
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Equals(digestAlgOID))
			{
				return "SHA384";
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Equals(digestAlgOID))
			{
				return "SHA512";
			}
			if (global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Equals(digestAlgOID))
			{
				return "RIPEMD128";
			}
			if (global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Equals(digestAlgOID))
			{
				return "RIPEMD160";
			}
			if (global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Equals(digestAlgOID))
			{
				return "RIPEMD256";
			}
			if (global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Equals(digestAlgOID))
			{
				return "GOST3411";
			}
			return digestAlgOID.Id;
		}

		// Token: 0x040000AB RID: 171
		private static readonly global::Org.BouncyCastle.Asn1.Asn1Null derNull = global::Org.BouncyCastle.Asn1.DerNull.Instance;
	}
}
