using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	internal static class o
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002DDC File Offset: 0x00000FDC
		public static int a(global::Motorola.Common.Communication.SrecType A_0)
		{
			short num = (short)882769922;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
				{
					num = (short)1945897675;
					short num3 = num;
					num = (short)156568267;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_105;
					default:
						goto IL_D2;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 3:
					num = (short)1052639233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)128843776;
					short num4 = num;
					if (A_0 != global::Motorola.Common.Communication.SrecType.S7)
					{
						num = (short)1912668163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 4;
				}
				case 5:
					num = (short)581500928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1324613636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_42:
				num = (short)2058878977;
				if (num != 0)
				{
				}
				if (A_0 != global::Motorola.Common.Communication.SrecType.S0)
				{
					num = (short)1196490757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return 2;
				IL_105:
				if (A_0 == global::Motorola.Common.Communication.SrecType.S3)
				{
					break;
				}
				num = (short)1630142470;
				num2 = (int)((global::System.IntPtr)num);
			}
			return 4;
			IL_D2:
			num = (short)1379074048;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
