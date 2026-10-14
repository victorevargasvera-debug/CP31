using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;

namespace AcpUI.Common
{
	// Token: 0x0200007B RID: 123
	public class ClmVisibilityStausConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x0007859C File Offset: 0x0007679C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)88408071;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
				switch (num2)
				{
				case 0:
					if (!acpFieldBase.HiddenDynamic)
					{
						num = (short)2062745605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AA;
				case 1:
					goto IL_CB;
				case 2:
					num = (short)359333889;
					if (num != 0)
					{
					}
					if (acpFieldBase.HiddenStatic)
					{
						num = (short)420872195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				case 3:
					goto IL_15B;
				case 4:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)446300166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EF;
				case 5:
					num = (short)1490157570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1EA;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (!(bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)757858308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)619985396;
				short num3 = num;
				num = (short)2060663284;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2032599040;
					if (num != 0)
					{
					}
					num = (short)336265217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1EA:
				acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)values[0];
				num = (short)1191051264;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			num = (short)1655701504;
			short num4 = num;
			return global::System.Windows.Visibility.Collapsed;
			IL_15B:
			IL_1AA:
			return global::System.Windows.Visibility.Collapsed;
			IL_1EF:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x000787A0 File Offset: 0x000769A0
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1320067851;
			short num2 = num;
			num = (short)158180107;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2084110336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)362217472;
			if (num != 0)
			{
			}
			num = (short)763101185;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
