using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200000E RID: 14
	internal struct c
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00004134 File Offset: 0x00002334
		private static uint[] a()
		{
			short num = (short)737017858;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_189;
				case 1:
				{
					int num3 = 8;
					num = (short)1694695424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1379008513;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_77;
					}
					continue;
				case 3:
				{
					int num3;
					if (num3 < 0)
					{
						num = (short)1692336132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num4 = 1U << 9 - num3 - 1;
					uint num5 = 1U << 9 - num3;
					uint num6 = num4;
					num = (short)1441857543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1907032064;
					short num7 = num;
					global::SevenZip.Compression.RangeCoder.c.f = true;
					num = (short)1293352968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_B9;
				case 6:
				{
					uint num5;
					uint num6;
					if (num6 >= num5)
					{
						num = (short)1603338250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1199737302;
					short num8 = num;
					num = (short)1220184534;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_249;
					default:
					{
						num = (short)1386938368;
						if (num != 0)
						{
						}
						int num3;
						global::SevenZip.Compression.RangeCoder.c.h[(int)num6] = (uint)((num3 << 6) + (int)(num5 - num6 << 6 >> 9 - num3 - 1));
						num6 += 1U;
						num = (short)1661992965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 7:
					goto IL_B9;
				case 8:
					goto IL_168;
				case 9:
					goto IL_189;
				case 10:
				{
					int num3;
					num3--;
					num = (short)1528299529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_77:
				if (!global::SevenZip.Compression.RangeCoder.c.f)
				{
					num = (short)525074433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_B9:
				num = (short)1010827270;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_189:
				num = (short)949026819;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_168:
			IL_249:
			return global::SevenZip.Compression.RangeCoder.c.h;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004390 File Offset: 0x00002590
		public void b()
		{
			short num = (short)1716125696;
			short num2 = num;
			num = (short)645815713;
			short num3 = num;
			num = (short)752508321;
			switch (num3 == num)
			{
			}
			num = (short)2126577665;
			if (num != 0)
			{
			}
			num = (short)669450240;
			if (num != 0)
			{
			}
			this.g = 1024U;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004444 File Offset: 0x00002644
		public void a(uint A_0)
		{
			short num = (short)1320157184;
			short num2 = num;
			if (A_0 == 0U)
			{
				num = (short)1523048108;
				short num3 = num;
				num = (short)1796529836;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)996540417;
					if (num != 0)
					{
					}
					num = (short)1062141952;
					if (num != 0)
					{
					}
					this.g += 2048U - this.g >> 5;
					return;
				}
			}
			this.g -= this.g >> 5;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004528 File Offset: 0x00002728
		public void a(global::SevenZip.Compression.RangeCoder.a A_0, uint A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			uint num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_1 == 0U)
					{
						num2 = (short)26476549;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					A_0.c += (ulong)num3;
					A_0.d -= num3;
					this.g -= this.g >> 5;
					num2 = (short)607780865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_6F;
				case 2:
					goto IL_6F;
				case 3:
					if (A_0.d < 16777216U)
					{
						num2 = (short)1808728070;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
				{
					num2 = (short)228719360;
					short num4 = num2;
					num2 = (short)483785472;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						goto IL_19C;
					}
					break;
				}
				case 5:
					A_0.d = num3;
					this.g += 2048U - this.g >> 5;
					num2 = (short)927989762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					A_0.d <<= 8;
					A_0.h();
					num2 = (short)2140798980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_6F:
				num2 = (short)442171395;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_19C:
			num2 = (short)1995112449;
			if (num2 != 0)
			{
			}
			num2 = (short)973340672;
			if (num2 != 0)
			{
			}
			num2 = (short)861601792;
			short num5 = num2;
			return;
			IL_2C:
			num3 = (A_0.d >> 11) * this.g;
			num2 = (short)1017708544;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000473C File Offset: 0x0000293C
		public uint b(uint A_0)
		{
			short num = (short)1376518144;
			short num2 = num;
			num = (short)1485764879;
			short num3 = num;
			num = (short)900135183;
			switch (num3 == num)
			{
			}
			num = (short)1705312257;
			if (num != 0)
			{
			}
			num = (short)2026897408;
			if (num != 0)
			{
			}
			return global::SevenZip.Compression.RangeCoder.c.a()[(int)(checked((global::System.IntPtr)((unchecked((ulong)(this.g - A_0) ^ (ulong)((long)(-(long)A_0))) & 2047UL) >> 2)))];
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004804 File Offset: 0x00002A04
		public uint c()
		{
			short num = (short)322109440;
			short num2 = num;
			num = (short)18733432;
			short num3 = num;
			num = (short)1295440248;
			switch (num3 == num)
			{
			}
			num = (short)337313793;
			if (num != 0)
			{
			}
			num = (short)175702016;
			if (num != 0)
			{
			}
			return global::SevenZip.Compression.RangeCoder.c.a()[(int)(this.g >> 2)];
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000048B8 File Offset: 0x00002AB8
		public uint d()
		{
			short num = (short)1343225856;
			short num2 = num;
			num = (short)71706434;
			short num3 = num;
			num = (short)167716674;
			switch (num3 == num)
			{
			}
			num = (short)1424490496;
			if (num != 0)
			{
			}
			num = (short)1302069249;
			if (num != 0)
			{
			}
			return global::SevenZip.Compression.RangeCoder.c.a()[(int)(2048U - this.g >> 2)];
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004974 File Offset: 0x00002B74
		// Note: this type is marked as 'beforefieldinit'.
		static c()
		{
			short num = (short)985661440;
			short num2 = num;
			num = (short)327443395;
			short num3 = num;
			num = (short)1366123459;
			switch (num3 == num)
			{
			}
			num = (short)1258618880;
			if (num != 0)
			{
			}
			num = (short)1633157121;
			if (num != 0)
			{
			}
			global::SevenZip.Compression.RangeCoder.c.f = false;
			global::SevenZip.Compression.RangeCoder.c.h = new uint[512];
		}

		// Token: 0x04000020 RID: 32
		public const int a = 11;

		// Token: 0x04000021 RID: 33
		public const uint b = 2048U;

		// Token: 0x04000022 RID: 34
		private const int c = 5;

		// Token: 0x04000023 RID: 35
		private const int d = 2;

		// Token: 0x04000024 RID: 36
		public const int e = 6;

		// Token: 0x04000025 RID: 37
		private static bool f;

		// Token: 0x04000026 RID: 38
		private uint g;

		// Token: 0x04000027 RID: 39
		private static uint[] h;
	}
}
