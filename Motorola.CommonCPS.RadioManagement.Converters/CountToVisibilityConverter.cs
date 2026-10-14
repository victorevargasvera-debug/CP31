using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000097 RID: 151
	public class CountToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00017BC8 File Offset: 0x00015DC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1305542658;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_123;
				case 1:
				{
					num = (short)1326263524;
					short num3 = num;
					num = (short)640101604;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1631846400;
						if (num != 0)
						{
						}
						num = (short)2106064896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)2002321408;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				}
				case 3:
					goto IL_BC;
				}
				IL_5F:
				num = (short)703594497;
				if (num != 0)
				{
				}
				if ((int)value != 0)
				{
					num = (short)1938096129;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1904345091;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BC:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_126;
			IL_123:
			visibility = global::System.Windows.Visibility.Visible;
			IL_126:
			return visibility;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00017D00 File Offset: 0x00015F00
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1859799920;
			short num2 = num;
			num = (short)1367886704;
			switch (num2 == num)
			{
			}
			num = (short)571473921;
			if (num != 0)
			{
			}
			num = (short)499384320;
			if (num != 0)
			{
			}
			num = (short)402456576;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
