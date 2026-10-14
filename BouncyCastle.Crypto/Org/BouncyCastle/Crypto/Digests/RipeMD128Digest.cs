using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D8 RID: 1240
	public class RipeMD128Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x06003077 RID: 12407 RVA: 0x000E3D56 File Offset: 0x000E1F56
		public RipeMD128Digest()
		{
			this.Reset();
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x000E3D71 File Offset: 0x000E1F71
		public RipeMD128Digest(global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000E3D90 File Offset: 0x000E1F90
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest t)
		{
			base.CopyIn(t);
			this.H0 = t.H0;
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x000E3DFB File Offset: 0x000E1FFB
		public override string AlgorithmName
		{
			get
			{
				return "RIPEMD128";
			}
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x000E3E02 File Offset: 0x000E2002
		public override int GetDigestSize()
		{
			return 16;
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x000E3E08 File Offset: 0x000E2008
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

		// Token: 0x0600307D RID: 12413 RVA: 0x000E3E72 File Offset: 0x000E2072
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (int)(bitLength & (long)((ulong)-1));
			this.X[15] = (int)((ulong)bitLength >> 32);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x000E3EA0 File Offset: 0x000E20A0
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
			outBytes[outOff] = (byte)word;
			outBytes[outOff + 1] = (byte)((uint)word >> 8);
			outBytes[outOff + 2] = (byte)((uint)word >> 16);
			outBytes[outOff + 3] = (byte)((uint)word >> 24);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x000E3EC4 File Offset: 0x000E20C4
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			this.UnpackWord(this.H0, output, outOff);
			this.UnpackWord(this.H1, output, outOff + 4);
			this.UnpackWord(this.H2, output, outOff + 8);
			this.UnpackWord(this.H3, output, outOff + 12);
			this.Reset();
			return 16;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x000E3F20 File Offset: 0x000E2120
		public override void Reset()
		{
			base.Reset();
			this.H0 = 1732584193;
			this.H1 = -271733879;
			this.H2 = -1732584194;
			this.H3 = 271733878;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x000E3F82 File Offset: 0x000E2182
		private int RL(int x, int n)
		{
			return x << n | (int)((uint)x >> 32 - n);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x000E3F94 File Offset: 0x000E2194
		private int F1(int x, int y, int z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x000E3F9B File Offset: 0x000E219B
		private int F2(int x, int y, int z)
		{
			return (x & y) | (~x & z);
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x000E3FA5 File Offset: 0x000E21A5
		private int F3(int x, int y, int z)
		{
			return (x | ~y) ^ z;
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x000E3FAD File Offset: 0x000E21AD
		private int F4(int x, int y, int z)
		{
			return (x & z) | (y & ~z);
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x000E3FB7 File Offset: 0x000E21B7
		private int F1(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F1(b, c, d) + x, s);
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x000E3FD0 File Offset: 0x000E21D0
		private int F2(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F2(b, c, d) + x + 1518500249, s);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x000E3FEF File Offset: 0x000E21EF
		private int F3(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F3(b, c, d) + x + 1859775393, s);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x000E400E File Offset: 0x000E220E
		private int F4(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F4(b, c, d) + x + -1894007588, s);
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x000E402D File Offset: 0x000E222D
		private int FF1(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F1(b, c, d) + x, s);
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x000E4046 File Offset: 0x000E2246
		private int FF2(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F2(b, c, d) + x + 1836072691, s);
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x000E4065 File Offset: 0x000E2265
		private int FF3(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F3(b, c, d) + x + 1548603684, s);
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x000E4084 File Offset: 0x000E2284
		private int FF4(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F4(b, c, d) + x + 1352829926, s);
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000E40A4 File Offset: 0x000E22A4
		internal override void ProcessBlock()
		{
			int a;
			int aa = a = this.H0;
			int b;
			int bb = b = this.H1;
			int c;
			int cc = c = this.H2;
			int d;
			int dd = d = this.H3;
			a = this.F1(a, b, c, d, this.X[0], 11);
			d = this.F1(d, a, b, c, this.X[1], 14);
			c = this.F1(c, d, a, b, this.X[2], 15);
			b = this.F1(b, c, d, a, this.X[3], 12);
			a = this.F1(a, b, c, d, this.X[4], 5);
			d = this.F1(d, a, b, c, this.X[5], 8);
			c = this.F1(c, d, a, b, this.X[6], 7);
			b = this.F1(b, c, d, a, this.X[7], 9);
			a = this.F1(a, b, c, d, this.X[8], 11);
			d = this.F1(d, a, b, c, this.X[9], 13);
			c = this.F1(c, d, a, b, this.X[10], 14);
			b = this.F1(b, c, d, a, this.X[11], 15);
			a = this.F1(a, b, c, d, this.X[12], 6);
			d = this.F1(d, a, b, c, this.X[13], 7);
			c = this.F1(c, d, a, b, this.X[14], 9);
			b = this.F1(b, c, d, a, this.X[15], 8);
			a = this.F2(a, b, c, d, this.X[7], 7);
			d = this.F2(d, a, b, c, this.X[4], 6);
			c = this.F2(c, d, a, b, this.X[13], 8);
			b = this.F2(b, c, d, a, this.X[1], 13);
			a = this.F2(a, b, c, d, this.X[10], 11);
			d = this.F2(d, a, b, c, this.X[6], 9);
			c = this.F2(c, d, a, b, this.X[15], 7);
			b = this.F2(b, c, d, a, this.X[3], 15);
			a = this.F2(a, b, c, d, this.X[12], 7);
			d = this.F2(d, a, b, c, this.X[0], 12);
			c = this.F2(c, d, a, b, this.X[9], 15);
			b = this.F2(b, c, d, a, this.X[5], 9);
			a = this.F2(a, b, c, d, this.X[2], 11);
			d = this.F2(d, a, b, c, this.X[14], 7);
			c = this.F2(c, d, a, b, this.X[11], 13);
			b = this.F2(b, c, d, a, this.X[8], 12);
			a = this.F3(a, b, c, d, this.X[3], 11);
			d = this.F3(d, a, b, c, this.X[10], 13);
			c = this.F3(c, d, a, b, this.X[14], 6);
			b = this.F3(b, c, d, a, this.X[4], 7);
			a = this.F3(a, b, c, d, this.X[9], 14);
			d = this.F3(d, a, b, c, this.X[15], 9);
			c = this.F3(c, d, a, b, this.X[8], 13);
			b = this.F3(b, c, d, a, this.X[1], 15);
			a = this.F3(a, b, c, d, this.X[2], 14);
			d = this.F3(d, a, b, c, this.X[7], 8);
			c = this.F3(c, d, a, b, this.X[0], 13);
			b = this.F3(b, c, d, a, this.X[6], 6);
			a = this.F3(a, b, c, d, this.X[13], 5);
			d = this.F3(d, a, b, c, this.X[11], 12);
			c = this.F3(c, d, a, b, this.X[5], 7);
			b = this.F3(b, c, d, a, this.X[12], 5);
			a = this.F4(a, b, c, d, this.X[1], 11);
			d = this.F4(d, a, b, c, this.X[9], 12);
			c = this.F4(c, d, a, b, this.X[11], 14);
			b = this.F4(b, c, d, a, this.X[10], 15);
			a = this.F4(a, b, c, d, this.X[0], 14);
			d = this.F4(d, a, b, c, this.X[8], 15);
			c = this.F4(c, d, a, b, this.X[12], 9);
			b = this.F4(b, c, d, a, this.X[4], 8);
			a = this.F4(a, b, c, d, this.X[13], 9);
			d = this.F4(d, a, b, c, this.X[3], 14);
			c = this.F4(c, d, a, b, this.X[7], 5);
			b = this.F4(b, c, d, a, this.X[15], 6);
			a = this.F4(a, b, c, d, this.X[14], 8);
			d = this.F4(d, a, b, c, this.X[5], 6);
			c = this.F4(c, d, a, b, this.X[6], 5);
			b = this.F4(b, c, d, a, this.X[2], 12);
			aa = this.FF4(aa, bb, cc, dd, this.X[5], 8);
			dd = this.FF4(dd, aa, bb, cc, this.X[14], 9);
			cc = this.FF4(cc, dd, aa, bb, this.X[7], 9);
			bb = this.FF4(bb, cc, dd, aa, this.X[0], 11);
			aa = this.FF4(aa, bb, cc, dd, this.X[9], 13);
			dd = this.FF4(dd, aa, bb, cc, this.X[2], 15);
			cc = this.FF4(cc, dd, aa, bb, this.X[11], 15);
			bb = this.FF4(bb, cc, dd, aa, this.X[4], 5);
			aa = this.FF4(aa, bb, cc, dd, this.X[13], 7);
			dd = this.FF4(dd, aa, bb, cc, this.X[6], 7);
			cc = this.FF4(cc, dd, aa, bb, this.X[15], 8);
			bb = this.FF4(bb, cc, dd, aa, this.X[8], 11);
			aa = this.FF4(aa, bb, cc, dd, this.X[1], 14);
			dd = this.FF4(dd, aa, bb, cc, this.X[10], 14);
			cc = this.FF4(cc, dd, aa, bb, this.X[3], 12);
			bb = this.FF4(bb, cc, dd, aa, this.X[12], 6);
			aa = this.FF3(aa, bb, cc, dd, this.X[6], 9);
			dd = this.FF3(dd, aa, bb, cc, this.X[11], 13);
			cc = this.FF3(cc, dd, aa, bb, this.X[3], 15);
			bb = this.FF3(bb, cc, dd, aa, this.X[7], 7);
			aa = this.FF3(aa, bb, cc, dd, this.X[0], 12);
			dd = this.FF3(dd, aa, bb, cc, this.X[13], 8);
			cc = this.FF3(cc, dd, aa, bb, this.X[5], 9);
			bb = this.FF3(bb, cc, dd, aa, this.X[10], 11);
			aa = this.FF3(aa, bb, cc, dd, this.X[14], 7);
			dd = this.FF3(dd, aa, bb, cc, this.X[15], 7);
			cc = this.FF3(cc, dd, aa, bb, this.X[8], 12);
			bb = this.FF3(bb, cc, dd, aa, this.X[12], 7);
			aa = this.FF3(aa, bb, cc, dd, this.X[4], 6);
			dd = this.FF3(dd, aa, bb, cc, this.X[9], 15);
			cc = this.FF3(cc, dd, aa, bb, this.X[1], 13);
			bb = this.FF3(bb, cc, dd, aa, this.X[2], 11);
			aa = this.FF2(aa, bb, cc, dd, this.X[15], 9);
			dd = this.FF2(dd, aa, bb, cc, this.X[5], 7);
			cc = this.FF2(cc, dd, aa, bb, this.X[1], 15);
			bb = this.FF2(bb, cc, dd, aa, this.X[3], 11);
			aa = this.FF2(aa, bb, cc, dd, this.X[7], 8);
			dd = this.FF2(dd, aa, bb, cc, this.X[14], 6);
			cc = this.FF2(cc, dd, aa, bb, this.X[6], 6);
			bb = this.FF2(bb, cc, dd, aa, this.X[9], 14);
			aa = this.FF2(aa, bb, cc, dd, this.X[11], 12);
			dd = this.FF2(dd, aa, bb, cc, this.X[8], 13);
			cc = this.FF2(cc, dd, aa, bb, this.X[12], 5);
			bb = this.FF2(bb, cc, dd, aa, this.X[2], 14);
			aa = this.FF2(aa, bb, cc, dd, this.X[10], 13);
			dd = this.FF2(dd, aa, bb, cc, this.X[0], 13);
			cc = this.FF2(cc, dd, aa, bb, this.X[4], 7);
			bb = this.FF2(bb, cc, dd, aa, this.X[13], 5);
			aa = this.FF1(aa, bb, cc, dd, this.X[8], 15);
			dd = this.FF1(dd, aa, bb, cc, this.X[6], 5);
			cc = this.FF1(cc, dd, aa, bb, this.X[4], 8);
			bb = this.FF1(bb, cc, dd, aa, this.X[1], 11);
			aa = this.FF1(aa, bb, cc, dd, this.X[3], 14);
			dd = this.FF1(dd, aa, bb, cc, this.X[11], 14);
			cc = this.FF1(cc, dd, aa, bb, this.X[15], 6);
			bb = this.FF1(bb, cc, dd, aa, this.X[0], 14);
			aa = this.FF1(aa, bb, cc, dd, this.X[5], 6);
			dd = this.FF1(dd, aa, bb, cc, this.X[12], 9);
			cc = this.FF1(cc, dd, aa, bb, this.X[2], 12);
			bb = this.FF1(bb, cc, dd, aa, this.X[13], 9);
			aa = this.FF1(aa, bb, cc, dd, this.X[9], 12);
			dd = this.FF1(dd, aa, bb, cc, this.X[7], 5);
			cc = this.FF1(cc, dd, aa, bb, this.X[10], 15);
			bb = this.FF1(bb, cc, dd, aa, this.X[14], 8);
			dd += c + this.H1;
			this.H1 = this.H2 + d + aa;
			this.H2 = this.H3 + a + bb;
			this.H3 = this.H0 + b + cc;
			this.H0 = dd;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000E4D0F File Offset: 0x000E2F0F
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest(this);
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x000E4D18 File Offset: 0x000E2F18
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest d = (global::Org.BouncyCastle.Crypto.Digests.RipeMD128Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001512 RID: 5394
		private const int DigestLength = 16;

		// Token: 0x04001513 RID: 5395
		private int H0;

		// Token: 0x04001514 RID: 5396
		private int H1;

		// Token: 0x04001515 RID: 5397
		private int H2;

		// Token: 0x04001516 RID: 5398
		private int H3;

		// Token: 0x04001517 RID: 5399
		private int[] X = new int[16];

		// Token: 0x04001518 RID: 5400
		private int xOff;
	}
}
