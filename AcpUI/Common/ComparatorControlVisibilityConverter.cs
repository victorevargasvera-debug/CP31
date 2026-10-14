using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000087 RID: 135
	public class ComparatorControlVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x0007B4A4 File Offset: 0x000796A4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)728367105;
			if (num != 0)
			{
			}
			num = (short)106364931;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)294518789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_238;
				case 1:
					goto IL_AB;
				case 2:
					num = (short)332791815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				case 4:
					goto IL_116;
				case 5:
					num = (short)1865023496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)803995657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_238;
				case 7:
				{
					num = (short)679608320;
					short num3 = num;
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)296026116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				}
				case 8:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)914620418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				case 9:
				{
					num = (short)358365266;
					short num4 = num;
					num = (short)1843279954;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)29491200;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1592393728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_73:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)2028339201;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)780337158;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_AB:
			return false;
			IL_116:
			return true;
			IL_1E5:
			return false;
			IL_238:
			return false;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0007B6F0 File Offset: 0x000798F0
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)904730304;
			short num2 = num;
			num = (short)725751488;
			switch (num2 == num)
			{
			}
			num = (short)333185025;
			if (num != 0)
			{
			}
			num = (short)157876224;
			if (num != 0)
			{
			}
			num = (short)804519936;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
