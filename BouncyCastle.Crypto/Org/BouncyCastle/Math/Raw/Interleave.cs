using System;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001EF RID: 495
	internal abstract class Interleave
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x00053D18 File Offset: 0x00051F18
		internal static uint Expand8to16(uint x)
		{
			x &= 255U;
			x = ((x | x << 4) & 3855U);
			x = ((x | x << 2) & 13107U);
			x = ((x | x << 1) & 21845U);
			return x;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00053D4B File Offset: 0x00051F4B
		internal static uint Expand16to32(uint x)
		{
			x &= 65535U;
			x = ((x | x << 8) & 16711935U);
			x = ((x | x << 4) & 252645135U);
			x = ((x | x << 2) & 858993459U);
			x = ((x | x << 1) & 1431655765U);
			return x;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00053D8C File Offset: 0x00051F8C
		internal static ulong Expand32to64(uint x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 65280U, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 15728880U, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 202116108U, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 572662306U, 1);
			return ((ulong)(x >> 1) & 1431655765UL) << 32 | ((ulong)x & 1431655765UL);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00053DEC File Offset: 0x00051FEC
		internal static void Expand64To128(ulong x, ulong[] z, int zOff)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, (ulong)-65536, 16);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 280375465148160UL, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 67555025218437360UL, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 868082074056920076UL, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 2459565876494606882UL, 1);
			z[zOff] = (x & 6148914691236517205UL);
			z[zOff + 1] = (x >> 1 & 6148914691236517205UL);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00053E74 File Offset: 0x00052074
		internal static void Expand64To128(ulong[] xs, int xsOff, int xsLen, ulong[] zs, int zsOff)
		{
			for (int i = 0; i < xsLen; i++)
			{
				global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128(xs[xsOff + i], zs, zsOff);
				zsOff += 2;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00053EA0 File Offset: 0x000520A0
		internal static void Expand64To128Rev(ulong x, ulong[] z, int zOff)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, (ulong)-65536, 16);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 280375465148160UL, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 67555025218437360UL, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 868082074056920076UL, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 2459565876494606882UL, 1);
			z[zOff] = (x & 12297829382473034410UL);
			z[zOff + 1] = (x << 1 & 12297829382473034410UL);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00053F25 File Offset: 0x00052125
		internal static uint Shuffle(uint x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 65280U, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 15728880U, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 202116108U, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 572662306U, 1);
			return x;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00053F60 File Offset: 0x00052160
		internal static ulong Shuffle(ulong x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, (ulong)-65536, 16);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 280375465148160UL, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 67555025218437360UL, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 868082074056920076UL, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 2459565876494606882UL, 1);
			return x;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00053FC6 File Offset: 0x000521C6
		internal static uint Shuffle2(uint x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 11141290U, 7);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 52428U, 14);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 15728880U, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 65280U, 8);
			return x;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00054002 File Offset: 0x00052202
		internal static uint Unshuffle(uint x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 572662306U, 1);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 202116108U, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 15728880U, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 65280U, 8);
			return x;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00054040 File Offset: 0x00052240
		internal static ulong Unshuffle(ulong x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 2459565876494606882UL, 1);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 868082074056920076UL, 2);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 67555025218437360UL, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 280375465148160UL, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, (ulong)-65536, 16);
			return x;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000540A6 File Offset: 0x000522A6
		internal static uint Unshuffle2(uint x)
		{
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 65280U, 8);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 15728880U, 4);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 52428U, 14);
			x = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStep(x, 11141290U, 7);
			return x;
		}

		// Token: 0x04000929 RID: 2345
		private const ulong M32 = 1431655765UL;

		// Token: 0x0400092A RID: 2346
		private const ulong M64 = 6148914691236517205UL;

		// Token: 0x0400092B RID: 2347
		private const ulong M64R = 12297829382473034410UL;
	}
}
