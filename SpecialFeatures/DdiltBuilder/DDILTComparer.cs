using System;
using System.Collections.Generic;

namespace SpecialFeatures.DdiltBuilder
{
	// Token: 0x02000143 RID: 323
	public class DDILTComparer : global::System.Collections.Generic.IComparer<ushort>
	{
		// Token: 0x060010A3 RID: 4259 RVA: 0x00173FE8 File Offset: 0x001721E8
		public int Compare(ushort x, ushort y)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			int result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1080688640;
					short num3 = num2;
					num2 = (short)1094057985;
					if (num2 != 0)
					{
					}
					if (x == y)
					{
						num2 = (short)1354301444;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
					goto IL_CF;
				case 3:
				{
					if (x >= y)
					{
						goto IL_CF;
					}
					num2 = (short)1990456801;
					short num4 = num2;
					num2 = (short)1257371105;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B0;
					default:
						num2 = (short)2004156416;
						if (num2 != 0)
						{
						}
						num2 = (short)539688965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_B0;
				case 5:
					result = 1;
					num2 = (short)1196294146;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_B0:
				result = 0;
				num2 = (short)1126563841;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CF:
				num2 = (short)381157376;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_28:
			result = -1;
			num2 = (short)658767875;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
