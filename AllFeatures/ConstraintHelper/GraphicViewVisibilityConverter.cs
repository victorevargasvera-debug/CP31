using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F2 RID: 1522
	public class GraphicViewVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D0DD RID: 53469 RVA: 0x00C39C6C File Offset: 0x00C37E6C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)265050717;
			short num2 = num;
			num = (short)1892702813;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13F:
				num = (short)1999372294;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1047265280;
				if (num != 0)
				{
				}
				num = (short)55574529;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			bool flag;
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)430702599;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_9B;
					}
					continue;
				case 2:
					if ((global::AcpCommonLib.ApplicationMode)value != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)2081292291;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21F;
				case 3:
					flag = false;
					num = (short)884932613;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_FF;
				case 5:
					goto IL_11A;
				case 6:
					num = (short)74907650;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (value != global::System.Windows.DependencyProperty.UnsetValue)
					{
						goto IL_13F;
					}
					goto IL_163;
				case 8:
					goto IL_17D;
				case 9:
					if (value != null)
					{
						num = (short)1031405568;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				}
				IL_9B:
				num = (short)1613627393;
				if (num != 0)
				{
				}
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1943404548;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = true;
				num = (short)146800649;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_163:
				flag = false;
				num = (short)1948188680;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			return false;
			IL_11A:
			goto IL_21F;
			IL_17D:
			num = (short)893845504;
			short num4 = num;
			IL_21F:
			return flag;
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x00C39EA0 File Offset: 0x00C380A0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)504823808;
			short num2 = num;
			num = (short)752990827;
			short num3 = num;
			num = (short)2123807339;
			switch (num3 == num)
			{
			}
			num = (short)1514864641;
			if (num != 0)
			{
			}
			num = (short)131268608;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
