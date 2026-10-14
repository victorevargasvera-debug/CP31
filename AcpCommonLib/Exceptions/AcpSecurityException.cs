using System;
using AcpCommonResources;

namespace AcpCommonLib.Exceptions
{
	// Token: 0x02000052 RID: 82
	[global::System.Serializable]
	public class AcpSecurityException : global::System.Exception
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0001D068 File Offset: 0x0001B268
		internal AcpSecurityException() : base(global::AcpCommonResources.AcpResources.Key_Not_Found)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001D080 File Offset: 0x0001B280
		internal AcpSecurityException(string A_0) : base(A_0)
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001D094 File Offset: 0x0001B294
		internal AcpSecurityException(string A_0, global::System.Exception A_1) : base(A_0, A_1)
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001D0AC File Offset: 0x0001B2AC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2018595720 + A_1) + (global::System.IntPtr)19 + (global::System.IntPtr)52 + (global::System.IntPtr)34);
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
