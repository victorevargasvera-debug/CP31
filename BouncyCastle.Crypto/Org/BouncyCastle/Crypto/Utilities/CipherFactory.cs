using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Utilities
{
	// Token: 0x020002EF RID: 751
	public class CipherFactory
	{
		// Token: 0x0600200C RID: 8204 RVA: 0x0009075A File Offset: 0x0008E95A
		private CipherFactory()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00090764 File Offset: 0x0008E964
		public static object CreateContentCipher(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters encKey, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encryptionAlgID)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier encAlg = encryptionAlgID.Algorithm;
			if (encAlg.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.rc4))
			{
				global::Org.BouncyCastle.Crypto.Engines.RC4Engine rc4Engine = new global::Org.BouncyCastle.Crypto.Engines.RC4Engine();
				((global::Org.BouncyCastle.Crypto.IStreamCipher)rc4Engine).Init(forEncryption, encKey);
				return rc4Engine;
			}
			global::Org.BouncyCastle.Crypto.BufferedBlockCipher cipher = global::Org.BouncyCastle.Crypto.Utilities.CipherFactory.CreateCipher(encryptionAlgID.Algorithm);
			global::Org.BouncyCastle.Asn1.Asn1Object sParams = encryptionAlgID.Parameters.ToAsn1Object();
			if (sParams != null && !(sParams is global::Org.BouncyCastle.Asn1.DerNull))
			{
				if (encAlg.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc) || encAlg.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.IDEA_CBC) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc) || encAlg.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc))
				{
					cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(encKey, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(sParams).GetOctets()));
				}
				else if (encAlg.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.CAST5_CBC))
				{
					global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters cbcParams = global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters.GetInstance(sParams);
					cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(encKey, cbcParams.GetIV()));
				}
				else
				{
					if (!encAlg.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc))
					{
						throw new global::System.InvalidOperationException("cannot match parameters");
					}
					global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter cbcParams2 = global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter.GetInstance(sParams);
					cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(new global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)encKey).GetKey(), (int)global::Org.BouncyCastle.Crypto.Utilities.CipherFactory.rc2Ekb[cbcParams2.RC2ParameterVersion.IntValue]), cbcParams2.GetIV()));
				}
			}
			else if (encAlg.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc) || encAlg.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.IDEA_CBC) || encAlg.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.CAST5_CBC))
			{
				cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(encKey, new byte[8]));
			}
			else
			{
				cipher.Init(forEncryption, encKey);
			}
			return cipher;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00090924 File Offset: 0x0008EB24
		private static global::Org.BouncyCastle.Crypto.BufferedBlockCipher CreateCipher(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm)
		{
			global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
			if (global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc.Equals(algorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc.Equals(algorithm) || global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc.Equals(algorithm))
			{
				cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.AesEngine());
			}
			else if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Equals(algorithm))
			{
				cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
			}
			else if (global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc.Equals(algorithm))
			{
				cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEngine());
			}
			else if (global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc.Equals(algorithm))
			{
				cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.RC2Engine());
			}
			else
			{
				if (!global::Org.BouncyCastle.Asn1.Misc.MiscObjectIdentifiers.cast5CBC.Equals(algorithm))
				{
					throw new global::System.InvalidOperationException("cannot recognise cipher: " + ((algorithm != null) ? algorithm.ToString() : null));
				}
				cipher = new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.Cast5Engine());
			}
			return new global::Org.BouncyCastle.Crypto.Paddings.PaddedBufferedBlockCipher(cipher, new global::Org.BouncyCastle.Crypto.Paddings.Pkcs7Padding());
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly short[] rc2Ekb = new short[]
		{
			93,
			190,
			155,
			139,
			17,
			153,
			110,
			77,
			89,
			243,
			133,
			166,
			63,
			183,
			131,
			197,
			228,
			115,
			107,
			58,
			104,
			90,
			192,
			71,
			160,
			100,
			52,
			12,
			241,
			208,
			82,
			165,
			185,
			30,
			150,
			67,
			65,
			216,
			212,
			44,
			219,
			248,
			7,
			119,
			42,
			202,
			235,
			239,
			16,
			28,
			22,
			13,
			56,
			114,
			47,
			137,
			193,
			249,
			128,
			196,
			109,
			174,
			48,
			61,
			206,
			32,
			99,
			254,
			230,
			26,
			199,
			184,
			80,
			232,
			36,
			23,
			252,
			37,
			111,
			187,
			106,
			163,
			68,
			83,
			217,
			162,
			1,
			171,
			188,
			182,
			31,
			152,
			238,
			154,
			167,
			45,
			79,
			158,
			142,
			172,
			224,
			198,
			73,
			70,
			41,
			244,
			148,
			138,
			175,
			225,
			91,
			195,
			179,
			123,
			87,
			209,
			124,
			156,
			237,
			135,
			64,
			140,
			226,
			203,
			147,
			20,
			201,
			97,
			46,
			229,
			204,
			246,
			94,
			168,
			92,
			214,
			117,
			141,
			98,
			149,
			88,
			105,
			118,
			161,
			74,
			181,
			85,
			9,
			120,
			51,
			130,
			215,
			221,
			121,
			245,
			27,
			11,
			222,
			38,
			33,
			40,
			116,
			4,
			151,
			86,
			223,
			60,
			240,
			55,
			57,
			220,
			255,
			6,
			164,
			234,
			66,
			8,
			218,
			180,
			113,
			176,
			207,
			18,
			122,
			78,
			250,
			108,
			29,
			132,
			0,
			200,
			127,
			145,
			69,
			170,
			43,
			194,
			177,
			143,
			213,
			186,
			242,
			173,
			25,
			178,
			103,
			54,
			247,
			15,
			10,
			146,
			125,
			227,
			157,
			233,
			144,
			62,
			35,
			39,
			102,
			19,
			236,
			129,
			21,
			189,
			34,
			191,
			159,
			126,
			169,
			81,
			75,
			76,
			251,
			2,
			211,
			112,
			134,
			49,
			231,
			59,
			5,
			3,
			84,
			96,
			72,
			101,
			24,
			210,
			205,
			95,
			50,
			136,
			14,
			53,
			253
		};
	}
}
