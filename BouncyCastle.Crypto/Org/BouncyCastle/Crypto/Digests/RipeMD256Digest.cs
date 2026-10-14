using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DA RID: 1242
	public class RipeMD256Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x000E704F File Offset: 0x000E524F
		public override string AlgorithmName
		{
			get
			{
				return "RIPEMD256";
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x000E7056 File Offset: 0x000E5256
		public override int GetDigestSize()
		{
			return 32;
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x000E705A File Offset: 0x000E525A
		public RipeMD256Digest()
		{
			this.Reset();
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x000E7075 File Offset: 0x000E5275
		public RipeMD256Digest(global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x000E7094 File Offset: 0x000E5294
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest t)
		{
			base.CopyIn(t);
			this.H0 = t.H0;
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			this.H5 = t.H5;
			this.H6 = t.H6;
			this.H7 = t.H7;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x000E7130 File Offset: 0x000E5330
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

		// Token: 0x060030AA RID: 12458 RVA: 0x000E719A File Offset: 0x000E539A
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (int)(bitLength & (long)((ulong)-1));
			this.X[15] = (int)((ulong)bitLength >> 32);
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x000E71C8 File Offset: 0x000E53C8
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
			outBytes[outOff] = (byte)word;
			outBytes[outOff + 1] = (byte)((uint)word >> 8);
			outBytes[outOff + 2] = (byte)((uint)word >> 16);
			outBytes[outOff + 3] = (byte)((uint)word >> 24);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x000E71EC File Offset: 0x000E53EC
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			this.UnpackWord(this.H0, output, outOff);
			this.UnpackWord(this.H1, output, outOff + 4);
			this.UnpackWord(this.H2, output, outOff + 8);
			this.UnpackWord(this.H3, output, outOff + 12);
			this.UnpackWord(this.H4, output, outOff + 16);
			this.UnpackWord(this.H5, output, outOff + 20);
			this.UnpackWord(this.H6, output, outOff + 24);
			this.UnpackWord(this.H7, output, outOff + 28);
			this.Reset();
			return 32;
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x000E728C File Offset: 0x000E548C
		public override void Reset()
		{
			base.Reset();
			this.H0 = 1732584193;
			this.H1 = -271733879;
			this.H2 = -1732584194;
			this.H3 = 271733878;
			this.H4 = 1985229328;
			this.H5 = -19088744;
			this.H6 = -1985229329;
			this.H7 = 19088743;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x000E731A File Offset: 0x000E551A
		private int RL(int x, int n)
		{
			return x << n | (int)((uint)x >> 32 - n);
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x000E732C File Offset: 0x000E552C
		private int F1(int x, int y, int z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000E7333 File Offset: 0x000E5533
		private int F2(int x, int y, int z)
		{
			return (x & y) | (~x & z);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000E733D File Offset: 0x000E553D
		private int F3(int x, int y, int z)
		{
			return (x | ~y) ^ z;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000E7345 File Offset: 0x000E5545
		private int F4(int x, int y, int z)
		{
			return (x & z) | (y & ~z);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000E734F File Offset: 0x000E554F
		private int F1(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F1(b, c, d) + x, s);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000E7368 File Offset: 0x000E5568
		private int F2(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F2(b, c, d) + x + 1518500249, s);
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x000E7387 File Offset: 0x000E5587
		private int F3(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F3(b, c, d) + x + 1859775393, s);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x000E73A6 File Offset: 0x000E55A6
		private int F4(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F4(b, c, d) + x + -1894007588, s);
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x000E73C5 File Offset: 0x000E55C5
		private int FF1(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F1(b, c, d) + x, s);
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x000E73DE File Offset: 0x000E55DE
		private int FF2(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F2(b, c, d) + x + 1836072691, s);
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000E73FD File Offset: 0x000E55FD
		private int FF3(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F3(b, c, d) + x + 1548603684, s);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000E741C File Offset: 0x000E561C
		private int FF4(int a, int b, int c, int d, int x, int s)
		{
			return this.RL(a + this.F4(b, c, d) + x + 1352829926, s);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000E743C File Offset: 0x000E563C
		internal override void ProcessBlock()
		{
			int a = this.H0;
			int b = this.H1;
			int c = this.H2;
			int d = this.H3;
			int aa = this.H4;
			int bb = this.H5;
			int cc = this.H6;
			int dd = this.H7;
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
			int num = a;
			a = aa;
			aa = num;
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
			int num2 = b;
			b = bb;
			bb = num2;
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
			int num3 = c;
			c = cc;
			cc = num3;
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
			int num4 = d;
			d = dd;
			dd = num4;
			this.H0 += a;
			this.H1 += b;
			this.H2 += c;
			this.H3 += d;
			this.H4 += aa;
			this.H5 += bb;
			this.H6 += cc;
			this.H7 += dd;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x000E80FF File Offset: 0x000E62FF
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest(this);
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x000E8108 File Offset: 0x000E6308
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest d = (global::Org.BouncyCastle.Crypto.Digests.RipeMD256Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001521 RID: 5409
		private const int DigestLength = 32;

		// Token: 0x04001522 RID: 5410
		private int H0;

		// Token: 0x04001523 RID: 5411
		private int H1;

		// Token: 0x04001524 RID: 5412
		private int H2;

		// Token: 0x04001525 RID: 5413
		private int H3;

		// Token: 0x04001526 RID: 5414
		private int H4;

		// Token: 0x04001527 RID: 5415
		private int H5;

		// Token: 0x04001528 RID: 5416
		private int H6;

		// Token: 0x04001529 RID: 5417
		private int H7;

		// Token: 0x0400152A RID: 5418
		private int[] X = new int[16];

		// Token: 0x0400152B RID: 5419
		private int xOff;
	}
}
