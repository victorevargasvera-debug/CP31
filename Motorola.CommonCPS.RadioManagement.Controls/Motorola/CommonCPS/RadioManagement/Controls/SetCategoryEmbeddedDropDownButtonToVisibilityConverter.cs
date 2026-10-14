using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200002C RID: 44
	internal class SetCategoryEmbeddedDropDownButtonToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000096BC File Offset: 0x000078BC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				IL_13:
				num = (short)695926784;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)283226185;
					short num4 = num;
					num = (short)1214885961;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1540292608;
						if (num != 0)
						{
						}
						if (setCategory == null)
						{
							num = (short)898039809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1510080517;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_103;
				case 2:
					goto IL_11D;
				case 3:
					num = (short)781582338;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_189;
				case 5:
					if (!(setCategory.Name != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캥솧\udea9즫\ud9af솱삳", a_)))
					{
						num = (short)1502150659;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1051197444;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_59;
			}
			IL_103:
			return global::System.Windows.Visibility.Collapsed;
			IL_11D:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_18C;
			IL_189:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_18C:
			return visibility;
			IL_59:
			num = (short)843907073;
			if (num != 0)
			{
			}
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num = (short)997785600;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000985C File Offset: 0x00007A5C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1570111488;
			short num2 = num;
			num = (short)1240798153;
			short num3 = num;
			num = (short)1193743305;
			switch (num3 == num)
			{
			}
			num = (short)1531183104;
			if (num != 0)
			{
			}
			num = (short)1244200961;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
