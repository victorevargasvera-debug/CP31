using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000029 RID: 41
	internal class SetCategoryAddTopSetCopiesToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600007E RID: 126 RVA: 0x00008DA8 File Offset: 0x00006FA8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			short num2;
			global::System.Windows.Visibility visibility;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (setCategory != null)
					{
						num2 = (short)2078277639;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B4;
				case 1:
				{
					num2 = (short)1364721664;
					short num3 = num2;
					visibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)1258225675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_203;
				case 3:
					if (flag)
					{
						num2 = (short)746389516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					visibility = global::System.Windows.Visibility.Collapsed;
					num2 = (short)1935015942;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_27B;
				case 5:
				{
					num2 = (short)1066572550;
					short num4 = num2;
					num2 = (short)1528142598;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D8;
					default:
						num2 = (short)992542720;
						if (num2 != 0)
						{
						}
						if (flag)
						{
							num2 = (short)928841729;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						visibility = global::System.Windows.Visibility.Visible;
						num2 = (short)1285816322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_1A5;
				case 7:
					num2 = (short)250019853;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (setCategory.IsTopSet)
					{
						num2 = (short)1858666505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D8;
				case 9:
					num2 = (short)1421410307;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)37552136;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_260;
				case 12:
					visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)415432708;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (setCategory.IsShareable)
					{
						num2 = (short)873922570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D8;
				}
				goto IL_51;
				IL_D8:
				num2 = (short)259325957;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1A5:
			IL_203:
			IL_260:
			IL_27B:
			IL_2B4:
			return visibility;
			IL_51:
			num2 = (short)462094337;
			if (num2 != 0)
			{
			}
			visibility = global::System.Windows.Visibility.Collapsed;
			flag = (parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춡풣\udfa5ﮧ쾩\ud8ab", a_));
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num2 = (short)302579712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009070 File Offset: 0x00007270
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1863712768;
			short num2 = num;
			num = (short)1050933707;
			short num3 = num;
			num = (short)104790475;
			switch (num3 == num)
			{
			}
			num = (short)1909194753;
			if (num != 0)
			{
			}
			num = (short)1646264320;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
