using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000038 RID: 56
	public abstract class Longs
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public static int NumberOfLeadingZeros(long i)
		{
			int x = (int)(i >> 32);
			int j = 0;
			if (x == 0)
			{
				j = 32;
				x = (int)i;
			}
			return j + global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros(x);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		public static int NumberOfTrailingZeros(long i)
		{
			int num = (int)global::Org.BouncyCastle.Utilities.Longs.DeBruijnTZ[(int)((uint)((ulong)((i & -i) * 315175865370177754L) >> 58))];
			long j = ((i & (long)((ulong)-1)) | (long)((ulong)i >> 32)) - 1L >> 63;
			return num - (int)j;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000C70C File Offset: 0x0000A90C
		public static long Reverse(long i)
		{
			return (long)global::Org.BouncyCastle.Utilities.Longs.Reverse((ulong)i);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000C714 File Offset: 0x0000A914
		[global::System.CLSCompliant(false)]
		public static ulong Reverse(ulong i)
		{
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 6148914691236517205UL, 1);
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 3689348814741910323UL, 2);
			i = global::Org.BouncyCastle.Math.Raw.Bits.BitPermuteStepSimple(i, 1085102592571150095UL, 4);
			return global::Org.BouncyCastle.Utilities.Longs.ReverseBytes(i);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000C752 File Offset: 0x0000A952
		public static long ReverseBytes(long i)
		{
			return (long)global::Org.BouncyCastle.Utilities.Longs.ReverseBytes((ulong)i);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000C75C File Offset: 0x0000A95C
		[global::System.CLSCompliant(false)]
		public static ulong ReverseBytes(ulong i)
		{
			return global::Org.BouncyCastle.Utilities.Longs.RotateLeft(i & 18374686483949813760UL, 8) | global::Org.BouncyCastle.Utilities.Longs.RotateLeft(i & 71776119077928960UL, 24) | global::Org.BouncyCastle.Utilities.Longs.RotateLeft(i & 280375465148160UL, 40) | global::Org.BouncyCastle.Utilities.Longs.RotateLeft(i & 1095216660735UL, 56);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		public static long RotateLeft(long i, int distance)
		{
			return i << distance ^ (long)((ulong)i >> -distance);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000C7C3 File Offset: 0x0000A9C3
		[global::System.CLSCompliant(false)]
		public static ulong RotateLeft(ulong i, int distance)
		{
			return i << distance ^ i >> -distance;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000C7D3 File Offset: 0x0000A9D3
		public static long RotateRight(long i, int distance)
		{
			return (long)((ulong)i >> distance ^ (ulong)((ulong)i << -distance));
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000C7E3 File Offset: 0x0000A9E3
		[global::System.CLSCompliant(false)]
		public static ulong RotateRight(ulong i, int distance)
		{
			return i >> distance ^ i << -distance;
		}

		// Token: 0x040000F5 RID: 245
		public const int NumBits = 64;

		// Token: 0x040000F6 RID: 246
		public const int NumBytes = 8;

		// Token: 0x040000F7 RID: 247
		private static readonly byte[] DeBruijnTZ = new byte[]
		{
			63,
			0,
			1,
			52,
			2,
			6,
			53,
			26,
			3,
			37,
			40,
			7,
			33,
			54,
			47,
			27,
			61,
			4,
			38,
			45,
			43,
			41,
			21,
			8,
			23,
			34,
			58,
			55,
			48,
			17,
			28,
			10,
			62,
			51,
			5,
			25,
			36,
			39,
			32,
			46,
			60,
			44,
			42,
			20,
			22,
			57,
			16,
			9,
			50,
			24,
			35,
			31,
			59,
			19,
			56,
			15,
			49,
			30,
			18,
			14,
			29,
			13,
			12,
			11
		};
	}
}
