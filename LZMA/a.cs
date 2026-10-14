using System;

namespace SevenZip
{
	// Token: 0x02000003 RID: 3
	internal class a
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		static a()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num3;
			uint num5;
			for (;;)
			{
				IL_0A:
				int num2;
				switch (num)
				{
				case 0:
					goto IL_239;
				case 1:
					if (num2 >= 8)
					{
						num3 = (short)1475018760;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1493303300;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_93;
				case 3:
					goto IL_CB;
				case 4:
				{
					uint num4;
					if ((num4 & 1U) != 0U)
					{
						num3 = (short)768606217;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num4 >>= 1;
					num3 = (short)1871970304;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 5:
					return;
				case 6:
					goto IL_127;
				case 7:
					goto IL_93;
				case 8:
				{
					uint num4;
					global::SevenZip.a.a[(int)num5] = num4;
					num5 += 1U;
					num3 = (short)648544262;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 9:
				{
					uint num4 = num4 >> 1 ^ 3988292384U;
					num3 = (short)1397424131;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 10:
				{
					if (num5 >= 256U)
					{
						num3 = (short)894304261;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1848777624;
					short num6 = num3;
					num3 = (short)301210520;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_239;
					default:
					{
						num3 = (short)239009792;
						if (num3 != 0)
						{
						}
						num3 = (short)442171393;
						if (num3 != 0)
						{
						}
						uint num4 = num5;
						num2 = 0;
						num3 = (short)1052835847;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					}
					break;
				}
				case 11:
				{
					num3 = (short)1343750144;
					short num7 = num3;
					goto IL_127;
				}
				}
				goto IL_40;
				IL_93:
				num3 = (short)1715273729;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_CB:
				num2++;
				num3 = (short)1529217026;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_239:
				goto IL_CB;
				IL_127:
				num3 = (short)1047986186;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_40:
			global::SevenZip.a.a = new uint[256];
			num5 = 0U;
			num3 = (short)967835659;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002390 File Offset: 0x00000590
		public void a()
		{
			short num = (short)749060509;
			short num2 = num;
			num = (short)905953693;
			switch (num2 == num)
			{
			}
			num = (short)2143223809;
			if (num != 0)
			{
			}
			num = (short)181207040;
			short num3 = num;
			num = (short)1447886848;
			if (num != 0)
			{
			}
			this.b = uint.MaxValue;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002440 File Offset: 0x00000640
		public void a(byte A_0)
		{
			short num = (short)734767726;
			short num2 = num;
			num = (short)7055982;
			switch (num2 == num)
			{
			}
			num = (short)126681089;
			if (num != 0)
			{
			}
			num = (short)1107492864;
			short num3 = num;
			num = (short)1577779200;
			if (num != 0)
			{
			}
			this.b = (global::SevenZip.a.a[(int)((byte)this.b ^ A_0)] ^ this.b >> 8);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002508 File Offset: 0x00000708
		public void b(byte[] A_0, uint A_1, uint A_2)
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
					goto IL_D3;
				case 1:
					goto IL_107;
				case 2:
					if (num2 >= A_2)
					{
						num3 = (short)1470758913;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.b = (global::SevenZip.a.a[(int)((byte)this.b ^ A_0[(int)(A_1 + num2)])] ^ this.b >> 8);
					num2 += 1U;
					num3 = (short)932970496;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_D3;
				}
				goto IL_20;
				IL_D3:
				num3 = (short)1323499522;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_107:
			return;
			IL_20:
			num2 = 0U;
			num3 = (short)325574716;
			short num4 = num3;
			num3 = (short)1668866108;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num3 = (short)1538850817;
				if (num3 != 0)
				{
				}
				num3 = (short)1016528896;
				short num5 = num3;
				num3 = (short)515506176;
				if (num3 != 0)
				{
				}
				num3 = (short)833486851;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002660 File Offset: 0x00000860
		public uint b()
		{
			short num = (short)1025258190;
			short num2 = num;
			num = (short)906048206;
			switch (num2 == num)
			{
			}
			num = (short)2080178177;
			if (num != 0)
			{
			}
			num = (short)1177878528;
			short num3 = num;
			num = (short)1613365248;
			if (num != 0)
			{
			}
			return this.b ^ uint.MaxValue;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002714 File Offset: 0x00000914
		private static uint a(byte[] A_0, uint A_1, uint A_2)
		{
			short num = (short)1713287951;
			short num2 = num;
			num = (short)376681231;
			switch (num2 == num)
			{
			}
			num = (short)696844289;
			if (num != 0)
			{
			}
			num = (short)434241536;
			short num3 = num;
			num = (short)1859911680;
			if (num != 0)
			{
			}
			global::SevenZip.a a = new global::SevenZip.a();
			a.b(A_0, A_1, A_2);
			return a.b();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027CC File Offset: 0x000009CC
		private static bool a(uint A_0, byte[] A_1, uint A_2, uint A_3)
		{
			short num = (short)1019887295;
			short num2 = num;
			num = (short)1406942911;
			switch (num2 == num)
			{
			}
			num = (short)1966997505;
			if (num != 0)
			{
			}
			num = (short)1971519488;
			short num3 = num;
			num = (short)1089929216;
			if (num != 0)
			{
			}
			return global::SevenZip.a.a(A_1, A_2, A_3) == A_0;
		}

		// Token: 0x04000003 RID: 3
		public static readonly uint[] a;

		// Token: 0x04000004 RID: 4
		private uint b = uint.MaxValue;
	}
}
