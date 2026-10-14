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
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001D RID: 29
	internal class X509Utilities
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000089A8 File Offset: 0x00006BA8
		static X509Utilities()
		{
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("MD2WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("MD2WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("MD5WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("MD5WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA-512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD160WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD160WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD128WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD128WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("RIPEMD256WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA1WITHDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("DSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA224WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA256WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA384WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA1WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("ECDSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA224WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA256WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA384WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("SHA512WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("GOST3411WITHGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("GOST3411WITHGOST3410-94", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("GOST3411WITHECGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("GOST3411WITHECGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.X509.X509Utilities.algorithms.Add("GOST3411WITHGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.X509.X509Utilities.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha1AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.X509.X509Utilities.exParams.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.X509.X509Utilities.CreatePssParams(sha1AlgId, 20));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha224AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.X509.X509Utilities.exParams.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.X509.X509Utilities.CreatePssParams(sha224AlgId, 28));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.X509.X509Utilities.exParams.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.X509.X509Utilities.CreatePssParams(sha256AlgId, 32));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.X509.X509Utilities.exParams.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.X509.X509Utilities.CreatePssParams(sha384AlgId, 48));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.X509.X509Utilities.exParams.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.X509.X509Utilities.CreatePssParams(sha512AlgId, 64));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000900B File Offset: 0x0000720B
		private static global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters CreatePssParams(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgId, int saltSize)
		{
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, hashAlgId), new global::Org.BouncyCastle.Asn1.DerInteger(saltSize), new global::Org.BouncyCastle.Asn1.DerInteger(1));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000902A File Offset: 0x0000722A
		internal static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetAlgorithmOid(string algorithmName)
		{
			algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithmName);
			if (global::Org.BouncyCastle.X509.X509Utilities.algorithms.Contains(algorithmName))
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.X509.X509Utilities.algorithms[algorithmName];
			}
			return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(algorithmName);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009058 File Offset: 0x00007258
		internal static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetSigAlgID(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid, string algorithmName)
		{
			if (global::Org.BouncyCastle.X509.X509Utilities.noParams.Contains(sigOid))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid);
			}
			algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithmName);
			if (global::Org.BouncyCastle.X509.X509Utilities.exParams.Contains(algorithmName))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, (global::Org.BouncyCastle.Asn1.Asn1Encodable)global::Org.BouncyCastle.X509.X509Utilities.exParams[algorithmName]);
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, global::Org.BouncyCastle.Asn1.DerNull.Instance);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000090B0 File Offset: 0x000072B0
		internal static global::System.Collections.IEnumerable GetAlgNames()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.X509.X509Utilities.algorithms.Keys);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000090C4 File Offset: 0x000072C4
		internal static byte[] GetSignatureForObject(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid, string sigName, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Asn1.Asn1Encodable ae)
		{
			if (sigOid == null)
			{
				throw new global::System.ArgumentNullException("sigOid");
			}
			global::Org.BouncyCastle.Crypto.ISigner sig = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(sigName);
			if (random != null)
			{
				sig.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(privateKey, random));
			}
			else
			{
				sig.Init(true, privateKey);
			}
			byte[] encoded = ae.GetDerEncoded();
			sig.BlockUpdate(encoded, 0, encoded.Length);
			return sig.GenerateSignature();
		}

		// Token: 0x040000AC RID: 172
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040000AD RID: 173
		private static readonly global::System.Collections.IDictionary exParams = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040000AE RID: 174
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
