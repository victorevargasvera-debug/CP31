using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A6 RID: 1190
	public class RC2Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002DE6 RID: 11750 RVA: 0x000CEEF4 File Offset: 0x000CD0F4
		private int[] GenerateWorkingKey(byte[] key, int bits)
		{
			int[] xKey = new int[128];
			for (int i = 0; i != key.Length; i++)
			{
				xKey[i] = (int)(key[i] & byte.MaxValue);
			}
			int len = key.Length;
			int x;
			if (len < 128)
			{
				int index = 0;
				x = xKey[len - 1];
				do
				{
					x = (int)(global::Org.BouncyCastle.Crypto.Engines.RC2Engine.piTable[x + xKey[index++] & 255] & byte.MaxValue);
					xKey[len++] = x;
				}
				while (len < 128);
			}
			len = bits + 7 >> 3;
			x = (int)(global::Org.BouncyCastle.Crypto.Engines.RC2Engine.piTable[xKey[128 - len] & 255 >> (7 & -bits)] & byte.MaxValue);
			xKey[128 - len] = x;
			for (int j = 128 - len - 1; j >= 0; j--)
			{
				x = (int)(global::Org.BouncyCastle.Crypto.Engines.RC2Engine.piTable[x ^ xKey[j + len]] & byte.MaxValue);
				xKey[j] = x;
			}
			int[] newKey = new int[64];
			for (int k = 0; k != newKey.Length; k++)
			{
				newKey[k] = xKey[2 * k] + (xKey[2 * k + 1] << 8);
			}
			return newKey;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x000CF008 File Offset: 0x000CD208
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.encrypting = forEncryption;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters param = (global::Org.BouncyCastle.Crypto.Parameters.RC2Parameters)parameters;
				this.workingKey = this.GenerateWorkingKey(param.GetKey(), param.EffectiveKeyBits);
				return;
			}
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				byte[] key = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
				this.workingKey = this.GenerateWorkingKey(key, key.Length * 8);
				return;
			}
			throw new global::System.ArgumentException("invalid parameter passed to RC2 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x000CF080 File Offset: 0x000CD280
		public virtual void Reset()
		{
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000CF082 File Offset: 0x000CD282
		public virtual string AlgorithmName
		{
			get
			{
				return "RC2";
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002DEA RID: 11754 RVA: 0x000CF089 File Offset: 0x000CD289
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x000CF08C File Offset: 0x000CD28C
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x000CF090 File Offset: 0x000CD290
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey == null)
			{
				throw new global::System.InvalidOperationException("RC2 engine not initialised");
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

		// Token: 0x06002DED RID: 11757 RVA: 0x000CF0EC File Offset: 0x000CD2EC
		private int RotateWordLeft(int x, int y)
		{
			x &= 65535;
			return x << y | x >> 16 - y;
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x000CF108 File Offset: 0x000CD308
		private void EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int x76 = ((int)(input[inOff + 7] & byte.MaxValue) << 8) + (int)(input[inOff + 6] & byte.MaxValue);
			int x77 = ((int)(input[inOff + 5] & byte.MaxValue) << 8) + (int)(input[inOff + 4] & byte.MaxValue);
			int x78 = ((int)(input[inOff + 3] & byte.MaxValue) << 8) + (int)(input[inOff + 2] & byte.MaxValue);
			int x79 = ((int)(input[inOff + 1] & byte.MaxValue) << 8) + (int)(input[inOff] & byte.MaxValue);
			for (int i = 0; i <= 16; i += 4)
			{
				x79 = this.RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + this.workingKey[i], 1);
				x78 = this.RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + this.workingKey[i + 1], 2);
				x77 = this.RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + this.workingKey[i + 2], 3);
				x76 = this.RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + this.workingKey[i + 3], 5);
			}
			x79 += this.workingKey[x76 & 63];
			x78 += this.workingKey[x79 & 63];
			x77 += this.workingKey[x78 & 63];
			x76 += this.workingKey[x77 & 63];
			for (int j = 20; j <= 40; j += 4)
			{
				x79 = this.RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + this.workingKey[j], 1);
				x78 = this.RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + this.workingKey[j + 1], 2);
				x77 = this.RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + this.workingKey[j + 2], 3);
				x76 = this.RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + this.workingKey[j + 3], 5);
			}
			x79 += this.workingKey[x76 & 63];
			x78 += this.workingKey[x79 & 63];
			x77 += this.workingKey[x78 & 63];
			x76 += this.workingKey[x77 & 63];
			for (int k = 44; k < 64; k += 4)
			{
				x79 = this.RotateWordLeft(x79 + (x78 & ~x76) + (x77 & x76) + this.workingKey[k], 1);
				x78 = this.RotateWordLeft(x78 + (x77 & ~x79) + (x76 & x79) + this.workingKey[k + 1], 2);
				x77 = this.RotateWordLeft(x77 + (x76 & ~x78) + (x79 & x78) + this.workingKey[k + 2], 3);
				x76 = this.RotateWordLeft(x76 + (x79 & ~x77) + (x78 & x77) + this.workingKey[k + 3], 5);
			}
			outBytes[outOff] = (byte)x79;
			outBytes[outOff + 1] = (byte)(x79 >> 8);
			outBytes[outOff + 2] = (byte)x78;
			outBytes[outOff + 3] = (byte)(x78 >> 8);
			outBytes[outOff + 4] = (byte)x77;
			outBytes[outOff + 5] = (byte)(x77 >> 8);
			outBytes[outOff + 6] = (byte)x76;
			outBytes[outOff + 7] = (byte)(x76 >> 8);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x000CF3D4 File Offset: 0x000CD5D4
		private void DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			int x76 = ((int)(input[inOff + 7] & byte.MaxValue) << 8) + (int)(input[inOff + 6] & byte.MaxValue);
			int x77 = ((int)(input[inOff + 5] & byte.MaxValue) << 8) + (int)(input[inOff + 4] & byte.MaxValue);
			int x78 = ((int)(input[inOff + 3] & byte.MaxValue) << 8) + (int)(input[inOff + 2] & byte.MaxValue);
			int x79 = ((int)(input[inOff + 1] & byte.MaxValue) << 8) + (int)(input[inOff] & byte.MaxValue);
			for (int i = 60; i >= 44; i -= 4)
			{
				x76 = this.RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + this.workingKey[i + 3]);
				x77 = this.RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + this.workingKey[i + 2]);
				x78 = this.RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + this.workingKey[i + 1]);
				x79 = this.RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + this.workingKey[i]);
			}
			x76 -= this.workingKey[x77 & 63];
			x77 -= this.workingKey[x78 & 63];
			x78 -= this.workingKey[x79 & 63];
			x79 -= this.workingKey[x76 & 63];
			for (int j = 40; j >= 20; j -= 4)
			{
				x76 = this.RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + this.workingKey[j + 3]);
				x77 = this.RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + this.workingKey[j + 2]);
				x78 = this.RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + this.workingKey[j + 1]);
				x79 = this.RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + this.workingKey[j]);
			}
			x76 -= this.workingKey[x77 & 63];
			x77 -= this.workingKey[x78 & 63];
			x78 -= this.workingKey[x79 & 63];
			x79 -= this.workingKey[x76 & 63];
			for (int k = 16; k >= 0; k -= 4)
			{
				x76 = this.RotateWordLeft(x76, 11) - ((x79 & ~x77) + (x78 & x77) + this.workingKey[k + 3]);
				x77 = this.RotateWordLeft(x77, 13) - ((x76 & ~x78) + (x79 & x78) + this.workingKey[k + 2]);
				x78 = this.RotateWordLeft(x78, 14) - ((x77 & ~x79) + (x76 & x79) + this.workingKey[k + 1]);
				x79 = this.RotateWordLeft(x79, 15) - ((x78 & ~x76) + (x77 & x76) + this.workingKey[k]);
			}
			outBytes[outOff] = (byte)x79;
			outBytes[outOff + 1] = (byte)(x79 >> 8);
			outBytes[outOff + 2] = (byte)x78;
			outBytes[outOff + 3] = (byte)(x78 >> 8);
			outBytes[outOff + 4] = (byte)x77;
			outBytes[outOff + 5] = (byte)(x77 >> 8);
			outBytes[outOff + 6] = (byte)x76;
			outBytes[outOff + 7] = (byte)(x76 >> 8);
		}

		// Token: 0x0400136B RID: 4971
		private static readonly byte[] piTable = new byte[]
		{
			217,
			120,
			249,
			196,
			25,
			221,
			181,
			237,
			40,
			233,
			253,
			121,
			74,
			160,
			216,
			157,
			198,
			126,
			55,
			131,
			43,
			118,
			83,
			142,
			98,
			76,
			100,
			136,
			68,
			139,
			251,
			162,
			23,
			154,
			89,
			245,
			135,
			179,
			79,
			19,
			97,
			69,
			109,
			141,
			9,
			129,
			125,
			50,
			189,
			143,
			64,
			235,
			134,
			183,
			123,
			11,
			240,
			149,
			33,
			34,
			92,
			107,
			78,
			130,
			84,
			214,
			101,
			147,
			206,
			96,
			178,
			28,
			115,
			86,
			192,
			20,
			167,
			140,
			241,
			220,
			18,
			117,
			202,
			31,
			59,
			190,
			228,
			209,
			66,
			61,
			212,
			48,
			163,
			60,
			182,
			38,
			111,
			191,
			14,
			218,
			70,
			105,
			7,
			87,
			39,
			242,
			29,
			155,
			188,
			148,
			67,
			3,
			248,
			17,
			199,
			246,
			144,
			239,
			62,
			231,
			6,
			195,
			213,
			47,
			200,
			102,
			30,
			215,
			8,
			232,
			234,
			222,
			128,
			82,
			238,
			247,
			132,
			170,
			114,
			172,
			53,
			77,
			106,
			42,
			150,
			26,
			210,
			113,
			90,
			21,
			73,
			116,
			75,
			159,
			208,
			94,
			4,
			24,
			164,
			236,
			194,
			224,
			65,
			110,
			15,
			81,
			203,
			204,
			36,
			145,
			175,
			80,
			161,
			244,
			112,
			57,
			153,
			124,
			58,
			133,
			35,
			184,
			180,
			122,
			252,
			2,
			54,
			91,
			37,
			85,
			151,
			49,
			45,
			93,
			250,
			152,
			227,
			138,
			146,
			174,
			5,
			223,
			41,
			16,
			103,
			108,
			186,
			201,
			211,
			0,
			230,
			207,
			225,
			158,
			168,
			44,
			99,
			22,
			1,
			63,
			88,
			226,
			137,
			169,
			13,
			56,
			52,
			27,
			171,
			51,
			byte.MaxValue,
			176,
			187,
			72,
			12,
			95,
			185,
			177,
			205,
			46,
			197,
			243,
			219,
			71,
			229,
			165,
			156,
			119,
			10,
			166,
			32,
			104,
			254,
			127,
			193,
			173
		};

		// Token: 0x0400136C RID: 4972
		private const int BLOCK_SIZE = 8;

		// Token: 0x0400136D RID: 4973
		private int[] workingKey;

		// Token: 0x0400136E RID: 4974
		private bool encrypting;
	}
}
