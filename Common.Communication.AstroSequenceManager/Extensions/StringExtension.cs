using System;
using System.Text;

namespace Motorola.Common.Communication.Extensions
{
	// Token: 0x02000036 RID: 54
	public static class StringExtension
	{
		// Token: 0x06000192 RID: 402 RVA: 0x0002814C File Offset: 0x0002634C
		public static string ToEncodedBase64(this string stringToEncode)
		{
			short num = (short)203096064;
			short num2 = num;
			num = (short)474324312;
			short num3 = num;
			num = (short)902536536;
			switch (num3 == num)
			{
			}
			num = (short)306970625;
			if (num != 0)
			{
			}
			num = (short)1103560704;
			if (num != 0)
			{
			}
			return global::System.Convert.ToBase64String(global::System.Text.Encoding.UTF8.GetBytes(stringToEncode));
		}
	}
}
