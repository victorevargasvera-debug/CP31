using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D2 RID: 1234
	public class MD2Digest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06003025 RID: 12325 RVA: 0x000E1E65 File Offset: 0x000E0065
		public MD2Digest()
		{
			this.Reset();
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000E1E9A File Offset: 0x000E009A
		public MD2Digest(global::Org.BouncyCastle.Crypto.Digests.MD2Digest t)
		{
			this.CopyIn(t);
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x000E1ED0 File Offset: 0x000E00D0
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.MD2Digest t)
		{
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
			global::System.Array.Copy(t.M, 0, this.M, 0, t.M.Length);
			this.mOff = t.mOff;
			global::System.Array.Copy(t.C, 0, this.C, 0, t.C.Length);
			this.COff = t.COff;
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x000E1F52 File Offset: 0x000E0152
		public string AlgorithmName
		{
			get
			{
				return "MD2";
			}
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x000E1F59 File Offset: 0x000E0159
		public int GetDigestSize()
		{
			return 16;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x000E1F5D File Offset: 0x000E015D
		public int GetByteLength()
		{
			return 16;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x000E1F64 File Offset: 0x000E0164
		public int DoFinal(byte[] output, int outOff)
		{
			byte paddingByte = (byte)(this.M.Length - this.mOff);
			for (int i = this.mOff; i < this.M.Length; i++)
			{
				this.M[i] = paddingByte;
			}
			this.ProcessChecksum(this.M);
			this.ProcessBlock(this.M);
			this.ProcessBlock(this.C);
			global::System.Array.Copy(this.X, this.xOff, output, outOff, 16);
			this.Reset();
			return 16;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x000E1FE4 File Offset: 0x000E01E4
		public void Reset()
		{
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
			this.mOff = 0;
			for (int j = 0; j != this.M.Length; j++)
			{
				this.M[j] = 0;
			}
			this.COff = 0;
			for (int k = 0; k != this.C.Length; k++)
			{
				this.C[k] = 0;
			}
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x000E205C File Offset: 0x000E025C
		public void Update(byte input)
		{
			byte[] m = this.M;
			int num = this.mOff;
			this.mOff = num + 1;
			m[num] = input;
			if (this.mOff == 16)
			{
				this.ProcessChecksum(this.M);
				this.ProcessBlock(this.M);
				this.mOff = 0;
			}
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x000E20AC File Offset: 0x000E02AC
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (this.mOff != 0)
			{
				if (length <= 0)
				{
					break;
				}
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
			while (length > 16)
			{
				global::System.Array.Copy(input, inOff, this.M, 0, 16);
				this.ProcessChecksum(this.M);
				this.ProcessBlock(this.M);
				length -= 16;
				inOff += 16;
			}
			while (length > 0)
			{
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x000E2130 File Offset: 0x000E0330
		internal void ProcessChecksum(byte[] m)
		{
			int L = (int)this.C[15];
			for (int i = 0; i < 16; i++)
			{
				byte[] c = this.C;
				int num = i;
				c[num] ^= global::Org.BouncyCastle.Crypto.Digests.MD2Digest.S[((int)m[i] ^ L) & 255];
				L = (int)this.C[i];
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000E2180 File Offset: 0x000E0380
		internal void ProcessBlock(byte[] m)
		{
			for (int i = 0; i < 16; i++)
			{
				this.X[i + 16] = m[i];
				this.X[i + 32] = (m[i] ^ this.X[i]);
			}
			int t = 0;
			for (int j = 0; j < 18; j++)
			{
				for (int k = 0; k < 48; k++)
				{
					byte[] x = this.X;
					int num = k;
					t = (int)(x[num] ^= global::Org.BouncyCastle.Crypto.Digests.MD2Digest.S[t]);
					t &= 255;
				}
				t = (t + j) % 256;
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000E220C File Offset: 0x000E040C
		public global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.MD2Digest(this);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000E2214 File Offset: 0x000E0414
		public void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.MD2Digest d = (global::Org.BouncyCastle.Crypto.Digests.MD2Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x040014D2 RID: 5330
		private const int DigestLength = 16;

		// Token: 0x040014D3 RID: 5331
		private const int BYTE_LENGTH = 16;

		// Token: 0x040014D4 RID: 5332
		private byte[] X = new byte[48];

		// Token: 0x040014D5 RID: 5333
		private int xOff;

		// Token: 0x040014D6 RID: 5334
		private byte[] M = new byte[16];

		// Token: 0x040014D7 RID: 5335
		private int mOff;

		// Token: 0x040014D8 RID: 5336
		private byte[] C = new byte[16];

		// Token: 0x040014D9 RID: 5337
		private int COff;

		// Token: 0x040014DA RID: 5338
		private static readonly byte[] S = new byte[]
		{
			41,
			46,
			67,
			201,
			162,
			216,
			124,
			1,
			61,
			54,
			84,
			161,
			236,
			240,
			6,
			19,
			98,
			167,
			5,
			243,
			192,
			199,
			115,
			140,
			152,
			147,
			43,
			217,
			188,
			76,
			130,
			202,
			30,
			155,
			87,
			60,
			253,
			212,
			224,
			22,
			103,
			66,
			111,
			24,
			138,
			23,
			229,
			18,
			190,
			78,
			196,
			214,
			218,
			158,
			222,
			73,
			160,
			251,
			245,
			142,
			187,
			47,
			238,
			122,
			169,
			104,
			121,
			145,
			21,
			178,
			7,
			63,
			148,
			194,
			16,
			137,
			11,
			34,
			95,
			33,
			128,
			127,
			93,
			154,
			90,
			144,
			50,
			39,
			53,
			62,
			204,
			231,
			191,
			247,
			151,
			3,
			byte.MaxValue,
			25,
			48,
			179,
			72,
			165,
			181,
			209,
			215,
			94,
			146,
			42,
			172,
			86,
			170,
			198,
			79,
			184,
			56,
			210,
			150,
			164,
			125,
			182,
			118,
			252,
			107,
			226,
			156,
			116,
			4,
			241,
			69,
			157,
			112,
			89,
			100,
			113,
			135,
			32,
			134,
			91,
			207,
			101,
			230,
			45,
			168,
			2,
			27,
			96,
			37,
			173,
			174,
			176,
			185,
			246,
			28,
			70,
			97,
			105,
			52,
			64,
			126,
			15,
			85,
			71,
			163,
			35,
			221,
			81,
			175,
			58,
			195,
			92,
			249,
			206,
			186,
			197,
			234,
			38,
			44,
			83,
			13,
			110,
			133,
			40,
			132,
			9,
			211,
			223,
			205,
			244,
			65,
			129,
			77,
			82,
			106,
			220,
			55,
			200,
			108,
			193,
			171,
			250,
			36,
			225,
			123,
			8,
			12,
			189,
			177,
			74,
			120,
			136,
			149,
			139,
			227,
			99,
			232,
			109,
			233,
			203,
			213,
			254,
			59,
			0,
			29,
			57,
			242,
			239,
			183,
			14,
			102,
			88,
			208,
			228,
			166,
			119,
			114,
			248,
			235,
			117,
			75,
			10,
			49,
			68,
			80,
			180,
			143,
			237,
			31,
			26,
			219,
			153,
			141,
			51,
			159,
			17,
			131,
			20
		};
	}
}
