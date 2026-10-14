using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonResources;

namespace AcpUI.Common
{
	// Token: 0x02000080 RID: 128
	public class InvalidFieldsDockWndHeaderConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x000794D8 File Offset: 0x000776D8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)1236664326;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string result;
				string invalid_Fields_Report;
				switch (num2)
				{
				case 0:
					return result;
				case 1:
				{
					num = (short)1688875603;
					short num3 = num;
					num = (short)8008275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_129;
					default:
						goto IL_C1;
					}
					break;
				}
				case 2:
				{
					int num4;
					result = invalid_Fields_Report + global::AcpUI.Common.Utility.c("蒣躥", a_) + num4.ToString() + global::AcpUI.Common.Utility.c("趣", a_);
					num = (short)1862926336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return result;
				case 4:
				{
					int num4 = global::System.Convert.ToInt32(value);
					num = (short)1603665928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					return result;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					continue;
				case 7:
					if (value is int)
					{
						num = (short)410648580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = invalid_Fields_Report;
					num = (short)1131610115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					int num4;
					if (num4 > 0)
					{
						num = (short)1598947330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_129;
				}
				}
				IL_53:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1753022465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = null;
				invalid_Fields_Report = global::AcpCommonResources.AcpResources.Invalid_Fields_Report;
				num = (short)1223884807;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_129:
				result = invalid_Fields_Report;
				num = (short)1083375621;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C1:
			num = (short)276889600;
			short num5 = num;
			num = (short)1241186305;
			if (num != 0)
			{
			}
			num = (short)368836608;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00079718 File Offset: 0x00077918
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1408672503;
			short num2 = num;
			num = (short)1908318967;
			switch (num2 == num)
			{
			}
			num = (short)1896480769;
			if (num != 0)
			{
			}
			num = (short)463798272;
			if (num != 0)
			{
			}
			num = (short)1876754432;
			short num3 = num;
			return null;
		}
	}
}
