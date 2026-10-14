using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class c
{
	// Token: 0x06000015 RID: 21 RVA: 0x00006208 File Offset: 0x00004408
	internal static uint a(string A_0)
	{
		short num = (short)1234173952;
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
					goto IL_3D;
				}
				continue;
			case 1:
			{
				num3 = 2166136261U;
				int num4 = 0;
				num = (short)1275723780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 2:
				goto IL_5D;
			case 3:
			{
				IL_C1:
				int num4;
				if (num4 >= A_0.Length)
				{
					num = (short)1206714373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = ((uint)A_0[num4] ^ num3) * 16777619U;
				num4++;
				num = (short)1405222912;
				short num5 = num;
				num = (short)1445003266;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 4:
				num = (short)1594556417;
				if (num != 0)
				{
				}
				goto IL_5D;
			case 5:
				return num3;
			}
			IL_3D:
			if (A_0 != null)
			{
				num = (short)1982332929;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_5D:
			num = (short)2094488348;
			short num6 = num;
			num = (short)906451740;
			switch ((num6 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C1;
			default:
				num = (short)1493434368;
				if (num != 0)
				{
				}
				num = (short)815398915;
				num2 = (int)((global::System.IntPtr)num);
				break;
			}
		}
		return num3;
	}
}
