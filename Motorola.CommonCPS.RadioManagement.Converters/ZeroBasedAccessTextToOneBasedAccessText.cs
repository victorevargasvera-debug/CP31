using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000AD RID: 173
	public class ZeroBasedAccessTextToOneBasedAccessText : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0001B9CC File Offset: 0x00019BCC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			short num;
			int num2;
			string result;
			int num4;
			for (;;)
			{
				IL_13:
				num = (short)1813250049;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)419895375;
					short num3 = num;
					num = (short)1654659151;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						num = (short)220987392;
						if (num != 0)
						{
						}
						result = global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\udeee껰쏲", a_);
						num = (short)13303811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_C1;
				case 2:
					if (num4 >= 10)
					{
						num = (short)1305018368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("냮", a_) + num4.ToString();
					num = (short)917700609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_133;
				}
				goto IL_50;
			}
			IL_C1:
			IL_133:
			num = (short)320471040;
			short num5 = num;
			return result;
			IL_50:
			num4 = int.Parse(value.ToString());
			num4++;
			num = (short)1920401410;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001BB3C File Offset: 0x00019D3C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)262762320;
			short num2 = num;
			num = (short)1529769808;
			switch (num2 == num)
			{
			}
			num = (short)562102272;
			short num3 = num;
			num = (short)112787456;
			if (num != 0)
			{
			}
			num = (short)774569985;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001BC00 File Offset: 0x00019E00
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2085071115 + A_1) + (global::System.IntPtr)35 + (global::System.IntPtr)27 + (global::System.IntPtr)76 + (global::System.IntPtr)41 + (global::System.IntPtr)44);
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
