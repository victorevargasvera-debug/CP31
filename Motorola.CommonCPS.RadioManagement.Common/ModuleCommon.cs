using System;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000041 RID: 65
	public class ModuleCommon
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00024FE0 File Offset: 0x000231E0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1754555083 + A_1) + (global::System.IntPtr)37 + (global::System.IntPtr)83 + (global::System.IntPtr)71 + (global::System.IntPtr)71);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}
	}
}
