using System;

namespace Motorola.Common.Communication.Message
{
	// Token: 0x02000012 RID: 18
	public class PCRDnsResponseMessage : global::Motorola.Common.Communication.DnsResponseMessage
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		protected override void ResolveResourceRecord(byte[] bytes, ref int ind, int recordType)
		{
			short num = (short)1948188673;
			if (num != 0)
			{
			}
			num = (short)925260304;
			short num2 = num;
			num = (short)884365840;
			switch (num2 == num)
			{
			}
			num = (short)351928320;
			short num3 = num;
			num = (short)755630080;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000BC80 File Offset: 0x00009E80
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1843623663 + A_1) + (global::System.IntPtr)67 + (global::System.IntPtr)76 + (global::System.IntPtr)35 + (global::System.IntPtr)1 + (global::System.IntPtr)92);
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
