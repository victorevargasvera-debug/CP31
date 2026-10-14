using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DB RID: 1243
	public class RipeMD320Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x000E8123 File Offset: 0x000E6323
		public override string AlgorithmName
		{
			get
			{
				return "RIPEMD320";
			}
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x000E812A File Offset: 0x000E632A
		public override int GetDigestSize()
		{
			return 40;
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x000E812E File Offset: 0x000E632E
		public RipeMD320Digest()
		{
			this.Reset();
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x000E8149 File Offset: 0x000E6349
		public RipeMD320Digest(global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x000E8168 File Offset: 0x000E6368
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest t)
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
			this.H8 = t.H8;
			this.H9 = t.H9;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x000E821C File Offset: 0x000E641C
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

		// Token: 0x060030C4 RID: 12484 RVA: 0x000E8286 File Offset: 0x000E6486
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (int)(bitLength & (long)((ulong)-1));
			this.X[15] = (int)((ulong)bitLength >> 32);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000E82B4 File Offset: 0x000E64B4
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
			outBytes[outOff] = (byte)word;
			outBytes[outOff + 1] = (byte)((uint)word >> 8);
			outBytes[outOff + 2] = (byte)((uint)word >> 16);
			outBytes[outOff + 3] = (byte)((uint)word >> 24);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000E82D8 File Offset: 0x000E64D8
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
			this.UnpackWord(this.H8, output, outOff + 32);
			this.UnpackWord(this.H9, output, outOff + 36);
			this.Reset();
			return 40;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000E8398 File Offset: 0x000E6598
		public override void Reset()
		{
			base.Reset();
			this.H0 = 1732584193;
			this.H1 = -271733879;
			this.H2 = -1732584194;
			this.H3 = 271733878;
			this.H4 = -1009589776;
			this.H5 = 1985229328;
			this.H6 = -19088744;
			this.H7 = -1985229329;
			this.H8 = 19088743;
			this.H9 = 1009589775;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000E843C File Offset: 0x000E663C
		private int RL(int x, int n)
		{
			return x << n | (int)((uint)x >> 32 - n);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000E844E File Offset: 0x000E664E
		private int F1(int x, int y, int z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000E8455 File Offset: 0x000E6655
		private int F2(int x, int y, int z)
		{
			return (x & y) | (~x & z);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000E845F File Offset: 0x000E665F
		private int F3(int x, int y, int z)
		{
			return (x | ~y) ^ z;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000E8467 File Offset: 0x000E6667
		private int F4(int x, int y, int z)
		{
			return (x & z) | (y & ~z);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000E8471 File Offset: 0x000E6671
		private int F5(int x, int y, int z)
		{
			return x ^ (y | ~z);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000E847C File Offset: 0x000E667C
		internal override void ProcessBlock()
		{
			int a = this.H0;
			int b = this.H1;
			int c = this.H2;
			int d = this.H3;
			int e = this.H4;
			int aa = this.H5;
			int bb = this.H6;
			int cc = this.H7;
			int dd = this.H8;
			int ee = this.H9;
			a = this.RL(a + this.F1(b, c, d) + this.X[0], 11) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F1(a, b, c) + this.X[1], 14) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F1(e, a, b) + this.X[2], 15) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F1(d, e, a) + this.X[3], 12) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F1(c, d, e) + this.X[4], 5) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F1(b, c, d) + this.X[5], 8) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F1(a, b, c) + this.X[6], 7) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F1(e, a, b) + this.X[7], 9) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F1(d, e, a) + this.X[8], 11) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F1(c, d, e) + this.X[9], 13) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F1(b, c, d) + this.X[10], 14) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F1(a, b, c) + this.X[11], 15) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F1(e, a, b) + this.X[12], 6) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F1(d, e, a) + this.X[13], 7) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F1(c, d, e) + this.X[14], 9) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F1(b, c, d) + this.X[15], 8) + e;
			c = this.RL(c, 10);
			aa = this.RL(aa + this.F5(bb, cc, dd) + this.X[5] + 1352829926, 8) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F5(aa, bb, cc) + this.X[14] + 1352829926, 9) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F5(ee, aa, bb) + this.X[7] + 1352829926, 9) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F5(dd, ee, aa) + this.X[0] + 1352829926, 11) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F5(cc, dd, ee) + this.X[9] + 1352829926, 13) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F5(bb, cc, dd) + this.X[2] + 1352829926, 15) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F5(aa, bb, cc) + this.X[11] + 1352829926, 15) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F5(ee, aa, bb) + this.X[4] + 1352829926, 5) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F5(dd, ee, aa) + this.X[13] + 1352829926, 7) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F5(cc, dd, ee) + this.X[6] + 1352829926, 7) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F5(bb, cc, dd) + this.X[15] + 1352829926, 8) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F5(aa, bb, cc) + this.X[8] + 1352829926, 11) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F5(ee, aa, bb) + this.X[1] + 1352829926, 14) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F5(dd, ee, aa) + this.X[10] + 1352829926, 14) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F5(cc, dd, ee) + this.X[3] + 1352829926, 12) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F5(bb, cc, dd) + this.X[12] + 1352829926, 6) + ee;
			cc = this.RL(cc, 10);
			int num = a;
			a = aa;
			aa = num;
			e = this.RL(e + this.F2(a, b, c) + this.X[7] + 1518500249, 7) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F2(e, a, b) + this.X[4] + 1518500249, 6) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F2(d, e, a) + this.X[13] + 1518500249, 8) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F2(c, d, e) + this.X[1] + 1518500249, 13) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F2(b, c, d) + this.X[10] + 1518500249, 11) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F2(a, b, c) + this.X[6] + 1518500249, 9) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F2(e, a, b) + this.X[15] + 1518500249, 7) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F2(d, e, a) + this.X[3] + 1518500249, 15) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F2(c, d, e) + this.X[12] + 1518500249, 7) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F2(b, c, d) + this.X[0] + 1518500249, 12) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F2(a, b, c) + this.X[9] + 1518500249, 15) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F2(e, a, b) + this.X[5] + 1518500249, 9) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F2(d, e, a) + this.X[2] + 1518500249, 11) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F2(c, d, e) + this.X[14] + 1518500249, 7) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F2(b, c, d) + this.X[11] + 1518500249, 13) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F2(a, b, c) + this.X[8] + 1518500249, 12) + d;
			b = this.RL(b, 10);
			ee = this.RL(ee + this.F4(aa, bb, cc) + this.X[6] + 1548603684, 9) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F4(ee, aa, bb) + this.X[11] + 1548603684, 13) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F4(dd, ee, aa) + this.X[3] + 1548603684, 15) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F4(cc, dd, ee) + this.X[7] + 1548603684, 7) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F4(bb, cc, dd) + this.X[0] + 1548603684, 12) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F4(aa, bb, cc) + this.X[13] + 1548603684, 8) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F4(ee, aa, bb) + this.X[5] + 1548603684, 9) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F4(dd, ee, aa) + this.X[10] + 1548603684, 11) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F4(cc, dd, ee) + this.X[14] + 1548603684, 7) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F4(bb, cc, dd) + this.X[15] + 1548603684, 7) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F4(aa, bb, cc) + this.X[8] + 1548603684, 12) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F4(ee, aa, bb) + this.X[12] + 1548603684, 7) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F4(dd, ee, aa) + this.X[4] + 1548603684, 6) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F4(cc, dd, ee) + this.X[9] + 1548603684, 15) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F4(bb, cc, dd) + this.X[1] + 1548603684, 13) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F4(aa, bb, cc) + this.X[2] + 1548603684, 11) + dd;
			bb = this.RL(bb, 10);
			int num2 = b;
			b = bb;
			bb = num2;
			d = this.RL(d + this.F3(e, a, b) + this.X[3] + 1859775393, 11) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F3(d, e, a) + this.X[10] + 1859775393, 13) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F3(c, d, e) + this.X[14] + 1859775393, 6) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F3(b, c, d) + this.X[4] + 1859775393, 7) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F3(a, b, c) + this.X[9] + 1859775393, 14) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F3(e, a, b) + this.X[15] + 1859775393, 9) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F3(d, e, a) + this.X[8] + 1859775393, 13) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F3(c, d, e) + this.X[1] + 1859775393, 15) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F3(b, c, d) + this.X[2] + 1859775393, 14) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F3(a, b, c) + this.X[7] + 1859775393, 8) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F3(e, a, b) + this.X[0] + 1859775393, 13) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F3(d, e, a) + this.X[6] + 1859775393, 6) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F3(c, d, e) + this.X[13] + 1859775393, 5) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F3(b, c, d) + this.X[11] + 1859775393, 12) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F3(a, b, c) + this.X[5] + 1859775393, 7) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F3(e, a, b) + this.X[12] + 1859775393, 5) + c;
			a = this.RL(a, 10);
			dd = this.RL(dd + this.F3(ee, aa, bb) + this.X[15] + 1836072691, 9) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F3(dd, ee, aa) + this.X[5] + 1836072691, 7) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F3(cc, dd, ee) + this.X[1] + 1836072691, 15) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F3(bb, cc, dd) + this.X[3] + 1836072691, 11) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F3(aa, bb, cc) + this.X[7] + 1836072691, 8) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F3(ee, aa, bb) + this.X[14] + 1836072691, 6) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F3(dd, ee, aa) + this.X[6] + 1836072691, 6) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F3(cc, dd, ee) + this.X[9] + 1836072691, 14) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F3(bb, cc, dd) + this.X[11] + 1836072691, 12) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F3(aa, bb, cc) + this.X[8] + 1836072691, 13) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F3(ee, aa, bb) + this.X[12] + 1836072691, 5) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F3(dd, ee, aa) + this.X[2] + 1836072691, 14) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F3(cc, dd, ee) + this.X[10] + 1836072691, 13) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F3(bb, cc, dd) + this.X[0] + 1836072691, 13) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F3(aa, bb, cc) + this.X[4] + 1836072691, 7) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F3(ee, aa, bb) + this.X[13] + 1836072691, 5) + cc;
			aa = this.RL(aa, 10);
			int num3 = c;
			c = cc;
			cc = num3;
			c = this.RL(c + this.F4(d, e, a) + this.X[1] + -1894007588, 11) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F4(c, d, e) + this.X[9] + -1894007588, 12) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F4(b, c, d) + this.X[11] + -1894007588, 14) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F4(a, b, c) + this.X[10] + -1894007588, 15) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F4(e, a, b) + this.X[0] + -1894007588, 14) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F4(d, e, a) + this.X[8] + -1894007588, 15) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F4(c, d, e) + this.X[12] + -1894007588, 9) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F4(b, c, d) + this.X[4] + -1894007588, 8) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F4(a, b, c) + this.X[13] + -1894007588, 9) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F4(e, a, b) + this.X[3] + -1894007588, 14) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F4(d, e, a) + this.X[7] + -1894007588, 5) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F4(c, d, e) + this.X[15] + -1894007588, 6) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F4(b, c, d) + this.X[14] + -1894007588, 8) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F4(a, b, c) + this.X[5] + -1894007588, 6) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F4(e, a, b) + this.X[6] + -1894007588, 5) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F4(d, e, a) + this.X[2] + -1894007588, 12) + b;
			e = this.RL(e, 10);
			cc = this.RL(cc + this.F2(dd, ee, aa) + this.X[8] + 2053994217, 15) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F2(cc, dd, ee) + this.X[6] + 2053994217, 5) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F2(bb, cc, dd) + this.X[4] + 2053994217, 8) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F2(aa, bb, cc) + this.X[1] + 2053994217, 11) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F2(ee, aa, bb) + this.X[3] + 2053994217, 14) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F2(dd, ee, aa) + this.X[11] + 2053994217, 14) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F2(cc, dd, ee) + this.X[15] + 2053994217, 6) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F2(bb, cc, dd) + this.X[0] + 2053994217, 14) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F2(aa, bb, cc) + this.X[5] + 2053994217, 6) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F2(ee, aa, bb) + this.X[12] + 2053994217, 9) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F2(dd, ee, aa) + this.X[2] + 2053994217, 12) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F2(cc, dd, ee) + this.X[13] + 2053994217, 9) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F2(bb, cc, dd) + this.X[9] + 2053994217, 12) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F2(aa, bb, cc) + this.X[7] + 2053994217, 5) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F2(ee, aa, bb) + this.X[10] + 2053994217, 15) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F2(dd, ee, aa) + this.X[14] + 2053994217, 8) + bb;
			ee = this.RL(ee, 10);
			int num4 = d;
			d = dd;
			dd = num4;
			b = this.RL(b + this.F5(c, d, e) + this.X[4] + -1454113458, 9) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F5(b, c, d) + this.X[0] + -1454113458, 15) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F5(a, b, c) + this.X[5] + -1454113458, 5) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F5(e, a, b) + this.X[9] + -1454113458, 11) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F5(d, e, a) + this.X[7] + -1454113458, 6) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F5(c, d, e) + this.X[12] + -1454113458, 8) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F5(b, c, d) + this.X[2] + -1454113458, 13) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F5(a, b, c) + this.X[10] + -1454113458, 12) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F5(e, a, b) + this.X[14] + -1454113458, 5) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F5(d, e, a) + this.X[1] + -1454113458, 12) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F5(c, d, e) + this.X[3] + -1454113458, 13) + a;
			d = this.RL(d, 10);
			a = this.RL(a + this.F5(b, c, d) + this.X[8] + -1454113458, 14) + e;
			c = this.RL(c, 10);
			e = this.RL(e + this.F5(a, b, c) + this.X[11] + -1454113458, 11) + d;
			b = this.RL(b, 10);
			d = this.RL(d + this.F5(e, a, b) + this.X[6] + -1454113458, 8) + c;
			a = this.RL(a, 10);
			c = this.RL(c + this.F5(d, e, a) + this.X[15] + -1454113458, 5) + b;
			e = this.RL(e, 10);
			b = this.RL(b + this.F5(c, d, e) + this.X[13] + -1454113458, 6) + a;
			d = this.RL(d, 10);
			bb = this.RL(bb + this.F1(cc, dd, ee) + this.X[12], 8) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F1(bb, cc, dd) + this.X[15], 5) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F1(aa, bb, cc) + this.X[10], 12) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F1(ee, aa, bb) + this.X[4], 9) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F1(dd, ee, aa) + this.X[1], 12) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F1(cc, dd, ee) + this.X[5], 5) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F1(bb, cc, dd) + this.X[8], 14) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F1(aa, bb, cc) + this.X[7], 6) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F1(ee, aa, bb) + this.X[6], 8) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F1(dd, ee, aa) + this.X[2], 13) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F1(cc, dd, ee) + this.X[13], 6) + aa;
			dd = this.RL(dd, 10);
			aa = this.RL(aa + this.F1(bb, cc, dd) + this.X[14], 5) + ee;
			cc = this.RL(cc, 10);
			ee = this.RL(ee + this.F1(aa, bb, cc) + this.X[0], 15) + dd;
			bb = this.RL(bb, 10);
			dd = this.RL(dd + this.F1(ee, aa, bb) + this.X[3], 13) + cc;
			aa = this.RL(aa, 10);
			cc = this.RL(cc + this.F1(dd, ee, aa) + this.X[9], 11) + bb;
			ee = this.RL(ee, 10);
			bb = this.RL(bb + this.F1(cc, dd, ee) + this.X[11], 11) + aa;
			dd = this.RL(dd, 10);
			this.H0 += a;
			this.H1 += b;
			this.H2 += c;
			this.H3 += d;
			this.H4 += ee;
			this.H5 += aa;
			this.H6 += bb;
			this.H7 += cc;
			this.H8 += dd;
			this.H9 += e;
			this.xOff = 0;
			for (int i = 0; i != this.X.Length; i++)
			{
				this.X[i] = 0;
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000EA54D File Offset: 0x000E874D
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest(this);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000EA558 File Offset: 0x000E8758
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest d = (global::Org.BouncyCastle.Crypto.Digests.RipeMD320Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x0400152C RID: 5420
		private const int DigestLength = 40;

		// Token: 0x0400152D RID: 5421
		private int H0;

		// Token: 0x0400152E RID: 5422
		private int H1;

		// Token: 0x0400152F RID: 5423
		private int H2;

		// Token: 0x04001530 RID: 5424
		private int H3;

		// Token: 0x04001531 RID: 5425
		private int H4;

		// Token: 0x04001532 RID: 5426
		private int H5;

		// Token: 0x04001533 RID: 5427
		private int H6;

		// Token: 0x04001534 RID: 5428
		private int H7;

		// Token: 0x04001535 RID: 5429
		private int H8;

		// Token: 0x04001536 RID: 5430
		private int H9;

		// Token: 0x04001537 RID: 5431
		private int[] X = new int[16];

		// Token: 0x04001538 RID: 5432
		private int xOff;
	}
}
