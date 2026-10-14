using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000037 RID: 55
	public abstract class Integers
	{
		// Token: 0x06000282 RID: 642 RVA: 0x0000C554 File Offset: 0x0000A754
		public static int NumberOfLeadingZeros(int i)
		{
			if (i <= 0)
			{
				return ~i >> 26 & 32;
			}
			uint u = (uint)i;
			int j = 1;
			if (u >> 16 == 0U)
			{
				j += 16;
				u <<= 16;
			}
			if (u >> 24 == 0U)
			{
				j += 8;
				u <<= 8;
			}
			if (u >> 28 == 0U)
			{
				j += 4;
				u <<= 4;
			}
			if (u >> 30 == 0U)
			{
				j += 2;
				u <<= 2;
			}
			return j - (int)(u >> 31);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		public static int NumberOfTrailingZeros(int i)
		{
			int num = (int)global::Org.BouncyCastle.Utilities.Integers.DeBruijnTZ[(int)((uint)((i & -i) * 251226722) >> 27)];
			int j = ((i & 65535) | (int)((uint)i >> 16)) - 1 >> 31;
			return num - j;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public static int Reverse(int i)
		{
			return (int)global::Org.BouncyCastle.Utilities.Integers.Reverse((uint)i);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
		[global::System.CLSCompliant(false)]
		public static uint Reverse(uint i)
		{
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 1431655765U, 1);
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 858993459U, 2);
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 252645135U, 4);
			return global::Org.BouncyCastle.Utilities.Integers.ReverseBytes(i);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000C622 File Offset: 0x0000A822
		public static int ReverseBytes(int i)
		{
			return (int)global::Org.BouncyCastle.Utilities.Integers.ReverseBytes((uint)i);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000C62A File Offset: 0x0000A82A
		[global::System.CLSCompliant(false)]
		public static uint ReverseBytes(uint i)
		{
			return global::Org.BouncyCastle.Utilities.Integers.RotateLeft(i & 4278255360U, 8) | global::Org.BouncyCastle.Utilities.Integers.RotateLeft(i & 16711935U, 24);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000C648 File Offset: 0x0000A848
		public static int RotateLeft(int i, int distance)
		{
			return i << distance ^ (int)((uint)i >> -distance);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000C658 File Offset: 0x0000A858
		[global::System.CLSCompliant(false)]
		public static uint RotateLeft(uint i, int distance)
		{
			return i << distance ^ i >> -distance;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000C668 File Offset: 0x0000A868
		public static int RotateRight(int i, int distance)
		{
			return (int)((uint)i >> distance ^ (uint)((uint)i << -distance));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000C678 File Offset: 0x0000A878
		[global::System.CLSCompliant(false)]
		public static uint RotateRight(uint i, int distance)
		{
			return i >> distance ^ i << -distance;
		}

		// Token: 0x040000F2 RID: 242
		public const int NumBits = 32;

		// Token: 0x040000F3 RID: 243
		public const int NumBytes = 4;

		// Token: 0x040000F4 RID: 244
		private static readonly byte[] DeBruijnTZ = new byte[]
		{
			31,
			0,
			27,
			1,
			28,
			13,
			23,
			2,
			29,
			21,
			19,
			14,
			24,
			16,
			3,
			7,
			30,
			26,
			12,
			22,
			20,
			18,
			15,
			6,
			25,
			11,
			17,
			5,
			10,
			4,
			9,
			8
		};
	}
}
