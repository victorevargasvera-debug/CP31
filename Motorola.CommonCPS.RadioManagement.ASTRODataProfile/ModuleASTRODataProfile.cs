using System;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200001D RID: 29
	public class ModuleASTRODataProfile
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000099EC File Offset: 0x00007BEC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(476642253 + A_1) + (global::System.IntPtr)69 + (global::System.IntPtr)54 + (global::System.IntPtr)84);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}
	}
}
