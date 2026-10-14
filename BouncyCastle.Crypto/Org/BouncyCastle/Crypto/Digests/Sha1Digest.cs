using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DC RID: 1244
	public class Sha1Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x060030D1 RID: 12497 RVA: 0x000EA573 File Offset: 0x000E8773
		public Sha1Digest()
		{
			this.Reset();
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000EA58E File Offset: 0x000E878E
		public Sha1Digest(global::Org.BouncyCastle.Crypto.Digests.Sha1Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000EA5AC File Offset: 0x000E87AC
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.Sha1Digest t)
		{
			base.CopyIn(t);
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			this.H5 = t.H5;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x000EA623 File Offset: 0x000E8823
		public override string AlgorithmName
		{
			get
			{
				return "SHA-1";
			}
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000EA62A File Offset: 0x000E882A
		public override int GetDigestSize()
		{
			return 20;
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000EA630 File Offset: 0x000E8830
		internal override void ProcessWord(byte[] input, int inOff)
		{
			this.X[this.xOff] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			int num = this.xOff + 1;
			this.xOff = num;
			if (num == 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000EA66C File Offset: 0x000E886C
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (uint)((ulong)bitLength >> 32);
			this.X[15] = (uint)bitLength;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000EA698 File Offset: 0x000E8898
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H1, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H2, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H3, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H4, output, outOff + 12);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H5, output, outOff + 16);
			this.Reset();
			return 20;
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x000EA700 File Offset: 0x000E8900
		public override void Reset()
		{
			base.Reset();
			this.H1 = 1732584193U;
			this.H2 = 4023233417U;
			this.H3 = 2562383102U;
			this.H4 = 271733878U;
			this.H5 = 3285377520U;
			this.xOff = 0;
			global::System.Array.Clear(this.X, 0, this.X.Length);
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000EA765 File Offset: 0x000E8965
		private static uint F(uint u, uint v, uint w)
		{
			return (u & v) | (~u & w);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000EA76F File Offset: 0x000E896F
		private static uint H(uint u, uint v, uint w)
		{
			return u ^ v ^ w;
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000EA776 File Offset: 0x000E8976
		private static uint G(uint u, uint v, uint w)
		{
			return (u & v) | (u & w) | (v & w);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000EA784 File Offset: 0x000E8984
		internal override void ProcessBlock()
		{
			for (int i = 16; i < 80; i++)
			{
				uint t = this.X[i - 3] ^ this.X[i - 8] ^ this.X[i - 14] ^ this.X[i - 16];
				this.X[i] = (t << 1 | t >> 31);
			}
			uint A = this.H1;
			uint B = this.H2;
			uint C = this.H3;
			uint D = this.H4;
			uint E = this.H5;
			int idx = 0;
			for (int j = 0; j < 4; j++)
			{
				E += (A << 5 | A >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.F(B, C, D) + this.X[idx++] + 1518500249U;
				B = (B << 30 | B >> 2);
				D += (E << 5 | E >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.F(A, B, C) + this.X[idx++] + 1518500249U;
				A = (A << 30 | A >> 2);
				C += (D << 5 | D >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.F(E, A, B) + this.X[idx++] + 1518500249U;
				E = (E << 30 | E >> 2);
				B += (C << 5 | C >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.F(D, E, A) + this.X[idx++] + 1518500249U;
				D = (D << 30 | D >> 2);
				A += (B << 5 | B >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.F(C, D, E) + this.X[idx++] + 1518500249U;
				C = (C << 30 | C >> 2);
			}
			for (int k = 0; k < 4; k++)
			{
				E += (A << 5 | A >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(B, C, D) + this.X[idx++] + 1859775393U;
				B = (B << 30 | B >> 2);
				D += (E << 5 | E >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(A, B, C) + this.X[idx++] + 1859775393U;
				A = (A << 30 | A >> 2);
				C += (D << 5 | D >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(E, A, B) + this.X[idx++] + 1859775393U;
				E = (E << 30 | E >> 2);
				B += (C << 5 | C >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(D, E, A) + this.X[idx++] + 1859775393U;
				D = (D << 30 | D >> 2);
				A += (B << 5 | B >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(C, D, E) + this.X[idx++] + 1859775393U;
				C = (C << 30 | C >> 2);
			}
			for (int l = 0; l < 4; l++)
			{
				E += (A << 5 | A >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.G(B, C, D) + this.X[idx++] + 2400959708U;
				B = (B << 30 | B >> 2);
				D += (E << 5 | E >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.G(A, B, C) + this.X[idx++] + 2400959708U;
				A = (A << 30 | A >> 2);
				C += (D << 5 | D >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.G(E, A, B) + this.X[idx++] + 2400959708U;
				E = (E << 30 | E >> 2);
				B += (C << 5 | C >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.G(D, E, A) + this.X[idx++] + 2400959708U;
				D = (D << 30 | D >> 2);
				A += (B << 5 | B >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.G(C, D, E) + this.X[idx++] + 2400959708U;
				C = (C << 30 | C >> 2);
			}
			for (int m = 0; m < 4; m++)
			{
				E += (A << 5 | A >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(B, C, D) + this.X[idx++] + 3395469782U;
				B = (B << 30 | B >> 2);
				D += (E << 5 | E >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(A, B, C) + this.X[idx++] + 3395469782U;
				A = (A << 30 | A >> 2);
				C += (D << 5 | D >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(E, A, B) + this.X[idx++] + 3395469782U;
				E = (E << 30 | E >> 2);
				B += (C << 5 | C >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(D, E, A) + this.X[idx++] + 3395469782U;
				D = (D << 30 | D >> 2);
				A += (B << 5 | B >> 27) + global::Org.BouncyCastle.Crypto.Digests.Sha1Digest.H(C, D, E) + this.X[idx++] + 3395469782U;
				C = (C << 30 | C >> 2);
			}
			this.H1 += A;
			this.H2 += B;
			this.H3 += C;
			this.H4 += D;
			this.H5 += E;
			this.xOff = 0;
			global::System.Array.Clear(this.X, 0, 16);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000EACD4 File Offset: 0x000E8ED4
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest(this);
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000EACDC File Offset: 0x000E8EDC
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha1Digest d = (global::Org.BouncyCastle.Crypto.Digests.Sha1Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001539 RID: 5433
		private const int DigestLength = 20;

		// Token: 0x0400153A RID: 5434
		private uint H1;

		// Token: 0x0400153B RID: 5435
		private uint H2;

		// Token: 0x0400153C RID: 5436
		private uint H3;

		// Token: 0x0400153D RID: 5437
		private uint H4;

		// Token: 0x0400153E RID: 5438
		private uint H5;

		// Token: 0x0400153F RID: 5439
		private uint[] X = new uint[80];

		// Token: 0x04001540 RID: 5440
		private int xOff;

		// Token: 0x04001541 RID: 5441
		private const uint Y1 = 1518500249U;

		// Token: 0x04001542 RID: 5442
		private const uint Y2 = 1859775393U;

		// Token: 0x04001543 RID: 5443
		private const uint Y3 = 2400959708U;

		// Token: 0x04001544 RID: 5444
		private const uint Y4 = 3395469782U;
	}
}
