using System;

namespace AcpModelTieringLib
{
	// Token: 0x0200000F RID: 15
	public class ErrorException : global::System.Exception
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00010594 File Offset: 0x0000E794
		internal ErrorException(long A_0, string A_1)
		{
			this._message = A_1;
			this._messageId = A_0;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000105B8 File Offset: 0x0000E7B8
		internal ErrorException(string A_0)
		{
			this._message = A_0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000105D4 File Offset: 0x0000E7D4
		internal ErrorException(long A_0)
		{
			this._messageId = A_0;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000105F0 File Offset: 0x0000E7F0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1724308981 + A_1) + (global::System.IntPtr)56 + (global::System.IntPtr)12 + (global::System.IntPtr)11 + (global::System.IntPtr)8 + (global::System.IntPtr)98);
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

		// Token: 0x04000040 RID: 64
		public string _message;

		// Token: 0x04000041 RID: 65
		public long _messageId;
	}
}
