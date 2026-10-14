using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000038 RID: 56
	public class MultiIsVisibleToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000AA RID: 170 RVA: 0x000099A4 File Offset: 0x00007BA4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1060110339;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1792540672;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)2055313824;
					short num4 = num;
					num = (short)1910413728;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					default:
						num = (short)1176174593;
						if (num != 0)
						{
						}
						num = (short)1201209344;
						if (num != 0)
						{
						}
						num = (short)865140737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_F8;
				case 2:
					goto IL_150;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				if (!values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.MultiIsVisibleToVisibilityConverter.<>c.<>9.a)))
				{
					num = (short)627179520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_139:
				num = (short)1609236482;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F8:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_153;
			IL_150:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_153:
			return visibility;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00009B0C File Offset: 0x00007D0C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1841302136;
			short num2 = num;
			num = (short)1951271544;
			switch (num2 == num)
			{
			}
			num = (short)869269504;
			if (num != 0)
			{
			}
			num = (short)1952841728;
			short num3 = num;
			num = (short)80347137;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
