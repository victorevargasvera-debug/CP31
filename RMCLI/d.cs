using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class d
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000254C File Offset: 0x0000074C
	internal static uint a(string A_0)
	{
		short num = (short)1888092165;
		int num2 = (int)((global::System.IntPtr)num);
		uint num4;
		for (;;)
		{
			switch (num2)
			{
			case 0:
			{
				int num3;
				if (num3 >= A_0.Length)
				{
					num = (short)552271874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = ((uint)A_0[num3] ^ num4) * 16777619U;
				num3++;
				num = (short)1843658755;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 1:
				goto IL_5C;
			case 2:
				goto IL_90;
			case 3:
				goto IL_5C;
			case 4:
			{
				num = (short)82509824;
				short num5 = num;
				num4 = 2166136261U;
				int num3 = 0;
				num = (short)2144337921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 5:
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				continue;
			}
			IL_3C:
			if (A_0 != null)
			{
				num = (short)1237778436;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			return num4;
			IL_5C:
			num = (short)1299251200;
			num2 = (int)((global::System.IntPtr)num);
		}
		IL_90:
		num = (short)1589083530;
		short num6 = num;
		num = (short)2038988170;
		switch ((num6 == num) ? 1 : 0)
		{
		case 0:
		case 2:
			break;
		default:
			num = (short)1066401792;
			if (num != 0)
			{
			}
			num = (short)782827521;
			if (num != 0)
			{
			}
			break;
		}
		return num4;
	}
}
