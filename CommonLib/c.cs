using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000008 RID: 8
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class c
{
	// Token: 0x0600001A RID: 26 RVA: 0x0000697C File Offset: 0x00004B7C
	internal static uint a(string A_0)
	{
		short num = (short)420819067;
		short num2 = num;
		num = (short)1739534459;
		uint num3;
		int num4;
		int num5;
		switch ((num2 == num) ? 1 : 0)
		{
		case 0:
		case 2:
			IL_F0:
			num3 = 2166136261U;
			num4 = 0;
			num = (short)1845559296;
			num5 = (int)((global::System.IntPtr)num);
			break;
		case 1:
			goto IL_5D;
		default:
		{
			num = (short)259457024;
			short num6 = num;
			goto IL_5D;
		}
		}
		for (;;)
		{
			IL_B8:
			switch (num5)
			{
			case 0:
				goto IL_F2;
			case 1:
				goto IL_F0;
			case 2:
				if (num4 >= A_0.Length)
				{
					num = (short)1579483141;
					num5 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = ((uint)A_0[num4] ^ num3) * 16777619U;
				num4++;
				num = (short)1650982916;
				num5 = (int)((global::System.IntPtr)num);
				continue;
			case 3:
				switch (0)
				{
				case 0:
					goto IL_D6;
				}
				continue;
			case 4:
				goto IL_F2;
			case 5:
				return num3;
			}
			IL_D6:
			if (A_0 != null)
			{
				num = (short)240648193;
				num5 = (int)((global::System.IntPtr)num);
				continue;
			}
			break;
			IL_F2:
			num = (short)405209090;
			num5 = (int)((global::System.IntPtr)num);
		}
		return num3;
		IL_5D:
		num = (short)991363073;
		if (num != 0)
		{
		}
		num = (short)1200029696;
		if (num != 0)
		{
		}
		num = (short)1301544963;
		num5 = (int)((global::System.IntPtr)num);
		goto IL_B8;
	}

	// Token: 0x04000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	internal static readonly global::c.a a;

	// Token: 0x04000032 RID: 50 RVA: 0x00002070 File Offset: 0x00000270
	internal static readonly global::c.b b;

	// Token: 0x02000009 RID: 9
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 32)]
	private struct a
	{
	}

	// Token: 0x0200000A RID: 10
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 128)]
	private struct b
	{
	}
}
