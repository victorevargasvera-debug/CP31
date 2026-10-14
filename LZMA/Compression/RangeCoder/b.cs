using System;
using System.IO;

namespace SevenZip.Compression.RangeCoder
{
	// Token: 0x0200000D RID: 13
	internal class b
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003688 File Offset: 0x00001888
		public void a(global::System.IO.Stream A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_ED;
				case 2:
					num2 = (short)815857665;
					if (num2 != 0)
					{
					}
					goto IL_ED;
				case 3:
					if (num3 >= 5)
					{
						num2 = (short)695468032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_122;
				}
				goto IL_20;
				IL_ED:
				num2 = (short)382402563;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_122:
			this.c = (this.c << 8 | (uint)((byte)this.d.ReadByte()));
			num3++;
			goto IL_141;
			IL_20:
			num2 = (short)1970227976;
			short num4 = num2;
			num2 = (short)135285512;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_141:
				num2 = (short)1507065857;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)643039232;
				short num5 = num2;
				break;
			}
			}
			num2 = (short)1101070336;
			if (num2 != 0)
			{
			}
			this.d = A_0;
			this.c = 0U;
			this.b = uint.MaxValue;
			num3 = 0;
			num2 = (short)555745282;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000037F0 File Offset: 0x000019F0
		public void a()
		{
			short num = (short)202768384;
			short num2 = num;
			num = (short)251550460;
			short num3 = num;
			num = (short)209017596;
			switch (num3 == num)
			{
			}
			num = (short)540213249;
			if (num != 0)
			{
			}
			num = (short)877199360;
			if (num != 0)
			{
			}
			this.d = null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000038A0 File Offset: 0x00001AA0
		public void e()
		{
			short num = (short)323944448;
			short num2 = num;
			num = (short)855228354;
			short num3 = num;
			num = (short)989249474;
			switch (num3 == num)
			{
			}
			num = (short)1767047169;
			if (num != 0)
			{
			}
			num = (short)1546977280;
			if (num != 0)
			{
			}
			this.d.Close();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003954 File Offset: 0x00001B54
		public void f()
		{
			short num = (short)873201666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1691090944;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 2:
					goto IL_15;
				case 3:
				{
					num = (short)1908867073;
					if (num != 0)
					{
					}
					if (this.b >= 16777216U)
					{
						num = (short)2008416256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)217987311;
					short num4 = num;
					num = (short)98384111;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1742274560;
						if (num != 0)
						{
						}
						this.c = (this.c << 8 | (uint)((byte)this.d.ReadByte()));
						this.b <<= 8;
						num = (short)1512177665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5F;
				IL_15:
				switch (0)
				{
				case 0:
					IL_5F:
					goto IL_61;
				}
				continue;
				IL_61:
				num = (short)1997340675;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003AB8 File Offset: 0x00001CB8
		public void g()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1245511681;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)108593152;
						short num3 = num;
						num = (short)149134506;
						short num4 = num;
						num = (short)1458412714;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)261160960;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						}
						break;
					}
					case 2:
						this.c = (this.c << 8 | (uint)((byte)this.d.ReadByte()));
						this.b <<= 8;
						num = (short)14876672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A8:
					num = (short)1991114753;
					if (num != 0)
					{
					}
					if (this.b >= 16777216U)
					{
						return;
					}
					num = (short)171048962;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003BFC File Offset: 0x00001DFC
		public uint a(uint A_0)
		{
			short num = (short)492306432;
			short num2 = num;
			num = (short)1913127248;
			short num3 = num;
			num = (short)617873744;
			switch (num3 == num)
			{
			}
			num = (short)1264123905;
			if (num != 0)
			{
			}
			num = (short)1109393408;
			if (num != 0)
			{
			}
			return this.c / (this.b /= A_0);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003CBC File Offset: 0x00001EBC
		public void a(uint A_0, uint A_1, uint A_2)
		{
			short num = (short)751173632;
			short num2 = num;
			num = (short)1857371479;
			short num3 = num;
			num = (short)267009367;
			switch (num3 == num)
			{
			}
			num = (short)1059651585;
			if (num != 0)
			{
			}
			num = (short)1755709440;
			if (num != 0)
			{
			}
			this.c -= A_0 * this.b;
			this.b *= A_1;
			this.f();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003D90 File Offset: 0x00001F90
		public uint a(int numTotalBits)
		{
			short num = (short)1709441024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				uint num3;
				uint num4;
				int num5;
				uint num7;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_1C6;
					case 1:
						num3 = (num3 << 8 | (uint)((byte)this.d.ReadByte()));
						num4 <<= 8;
						num = (short)1465974787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (num5 <= 0)
						{
							num = (short)781713412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 >>= 1;
						uint num6 = num3 - num4 >> 31;
						num3 -= (num4 & num6 - 1U);
						num7 = (num7 << 1 | 1U - num6);
						num = (short)477364230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_78;
					case 4:
						goto IL_1FB;
					case 5:
						goto IL_1C6;
					case 6:
						if (num4 < 16777216U)
						{
							num = (short)258998273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_78;
					}
					goto IL_4B;
					IL_78:
					num = (short)1737034017;
					short num8 = num;
					num = (short)48695585;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1869676544;
						short num9 = num;
						num = (short)1162543104;
						if (num != 0)
						{
						}
						num5--;
						num = (short)2050424833;
						if (num != 0)
						{
						}
						num = (short)247660549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1C6:
					num = (short)1576665090;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FB:
				this.b = num4;
				this.c = num3;
				return num7;
				IL_4B:
				num4 = this.b;
				num3 = this.c;
				num7 = 0U;
				num5 = numTotalBits;
				num = (short)1556676608;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003FAC File Offset: 0x000021AC
		public uint a(uint A_0, int A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			uint num4;
			uint result;
			for (;;)
			{
				IL_0A:
				num = (short)1351730107;
				short num2 = num;
				num = (short)1929102267;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15C;
				default:
					num = (short)2023227392;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_E8;
					case 1:
						goto IL_15C;
					case 2:
						if (this.c < num4)
						{
							num = (short)1666777091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = 1U;
						this.c -= num4;
						this.b -= num4;
						num = (short)292356096;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						result = 0U;
						this.b = num4;
						num = (short)200409088;
						short num5 = num;
						num = (short)1886715905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6A;
				}
			}
			IL_E8:
			num = (short)1196228609;
			if (num != 0)
			{
			}
			IL_15C:
			this.f();
			return result;
			IL_6A:
			num4 = (this.b >> A_1) * A_0;
			num = (short)953876482;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0400001C RID: 28
		public const uint a = 16777216U;

		// Token: 0x0400001D RID: 29
		public uint b;

		// Token: 0x0400001E RID: 30
		public uint c;

		// Token: 0x0400001F RID: 31
		public global::System.IO.Stream d;
	}
}
