using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200003F RID: 63
	public static class TypeCodeInfo
	{
		// Token: 0x06000276 RID: 630 RVA: 0x00038728 File Offset: 0x00036928
		static TypeCodeInfo()
		{
			short num = (short)1053276031;
			short num2 = num;
			num = (short)1383905151;
			switch (num2 == num)
			{
			}
			num = (short)2062811137;
			if (num != 0)
			{
			}
			num = (short)1404829696;
			if (num != 0)
			{
			}
			num = (short)66387968;
			short num3 = num;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000387D8 File Offset: 0x000369D8
		internal static int g(global::System.TypeCode A_0)
		{
			short num = (short)33097229;
			short num2 = num;
			num = (short)765658637;
			switch (num2 == num)
			{
			}
			num = (short)569114625;
			if (num != 0)
			{
			}
			num = (short)1673592832;
			if (num != 0)
			{
			}
			num = (short)1779892224;
			short num3 = num;
			return global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.f(A_0) - 1;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0003888C File Offset: 0x00036A8C
		internal static int f(global::System.TypeCode A_0)
		{
			while (A_0 != global::System.TypeCode.Boolean)
			{
				short num = (short)1836777472;
				short num2 = num;
				num = (short)1727725569;
				if (num != 0)
				{
				}
				num = (short)1643614298;
				short num3 = num;
				num = (short)1439797338;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)41615360;
					if (num != 0)
					{
					}
					return global::Motorola.Acp.PackUnpack.Ish.TypeCodeInfo.e(A_0) * 8;
				}
			}
			return 1;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00038948 File Offset: 0x00036B48
		internal static int e(global::System.TypeCode A_0)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			int result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_D7;
				case 1:
					goto IL_1F6;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					return result;
				case 5:
					goto IL_1C3;
				case 6:
					goto IL_135;
				case 7:
					goto IL_17D;
				case 8:
					switch (A_0)
					{
					case global::System.TypeCode.Boolean:
					{
						result = 1;
						num2 = (short)1682440192;
						short num3 = num2;
						num2 = (short)37683207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case global::System.TypeCode.Char:
					case global::System.TypeCode.Single:
					case global::System.TypeCode.Double:
						goto IL_1C8;
					case global::System.TypeCode.SByte:
						result = 1;
						num2 = (short)778895371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Byte:
						result = 1;
						num2 = (short)814678020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Int16:
						result = 2;
						num2 = (short)665649153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt16:
						result = 2;
						num2 = (short)709099522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.Int32:
						result = 4;
						num2 = (short)1680015369;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt32:
						break;
					case global::System.TypeCode.Int64:
						result = 8;
						num2 = (short)1553399808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::System.TypeCode.UInt64:
					{
						result = 8;
						num2 = (short)995534597;
						short num4 = num2;
						num2 = (short)1858447109;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1435041792;
							if (num2 != 0)
							{
							}
							num2 = (short)628359171;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case global::System.TypeCode.Decimal:
						result = 16;
						num2 = (short)970981382;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1266286602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = 4;
					num2 = (short)1201143813;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_F7;
				case 10:
					num2 = (short)1034813452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_116;
				case 12:
					goto IL_212;
				}
				goto IL_4D;
			}
			IL_D7:
			IL_F7:
			IL_116:
			IL_135:
			return result;
			IL_17D:
			num2 = (short)1460338689;
			if (num2 != 0)
			{
			}
			IL_1C3:
			return result;
			IL_1C8:
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("얟쮣슥춧", a_));
			IL_1F6:
			return result;
			IL_212:
			goto IL_1C8;
			IL_4D:
			result = 0;
			num2 = (short)497090568;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00038C08 File Offset: 0x00036E08
		internal static bool d(global::System.TypeCode A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_AF;
					case 1:
						if (A_0 - global::System.TypeCode.SByte <= 7)
						{
							num2 = (short)1752432642;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = false;
						num2 = (short)208207875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = true;
						num2 = (short)979435520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_6A;
					}
					goto IL_20;
				}
				IL_B1:
				num2 = (short)1721591507;
				short num3 = num2;
				num2 = (short)176645843;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E6;
				}
				IL_6A:
				num2 = (short)1638596608;
				short num4 = num2;
				IL_AF:
				goto IL_B1;
				IL_20:
				result = false;
				num2 = (short)2016870401;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_E6:
			num2 = (short)1724121089;
			if (num2 != 0)
			{
			}
			num2 = (short)1084489728;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00038D38 File Offset: 0x00036F38
		internal static bool c(global::System.TypeCode A_0)
		{
			short num2;
			bool result;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_AD;
					case 1:
						if (A_0 - global::System.TypeCode.Boolean <= 11)
						{
							num2 = (short)1568210946;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = false;
						num2 = (short)996540419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = true;
						num2 = (short)1826684928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_6A;
					}
					goto IL_20;
				}
				IL_AF:
				num2 = (short)1676390775;
				short num3 = num2;
				num2 = (short)2141630839;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E5;
				}
				IL_6A:
				num2 = (short)781058048;
				short num4 = num2;
				IL_AD:
				goto IL_AF;
				IL_20:
				result = false;
				num2 = (short)1346830337;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_E5:
			num2 = (short)295829505;
			if (num2 != 0)
			{
			}
			num2 = (short)730791936;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00038E68 File Offset: 0x00037068
		internal static bool b(global::System.TypeCode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)945871697;
					short num3 = num2;
					num2 = (short)1446501201;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
					{
						num2 = (short)1001193472;
						short num4 = num2;
						num2 = (short)863502336;
						if (num2 != 0)
						{
						}
						goto IL_76;
					}
					}
					break;
				}
				case 1:
					goto IL_8F;
				case 2:
					goto IL_3A;
				case 3:
					num2 = (short)1032650752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				}
				goto IL_24;
				IL_3A:
				switch (A_0)
				{
				case global::System.TypeCode.SByte:
				case global::System.TypeCode.Int16:
				case global::System.TypeCode.Int32:
				case global::System.TypeCode.Int64:
					result = true;
					num2 = (short)403701764;
					num = (int)((global::System.IntPtr)num2);
					break;
				case global::System.TypeCode.Byte:
				case global::System.TypeCode.UInt16:
				case global::System.TypeCode.UInt32:
					IL_76:
					result = false;
					num2 = (short)2011627521;
					num = (int)((global::System.IntPtr)num2);
					break;
				default:
					num2 = (short)834273283;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_8F:
			num2 = (short)726073345;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = false;
			num2 = (short)762642434;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00038FE0 File Offset: 0x000371E0
		internal static bool a(global::System.TypeCode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1870379971;
					short num3 = num2;
					num2 = (short)1548467139;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C;
					default:
					{
						num2 = (short)271450112;
						short num4 = num2;
						num2 = (short)65536000;
						if (num2 != 0)
						{
						}
						goto IL_76;
					}
					}
					break;
				}
				case 1:
					goto IL_90;
				case 2:
					goto IL_3C;
				case 3:
					num2 = (short)739835904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_AE;
				}
				goto IL_24;
				IL_3C:
				switch (A_0)
				{
				case global::System.TypeCode.Byte:
				case global::System.TypeCode.UInt16:
				case global::System.TypeCode.UInt32:
				case global::System.TypeCode.UInt64:
					result = true;
					num2 = (short)2048851972;
					num = (int)((global::System.IntPtr)num2);
					break;
				case global::System.TypeCode.Int16:
				case global::System.TypeCode.Int32:
				case global::System.TypeCode.Int64:
					IL_76:
					result = false;
					num2 = (short)1987903489;
					num = (int)((global::System.IntPtr)num2);
					break;
				default:
					num2 = (short)2118647811;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_90:
			return result;
			IL_AE:
			num2 = (short)569376769;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = false;
			num2 = (short)872153090;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
