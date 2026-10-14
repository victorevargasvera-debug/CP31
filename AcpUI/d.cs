using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class d
{
	// Token: 0x0600001A RID: 26 RVA: 0x00003298 File Offset: 0x00001498
	internal static uint a(string A_0)
	{
		short num = (short)134414339;
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
					num = (short)220200964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = ((uint)A_0[num3] ^ num4) * 16777619U;
				num3++;
				num = (short)349437953;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 1:
				goto IL_59;
			case 2:
			{
				num4 = 2166136261U;
				int num3 = 0;
				num = (short)2101870597;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 3:
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				continue;
			case 4:
				return num4;
			case 5:
			{
				num = (short)1048707073;
				if (num != 0)
				{
				}
				num = (short)1367962855;
				short num5 = num;
				num = (short)1481602279;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_42;
				case 1:
					break;
				default:
				{
					num = (short)1383071744;
					short num6 = num;
					break;
				}
				}
				num = (short)682098688;
				if (num != 0)
				{
				}
				goto IL_59;
			}
			}
			goto IL_3C;
			IL_42:
			num = (short)2138570754;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_3C:
			if (A_0 != null)
			{
				goto IL_42;
			}
			break;
			IL_59:
			num = (short)601423872;
			num2 = (int)((global::System.IntPtr)num);
		}
		return num4;
	}
}
