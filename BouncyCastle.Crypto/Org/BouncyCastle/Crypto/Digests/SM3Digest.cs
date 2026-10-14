using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E7 RID: 1255
	public class SM3Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x0600315F RID: 12639 RVA: 0x000ECC8C File Offset: 0x000EAE8C
		static SM3Digest()
		{
			for (int i = 0; i < 16; i++)
			{
				uint t = 2043430169U;
				global::Org.BouncyCastle.Crypto.Digests.SM3Digest.T[i] = (t << i | t >> 32 - i);
			}
			for (int j = 16; j < 64; j++)
			{
				int k = j % 32;
				uint t2 = 2055708042U;
				global::Org.BouncyCastle.Crypto.Digests.SM3Digest.T[j] = (t2 << k | t2 >> 32 - k);
			}
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000ECD02 File Offset: 0x000EAF02
		public SM3Digest()
		{
			this.Reset();
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000ECD36 File Offset: 0x000EAF36
		public SM3Digest(global::Org.BouncyCastle.Crypto.Digests.SM3Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000ECD6C File Offset: 0x000EAF6C
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.SM3Digest t)
		{
			global::System.Array.Copy(t.V, 0, this.V, 0, this.V.Length);
			global::System.Array.Copy(t.inwords, 0, this.inwords, 0, this.inwords.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x000ECDBB File Offset: 0x000EAFBB
		public override string AlgorithmName
		{
			get
			{
				return "SM3";
			}
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000ECDC2 File Offset: 0x000EAFC2
		public override int GetDigestSize()
		{
			return 32;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000ECDC6 File Offset: 0x000EAFC6
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.SM3Digest(this);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000ECDD0 File Offset: 0x000EAFD0
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.SM3Digest d = (global::Org.BouncyCastle.Crypto.Digests.SM3Digest)other;
			base.CopyIn(d);
			this.CopyIn(d);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000ECDF4 File Offset: 0x000EAFF4
		public override void Reset()
		{
			base.Reset();
			this.V[0] = 1937774191U;
			this.V[1] = 1226093241U;
			this.V[2] = 388252375U;
			this.V[3] = 3666478592U;
			this.V[4] = 2842636476U;
			this.V[5] = 372324522U;
			this.V[6] = 3817729613U;
			this.V[7] = 2969243214U;
			this.xOff = 0;
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000ECE76 File Offset: 0x000EB076
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.V, output, outOff);
			this.Reset();
			return 32;
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000ECE94 File Offset: 0x000EB094
		internal override void ProcessWord(byte[] input, int inOff)
		{
			uint i = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			this.inwords[this.xOff] = i;
			this.xOff++;
			if (this.xOff >= 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000ECED8 File Offset: 0x000EB0D8
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.inwords[this.xOff] = 0U;
				this.xOff++;
				this.ProcessBlock();
			}
			while (this.xOff < 14)
			{
				this.inwords[this.xOff] = 0U;
				this.xOff++;
			}
			uint[] array = this.inwords;
			int num = this.xOff;
			this.xOff = num + 1;
			array[num] = (uint)(bitLength >> 32);
			uint[] array2 = this.inwords;
			num = this.xOff;
			this.xOff = num + 1;
			array2[num] = (uint)bitLength;
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000ECF70 File Offset: 0x000EB170
		private uint P0(uint x)
		{
			uint r9 = x << 9 | x >> 23;
			uint r10 = x << 17 | x >> 15;
			return x ^ r9 ^ r10;
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000ECF98 File Offset: 0x000EB198
		private uint P1(uint x)
		{
			uint r15 = x << 15 | x >> 17;
			uint r16 = x << 23 | x >> 9;
			return x ^ r15 ^ r16;
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000ECFBE File Offset: 0x000EB1BE
		private uint FF0(uint x, uint y, uint z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000ECFC5 File Offset: 0x000EB1C5
		private uint FF1(uint x, uint y, uint z)
		{
			return (x & y) | (x & z) | (y & z);
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000ECFD2 File Offset: 0x000EB1D2
		private uint GG0(uint x, uint y, uint z)
		{
			return x ^ y ^ z;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000ECFD9 File Offset: 0x000EB1D9
		private uint GG1(uint x, uint y, uint z)
		{
			return (x & y) | (~x & z);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000ECFE4 File Offset: 0x000EB1E4
		internal override void ProcessBlock()
		{
			for (int i = 0; i < 16; i++)
			{
				this.W[i] = this.inwords[i];
			}
			for (int j = 16; j < 68; j++)
			{
				uint wj3 = this.W[j - 3];
				uint r15 = wj3 << 15 | wj3 >> 17;
				uint wj4 = this.W[j - 13];
				uint r16 = wj4 << 7 | wj4 >> 25;
				this.W[j] = (this.P1(this.W[j - 16] ^ this.W[j - 9] ^ r15) ^ r16 ^ this.W[j - 6]);
			}
			uint A = this.V[0];
			uint B = this.V[1];
			uint C = this.V[2];
			uint D = this.V[3];
			uint E = this.V[4];
			uint F = this.V[5];
			uint G = this.V[6];
			uint H = this.V[7];
			for (int k = 0; k < 16; k++)
			{
				uint a12 = A << 12 | A >> 20;
				uint s1_ = a12 + E + global::Org.BouncyCastle.Crypto.Digests.SM3Digest.T[k];
				uint SS = s1_ << 7 | s1_ >> 25;
				uint SS2 = SS ^ a12;
				uint Wj = this.W[k];
				uint W1j = Wj ^ this.W[k + 4];
				uint num = this.FF0(A, B, C) + D + SS2 + W1j;
				uint TT2 = this.GG0(E, F, G) + H + SS + Wj;
				D = C;
				C = (B << 9 | B >> 23);
				B = A;
				A = num;
				H = G;
				G = (F << 19 | F >> 13);
				F = E;
				E = this.P0(TT2);
			}
			for (int l = 16; l < 64; l++)
			{
				uint a13 = A << 12 | A >> 20;
				uint s1_2 = a13 + E + global::Org.BouncyCastle.Crypto.Digests.SM3Digest.T[l];
				uint SS3 = s1_2 << 7 | s1_2 >> 25;
				uint SS4 = SS3 ^ a13;
				uint Wj2 = this.W[l];
				uint W1j2 = Wj2 ^ this.W[l + 4];
				uint num2 = this.FF1(A, B, C) + D + SS4 + W1j2;
				uint TT3 = this.GG1(E, F, G) + H + SS3 + Wj2;
				D = C;
				C = (B << 9 | B >> 23);
				B = A;
				A = num2;
				H = G;
				G = (F << 19 | F >> 13);
				F = E;
				E = this.P0(TT3);
			}
			this.V[0] ^= A;
			this.V[1] ^= B;
			this.V[2] ^= C;
			this.V[3] ^= D;
			this.V[4] ^= E;
			this.V[5] ^= F;
			this.V[6] ^= G;
			this.V[7] ^= H;
			this.xOff = 0;
		}

		// Token: 0x04001580 RID: 5504
		private const int DIGEST_LENGTH = 32;

		// Token: 0x04001581 RID: 5505
		private const int BLOCK_SIZE = 16;

		// Token: 0x04001582 RID: 5506
		private uint[] V = new uint[8];

		// Token: 0x04001583 RID: 5507
		private uint[] inwords = new uint[16];

		// Token: 0x04001584 RID: 5508
		private int xOff;

		// Token: 0x04001585 RID: 5509
		private uint[] W = new uint[68];

		// Token: 0x04001586 RID: 5510
		private static readonly uint[] T = new uint[64];
	}
}
