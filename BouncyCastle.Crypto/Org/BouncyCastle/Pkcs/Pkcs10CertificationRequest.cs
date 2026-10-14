using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AB RID: 427
	public class Pkcs10CertificationRequest : global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequest
	{
		// Token: 0x06001029 RID: 4137 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
		static Pkcs10CertificationRequest()
		{
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("MD2WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("MD2WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("MD5WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("MD5WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RSAWITHMD5", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-1WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-1WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-224WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-224WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-256WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-384WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-384WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512(224)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512(224)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512(256)WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA-512(256)WITHRSA", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RSAWITHSHA1", global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD128WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD128WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD160WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD160WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD256WITHRSAENCRYPTION", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("RIPEMD256WITHRSA", global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA1WITHDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("DSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA224WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA256WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA384WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512WITHDSA", global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA1WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA224WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA256WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA384WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("SHA512WITHECDSA", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("ECDSAWITHSHA1", global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("GOST3411WITHGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("GOST3410WITHGOST3411", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("GOST3411WITHECGOST3410", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("GOST3411WITHECGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.algorithms.Add("GOST3411WITHGOST3410-2001", global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption, "SHA1WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption, "SHA224WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption, "SHA256WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption, "SHA384WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption, "SHA512WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption, "SHA512(224)WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption, "SHA512(256)WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94, "GOST3411WITHGOST3410");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001, "GOST3411WITHECGOST3410");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption, "MD5WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption, "MD2WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1, "SHA1WITHDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1, "SHA1WITHECDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224, "SHA224WITHECDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256, "SHA256WITHECDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384, "SHA384WITHECDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512, "SHA512WITHECDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa, "MD5WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa, "SHA1WITHRSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1, "SHA1WITHDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224, "SHA224WITHDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.oids.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256, "SHA256WITHDSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.keyAlgorithms.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption, "RSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.keyAlgorithms.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsa, "DSA");
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha1AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Add("SHA1WITHRSAANDMGF1", global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.CreatePssParams(sha1AlgId, 20));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha224AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Add("SHA224WITHRSAANDMGF1", global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.CreatePssParams(sha224AlgId, 28));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Add("SHA256WITHRSAANDMGF1", global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.CreatePssParams(sha256AlgId, 32));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Add("SHA384WITHRSAANDMGF1", global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.CreatePssParams(sha384AlgId, 48));
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.exParams.Add("SHA512WITHRSAANDMGF1", global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.CreatePssParams(sha512AlgId, 64));
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00040811 File Offset: 0x0003EA11
		private static global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters CreatePssParams(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgId, int saltSize)
		{
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, hashAlgId), new global::Org.BouncyCastle.Asn1.DerInteger(saltSize), new global::Org.BouncyCastle.Asn1.DerInteger(1));
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00040830 File Offset: 0x0003EA30
		protected Pkcs10CertificationRequest()
		{
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00040838 File Offset: 0x0003EA38
		public Pkcs10CertificationRequest(byte[] encoded) : base((global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(encoded))
		{
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0004084B File Offset: 0x0003EA4B
		public Pkcs10CertificationRequest(global::Org.BouncyCastle.Asn1.Asn1Sequence seq) : base(seq)
		{
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00040854 File Offset: 0x0003EA54
		public Pkcs10CertificationRequest(global::System.IO.Stream input) : base((global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(input))
		{
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00040867 File Offset: 0x0003EA67
		public Pkcs10CertificationRequest(string signatureAlgorithm, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter signingKey) : this(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(signatureAlgorithm, signingKey), subject, publicKey, attributes)
		{
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x0004087B File Offset: 0x0003EA7B
		[global::System.Obsolete("Use constructor without 'signingKey' parameter (ignored here)")]
		public Pkcs10CertificationRequest(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureFactory, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter signingKey) : this(signatureFactory, subject, publicKey, attributes)
		{
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00040888 File Offset: 0x0003EA88
		public Pkcs10CertificationRequest(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureFactory, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			if (signatureFactory == null)
			{
				throw new global::System.ArgumentNullException("signatureFactory");
			}
			if (subject == null)
			{
				throw new global::System.ArgumentNullException("subject");
			}
			if (publicKey == null)
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("expected public key", "publicKey");
			}
			this.Init(signatureFactory, subject, publicKey, attributes);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000408E8 File Offset: 0x0003EAE8
		private void Init(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureFactory, global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey, global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			this.sigAlgId = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureFactory.AlgorithmDetails;
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pubInfo = global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey);
			this.reqInfo = new global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo(subject, pubInfo, attributes);
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureFactory.CreateCalculator();
			byte[] reqInfoData = this.reqInfo.GetDerEncoded();
			streamCalculator.Stream.Write(reqInfoData, 0, reqInfoData.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			this.sigBits = new global::Org.BouncyCastle.Asn1.DerBitString(((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00040965 File Offset: 0x0003EB65
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter GetPublicKey()
		{
			return global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(this.reqInfo.SubjectPublicKeyInfo);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00040977 File Offset: 0x0003EB77
		public bool Verify()
		{
			return this.Verify(this.GetPublicKey());
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00040985 File Offset: 0x0003EB85
		public bool Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return this.Verify(new global::Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactoryProvider(publicKey));
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00040993 File Offset: 0x0003EB93
		public bool Verify(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierProvider)
		{
			return this.Verify(verifierProvider.CreateVerifierFactory(this.sigAlgId));
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x000409A8 File Offset: 0x0003EBA8
		public bool Verify(global::Org.BouncyCastle.Crypto.IVerifierFactory verifier)
		{
			bool result;
			try
			{
				byte[] b = this.reqInfo.GetDerEncoded();
				global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = verifier.CreateCalculator();
				streamCalculator.Stream.Write(b, 0, b.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
				result = ((global::Org.BouncyCastle.Crypto.IVerifier)streamCalculator.GetResult()).IsVerified(this.sigBits.GetOctets());
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.SignatureException("exception encoding TBS cert request", e);
			}
			return result;
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00040A20 File Offset: 0x0003EC20
		private void SetSignatureParameters(global::Org.BouncyCastle.Crypto.ISigner signature, global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params)
		{
			if (asn1Params != null && !(asn1Params is global::Org.BouncyCastle.Asn1.Asn1Null) && global::Org.BouncyCastle.Utilities.Platform.EndsWith(signature.AlgorithmName, "MGF1"))
			{
				throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("signature algorithm with MGF1");
			}
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00040A4C File Offset: 0x0003EC4C
		internal static string GetSignatureName(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId)
		{
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = sigAlgId.Parameters;
			if (asn1Params != null && !(asn1Params is global::Org.BouncyCastle.Asn1.Asn1Null) && sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
			{
				return global::Org.BouncyCastle.Pkcs.Pkcs10CertificationRequest.GetDigestAlgName(global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(asn1Params).HashAlgorithm.Algorithm) + "withRSAandMGF1";
			}
			return sigAlgId.Algorithm.Id;
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00040AA8 File Offset: 0x0003ECA8
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

		// Token: 0x0600103B RID: 4155 RVA: 0x00040BA0 File Offset: 0x0003EDA0
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions GetRequestedExtensions()
		{
			if (this.reqInfo.Attributes != null)
			{
				foreach (object obj in this.reqInfo.Attributes)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable item = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs attributePkcs;
					try
					{
						attributePkcs = global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs.GetInstance(item);
					}
					catch (global::System.ArgumentException ex)
					{
						throw new global::System.ArgumentException("encountered non PKCS attribute in extensions block", ex);
					}
					if (attributePkcs.AttrType.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtExtensionRequest))
					{
						global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator generator = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();
						foreach (object obj2 in global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(attributePkcs.AttrValues[0]))
						{
							global::Org.BouncyCastle.Asn1.Asn1Sequence itemSeq = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2);
							if (itemSeq.Count == 2)
							{
								generator.AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(itemSeq[0]), false, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(itemSeq[1]).GetOctets());
							}
							else
							{
								if (itemSeq.Count != 3)
								{
									throw new global::System.ArgumentException("incorrect sequence size of X509Extension got " + itemSeq.Count.ToString() + " expected 2 or 3");
								}
								generator.AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(itemSeq[0]), global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(itemSeq[1]).IsTrue, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(itemSeq[2]).GetOctets());
							}
						}
						return generator.Generate();
					}
				}
			}
			return null;
		}

		// Token: 0x0400089B RID: 2203
		protected static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400089C RID: 2204
		protected static readonly global::System.Collections.IDictionary exParams = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400089D RID: 2205
		protected static readonly global::System.Collections.IDictionary keyAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400089E RID: 2206
		protected static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400089F RID: 2207
		protected static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
