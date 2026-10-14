using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005F RID: 95
	public class MNISAndCMSCToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1960050691;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily;
				switch (num2)
				{
				case 0:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num = (short)38076418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17F;
				case 1:
				{
					num = (short)1712296838;
					short num3 = num;
					num = (short)1221301126;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C2;
					default:
					{
						num = (short)469958656;
						short num4 = num;
						num = (short)1432748032;
						if (num != 0)
						{
						}
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num = (short)222822405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_178;
					}
					}
					break;
				}
				case 2:
					goto IL_B6;
				case 3:
					num = (short)1046740993;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 4:
					goto IL_7D;
				case 5:
					num = (short)1070661632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_65:
				if (value == null)
				{
					num = (short)82182148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				productFamily = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value;
				IL_C2:
				num = (short)1296826369;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7D:
			return global::System.Windows.Visibility.Visible;
			IL_B6:
			IL_178:
			return global::System.Windows.Visibility.Collapsed;
			IL_17F:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)591430762;
			short num2 = num;
			num = (short)1016890474;
			switch (num2 == num)
			{
			}
			num = (short)259391489;
			if (num != 0)
			{
			}
			num = (short)733216768;
			short num3 = num;
			num = (short)1757347840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
