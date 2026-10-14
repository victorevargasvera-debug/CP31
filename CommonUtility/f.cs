using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000005 RID: 5
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class f
{
	// Token: 0x06000023 RID: 35 RVA: 0x00003F60 File Offset: 0x00002160
	internal static uint a(string A_0)
	{
		short num = (short)1347158018;
		int num2 = (int)((global::System.IntPtr)num);
		uint num4;
		for (;;)
		{
			switch (num2)
			{
			case 0:
			{
				num = (short)826671105;
				if (num != 0)
				{
				}
				int num3;
				if (num3 >= A_0.Length)
				{
					num = (short)101122053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num4 = ((uint)A_0[num3] ^ num4) * 16777619U;
				num3++;
				num = (short)2013396996;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			case 1:
				goto IL_5C;
			case 2:
				switch (0)
				{
				case 0:
					goto IL_3D;
				}
				continue;
			case 3:
			{
				num = (short)134493420;
				short num5 = num;
				num = (short)1255290092;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1918566400;
					if (num != 0)
					{
					}
					num4 = 2166136261U;
					int num3 = 0;
					num = (short)830406657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				break;
			}
			case 4:
				goto IL_5C;
			case 5:
				return num4;
			}
			IL_3D:
			if (A_0 != null)
			{
				num = (short)1622081539;
				num2 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_5C:
			num = (short)943587328;
			short num6 = num;
			num = (short)1918042112;
			num2 = (int)((global::System.IntPtr)num);
		}
		return num4;
	}

	// Token: 0x04000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	internal static readonly global::f.a a;

	// Token: 0x02000006 RID: 6
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct a
	{
	}
}
