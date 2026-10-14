using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D3 RID: 1235
	public class MD4Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x06003034 RID: 12340 RVA: 0x000E224B File Offset: 0x000E044B
		public MD4Digest()
		{
			this.Reset();
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x000E2266 File Offset: 0x000E0466
		public MD4Digest(global::Org.BouncyCastle.Crypto.Digests.MD4Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x000E2284 File Offset: 0x000E0484
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.MD4Digest t)
		{
			base.CopyIn(t);
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06003037 RID: 12343 RVA: 0x000E22EF File Offset: 0x000E04EF
		public override string AlgorithmName
		{
			get
			{
				return "MD4";
			}
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x000E22F6 File Offset: 0x000E04F6
		public override int GetDigestSize()
		{
			return 16;
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000E22FC File Offset: 0x000E04FC
		internal override void ProcessWord(byte[] input, int inOff)
		{
			int[] x = this.X;
			int num = this.xOff;
			this.xOff = num + 1;
			x[num] = ((int)(input[inOff] & byte.MaxValue) | (int)(input[inOff + 1] & byte.MaxValue) << 8 | (int)(input[inOff + 2] & byte.MaxValue) << 16 | (int)(input[inOff + 3] & byte.MaxValue) << 24);
			if (this.xOff == 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000E2366 File Offset: 0x000E0566
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (int)(bitLength & (long)((ulong)-1));
			this.X[15] = (int)((ulong)bitLength >> 32);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000E2394 File Offset: 0x000E0594
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
			outBytes[outOff] = (byte)word;
			outBytes[outOff + 1] = (byte)((uint)word >> 8);
			outBytes[outOff + 2] = (byte)((uint)word >> 16);
			outBytes[outOff + 3] = (byte)((uint)word >> 24);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000E23B8 File Offset: 0x000E05B8
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			this.UnpackWord(this.H1, output, outOff);
			this.UnpackWord(this.H2, output, outOff + 4);
			this.UnpackWord(this.H3, output, outOff + 8);
			this.UnpackWord(this.H4, output, outOff + 12);
			this.Reset();
			return 16;
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000E2414 File Offset: 0x000E0614
		public override void Reset()
		{
			base.Reset();
			this.H1 = 1732584193;
			this.H2 = -271733879;
			this.H3 = -1732584194;
			this.H4 = 271733878;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x000E2476 File Offset: 0x000E0676
		private int RotateLeft(int x, int n)
		{
			return x << n | (int)((uint)x >> 32 - n);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000E2488 File Offset: 0x000E0688
		private int F(int u, int v, int w)
		{
			return (u & v) | (~u & w);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000E2492 File Offset: 0x000E0692
		private int G(int u, int v, int w)
		{
			return (u & v) | (u & w) | (v & w);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000E249F File Offset: 0x000E069F
		private int H(int u, int v, int w)
		{
			return u ^ v ^ w;
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000E24A8 File Offset: 0x000E06A8
		internal override void ProcessBlock()
		{
			int a = this.H1;
			int b = this.H2;
			int c = this.H3;
			int d = this.H4;
			a = this.RotateLeft(a + this.F(b, c, d) + this.X[0], 3);
			d = this.RotateLeft(d + this.F(a, b, c) + this.X[1], 7);
			c = this.RotateLeft(c + this.F(d, a, b) + this.X[2], 11);
			b = this.RotateLeft(b + this.F(c, d, a) + this.X[3], 19);
			a = this.RotateLeft(a + this.F(b, c, d) + this.X[4], 3);
			d = this.RotateLeft(d + this.F(a, b, c) + this.X[5], 7);
			c = this.RotateLeft(c + this.F(d, a, b) + this.X[6], 11);
			b = this.RotateLeft(b + this.F(c, d, a) + this.X[7], 19);
			a = this.RotateLeft(a + this.F(b, c, d) + this.X[8], 3);
			d = this.RotateLeft(d + this.F(a, b, c) + this.X[9], 7);
			c = this.RotateLeft(c + this.F(d, a, b) + this.X[10], 11);
			b = this.RotateLeft(b + this.F(c, d, a) + this.X[11], 19);
			a = this.RotateLeft(a + this.F(b, c, d) + this.X[12], 3);
			d = this.RotateLeft(d + this.F(a, b, c) + this.X[13], 7);
			c = this.RotateLeft(c + this.F(d, a, b) + this.X[14], 11);
			b = this.RotateLeft(b + this.F(c, d, a) + this.X[15], 19);
			a = this.RotateLeft(a + this.G(b, c, d) + this.X[0] + 1518500249, 3);
			d = this.RotateLeft(d + this.G(a, b, c) + this.X[4] + 1518500249, 5);
			c = this.RotateLeft(c + this.G(d, a, b) + this.X[8] + 1518500249, 9);
			b = this.RotateLeft(b + this.G(c, d, a) + this.X[12] + 1518500249, 13);
			a = this.RotateLeft(a + this.G(b, c, d) + this.X[1] + 1518500249, 3);
			d = this.RotateLeft(d + this.G(a, b, c) + this.X[5] + 1518500249, 5);
			c = this.RotateLeft(c + this.G(d, a, b) + this.X[9] + 1518500249, 9);
			b = this.RotateLeft(b + this.G(c, d, a) + this.X[13] + 1518500249, 13);
			a = this.RotateLeft(a + this.G(b, c, d) + this.X[2] + 1518500249, 3);
			d = this.RotateLeft(d + this.G(a, b, c) + this.X[6] + 1518500249, 5);
			c = this.RotateLeft(c + this.G(d, a, b) + this.X[10] + 1518500249, 9);
			b = this.RotateLeft(b + this.G(c, d, a) + this.X[14] + 1518500249, 13);
			a = this.RotateLeft(a + this.G(b, c, d) + this.X[3] + 1518500249, 3);
			d = this.RotateLeft(d + this.G(a, b, c) + this.X[7] + 1518500249, 5);
			c = this.RotateLeft(c + this.G(d, a, b) + this.X[11] + 1518500249, 9);
			b = this.RotateLeft(b + this.G(c, d, a) + this.X[15] + 1518500249, 13);
			a = this.RotateLeft(a + this.H(b, c, d) + this.X[0] + 1859775393, 3);
			d = this.RotateLeft(d + this.H(a, b, c) + this.X[8] + 1859775393, 9);
			c = this.RotateLeft(c + this.H(d, a, b) + this.X[4] + 1859775393, 11);
			b = this.RotateLeft(b + this.H(c, d, a) + this.X[12] + 1859775393, 15);
			a = this.RotateLeft(a + this.H(b, c, d) + this.X[2] + 1859775393, 3);
			d = this.RotateLeft(d + this.H(a, b, c) + this.X[10] + 1859775393, 9);
			c = this.RotateLeft(c + this.H(d, a, b) + this.X[6] + 1859775393, 11);
			b = this.RotateLeft(b + this.H(c, d, a) + this.X[14] + 1859775393, 15);
			a = this.RotateLeft(a + this.H(b, c, d) + this.X[1] + 1859775393, 3);
			d = this.RotateLeft(d + this.H(a, b, c) + this.X[9] + 1859775393, 9);
			c = this.RotateLeft(c + this.H(d, a, b) + this.X[5] + 1859775393, 11);
			b = this.RotateLeft(b + this.H(c, d, a) + this.X[13] + 1859775393, 15);
			a = this.RotateLeft(a + this.H(b, c, d) + this.X[3] + 1859775393, 3);
			d = this.RotateLeft(d + this.H(a, b, c) + this.X[11] + 1859775393, 9);
			c = this.RotateLeft(c + this.H(d, a, b) + this.X[7] + 1859775393, 11);
			b = this.RotateLeft(b + this.H(c, d, a) + this.X[15] + 1859775393, 15);
			this.H1 += a;
			this.H2 += b;
			this.H3 += c;
			this.H4 += d;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000E2B62 File Offset: 0x000E0D62
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.MD4Digest(this);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000E2B6C File Offset: 0x000E0D6C
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.MD4Digest d = (global::Org.BouncyCastle.Crypto.Digests.MD4Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x040014DB RID: 5339
		private const int DigestLength = 16;

		// Token: 0x040014DC RID: 5340
		private int H1;

		// Token: 0x040014DD RID: 5341
		private int H2;

		// Token: 0x040014DE RID: 5342
		private int H3;

		// Token: 0x040014DF RID: 5343
		private int H4;

		// Token: 0x040014E0 RID: 5344
		private int[] X = new int[16];

		// Token: 0x040014E1 RID: 5345
		private int xOff;

		// Token: 0x040014E2 RID: 5346
		private const int S11 = 3;

		// Token: 0x040014E3 RID: 5347
		private const int S12 = 7;

		// Token: 0x040014E4 RID: 5348
		private const int S13 = 11;

		// Token: 0x040014E5 RID: 5349
		private const int S14 = 19;

		// Token: 0x040014E6 RID: 5350
		private const int S21 = 3;

		// Token: 0x040014E7 RID: 5351
		private const int S22 = 5;

		// Token: 0x040014E8 RID: 5352
		private const int S23 = 9;

		// Token: 0x040014E9 RID: 5353
		private const int S24 = 13;

		// Token: 0x040014EA RID: 5354
		private const int S31 = 3;

		// Token: 0x040014EB RID: 5355
		private const int S32 = 9;

		// Token: 0x040014EC RID: 5356
		private const int S33 = 11;

		// Token: 0x040014ED RID: 5357
		private const int S34 = 15;
	}
}
