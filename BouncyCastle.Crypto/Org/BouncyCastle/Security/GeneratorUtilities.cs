using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.EdEC;
using Org.BouncyCastle.Asn1.Iana;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Nsri;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C5 RID: 453
	public sealed class GeneratorUtilities
	{
		// Token: 0x060010EC RID: 4332 RVA: 0x00046D91 File Offset: 0x00044F91
		private GeneratorUtilities()
		{
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00046D9C File Offset: 0x00044F9C
		static GeneratorUtilities()
		{
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("AES", new object[]
			{
				"AESWRAP"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("AES128", new object[]
			{
				"2.16.840.1.101.3.4.2",
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ccm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cfb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ecb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Gcm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Ofb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("AES192", new object[]
			{
				"2.16.840.1.101.3.4.22",
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ccm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cfb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ecb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Gcm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Ofb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("AES256", new object[]
			{
				"2.16.840.1.101.3.4.42",
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ccm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cfb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ecb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Gcm,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Ofb,
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("BLOWFISH", new object[]
			{
				"1.3.6.1.4.1.3029.1.2"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAMELLIA", new object[]
			{
				"CAMELLIAWRAP"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("ARIA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("ARIA128", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_cbc,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ccm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_cfb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ctr,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ecb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_gcm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ocb2,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria128_ofb
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("ARIA192", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_cbc,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ccm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_cfb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ctr,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ecb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_gcm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ocb2,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria192_ofb
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("ARIA256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_cbc,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ccm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_cfb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ctr,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ecb,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_gcm,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ocb2,
				global::Org.BouncyCastle.Asn1.Nsri.NsriObjectIdentifiers.id_aria256_ofb
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAMELLIA128", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAMELLIA192", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAMELLIA256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAST5", new object[]
			{
				"1.2.840.113533.7.66.10"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CAST6", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CHACHA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("CHACHA7539", new object[]
			{
				"CHACHA20",
				"CHACHA20-POLY1305",
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgAeadChaCha20Poly1305
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("DES", new object[]
			{
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCfb,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEcb,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesOfb
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("DESEDE", new object[]
			{
				"DESEDEWRAP",
				"TDEA",
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEde
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("DESEDE3", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc,
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCms3DesWrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("GOST28147", new object[]
			{
				"GOST",
				"GOST-28147",
				global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR28147Cbc
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("HC128", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("HC256", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("IDEA", new object[]
			{
				"1.3.6.1.4.1.188.7.1.1.2"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("NOEKEON", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RC2", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc,
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCmsRC2Wrap
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RC4", new object[]
			{
				"ARC4",
				"1.2.840.113549.3.4"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RC5", new object[]
			{
				"RC5-32"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RC5-64", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RC6", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("RIJNDAEL", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("SALSA20", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("SEED", new object[]
			{
				global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap,
				global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("SERPENT", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("SKIPJACK", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("SM4", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("TEA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("THREEFISH-256", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("THREEFISH-512", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("THREEFISH-1024", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("TNEPRES", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("TWOFISH", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("VMPC", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("VMPC-KSA3", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKgAlgorithm("XTEA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("MD2", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("MD4", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("MD5", new object[]
			{
				global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacMD5
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA1", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha1,
				global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA224", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha224
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha256
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA384", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha384
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA512", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha512
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA512/224", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA512/256", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("KECCAK224", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("KECCAK256", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("KECCAK288", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("KECCAK384", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("KECCAK512", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA3-224", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_224
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA3-256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_256
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA3-384", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_384
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("SHA3-512", new object[]
			{
				global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_512
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("RIPEMD128", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("RIPEMD160", new object[]
			{
				global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacRipeMD160
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("TIGER", new object[]
			{
				global::Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacTiger
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("GOST3411-2012-256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_hmac_gost_3411_12_256
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddHMacKeyGenerator("GOST3411-2012-512", new object[]
			{
				global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_hmac_gost_3411_12_512
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("DH", new object[]
			{
				"DIFFIEHELLMAN"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("DSA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("EC", new object[]
			{
				global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.DHSinglePassStdDHSha1KdfScheme
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ECDH", new object[]
			{
				"ECIES"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ECDHC", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ECMQV", new object[]
			{
				global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.MqvSinglePassSha1KdfScheme
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ECDSA", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ECGOST3410", new object[]
			{
				"ECGOST-3410",
				"GOST-3410-2001"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("Ed25519", new object[]
			{
				"Ed25519ctx",
				"Ed25519ph",
				global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed25519
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("Ed448", new object[]
			{
				"Ed448ph",
				global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_Ed448
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("ELGAMAL", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("GOST3410", new object[]
			{
				"GOST-3410",
				"GOST-3410-94"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("RSA", new object[]
			{
				"1.2.840.113549.1.1.1"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("RSASSA-PSS", new object[0]);
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("X25519", new object[]
			{
				global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X25519
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddKpgAlgorithm("X448", new object[]
			{
				global::Org.BouncyCastle.Asn1.EdEC.EdECObjectIdentifiers.id_X448
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(64, new string[]
			{
				"DES"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(80, new string[]
			{
				"SKIPJACK"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(128, new string[]
			{
				"AES128",
				"ARIA128",
				"BLOWFISH",
				"CAMELLIA128",
				"CAST5",
				"CHACHA",
				"DESEDE",
				"HC128",
				"HMACMD2",
				"HMACMD4",
				"HMACMD5",
				"HMACRIPEMD128",
				"IDEA",
				"NOEKEON",
				"RC2",
				"RC4",
				"RC5",
				"SALSA20",
				"SEED",
				"SM4",
				"TEA",
				"XTEA",
				"VMPC",
				"VMPC-KSA3"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(160, new string[]
			{
				"HMACRIPEMD160",
				"HMACSHA1"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(192, new string[]
			{
				"AES",
				"AES192",
				"ARIA192",
				"CAMELLIA192",
				"DESEDE3",
				"HMACTIGER",
				"RIJNDAEL",
				"SERPENT",
				"TNEPRES"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(224, new string[]
			{
				"HMACSHA3-224",
				"HMACKECCAK224",
				"HMACSHA224",
				"HMACSHA512/224"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(256, new string[]
			{
				"AES256",
				"ARIA",
				"ARIA256",
				"CAMELLIA",
				"CAMELLIA256",
				"CAST6",
				"CHACHA7539",
				"GOST28147",
				"HC256",
				"HMACGOST3411-2012-256",
				"HMACSHA3-256",
				"HMACKECCAK256",
				"HMACSHA256",
				"HMACSHA512/256",
				"RC5-64",
				"RC6",
				"THREEFISH-256",
				"TWOFISH"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(288, new string[]
			{
				"HMACKECCAK288"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(384, new string[]
			{
				"HMACSHA3-384",
				"HMACKECCAK384",
				"HMACSHA384"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(512, new string[]
			{
				"HMACGOST3411-2012-512",
				"HMACSHA3-512",
				"HMACKECCAK512",
				"HMACSHA512",
				"THREEFISH-512"
			});
			global::Org.BouncyCastle.Security.GeneratorUtilities.AddDefaultKeySizeEntries(1024, new string[]
			{
				"THREEFISH-1024"
			});
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00047984 File Offset: 0x00045B84
		private static void AddDefaultKeySizeEntries(int size, params string[] algorithms)
		{
			foreach (string algorithm in algorithms)
			{
				global::Org.BouncyCastle.Security.GeneratorUtilities.defaultKeySizes.Add(algorithm, size);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x000479B8 File Offset: 0x00045BB8
		private static void AddKgAlgorithm(string canonicalName, params object[] aliases)
		{
			global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(canonicalName)] = canonicalName;
			foreach (object alias in aliases)
			{
				global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias.ToString())] = canonicalName;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00047A00 File Offset: 0x00045C00
		private static void AddKpgAlgorithm(string canonicalName, params object[] aliases)
		{
			global::Org.BouncyCastle.Security.GeneratorUtilities.kpgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(canonicalName)] = canonicalName;
			foreach (object alias in aliases)
			{
				global::Org.BouncyCastle.Security.GeneratorUtilities.kpgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias.ToString())] = canonicalName;
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00047A48 File Offset: 0x00045C48
		private static void AddHMacKeyGenerator(string algorithm, params object[] aliases)
		{
			string mainName = "HMAC" + algorithm;
			global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms[mainName] = mainName;
			global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms["HMAC-" + algorithm] = mainName;
			global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms["HMAC/" + algorithm] = mainName;
			foreach (object alias in aliases)
			{
				global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(alias.ToString())] = mainName;
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00047AC3 File Offset: 0x00045CC3
		internal static string GetCanonicalKeyGeneratorAlgorithm(string algorithm)
		{
			return (string)global::Org.BouncyCastle.Security.GeneratorUtilities.kgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00047ADA File Offset: 0x00045CDA
		internal static string GetCanonicalKeyPairGeneratorAlgorithm(string algorithm)
		{
			return (string)global::Org.BouncyCastle.Security.GeneratorUtilities.kpgAlgorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00047AF1 File Offset: 0x00045CF1
		public static global::Org.BouncyCastle.Crypto.CipherKeyGenerator GetKeyGenerator(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(oid.Id);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00047B00 File Offset: 0x00045D00
		public static global::Org.BouncyCastle.Crypto.CipherKeyGenerator GetKeyGenerator(string algorithm)
		{
			string canonicalName = global::Org.BouncyCastle.Security.GeneratorUtilities.GetCanonicalKeyGeneratorAlgorithm(algorithm);
			if (canonicalName == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("KeyGenerator " + algorithm + " not recognised.");
			}
			int defaultKeySize = global::Org.BouncyCastle.Security.GeneratorUtilities.FindDefaultKeySize(canonicalName);
			if (defaultKeySize == -1)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException(string.Concat(new string[]
				{
					"KeyGenerator ",
					algorithm,
					" (",
					canonicalName,
					") not supported."
				}));
			}
			if (canonicalName == "DES")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.DesKeyGenerator(defaultKeySize);
			}
			if (canonicalName == "DESEDE" || canonicalName == "DESEDE3")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.DesEdeKeyGenerator(defaultKeySize);
			}
			return new global::Org.BouncyCastle.Crypto.CipherKeyGenerator(defaultKeySize);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00047BA4 File Offset: 0x00045DA4
		public static global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyPairGenerator(oid.Id);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00047BB4 File Offset: 0x00045DB4
		public static global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator GetKeyPairGenerator(string algorithm)
		{
			string canonicalName = global::Org.BouncyCastle.Security.GeneratorUtilities.GetCanonicalKeyPairGeneratorAlgorithm(algorithm);
			if (canonicalName == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("KeyPairGenerator " + algorithm + " not recognised.");
			}
			if (canonicalName == "DH")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.DHKeyPairGenerator();
			}
			if (canonicalName == "DSA")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator();
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(canonicalName, "EC"))
			{
				return new global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator(canonicalName);
			}
			if (canonicalName == "Ed25519")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.Ed25519KeyPairGenerator();
			}
			if (canonicalName == "Ed448")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.Ed448KeyPairGenerator();
			}
			if (canonicalName == "ELGAMAL")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.ElGamalKeyPairGenerator();
			}
			if (canonicalName == "GOST3410")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.Gost3410KeyPairGenerator();
			}
			if (canonicalName == "RSA" || canonicalName == "RSASSA-PSS")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.RsaKeyPairGenerator();
			}
			if (canonicalName == "X25519")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.X25519KeyPairGenerator();
			}
			if (canonicalName == "X448")
			{
				return new global::Org.BouncyCastle.Crypto.Generators.X448KeyPairGenerator();
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException(string.Concat(new string[]
			{
				"KeyPairGenerator ",
				algorithm,
				" (",
				canonicalName,
				") not supported."
			}));
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00047CDD File Offset: 0x00045EDD
		internal static int GetDefaultKeySize(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return global::Org.BouncyCastle.Security.GeneratorUtilities.GetDefaultKeySize(oid.Id);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00047CEC File Offset: 0x00045EEC
		internal static int GetDefaultKeySize(string algorithm)
		{
			string canonicalName = global::Org.BouncyCastle.Security.GeneratorUtilities.GetCanonicalKeyGeneratorAlgorithm(algorithm);
			if (canonicalName == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("KeyGenerator " + algorithm + " not recognised.");
			}
			int defaultKeySize = global::Org.BouncyCastle.Security.GeneratorUtilities.FindDefaultKeySize(canonicalName);
			if (defaultKeySize == -1)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException(string.Concat(new string[]
				{
					"KeyGenerator ",
					algorithm,
					" (",
					canonicalName,
					") not supported."
				}));
			}
			return defaultKeySize;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00047D56 File Offset: 0x00045F56
		private static int FindDefaultKeySize(string canonicalName)
		{
			if (!global::Org.BouncyCastle.Security.GeneratorUtilities.defaultKeySizes.Contains(canonicalName))
			{
				return -1;
			}
			return (int)global::Org.BouncyCastle.Security.GeneratorUtilities.defaultKeySizes[canonicalName];
		}

		// Token: 0x040008CC RID: 2252
		private static readonly global::System.Collections.IDictionary kgAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008CD RID: 2253
		private static readonly global::System.Collections.IDictionary kpgAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008CE RID: 2254
		private static readonly global::System.Collections.IDictionary defaultKeySizes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
