using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E2 RID: 1250
	public class Sha512tDigest : global::Org.BouncyCastle.Crypto.Digests.LongDigest
	{
		// Token: 0x0600311D RID: 12573 RVA: 0x000EBD84 File Offset: 0x000E9F84
		public Sha512tDigest(int bitLength)
		{
			if (bitLength >= 512)
			{
				throw new global::System.ArgumentException("cannot be >= 512", "bitLength");
			}
			if (bitLength % 8 != 0)
			{
				throw new global::System.ArgumentException("needs to be a multiple of 8", "bitLength");
			}
			if (bitLength == 384)
			{
				throw new global::System.ArgumentException("cannot be 384 use SHA384 instead", "bitLength");
			}
			this.digestLength = bitLength / 8;
			this.tIvGenerate(this.digestLength * 8);
			this.Reset();
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000EBDF9 File Offset: 0x000E9FF9
		public Sha512tDigest(global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest t) : base(t)
		{
			this.digestLength = t.digestLength;
			this.Reset(t);
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x000EBE18 File Offset: 0x000EA018
		public override string AlgorithmName
		{
			get
			{
				return "SHA-512/" + (this.digestLength * 8).ToString();
			}
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000EBE3F File Offset: 0x000EA03F
		public override int GetDigestSize()
		{
			return this.digestLength;
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000EBE48 File Offset: 0x000EA048
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H1, output, outOff, this.digestLength);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H2, output, outOff + 8, this.digestLength - 8);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H3, output, outOff + 16, this.digestLength - 16);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H4, output, outOff + 24, this.digestLength - 24);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H5, output, outOff + 32, this.digestLength - 32);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H6, output, outOff + 40, this.digestLength - 40);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H7, output, outOff + 48, this.digestLength - 48);
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt64_To_BE(this.H8, output, outOff + 56, this.digestLength - 56);
			this.Reset();
			return this.digestLength;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000EBF28 File Offset: 0x000EA128
		public override void Reset()
		{
			base.Reset();
			this.H1 = this.H1t;
			this.H2 = this.H2t;
			this.H3 = this.H3t;
			this.H4 = this.H4t;
			this.H5 = this.H5t;
			this.H6 = this.H6t;
			this.H7 = this.H7t;
			this.H8 = this.H8t;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000EBF9C File Offset: 0x000EA19C
		private void tIvGenerate(int bitLength)
		{
			this.H1 = 14964410163792538797UL;
			this.H2 = 2216346199247487646UL;
			this.H3 = 11082046791023156622UL;
			this.H4 = 65953792586715988UL;
			this.H5 = 17630457682085488500UL;
			this.H6 = 4512832404995164602UL;
			this.H7 = 13413544941332994254UL;
			this.H8 = 18322165818757711068UL;
			base.Update(83);
			base.Update(72);
			base.Update(65);
			base.Update(45);
			base.Update(53);
			base.Update(49);
			base.Update(50);
			base.Update(47);
			if (bitLength > 100)
			{
				base.Update((byte)(bitLength / 100 + 48));
				bitLength %= 100;
				base.Update((byte)(bitLength / 10 + 48));
				bitLength %= 10;
				base.Update((byte)(bitLength + 48));
			}
			else if (bitLength > 10)
			{
				base.Update((byte)(bitLength / 10 + 48));
				bitLength %= 10;
				base.Update((byte)(bitLength + 48));
			}
			else
			{
				base.Update((byte)(bitLength + 48));
			}
			base.Finish();
			this.H1t = this.H1;
			this.H2t = this.H2;
			this.H3t = this.H3;
			this.H4t = this.H4;
			this.H5t = this.H5;
			this.H6t = this.H6;
			this.H7t = this.H7;
			this.H8t = this.H8;
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000EC132 File Offset: 0x000EA332
		private static void UInt64_To_BE(ulong n, byte[] bs, int off, int max)
		{
			if (max > 0)
			{
				global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt32_To_BE((uint)(n >> 32), bs, off, max);
				if (max > 4)
				{
					global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest.UInt32_To_BE((uint)n, bs, off + 4, max - 4);
				}
			}
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000EC158 File Offset: 0x000EA358
		private static void UInt32_To_BE(uint n, byte[] bs, int off, int max)
		{
			int num = global::System.Math.Min(4, max);
			while (--num >= 0)
			{
				int shift = 8 * (3 - num);
				bs[off + num] = (byte)(n >> shift);
			}
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000EC189 File Offset: 0x000EA389
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest(this);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000EC194 File Offset: 0x000EA394
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest t = (global::Org.BouncyCastle.Crypto.Digests.Sha512tDigest)other;
			if (this.digestLength != t.digestLength)
			{
				throw new global::Org.BouncyCastle.Utilities.MemoableResetException("digestLength inappropriate in other");
			}
			base.CopyIn(t);
			this.H1t = t.H1t;
			this.H2t = t.H2t;
			this.H3t = t.H3t;
			this.H4t = t.H4t;
			this.H5t = t.H5t;
			this.H6t = t.H6t;
			this.H7t = t.H7t;
			this.H8t = t.H8t;
		}

		// Token: 0x0400155F RID: 5471
		private const ulong A5 = 11936128518282651045UL;

		// Token: 0x04001560 RID: 5472
		private readonly int digestLength;

		// Token: 0x04001561 RID: 5473
		private ulong H1t;

		// Token: 0x04001562 RID: 5474
		private ulong H2t;

		// Token: 0x04001563 RID: 5475
		private ulong H3t;

		// Token: 0x04001564 RID: 5476
		private ulong H4t;

		// Token: 0x04001565 RID: 5477
		private ulong H5t;

		// Token: 0x04001566 RID: 5478
		private ulong H6t;

		// Token: 0x04001567 RID: 5479
		private ulong H7t;

		// Token: 0x04001568 RID: 5480
		private ulong H8t;
	}
}
