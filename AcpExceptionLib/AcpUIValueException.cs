using System;

namespace AcpExceptionLib
{
	// Token: 0x02000005 RID: 5
	public class AcpUIValueException : global::System.Exception
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00003704 File Offset: 0x00001904
		internal AcpUIValueException()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003718 File Offset: 0x00001918
		internal AcpUIValueException(string A_0) : base(A_0)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000372C File Offset: 0x0000192C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1749855672 + A_1) + (global::System.IntPtr)68 + (global::System.IntPtr)38 + (global::System.IntPtr)70 + (global::System.IntPtr)68 + (global::System.IntPtr)48);
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
}
