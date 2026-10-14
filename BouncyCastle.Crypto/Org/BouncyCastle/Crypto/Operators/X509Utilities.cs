using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000428 RID: 1064
	internal class X509Utilities
	{
		// Token: 0x0600291D RID: 10525 RVA: 0x000AE448 File Offset: 0x000AC648
		static X509Utilities()
		{
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("MD2WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("MD2WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("MD5WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("MD5WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA-512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-224WITHRSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-256WITHRSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-384WITHRSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA3-512WITHRSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD160WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD160WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD128WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD128WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("RIPEMD256WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA1WITHDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("DSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA224WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA256WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA384WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA1WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("ECDSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA224WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA256WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA384WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("SHA512WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("GOST3411WITHGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("GOST3411WITHGOST3410-94", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("GOST3411WITHECGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("GOST3411WITHECGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add("GOST3411WITHGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha1AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(sha1AlgId, 20));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha224AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(sha224AlgId, 28));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(sha256AlgId, 32));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(sha384AlgId, 48));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(sha512AlgId, 64));
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x000AEB58 File Offset: 0x000ACD58
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
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224.Equals(digestAlgOID))
			{
				return "SHA512(224)";
			}
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256.Equals(digestAlgOID))
			{
				return "SHA512(256)";
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

		// Token: 0x0600291F RID: 10527 RVA: 0x000AEC50 File Offset: 0x000ACE50
		internal static string GetSignatureName(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable parameters = sigAlgId.Parameters;
			if (parameters != null && !global::Org.BouncyCastle.Crypto.Operators.X509Utilities.derNull.Equals(parameters))
			{
				if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
				{
					return global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(parameters).HashAlgorithm.Algorithm) + "withRSAandMGF1";
				}
				if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2))
				{
					return global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(parameters)[0]) + "withECDSA";
				}
			}
			return sigAlgId.Algorithm.Id;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000AECE4 File Offset: 0x000ACEE4
		private static global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters CreatePssParams(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgId, int saltSize)
		{
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, hashAlgId), new global::Org.BouncyCastle.Asn1.DerInteger(saltSize), new global::Org.BouncyCastle.Asn1.DerInteger(1));
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000AED03 File Offset: 0x000ACF03
		internal static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetAlgorithmOid(string algorithmName)
		{
			algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithmName);
			if (global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Contains(algorithmName))
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms[algorithmName];
			}
			return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(algorithmName);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x000AED34 File Offset: 0x000ACF34
		internal static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetSigAlgID(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid, string algorithmName)
		{
			if (global::Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams.Contains(sigOid))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid);
			}
			algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithmName);
			if (global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Contains(algorithmName))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, (global::Org.BouncyCastle.Asn1.Asn1Encodable)global::Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams[algorithmName]);
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, global::Org.BouncyCastle.Asn1.DerNull.Instance);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000AED8C File Offset: 0x000ACF8C
		internal static global::System.Collections.IEnumerable GetAlgNames()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Keys);
		}

		// Token: 0x040010A8 RID: 4264
		private static readonly global::Org.BouncyCastle.Asn1.Asn1Null derNull = global::Org.BouncyCastle.Asn1.DerNull.Instance;

		// Token: 0x040010A9 RID: 4265
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040010AA RID: 4266
		private static readonly global::System.Collections.IDictionary exParams = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040010AB RID: 4267
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
