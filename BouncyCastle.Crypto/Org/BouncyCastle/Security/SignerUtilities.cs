using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Bsi;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Eac;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001D2 RID: 466
	public sealed class SignerUtilities
	{
		// Token: 0x06001166 RID: 4454 RVA: 0x0004B654 File Offset: 0x00049854
		private SignerUtilities()
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0004B65C File Offset: 0x0004985C
		static SignerUtilities()
		{
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD2WITHRSA"] = "MD2withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD2WITHRSAENCRYPTION"] = "MD2withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption.Id] = "MD2withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD4WITHRSA"] = "MD4withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD4WITHRSAENCRYPTION"] = "MD4withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption.Id] = "MD4withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsa.Id] = "MD4withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD4WithRsaEncryption.Id] = "MD4withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD5WITHRSA"] = "MD5withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["MD5WITHRSAENCRYPTION"] = "MD5withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption.Id] = "MD5withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.MD5WithRsa.Id] = "MD5withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHRSA"] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHRSA"] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHRSAENCRYPTION"] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHRSAENCRYPTION"] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.Sha1WithRsa.Id] = "SHA-1withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHRSA"] = "SHA-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHRSA"] = "SHA-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHRSAENCRYPTION"] = "SHA-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHRSAENCRYPTION"] = "SHA-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption.Id] = "SHA-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHRSA"] = "SHA-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHRSA"] = "SHA-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHRSAENCRYPTION"] = "SHA-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHRSAENCRYPTION"] = "SHA-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption.Id] = "SHA-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHRSA"] = "SHA-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHRSA"] = "SHA-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHRSAENCRYPTION"] = "SHA-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHRSAENCRYPTION"] = "SHA-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption.Id] = "SHA-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHRSA"] = "SHA-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHRSA"] = "SHA-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHRSAENCRYPTION"] = "SHA-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHRSAENCRYPTION"] = "SHA-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption.Id] = "SHA-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512(224)WITHRSA"] = "SHA-512(224)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512(224)WITHRSA"] = "SHA-512(224)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512(224)WITHRSAENCRYPTION"] = "SHA-512(224)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512(224)WITHRSAENCRYPTION"] = "SHA-512(224)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption.Id] = "SHA-512(224)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512(256)WITHRSA"] = "SHA-512(256)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512(256)WITHRSA"] = "SHA-512(256)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512(256)WITHRSAENCRYPTION"] = "SHA-512(256)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512(256)WITHRSAENCRYPTION"] = "SHA-512(256)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption.Id] = "SHA-512(256)withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-224WITHRSA"] = "SHA3-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-224WITHRSAENCRYPTION"] = "SHA3-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224.Id] = "SHA3-224withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-256WITHRSA"] = "SHA3-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-256WITHRSAENCRYPTION"] = "SHA3-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256.Id] = "SHA3-256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-384WITHRSA"] = "SHA3-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-384WITHRSAENCRYPTION"] = "SHA3-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384.Id] = "SHA3-384withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-512WITHRSA"] = "SHA3-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA3-512WITHRSAENCRYPTION"] = "SHA3-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512.Id] = "SHA3-512withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PSSWITHRSA"] = "PSSwithRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RSASSA-PSS"] = "PSSwithRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Id] = "PSSwithRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RSAPSS"] = "PSSwithRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHRSAANDMGF1"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHRSAANDMGF1"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHRSA/PSS"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHRSA/PSS"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHRSASSA-PSS"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHRSASSA-PSS"] = "SHA-1withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHRSAANDMGF1"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHRSAANDMGF1"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHRSA/PSS"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHRSA/PSS"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHRSASSA-PSS"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHRSASSA-PSS"] = "SHA-224withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHRSAANDMGF1"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHRSAANDMGF1"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHRSA/PSS"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHRSA/PSS"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHRSASSA-PSS"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHRSASSA-PSS"] = "SHA-256withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHRSAANDMGF1"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHRSAANDMGF1"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHRSA/PSS"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHRSA/PSS"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHRSASSA-PSS"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHRSASSA-PSS"] = "SHA-384withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHRSAANDMGF1"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHRSAANDMGF1"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHRSA/PSS"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHRSA/PSS"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHRSASSA-PSS"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHRSASSA-PSS"] = "SHA-512withRSAandMGF1";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD128WITHRSA"] = "RIPEMD128withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD128WITHRSAENCRYPTION"] = "RIPEMD128withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128.Id] = "RIPEMD128withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160WITHRSA"] = "RIPEMD160withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160WITHRSAENCRYPTION"] = "RIPEMD160withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160.Id] = "RIPEMD160withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD256WITHRSA"] = "RIPEMD256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD256WITHRSAENCRYPTION"] = "RIPEMD256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256.Id] = "RIPEMD256withRSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHRSA"] = "RSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RSAWITHNONE"] = "RSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RAWRSA"] = "RSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RAWRSAPSS"] = "RAWRSASSA-PSS";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHRSAPSS"] = "RAWRSASSA-PSS";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHRSASSA-PSS"] = "RAWRSASSA-PSS";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHDSA"] = "NONEwithDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHNONE"] = "NONEwithDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RAWDSA"] = "NONEwithDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA1"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA-1"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA/DSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1/DSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1/DSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHDSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHDSA"] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1.Id] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DsaWithSha1.Id] = "SHA-1withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA224"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA-224"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224/DSA"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224/DSA"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHDSA"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHDSA"] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224.Id] = "SHA-224withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA256"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA-256"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256/DSA"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256/DSA"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHDSA"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHDSA"] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256.Id] = "SHA-256withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA384"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA-384"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384/DSA"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384/DSA"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHDSA"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHDSA"] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384.Id] = "SHA-384withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA512"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["DSAWITHSHA-512"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512/DSA"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512/DSA"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHDSA"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHDSA"] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512.Id] = "SHA-512withDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHECDSA"] = "NONEwithECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHNONE"] = "NONEwithECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSA"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1/ECDSA"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1/ECDSA"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA1"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA-1"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHECDSA"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHECDSA"] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1.Id] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithSha1.Id] = "SHA-1withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224/ECDSA"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224/ECDSA"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA224"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA-224"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHECDSA"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHECDSA"] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224.Id] = "SHA-224withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256/ECDSA"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256/ECDSA"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA256"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA-256"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHECDSA"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHECDSA"] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256.Id] = "SHA-256withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384/ECDSA"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384/ECDSA"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA384"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA-384"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHECDSA"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHECDSA"] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384.Id] = "SHA-384withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512/ECDSA"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512/ECDSA"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA512"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHSHA-512"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHECDSA"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHECDSA"] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512.Id] = "SHA-512withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160/ECDSA"] = "RIPEMD160withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECDSAWITHRIPEMD160"] = "RIPEMD160withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160WITHECDSA"] = "RIPEMD160withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithRipeMD160.Id] = "RIPEMD160withECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHCVC-ECDSA"] = "NONEwithCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHNONE"] = "NONEwithCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1/CVC-ECDSA"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1/CVC-ECDSA"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA1"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA-1"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHCVC-ECDSA"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHCVC-ECDSA"] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1.Id] = "SHA-1withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224/CVC-ECDSA"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224/CVC-ECDSA"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA224"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA-224"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHCVC-ECDSA"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHCVC-ECDSA"] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224.Id] = "SHA-224withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256/CVC-ECDSA"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256/CVC-ECDSA"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA256"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA-256"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHCVC-ECDSA"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHCVC-ECDSA"] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256.Id] = "SHA-256withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384/CVC-ECDSA"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384/CVC-ECDSA"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA384"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA-384"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHCVC-ECDSA"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHCVC-ECDSA"] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384.Id] = "SHA-384withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512/CVC-ECDSA"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512/CVC-ECDSA"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA512"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["CVC-ECDSAWITHSHA-512"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHCVC-ECDSA"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHCVC-ECDSA"] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512.Id] = "SHA-512withCVC-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["NONEWITHPLAIN-ECDSA"] = "NONEwithPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHNONE"] = "NONEwithPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1/PLAIN-ECDSA"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1/PLAIN-ECDSA"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA1"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA-1"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHPLAIN-ECDSA"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHPLAIN-ECDSA"] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA1.Id] = "SHA-1withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224/PLAIN-ECDSA"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224/PLAIN-ECDSA"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA224"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA-224"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHPLAIN-ECDSA"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHPLAIN-ECDSA"] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA224.Id] = "SHA-224withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256/PLAIN-ECDSA"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256/PLAIN-ECDSA"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA256"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA-256"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHPLAIN-ECDSA"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHPLAIN-ECDSA"] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA256.Id] = "SHA-256withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384/PLAIN-ECDSA"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384/PLAIN-ECDSA"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA384"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA-384"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHPLAIN-ECDSA"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHPLAIN-ECDSA"] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA384.Id] = "SHA-384withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512/PLAIN-ECDSA"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512/PLAIN-ECDSA"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA512"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHSHA-512"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHPLAIN-ECDSA"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHPLAIN-ECDSA"] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA512.Id] = "SHA-512withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160/PLAIN-ECDSA"] = "RIPEMD160withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["PLAIN-ECDSAWITHRIPEMD160"] = "RIPEMD160withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["RIPEMD160WITHPLAIN-ECDSA"] = "RIPEMD160withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_RIPEMD160.Id] = "RIPEMD160withPLAIN-ECDSA";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA1WITHECNR"] = "SHA-1withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-1WITHECNR"] = "SHA-1withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA224WITHECNR"] = "SHA-224withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-224WITHECNR"] = "SHA-224withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHECNR"] = "SHA-256withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-256WITHECNR"] = "SHA-256withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA384WITHECNR"] = "SHA-384withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-384WITHECNR"] = "SHA-384withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA512WITHECNR"] = "SHA-512withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA-512WITHECNR"] = "SHA-512withECNR";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["GOST-3410"] = "GOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["GOST-3410-94"] = "GOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["GOST3411WITHGOST3410"] = "GOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94.Id] = "GOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECGOST-3410"] = "ECGOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ECGOST-3410-2001"] = "ECGOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["GOST3411WITHECGOST3410"] = "ECGOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001.Id] = "ECGOST3410";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ED25519"] = "Ed25519";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519.Id] = "Ed25519";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ED25519CTX"] = "Ed25519ctx";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ED25519PH"] = "Ed25519ph";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ED448"] = "Ed448";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448.Id] = "Ed448";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["ED448PH"] = "Ed448ph";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SHA256WITHSM2"] = "SHA256withSM2";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sha256.Id] = "SHA256withSM2";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms["SM3WITHSM2"] = "SM3withSM2";
			global::Org.BouncyCastle.Security.SignerUtilities.algorithms[global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sm3.Id] = "SM3withSM2";
			global::Org.BouncyCastle.Security.SignerUtilities.oids["MD2withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["MD4withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["MD5withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-224withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-256withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-384withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512(224)withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_224WithRSAEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512(256)withRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512_256WithRSAEncryption;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA3-224withRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_224;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA3-256withRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA3-384withRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_384;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA3-512withRSA"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdRsassaPkcs1V15WithSha3_512;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["PSSwithRSA"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withRSAandMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-224withRSAandMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-256withRSAandMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-384withRSAandMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512withRSAandMGF1"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["RIPEMD128withRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["RIPEMD160withRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["RIPEMD256withRSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-224withECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-256withECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-384withECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512withECDSA"] = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["RIPEMD160withECDSA"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithRipeMD160;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_1;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-224withCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_224;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-256withCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-384withCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_384;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512withCVC-ECDSA"] = global::Org.BouncyCastle.Asn1.Eac.EacObjectIdentifiers.id_TA_ECDSA_SHA_512;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-1withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA1;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-224withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA224;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-256withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-384withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA384;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA-512withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_SHA512;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["RIPEMD160withPLAIN-ECDSA"] = global::Org.BouncyCastle.Asn1.Bsi.BsiObjectIdentifiers.ecdsa_plain_RIPEMD160;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["GOST3410"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["ECGOST3410"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["Ed25519"] = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["Ed448"] = global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SHA256withSM2"] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sha256;
			global::Org.BouncyCastle.Security.SignerUtilities.oids["SM3withSM2"] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm2sign_with_sm3;
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0004D2A0 File Offset: 0x0004B4A0
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			if (mechanism == null)
			{
				throw new global::System.ArgumentNullException("mechanism");
			}
			mechanism = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(mechanism);
			string aliased = (string)global::Org.BouncyCastle.Security.SignerUtilities.algorithms[mechanism];
			if (aliased != null)
			{
				mechanism = aliased;
			}
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Security.SignerUtilities.oids[mechanism];
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0004D2EA File Offset: 0x0004B4EA
		public static global::System.Collections.ICollection Algorithms
		{
			get
			{
				return global::Org.BouncyCastle.Security.SignerUtilities.oids.Keys;
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0004D2F6 File Offset: 0x0004B4F6
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GetDefaultX509Parameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id)
		{
			return global::Org.BouncyCastle.Security.SignerUtilities.GetDefaultX509Parameters(id.Id);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0004D304 File Offset: 0x0004B504
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GetDefaultX509Parameters(string algorithm)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			algorithm = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.SignerUtilities.algorithms[algorithm];
			if (mechanism == null)
			{
				mechanism = algorithm;
			}
			if (mechanism == "PSSwithRSA")
			{
				return global::Org.BouncyCastle.Security.SignerUtilities.GetPssX509Parameters("SHA-1");
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withRSAandMGF1"))
			{
				return global::Org.BouncyCastle.Security.SignerUtilities.GetPssX509Parameters(mechanism.Substring(0, mechanism.Length - "withRSAandMGF1".Length));
			}
			return global::Org.BouncyCastle.Asn1.DerNull.Instance;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0004D388 File Offset: 0x0004B588
		private static global::Org.BouncyCastle.Asn1.Asn1Encodable GetPssX509Parameters(string digestName)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Security.DigestUtilities.GetObjectIdentifier(digestName), global::Org.BouncyCastle.Asn1.DerNull.Instance);
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier maskGenAlgorithm = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, hashAlgorithm);
			int saltLen = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestName).GetDigestSize();
			return new global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgorithm, maskGenAlgorithm, new global::Org.BouncyCastle.Asn1.DerInteger(saltLen), new global::Org.BouncyCastle.Asn1.DerInteger(1));
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0004D3D1 File Offset: 0x0004B5D1
		public static global::Org.BouncyCastle.Crypto.ISigner GetSigner(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id)
		{
			return global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(id.Id);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0004D3E0 File Offset: 0x0004B5E0
		public static global::Org.BouncyCastle.Crypto.ISigner GetSigner(string algorithm)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			algorithm = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.SignerUtilities.algorithms[algorithm];
			if (mechanism == null)
			{
				mechanism = algorithm;
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "Ed"))
			{
				if (mechanism.Equals("Ed25519"))
				{
					return new global::Org.BouncyCastle.Crypto.Signers.Ed25519Signer();
				}
				if (mechanism.Equals("Ed25519ctx"))
				{
					return new global::Org.BouncyCastle.Crypto.Signers.Ed25519ctxSigner(global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes);
				}
				if (mechanism.Equals("Ed25519ph"))
				{
					return new global::Org.BouncyCastle.Crypto.Signers.Ed25519phSigner(global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes);
				}
				if (mechanism.Equals("Ed448"))
				{
					return new global::Org.BouncyCastle.Crypto.Signers.Ed448Signer(global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes);
				}
				if (mechanism.Equals("Ed448ph"))
				{
					return new global::Org.BouncyCastle.Crypto.Signers.Ed448phSigner(global::Org.BouncyCastle.Utilities.Arrays.EmptyBytes);
				}
			}
			if (mechanism.Equals("RSA"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(new global::Org.BouncyCastle.Crypto.Digests.NullDigest(), null);
			}
			if (mechanism.Equals("RAWRSASSA-PSS"))
			{
				return global::Org.BouncyCastle.Crypto.Signers.PssSigner.CreateRawSigner(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest());
			}
			if (mechanism.Equals("PSSwithRSA"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.PssSigner(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest());
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withRSA"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with"))));
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withRSAandMGF1"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with")));
				return new global::Org.BouncyCastle.Crypto.Signers.PssSigner(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withDSA"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest2 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with")));
				return new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.DsaSigner(), digest2);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withECDSA"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest3 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with")));
				return new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(), digest3);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withCVC-ECDSA") || global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withPLAIN-ECDSA"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest4 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with")));
				return new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(), digest4, global::Org.BouncyCastle.Crypto.Signers.PlainDsaEncoding.Instance);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withECNR"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest5 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with")));
				return new global::Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECNRSigner(), digest5);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "withSM2"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.SM2Signer(global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring(0, mechanism.LastIndexOf("with"))));
			}
			if (mechanism.Equals("GOST3410"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.Gost3410DigestSigner(new global::Org.BouncyCastle.Crypto.Signers.Gost3410Signer(), new global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest());
			}
			if (mechanism.Equals("ECGOST3410"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.Gost3410DigestSigner(new global::Org.BouncyCastle.Crypto.Signers.ECGost3410Signer(), new global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest());
			}
			if (mechanism.Equals("SHA1WITHRSA/ISO9796-2"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.Iso9796d2Signer(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest(), true);
			}
			if (mechanism.Equals("MD5WITHRSA/ISO9796-2"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.Iso9796d2Signer(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), new global::Org.BouncyCastle.Crypto.Digests.MD5Digest(), true);
			}
			if (mechanism.Equals("RIPEMD160WITHRSA/ISO9796-2"))
			{
				return new global::Org.BouncyCastle.Crypto.Signers.Iso9796d2Signer(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), new global::Org.BouncyCastle.Crypto.Digests.RipeMD160Digest(), true);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "/X9.31"))
			{
				string x931 = mechanism.Substring(0, mechanism.Length - "/X9.31".Length);
				int withPos = global::Org.BouncyCastle.Utilities.Platform.IndexOf(x931, "WITH");
				if (withPos > 0)
				{
					int endPos = withPos + "WITH".Length;
					global::Org.BouncyCastle.Crypto.IDigest digest6 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(x931.Substring(0, withPos));
					if (x931.Substring(endPos, x931.Length - endPos).Equals("RSA"))
					{
						return new global::Org.BouncyCastle.Crypto.Signers.X931Signer(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest6);
					}
				}
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Signer " + algorithm + " not recognised.");
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0004D77A File Offset: 0x0004B97A
		public static string GetEncodingName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.SignerUtilities.algorithms[oid.Id];
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0004D791 File Offset: 0x0004B991
		public static global::Org.BouncyCastle.Crypto.ISigner InitSigner(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid, bool forSigning, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return global::Org.BouncyCastle.Security.SignerUtilities.InitSigner(algorithmOid.Id, forSigning, privateKey, random);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0004D7A1 File Offset: 0x0004B9A1
		public static global::Org.BouncyCastle.Crypto.ISigner InitSigner(string algorithm, bool forSigning, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			global::Org.BouncyCastle.Crypto.ISigner signer = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner(algorithm);
			signer.Init(forSigning, global::Org.BouncyCastle.Security.ParameterUtilities.WithRandom(privateKey, random));
			return signer;
		}

		// Token: 0x040008DD RID: 2269
		internal static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008DE RID: 2270
		internal static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
