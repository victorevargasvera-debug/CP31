using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E3 RID: 1251
	public class ShakeDigest : global::Org.BouncyCastle.Crypto.Digests.KeccakDigest, global::Org.BouncyCastle.Crypto.IXof, global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06003128 RID: 12584 RVA: 0x000EC228 File Offset: 0x000EA428
		private static int CheckBitLength(int bitLength)
		{
			if (bitLength == 128 || bitLength == 256)
			{
				return bitLength;
			}
			throw new global::System.ArgumentException(bitLength.ToString() + " not supported for SHAKE", "bitLength");
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000EC257 File Offset: 0x000EA457
		public ShakeDigest() : this(128)
		{
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000EC264 File Offset: 0x000EA464
		public ShakeDigest(int bitLength) : base(global::Org.BouncyCastle.Crypto.Digests.ShakeDigest.CheckBitLength(bitLength))
		{
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000EC272 File Offset: 0x000EA472
		public ShakeDigest(global::Org.BouncyCastle.Crypto.Digests.ShakeDigest source) : base(source)
		{
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x000EC27B File Offset: 0x000EA47B
		public override string AlgorithmName
		{
			get
			{
				return "SHAKE" + this.fixedOutputLength.ToString();
			}
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x000EC292 File Offset: 0x000EA492
		public override int GetDigestSize()
		{
			return this.fixedOutputLength >> 2;
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x000EC29C File Offset: 0x000EA49C
		public override int DoFinal(byte[] output, int outOff)
		{
			return this.DoFinal(output, outOff, this.GetDigestSize());
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x000EC2AC File Offset: 0x000EA4AC
		public virtual int DoFinal(byte[] output, int outOff, int outLen)
		{
			int result = this.DoOutput(output, outOff, outLen);
			this.Reset();
			return result;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x000EC2BD File Offset: 0x000EA4BD
		public virtual int DoOutput(byte[] output, int outOff, int outLen)
		{
			if (!this.squeezing)
			{
				base.AbsorbBits(15, 4);
			}
			base.Squeeze(output, outOff, (long)outLen << 3);
			return outLen;
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x000EC2DD File Offset: 0x000EA4DD
		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			return this.DoFinal(output, outOff, this.GetDigestSize(), partialByte, partialBits);
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x000EC2F0 File Offset: 0x000EA4F0
		protected virtual int DoFinal(byte[] output, int outOff, int outLen, byte partialByte, int partialBits)
		{
			if (partialBits < 0 || partialBits > 7)
			{
				throw new global::System.ArgumentException("must be in the range [0,7]", "partialBits");
			}
			int finalInput = ((int)partialByte & (1 << partialBits) - 1) | 15 << partialBits;
			int finalBits = partialBits + 4;
			if (finalBits >= 8)
			{
				base.Absorb((byte)finalInput);
				finalBits -= 8;
				finalInput >>= 8;
			}
			if (finalBits > 0)
			{
				base.AbsorbBits(finalInput, finalBits);
			}
			base.Squeeze(output, outOff, (long)outLen << 3);
			this.Reset();
			return outLen;
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000EC365 File Offset: 0x000EA565
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.ShakeDigest(this);
		}
	}
}
