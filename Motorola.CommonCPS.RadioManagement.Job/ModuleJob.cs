using System;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000011 RID: 17
	public class ModuleJob
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00005E08 File Offset: 0x00004008
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1051404571 + A_1) + (global::System.IntPtr)93 + (global::System.IntPtr)71 + (global::System.IntPtr)66 + (global::System.IntPtr)14);
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
