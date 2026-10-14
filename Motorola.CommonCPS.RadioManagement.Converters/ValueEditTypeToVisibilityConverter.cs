using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000AA RID: 170
	public class ValueEditTypeToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0001B280 File Offset: 0x00019480
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1266417666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1779492076;
				short num3 = num;
				num = (short)1236853996;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2070937600;
					if (num != 0)
					{
					}
					num = (short)1307901953;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_E9;
					case 1:
						if (value.ToString() == parameter.ToString())
						{
							goto IL_11C;
						}
						goto IL_13C;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 3:
						goto IL_133;
					}
					IL_A5:
					num = (short)2000486400;
					short num4 = num;
					if (value == null)
					{
						num = (short)10747904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1294860289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_11C:
				num = (short)234291203;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E9:
			return global::System.Windows.Visibility.Collapsed;
			IL_133:
			return global::System.Windows.Visibility.Visible;
			IL_13C:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001B3D0 File Offset: 0x000195D0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1760561538;
			short num2 = num;
			num = (short)248121730;
			switch (num2 == num)
			{
			}
			num = (short)1700200448;
			short num3 = num;
			num = (short)775028737;
			if (num != 0)
			{
			}
			num = (short)984612864;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
