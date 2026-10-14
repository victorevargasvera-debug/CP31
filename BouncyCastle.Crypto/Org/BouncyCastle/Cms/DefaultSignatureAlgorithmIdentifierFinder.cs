using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Asn1.Bsi;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Eac;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200053A RID: 1338
	public class DefaultSignatureAlgorithmIdentifierFinder
	{
		// Token: 0x060033BC RID: 13244 RVA: 0x000F61C0 File Offset: 0x000F43C0
		static DefaultSignatureAlgorithmIdentifierFinder()
		{
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["MD2WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["MD2WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["MD5WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["MD5WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-1WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-1WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-224WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-224WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-256WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-256WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-384WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-384WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512(224)WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512(224)WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512(224)WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512(224)WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512(256)WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512(256)WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512(256)WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-512(256)WITHRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-224WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-256WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-384WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHRSAANDMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD160WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD160WITHRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD128WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD128WITHRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD256WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD256WITHRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA-1WITHDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["DSAWITHSHA1"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-224WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-256WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-384WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-224WITHECDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-256WITHECDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-384WITHECDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHECDSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-224WITHRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-256WITHRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-384WITHRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-224WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-256WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-384WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHRSAENCRYPTION"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["ECDSAWITHSHA1"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHGOST3410"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHGOST3410-94"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHECGOST3410"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHECGOST3410-2001"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHGOST3410-2001"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHECGOST3410-2012-256"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHECGOST3410-2012-512"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHGOST3410-2012-256"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411WITHGOST3410-2012-512"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411-2012-256WITHECGOST3410-2012-256"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411-2012-512WITHECGOST3410-2012-512"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411-2012-256WITHGOST3410-2012-256"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["GOST3411-2012-512WITHGOST3410-2012-512"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["RIPEMD160WITHPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_RIPEMD160;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA1WITHCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA224WITHCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA384WITHCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA3-512WITHSPHINCS256"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256_with_SHA3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHSPHINCS256"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256_with_SHA512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHSM2"] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SM3WITHSM2"] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sm3;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHXMSS"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHA256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHXMSS"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHA512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHAKE128WITHXMSS"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHAKE128;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHAKE256WITHXMSS"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHAKE256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA256WITHXMSSMT"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHA256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHA512WITHXMSSMT"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHA512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHAKE128WITHXMSSMT"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHAKE128;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms["SHAKE256WITHXMSSMT"] = global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHAKE256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_224);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_384);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_224);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_384);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256_with_SHA512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.sphincs256_with_SHA3_512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHA256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHA512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHAKE128);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_with_SHAKE256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHA256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHA512);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHAKE128);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.xmss_mt_with_SHAKE256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sha256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Add(global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sm3);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Add(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha1AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA1WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha1AlgId, 20);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha224AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA224WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha224AlgId, 28);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha256AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA256WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha256AlgId, 32);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha384AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA384WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha384AlgId, 48);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha512AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA512WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha512AlgId, 64);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha3_224AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA3-224WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha3_224AlgId, 28);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha3_256AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA3-256WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha3_256AlgId, 32);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha3_384AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA3-384WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha3_384AlgId, 48);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sha3_512AlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params["SHA3-512WITHRSAANDMGF1"] = global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.CreatePssParams(sha3_512AlgId, 64);
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_224] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_256] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_384] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdDsaWithSha3_512] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_224] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_256] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_384] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdEcdsaWithSha3_512] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption] = global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_256] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_signwithdigest_gost_3410_12_512] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sha256] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sm3] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x000F7210 File Offset: 0x000F5410
		private static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Generate(string signatureAlgorithm)
		{
			string algorithmName = global::Org.BouncyCastle.Utilities.Strings.ToUpperCase(signatureAlgorithm);
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.algorithms[algorithmName];
			if (sigOID == null)
			{
				throw new global::System.ArgumentException("Unknown signature type requested: " + algorithmName);
			}
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;
			if (global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.noParams.Contains(sigOID))
			{
				sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOID);
			}
			else if (global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params.Contains(algorithmName))
			{
				sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOID, (global::Org.BouncyCastle.Asn1.Asn1Encodable)global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder._params[algorithmName]);
			}
			else
			{
				sigAlgId = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(sigOID, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			if (global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.pkcs15RsaEncryption.Contains(sigOID))
			{
				new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			if (sigAlgId.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
			{
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm = ((global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)sigAlgId.Parameters).HashAlgorithm;
			}
			else
			{
				new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.digestOids[sigOID], global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			return sigAlgId;
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x000F72EF File Offset: 0x000F54EF
		private static global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters CreatePssParams(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgId, int saltSize)
		{
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgId, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, hashAlgId), new global::Org.BouncyCastle.Asn1.DerInteger(saltSize), new global::Org.BouncyCastle.Asn1.DerInteger(1));
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x000F730E File Offset: 0x000F550E
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Find(string sigAlgName)
		{
			return global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder.Generate(sigAlgName);
		}

		// Token: 0x0400170C RID: 5900
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400170D RID: 5901
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet noParams = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x0400170E RID: 5902
		private static readonly global::System.Collections.IDictionary _params = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400170F RID: 5903
		private static readonly global::Org.BouncyCastle.Utilities.Collections.ISet pkcs15RsaEncryption = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04001710 RID: 5904
		private static readonly global::System.Collections.IDictionary digestOids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001711 RID: 5905
		private static readonly global::System.Collections.IDictionary digestBuilders = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001712 RID: 5906
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_RSA = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RsaEncryption;

		// Token: 0x04001713 RID: 5907
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_DSA = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1;

		// Token: 0x04001714 RID: 5908
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECDSA = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1;

		// Token: 0x04001715 RID: 5909
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_RSA_PSS = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;

		// Token: 0x04001716 RID: 5910
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_GOST3410 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94;

		// Token: 0x04001717 RID: 5911
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410 = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x2001;

		// Token: 0x04001718 RID: 5912
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410_2012_256 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_256;

		// Token: 0x04001719 RID: 5913
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier ENCRYPTION_ECGOST3410_2012_512 = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3410_12_512;
	}
}
