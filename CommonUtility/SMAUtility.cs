using System;

namespace CommonUtility
{
	// Token: 0x02000051 RID: 81
	public class SMAUtility
	{
		// Token: 0x060001AE RID: 430 RVA: 0x0002E79C File Offset: 0x0002C99C
		public bool Validate(byte? releaseDate, byte? SMADate, byte? warrantyDate)
		{
			short num = (short)1461256192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				byte? b;
				bool result;
				for (;;)
				{
					IL_28:
					int? num4;
					int? num5;
					int? num6;
					int? num7;
					int? num9;
					int? num10;
					int? num12;
					int num13;
					switch (num2)
					{
					case 0:
						if (b == null)
						{
							num = (short)1085800467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)211419150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						b = releaseDate;
						num = (short)1505558539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int? num3 = null;
						num = (short)195493894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num4.GetValueOrDefault() > num5.GetValueOrDefault() & (num4 != null & num5 != null))
						{
							num = (short)1957036040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						num6 = new int?((int)b.GetValueOrDefault());
						goto IL_213;
					case 5:
					{
						int? num3 = null;
						num = (short)32571409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int? num3;
						num6 = num3;
						goto IL_213;
					}
					case 7:
						num7 = new int?((int)b.GetValueOrDefault());
						goto IL_298;
					case 8:
						b = releaseDate;
						num = (short)294453268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						result = false;
						num = (short)1974665231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1290207232;
						short num8 = num;
						int? num3 = null;
						num = (short)350814224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (b == null)
						{
							num = (short)541917194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2088173575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num9 = num5;
						goto IL_32A;
					case 13:
					{
						int? num3;
						num10 = num3;
						goto IL_37B;
					}
					case 14:
						num9 = new int?((int)b.GetValueOrDefault());
						goto IL_32A;
					case 15:
					{
						num = (short)2010833024;
						short num11 = num;
						num = (short)1722409088;
						switch ((num11 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_52D;
						}
						break;
					}
					case 16:
					{
						int? num3;
						num7 = num3;
						goto IL_298;
					}
					case 17:
					{
						int? num3;
						num12 = num3;
						goto IL_400;
					}
					case 18:
						num12 = new int?((int)b.GetValueOrDefault());
						goto IL_400;
					case 19:
						num5 = null;
						num = (short)1981808652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (b == null)
						{
							num = (short)1640693765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1117782034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (num5.GetValueOrDefault() > num4.GetValueOrDefault() & (num5 != null & num4 != null))
						{
							num = (short)407306249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 22:
						if (num4.GetValueOrDefault() > num13 & num4 != null)
						{
							num = (short)1897136129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 23:
					{
						int? num3 = null;
						num = (short)1009975309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)969932801;
						if (num != 0)
						{
						}
						if (b == null)
						{
							num = (short)205127703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1943797786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (b == null)
						{
							num = (short)2091712514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1912930308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num10 = new int?((int)b.GetValueOrDefault());
						goto IL_37B;
					}
					goto IL_9B;
					IL_213:
					num5 = num6;
					num = (short)1104478211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_298:
					num4 = num7;
					b = SMADate;
					num = (short)421462041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num4 = num9;
					num13 = 1;
					num = (short)33619990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num4 = num10;
					num = (short)1107689493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_400:
					num5 = num12;
					b = warrantyDate;
					num = (short)1345454104;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_52D:
				num = (short)1920466944;
				if (num != 0)
				{
				}
				return result;
				IL_9B:
				result = true;
				b = releaseDate;
				num = (short)1409548288;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
