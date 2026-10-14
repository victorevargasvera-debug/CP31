using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SpecialFeatures.Flashport
{
	// Token: 0x020000C6 RID: 198
	public sealed class Crc32 : global::System.Security.Cryptography.HashAlgorithm
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x00002EDD File Offset: 0x000010DD
		public Crc32() : this(3988292384U, uint.MaxValue)
		{
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00102040 File Offset: 0x00100240
		public Crc32(uint polynomial, uint seed)
		{
			this.c = global::SpecialFeatures.Flashport.Crc32.b(polynomial);
			this.d = seed;
			this.b = seed;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00102070 File Offset: 0x00100270
		public override void Initialize()
		{
			short num = (short)104032737;
			short num2 = num;
			num = (short)1462594017;
			switch (num2 == num)
			{
			}
			num = (short)1519648768;
			if (num != 0)
			{
			}
			num = (short)1990131713;
			if (num != 0)
			{
			}
			num = (short)681115648;
			short num3 = num;
			this.d = this.b;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00102124 File Offset: 0x00100324
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			short num = (short)1453222155;
			short num2 = num;
			num = (short)2048747787;
			switch (num2 == num)
			{
			}
			num = (short)2002911232;
			if (num != 0)
			{
			}
			num = (short)1188364289;
			if (num != 0)
			{
			}
			num = (short)1340801024;
			short num3 = num;
			this.d = global::SpecialFeatures.Flashport.Crc32.a(this.c, this.d, buffer, start, length);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x001021E4 File Offset: 0x001003E4
		protected override byte[] HashFinal()
		{
			short num = (short)1717171141;
			short num2 = num;
			num = (short)1829696453;
			switch (num2 == num)
			{
			}
			num = (short)574554113;
			if (num != 0)
			{
			}
			num = (short)1580531712;
			if (num != 0)
			{
			}
			num = (short)1183842304;
			short num3 = num;
			byte[] array = global::SpecialFeatures.Flashport.Crc32.a(~this.d);
			this.HashValue = array;
			return array;
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x001022A4 File Offset: 0x001004A4
		public override int HashSize
		{
			get
			{
				short num = (short)1796662905;
				short num2 = num;
				num = (short)1777788537;
				switch (num2 == num)
				{
				}
				num = (short)221511681;
				if (num != 0)
				{
				}
				num = (short)565575680;
				if (num != 0)
				{
				}
				num = (short)476971008;
				short num3 = num;
				return 32;
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00102350 File Offset: 0x00100550
		public static uint Compute(byte[] buffer)
		{
			short num = (short)1068816526;
			short num2 = num;
			num = (short)1205065870;
			switch (num2 == num)
			{
			}
			num = (short)535035905;
			if (num != 0)
			{
			}
			num = (short)73793536;
			if (num != 0)
			{
			}
			num = (short)100990976;
			short num3 = num;
			return global::SpecialFeatures.Flashport.Crc32.Compute(uint.MaxValue, buffer);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00102400 File Offset: 0x00100600
		public static uint Compute(uint seed, byte[] buffer)
		{
			short num = (short)1543927189;
			short num2 = num;
			num = (short)1672705429;
			switch (num2 == num)
			{
			}
			num = (short)939524097;
			if (num != 0)
			{
			}
			num = (short)1637679104;
			if (num != 0)
			{
			}
			num = (short)1953497088;
			short num3 = num;
			return global::SpecialFeatures.Flashport.Crc32.Compute(3988292384U, seed, buffer);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x001024B4 File Offset: 0x001006B4
		public static uint Compute(uint polynomial, uint seed, byte[] buffer)
		{
			short num = (short)1839086638;
			short num2 = num;
			num = (short)788216878;
			switch (num2 == num)
			{
			}
			num = (short)1181941760;
			if (num != 0)
			{
			}
			num = (short)1348861953;
			if (num != 0)
			{
			}
			num = (short)770113536;
			short num3 = num;
			return ~global::SpecialFeatures.Flashport.Crc32.a(global::SpecialFeatures.Flashport.Crc32.b(polynomial), seed, buffer, 0, buffer.Length);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00102570 File Offset: 0x00100770
		private static uint[] b(uint A_0)
		{
			short num = (short)1693646848;
			switch (num)
			{
			default:
			{
				num = (short)1668153360;
				int num2 = (int)((global::System.IntPtr)num);
				uint[] array;
				for (;;)
				{
					int num4;
					int num6;
					switch (num2)
					{
					case 0:
						num = (short)1108803587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (global::SpecialFeatures.Flashport.Crc32.a == null)
						{
							goto IL_FA;
						}
						num = (short)290568819;
						short num3 = num;
						num = (short)2130295411;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_349;
						default:
							num = (short)1941241856;
							if (num != 0)
							{
							}
							num = (short)112918539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
					{
						uint num5;
						array[num4] = num5;
						num4++;
						num = (short)1716649998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1367212033;
						if (num != 0)
						{
						}
						if (A_0 == 3988292384U)
						{
							num = (short)1028390920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					case 4:
						goto IL_18D;
					case 5:
					{
						uint num5 = num5 >> 1 ^ A_0;
						num = (short)171900935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (num6 >= 8)
						{
							num = (short)566624258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 7:
					{
						num = (short)945618944;
						short num7 = num;
						goto IL_29A;
					}
					case 8:
						global::SpecialFeatures.Flashport.Crc32.a = array;
						num = (short)2025062417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						uint num5;
						if ((num5 & 1U) == 1U)
						{
							num = (short)865927173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 >>= 1;
						num = (short)1743061007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_18D;
					case 11:
						goto IL_344;
					case 12:
					{
						if (num4 >= 256)
						{
							num = (short)1625489408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num5 = (uint)num4;
						num6 = 0;
						num = (short)1188691972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)408485889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_25A;
					case 15:
						goto IL_29A;
					case 16:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 17:
						goto IL_1EA;
					case 18:
						goto IL_25A;
					}
					IL_90:
					if (A_0 == 3988292384U)
					{
						num = (short)1456537613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FA:
					array = new uint[256];
					num4 = 0;
					num = (short)1693384722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)990380038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25A:
					num = (short)1974665228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					num6++;
					num = (short)291962890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_349:
					num = (short)711655433;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EA:
				return array;
				IL_344:
				return global::SpecialFeatures.Flashport.Crc32.a;
			}
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00102908 File Offset: 0x00100B08
		private static uint a(uint[] A_0, uint A_1, global::System.Collections.Generic.IList<byte> A_2, int A_3, int A_4)
		{
			short num = (short)1756626945;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			int num2;
			uint num3;
			int num4;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					return num3;
				case 1:
					goto IL_D6;
				case 2:
					if (num4 >= A_4 - A_3)
					{
						num = (short)1051197440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = (num3 >> 8 ^ A_0[(int)((uint)A_2[num4] ^ (num3 & 255U))]);
					num4++;
					num = (short)1991049217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)684482924;
					short num5 = num;
					num = (short)1820877164;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						num = (short)1776025600;
						if (num != 0)
						{
						}
						goto IL_D6;
					}
					break;
				}
				}
				goto IL_46;
				IL_D6:
				num = (short)271515650;
				num2 = (int)((global::System.IntPtr)num);
			}
			return num3;
			IL_46:
			num3 = A_1;
			num4 = A_3;
			num = (short)520814592;
			short num6 = num;
			num = (short)780271619;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00102A58 File Offset: 0x00100C58
		private static byte[] a(uint A_0)
		{
			short num = (short)216268801;
			if (num != 0)
			{
			}
			num = (short)975127793;
			short num2 = num;
			num = (short)1790461169;
			switch (num2 == num)
			{
			}
			num = (short)1384906752;
			if (num != 0)
			{
			}
			num = (short)783810560;
			short num3 = num;
			return global::System.BitConverter.GetBytes(A_0);
		}

		// Token: 0x0400060A RID: 1546
		public const uint DefaultPolynomial = 3988292384U;

		// Token: 0x0400060B RID: 1547
		public const uint DefaultSeed = 4294967295U;

		// Token: 0x0400060C RID: 1548
		private static uint[] a;

		// Token: 0x0400060D RID: 1549
		private readonly uint b;

		// Token: 0x0400060E RID: 1550
		private readonly uint[] c;

		// Token: 0x0400060F RID: 1551
		private uint d;
	}
}
