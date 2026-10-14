using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000086 RID: 134
	public class ParentControlVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0007B094 File Offset: 0x00079294
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)813105156;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)32309257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_9B;
				case 2:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1862991877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 3:
					num = (short)1476460545;
					if (num != 0)
					{
					}
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)1019019264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 5:
					num = (short)668008459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1176829966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 7:
					num = (short)1879703555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)688652303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 9:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)805896205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 10:
				{
					if (values[2] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						goto IL_337;
					}
					num = (short)413532160;
					short num3 = num;
					num = (short)2146544740;
					short num4 = num;
					num = (short)2096016484;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_280;
					default:
						num = (short)1079181312;
						if (num != 0)
						{
						}
						num = (short)625278988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1012465671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 12:
					num = (short)732233730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_E0;
				case 14:
					num = (short)594935816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_280;
				}
				IL_64:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)392429569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)855965702;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_280:
				num = (short)1793196042;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			return false;
			IL_E0:
			return false;
			IL_161:
			return bool.Parse(values[3].ToString());
			IL_182:
			return bool.Parse(values[3].ToString());
			IL_337:
			return false;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0007B3E0 File Offset: 0x000795E0
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)501350401;
			if (num != 0)
			{
			}
			num = (short)1127029823;
			short num2 = num;
			num = (short)609885247;
			switch (num2 == num)
			{
			}
			num = (short)296681472;
			if (num != 0)
			{
			}
			num = (short)1471086592;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
