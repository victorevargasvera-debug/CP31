using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000084 RID: 132
	public class AcpRtdInvalidsButtonVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0007A5D0 File Offset: 0x000787D0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1744961552;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1290797064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DC;
				case 1:
					num = (short)1092681730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!(values[1] is global::AcpCommonLib.IAcpPointerField))
					{
						num = (short)641859596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				case 3:
					num = (short)1617035289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)750452757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)2013200398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				case 6:
				{
					global::AcpBusinessLayer.AcpListField acpListField;
					if (acpListField != null)
					{
						num = (short)156499972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				}
				case 7:
					goto IL_227;
				case 8:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase = values[1] as global::AcpBusinessLayer.AcpFieldBase;
					global::AcpBusinessLayer.AcpListField acpListField = acpFieldBase as global::AcpBusinessLayer.AcpListField;
					bool flag = false;
					num = (short)720896000;
					short num3 = num;
					num = (short)601882630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					bool flag;
					if (!flag)
					{
						goto IL_47F;
					}
					goto IL_3B8;
				}
				case 10:
					num = (short)1648754693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_423;
				case 12:
					num = (short)287834125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (acpFieldBase != null)
					{
						num = (short)1743192067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				}
				case 14:
					goto IL_461;
				case 15:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (acpFieldBase.Editable)
					{
						num = (short)1545601031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				}
				case 16:
					switch (0)
					{
					case 0:
						goto IL_98;
					}
					continue;
				case 17:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (!acpFieldBase.HiddenStatic)
					{
						num = (short)1435828243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				}
				case 18:
					num = (short)90701824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)2141454337;
					if (num != 0)
					{
					}
					num = (short)450428943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)451149841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					global::AcpBusinessLayer.AcpListField acpListField;
					if (acpListField.SerializeItems)
					{
						num = (short)671154199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
				}
				case 22:
					num = (short)543948824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
				{
					bool flag = true;
					num = (short)1835401227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 24:
					if (!(values[1] is global::AcpBusinessLayer.AcpKeyField))
					{
						num = (short)1550188545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				case 25:
				{
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					if (acpFieldBase.BlockDataTransfer)
					{
						goto IL_3B8;
					}
					num = (short)1374452790;
					short num4 = num;
					num = (short)234585142;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_47F;
					default:
						num = (short)186515456;
						if (num != 0)
						{
						}
						num = (short)766115860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 26:
					goto IL_D4;
				case 27:
					if ((global::AcpCommonLib.ApplicationMode)values[0] != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1475608586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_461;
				case 28:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)69074962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DC;
				}
				IL_98:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1459355674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1140785180;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_423:
				num = (short)534118427;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_461:
				num = (short)744751113;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_47F:
				num = (short)675414038;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			return false;
			IL_227:
			return true;
			IL_3B8:
			return false;
			IL_4DC:
			return false;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0007AAC0 File Offset: 0x00078CC0
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)834994177;
			if (num != 0)
			{
			}
			num = (short)1147190098;
			short num2 = num;
			num = (short)1396489042;
			switch (num2 == num)
			{
			}
			num = (short)1050935296;
			if (num != 0)
			{
			}
			num = (short)1596915712;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
