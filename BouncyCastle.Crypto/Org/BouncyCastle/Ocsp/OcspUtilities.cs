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

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E5 RID: 485
	internal class OcspUtilities
	{
		// Token: 0x060011E2 RID: 4578 RVA: 0x0004EB94 File Offset: 0x0004CD94
		static OcspUtilities()
		{
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("MD2WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("MD2WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("MD5WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("MD5WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA-512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD160WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD160WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD128WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD128WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("RIPEMD256WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA1WITHDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("DSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA224WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA256WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA1WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("ECDSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA224WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA256WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA384WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("SHA512WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("GOST3411WITHGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Add("GOST3411WITHGOST3410-94", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption, "MD2WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption, "MD5WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption, "SHA1WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption, "SHA224WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption, "SHA256WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption, "SHA384WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption, "SHA512WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption, "SHA512(224)WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption, "SHA512(256)WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160, "RIPEMD160WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128, "RIPEMD128WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256, "RIPEMD256WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1, "SHA1WITHDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224, "SHA224WITHDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256, "SHA256WITHDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1, "SHA1WITHECDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224, "SHA224WITHECDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256, "SHA256WITHECDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384, "SHA384WITHECDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512, "SHA512WITHECDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94, "GOST3411WITHGOST3410");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa, "MD5WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa, "SHA1WITHRSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1, "SHA1WITHDSA");
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0004F20E File Offset: 0x0004D40E
		internal static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetAlgorithmOid(string algorithmName)
		{
			algorithmName = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithmName);
			if (global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Contains(algorithmName))
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms[algorithmName];
			}
			return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(algorithmName);
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0004F23C File Offset: 0x0004D43C
		internal static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			if (global::Org.BouncyCastle.Ocsp.OcspUtilities.oids.Contains(oid))
			{
				return (string)global::Org.BouncyCastle.Ocsp.OcspUtilities.oids[oid];
			}
			return oid.Id;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0004F262 File Offset: 0x0004D462
		internal static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetSigAlgID(global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid)
		{
			if (global::Org.BouncyCastle.Ocsp.OcspUtilities.noParams.Contains(sigOid))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid);
			}
			return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOid, global::Org.BouncyCastle.Asn1.DerNull.Instance);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004F283 File Offset: 0x0004D483
		internal static global::System.Collections.IEnumerable AlgNames
		{
			get
			{
				return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(global::Org.BouncyCastle.Ocsp.OcspUtilities.algorithms.Keys);
			}
		}

		// Token: 0x040008F9 RID: 2297
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008FA RID: 2298
		private static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008FB RID: 2299
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
