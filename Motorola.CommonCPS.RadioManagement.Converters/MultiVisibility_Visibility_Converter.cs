using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200006B RID: 107
	public class MultiVisibility_Visibility_Converter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000145 RID: 325 RVA: 0x00011914 File Offset: 0x0000FB14
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1471021059;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_57;
				case 1:
					goto IL_151;
				case 2:
					goto IL_119;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.MultiVisibility_Visibility_Converter.<>c.<>9.a)))
				{
					num = (short)1804206081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)613613857;
				short num3 = num;
				num = (short)670761249;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)367919105;
					if (num != 0)
					{
					}
					num = (short)1951268864;
					if (num != 0)
					{
					}
					num = (short)124321792;
					short num4 = num;
					num = (short)490143746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_119:
				num = (short)714735616;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_57:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_154;
			IL_151:
			visibility = global::System.Windows.Visibility.Visible;
			IL_154:
			return visibility;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00011A7C File Offset: 0x0000FC7C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)308281344;
			short num2 = num;
			num = (short)1641168870;
			short num3 = num;
			num = (short)150880230;
			switch (num3 == num)
			{
			}
			num = (short)202440705;
			if (num != 0)
			{
			}
			num = (short)230227968;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
