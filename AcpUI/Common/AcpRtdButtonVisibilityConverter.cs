using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000083 RID: 131
	public class AcpRtdButtonVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005F8 RID: 1528 RVA: 0x00079F20 File Offset: 0x00078120
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)348127254;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1212481570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1494417408;
						short num3 = num;
						num = (short)1472725013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D7;
				case 2:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)1878655006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 3:
				{
					bool flag;
					if (!flag)
					{
						num = (short)1964113940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				}
				case 4:
					goto IL_2A7;
				case 5:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (!acpFieldBase.BlockDataTransfer)
					{
						num = (short)1663565857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				}
				case 6:
					if (!(values[2] is global::AcpBusinessLayer.AcpKeyField))
					{
						num = (short)1420623872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 7:
					num = (short)906493967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (bool.Parse(values[4].ToString()))
					{
						num = (short)1699282961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 9:
					num = (short)1929904160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)2087583752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1292042265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D7;
				case 12:
				{
					global::AcpBusinessLayer.AcpListField acpListField;
					if (acpListField.SerializeItems)
					{
						num = (short)1415381019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				}
				case 13:
					if (bool.Parse(values[3].ToString()))
					{
						num = (short)823001098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 14:
					num = (short)1949106188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_2FF;
				case 16:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)903348231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D7;
				case 17:
					goto IL_3B1;
				case 18:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase = values[2] as global::AcpBusinessLayer.AcpFieldBase;
					global::AcpBusinessLayer.AcpListField acpListField = acpFieldBase as global::AcpBusinessLayer.AcpListField;
					bool flag = false;
					num = (short)1845231640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					num = (short)715980805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1445330950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1598357520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					continue;
				case 23:
					num = (short)772407298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
				{
					global::AcpBusinessLayer.AcpListField acpListField;
					if (acpListField != null)
					{
						num = (short)1425014798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A7;
				}
				case 25:
					num = (short)910688257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
				{
					num = (short)1785698525;
					short num4 = num;
					num = (short)2061146333;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2FF;
					default:
						num = (short)1372258304;
						if (num != 0)
						{
						}
						num = (short)882180125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 27:
				{
					bool flag = true;
					num = (short)1072037892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 28:
					goto IL_EC;
				case 29:
					if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1993080850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D7;
				case 30:
					num = (short)993722371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1850605591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				case 32:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (acpFieldBase != null)
					{
						num = (short)587989011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				}
				case 33:
					num = (short)1740439565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (!(values[2] is global::AcpCommonLib.IAcpPointerField))
					{
						num = (short)586022921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3DD;
				}
				IL_B1:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)540475420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1124532235;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A7:
				num = (short)1366032415;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FF:
				if (values[3] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					goto IL_5D7;
				}
				num = (short)332202010;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EC:
			return false;
			IL_3B1:
			num = (short)429326337;
			if (num != 0)
			{
			}
			return true;
			IL_3DD:
			return false;
			IL_5D7:
			return false;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0007A50C File Offset: 0x0007870C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)254260173;
			short num2 = num;
			num = (short)1195094989;
			switch (num2 == num)
			{
			}
			num = (short)1700593665;
			if (num != 0)
			{
			}
			num = (short)742719488;
			if (num != 0)
			{
			}
			num = (short)761004032;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
