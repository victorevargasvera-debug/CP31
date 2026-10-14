using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E0 RID: 1248
	public class Sha3Digest : global::Org.BouncyCastle.Crypto.Digests.KeccakDigest
	{
		// Token: 0x0600310D RID: 12557 RVA: 0x000EBB14 File Offset: 0x000E9D14
		private static int CheckBitLength(int bitLength)
		{
			if (bitLength <= 256)
			{
				if (bitLength != 224 && bitLength != 256)
				{
					goto IL_2C;
				}
			}
			else if (bitLength != 384 && bitLength != 512)
			{
				goto IL_2C;
			}
			return bitLength;
			IL_2C:
			throw new global::System.ArgumentException(bitLength.ToString() + " not supported for SHA-3", "bitLength");
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000EBB68 File Offset: 0x000E9D68
		public Sha3Digest() : this(256)
		{
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000EBB75 File Offset: 0x000E9D75
		public Sha3Digest(int bitLength) : base(global::Org.BouncyCastle.Crypto.Digests.Sha3Digest.CheckBitLength(bitLength))
		{
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000EBB83 File Offset: 0x000E9D83
		public Sha3Digest(global::Org.BouncyCastle.Crypto.Digests.Sha3Digest source) : base(source)
		{
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000EBB8C File Offset: 0x000E9D8C
		public override string AlgorithmName
		{
			get
			{
				return "SHA3-" + this.fixedOutputLength.ToString();
			}
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000EBBA3 File Offset: 0x000E9DA3
		public override int DoFinal(byte[] output, int outOff)
		{
			base.AbsorbBits(2, 2);
			return base.DoFinal(output, outOff);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000EBBB8 File Offset: 0x000E9DB8
		protected override int DoFinal(byte[] output, int outOff, byte partialByte, int partialBits)
		{
			if (partialBits < 0 || partialBits > 7)
			{
				throw new global::System.ArgumentException("must be in the range [0,7]", "partialBits");
			}
			int finalInput = ((int)partialByte & (1 << partialBits) - 1) | 2 << partialBits;
			int finalBits = partialBits + 2;
			if (finalBits >= 8)
			{
				base.Absorb((byte)finalInput);
				finalBits -= 8;
				finalInput >>= 8;
			}
			return base.DoFinal(output, outOff, (byte)finalInput, finalBits);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000EBC17 File Offset: 0x000E9E17
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha3Digest(this);
		}
	}
}
