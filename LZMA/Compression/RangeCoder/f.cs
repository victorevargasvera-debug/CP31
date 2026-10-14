using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x02000011 RID: 17
	internal struct f
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00005850 File Offset: 0x00003A50
		public f(int numBitLevels)
		{
			this.b = numBitLevels;
			this.a = new global::SevenZip.Compression.RangeCoder.d[1 << numBitLevels];
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005878 File Offset: 0x00003A78
		public void a()
		{
			short num = (short)1256652800;
			short num2 = num;
			num = (short)745246722;
			short num3 = num;
			num = (short)17928194;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D7:
				num = (short)535166979;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)517079040;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				break;
			}
			uint num5;
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_D5;
				case 2:
					goto IL_143;
				case 3:
					if ((ulong)num5 >= (ulong)(1L << (this.b & 31)))
					{
						num = (short)304021504;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a[(int)num5].a();
					num5 += 1U;
					num = (short)1020788738;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_95;
			}
			IL_D5:
			IL_143:
			goto IL_D7;
			IL_95:
			num = (short)1457717249;
			if (num != 0)
			{
			}
			num5 = 1U;
			num = (short)732889089;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000059CC File Offset: 0x00003BCC
		public uint a(global::SevenZip.Compression.RangeCoder.b A_0)
		{
			short num = (short)189726720;
			short num2 = num;
			num = (short)169090248;
			short num3 = num;
			num = (short)1503599816;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DC:
				num = (short)1392640003;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)586350592;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BC;
				}
				break;
			}
			int num5;
			uint num6;
			for (;;)
			{
				IL_7E:
				num = (short)2128871425;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_10B;
				case 1:
					goto IL_DA;
				case 2:
					goto IL_140;
				case 3:
					if (num5 <= 0)
					{
						num = (short)1015349248;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num6 = (num6 << 1) + this.a[(int)num6].a(A_0);
					num5--;
					num = (short)1259470850;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BC;
			}
			IL_DA:
			goto IL_DC;
			IL_10B:
			return num6 - (1U << this.b);
			IL_140:
			goto IL_DC;
			IL_BC:
			num6 = 1U;
			num5 = this.b;
			num = (short)1296891905;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005B28 File Offset: 0x00003D28
		public uint b(global::SevenZip.Compression.RangeCoder.b A_0)
		{
			short num;
			int num3;
			for (;;)
			{
				num = (short)384696320;
				short num2 = num;
				num = (short)509935616;
				num3 = (int)num;
				switch (num3)
				{
				default:
				{
					num = (short)1330319860;
					short num4 = num;
					num = (short)1455034868;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7C;
					}
					break;
				}
				}
			}
			IL_7C:
			num = (short)915210240;
			if (num != 0)
			{
			}
			num = (short)765263873;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_D9;
			}
			uint num5;
			int num6;
			uint num8;
			for (;;)
			{
				IL_C2:
				switch (num3)
				{
				case 0:
					return num5;
				case 1:
					goto IL_F7;
				case 2:
					goto IL_F7;
				case 3:
				{
					if (num6 >= this.b)
					{
						num = (short)1503264768;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					uint num7 = this.a[(int)num8].a(A_0);
					num8 <<= 1;
					num8 += num7;
					num5 |= num7 << num6;
					num6++;
					num = (short)1108869122;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_D9;
				IL_F7:
				num = (short)1402142723;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num5;
			IL_D9:
			num8 = 1U;
			num5 = 0U;
			num6 = 0;
			num = (short)1736114177;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_C2;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public static uint a(global::SevenZip.Compression.RangeCoder.d[] A_0, uint A_1, global::SevenZip.Compression.RangeCoder.b A_2, int A_3)
		{
			short num = (short)1401552896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B2;
				}
				int num4;
				uint num7;
				uint num8;
				for (;;)
				{
					IL_27:
					num = (short)1341980673;
					if (num != 0)
					{
					}
					num = (short)891884881;
					short num3 = num;
					num = (short)410916177;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1441529856;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							if (num4 >= A_3)
							{
								num = (short)423493632;
								short num5 = num;
								num = (short)1715208194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uint num6 = A_0[(int)(A_1 + num7)].a(A_2);
							num7 <<= 1;
							num7 += num6;
							num8 |= num6 << num4;
							num4++;
							num = (short)67174401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_D2;
						case 2:
							return num8;
						case 3:
							goto IL_D2;
						}
						goto IL_B2;
					}
					IL_D2:
					num = (short)603914240;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num8;
				IL_B2:
				num7 = 1U;
				num8 = 0U;
				num4 = 0;
				num = (short)1542127619;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0400002E RID: 46
		private global::SevenZip.Compression.RangeCoder.d[] a;

		// Token: 0x0400002F RID: 47
		private int b;
	}
}
