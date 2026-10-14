using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004BA RID: 1210
	public class SM4Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002ED4 RID: 11988 RVA: 0x000D6A54 File Offset: 0x000D4C54
		private static uint tau(uint A)
		{
			uint num = (uint)global::Org.BouncyCastle.Crypto.Engines.SM4Engine.Sbox[(int)(A >> 24)];
			uint b = (uint)global::Org.BouncyCastle.Crypto.Engines.SM4Engine.Sbox[(int)(A >> 16 & 255U)];
			uint b2 = (uint)global::Org.BouncyCastle.Crypto.Engines.SM4Engine.Sbox[(int)(A >> 8 & 255U)];
			uint b3 = (uint)global::Org.BouncyCastle.Crypto.Engines.SM4Engine.Sbox[(int)(A & 255U)];
			return num << 24 | b << 16 | b2 << 8 | b3;
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x000D6AA8 File Offset: 0x000D4CA8
		private static uint L_ap(uint B)
		{
			return B ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 13) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 23);
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000D6ABD File Offset: 0x000D4CBD
		private uint T_ap(uint Z)
		{
			return global::Org.BouncyCastle.Crypto.Engines.SM4Engine.L_ap(global::Org.BouncyCastle.Crypto.Engines.SM4Engine.tau(Z));
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000D6ACC File Offset: 0x000D4CCC
		private void ExpandKey(bool forEncryption, byte[] key)
		{
			uint K0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 0) ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.FK[0];
			uint K = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 4) ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.FK[1];
			uint K2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 8) ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.FK[2];
			uint K3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(key, 12) ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.FK[3];
			if (forEncryption)
			{
				this.rk[0] = (K0 ^ this.T_ap(K ^ K2 ^ K3 ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[0]));
				this.rk[1] = (K ^ this.T_ap(K2 ^ K3 ^ this.rk[0] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[1]));
				this.rk[2] = (K2 ^ this.T_ap(K3 ^ this.rk[0] ^ this.rk[1] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[2]));
				this.rk[3] = (K3 ^ this.T_ap(this.rk[0] ^ this.rk[1] ^ this.rk[2] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[3]));
				for (int i = 4; i < 32; i++)
				{
					this.rk[i] = (this.rk[i - 4] ^ this.T_ap(this.rk[i - 3] ^ this.rk[i - 2] ^ this.rk[i - 1] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[i]));
				}
				return;
			}
			this.rk[31] = (K0 ^ this.T_ap(K ^ K2 ^ K3 ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[0]));
			this.rk[30] = (K ^ this.T_ap(K2 ^ K3 ^ this.rk[31] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[1]));
			this.rk[29] = (K2 ^ this.T_ap(K3 ^ this.rk[31] ^ this.rk[30] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[2]));
			this.rk[28] = (K3 ^ this.T_ap(this.rk[31] ^ this.rk[30] ^ this.rk[29] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[3]));
			for (int j = 27; j >= 0; j--)
			{
				this.rk[j] = (this.rk[j + 4] ^ this.T_ap(this.rk[j + 3] ^ this.rk[j + 2] ^ this.rk[j + 1] ^ global::Org.BouncyCastle.Crypto.Engines.SM4Engine.CK[31 - j]));
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000D6D1A File Offset: 0x000D4F1A
		private static uint L(uint B)
		{
			return B ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 2) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 10) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 18) ^ global::Org.BouncyCastle.Utilities.Integers.RotateLeft(B, 24);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000D6D40 File Offset: 0x000D4F40
		private static uint T(uint Z)
		{
			return global::Org.BouncyCastle.Crypto.Engines.SM4Engine.L(global::Org.BouncyCastle.Crypto.Engines.SM4Engine.tau(Z));
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000D6D50 File Offset: 0x000D4F50
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter keyParameter = parameters as global::Org.BouncyCastle.Crypto.Parameters.KeyParameter;
			if (keyParameter == null)
			{
				throw new global::System.ArgumentException("invalid parameter passed to SM4 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters), "parameters");
			}
			byte[] key = keyParameter.GetKey();
			if (key.Length != 16)
			{
				throw new global::System.ArgumentException("SM4 requires a 128 bit key", "parameters");
			}
			if (this.rk == null)
			{
				this.rk = new uint[32];
			}
			this.ExpandKey(forEncryption, key);
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000D6DBD File Offset: 0x000D4FBD
		public virtual string AlgorithmName
		{
			get
			{
				return "SM4";
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x000D6DC4 File Offset: 0x000D4FC4
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000D6DC7 File Offset: 0x000D4FC7
		public virtual int GetBlockSize()
		{
			return 16;
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000D6DCC File Offset: 0x000D4FCC
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.rk == null)
			{
				throw new global::System.InvalidOperationException("SM4 not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 16, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 16, "output buffer too short");
			uint X0 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			uint X = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 4);
			uint X2 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 8);
			uint X3 = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 12);
			for (int i = 0; i < 32; i += 4)
			{
				X0 ^= global::Org.BouncyCastle.Crypto.Engines.SM4Engine.T(X ^ X2 ^ X3 ^ this.rk[i]);
				X ^= global::Org.BouncyCastle.Crypto.Engines.SM4Engine.T(X2 ^ X3 ^ X0 ^ this.rk[i + 1]);
				X2 ^= global::Org.BouncyCastle.Crypto.Engines.SM4Engine.T(X3 ^ X0 ^ X ^ this.rk[i + 2]);
				X3 ^= global::Org.BouncyCastle.Crypto.Engines.SM4Engine.T(X0 ^ X ^ X2 ^ this.rk[i + 3]);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(X3, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(X2, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(X, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(X0, output, outOff + 12);
			return 16;
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x000D6ED0 File Offset: 0x000D50D0
		public virtual void Reset()
		{
		}

		// Token: 0x040013E5 RID: 5093
		private const int BlockSize = 16;

		// Token: 0x040013E6 RID: 5094
		private static readonly byte[] Sbox = new byte[]
		{
			214,
			144,
			233,
			254,
			204,
			225,
			61,
			183,
			22,
			182,
			20,
			194,
			40,
			251,
			44,
			5,
			43,
			103,
			154,
			118,
			42,
			190,
			4,
			195,
			170,
			68,
			19,
			38,
			73,
			134,
			6,
			153,
			156,
			66,
			80,
			244,
			145,
			239,
			152,
			122,
			51,
			84,
			11,
			67,
			237,
			207,
			172,
			98,
			228,
			179,
			28,
			169,
			201,
			8,
			232,
			149,
			128,
			223,
			148,
			250,
			117,
			143,
			63,
			166,
			71,
			7,
			167,
			252,
			243,
			115,
			23,
			186,
			131,
			89,
			60,
			25,
			230,
			133,
			79,
			168,
			104,
			107,
			129,
			178,
			113,
			100,
			218,
			139,
			248,
			235,
			15,
			75,
			112,
			86,
			157,
			53,
			30,
			36,
			14,
			94,
			99,
			88,
			209,
			162,
			37,
			34,
			124,
			59,
			1,
			33,
			120,
			135,
			212,
			0,
			70,
			87,
			159,
			211,
			39,
			82,
			76,
			54,
			2,
			231,
			160,
			196,
			200,
			158,
			234,
			191,
			138,
			210,
			64,
			199,
			56,
			181,
			163,
			247,
			242,
			206,
			249,
			97,
			21,
			161,
			224,
			174,
			93,
			164,
			155,
			52,
			26,
			85,
			173,
			147,
			50,
			48,
			245,
			140,
			177,
			227,
			29,
			246,
			226,
			46,
			130,
			102,
			202,
			96,
			192,
			41,
			35,
			171,
			13,
			83,
			78,
			111,
			213,
			219,
			55,
			69,
			222,
			253,
			142,
			47,
			3,
			byte.MaxValue,
			106,
			114,
			109,
			108,
			91,
			81,
			141,
			27,
			175,
			146,
			187,
			221,
			188,
			127,
			17,
			217,
			92,
			65,
			31,
			16,
			90,
			216,
			10,
			193,
			49,
			136,
			165,
			205,
			123,
			189,
			45,
			116,
			208,
			18,
			184,
			229,
			180,
			176,
			137,
			105,
			151,
			74,
			12,
			150,
			119,
			126,
			101,
			185,
			241,
			9,
			197,
			110,
			198,
			132,
			24,
			240,
			125,
			236,
			58,
			220,
			77,
			32,
			121,
			238,
			95,
			62,
			215,
			203,
			57,
			72
		};

		// Token: 0x040013E7 RID: 5095
		private static readonly uint[] CK = new uint[]
		{
			462357U,
			472066609U,
			943670861U,
			1415275113U,
			1886879365U,
			2358483617U,
			2830087869U,
			3301692121U,
			3773296373U,
			4228057617U,
			404694573U,
			876298825U,
			1347903077U,
			1819507329U,
			2291111581U,
			2762715833U,
			3234320085U,
			3705924337U,
			4177462797U,
			337322537U,
			808926789U,
			1280531041U,
			1752135293U,
			2223739545U,
			2695343797U,
			3166948049U,
			3638552301U,
			4110090761U,
			269950501U,
			741554753U,
			1213159005U,
			1684763257U
		};

		// Token: 0x040013E8 RID: 5096
		private static readonly uint[] FK = new uint[]
		{
			2746333894U,
			1453994832U,
			1736282519U,
			2993693404U
		};

		// Token: 0x040013E9 RID: 5097
		private uint[] rk;
	}
}
