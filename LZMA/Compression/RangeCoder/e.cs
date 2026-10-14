using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x02000010 RID: 16
	internal struct e
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00004E54 File Offset: 0x00003054
		public e(int numBitLevels)
		{
			this.b = numBitLevels;
			this.a = new global::SevenZip.Compression.RangeCoder.c[1 << numBitLevels];
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004E7C File Offset: 0x0000307C
		public void a()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			uint num2;
			short num3;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_D8;
				case 2:
					goto IL_D8;
				case 3:
					if ((ulong)num2 >= (ulong)(1L << (this.b & 31)))
					{
						num3 = (short)1576271872;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_118;
				}
				goto IL_20;
				IL_D8:
				num3 = (short)1960312835;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_118:
			this.a[(int)num2].b();
			num2 += 1U;
			goto IL_12D;
			IL_20:
			num3 = (short)1395851265;
			if (num3 != 0)
			{
			}
			num3 = (short)907673600;
			short num4 = num3;
			num3 = (short)1508055421;
			short num5 = num3;
			num3 = (short)584325501;
			switch ((num5 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12D:
				num3 = (short)405078017;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			default:
			{
				num3 = (short)375390208;
				if (num3 != 0)
				{
				}
				num2 = 1U;
				num3 = (short)1053097986;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004FD0 File Offset: 0x000031D0
		public void a(global::SevenZip.Compression.RangeCoder.a A_0, uint A_1)
		{
			short num = (short)1717895168;
			short num2 = num;
			num = (short)475811065;
			short num3 = num;
			num = (short)240536825;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DD:
				num = (short)1692008451;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)686686208;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BE;
				}
				break;
			}
			int num5;
			uint num7;
			for (;;)
			{
				IL_80:
				num = (short)1843986433;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_DB;
				case 2:
					goto IL_14D;
				case 3:
				{
					if (num5 <= 0)
					{
						num = (short)1198718976;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5--;
					uint num6 = A_1 >> num5 & 1U;
					this.a[(int)num7].a(A_0, num6);
					num7 = (num7 << 1 | num6);
					num = (short)1645084674;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_BE;
			}
			IL_DB:
			IL_14D:
			goto IL_DD;
			IL_BE:
			num7 = 1U;
			num5 = this.b;
			num = (short)1348403201;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_80;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000512C File Offset: 0x0000332C
		public void b(global::SevenZip.Compression.RangeCoder.a A_0, uint A_1)
		{
			short num = (short)2068119552;
			short num2 = num;
			num = (short)1397538961;
			short num3 = num;
			num = (short)1730723985;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D5:
				num = (short)1625161731;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)724566016;
				if (num != 0)
				{
				}
				num = (short)569311233;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				break;
			}
			uint num5;
			uint num7;
			for (;;)
			{
				IL_A4:
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_D3;
				case 2:
					goto IL_149;
				case 3:
				{
					if ((ulong)num5 >= (ulong)((long)this.b))
					{
						num = (short)925040640;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num6 = A_1 & 1U;
					this.a[(int)num7].a(A_0, num6);
					num7 = (num7 << 1 | num6);
					A_1 >>= 1;
					num5 += 1U;
					num = (short)208273410;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_BA;
			}
			IL_D3:
			IL_149:
			goto IL_D5;
			IL_BA:
			num7 = 1U;
			num5 = 0U;
			num = (short)55771137;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005284 File Offset: 0x00003484
		public uint a(uint A_0)
		{
			short num;
			int num3;
			for (;;)
			{
				num = (short)1503461376;
				short num2 = num;
				num = (short)1371078656;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)921487183;
					short num4 = num;
					num = (short)617989967;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7A;
					}
					break;
				}
				}
			}
			IL_7A:
			num = (short)1024917504;
			if (num != 0)
			{
			}
			num = (short)460128257;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_D7;
			}
			uint num5;
			int num6;
			uint num8;
			for (;;)
			{
				IL_C0:
				switch (num3)
				{
				case 0:
					return num5;
				case 1:
					goto IL_FB;
				case 2:
					goto IL_FB;
				case 3:
				{
					if (num6 <= 0)
					{
						num = (short)160301056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num6--;
					uint num7 = A_0 >> num6 & 1U;
					num5 += this.a[(int)num8].b(num7);
					num8 = (num8 << 1) + num7;
					num = (short)131072002;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_D7;
				IL_FB:
				num = (short)1812463619;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num5;
			IL_D7:
			num5 = 0U;
			num8 = 1U;
			num6 = this.b;
			num = (short)1834352641;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_C0;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005400 File Offset: 0x00003600
		public uint b(uint A_0)
		{
			short num;
			int num3;
			for (;;)
			{
				num = (short)254869504;
				short num2 = num;
				num = (short)761200640;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)642227545;
					short num4 = num;
					num = (short)1838849369;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7B;
					}
					break;
				}
				}
			}
			IL_7B:
			num = (short)756416512;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B2;
			}
			uint num5;
			int num6;
			uint num8;
			for (;;)
			{
				IL_9B:
				switch (num3)
				{
				case 0:
					return num5;
				case 1:
					goto IL_D5;
				case 2:
					goto IL_D5;
				case 3:
				{
					if (num6 <= 0)
					{
						num = (short)1337589760;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num7 = A_0 & 1U;
					A_0 >>= 1;
					num5 += this.a[(int)num8].b(num7);
					num8 = (num8 << 1 | num7);
					num6--;
					num = (short)1844248578;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_B2;
				IL_D5:
				num = (short)157220865;
				if (num != 0)
				{
				}
				num = (short)1465843715;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num5;
			IL_B2:
			num5 = 0U;
			num8 = 1U;
			num6 = this.b;
			num = (short)566231041;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_9B;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005584 File Offset: 0x00003784
		public static uint a(global::SevenZip.Compression.RangeCoder.c[] A_0, uint A_1, int A_2, uint A_3)
		{
			short num;
			int num3;
			for (;;)
			{
				num = (short)1658126336;
				short num2 = num;
				num = (short)1593049088;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)2051013242;
					short num4 = num;
					num = (short)1555823226;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7E;
					}
					break;
				}
				}
			}
			IL_7E:
			num = (short)43843584;
			if (num != 0)
			{
			}
			num = (short)436797441;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_DE;
			}
			uint num5;
			int num6;
			uint num8;
			for (;;)
			{
				IL_C7:
				switch (num3)
				{
				case 0:
					return num5;
				case 1:
					goto IL_FC;
				case 2:
					goto IL_FC;
				case 3:
				{
					if (num6 <= 0)
					{
						num = (short)470351872;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num7 = A_3 & 1U;
					A_3 >>= 1;
					num5 += A_0[(int)(A_1 + num8)].b(num7);
					num8 = (num8 << 1 | num7);
					num6--;
					num = (short)440664066;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_DE;
				IL_FC:
				num = (short)1143668739;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num5;
			IL_DE:
			num5 = 0U;
			num8 = 1U;
			num6 = A_2;
			num = (short)1119354881;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_C7;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005700 File Offset: 0x00003900
		public static void a(global::SevenZip.Compression.RangeCoder.c[] A_0, uint A_1, global::SevenZip.Compression.RangeCoder.a A_2, int A_3, uint A_4)
		{
			short num = (short)1687158784;
			short num2 = num;
			num = (short)546166982;
			short num3 = num;
			num = (short)2138364102;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D2:
				num = (short)185466883;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1330118657;
				if (num != 0)
				{
				}
				num = (short)2106064896;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				break;
			}
			int num5;
			uint num7;
			for (;;)
			{
				IL_A2:
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_D0;
				case 2:
					goto IL_13E;
				case 3:
				{
					if (num5 >= A_3)
					{
						num = (short)285016064;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num6 = A_4 & 1U;
					A_0[(int)(A_1 + num7)].a(A_2, num6);
					num7 = (num7 << 1 | num6);
					A_4 >>= 1;
					num5++;
					num = (short)1422000130;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_B8;
			}
			IL_D0:
			IL_13E:
			goto IL_D2;
			IL_B8:
			num7 = 1U;
			num5 = 0;
			num = (short)230096897;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A2;
		}

		// Token: 0x0400002C RID: 44
		private global::SevenZip.Compression.RangeCoder.c[] a;

		// Token: 0x0400002D RID: 45
		private int b;
	}
}
