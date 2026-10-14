using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F8 RID: 1528
	public class CustomViewCheckBoxVisibilityConverter_SimulateLabtoolFieldInCustomView : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D0EF RID: 53487 RVA: 0x00C3BAF4 File Offset: 0x00C39CF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)151257097;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((global::AcpCommonLib.ApplicationMode)value == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1921253378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num = (short)1695023112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)470220800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					flag = (global::AcpCommonLib.AppInfoManager.AppType > global::AcpCommonLib.ApplicationType.CPS);
					num = (short)381157381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_8A;
				case 4:
					num = (short)1280835590;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1084030977;
					if (num != 0)
					{
					}
					num = (short)1212251321;
					short num3 = num;
					num = (short)120749241;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18E;
					case 1:
						goto IL_134;
					}
					goto Block_2;
				}
				case 6:
					if (value != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)459079681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				case 7:
					goto IL_1DC;
				case 8:
					goto IL_1FE;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 10:
					if (value != null)
					{
						num = (short)1233977348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				}
				IL_52:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1620180995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = true;
				IL_18E:
				num = (short)1512833034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C1:
				flag = false;
				num = (short)220004359;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_8A:
			return false;
			Block_2:
			num = (short)483131392;
			short num4 = num;
			IL_134:
			num = (short)2141519872;
			if (num != 0)
			{
			}
			IL_1DC:
			IL_1FE:
			return flag;
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x00C3BD44 File Offset: 0x00C39F44
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2131280003;
			short num2 = num;
			num = (short)1028636803;
			switch (num2 == num)
			{
			}
			num = (short)1534459905;
			if (num != 0)
			{
			}
			num = (short)766312448;
			short num3 = num;
			num = (short)1681063936;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
