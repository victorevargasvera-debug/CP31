using System;
using System.Globalization;
using System.Windows.Data;

namespace DevComponents.WpfDock.Converters
{
	// Token: 0x0200005C RID: 92
	[global::System.Windows.Data.ValueConversion(typeof(object), typeof(bool))]
	public class IsStringTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00053344 File Offset: 0x00051544
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)700818439;
			short num2 = num;
			num = (short)37004295;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)396165120;
				if (num != 0)
				{
				}
				if (!(value is string))
				{
					return false;
				}
				num = (short)1078984705;
				if (num != 0)
				{
				}
				num = (short)642187264;
				short num3 = num;
				break;
			}
			}
			return true;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00053404 File Offset: 0x00051604
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			short num = (short)412352512;
			short num2 = num;
			num = (short)462894943;
			short num3 = num;
			num = (short)1470379871;
			switch (num3 == num)
			{
			}
			num = (short)1786511361;
			if (num != 0)
			{
			}
			num = (short)1332609024;
			if (num != 0)
			{
			}
			return new global::System.NotSupportedException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("裊ꋌꇎꟐ뛒꟔ꏖ鯘뫚뻜듞쇠跢諤鏦짨飪飬鿮臰鳲蟴菶鳸鿺\uddfc鷾砀⌂焄漆怈砊ⴌ氎縐紒挔爖欘漚砜洞༠", a_));
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000534DC File Offset: 0x000516DC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1242787906 + A_1) + (global::System.IntPtr)71 + (global::System.IntPtr)48 + (global::System.IntPtr)5);
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
