using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace ControlHeadGraphicView.converters
{
	// Token: 0x02000013 RID: 19
	public class O9GraphicviewEditabilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x000C6DC0 File Offset: 0x000C4FC0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1632632848;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A6;
				case 1:
					goto IL_208;
				case 2:
					if (values[2] != null)
					{
						num = (short)1268514822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25A;
				case 3:
					num = (short)276693001;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)95879171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 5:
					goto IL_258;
				case 6:
					num = (short)1486422033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (((global::AcpBusinessLayer.AcpFieldBase)values[2]).KeyNameField)
					{
						num = (short)1097138181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25A;
				case 8:
					num = (short)485818370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)885981198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 10:
				{
					num = (short)1312415113;
					short num3 = num;
					num = (short)2085936521;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_208;
					default:
					{
						num = (short)1697644545;
						if (num != 0)
						{
						}
						num = (short)1776943104;
						if (num != 0)
						{
						}
						num = (short)945291264;
						short num4 = num;
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)423624705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_367;
					}
					}
					break;
				}
				case 11:
					num = (short)1270153231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if ((global::AcpCommonLib.ApplicationMode)values[0] != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)480378891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20D;
				case 13:
					num = (short)1287847943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)861143052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1595867144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25A;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 17:
					if (!(values[2] is global::AcpBusinessLayer.AcpKeyField))
					{
						num = (short)1647771661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20D;
				}
				IL_6C:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1125318656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1618345994;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_208:
				num = (short)801701892;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			return false;
			IL_20D:
			return false;
			IL_258:
			goto IL_20D;
			IL_25A:
			return bool.Parse(values[1].ToString());
			IL_367:
			return false;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x000C713C File Offset: 0x000C533C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1737288793;
			short num2 = num;
			num = (short)689040473;
			switch (num2 == num)
			{
			default:
			{
				num = (short)777846784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)654835712;
			if (num != 0)
			{
			}
			num = (short)1789722625;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
