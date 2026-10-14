using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Nsri;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001CB RID: 459
	public sealed class ParameterUtilities
	{
		// Token: 0x0600110F RID: 4367 RVA: 0x000484F1 File Offset: 0x000466F1
		private ParameterUtilities()
		{
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x000484FC File Offset: 0x000466FC
		static ParameterUtilities()
		{
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("AES", new object[]
			{
				"AESWRAP"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("AES128", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("AES192", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("AES256", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("ARIA", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("ARIA128", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("ARIA192", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("ARIA256", new object[]
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
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("BLOWFISH", new object[]
			{
				"1.3.6.1.4.1.3029.1.2"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAMELLIA", new object[]
			{
				"CAMELLIAWRAP"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAMELLIA128", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Wrap
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAMELLIA192", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Wrap
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAMELLIA256", new object[]
			{
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc,
				global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Wrap
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAST5", new object[]
			{
				"1.2.840.113533.7.66.10"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CAST6", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CHACHA", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("CHACHA7539", new object[]
			{
				"CHACHA20",
				"CHACHA20-POLY1305",
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgAeadChaCha20Poly1305
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("DES", new object[]
			{
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCfb,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEcb,
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesOfb
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("DESEDE", new object[]
			{
				"DESEDEWRAP",
				"TDEA",
				global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesEde,
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCms3DesWrap
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("DESEDE3", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("GOST28147", new object[]
			{
				"GOST",
				"GOST-28147",
				global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR28147Cbc
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("HC128", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("HC256", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("IDEA", new object[]
			{
				"1.3.6.1.4.1.188.7.1.1.2"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("NOEKEON", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RC2", new object[]
			{
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc,
				global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAlgCmsRC2Wrap
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RC4", new object[]
			{
				"ARC4",
				"1.2.840.113549.3.4"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RC5", new object[]
			{
				"RC5-32"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RC5-64", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RC6", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("RIJNDAEL", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("SALSA20", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("SEED", new object[]
			{
				global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdNpkiAppCmsSeedWrap,
				global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("SERPENT", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("SKIPJACK", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("SM4", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("TEA", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("THREEFISH-256", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("THREEFISH-512", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("THREEFISH-1024", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("TNEPRES", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("TWOFISH", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("VMPC", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("VMPC-KSA3", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddAlgorithm("XTEA", new object[0]);
			global::Org.BouncyCastle.Security.ParameterUtilities.AddBasicIVSizeEntries(8, new string[]
			{
				"BLOWFISH",
				"CHACHA",
				"DES",
				"DESEDE",
				"DESEDE3",
				"SALSA20"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddBasicIVSizeEntries(12, new string[]
			{
				"CHACHA7539"
			});
			global::Org.BouncyCastle.Security.ParameterUtilities.AddBasicIVSizeEntries(16, new string[]
			{
				"AES",
				"AES128",
				"AES192",
				"AES256",
				"ARIA",
				"ARIA128",
				"ARIA192",
				"ARIA256",
				"CAMELLIA",
				"CAMELLIA128",
				"CAMELLIA192",
				"CAMELLIA256",
				"NOEKEON",
				"SEED",
				"SM4"
			});
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00048B54 File Offset: 0x00046D54
		private static void AddAlgorithm(string canonicalName, params object[] aliases)
		{
			global::Org.BouncyCastle.Security.ParameterUtilities.algorithms[canonicalName] = canonicalName;
			foreach (object alias in aliases)
			{
				global::Org.BouncyCastle.Security.ParameterUtilities.algorithms[alias.ToString()] = canonicalName;
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00048B94 File Offset: 0x00046D94
		private static void AddBasicIVSizeEntries(int size, params string[] algorithms)
		{
			foreach (string algorithm in algorithms)
			{
				global::Org.BouncyCastle.Security.ParameterUtilities.basicIVSizes.Add(algorithm, size);
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00048BC6 File Offset: 0x00046DC6
		public static string GetCanonicalAlgorithmName(string algorithm)
		{
			return (string)global::Org.BouncyCastle.Security.ParameterUtilities.algorithms[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm)];
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00048BDD File Offset: 0x00046DDD
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter CreateKeyParameter(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid, byte[] keyBytes)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algOid.Id, keyBytes, 0, keyBytes.Length);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00048BEF File Offset: 0x00046DEF
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter CreateKeyParameter(string algorithm, byte[] keyBytes)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algorithm, keyBytes, 0, keyBytes.Length);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00048BFC File Offset: 0x00046DFC
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter CreateKeyParameter(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid, byte[] keyBytes, int offset, int length)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(algOid.Id, keyBytes, offset, length);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00048C0C File Offset: 0x00046E0C
		public static global::Org.BouncyCastle.Crypto.Parameters.KeyParameter CreateKeyParameter(string algorithm, byte[] keyBytes, int offset, int length)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			string canonical = global::Org.BouncyCastle.Security.ParameterUtilities.GetCanonicalAlgorithmName(algorithm);
			if (canonical == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
			}
			if (canonical == "DES")
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.DesParameters(keyBytes, offset, length);
			}
			if (canonical == "DESEDE" || canonical == "DESEDE3")
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.DesEdeParameters(keyBytes, offset, length);
			}
			if (canonical == "RC2")
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters(keyBytes, offset, length);
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(keyBytes, offset, length);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00048C9E File Offset: 0x00046E9E
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GetCipherParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algOid, global::Org.BouncyCastle.Crypto.ICipherParameters key, global::Org.BouncyCastle.Asn1.Asn1Object asn1Params)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.GetCipherParameters(algOid.Id, key, asn1Params);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00048CB0 File Offset: 0x00046EB0
		public static global::Org.BouncyCastle.Crypto.ICipherParameters GetCipherParameters(string algorithm, global::Org.BouncyCastle.Crypto.ICipherParameters key, global::Org.BouncyCastle.Asn1.Asn1Object asn1Params)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			string canonical = global::Org.BouncyCastle.Security.ParameterUtilities.GetCanonicalAlgorithmName(algorithm);
			if (canonical == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
			}
			byte[] iv = null;
			try
			{
				if (global::Org.BouncyCastle.Security.ParameterUtilities.FindBasicIVSize(canonical) != -1 || canonical == "RIJNDAEL" || canonical == "SKIPJACK" || canonical == "TWOFISH")
				{
					iv = ((global::Org.BouncyCastle.Asn1.Asn1OctetString)asn1Params).GetOctets();
				}
				else if (canonical == "CAST5")
				{
					iv = global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters.GetInstance(asn1Params).GetIV();
				}
				else if (canonical == "IDEA")
				{
					iv = global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar.GetInstance(asn1Params).GetIV();
				}
				else if (canonical == "RC2")
				{
					iv = global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter.GetInstance(asn1Params).GetIV();
				}
			}
			catch (global::System.Exception e)
			{
				throw new global::System.ArgumentException("Could not process ASN.1 parameters", e);
			}
			if (iv != null)
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv);
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00048DBC File Offset: 0x00046FBC
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algID, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return global::Org.BouncyCastle.Security.ParameterUtilities.GenerateParameters(algID.Id, random);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00048DCC File Offset: 0x00046FCC
		public static global::Org.BouncyCastle.Asn1.Asn1Encodable GenerateParameters(string algorithm, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			string canonical = global::Org.BouncyCastle.Security.ParameterUtilities.GetCanonicalAlgorithmName(algorithm);
			if (canonical == null)
			{
				throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
			}
			int basicIVKeySize = global::Org.BouncyCastle.Security.ParameterUtilities.FindBasicIVSize(canonical);
			if (basicIVKeySize != -1)
			{
				return global::Org.BouncyCastle.Security.ParameterUtilities.CreateIVOctetString(random, basicIVKeySize);
			}
			if (canonical == "CAST5")
			{
				return new global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters(global::Org.BouncyCastle.Security.ParameterUtilities.CreateIV(random, 8), 128);
			}
			if (canonical == "IDEA")
			{
				return new global::Org.BouncyCastle.Asn1.Misc.IdeaCbcPar(global::Org.BouncyCastle.Security.ParameterUtilities.CreateIV(random, 8));
			}
			if (canonical == "RC2")
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter(global::Org.BouncyCastle.Security.ParameterUtilities.CreateIV(random, 8));
			}
			throw new global::Org.BouncyCastle.Security.SecurityUtilityException("Algorithm " + algorithm + " not recognised.");
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00048E82 File Offset: 0x00047082
		public static global::Org.BouncyCastle.Crypto.ICipherParameters WithRandom(global::Org.BouncyCastle.Crypto.ICipherParameters cp, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (random != null)
			{
				cp = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(cp, random);
			}
			return cp;
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00048E91 File Offset: 0x00047091
		private static global::Org.BouncyCastle.Asn1.Asn1OctetString CreateIVOctetString(global::Org.BouncyCastle.Security.SecureRandom random, int ivLength)
		{
			return new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Security.ParameterUtilities.CreateIV(random, ivLength));
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00048E9F File Offset: 0x0004709F
		private static byte[] CreateIV(global::Org.BouncyCastle.Security.SecureRandom random, int ivLength)
		{
			return global::Org.BouncyCastle.Security.SecureRandom.GetNextBytes(random, ivLength);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00048EA8 File Offset: 0x000470A8
		private static int FindBasicIVSize(string canonicalName)
		{
			if (!global::Org.BouncyCastle.Security.ParameterUtilities.basicIVSizes.Contains(canonicalName))
			{
				return -1;
			}
			return (int)global::Org.BouncyCastle.Security.ParameterUtilities.basicIVSizes[canonicalName];
		}

		// Token: 0x040008D0 RID: 2256
		private static readonly global::System.Collections.IDictionary algorithms = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x040008D1 RID: 2257
		private static readonly global::System.Collections.IDictionary basicIVSizes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
