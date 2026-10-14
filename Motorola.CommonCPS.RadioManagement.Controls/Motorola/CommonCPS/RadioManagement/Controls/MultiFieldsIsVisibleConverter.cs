using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000025 RID: 37
	public class MultiFieldsIsVisibleConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000083E8 File Offset: 0x000065E8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1311933344;
			short num2 = num;
			num = (short)1277264800;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_100:
				num = (short)401342468;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1528758273;
				if (num != 0)
				{
				}
				num = (short)206503936;
				if (num != 0)
				{
				}
				num = (short)1368588288;
				short num4 = num;
				num = (short)705036288;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			}
			bool flag;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_D6;
					}
					continue;
				case 1:
					goto IL_F7;
				case 2:
					num = (short)514916353;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_15E;
				case 4:
					if (!flag)
					{
						num = (short)1741029378;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)159973379;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_D6:
			flag = values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsIsVisibleConverter.<>c.<>9.a));
			goto IL_100;
			IL_F7:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_161;
			IL_15E:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_161:
			return visibility;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000855C File Offset: 0x0000675C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1133248512;
			short num2 = num;
			num = (short)1917164955;
			short num3 = num;
			num = (short)807706011;
			switch (num3 == num)
			{
			}
			num = (short)161153025;
			if (num != 0)
			{
			}
			num = (short)1117716480;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
