using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B8 RID: 1208
	public class SkipjackEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002EBC RID: 11964 RVA: 0x000D6138 File Offset: 0x000D4338
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to SKIPJACK init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			byte[] keyBytes = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
			this.encrypting = forEncryption;
			this.key0 = new int[32];
			this.key1 = new int[32];
			this.key2 = new int[32];
			this.key3 = new int[32];
			for (int i = 0; i < 32; i++)
			{
				this.key0[i] = (int)(keyBytes[i * 4 % 10] & byte.MaxValue);
				this.key1[i] = (int)(keyBytes[(i * 4 + 1) % 10] & byte.MaxValue);
				this.key2[i] = (int)(keyBytes[(i * 4 + 2) % 10] & byte.MaxValue);
				this.key3[i] = (int)(keyBytes[(i * 4 + 3) % 10] & byte.MaxValue);
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x000D6215 File Offset: 0x000D4415
		public virtual string AlgorithmName
		{
			get
			{
				return "SKIPJACK";
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x000D621C File Offset: 0x000D441C
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000D621F File Offset: 0x000D441F
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x000D6224 File Offset: 0x000D4424
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.key1 == null)
			{
				throw new global::System.InvalidOperationException("SKIPJACK engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 8, "output buffer too short");
			if (this.encrypting)
			{
				this.EncryptBlock(input, inOff, output, outOff);
			}
			else
			{
				this.DecryptBlock(input, inOff, output, outOff);
			}
			return 8;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x000D6282 File Offset: 0x000D4482
		public virtual void Reset()
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000D6284 File Offset: 0x000D4484
		private int G(int k, int w)
		{
			int g = w >> 8 & 255;
			int g2 = w & 255;
			int g3 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[g2 ^ this.key0[k]] ^ g;
			int g4 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[g3 ^ this.key1[k]] ^ g2;
			int g5 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[g4 ^ this.key2[k]] ^ g3;
			int g6 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[g5 ^ this.key3[k]] ^ g4;
			return (g5 << 8) + g6;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000D62FC File Offset: 0x000D44FC
		public virtual int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int w = ((int)input[inOff] << 8) + (int)(input[inOff + 1] & byte.MaxValue);
			int w2 = ((int)input[inOff + 2] << 8) + (int)(input[inOff + 3] & byte.MaxValue);
			int w3 = ((int)input[inOff + 4] << 8) + (int)(input[inOff + 5] & byte.MaxValue);
			int w4 = ((int)input[inOff + 6] << 8) + (int)(input[inOff + 7] & byte.MaxValue);
			int i = 0;
			for (int t = 0; t < 2; t++)
			{
				for (int j = 0; j < 8; j++)
				{
					int tmp = w4;
					w4 = w3;
					w3 = w2;
					w2 = this.G(i, w);
					w = (w2 ^ tmp ^ i + 1);
					i++;
				}
				for (int k = 0; k < 8; k++)
				{
					int num = w4;
					w4 = w3;
					w3 = (w ^ w2 ^ i + 1);
					w2 = this.G(i, w);
					w = num;
					i++;
				}
			}
			outBytes[outOff] = (byte)(w >> 8);
			outBytes[outOff + 1] = (byte)w;
			outBytes[outOff + 2] = (byte)(w2 >> 8);
			outBytes[outOff + 3] = (byte)w2;
			outBytes[outOff + 4] = (byte)(w3 >> 8);
			outBytes[outOff + 5] = (byte)w3;
			outBytes[outOff + 6] = (byte)(w4 >> 8);
			outBytes[outOff + 7] = (byte)w4;
			return 8;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000D6410 File Offset: 0x000D4610
		private int H(int k, int w)
		{
			int h = w & 255;
			int h2 = w >> 8 & 255;
			int h3 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[h2 ^ this.key3[k]] ^ h;
			int h4 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[h3 ^ this.key2[k]] ^ h2;
			int h5 = (int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[h4 ^ this.key1[k]] ^ h3;
			return (((int)global::Org.BouncyCastle.Crypto.Engines.SkipjackEngine.ftable[h5 ^ this.key0[k]] ^ h4) << 8) + h5;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000D6484 File Offset: 0x000D4684
		public virtual int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int w2 = ((int)input[inOff] << 8) + (int)(input[inOff + 1] & byte.MaxValue);
			int w3 = ((int)input[inOff + 2] << 8) + (int)(input[inOff + 3] & byte.MaxValue);
			int w4 = ((int)input[inOff + 4] << 8) + (int)(input[inOff + 5] & byte.MaxValue);
			int w5 = ((int)input[inOff + 6] << 8) + (int)(input[inOff + 7] & byte.MaxValue);
			int i = 31;
			for (int t = 0; t < 2; t++)
			{
				for (int j = 0; j < 8; j++)
				{
					int tmp = w4;
					w4 = w5;
					w5 = w2;
					w2 = this.H(i, w3);
					w3 = (w2 ^ tmp ^ i + 1);
					i--;
				}
				for (int k = 0; k < 8; k++)
				{
					int num = w4;
					w4 = w5;
					w5 = (w3 ^ w2 ^ i + 1);
					w2 = this.H(i, w3);
					w3 = num;
					i--;
				}
			}
			outBytes[outOff] = (byte)(w2 >> 8);
			outBytes[outOff + 1] = (byte)w2;
			outBytes[outOff + 2] = (byte)(w3 >> 8);
			outBytes[outOff + 3] = (byte)w3;
			outBytes[outOff + 4] = (byte)(w4 >> 8);
			outBytes[outOff + 5] = (byte)w4;
			outBytes[outOff + 6] = (byte)(w5 >> 8);
			outBytes[outOff + 7] = (byte)w5;
			return 8;
		}

		// Token: 0x040013D8 RID: 5080
		private const int BLOCK_SIZE = 8;

		// Token: 0x040013D9 RID: 5081
		private static readonly short[] ftable = new short[]
		{
			163,
			215,
			9,
			131,
			248,
			72,
			246,
			244,
			179,
			33,
			21,
			120,
			153,
			177,
			175,
			249,
			231,
			45,
			77,
			138,
			206,
			76,
			202,
			46,
			82,
			149,
			217,
			30,
			78,
			56,
			68,
			40,
			10,
			223,
			2,
			160,
			23,
			241,
			96,
			104,
			18,
			183,
			122,
			195,
			233,
			250,
			61,
			83,
			150,
			132,
			107,
			186,
			242,
			99,
			154,
			25,
			124,
			174,
			229,
			245,
			247,
			22,
			106,
			162,
			57,
			182,
			123,
			15,
			193,
			147,
			129,
			27,
			238,
			180,
			26,
			234,
			208,
			145,
			47,
			184,
			85,
			185,
			218,
			133,
			63,
			65,
			191,
			224,
			90,
			88,
			128,
			95,
			102,
			11,
			216,
			144,
			53,
			213,
			192,
			167,
			51,
			6,
			101,
			105,
			69,
			0,
			148,
			86,
			109,
			152,
			155,
			118,
			151,
			252,
			178,
			194,
			176,
			254,
			219,
			32,
			225,
			235,
			214,
			228,
			221,
			71,
			74,
			29,
			66,
			237,
			158,
			110,
			73,
			60,
			205,
			67,
			39,
			210,
			7,
			212,
			222,
			199,
			103,
			24,
			137,
			203,
			48,
			31,
			141,
			198,
			143,
			170,
			200,
			116,
			220,
			201,
			93,
			92,
			49,
			164,
			112,
			136,
			97,
			44,
			159,
			13,
			43,
			135,
			80,
			130,
			84,
			100,
			38,
			125,
			3,
			64,
			52,
			75,
			28,
			115,
			209,
			196,
			253,
			59,
			204,
			251,
			127,
			171,
			230,
			62,
			91,
			165,
			173,
			4,
			35,
			156,
			20,
			81,
			34,
			240,
			41,
			121,
			113,
			126,
			255,
			140,
			14,
			226,
			12,
			239,
			188,
			114,
			117,
			111,
			55,
			161,
			236,
			211,
			142,
			98,
			139,
			134,
			16,
			232,
			8,
			119,
			17,
			190,
			146,
			79,
			36,
			197,
			50,
			54,
			157,
			207,
			243,
			166,
			187,
			172,
			94,
			108,
			169,
			19,
			87,
			37,
			181,
			227,
			189,
			168,
			58,
			1,
			5,
			89,
			42,
			70
		};

		// Token: 0x040013DA RID: 5082
		private int[] key0;

		// Token: 0x040013DB RID: 5083
		private int[] key1;

		// Token: 0x040013DC RID: 5084
		private int[] key2;

		// Token: 0x040013DD RID: 5085
		private int[] key3;

		// Token: 0x040013DE RID: 5086
		private bool encrypting;
	}
}
