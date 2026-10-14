using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000081 RID: 129
	public class EditabilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x000797D4 File Offset: 0x000779D4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2078212107;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)821297162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)2097938445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1517551632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)499187716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 4:
					num = (short)1023737865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1652424711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1579089923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_173;
				case 8:
					num = (short)847446017;
					if (num != 0)
					{
					}
					if ((global::AcpCommonLib.ApplicationMode)values[0] != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)758579205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DD;
				case 9:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)949813262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				case 10:
					if (((global::AcpBusinessLayer.AcpFieldBase)values[2]).KeyNameField)
					{
						num = (short)1689518092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 12:
					goto IL_229;
				case 13:
					if (values[2] != null)
					{
						num = (short)150929408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
				case 14:
					num = (short)306774024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					num = (short)1947855516;
					short num3 = num;
					num = (short)803400348;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						goto IL_DE;
					}
					break;
				}
				case 16:
					if (!(values[2] is global::AcpBusinessLayer.AcpKeyField))
					{
						num = (short)1787756545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DD;
				case 17:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1392967686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_367;
				}
				IL_6D:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1933836303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2036989969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_173:
				if ((global::AcpCommonLib.ApplicationMode)values[0] != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					goto IL_22B;
				}
				num = (short)1698496514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DE:
			num = (short)1051197440;
			if (num != 0)
			{
			}
			num = (short)285343744;
			short num4 = num;
			return false;
			IL_1DD:
			return false;
			IL_229:
			goto IL_1DD;
			IL_22B:
			return bool.Parse(values[1].ToString());
			IL_367:
			return false;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00079B50 File Offset: 0x00077D50
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1655177217;
			if (num != 0)
			{
			}
			num = (short)1573657130;
			short num2 = num;
			num = (short)1033312810;
			switch (num2 == num)
			{
			}
			num = (short)1695088640;
			if (num != 0)
			{
			}
			num = (short)1608646656;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
