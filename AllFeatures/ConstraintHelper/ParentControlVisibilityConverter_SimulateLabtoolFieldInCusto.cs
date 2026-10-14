using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F9 RID: 1529
	public class ParentControlVisibilityConverter_SimulateLabtoolFieldInCustomView : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0F2 RID: 53490 RVA: 0x00C3BE00 File Offset: 0x00C3A000
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)643629066;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)582221831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 1:
					num = (short)250478608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_3D8;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
					{
						num = (short)526712843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CD;
				case 4:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)2084765698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 5:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)567279633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
				case 6:
					num = (short)522321924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)2122252307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)42139654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB;
				case 9:
					num = (short)99942400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				case 11:
					goto IL_30A;
				case 12:
					goto IL_2D4;
				case 13:
					num = (short)1759641605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)196411401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 15:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)2004353036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 16:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1088421901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 17:
				{
					num = (short)1783836652;
					short num3 = num;
					num = (short)1264922604;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D4;
					default:
						num = (short)511377409;
						if (num != 0)
						{
						}
						num = (short)2123694080;
						if (num != 0)
						{
						}
						num = (short)1101332488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 18:
					goto IL_D6;
				case 19:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1286078465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				}
				IL_74:
				num = (short)107151360;
				short num4 = num;
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1019740178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)567345166;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DB:
				num = (short)541261839;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D4:
				num = (short)1048248323;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			return false;
			IL_1AD:
			return bool.Parse(values[3].ToString());
			IL_1C0:
			return bool.Parse(values[3].ToString());
			IL_2CD:
			return true;
			IL_30A:
			return false;
			IL_3D8:
			return false;
			IL_3DD:
			return false;
		}

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x00C3C1F0 File Offset: 0x00C3A3F0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2026303224;
			short num2 = num;
			num = (short)947646200;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1278476288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1292697601;
			if (num != 0)
			{
			}
			num = (short)1912668160;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
