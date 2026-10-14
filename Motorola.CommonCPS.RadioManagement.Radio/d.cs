using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class d
{
	// Token: 0x06000008 RID: 8 RVA: 0x00002580 File Offset: 0x00000780
	internal static uint a(string A_0)
	{
		short num = (short)677511173;
		int num2 = (int)((global::System.IntPtr)num);
		uint num3;
		for (;;)
		{
			switch (num2)
			{
			case 0:
				goto IL_CC;
			case 1:
				return num3;
			case 2:
			{
				int num4;
				if (num4 >= A_0.Length)
				{
					num = (short)1396703233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = ((uint)A_0[num4] ^ num3) * 16777619U;
				num4++;
				num = (short)817430528;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 3:
				num = (short)1994129409;
				if (num != 0)
				{
				}
				goto IL_CC;
			case 4:
			{
				num = (short)1253476532;
				short num5 = num;
				num = (short)1098090676;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_44;
				default:
				{
					num = (short)854196224;
					if (num != 0)
					{
					}
					num = (short)2075459584;
					short num6 = num;
					num3 = 2166136261U;
					int num4 = 0;
					num = (short)290717699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			case 5:
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				continue;
			}
			goto IL_3E;
			IL_44:
			num = (short)452722692;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_3E:
			if (A_0 != null)
			{
				goto IL_44;
			}
			break;
			IL_CC:
			num = (short)2107768834;
			num2 = (int)((global::System.IntPtr)num);
		}
		return num3;
	}
}
