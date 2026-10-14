using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.GM;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Rosstandart;
using Org.BouncyCastle.Asn1.TeleTrust;
using Org.BouncyCastle.Asn1.UA;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C2 RID: 450
	public sealed class DigestUtilities
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x00045B3A File Offset: 0x00043D3A
		private DigestUtilities()
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00045B44 File Offset: 0x00043D44
		static DigestUtilities()
		{
			((global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(typeof(global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm))).ToString();
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2.Id] = "MD2";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4.Id] = "MD4";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id] = "MD5";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA1"] = "SHA-1";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id] = "SHA-1";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha1.Id] = "SHA-1";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.HMAC_SHA1.Id] = "SHA-1";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA224"] = "SHA-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id] = "SHA-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha224.Id] = "SHA-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA256"] = "SHA-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id] = "SHA-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha256.Id] = "SHA-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA384"] = "SHA-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id] = "SHA-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha384.Id] = "SHA-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA512"] = "SHA-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id] = "SHA-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha512.Id] = "SHA-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA512/224"] = "SHA-512/224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA512(224)"] = "SHA-512/224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA-512(224)"] = "SHA-512/224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224.Id] = "SHA-512/224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA512/256"] = "SHA-512/256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA512(256)"] = "SHA-512/256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHA-512(256)"] = "SHA-512/256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256.Id] = "SHA-512/256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["RIPEMD-128"] = "RIPEMD128";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id] = "RIPEMD128";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["RIPEMD-160"] = "RIPEMD160";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id] = "RIPEMD160";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["RIPEMD-256"] = "RIPEMD256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id] = "RIPEMD256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["RIPEMD-320"] = "RIPEMD320";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id] = "GOST3411";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["KECCAK224"] = "KECCAK-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["KECCAK256"] = "KECCAK-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["KECCAK288"] = "KECCAK-288";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["KECCAK384"] = "KECCAK-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["KECCAK512"] = "KECCAK-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224.Id] = "SHA3-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_224.Id] = "SHA3-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256.Id] = "SHA3-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_256.Id] = "SHA3-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384.Id] = "SHA3-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_384.Id] = "SHA3-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512.Id] = "SHA3-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdHMacWithSha3_512.Id] = "SHA3-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHAKE128"] = "SHAKE128-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128.Id] = "SHAKE128-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms["SHAKE256"] = "SHAKE256-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256.Id] = "SHAKE256-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3.Id] = "SM3";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b160.Id] = "BLAKE2B-160";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b256.Id] = "BLAKE2B-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b384.Id] = "BLAKE2B-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b512.Id] = "BLAKE2B-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s128.Id] = "BLAKE2S-128";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s160.Id] = "BLAKE2S-160";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s224.Id] = "BLAKE2S-224";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s256.Id] = "BLAKE2S-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256.Id] = "GOST3411-2012-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512.Id] = "GOST3411-2012-512";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_256.Id] = "DSTU7564-256";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_384.Id] = "DSTU7564-384";
			global::Org.BouncyCastle.Security.DigestUtilities.algorithms[global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_512.Id] = "DSTU7564-512";
			global::Org.BouncyCastle.Security.DigestUtilities.oids["MD2"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["MD4"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["MD5"] = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-1"] = global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-384"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-512"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-512/224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA-512/256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA3-224"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA3-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA3-384"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHA3-512"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHAKE128-256"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SHAKE256-512"] = global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["RIPEMD128"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["RIPEMD160"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["RIPEMD256"] = global::Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["GOST3411"] = global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["SM3"] = global::Org.BouncyCastle.Asn1.GM.GMObjectIdentifiers.sm3;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2B-160"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b160;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2B-256"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2B-384"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b384;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2B-512"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2b512;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2S-128"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s128;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2S-160"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s160;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2S-224"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s224;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["BLAKE2S-256"] = global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.id_blake2s256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["GOST3411-2012-256"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["GOST3411-2012-512"] = global::Org.BouncyCastle.Asn1.Rosstandart.RosstandartObjectIdentifiers.id_tc26_gost_3411_12_512;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["DSTU7564-256"] = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_256;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["DSTU7564-384"] = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_384;
			global::Org.BouncyCastle.Security.DigestUtilities.oids["DSTU7564-512"] = global::Org.BouncyCastle.Asn1.UA.UAObjectIdentifiers.dstu7564digest_512;
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00046434 File Offset: 0x00044634
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			if (mechanism == null)
			{
				throw new global::System.ArgumentNullException("mechanism");
			}
			mechanism = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(mechanism);
			string aliased = (string)global::Org.BouncyCastle.Security.DigestUtilities.algorithms[mechanism];
			if (aliased != null)
			{
				mechanism = aliased;
			}
			return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)global::Org.BouncyCastle.Security.DigestUtilities.oids[mechanism];
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0004647E File Offset: 0x0004467E
		public static global::System.Collections.ICollection Algorithms
		{
			get
			{
				return global::Org.BouncyCastle.Security.DigestUtilities.oids.Keys;
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0004648A File Offset: 0x0004468A
		public static global::Org.BouncyCastle.Crypto.IDigest GetDigest(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id)
		{
			return global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(id.Id);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00046498 File Offset: 0x00044698
		public static global::Org.BouncyCastle.Crypto.IDigest GetDigest(string algorithm)
		{
			string upper = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			string mechanism = (string)global::Org.BouncyCastle.Security.DigestUtilities.algorithms[upper];
			if (mechanism == null)
			{
				mechanism = upper;
			}
			try
			{
				switch ((global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm), mechanism))
				{
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2B_160:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest(160);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2B_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2B_384:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest(384);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2B_512:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2bDigest(512);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2S_128:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest(128);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2S_160:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest(160);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2S_224:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest(224);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.BLAKE2S_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Blake2sDigest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.DSTU7564_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.DSTU7564_384:
					return new global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest(384);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.DSTU7564_512:
					return new global::Org.BouncyCastle.Crypto.Digests.Dstu7564Digest(512);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.GOST3411:
					return new global::Org.BouncyCastle.Crypto.Digests.Gost3411Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.GOST3411_2012_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_256Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.GOST3411_2012_512:
					return new global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_512Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.KECCAK_224:
					return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(224);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.KECCAK_256:
					return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.KECCAK_288:
					return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(288);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.KECCAK_384:
					return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(384);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.KECCAK_512:
					return new global::Org.BouncyCastle.Crypto.Digests.KeccakDigest(512);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.MD2:
					return new global::Org.BouncyCastle.Crypto.Digests.MD2Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.MD4:
					return new global::Org.BouncyCastle.Crypto.Digests.MD4Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.MD5:
					return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.NONE:
					return new global::Org.BouncyCastle.Crypto.Digests.NullDigest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.RIPEMD128:
					return new global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.RIPEMD160:
					return new global::Org.BouncyCastle.Crypto.Digests.RipeMD160Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.RIPEMD256:
					return new global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.RIPEMD320:
					return new global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_1:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_224:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_384:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_512:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_512_224:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest(224);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA_512_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA3_224:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha3Digest(224);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA3_256:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha3Digest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA3_384:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha3Digest(384);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHA3_512:
					return new global::Org.BouncyCastle.Crypto.Digests.Sha3Digest(512);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHAKE128_256:
					return new global::Org.BouncyCastle.Crypto.Digests.ShakeDigest(128);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SHAKE256_512:
					return new global::Org.BouncyCastle.Crypto.Digests.ShakeDigest(256);
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.SM3:
					return new global::Org.BouncyCastle.Crypto.Digests.SM3Digest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.TIGER:
					return new global::Org.BouncyCastle.Crypto.Digests.TigerDigest();
				case global::Org.BouncyCastle.Security.DigestUtilities.DigestAlgorithm.WHIRLPOOL:
					return new global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest();
				}
			}
			catch (global::System.ArgumentException)
			{
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Digest " + mechanism + " not recognised.");
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00046800 File Offset: 0x00044A00
		public static string GetAlgorithmName(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return (string)global::Org.BouncyCastle.Security.DigestUtilities.algorithms[oid.Id];
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00046817 File Offset: 0x00044A17
		public static byte[] CalculateDigest(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id, byte[] input)
		{
			return global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(id.Id, input);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00046825 File Offset: 0x00044A25
		public static byte[] CalculateDigest(string algorithm, byte[] input)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm);
			digest.BlockUpdate(input, 0, input.Length);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00046840 File Offset: 0x00044A40
		public static byte[] DoFinal(global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			byte[] b = new byte[digest.GetDigestSize()];
			digest.DoFinal(b, 0);
			return b;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00046863 File Offset: 0x00044A63
		public static byte[] DoFinal(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] input)
		{
			digest.BlockUpdate(input, 0, input.Length);
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
		}

		// Token: 0x040008CA RID: 2250
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008CB RID: 2251
		private static readonly global::System.Collections.IDictionary oids = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x020007B6 RID: 1974
		private enum DigestAlgorithm
		{
			// Token: 0x040023A3 RID: 9123
			BLAKE2B_160,
			// Token: 0x040023A4 RID: 9124
			BLAKE2B_256,
			// Token: 0x040023A5 RID: 9125
			BLAKE2B_384,
			// Token: 0x040023A6 RID: 9126
			BLAKE2B_512,
			// Token: 0x040023A7 RID: 9127
			BLAKE2S_128,
			// Token: 0x040023A8 RID: 9128
			BLAKE2S_160,
			// Token: 0x040023A9 RID: 9129
			BLAKE2S_224,
			// Token: 0x040023AA RID: 9130
			BLAKE2S_256,
			// Token: 0x040023AB RID: 9131
			DSTU7564_256,
			// Token: 0x040023AC RID: 9132
			DSTU7564_384,
			// Token: 0x040023AD RID: 9133
			DSTU7564_512,
			// Token: 0x040023AE RID: 9134
			GOST3411,
			// Token: 0x040023AF RID: 9135
			GOST3411_2012_256,
			// Token: 0x040023B0 RID: 9136
			GOST3411_2012_512,
			// Token: 0x040023B1 RID: 9137
			KECCAK_224,
			// Token: 0x040023B2 RID: 9138
			KECCAK_256,
			// Token: 0x040023B3 RID: 9139
			KECCAK_288,
			// Token: 0x040023B4 RID: 9140
			KECCAK_384,
			// Token: 0x040023B5 RID: 9141
			KECCAK_512,
			// Token: 0x040023B6 RID: 9142
			MD2,
			// Token: 0x040023B7 RID: 9143
			MD4,
			// Token: 0x040023B8 RID: 9144
			MD5,
			// Token: 0x040023B9 RID: 9145
			NONE,
			// Token: 0x040023BA RID: 9146
			RIPEMD128,
			// Token: 0x040023BB RID: 9147
			RIPEMD160,
			// Token: 0x040023BC RID: 9148
			RIPEMD256,
			// Token: 0x040023BD RID: 9149
			RIPEMD320,
			// Token: 0x040023BE RID: 9150
			SHA_1,
			// Token: 0x040023BF RID: 9151
			SHA_224,
			// Token: 0x040023C0 RID: 9152
			SHA_256,
			// Token: 0x040023C1 RID: 9153
			SHA_384,
			// Token: 0x040023C2 RID: 9154
			SHA_512,
			// Token: 0x040023C3 RID: 9155
			SHA_512_224,
			// Token: 0x040023C4 RID: 9156
			SHA_512_256,
			// Token: 0x040023C5 RID: 9157
			SHA3_224,
			// Token: 0x040023C6 RID: 9158
			SHA3_256,
			// Token: 0x040023C7 RID: 9159
			SHA3_384,
			// Token: 0x040023C8 RID: 9160
			SHA3_512,
			// Token: 0x040023C9 RID: 9161
			SHAKE128_256,
			// Token: 0x040023CA RID: 9162
			SHAKE256_512,
			// Token: 0x040023CB RID: 9163
			SM3,
			// Token: 0x040023CC RID: 9164
			TIGER,
			// Token: 0x040023CD RID: 9165
			WHIRLPOOL
		}
	}
}
