using System;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200000F RID: 15
	internal struct d
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004A30 File Offset: 0x00002C30
		public void a(int A_0, uint A_1)
		{
			short num = (short)755761152;
			short num2 = num;
			num = (short)345047041;
			if (num != 0)
			{
			}
			if (A_1 == 0U)
			{
				num = (short)1132785472;
				short num3 = num;
				num = (short)222490432;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)988020736;
					if (num != 0)
					{
					}
					this.d += 2048U - this.d >> A_0;
					return;
				}
			}
			this.d -= this.d >> A_0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004B18 File Offset: 0x00002D18
		public void a()
		{
			short num = (short)751239168;
			short num2 = num;
			num = (short)1452078865;
			short num3 = num;
			num = (short)1314780945;
			switch (num3 == num)
			{
			}
			num = (short)1647968257;
			if (num != 0)
			{
			}
			num = (short)524615680;
			if (num != 0)
			{
			}
			this.d = 1024U;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004BD0 File Offset: 0x00002DD0
		public uint a(global::SevenZip.Compression.RangeCoder.b A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			uint num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (A_0.c < num2)
					{
						num3 = (short)111935494;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					A_0.b -= num2;
					A_0.c -= num2;
					this.d -= this.d >> 5;
					num3 = (short)1189019650;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					A_0.c = (A_0.c << 8 | (uint)((byte)A_0.d.ReadByte()));
					A_0.b <<= 8;
					num3 = (short)548864004;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					if (A_0.b < 16777216U)
					{
						num3 = (short)818675719;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return 1U;
				case 3:
					goto IL_18C;
				case 4:
				{
					num3 = (short)1455947776;
					short num4 = num3;
					num3 = (short)2006714952;
					short num5 = num3;
					num3 = (short)1533676104;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						goto IL_234;
					}
					break;
				}
				case 5:
					if (A_0.b < 16777216U)
					{
						num3 = (short)1629356033;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return 0U;
				case 6:
					A_0.b = num2;
					this.d += 2048U - this.d >> 5;
					num3 = (short)148635653;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					goto IL_14C;
				}
				goto IL_30;
				IL_14C:
				A_0.c = (A_0.c << 8 | (uint)((byte)A_0.d.ReadByte()));
				A_0.b <<= 8;
				num3 = (short)1801388035;
				num = (int)((global::System.IntPtr)num3);
			}
			return 0U;
			IL_18C:
			return 1U;
			IL_234:
			num3 = (short)760217601;
			if (num3 != 0)
			{
			}
			num3 = (short)888012800;
			if (num3 != 0)
			{
			}
			return 0U;
			IL_30:
			num2 = (A_0.b >> 11) * this.d;
			num3 = (short)878772224;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x04000028 RID: 40
		public const int a = 11;

		// Token: 0x04000029 RID: 41
		public const uint b = 2048U;

		// Token: 0x0400002A RID: 42
		private const int c = 5;

		// Token: 0x0400002B RID: 43
		private uint d;
	}
}
