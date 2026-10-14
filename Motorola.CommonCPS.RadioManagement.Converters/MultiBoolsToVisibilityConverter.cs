using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000089 RID: 137
	public class MultiBoolsToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00015844 File Offset: 0x00013A44
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1362690050;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)368207578;
					short num3 = num;
					num = (short)2029807322;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_12E;
					}
					break;
				}
				case 1:
				{
					num = (short)536674304;
					short num4 = num;
					num = (short)1024786435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_15;
				case 3:
					goto IL_7C;
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
					IL_35:
					num = (short)59768833;
					if (num != 0)
					{
					}
					if (!values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.MultiBoolsToVisibilityConverter.<>c.<>9.a)))
					{
						num = (short)491716609;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1178009600;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_7C:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_146;
			IL_12E:
			num = (short)1641873408;
			if (num != 0)
			{
			}
			visibility = global::System.Windows.Visibility.Visible;
			IL_146:
			return visibility;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001599C File Offset: 0x00013B9C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1377107969;
			if (num != 0)
			{
			}
			num = (short)635305984;
			short num2 = num;
			num = (short)339414377;
			short num3 = num;
			num = (short)1162087785;
			switch (num3 == num)
			{
			}
			num = (short)93716480;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
