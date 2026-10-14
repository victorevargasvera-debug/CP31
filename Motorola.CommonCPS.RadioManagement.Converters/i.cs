using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class i
{
	// Token: 0x06000007 RID: 7 RVA: 0x000022A4 File Offset: 0x000004A4
	internal static uint a(string A_0)
	{
		short num = (short)387055616;
		int num2 = (int)((global::System.IntPtr)num);
		uint num5;
		for (;;)
		{
			int num4;
			switch (num2)
			{
			case 0:
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				continue;
			case 1:
			{
				num = (short)154609087;
				short num3 = num;
				num = (short)2094802367;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_163;
				default:
					num = (short)203030528;
					if (num != 0)
					{
					}
					if (num4 >= A_0.Length)
					{
						num = (short)1953300482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = ((uint)A_0[num4] ^ num5) * 16777619U;
					num4++;
					num = (short)736296965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			case 2:
				return num5;
			case 3:
				goto IL_86;
			case 4:
				goto IL_163;
			case 5:
				goto IL_86;
			}
			IL_3D:
			num = (short)1580531713;
			if (num != 0)
			{
			}
			if (A_0 != null)
			{
				num = (short)1463287812;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_86:
			num = (short)1822621696;
			short num6 = num;
			num = (short)1696399361;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_163:
			num5 = 2166136261U;
			num4 = 0;
			num = (short)1452146691;
			num2 = (int)((global::System.IntPtr)num);
		}
		return num5;
	}
}
