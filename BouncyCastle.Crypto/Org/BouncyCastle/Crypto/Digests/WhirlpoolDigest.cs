using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004EA RID: 1258
	public sealed class WhirlpoolDigest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06003195 RID: 12693 RVA: 0x000EDFD8 File Offset: 0x000EC1D8
		static WhirlpoolDigest()
		{
			global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.EIGHT[31] = 8;
			for (int i = 0; i < 256; i++)
			{
				int v = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.SBOX[i];
				int v2 = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.maskWithReductionPolynomial(v << 1);
				int v3 = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.maskWithReductionPolynomial(v2 << 1);
				int v4 = v3 ^ v;
				int v5 = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.maskWithReductionPolynomial(v3 << 1);
				int v6 = v5 ^ v;
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v, v, v3, v, v5, v4, v2, v6);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v6, v, v, v3, v, v5, v4, v2);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v2, v6, v, v, v3, v, v5, v4);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v4, v2, v6, v, v, v3, v, v5);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v5, v4, v2, v6, v, v, v3, v);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v, v5, v4, v2, v6, v, v, v3);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v3, v, v5, v4, v2, v6, v, v);
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.packIntoLong(v, v3, v, v5, v4, v2, v6, v);
			}
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000EE18C File Offset: 0x000EC38C
		public WhirlpoolDigest()
		{
			this._rc[0] = 0L;
			for (int r = 1; r <= 10; r++)
			{
				int i = 8 * (r - 1);
				this._rc[r] = ((global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0[i] & -72057594037927936L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1[i + 1] & 71776119061217280L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2[i + 2] & 280375465082880L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3[i + 3] & 1095216660480L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4[i + 4] & (long)((ulong)-16777216)) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5[i + 5] & 16711680L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6[i + 6] & 65280L) ^ (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7[i + 7] & 255L));
			}
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x000EE2BE File Offset: 0x000EC4BE
		private static long packIntoLong(int b7, int b6, int b5, int b4, int b3, int b2, int b1, int b0)
		{
			return (long)b7 << 56 ^ (long)b6 << 48 ^ (long)b5 << 40 ^ (long)b4 << 32 ^ (long)b3 << 24 ^ (long)b2 << 16 ^ (long)b1 << 8 ^ (long)b0;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x000EE2F0 File Offset: 0x000EC4F0
		private static int maskWithReductionPolynomial(int input)
		{
			int rv = input;
			if ((long)rv >= 256L)
			{
				rv ^= 285;
			}
			return rv;
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000EE314 File Offset: 0x000EC514
		public WhirlpoolDigest(global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest originalDigest)
		{
			this.Reset(originalDigest);
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x000EE391 File Offset: 0x000EC591
		public string AlgorithmName
		{
			get
			{
				return "Whirlpool";
			}
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x000EE398 File Offset: 0x000EC598
		public int GetDigestSize()
		{
			return 64;
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000EE39C File Offset: 0x000EC59C
		public int DoFinal(byte[] output, int outOff)
		{
			this.finish();
			for (int i = 0; i < 8; i++)
			{
				global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.convertLongToByteArray(this._hash[i], output, outOff + i * 8);
			}
			this.Reset();
			return this.GetDigestSize();
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000EE3DC File Offset: 0x000EC5DC
		public void Reset()
		{
			this._bufferPos = 0;
			global::System.Array.Clear(this._bitCount, 0, this._bitCount.Length);
			global::System.Array.Clear(this._buffer, 0, this._buffer.Length);
			global::System.Array.Clear(this._hash, 0, this._hash.Length);
			global::System.Array.Clear(this._K, 0, this._K.Length);
			global::System.Array.Clear(this._L, 0, this._L.Length);
			global::System.Array.Clear(this._block, 0, this._block.Length);
			global::System.Array.Clear(this._state, 0, this._state.Length);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000EE47C File Offset: 0x000EC67C
		private void processFilledBuffer()
		{
			for (int i = 0; i < this._state.Length; i++)
			{
				this._block[i] = global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.bytesToLongFromBuffer(this._buffer, i * 8);
			}
			this.processBlock();
			this._bufferPos = 0;
			global::System.Array.Clear(this._buffer, 0, this._buffer.Length);
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x000EE4D4 File Offset: 0x000EC6D4
		private static long bytesToLongFromBuffer(byte[] buffer, int startPos)
		{
			return (long)(((ulong)buffer[startPos] & 255UL) << 56 | ((ulong)buffer[startPos + 1] & 255UL) << 48 | ((ulong)buffer[startPos + 2] & 255UL) << 40 | ((ulong)buffer[startPos + 3] & 255UL) << 32 | ((ulong)buffer[startPos + 4] & 255UL) << 24 | ((ulong)buffer[startPos + 5] & 255UL) << 16 | ((ulong)buffer[startPos + 6] & 255UL) << 8 | ((ulong)buffer[startPos + 7] & 255UL));
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x000EE564 File Offset: 0x000EC764
		private static void convertLongToByteArray(long inputLong, byte[] outputArray, int offSet)
		{
			for (int i = 0; i < 8; i++)
			{
				outputArray[offSet + i] = (byte)(inputLong >> 56 - i * 8 & 255L);
			}
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x000EE598 File Offset: 0x000EC798
		private void processBlock()
		{
			for (int i = 0; i < 8; i++)
			{
				this._state[i] = (this._block[i] ^ (this._K[i] = this._hash[i]));
			}
			for (int round = 1; round <= 10; round++)
			{
				for (int j = 0; j < 8; j++)
				{
					this._L[j] = 0L;
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0[(int)(this._K[j & 7] >> 56) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1[(int)(this._K[j - 1 & 7] >> 48) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2[(int)(this._K[j - 2 & 7] >> 40) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3[(int)(this._K[j - 3 & 7] >> 32) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4[(int)(this._K[j - 4 & 7] >> 24) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5[(int)(this._K[j - 5 & 7] >> 16) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6[(int)(this._K[j - 6 & 7] >> 8) & 255];
					this._L[j] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7[(int)this._K[j - 7 & 7] & 255];
				}
				global::System.Array.Copy(this._L, 0, this._K, 0, this._K.Length);
				this._K[0] ^= this._rc[round];
				for (int k = 0; k < 8; k++)
				{
					this._L[k] = this._K[k];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C0[(int)(this._state[k & 7] >> 56) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C1[(int)(this._state[k - 1 & 7] >> 48) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C2[(int)(this._state[k - 2 & 7] >> 40) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C3[(int)(this._state[k - 3 & 7] >> 32) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C4[(int)(this._state[k - 4 & 7] >> 24) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C5[(int)(this._state[k - 5 & 7] >> 16) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C6[(int)(this._state[k - 6 & 7] >> 8) & 255];
					this._L[k] ^= global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.C7[(int)this._state[k - 7 & 7] & 255];
				}
				global::System.Array.Copy(this._L, 0, this._state, 0, this._state.Length);
			}
			for (int l = 0; l < 8; l++)
			{
				this._hash[l] ^= (this._state[l] ^ this._block[l]);
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000EE972 File Offset: 0x000ECB72
		public void Update(byte input)
		{
			this._buffer[this._bufferPos] = input;
			this._bufferPos++;
			if (this._bufferPos == this._buffer.Length)
			{
				this.processFilledBuffer();
			}
			this.increment();
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000EE9AC File Offset: 0x000ECBAC
		private void increment()
		{
			int carry = 0;
			for (int i = this._bitCount.Length - 1; i >= 0; i--)
			{
				int sum = (int)((this._bitCount[i] & 255) + global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest.EIGHT[i]) + carry;
				carry = sum >> 8;
				this._bitCount[i] = (short)(sum & 255);
			}
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000EE9FD File Offset: 0x000ECBFD
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (length > 0)
			{
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000EEA18 File Offset: 0x000ECC18
		private void finish()
		{
			byte[] bitLength = this.copyBitLength();
			byte[] buffer = this._buffer;
			int bufferPos = this._bufferPos;
			this._bufferPos = bufferPos + 1;
			int num = bufferPos;
			buffer[num] |= 128;
			if (this._bufferPos == this._buffer.Length)
			{
				this.processFilledBuffer();
			}
			if (this._bufferPos > 32)
			{
				while (this._bufferPos != 0)
				{
					this.Update(0);
				}
			}
			while (this._bufferPos <= 32)
			{
				this.Update(0);
			}
			global::System.Array.Copy(bitLength, 0, this._buffer, 32, bitLength.Length);
			this.processFilledBuffer();
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000EEAB0 File Offset: 0x000ECCB0
		private byte[] copyBitLength()
		{
			byte[] rv = new byte[32];
			for (int i = 0; i < rv.Length; i++)
			{
				rv[i] = (byte)(this._bitCount[i] & 255);
			}
			return rv;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000EEAE6 File Offset: 0x000ECCE6
		public int GetByteLength()
		{
			return 64;
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000EEAEA File Offset: 0x000ECCEA
		public global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest(this);
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x000EEAF4 File Offset: 0x000ECCF4
		public void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest originalDigest = (global::Org.BouncyCastle.Crypto.Digests.WhirlpoolDigest)other;
			global::System.Array.Copy(originalDigest._rc, 0, this._rc, 0, this._rc.Length);
			global::System.Array.Copy(originalDigest._buffer, 0, this._buffer, 0, this._buffer.Length);
			this._bufferPos = originalDigest._bufferPos;
			global::System.Array.Copy(originalDigest._bitCount, 0, this._bitCount, 0, this._bitCount.Length);
			global::System.Array.Copy(originalDigest._hash, 0, this._hash, 0, this._hash.Length);
			global::System.Array.Copy(originalDigest._K, 0, this._K, 0, this._K.Length);
			global::System.Array.Copy(originalDigest._L, 0, this._L, 0, this._L.Length);
			global::System.Array.Copy(originalDigest._block, 0, this._block, 0, this._block.Length);
			global::System.Array.Copy(originalDigest._state, 0, this._state, 0, this._state.Length);
		}

		// Token: 0x0400159A RID: 5530
		private const int BYTE_LENGTH = 64;

		// Token: 0x0400159B RID: 5531
		private const int DIGEST_LENGTH_BYTES = 64;

		// Token: 0x0400159C RID: 5532
		private const int ROUNDS = 10;

		// Token: 0x0400159D RID: 5533
		private const int REDUCTION_POLYNOMIAL = 285;

		// Token: 0x0400159E RID: 5534
		private static readonly int[] SBOX = new int[]
		{
			24,
			35,
			198,
			232,
			135,
			184,
			1,
			79,
			54,
			166,
			210,
			245,
			121,
			111,
			145,
			82,
			96,
			188,
			155,
			142,
			163,
			12,
			123,
			53,
			29,
			224,
			215,
			194,
			46,
			75,
			254,
			87,
			21,
			119,
			55,
			229,
			159,
			240,
			74,
			218,
			88,
			201,
			41,
			10,
			177,
			160,
			107,
			133,
			189,
			93,
			16,
			244,
			203,
			62,
			5,
			103,
			228,
			39,
			65,
			139,
			167,
			125,
			149,
			216,
			251,
			238,
			124,
			102,
			221,
			23,
			71,
			158,
			202,
			45,
			191,
			7,
			173,
			90,
			131,
			51,
			99,
			2,
			170,
			113,
			200,
			25,
			73,
			217,
			242,
			227,
			91,
			136,
			154,
			38,
			50,
			176,
			233,
			15,
			213,
			128,
			190,
			205,
			52,
			72,
			255,
			122,
			144,
			95,
			32,
			104,
			26,
			174,
			180,
			84,
			147,
			34,
			100,
			241,
			115,
			18,
			64,
			8,
			195,
			236,
			219,
			161,
			141,
			61,
			151,
			0,
			207,
			43,
			118,
			130,
			214,
			27,
			181,
			175,
			106,
			80,
			69,
			243,
			48,
			239,
			63,
			85,
			162,
			234,
			101,
			186,
			47,
			192,
			222,
			28,
			253,
			77,
			146,
			117,
			6,
			138,
			178,
			230,
			14,
			31,
			98,
			212,
			168,
			150,
			249,
			197,
			37,
			89,
			132,
			114,
			57,
			76,
			94,
			120,
			56,
			140,
			209,
			165,
			226,
			97,
			179,
			33,
			156,
			30,
			67,
			199,
			252,
			4,
			81,
			153,
			109,
			13,
			250,
			223,
			126,
			36,
			59,
			171,
			206,
			17,
			143,
			78,
			183,
			235,
			60,
			129,
			148,
			247,
			185,
			19,
			44,
			211,
			231,
			110,
			196,
			3,
			86,
			68,
			127,
			169,
			42,
			187,
			193,
			83,
			220,
			11,
			157,
			108,
			49,
			116,
			246,
			70,
			172,
			137,
			20,
			225,
			22,
			58,
			105,
			9,
			112,
			182,
			208,
			237,
			204,
			66,
			152,
			164,
			40,
			92,
			248,
			134
		};

		// Token: 0x0400159F RID: 5535
		private static readonly long[] C0 = new long[256];

		// Token: 0x040015A0 RID: 5536
		private static readonly long[] C1 = new long[256];

		// Token: 0x040015A1 RID: 5537
		private static readonly long[] C2 = new long[256];

		// Token: 0x040015A2 RID: 5538
		private static readonly long[] C3 = new long[256];

		// Token: 0x040015A3 RID: 5539
		private static readonly long[] C4 = new long[256];

		// Token: 0x040015A4 RID: 5540
		private static readonly long[] C5 = new long[256];

		// Token: 0x040015A5 RID: 5541
		private static readonly long[] C6 = new long[256];

		// Token: 0x040015A6 RID: 5542
		private static readonly long[] C7 = new long[256];

		// Token: 0x040015A7 RID: 5543
		private readonly long[] _rc = new long[11];

		// Token: 0x040015A8 RID: 5544
		private static readonly short[] EIGHT = new short[32];

		// Token: 0x040015A9 RID: 5545
		private const int BITCOUNT_ARRAY_SIZE = 32;

		// Token: 0x040015AA RID: 5546
		private byte[] _buffer = new byte[64];

		// Token: 0x040015AB RID: 5547
		private int _bufferPos;

		// Token: 0x040015AC RID: 5548
		private short[] _bitCount = new short[32];

		// Token: 0x040015AD RID: 5549
		private long[] _hash = new long[8];

		// Token: 0x040015AE RID: 5550
		private long[] _K = new long[8];

		// Token: 0x040015AF RID: 5551
		private long[] _L = new long[8];

		// Token: 0x040015B0 RID: 5552
		private long[] _block = new long[8];

		// Token: 0x040015B1 RID: 5553
		private long[] _state = new long[8];
	}
}
