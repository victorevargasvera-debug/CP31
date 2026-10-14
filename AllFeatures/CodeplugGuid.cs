using System;

namespace AllFeatures
{
	// Token: 0x02000604 RID: 1540
	public static class CodeplugGuid
	{
		// Token: 0x0600D116 RID: 53526 RVA: 0x00C3E680 File Offset: 0x00C3C880
		public static string NewGuid()
		{
			int a_ = 9;
			short num = (short)200474624;
			short num2 = num;
			num = (short)1740912090;
			short num3 = num;
			num = (short)922039770;
			switch (num3 == num)
			{
			}
			num = (short)82051073;
			if (num != 0)
			{
			}
			num = (short)1957232640;
			if (num != 0)
			{
			}
			return global::System.Guid.NewGuid().ToString().Replace(global::AllFeatures.CodeplugGuid.b("", a_), "").ToUpper();
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x00C3E764 File Offset: 0x00C3C964
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(868384029 + A_1) + (global::System.IntPtr)90 + (global::System.IntPtr)69 + (global::System.IntPtr)76 + (global::System.IntPtr)91 + (global::System.IntPtr)93);
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
