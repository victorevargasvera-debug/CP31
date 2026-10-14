using System;
using System.Runtime.CompilerServices;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000038 RID: 56
	public class UserProvAgencyInfoDoc
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000C628 File Offset: 0x0000A828
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo Data
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)200713803;
				short num2 = num;
				num = (short)409839179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1319174144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1811283969;
				if (num != 0)
				{
				}
				num = (short)1279262720;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)709427201;
				if (num != 0)
				{
				}
				num = (short)1668415488;
				short num2 = num;
				num = (short)247488499;
				short num3 = num;
				num = (short)1462525939;
				switch (num3 == num)
				{
				}
				num = (short)1092288512;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000C79C File Offset: 0x0000A99C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(931366086 + A_1) + (global::System.IntPtr)21 + (global::System.IntPtr)37 + (global::System.IntPtr)2 + (global::System.IntPtr)67 + (global::System.IntPtr)99);
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

		// Token: 0x040000EC RID: 236
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo a;
	}
}
