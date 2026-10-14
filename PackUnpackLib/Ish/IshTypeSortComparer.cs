using System;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000030 RID: 48
	public class IshTypeSortComparer : global::System.Collections.Generic.IComparer<global::Motorola.Acp.PackUnpack.Ish.IshType>
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00024798 File Offset: 0x00022998
		internal IshTypeSortComparer()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000247AC File Offset: 0x000229AC
		public int Compare(global::Motorola.Acp.PackUnpack.Ish.IshType x, global::Motorola.Acp.PackUnpack.Ish.IshType y)
		{
			short num = (short)780402688;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1404125847;
					short num3 = num;
					num = (short)2051621527;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
						num = (short)1035993088;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					}
					break;
				}
				case 1:
					return -1;
				case 2:
					return 1;
				case 3:
				{
					num = (short)1062207488;
					short num4 = num;
					if (x.Value < y.Value)
					{
						goto IL_11D;
					}
					return 0;
				}
				}
				IL_83:
				if (x.Value > y.Value)
				{
					num = (short)931069953;
					if (num != 0)
					{
					}
					num = (short)2048327682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1775108099;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11D:
				num = (short)91422721;
				num2 = (int)((global::System.IntPtr)num);
			}
			return 1;
		}
	}
}
