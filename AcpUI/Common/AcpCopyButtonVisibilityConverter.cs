using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000085 RID: 133
	public class AcpCopyButtonVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005FE RID: 1534 RVA: 0x0007AB84 File Offset: 0x00078D84
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)364118027;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)848560137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43C;
				case 1:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (!acpFieldBase.BlockDataTransfer)
					{
						num = (short)776404996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				}
				case 2:
					goto IL_103;
				case 3:
					num = (short)1301020673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1377763329;
					if (num != 0)
					{
					}
					num = (short)769064982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!(values[1] is global::AcpBusinessLayer.AcpKeyField))
					{
						num = (short)813170690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 6:
					num = (short)1658650624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)341508101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1272709127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 9:
					num = (short)73531406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1C6;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 12:
					goto IL_BF;
				case 13:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase = values[1] as global::AcpBusinessLayer.AcpFieldBase;
					num = (short)1563951112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)65536023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43C;
				case 15:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1728774150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43C;
				case 16:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1627586573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43C;
				case 17:
					if (!(values[1] is global::AcpCommonLib.IAcpPointerField))
					{
						num = (short)1794441237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 18:
					num = (short)488374291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (bool.Parse(values[3].ToString()))
					{
						num = (short)2079916042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 20:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (acpFieldBase != null)
					{
						num = (short)334561283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				}
				case 21:
					num = (short)596246548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)496304146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_279;
				case 23:
				{
					num = (short)498317936;
					short num3 = num;
					num = (short)1307622000;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						num = (short)1660551168;
						if (num != 0)
						{
						}
						num = (short)1195835408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_84:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)2140995596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)847642639;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_103:
				num = (short)1330774033;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BF:
			return false;
			IL_1C6:
			return true;
			IL_279:
			num = (short)1197801472;
			short num4 = num;
			return false;
			IL_43C:
			return false;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0007AFD4 File Offset: 0x000791D4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)346987115;
			short num2 = num;
			num = (short)93559403;
			switch (num2 == num)
			{
			}
			num = (short)1272512513;
			if (num != 0)
			{
			}
			num = (short)532217856;
			if (num != 0)
			{
			}
			num = (short)1565589504;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
