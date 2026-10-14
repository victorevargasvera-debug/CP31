using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200007F RID: 127
	public class MenuItemsAddBtnConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0007916C File Offset: 0x0007736C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1977090049;
			if (num != 0)
			{
			}
			num = (short)202309641;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1061421057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 1:
					num = (short)1466236933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1226637322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 3:
				{
					int num3;
					int num4;
					if (num3 < num4)
					{
						num = (short)1981546500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_213;
				}
				case 4:
					goto IL_13E;
				case 5:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)212729864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 6:
					goto IL_191;
				case 7:
					goto IL_104;
				case 8:
					num = (short)348717058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 10:
				{
					int num3 = global::System.Convert.ToInt32(values[0]);
					int num4 = global::System.Convert.ToInt32(values[1]);
					num = (short)319553547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					if (global::System.Convert.ToInt32(values[2]) < 0)
					{
						num = (short)764936198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)716767235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7C:
				num = (short)1782364559;
				short num5 = num;
				num = (short)1809430927;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_292;
				default:
					num = (short)182714368;
					if (num != 0)
					{
					}
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)913506311;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)30670848;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_104:
			num = (short)1962082304;
			short num6 = num;
			return false;
			IL_13E:
			return true;
			IL_191:
			return false;
			IL_213:
			return false;
			IL_292:
			return false;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00079414 File Offset: 0x00077614
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)514654209;
			if (num != 0)
			{
			}
			num = (short)503898690;
			short num2 = num;
			num = (short)402907714;
			switch (num2 == num)
			{
			}
			num = (short)1251803136;
			if (num != 0)
			{
			}
			num = (short)636157952;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
