using System;
using System.Runtime.CompilerServices;

// Token: 0x02000006 RID: 6
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class c
{
	// Token: 0x06000046 RID: 70 RVA: 0x0000AA70 File Offset: 0x00008C70
	internal static uint a(string A_0)
	{
		short num = (short)1357316096;
		int num2 = (int)((global::System.IntPtr)num);
		uint num3;
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
				goto IL_84;
			case 2:
				return num3;
			case 3:
				for (;;)
				{
					num = (short)983695361;
					if (num != 0)
					{
					}
					int num4;
					if (num4 >= A_0.Length)
					{
						break;
					}
					num3 = ((uint)A_0[num4] ^ num3) * 16777619U;
					num4++;
					num = (short)1241818234;
					short num5 = num;
					num = (short)1535812730;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_130;
					}
				}
				num = (short)1050148866;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_130:
				num = (short)2130706432;
				if (num != 0)
				{
				}
				num = (short)1009778689;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			case 4:
			{
				num = (short)1719271424;
				short num6 = num;
				num3 = 2166136261U;
				int num4 = 0;
				num = (short)1910833157;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 5:
				goto IL_84;
			}
			IL_3C:
			if (A_0 != null)
			{
				num = (short)2106916868;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_84:
			num = (short)914292739;
			num2 = (int)((global::System.IntPtr)num);
		}
		return num3;
	}
}
