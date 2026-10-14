using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200048E RID: 1166
	public class AriaEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002CBC RID: 11452 RVA: 0x000C4268 File Offset: 0x000C2468
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter = parameters as global::Org.BouncyCastle.Crypto.Parameters.KeyParameter;
			if (keyParameter == null)
			{
				throw new global::System.ArgumentException("invalid parameter passed to ARIA init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.m_roundKeys = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeySchedule(forEncryption, keyParameter.GetKey());
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000C42A7 File Offset: 0x000C24A7
		public virtual string AlgorithmName
		{
			get
			{
				return "ARIA";
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000C42AE File Offset: 0x000C24AE
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x000C42B1 File Offset: 0x000C24B1
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x000C42B8 File Offset: 0x000C24B8
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.m_roundKeys == null)
			{
				throw new global::System.InvalidOperationException("ARIA engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			byte[] z = new byte[16];
			global::System.Array.Copy(input, inOff, z, 0, 16);
			int i = 0;
			int rounds = this.m_roundKeys.Length - 3;
			while (i < rounds)
			{
				global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FO(z, this.m_roundKeys[i++]);
				global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FE(z, this.m_roundKeys[i++]);
			}
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FO(z, this.m_roundKeys[i++]);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(z, this.m_roundKeys[i++]);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SL2(z);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(z, this.m_roundKeys[i]);
			global::System.Array.Copy(z, 0, output, outOff, 16);
			return 16;
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x000C4385 File Offset: 0x000C2585
		public virtual void Reset()
		{
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x000C4388 File Offset: 0x000C2588
		protected static void A(byte[] z)
		{
			byte x0 = z[0];
			byte x = z[1];
			byte x2 = z[2];
			byte x3 = z[3];
			byte x4 = z[4];
			byte x5 = z[5];
			byte x6 = z[6];
			byte x7 = z[7];
			byte x8 = z[8];
			byte x9 = z[9];
			byte x10 = z[10];
			byte x11 = z[11];
			byte x12 = z[12];
			byte x13 = z[13];
			byte x14 = z[14];
			byte x15 = z[15];
			z[0] = (x3 ^ x4 ^ x6 ^ x8 ^ x9 ^ x13 ^ x14);
			z[1] = (x2 ^ x5 ^ x7 ^ x8 ^ x9 ^ x12 ^ x15);
			z[2] = (x ^ x4 ^ x6 ^ x10 ^ x11 ^ x12 ^ x15);
			z[3] = (x0 ^ x5 ^ x7 ^ x10 ^ x11 ^ x13 ^ x14);
			z[4] = (x0 ^ x2 ^ x5 ^ x8 ^ x11 ^ x14 ^ x15);
			z[5] = (x ^ x3 ^ x4 ^ x9 ^ x10 ^ x14 ^ x15);
			z[6] = (x0 ^ x2 ^ x7 ^ x9 ^ x10 ^ x12 ^ x13);
			z[7] = (x ^ x3 ^ x6 ^ x8 ^ x11 ^ x12 ^ x13);
			z[8] = (x0 ^ x ^ x4 ^ x7 ^ x10 ^ x13 ^ x15);
			z[9] = (x0 ^ x ^ x5 ^ x6 ^ x11 ^ x12 ^ x14);
			z[10] = (x2 ^ x3 ^ x5 ^ x6 ^ x8 ^ x13 ^ x15);
			z[11] = (x2 ^ x3 ^ x4 ^ x7 ^ x9 ^ x12 ^ x14);
			z[12] = (x ^ x2 ^ x6 ^ x7 ^ x9 ^ x11 ^ x12);
			z[13] = (x0 ^ x3 ^ x6 ^ x7 ^ x8 ^ x10 ^ x13);
			z[14] = (x0 ^ x3 ^ x4 ^ x5 ^ x9 ^ x11 ^ x14);
			z[15] = (x ^ x2 ^ x4 ^ x5 ^ x8 ^ x10 ^ x15);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000C4553 File Offset: 0x000C2753
		protected static void FE(byte[] D, byte[] RK)
		{
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(D, RK);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SL2(D);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.A(D);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000C4568 File Offset: 0x000C2768
		protected static void FO(byte[] D, byte[] RK)
		{
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(D, RK);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SL1(D);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.A(D);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000C4580 File Offset: 0x000C2780
		protected static byte[][] KeySchedule(bool forEncryption, byte[] K)
		{
			int keyLen = K.Length;
			if (keyLen < 16 || keyLen > 32 || (keyLen & 7) != 0)
			{
				throw new global::System.ArgumentException("Key length not 128/192/256 bits.");
			}
			int keyLenIdx = (keyLen >> 3) - 2;
			byte[] CK = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.C[keyLenIdx];
			byte[] CK2 = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.C[(keyLenIdx + 1) % 3];
			byte[] CK3 = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.C[(keyLenIdx + 2) % 3];
			byte[] KL = new byte[16];
			byte[] KR = new byte[16];
			global::System.Array.Copy(K, 0, KL, 0, 16);
			global::System.Array.Copy(K, 16, KR, 0, keyLen - 16);
			byte[] W0 = new byte[16];
			byte[] W = new byte[16];
			byte[] W2 = new byte[16];
			byte[] W3 = new byte[16];
			global::System.Array.Copy(KL, 0, W0, 0, 16);
			global::System.Array.Copy(W0, 0, W, 0, 16);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FO(W, CK);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(W, KR);
			global::System.Array.Copy(W, 0, W2, 0, 16);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FE(W2, CK2);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(W2, W0);
			global::System.Array.Copy(W2, 0, W3, 0, 16);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.FO(W3, CK3);
			global::Org.BouncyCastle.Crypto.Engines.AriaEngine.Xor(W3, W);
			int numRounds = 12 + keyLenIdx * 2;
			byte[][] rks = new byte[numRounds + 1][];
			rks[0] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W0, W, 19);
			rks[1] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W, W2, 19);
			rks[2] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W2, W3, 19);
			rks[3] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W3, W0, 19);
			rks[4] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W0, W, 31);
			rks[5] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W, W2, 31);
			rks[6] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W2, W3, 31);
			rks[7] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W3, W0, 31);
			rks[8] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W0, W, 67);
			rks[9] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W, W2, 67);
			rks[10] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W2, W3, 67);
			rks[11] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W3, W0, 67);
			rks[12] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W0, W, 97);
			if (numRounds > 12)
			{
				rks[13] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W, W2, 97);
				rks[14] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W2, W3, 97);
				if (numRounds > 14)
				{
					rks[15] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W3, W0, 97);
					rks[16] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.KeyScheduleRound(W0, W, 109);
				}
			}
			if (!forEncryption)
			{
				global::Org.BouncyCastle.Crypto.Engines.AriaEngine.ReverseKeys(rks);
				for (int i = 1; i < numRounds; i++)
				{
					global::Org.BouncyCastle.Crypto.Engines.AriaEngine.A(rks[i]);
				}
			}
			return rks;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000C47D8 File Offset: 0x000C29D8
		protected static byte[] KeyScheduleRound(byte[] w, byte[] wr, int n)
		{
			byte[] rk = new byte[16];
			int off = n >> 3;
			int right = n & 7;
			int left = 8 - right;
			int hi = (int)(wr[15 - off] & byte.MaxValue);
			for (int to = 0; to < 16; to++)
			{
				int lo = (int)(wr[to - off & 15] & byte.MaxValue);
				int b = hi << left | lo >> right;
				b ^= (int)(w[to] & byte.MaxValue);
				rk[to] = (byte)b;
				hi = lo;
			}
			return rk;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000C4858 File Offset: 0x000C2A58
		protected static void ReverseKeys(byte[][] keys)
		{
			int num = keys.Length;
			int limit = num / 2;
			int last = num - 1;
			for (int i = 0; i < limit; i++)
			{
				byte[] t = keys[i];
				keys[i] = keys[last - i];
				keys[last - i] = t;
			}
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000C488D File Offset: 0x000C2A8D
		protected static byte SB1(byte x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1_sbox[(int)(x & byte.MaxValue)];
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000C489C File Offset: 0x000C2A9C
		protected static byte SB2(byte x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2_sbox[(int)(x & byte.MaxValue)];
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000C48AB File Offset: 0x000C2AAB
		protected static byte SB3(byte x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3_sbox[(int)(x & byte.MaxValue)];
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000C48BA File Offset: 0x000C2ABA
		protected static byte SB4(byte x)
		{
			return global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4_sbox[(int)(x & byte.MaxValue)];
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000C48CC File Offset: 0x000C2ACC
		protected static void SL1(byte[] z)
		{
			z[0] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[0]);
			z[1] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[1]);
			z[2] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[2]);
			z[3] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[3]);
			z[4] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[4]);
			z[5] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[5]);
			z[6] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[6]);
			z[7] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[7]);
			z[8] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[8]);
			z[9] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[9]);
			z[10] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[10]);
			z[11] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[11]);
			z[12] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[12]);
			z[13] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[13]);
			z[14] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[14]);
			z[15] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[15]);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000C4998 File Offset: 0x000C2B98
		protected static void SL2(byte[] z)
		{
			z[0] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[0]);
			z[1] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[1]);
			z[2] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[2]);
			z[3] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[3]);
			z[4] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[4]);
			z[5] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[5]);
			z[6] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[6]);
			z[7] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[7]);
			z[8] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[8]);
			z[9] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[9]);
			z[10] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[10]);
			z[11] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[11]);
			z[12] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB3(z[12]);
			z[13] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB4(z[13]);
			z[14] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB1(z[14]);
			z[15] = global::Org.BouncyCastle.Crypto.Engines.AriaEngine.SB2(z[15]);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000C4A64 File Offset: 0x000C2C64
		protected static void Xor(byte[] z, byte[] x)
		{
			for (int i = 0; i < 16; i++)
			{
				int num = i;
				z[num] ^= x[i];
			}
		}

		// Token: 0x040012B2 RID: 4786
		private static readonly byte[][] C = new byte[][]
		{
			global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("517cc1b727220a94fe13abe8fa9a6ee0"),
			global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("6db14acc9e21c820ff28b1d5ef5de2b0"),
			global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("db92371d2126e9700324977504e8c90e")
		};

		// Token: 0x040012B3 RID: 4787
		private static readonly byte[] SB1_sbox = new byte[]
		{
			99,
			124,
			119,
			123,
			242,
			107,
			111,
			197,
			48,
			1,
			103,
			43,
			254,
			215,
			171,
			118,
			202,
			130,
			201,
			125,
			250,
			89,
			71,
			240,
			173,
			212,
			162,
			175,
			156,
			164,
			114,
			192,
			183,
			253,
			147,
			38,
			54,
			63,
			247,
			204,
			52,
			165,
			229,
			241,
			113,
			216,
			49,
			21,
			4,
			199,
			35,
			195,
			24,
			150,
			5,
			154,
			7,
			18,
			128,
			226,
			235,
			39,
			178,
			117,
			9,
			131,
			44,
			26,
			27,
			110,
			90,
			160,
			82,
			59,
			214,
			179,
			41,
			227,
			47,
			132,
			83,
			209,
			0,
			237,
			32,
			252,
			177,
			91,
			106,
			203,
			190,
			57,
			74,
			76,
			88,
			207,
			208,
			239,
			170,
			251,
			67,
			77,
			51,
			133,
			69,
			249,
			2,
			127,
			80,
			60,
			159,
			168,
			81,
			163,
			64,
			143,
			146,
			157,
			56,
			245,
			188,
			182,
			218,
			33,
			16,
			byte.MaxValue,
			243,
			210,
			205,
			12,
			19,
			236,
			95,
			151,
			68,
			23,
			196,
			167,
			126,
			61,
			100,
			93,
			25,
			115,
			96,
			129,
			79,
			220,
			34,
			42,
			144,
			136,
			70,
			238,
			184,
			20,
			222,
			94,
			11,
			219,
			224,
			50,
			58,
			10,
			73,
			6,
			36,
			92,
			194,
			211,
			172,
			98,
			145,
			149,
			228,
			121,
			231,
			200,
			55,
			109,
			141,
			213,
			78,
			169,
			108,
			86,
			244,
			234,
			101,
			122,
			174,
			8,
			186,
			120,
			37,
			46,
			28,
			166,
			180,
			198,
			232,
			221,
			116,
			31,
			75,
			189,
			139,
			138,
			112,
			62,
			181,
			102,
			72,
			3,
			246,
			14,
			97,
			53,
			87,
			185,
			134,
			193,
			29,
			158,
			225,
			248,
			152,
			17,
			105,
			217,
			142,
			148,
			155,
			30,
			135,
			233,
			206,
			85,
			40,
			223,
			140,
			161,
			137,
			13,
			191,
			230,
			66,
			104,
			65,
			153,
			45,
			15,
			176,
			84,
			187,
			22
		};

		// Token: 0x040012B4 RID: 4788
		private static readonly byte[] SB2_sbox = new byte[]
		{
			226,
			78,
			84,
			252,
			148,
			194,
			74,
			204,
			98,
			13,
			106,
			70,
			60,
			77,
			139,
			209,
			94,
			250,
			100,
			203,
			180,
			151,
			190,
			43,
			188,
			119,
			46,
			3,
			211,
			25,
			89,
			193,
			29,
			6,
			65,
			107,
			85,
			240,
			153,
			105,
			234,
			156,
			24,
			174,
			99,
			223,
			231,
			187,
			0,
			115,
			102,
			251,
			150,
			76,
			133,
			228,
			58,
			9,
			69,
			170,
			15,
			238,
			16,
			235,
			45,
			127,
			244,
			41,
			172,
			207,
			173,
			145,
			141,
			120,
			200,
			149,
			249,
			47,
			206,
			205,
			8,
			122,
			136,
			56,
			92,
			131,
			42,
			40,
			71,
			219,
			184,
			199,
			147,
			164,
			18,
			83,
			byte.MaxValue,
			135,
			14,
			49,
			54,
			33,
			88,
			72,
			1,
			142,
			55,
			116,
			50,
			202,
			233,
			177,
			183,
			171,
			12,
			215,
			196,
			86,
			66,
			38,
			7,
			152,
			96,
			217,
			182,
			185,
			17,
			64,
			236,
			32,
			140,
			189,
			160,
			201,
			132,
			4,
			73,
			35,
			241,
			79,
			80,
			31,
			19,
			220,
			216,
			192,
			158,
			87,
			227,
			195,
			123,
			101,
			59,
			2,
			143,
			62,
			232,
			37,
			146,
			229,
			21,
			221,
			253,
			23,
			169,
			191,
			212,
			154,
			126,
			197,
			57,
			103,
			254,
			118,
			157,
			67,
			167,
			225,
			208,
			245,
			104,
			242,
			27,
			52,
			112,
			5,
			163,
			138,
			213,
			121,
			134,
			168,
			48,
			198,
			81,
			75,
			30,
			166,
			39,
			246,
			53,
			210,
			110,
			36,
			22,
			130,
			95,
			218,
			230,
			117,
			162,
			239,
			44,
			178,
			28,
			159,
			93,
			111,
			128,
			10,
			114,
			68,
			155,
			108,
			144,
			11,
			91,
			51,
			125,
			90,
			82,
			243,
			97,
			161,
			247,
			176,
			214,
			63,
			124,
			109,
			237,
			20,
			224,
			165,
			61,
			34,
			179,
			248,
			137,
			222,
			113,
			26,
			175,
			186,
			181,
			129
		};

		// Token: 0x040012B5 RID: 4789
		private static readonly byte[] SB3_sbox = new byte[]
		{
			82,
			9,
			106,
			213,
			48,
			54,
			165,
			56,
			191,
			64,
			163,
			158,
			129,
			243,
			215,
			251,
			124,
			227,
			57,
			130,
			155,
			47,
			byte.MaxValue,
			135,
			52,
			142,
			67,
			68,
			196,
			222,
			233,
			203,
			84,
			123,
			148,
			50,
			166,
			194,
			35,
			61,
			238,
			76,
			149,
			11,
			66,
			250,
			195,
			78,
			8,
			46,
			161,
			102,
			40,
			217,
			36,
			178,
			118,
			91,
			162,
			73,
			109,
			139,
			209,
			37,
			114,
			248,
			246,
			100,
			134,
			104,
			152,
			22,
			212,
			164,
			92,
			204,
			93,
			101,
			182,
			146,
			108,
			112,
			72,
			80,
			253,
			237,
			185,
			218,
			94,
			21,
			70,
			87,
			167,
			141,
			157,
			132,
			144,
			216,
			171,
			0,
			140,
			188,
			211,
			10,
			247,
			228,
			88,
			5,
			184,
			179,
			69,
			6,
			208,
			44,
			30,
			143,
			202,
			63,
			15,
			2,
			193,
			175,
			189,
			3,
			1,
			19,
			138,
			107,
			58,
			145,
			17,
			65,
			79,
			103,
			220,
			234,
			151,
			242,
			207,
			206,
			240,
			180,
			230,
			115,
			150,
			172,
			116,
			34,
			231,
			173,
			53,
			133,
			226,
			249,
			55,
			232,
			28,
			117,
			223,
			110,
			71,
			241,
			26,
			113,
			29,
			41,
			197,
			137,
			111,
			183,
			98,
			14,
			170,
			24,
			190,
			27,
			252,
			86,
			62,
			75,
			198,
			210,
			121,
			32,
			154,
			219,
			192,
			254,
			120,
			205,
			90,
			244,
			31,
			221,
			168,
			51,
			136,
			7,
			199,
			49,
			177,
			18,
			16,
			89,
			39,
			128,
			236,
			95,
			96,
			81,
			127,
			169,
			25,
			181,
			74,
			13,
			45,
			229,
			122,
			159,
			147,
			201,
			156,
			239,
			160,
			224,
			59,
			77,
			174,
			42,
			245,
			176,
			200,
			235,
			187,
			60,
			131,
			83,
			153,
			97,
			23,
			43,
			4,
			126,
			186,
			119,
			214,
			38,
			225,
			105,
			20,
			99,
			85,
			33,
			12,
			125
		};

		// Token: 0x040012B6 RID: 4790
		private static readonly byte[] SB4_sbox = new byte[]
		{
			48,
			104,
			153,
			27,
			135,
			185,
			33,
			120,
			80,
			57,
			219,
			225,
			114,
			9,
			98,
			60,
			62,
			126,
			94,
			142,
			241,
			160,
			204,
			163,
			42,
			29,
			251,
			182,
			214,
			32,
			196,
			141,
			129,
			101,
			245,
			137,
			203,
			157,
			119,
			198,
			87,
			67,
			86,
			23,
			212,
			64,
			26,
			77,
			192,
			99,
			108,
			227,
			183,
			200,
			100,
			106,
			83,
			170,
			56,
			152,
			12,
			244,
			155,
			237,
			127,
			34,
			118,
			175,
			221,
			58,
			11,
			88,
			103,
			136,
			6,
			195,
			53,
			13,
			1,
			139,
			140,
			194,
			230,
			95,
			2,
			36,
			117,
			147,
			102,
			30,
			229,
			226,
			84,
			216,
			16,
			206,
			122,
			232,
			8,
			44,
			18,
			151,
			50,
			171,
			180,
			39,
			10,
			35,
			223,
			239,
			202,
			217,
			184,
			250,
			220,
			49,
			107,
			209,
			173,
			25,
			73,
			189,
			81,
			150,
			238,
			228,
			168,
			65,
			218,
			byte.MaxValue,
			205,
			85,
			134,
			54,
			190,
			97,
			82,
			248,
			187,
			14,
			130,
			72,
			105,
			154,
			224,
			71,
			158,
			92,
			4,
			75,
			52,
			21,
			121,
			38,
			167,
			222,
			41,
			174,
			146,
			215,
			132,
			233,
			210,
			186,
			93,
			243,
			197,
			176,
			191,
			164,
			59,
			113,
			68,
			70,
			43,
			252,
			235,
			111,
			213,
			246,
			20,
			254,
			124,
			112,
			90,
			125,
			253,
			47,
			24,
			131,
			22,
			165,
			145,
			31,
			5,
			149,
			116,
			169,
			193,
			91,
			74,
			133,
			109,
			19,
			7,
			79,
			78,
			69,
			178,
			15,
			201,
			28,
			166,
			188,
			236,
			115,
			144,
			123,
			207,
			89,
			143,
			161,
			249,
			45,
			242,
			177,
			0,
			148,
			55,
			159,
			208,
			46,
			156,
			110,
			40,
			63,
			128,
			240,
			61,
			211,
			37,
			138,
			181,
			231,
			66,
			179,
			199,
			234,
			247,
			76,
			17,
			51,
			3,
			162,
			172,
			96
		};

		// Token: 0x040012B7 RID: 4791
		protected const int BlockSize = 16;

		// Token: 0x040012B8 RID: 4792
		private byte[][] m_roundKeys;
	}
}
