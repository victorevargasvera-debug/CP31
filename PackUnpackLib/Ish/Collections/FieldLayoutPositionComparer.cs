using System;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x0200009A RID: 154
	public class FieldLayoutPositionComparer : global::System.Collections.Generic.IComparer<int>
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x00060AC8 File Offset: 0x0005ECC8
		internal FieldLayoutPositionComparer()
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00060ADC File Offset: 0x0005ECDC
		public int Compare(int x, int y)
		{
			short num = (short)486866944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1388887875;
				short num3 = num;
				num = (short)1950138179;
				int num4;
				int num5;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1E8:
					if (num4 >= num5)
					{
						return 0;
					}
					num = (short)1548419078;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1422786561;
					if (num != 0)
					{
					}
					num = (short)16580608;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					break;
				}
				int num7;
				int num8;
				for (;;)
				{
					IL_9B:
					switch (num2)
					{
					case 0:
						return -1;
					case 1:
						if (num4 > num5)
						{
							num = (short)1098973184;
							short num6 = num;
							num = (short)622198784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1246167044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return -1;
					case 3:
						return 1;
					case 4:
						goto IL_1E8;
					case 5:
						if (num7 < num8)
						{
							num = (short)1058471938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)863371271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return 1;
					case 7:
						if (num7 > num8)
						{
							num = (short)2103050243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1501888513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C2;
				}
				return -1;
				IL_C2:
				num7 = (int)((uint)(x & 536608768) >> 18);
				num4 = (int)((uint)((long)x & (long)((ulong)-536870912)) >> 29);
				num8 = (int)((uint)(y & 536608768) >> 18);
				num5 = (int)((uint)((long)y & (long)((ulong)-536870912)) >> 29);
				num = (short)1425932293;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_9B;
			}
			}
		}
	}
}
