using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000082 RID: 130
	public class AcpCustomViewCheckBoxVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x00079C10 File Offset: 0x00077E10
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1645674503;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)181403649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 1:
					num = (short)1330249730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)643301377;
					if (num != 0)
					{
					}
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)1867579401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 3:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)2080702470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				case 4:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)898564104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				case 5:
					goto IL_FB;
				case 6:
					num = (short)1391656960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 8:
					num = (short)27328515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_167;
				}
				IL_4D:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1571437850;
					short num3 = num;
					num = (short)1244216602;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FB;
					default:
					{
						num = (short)1212874752;
						short num4 = num;
						num = (short)435355648;
						if (num != 0)
						{
						}
						num = (short)897843205;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				else
				{
					num = (short)1862467588;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_FB:
			return false;
			IL_167:
			return true;
			IL_1E7:
			return false;
			IL_239:
			return false;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00079E5C File Offset: 0x0007805C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)808283654;
			short num2 = num;
			num = (short)1951952390;
			switch (num2 == num)
			{
			}
			num = (short)1226702848;
			if (num != 0)
			{
			}
			num = (short)1845559297;
			if (num != 0)
			{
			}
			num = (short)251133952;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
