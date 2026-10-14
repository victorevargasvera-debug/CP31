using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x0200008E RID: 142
	public class AcpRecNavToolbarTableModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x0007D0AC File Offset: 0x0007B2AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1801453568;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_69;
				case 2:
					goto IL_14A;
				case 3:
				{
					if ((global::AcpCommonLib.ApplicationMode)value != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_156;
					}
					num = (short)1453878414;
					short num3 = num;
					num = (short)407923854;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						num = (short)554631168;
						if (num != 0)
						{
						}
						num = (short)564985858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_34;
				IL_54:
				num = (short)1126170625;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					goto IL_54;
				}
				num = (short)1858928643;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_69:
			num = (short)694681601;
			if (num != 0)
			{
			}
			num = (short)1520631808;
			short num4 = num;
			return false;
			IL_14A:
			return false;
			IL_156:
			return true;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0007D218 File Offset: 0x0007B418
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2137579729;
			short num2 = num;
			num = (short)269279441;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1060503552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)539164673;
			if (num != 0)
			{
			}
			num = (short)1084096512;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
