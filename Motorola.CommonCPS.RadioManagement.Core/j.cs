using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class j
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
	internal static uint a(string A_0)
	{
		short num = (short)2042888192;
		int num2 = (int)((global::System.IntPtr)num);
		uint num4;
		for (;;)
		{
			switch (num2)
			{
			case 0:
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				continue;
			case 1:
				goto IL_108;
			case 2:
				goto IL_CE;
			case 3:
			{
				num = (short)1399588729;
				short num3 = num;
				num = (short)1854015353;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_147;
				default:
				{
					num = (short)226230272;
					if (num != 0)
					{
					}
					num4 = 2166136261U;
					int num5 = 0;
					num = (short)2082275330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			case 4:
			{
				int num5;
				if (num5 >= A_0.Length)
				{
					num = (short)379387905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = ((uint)A_0[num5] ^ num4) * 16777619U;
				num5++;
				goto IL_147;
			}
			case 5:
				goto IL_CE;
			}
			IL_3C:
			num = (short)1995440129;
			if (num != 0)
			{
			}
			if (A_0 != null)
			{
				num = (short)1843593219;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			return num4;
			IL_CE:
			num = (short)1544880132;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_147:
			num = (short)689242117;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_108:
		num = (short)1767702528;
		short num6 = num;
		return num4;
	}
}
