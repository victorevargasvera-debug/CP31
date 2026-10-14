using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001A RID: 26
	internal class RxGrouplistToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006870 File Offset: 0x00004A70
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1664090113;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_94;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 2:
					goto IL_D0;
				case 3:
				{
					num = (short)2012533640;
					short num3 = num;
					num = (short)419943304;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_94;
					default:
						goto IL_1BA;
					}
					break;
				}
				case 4:
				{
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem item;
					if (list.Contains(item))
					{
						num = (short)13107202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				}
				case 5:
				{
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list;
					if (list != null)
					{
						num = (short)1150615552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				}
				case 6:
				{
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)85590019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)788791296;
					short num4 = num;
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> list = values[0] as global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem item = values[1] as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem;
					num = (short)403439621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)255918086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_46:
				if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)2075459585;
					if (num != 0)
					{
					}
					num = (short)1181220871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D9;
				IL_94:
				num = (short)857407492;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			return global::System.Windows.Visibility.Visible;
			IL_1BA:
			num = (short)1949302784;
			if (num != 0)
			{
			}
			IL_1D9:
			return global::System.Windows.Visibility.Hidden;
			IL_1E0:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006A64 File Offset: 0x00004C64
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1896715685;
			short num2 = num;
			num = (short)1587320229;
			switch (num2 == num)
			{
			}
			num = (short)816578560;
			if (num != 0)
			{
			}
			num = (short)1367212033;
			if (num != 0)
			{
			}
			num = (short)2138243072;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
