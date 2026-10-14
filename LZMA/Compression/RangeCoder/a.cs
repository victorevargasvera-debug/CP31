using System;
using System.IO;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200000C RID: 12
	internal class a
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000028F4 File Offset: 0x00000AF4
		public void a(global::System.IO.Stream A_0)
		{
			short num = (short)1200722165;
			short num2 = num;
			num = (short)418025717;
			switch (num2 == num)
			{
			}
			num = (short)2121728001;
			if (num != 0)
			{
			}
			num = (short)610336768;
			short num3 = num;
			num = (short)1129512960;
			if (num != 0)
			{
			}
			this.b = A_0;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000029A4 File Offset: 0x00000BA4
		public void a()
		{
			short num = (short)866132172;
			short num2 = num;
			num = (short)2073698508;
			switch (num2 == num)
			{
			}
			num = (short)674430977;
			if (num != 0)
			{
			}
			num = (short)1167065088;
			short num3 = num;
			num = (short)1992818688;
			if (num != 0)
			{
			}
			this.b = null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A54 File Offset: 0x00000C54
		public void b()
		{
			short num = (short)1799684097;
			if (num != 0)
			{
			}
			num = (short)1125663083;
			short num2 = num;
			num = (short)1412972907;
			switch (num2 == num)
			{
			}
			num = (short)1270349824;
			short num3 = num;
			num = (short)1120993280;
			if (num != 0)
			{
			}
			this.g = this.b.Position;
			this.c = 0UL;
			this.d = uint.MaxValue;
			this.e = 1U;
			this.f = 0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B28 File Offset: 0x00000D28
		public void e()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_D6;
				case 1:
					goto IL_10C;
				case 2:
					if (num2 >= 5)
					{
						num3 = (short)169672705;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					this.h();
					num2++;
					num3 = (short)205586432;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					num3 = (short)1118175233;
					if (num3 != 0)
					{
					}
					goto IL_D6;
				}
				goto IL_20;
				IL_D6:
				num3 = (short)2097348610;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_10C:
			return;
			IL_20:
			num2 = 0;
			num3 = (short)1409416135;
			short num4 = num3;
			num3 = (short)1323301831;
			switch ((num4 == num3) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num3 = (short)2000879616;
				if (num3 != 0)
				{
				}
				num3 = (short)1900085248;
				short num5 = num3;
				num3 = (short)1439956995;
				int num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002C68 File Offset: 0x00000E68
		public void f()
		{
			short num = (short)88014849;
			if (num != 0)
			{
			}
			num = (short)105072127;
			short num2 = num;
			num = (short)1453082111;
			switch (num2 == num)
			{
			}
			num = (short)553713664;
			short num3 = num;
			num = (short)268566528;
			if (num != 0)
			{
			}
			this.b.Flush();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002D20 File Offset: 0x00000F20
		public void g()
		{
			short num = (short)1936232845;
			short num2 = num;
			num = (short)1687589261;
			switch (num2 == num)
			{
			}
			num = (short)1060962304;
			if (num != 0)
			{
			}
			num = (short)175964160;
			short num3 = num;
			num = (short)827850753;
			if (num != 0)
			{
			}
			this.b.Close();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002DD4 File Offset: 0x00000FD4
		public void a(uint A_0, uint A_1, uint A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)194379777;
					if (num2 != 0)
					{
					}
					goto IL_DF;
				case 1:
					goto IL_11C;
				case 2:
					if (this.d >= 16777216U)
					{
						num2 = (short)1668349953;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d <<= 8;
					this.h();
					num2 = (short)972226560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_DF;
				}
				goto IL_20;
				IL_DF:
				num2 = (short)257228802;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11C:
			return;
			IL_20:
			this.c += (ulong)(A_0 * (this.d /= A_2));
			this.d *= A_1;
			num2 = (short)519805422;
			short num3 = num2;
			num2 = (short)1494784494;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)1033830400;
				if (num2 != 0)
				{
				}
				num2 = (short)1186791424;
				short num4 = num2;
				num2 = (short)1978138627;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F58 File Offset: 0x00001158
		public void h()
		{
			short num = (short)283836423;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				uint num5;
				switch (num2)
				{
				case 0:
					if ((uint)(this.c >> 32) == 1U)
					{
						num = (short)1248591877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_200;
				case 1:
				{
					num = (short)294093902;
					short num3 = num;
					num = (short)708805710;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						goto IL_1E7;
					}
					break;
				}
				case 2:
				{
					num = (short)475594752;
					short num4 = num;
					num = (short)1320419329;
					if (num != 0)
					{
					}
					if (num5 == 0U)
					{
						num = (short)23724038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				}
				case 3:
					goto IL_71;
				case 4:
					goto IL_6C;
				case 5:
					goto IL_125;
				case 6:
					this.f = (byte)((uint)this.c >> 24);
					num = (short)2124939265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if ((uint)this.c >= 4278190080U)
				{
					num = (short)1609891844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_125;
				IL_6C:
				num = (short)1584791552;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_71:
				byte maxValue;
				this.b.WriteByte((byte)((ulong)maxValue + (this.c >> 32)));
				maxValue = byte.MaxValue;
				num5 = this.e - 1U;
				this.e = num5;
				num = (short)678166530;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_125:
				maxValue = this.f;
				num = (short)1345126403;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1E7:
			num = (short)898301952;
			if (num != 0)
			{
			}
			IL_200:
			this.e += 1U;
			this.c = (ulong)((ulong)((uint)this.c) << 8);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003184 File Offset: 0x00001384
		public void a(uint A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_156;
				case 1:
					goto IL_156;
				case 2:
				{
					num2 = (short)590483386;
					short num3 = num2;
					num2 = (short)326373306;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A5;
					default:
						num2 = (short)533266432;
						if (num2 != 0)
						{
						}
						this.d <<= 8;
						this.h();
						num2 = (short)1981546502;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					if (num4 < 0)
					{
						num2 = (short)1009057795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.d >>= 1;
					num2 = (short)1666187273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_A0;
				case 6:
					goto IL_80;
				case 7:
					this.c += (ulong)this.d;
					goto IL_1A5;
				case 8:
					if (this.d < 16777216U)
					{
						num2 = (short)232194050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_80;
				case 9:
					if ((A_0 >> num4 & 1U) == 1U)
					{
						num2 = (short)248578049;
						if (num2 != 0)
						{
						}
						num2 = (short)1121779719;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A0;
				}
				goto IL_38;
				IL_80:
				num4--;
				num2 = (short)844365824;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A0:
				num2 = (short)387579912;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_156:
				num2 = (short)425852932;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A5:
				num2 = (short)1714028549;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			num2 = (short)149422080;
			short num5 = num2;
			num4 = A_1 - 1;
			num2 = (short)872742913;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000033D4 File Offset: 0x000015D4
		public void a(uint A_0, int A_1, uint A_2)
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
					if (A_2 == 0U)
					{
						num2 = (short)1961558021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.c += (ulong)num3;
					this.d -= num3;
					num2 = (short)1328021510;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_116;
				case 2:
					if (this.d >= 16777216U)
					{
						num2 = (short)830275588;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_68;
				case 3:
					goto IL_116;
				case 4:
				{
					num2 = (short)970291233;
					short num4 = num2;
					num2 = (short)1581873185;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						goto IL_18A;
					}
					break;
				}
				case 5:
					num2 = (short)816054273;
					if (num2 != 0)
					{
					}
					this.d = num3;
					num2 = (short)1726676993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_116;
				}
				goto IL_2C;
				IL_68:
				this.d <<= 8;
				this.h();
				num2 = (short)267517955;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_116:
				num2 = (short)1374289922;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_18A:
			num2 = (short)1398145024;
			if (num2 != 0)
			{
			}
			num2 = (short)157220864;
			short num5 = num2;
			return;
			IL_2C:
			num3 = (this.d >> A_1) * A_0;
			num2 = (short)790102016;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000035AC File Offset: 0x000017AC
		public long i()
		{
			short num = (short)596574208;
			short num2 = num;
			num = (short)1148529690;
			short num3 = num;
			num = (short)350628890;
			switch (num3 == num)
			{
			}
			num = (short)501874689;
			if (num != 0)
			{
			}
			num = (short)433979392;
			if (num != 0)
			{
			}
			return (long)((ulong)this.e + (ulong)this.b.Position - (ulong)this.g + 4UL);
		}

		// Token: 0x04000015 RID: 21
		public const uint a = 16777216U;

		// Token: 0x04000016 RID: 22
		private global::System.IO.Stream b;

		// Token: 0x04000017 RID: 23
		public ulong c;

		// Token: 0x04000018 RID: 24
		public uint d;

		// Token: 0x04000019 RID: 25
		private uint e;

		// Token: 0x0400001A RID: 26
		private byte f;

		// Token: 0x0400001B RID: 27
		private long g;
	}
}
