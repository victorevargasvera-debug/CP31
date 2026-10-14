using System;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
	internal static string b(string A_0, int A_1)
	{
		char[] array = A_0.ToCharArray();
		int num = (int)((global::System.IntPtr)(97375746 + A_1) + (global::System.IntPtr)48 + (global::System.IntPtr)36 + (global::System.IntPtr)66 + (global::System.IntPtr)33 + (global::System.IntPtr)60);
		int num3;
		int num2;
		if ((num2 = (num3 = 0)) < 1)
		{
			goto IL_6A;
		}
		IL_37:
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
		IL_6A:
		if ((num2 = num3) >= array.Length)
		{
			return string.Intern(new string(array));
		}
		goto IL_37;
	}
}
