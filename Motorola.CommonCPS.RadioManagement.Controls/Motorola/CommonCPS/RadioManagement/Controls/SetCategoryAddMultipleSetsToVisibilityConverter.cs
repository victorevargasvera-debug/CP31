using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200002D RID: 45
	internal class SetCategoryAddMultipleSetsToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000991C File Offset: 0x00007B1C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_A7;
				case 1:
					num2 = (short)809893896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
					if (!setCategory.IsTopSet)
					{
						num2 = (short)912982020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1895694345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_1E1;
				case 4:
					num2 = (short)1807351819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_C5;
				case 6:
					goto IL_146;
				case 7:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
					{
						num2 = (short)1872232449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1790771202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)110231552;
					short num3 = num2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
					if (!setCategory.IsRoot)
					{
						num2 = (short)525664266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1960181761;
					if (num2 != 0)
					{
					}
					num2 = (short)1700855814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					goto IL_1C4;
				case 10:
					num2 = (short)522977283;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_19A;
				}
				goto IL_40;
			}
			IL_C5:
			return global::System.Windows.Visibility.Collapsed;
			IL_146:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_1A7;
			IL_19A:
			global::System.Windows.Visibility visibility2 = global::System.Windows.Visibility.Visible;
			goto IL_249;
			IL_1A7:
			return visibility;
			IL_1C4:
			visibility2 = global::System.Windows.Visibility.Collapsed;
			goto IL_249;
			IL_1E1:
			visibility = global::System.Windows.Visibility.Visible;
			goto IL_1A7;
			IL_249:
			return visibility2;
			IL_40:
			num2 = (short)2000612935;
			short num4 = num2;
			num2 = (short)415559239;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A7:
				int num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				if (setCategory == null)
				{
					num2 = (short)1905852421;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				num2 = (short)502661127;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1289224192;
				if (num2 != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
				num2 = (short)767098880;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009B78 File Offset: 0x00007D78
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1548156928;
			short num2 = num;
			num = (short)668270593;
			if (num != 0)
			{
			}
			num = (short)980026727;
			short num3 = num;
			num = (short)992413031;
			switch (num3 == num)
			{
			}
			num = (short)1974534144;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
