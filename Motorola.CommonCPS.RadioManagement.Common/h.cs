using System;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class h
{
	// Token: 0x06000008 RID: 8 RVA: 0x00002AB8 File Offset: 0x00000CB8
	internal static uint a(string A_0)
	{
		short num = (short)1291583490;
		int num2 = (int)((global::System.IntPtr)num);
		uint num5;
		for (;;)
		{
			switch (num2)
			{
			case 0:
				goto IL_17C;
			case 1:
				num = (short)424607745;
				if (num != 0)
				{
				}
				goto IL_A7;
			case 2:
			{
				num = (short)825433435;
				short num3 = num;
				num = (short)902634843;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_17C;
				default:
					num = (short)1897529344;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				}
				break;
			}
			case 3:
			{
				int num4;
				if (num4 >= A_0.Length)
				{
					num = (short)672333828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num5 = ((uint)A_0[num4] ^ num5) * 16777619U;
				num4++;
				num = (short)954073089;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 4:
				return num5;
			case 5:
			{
				num = (short)61472768;
				short num6 = num;
				num5 = 2166136261U;
				int num4 = 0;
				num = (short)1689190400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			}
			IL_86:
			if (A_0 != null)
			{
				num = (short)1280507909;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_A7:
			num = (short)1722482691;
			num2 = (int)((global::System.IntPtr)num);
			continue;
			IL_17C:
			goto IL_A7;
		}
		return num5;
	}
}
