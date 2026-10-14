using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000023 RID: 35
	internal class IsApplicableAndIsEditableToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00007F24 File Offset: 0x00006124
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)63635456;
			short num2 = num;
			num = (short)2019753985;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					bool flag;
					if (!flag)
					{
						goto IL_190;
					}
					goto IL_1C7;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 2:
				{
					num = (short)242417665;
					if (num != 0)
					{
					}
					bool flag2;
					if (!flag2)
					{
						num = (short)1725628421;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1939275780;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_1C4;
				case 4:
					goto IL_F6;
				case 5:
					num = (short)254476291;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)457768962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_DD;
				}
				IL_6C:
				num = (short)1325129813;
				short num4 = num;
				num = (short)1776541781;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_190:
					num = (short)1183645702;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)696057856;
					if (num != 0)
					{
					}
					if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)618004487;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						bool flag = (bool)values[0];
						bool flag2 = (bool)values[1];
						num = (short)1669332992;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_DD:
			return global::System.Windows.Visibility.Collapsed;
			IL_F6:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			IL_15D:
			return visibility;
			IL_1C4:
			visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_15D;
			IL_1C7:
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008100 File Offset: 0x00006300
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1666842624;
			short num2 = num;
			num = (short)580962754;
			short num3 = num;
			num = (short)1542048194;
			switch (num3 == num)
			{
			}
			num = (short)1290862592;
			if (num != 0)
			{
			}
			num = (short)1151467521;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
