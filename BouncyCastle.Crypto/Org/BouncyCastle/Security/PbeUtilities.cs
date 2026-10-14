using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CC RID: 460
	public sealed class PbeUtilities
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x00048EC9 File Offset: 0x000470C9
		private PbeUtilities()
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00048ED4 File Offset: 0x000470D4
		static PbeUtilities()
		{
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PKCS5SCHEME1"] = "Pkcs5scheme1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PKCS5SCHEME2"] = "Pkcs5scheme2";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBKDF2"] = "Pkcs5scheme2";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbeS2.Id] = "Pkcs5scheme2";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD2ANDDES-CBC"] = "PBEwithMD2andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD2AndDesCbc.Id] = "PBEwithMD2andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD2ANDRC2-CBC"] = "PBEwithMD2andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD2AndRC2Cbc.Id] = "PBEwithMD2andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD5ANDDES-CBC"] = "PBEwithMD5andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD5AndDesCbc.Id] = "PBEwithMD5andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD5ANDRC2-CBC"] = "PBEwithMD5andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD5AndRC2Cbc.Id] = "PBEwithMD5andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1ANDDES"] = "PBEwithSHA-1andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1ANDDES"] = "PBEwithSHA-1andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1ANDDES-CBC"] = "PBEwithSHA-1andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1ANDDES-CBC"] = "PBEwithSHA-1andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndDesCbc.Id] = "PBEwithSHA-1andDES-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1ANDRC2"] = "PBEwithSHA-1andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1ANDRC2"] = "PBEwithSHA-1andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1ANDRC2-CBC"] = "PBEwithSHA-1andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1ANDRC2-CBC"] = "PBEwithSHA-1andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndRC2Cbc.Id] = "PBEwithSHA-1andRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PKCS12"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12_aes128_cbc.Id] = "PBEwithSHA-1and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12_aes192_cbc.Id] = "PBEwithSHA-1and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha1_pkcs12_aes256_cbc.Id] = "PBEwithSHA-1and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12_aes128_cbc.Id] = "PBEwithSHA-256and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12_aes192_cbc.Id] = "PBEwithSHA-256and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.BC.BCObjectIdentifiers.bc_pbe_sha256_pkcs12_aes256_cbc.Id] = "PBEwithSHA-256and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND128BITRC4"] = "PBEwithSHA-1and128bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND128BITRC4"] = "PBEwithSHA-1and128bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND128BITRC4"] = "PBEwithSHA-1and128bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC4.Id] = "PBEwithSHA-1and128bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND40BITRC4"] = "PBEwithSHA-1and40bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND40BITRC4"] = "PBEwithSHA-1and40bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND40BITRC4"] = "PBEwithSHA-1and40bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd40BitRC4.Id] = "PBEwithSHA-1and40bitRC4";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND3-KEYDESEDE-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND3-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND3-KEYDESEDE-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND3-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND3-KEYDESEDE-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND3-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id] = "PBEwithSHA-1and3-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND2-KEYDESEDE-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND2-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND2-KEYDESEDE-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND2-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND2-KEYDESEDE-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND2-KEYTRIPLEDES-CBC"] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd2KeyTripleDesCbc.Id] = "PBEwithSHA-1and2-keyDESEDE-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND128BITRC2-CBC"] = "PBEwithSHA-1and128bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND128BITRC2-CBC"] = "PBEwithSHA-1and128bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND128BITRC2-CBC"] = "PBEwithSHA-1and128bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC2Cbc.Id] = "PBEwithSHA-1and128bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND40BITRC2-CBC"] = "PBEwithSHA-1and40bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND40BITRC2-CBC"] = "PBEwithSHA-1and40bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND40BITRC2-CBC"] = "PBEwithSHA-1and40bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc.Id] = "PBEwithSHA-1and40bitRC2-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND128BITAES-CBC-BC"] = "PBEwithSHA-1and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND128BITAES-CBC-BC"] = "PBEwithSHA-1and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND128BITAES-CBC-BC"] = "PBEwithSHA-1and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND192BITAES-CBC-BC"] = "PBEwithSHA-1and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND192BITAES-CBC-BC"] = "PBEwithSHA-1and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND192BITAES-CBC-BC"] = "PBEwithSHA-1and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAAND256BITAES-CBC-BC"] = "PBEwithSHA-1and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA1AND256BITAES-CBC-BC"] = "PBEwithSHA-1and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-1AND256BITAES-CBC-BC"] = "PBEwithSHA-1and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA256AND128BITAES-CBC-BC"] = "PBEwithSHA-256and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-256AND128BITAES-CBC-BC"] = "PBEwithSHA-256and128bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA256AND192BITAES-CBC-BC"] = "PBEwithSHA-256and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-256AND192BITAES-CBC-BC"] = "PBEwithSHA-256and192bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA256AND256BITAES-CBC-BC"] = "PBEwithSHA-256and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHA-256AND256BITAES-CBC-BC"] = "PBEwithSHA-256and256bitAES-CBC-BC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAANDIDEA"] = "PBEwithSHA-1andIDEA-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAANDIDEA-CBC"] = "PBEwithSHA-1andIDEA-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAANDTWOFISH"] = "PBEwithSHA-1andTWOFISH-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHSHAANDTWOFISH-CBC"] = "PBEwithSHA-1andTWOFISH-CBC";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA1"] = "PBEwithHmacSHA-1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA-1"] = "PBEwithHmacSHA-1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id] = "PBEwithHmacSHA-1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA224"] = "PBEwithHmacSHA-224";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA-224"] = "PBEwithHmacSHA-224";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id] = "PBEwithHmacSHA-224";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA256"] = "PBEwithHmacSHA-256";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACSHA-256"] = "PBEwithHmacSHA-256";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id] = "PBEwithHmacSHA-256";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACRIPEMD128"] = "PBEwithHmacRipeMD128";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id] = "PBEwithHmacRipeMD128";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACRIPEMD160"] = "PBEwithHmacRipeMD160";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id] = "PBEwithHmacRipeMD160";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACRIPEMD256"] = "PBEwithHmacRipeMD256";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id] = "PBEwithHmacRipeMD256";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHHMACTIGER"] = "PBEwithHmacTiger";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD5AND128BITAES-CBC-OPENSSL"] = "PBEwithMD5and128bitAES-CBC-OpenSSL";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD5AND192BITAES-CBC-OPENSSL"] = "PBEwithMD5and192bitAES-CBC-OpenSSL";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithms["PBEWITHMD5AND256BITAES-CBC-OPENSSL"] = "PBEwithMD5and256bitAES-CBC-OpenSSL";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["Pkcs5scheme1"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["Pkcs5scheme2"] = "Pkcs5S2";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD2andDES-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD2andRC2-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD5andDES-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD5andRC2-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1andDES-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1andRC2-CBC"] = "Pkcs5S1";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["Pkcs12"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and128bitRC4"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and40bitRC4"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and3-keyDESEDE-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and2-keyDESEDE-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and128bitRC2-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and40bitRC2-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and128bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and192bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1and256bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-256and128bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-256and192bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-256and256bitAES-CBC-BC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1andIDEA-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithSHA-1andTWOFISH-CBC"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacSHA-1"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacSHA-224"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacSHA-256"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacRipeMD128"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacRipeMD160"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacRipeMD256"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithHmacTiger"] = "Pkcs12";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD5and128bitAES-CBC-OpenSSL"] = "OpenSsl";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD5and192bitAES-CBC-OpenSSL"] = "OpenSsl";
			global::Org.BouncyCastle.Security.PbeUtilities.algorithmType["PBEwithMD5and256bitAES-CBC-OpenSSL"] = "OpenSsl";
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithMD2andDES-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD2AndDesCbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithMD2andRC2-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD2AndRC2Cbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithMD5andDES-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD5AndDesCbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithMD5andRC2-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithMD5AndRC2Cbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1andDES-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndDesCbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1andRC2-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithSha1AndRC2Cbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and128bitRC4"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC4;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and40bitRC4"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd40BitRC4;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and3-keyDESEDE-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and2-keyDESEDE-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd2KeyTripleDesCbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and128bitRC2-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd128BitRC2Cbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithSHA-1and40bitRC2-CBC"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacSHA-1"] = global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacSHA-224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacSHA-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacRipeMD128"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacRipeMD160"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["PBEwithHmacRipeMD256"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256;
			global::Org.BouncyCastle.Security.PbeUtilities.oids["Pkcs5scheme2"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbeS2;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00049B20 File Offset: 0x00047D20
		private static global::Org.BouncyCastle.Crypto.PbeParametersGenerator MakePbeGenerator(string type, global::Org.BouncyCastle.Crypto.IDigest digest, byte[] key, byte[] salt, int iterationCount)
		{
			global::Org.BouncyCastle.Crypto.PbeParametersGenerator generator;
			if (type.Equals("Pkcs5S1"))
			{
				generator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S1ParametersGenerator(digest);
			}
			else if (type.Equals("Pkcs5S2"))
			{
				generator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator(digest);
			}
			else if (type.Equals("Pkcs12"))
			{
				generator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs12ParametersGenerator(digest);
			}
			else
			{
				if (!type.Equals("OpenSsl"))
				{
					throw new global::System.ArgumentException("Unknown PBE type: " + type, "type");
				}
				generator = new global::Org.BouncyCastle.Crypto.Generators.OpenSslPbeParametersGenerator();
			}
			generator.Init(key, salt, iterationCount);
			return generator;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00049BA5 File Offset: 0x00047DA5
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(mechanism)];
			if (mechanism != null)
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Security.PbeUtilities.oids[mechanism];
			}
			return null;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x00049BD3 File Offset: 0x00047DD3
		public static global::System.Collections.ICollection Algorithms
		{
			get
			{
				return global::Org.BouncyCastle.Security.PbeUtilities.oids.Keys;
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00049BE0 File Offset: 0x00047DE0
		public static bool IsPkcs12(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			return mechanism != null && "Pkcs12".Equals(global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism]);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00049C20 File Offset: 0x00047E20
		public static bool IsPkcs5Scheme1(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			return mechanism != null && "Pkcs5S1".Equals(global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism]);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00049C60 File Offset: 0x00047E60
		public static bool IsPkcs5Scheme2(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			return mechanism != null && "Pkcs5S2".Equals(global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism]);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00049CA0 File Offset: 0x00047EA0
		public static bool IsOpenSsl(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			return mechanism != null && "OpenSsl".Equals(global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism]);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00049CE0 File Offset: 0x00047EE0
		public static bool IsPbeAlgorithm(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			return mechanism != null && global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism] != null;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00049D16 File Offset: 0x00047F16
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateAlgorithmParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid, byte[] salt, int iterationCount)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateAlgorithmParameters(algorithmOid.Id, salt, iterationCount);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00049D25 File Offset: 0x00047F25
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateAlgorithmParameters(string algorithm, byte[] salt, int iterationCount)
		{
			if (global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs12(algorithm))
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams(salt, iterationCount);
			}
			if (global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs5Scheme2(algorithm))
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params(salt, iterationCount);
			}
			return new global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter(salt, iterationCount);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00049D50 File Offset: 0x00047F50
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateAlgorithmParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier cipherAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier hashAlgorithm, byte[] salt, int iterationCount, global::Org.BouncyCastle.Security.SecureRandom secureRandom)
		{
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc.Equals(cipherAlgorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc.Equals(cipherAlgorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc.Equals(cipherAlgorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cfb.Equals(cipherAlgorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cfb.Equals(cipherAlgorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cfb.Equals(cipherAlgorithm))
			{
				byte[] iv = new byte[16];
				secureRandom.NextBytes(iv);
				global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme encScheme = new global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme(cipherAlgorithm, new global::Org.BouncyCastle.Asn1.DerOctetString(iv));
				return new global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters(new global::Org.BouncyCastle.Asn1.Pkcs.KeyDerivationFunc(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdPbkdf2, new global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params(salt, iterationCount, new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(hashAlgorithm, global::Org.BouncyCastle.Asn1.DerNull.Instance))), encScheme);
			}
			throw new global::System.ArgumentException("unknown cipher: " + ((cipherAlgorithm != null) ? cipherAlgorithm.ToString() : null));
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00049E09 File Offset: 0x00048009
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid, char[] password, global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algorithmOid.Id, password, false, pbeParameters);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00049E19 File Offset: 0x00048019
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid, char[] password, bool wrongPkcs12Zero, global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algorithmOid.Id, password, wrongPkcs12Zero, pbeParameters);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00049E29 File Offset: 0x00048029
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, char[] password)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algID.Algorithm.Id, password, false, algID.Parameters);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00049E43 File Offset: 0x00048043
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID, char[] password, bool wrongPkcs12Zero)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algID.Algorithm.Id, password, wrongPkcs12Zero, algID.Parameters);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00049E5D File Offset: 0x0004805D
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(string algorithm, char[] password, global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.GenerateCipherParameters(algorithm, password, false, pbeParameters);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00049E68 File Offset: 0x00048068
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GenerateCipherParameters(string algorithm, char[] password, bool wrongPkcs12Zero, global::Org.BouncyCastle.Asn1.Asn1Encodable pbeParameters)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			byte[] keyBytes = null;
			byte[] salt = null;
			int iterationCount = 0;
			if (global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs12(mechanism))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams instance = global::Org.BouncyCastle.Asn1.Pkcs.Pkcs12PbeParams.GetInstance(pbeParameters);
				salt = instance.GetIV();
				iterationCount = instance.Iterations.IntValue;
				keyBytes = global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs12PasswordToBytes(password, wrongPkcs12Zero);
			}
			else if (!global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs5Scheme2(mechanism))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter instance2 = global::Org.BouncyCastle.Asn1.Pkcs.PbeParameter.GetInstance(pbeParameters);
				salt = instance2.GetSalt();
				iterationCount = instance2.IterationCount.IntValue;
				keyBytes = global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs5PasswordToBytes(password);
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters parameters = null;
			if (global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs5Scheme2(mechanism))
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters instance3 = global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters.GetInstance(pbeParameters.ToAsn1Object());
				global::Org.BouncyCastle.Asn1.Pkcs.EncryptionScheme encryptionScheme = instance3.EncryptionScheme;
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier encOid = encryptionScheme.Algorithm;
				global::Org.BouncyCastle.Asn1.Asn1Object encParams = encryptionScheme.Parameters.ToAsn1Object();
				global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params pbeParams = global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params.GetInstance(instance3.KeyDerivationFunc.Parameters.ToAsn1Object());
				global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(pbeParams.Prf.Algorithm);
				byte[] iv;
				if (encOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc))
				{
					iv = global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter.GetInstance(encParams).GetIV();
				}
				else
				{
					iv = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(encParams).GetOctets();
				}
				salt = pbeParams.GetSalt();
				iterationCount = pbeParams.IterationCount.IntValue;
				keyBytes = global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs5PasswordToBytes(password);
				int keyLength = (pbeParams.KeyLength != null) ? (pbeParams.KeyLength.IntValue * 8) : global::Org.BouncyCastle.Security.GeneratorUtilities.GetDefaultKeySize(encOid);
				parameters = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], digest, keyBytes, salt, iterationCount).GenerateDerivedParameters(encOid.Id, keyLength);
				if (iv != null && !global::Org.BouncyCastle.Utilities.Arrays.AreEqual(iv, new byte[iv.Length]))
				{
					parameters = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(parameters, iv);
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithSHA-1"))
			{
				global::Org.BouncyCastle.Crypto.PbeParametersGenerator generator = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest(), keyBytes, salt, iterationCount);
				if (mechanism.Equals("PBEwithSHA-1and128bitAES-CBC-BC"))
				{
					parameters = generator.GenerateDerivedParameters("AES", 128, 128);
				}
				else if (mechanism.Equals("PBEwithSHA-1and192bitAES-CBC-BC"))
				{
					parameters = generator.GenerateDerivedParameters("AES", 192, 128);
				}
				else if (mechanism.Equals("PBEwithSHA-1and256bitAES-CBC-BC"))
				{
					parameters = generator.GenerateDerivedParameters("AES", 256, 128);
				}
				else if (mechanism.Equals("PBEwithSHA-1and128bitRC4"))
				{
					parameters = generator.GenerateDerivedParameters("RC4", 128);
				}
				else if (mechanism.Equals("PBEwithSHA-1and40bitRC4"))
				{
					parameters = generator.GenerateDerivedParameters("RC4", 40);
				}
				else if (mechanism.Equals("PBEwithSHA-1and3-keyDESEDE-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("DESEDE", 192, 64);
				}
				else if (mechanism.Equals("PBEwithSHA-1and2-keyDESEDE-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("DESEDE", 128, 64);
				}
				else if (mechanism.Equals("PBEwithSHA-1and128bitRC2-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("RC2", 128, 64);
				}
				else if (mechanism.Equals("PBEwithSHA-1and40bitRC2-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("RC2", 40, 64);
				}
				else if (mechanism.Equals("PBEwithSHA-1andDES-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("DES", 64, 64);
				}
				else if (mechanism.Equals("PBEwithSHA-1andRC2-CBC"))
				{
					parameters = generator.GenerateDerivedParameters("RC2", 64, 64);
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithSHA-256"))
			{
				global::Org.BouncyCastle.Crypto.PbeParametersGenerator generator2 = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest(), keyBytes, salt, iterationCount);
				if (mechanism.Equals("PBEwithSHA-256and128bitAES-CBC-BC"))
				{
					parameters = generator2.GenerateDerivedParameters("AES", 128, 128);
				}
				else if (mechanism.Equals("PBEwithSHA-256and192bitAES-CBC-BC"))
				{
					parameters = generator2.GenerateDerivedParameters("AES", 192, 128);
				}
				else if (mechanism.Equals("PBEwithSHA-256and256bitAES-CBC-BC"))
				{
					parameters = generator2.GenerateDerivedParameters("AES", 256, 128);
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithMD5"))
			{
				global::Org.BouncyCastle.Crypto.PbeParametersGenerator generator3 = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], new global::Org.BouncyCastle.Crypto.Digests.MD5Digest(), keyBytes, salt, iterationCount);
				if (mechanism.Equals("PBEwithMD5andDES-CBC"))
				{
					parameters = generator3.GenerateDerivedParameters("DES", 64, 64);
				}
				else if (mechanism.Equals("PBEwithMD5andRC2-CBC"))
				{
					parameters = generator3.GenerateDerivedParameters("RC2", 64, 64);
				}
				else if (mechanism.Equals("PBEwithMD5and128bitAES-CBC-OpenSSL"))
				{
					parameters = generator3.GenerateDerivedParameters("AES", 128, 128);
				}
				else if (mechanism.Equals("PBEwithMD5and192bitAES-CBC-OpenSSL"))
				{
					parameters = generator3.GenerateDerivedParameters("AES", 192, 128);
				}
				else if (mechanism.Equals("PBEwithMD5and256bitAES-CBC-OpenSSL"))
				{
					parameters = generator3.GenerateDerivedParameters("AES", 256, 128);
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithMD2"))
			{
				global::Org.BouncyCastle.Crypto.PbeParametersGenerator generator4 = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], new global::Org.BouncyCastle.Crypto.Digests.MD2Digest(), keyBytes, salt, iterationCount);
				if (mechanism.Equals("PBEwithMD2andDES-CBC"))
				{
					parameters = generator4.GenerateDerivedParameters("DES", 64, 64);
				}
				else if (mechanism.Equals("PBEwithMD2andRC2-CBC"))
				{
					parameters = generator4.GenerateDerivedParameters("RC2", 64, 64);
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithHmac"))
			{
				global::Org.BouncyCastle.Crypto.IDigest digest2 = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(mechanism.Substring("PBEwithHmac".Length));
				global::Org.BouncyCastle.Crypto.PbeParametersGenerator pbeParametersGenerator = global::Org.BouncyCastle.Security.PbeUtilities.MakePbeGenerator((string)global::Org.BouncyCastle.Security.PbeUtilities.algorithmType[mechanism], digest2, keyBytes, salt, iterationCount);
				int bitLen = digest2.GetDigestSize() * 8;
				parameters = pbeParametersGenerator.GenerateDerivedMacParameters(bitLen);
			}
			global::System.Array.Clear(keyBytes, 0, keyBytes.Length);
			return global::Org.BouncyCastle.Security.PbeUtilities.FixDesParity(mechanism, parameters);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0004A450 File Offset: 0x00048650
		public static object CreateEngine(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid)
		{
			return global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(algorithmOid.Id);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0004A460 File Offset: 0x00048660
		public static object CreateEngine(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID)
		{
			string algorithm = algID.Algorithm.Id;
			if (global::Org.BouncyCastle.Security.PbeUtilities.IsPkcs5Scheme2(algorithm))
			{
				return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Asn1.Pkcs.PbeS2Parameters.GetInstance(algID.Parameters.ToAsn1Object()).EncryptionScheme.Algorithm);
			}
			return global::Org.BouncyCastle.Security.PbeUtilities.CreateEngine(algorithm);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0004A4A8 File Offset: 0x000486A8
		public static object CreateEngine(string algorithm)
		{
			string mechanism = (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithHmac"))
			{
				string digestName = mechanism.Substring("PBEwithHmac".Length);
				return global::Org.BouncyCastle.Security.MacUtilities.GetMac("HMAC/" + digestName);
			}
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithMD2") || global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithMD5") || global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithSHA-1") || global::Org.BouncyCastle.Utilities.Platform.StartsWith(mechanism, "PBEwithSHA-256"))
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "AES-CBC-BC") || global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "AES-CBC-OPENSSL"))
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("AES/CBC");
				}
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "DES-CBC"))
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("DES/CBC");
				}
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "DESEDE-CBC"))
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("DESEDE/CBC");
				}
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "RC2-CBC"))
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("RC2/CBC");
				}
				if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "RC4"))
				{
					return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("RC4");
				}
			}
			return null;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0004A5B7 File Offset: 0x000487B7
		public static string GetEncodingName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.PbeUtilities.algorithms[oid.Id];
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0004A5D0 File Offset: 0x000487D0
		private static global::Org.BouncyCastle.Crypto.ICipherParameters FixDesParity(string mechanism, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "DES-CBC") && !global::Org.BouncyCastle.Utilities.Platform.EndsWith(mechanism, "DESEDE-CBC"))
			{
				return parameters;
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV ivParams = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
				return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(global::Org.BouncyCastle.Security.PbeUtilities.FixDesParity(mechanism, ivParams.Parameters), ivParams.GetIV());
			}
			byte[] key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			global::Org.BouncyCastle.Crypto.Parameters.DesParameters.SetOddParity(key);
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key);
		}

		// Token: 0x040008D2 RID: 2258
		private const string Pkcs5S1 = "Pkcs5S1";

		// Token: 0x040008D3 RID: 2259
		private const string Pkcs5S2 = "Pkcs5S2";

		// Token: 0x040008D4 RID: 2260
		private const string Pkcs12 = "Pkcs12";

		// Token: 0x040008D5 RID: 2261
		private const string OpenSsl = "OpenSsl";

		// Token: 0x040008D6 RID: 2262
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008D7 RID: 2263
		private static readonly global::System.Collections.IDictionary algorithmType = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008D8 RID: 2264
		private static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
