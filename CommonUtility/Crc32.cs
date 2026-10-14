using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CommonUtility
{
	// Token: 0x0200002A RID: 42
	public sealed class Crc32 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x060000FD RID: 253 RVA: 0x0001A28C File Offset: 0x0001848C
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001A2A8 File Offset: 0x000184A8
		public Crc32(uint polynomial, uint seed)
		{
			this.c = global::CommonUtility.Crc32.b(polynomial);
			this.d = seed;
			this.b = seed;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001A2D8 File Offset: 0x000184D8
		public override void Initialize()
		{
			short num = (short)569376768;
			short num2 = num;
			num = (short)990642177;
			if (num != 0)
			{
			}
			num = (short)2075248552;
			short num3 = num;
			num = (short)908838824;
			switch (num3 == num)
			{
			}
			num = (short)1836056576;
			if (num != 0)
			{
			}
			this.d = this.b;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001A390 File Offset: 0x00018590
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			short num = (short)807272448;
			short num2 = num;
			num = (short)372833316;
			short num3 = num;
			num = (short)172620836;
			switch (num3 == num)
			{
			}
			num = (short)816906240;
			if (num != 0)
			{
			}
			num = (short)1474822145;
			if (num != 0)
			{
			}
			this.d = global::CommonUtility.Crc32.a(this.c, this.d, buffer, start, length);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001A454 File Offset: 0x00018654
		protected override byte[] HashFinal()
		{
			short num = (short)1349976064;
			short num2 = num;
			num = (short)2107568259;
			short num3 = num;
			num = (short)1189474435;
			switch (num3 == num)
			{
			}
			num = (short)1851916288;
			if (num != 0)
			{
			}
			num = (short)795148289;
			if (num != 0)
			{
			}
			byte[] array = global::CommonUtility.Crc32.a(~this.d);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0001A514 File Offset: 0x00018714
		public override int HashSize
		{
			get
			{
				short num = (short)1808662528;
				short num2 = num;
				num = (short)1878303701;
				short num3 = num;
				num = (short)1965597653;
				switch (num3 == num)
				{
				}
				num = (short)1448607745;
				if (num != 0)
				{
				}
				num = (short)562757632;
				if (num != 0)
				{
				}
				return 32;
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001A5C0 File Offset: 0x000187C0
		public static uint Compute(byte[] buffer)
		{
			short num = (short)241500160;
			short num2 = num;
			num = (short)875093173;
			short num3 = num;
			num = (short)1127275701;
			switch (num3 == num)
			{
			}
			num = (short)1408499713;
			if (num != 0)
			{
			}
			num = (short)2059599872;
			if (num != 0)
			{
			}
			return global::CommonUtility.Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001A670 File Offset: 0x00018870
		public static uint Compute(uint seed, byte[] buffer)
		{
			short num = (short)46268416;
			short num2 = num;
			num = (short)81908487;
			short num3 = num;
			num = (short)1132974855;
			switch (num3 == num)
			{
			}
			num = (short)933167105;
			if (num != 0)
			{
			}
			num = (short)344129536;
			if (num != 0)
			{
			}
			return global::CommonUtility.Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0001A728 File Offset: 0x00018928
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			short num = (short)645595136;
			short num2 = num;
			num = (short)682101381;
			short num3 = num;
			num = (short)546245253;
			switch (num3 == num)
			{
			}
			num = (short)789381120;
			if (num != 0)
			{
			}
			num = (short)1373306881;
			if (num != 0)
			{
			}
			return ~global::CommonUtility.Crc32.a(global::CommonUtility.Crc32.b(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0001A7E0 File Offset: 0x000189E0
		private static uint[] b(uint A_0)
		{
			short num = (short)598409216;
			switch (num)
			{
			default:
			{
				num = (short)681902080;
				int num2 = (int)((global::System.IntPtr)num);
				uint[] array;
				for (;;)
				{
					int num3;
					int num5;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 1:
						if (num3 >= 8)
						{
							num = (short)1658978322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1398276100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_262;
					case 3:
					{
						uint num4 = num4 >> 1 ^ A_0;
						num = (short)1298595853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						uint num4;
						if ((num4 & 1U) == 1U)
						{
							num = (short)231276547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 >>= 1;
						num = (short)1069875206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_206;
					case 6:
						goto IL_2E5;
					case 7:
						global::CommonUtility.Crc32.a = array;
						num = (short)1642070018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_2A8;
					case 9:
						num = (short)325386254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1143013392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_206;
					case 12:
						goto IL_2A8;
					case 13:
						goto IL_2E5;
					case 14:
						if (A_0 == 3988292384U)
						{
							num = (short)1617362951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 15:
					{
						IL_2C0:
						if (num5 >= 256)
						{
							num = (short)361758729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num4 = (uint)num5;
						num3 = 0;
						num = (short)1697710085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (global::CommonUtility.Crc32.a != null)
						{
							num = (short)224591889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 17:
						goto IL_342;
					case 18:
					{
						uint num4;
						array[num5] = num4;
						num5++;
						num = (short)2117664780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_8F:
					num = (short)910884864;
					short num6 = num;
					if (A_0 == 3988292384U)
					{
						num = (short)1246691338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_125:
					array = new uint[256];
					num5 = 0;
					num = (short)1743831224;
					short num7 = num;
					num = (short)1887027384;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2C0;
					default:
						num = (short)280559616;
						if (num != 0)
						{
						}
						num = (short)1764491265;
						if (num != 0)
						{
						}
						num = (short)313131016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_206:
					num = (short)37289985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A8:
					num = (short)818216975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					num3++;
					num = (short)2070675467;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_262:
				return array;
				IL_342:
				return global::CommonUtility.Crc32.a;
			}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0001AB74 File Offset: 0x00018D74
		private static uint a(uint[] A_0, uint A_1, global::System.Collections.Generic.IList<byte> A_2, int A_3, int A_4)
		{
			short num = (short)220725248;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num3;
			uint num4;
			int num5;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					goto IL_63;
				case 1:
					goto IL_63;
				case 2:
					return num4;
				case 3:
				{
					if (num5 >= A_4 - A_3)
					{
						num = (short)1280245762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = (num4 >> 8 ^ A_0[(int)((uint)A_2[num5] ^ (num4 & 255U))]);
					num5++;
					num = (short)1917711041;
					short num6 = num;
					num = (short)1114698433;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return num4;
					default:
						num = (short)1451032576;
						if (num != 0)
						{
						}
						num = (short)256442369;
						if (num != 0)
						{
						}
						num = (short)1080557569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_48;
				IL_63:
				num = (short)487325699;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num4;
			IL_48:
			num4 = A_1;
			num5 = A_3;
			num = (short)1320288256;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		private static byte[] a(uint A_0)
		{
			short num = (short)1074462720;
			short num2 = num;
			num = (short)1337327617;
			if (num != 0)
			{
			}
			num = (short)915110535;
			short num3 = num;
			num = (short)271743623;
			switch (num3 == num)
			{
			}
			num = (short)1402208256;
			if (num != 0)
			{
			}
			return global::System.BitConverter.GetBytes(A_0);
		}

		// Token: 0x04000077 RID: 119
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x04000078 RID: 120
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x04000079 RID: 121
		private static uint[] a;

		// Token: 0x0400007A RID: 122
		private readonly uint b;

		// Token: 0x0400007B RID: 123
		private readonly uint[] c;

		// Token: 0x0400007C RID: 124
		private uint d;
	}
}
