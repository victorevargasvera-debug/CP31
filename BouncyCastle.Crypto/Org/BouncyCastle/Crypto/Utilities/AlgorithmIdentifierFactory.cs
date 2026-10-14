using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Kisa;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Ntt;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Utilities
{
	// Token: 0x020002ED RID: 749
	public class AlgorithmIdentifierFactory
	{
		// Token: 0x06002004 RID: 8196 RVA: 0x000903B4 File Offset: 0x0008E5B4
		public static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GenerateEncryptionAlgID(global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionOID, int keySize, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes128Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes192Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdAes256Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia128Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia192Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Ntt.NttObjectIdentifiers.IdCamellia256Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Kisa.KisaObjectIdentifiers.IdSeedCbc))
			{
				byte[] iv = new byte[16];
				random.NextBytes(iv);
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encryptionOID, new global::Org.BouncyCastle.Asn1.DerOctetString(iv));
			}
			if (encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc) || encryptionOID.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.IDEA_CBC) || encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.DesCbc))
			{
				byte[] iv2 = new byte[8];
				random.NextBytes(iv2);
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encryptionOID, new global::Org.BouncyCastle.Asn1.DerOctetString(iv2));
			}
			if (encryptionOID.Equals(global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.CAST5_CBC))
			{
				byte[] iv3 = new byte[8];
				random.NextBytes(iv3);
				global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters cbcParams = new global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters(iv3, keySize);
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encryptionOID, cbcParams);
			}
			if (encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.rc4))
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encryptionOID, global::Org.BouncyCastle.Asn1.DerNull.Instance);
			}
			if (encryptionOID.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.RC2Cbc))
			{
				byte[] iv4 = new byte[8];
				random.NextBytes(iv4);
				global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter cbcParams2 = new global::Org.BouncyCastle.Asn1.Pkcs.RC2CbcParameter((int)global::Org.BouncyCastle.Crypto.Utilities.AlgorithmIdentifierFactory.rc2Table[128], iv4);
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(encryptionOID, cbcParams2);
			}
			throw new global::System.InvalidOperationException("unable to match algorithm");
		}

		// Token: 0x04000B37 RID: 2871
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IDEA_CBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.4.1.188.7.1.1.2");

		// Token: 0x04000B38 RID: 2872
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier CAST5_CBC = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.2.840.113533.7.66.10");

		// Token: 0x04000B39 RID: 2873
		private static readonly short[] rc2Table = new short[]
		{
			189,
			86,
			234,
			242,
			162,
			241,
			172,
			42,
			176,
			147,
			209,
			156,
			27,
			51,
			253,
			208,
			48,
			4,
			182,
			220,
			125,
			223,
			50,
			75,
			247,
			203,
			69,
			155,
			49,
			187,
			33,
			90,
			65,
			159,
			225,
			217,
			74,
			77,
			158,
			218,
			160,
			104,
			44,
			195,
			39,
			95,
			128,
			54,
			62,
			238,
			251,
			149,
			26,
			254,
			206,
			168,
			52,
			169,
			19,
			240,
			166,
			63,
			216,
			12,
			120,
			36,
			175,
			35,
			82,
			193,
			103,
			23,
			245,
			102,
			144,
			231,
			232,
			7,
			184,
			96,
			72,
			230,
			30,
			83,
			243,
			146,
			164,
			114,
			140,
			8,
			21,
			110,
			134,
			0,
			132,
			250,
			244,
			127,
			138,
			66,
			25,
			246,
			219,
			205,
			20,
			141,
			80,
			18,
			186,
			60,
			6,
			78,
			236,
			179,
			53,
			17,
			161,
			136,
			142,
			43,
			148,
			153,
			183,
			113,
			116,
			211,
			228,
			191,
			58,
			222,
			150,
			14,
			188,
			10,
			237,
			119,
			252,
			55,
			107,
			3,
			121,
			137,
			98,
			198,
			215,
			192,
			210,
			124,
			106,
			139,
			34,
			163,
			91,
			5,
			93,
			2,
			117,
			213,
			97,
			227,
			24,
			143,
			85,
			81,
			173,
			31,
			11,
			94,
			133,
			229,
			194,
			87,
			99,
			202,
			61,
			108,
			180,
			197,
			204,
			112,
			178,
			145,
			89,
			13,
			71,
			32,
			200,
			79,
			88,
			224,
			1,
			226,
			22,
			56,
			196,
			111,
			59,
			15,
			101,
			70,
			190,
			126,
			45,
			123,
			130,
			249,
			64,
			181,
			29,
			115,
			248,
			235,
			38,
			199,
			135,
			151,
			37,
			84,
			177,
			40,
			170,
			152,
			157,
			165,
			100,
			109,
			122,
			212,
			16,
			129,
			68,
			239,
			73,
			214,
			174,
			46,
			221,
			118,
			92,
			47,
			167,
			28,
			201,
			9,
			105,
			154,
			131,
			207,
			41,
			57,
			185,
			233,
			76,
			255,
			67,
			171
		};
	}
}
