using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200002B RID: 43
	internal class SetCategoryTopDropDownButtonToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00009458 File Offset: 0x00007658
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_5B;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				IL_13:
				num = (short)279052288;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)961641558;
					short num4 = num;
					num = (short)1677294678;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2128609281;
						if (num != 0)
						{
						}
						num = (short)11534336;
						if (num != 0)
						{
						}
						if (setCategory == null)
						{
							num = (short)872218625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)139853829;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_102;
				case 2:
					goto IL_11B;
				case 3:
					num = (short)504430594;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_18B;
				case 5:
					if (!(setCategory.Name != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾗얟춣향\udca7", a_)))
					{
						num = (short)543358979;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)622395396;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5B;
			}
			IL_102:
			return global::System.Windows.Visibility.Collapsed;
			IL_11B:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_18E;
			IL_18B:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_18E:
			return visibility;
			IL_5B:
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num = (short)889847808;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000095F8 File Offset: 0x000077F8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1422196736;
			short num2 = num;
			num = (short)24330650;
			short num3 = num;
			num = (short)783696282;
			switch (num3 == num)
			{
			}
			num = (short)1417084928;
			if (num != 0)
			{
			}
			num = (short)1527578625;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
