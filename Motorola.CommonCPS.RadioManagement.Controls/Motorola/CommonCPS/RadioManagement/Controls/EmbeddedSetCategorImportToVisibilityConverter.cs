using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000013 RID: 19
	internal class EmbeddedSetCategorImportToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004624 File Offset: 0x00002824
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num = (short)864550913;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				IL_3B:
				switch (num2)
				{
				case 0:
					goto IL_86;
				case 1:
					goto IL_150;
				case 2:
				{
					num = (short)417814672;
					short num3 = num;
					num = (short)1254119568;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num = (short)1920466944;
						if (num != 0)
						{
						}
						if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪜좠힢삤\ud9a8\udbaa", a_)))
						{
							num = (short)1052377089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					}
					break;
				}
				case 3:
					if (setCategory != null)
					{
						num = (short)423231488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
				}
				goto IL_51;
				IL_86:
				num = (short)2097152;
				short num4 = num;
				num = (short)139329538;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_88:
			return global::System.Windows.Visibility.Collapsed;
			IL_150:
			goto IL_88;
			IL_155:
			return global::System.Windows.Visibility.Visible;
			IL_51:
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num = (short)1148321795;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000478C File Offset: 0x0000298C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)875797926;
			short num2 = num;
			num = (short)1679334822;
			switch (num2 == num)
			{
			}
			num = (short)1618739200;
			short num3 = num;
			num = (short)1507721217;
			if (num != 0)
			{
			}
			num = (short)340131840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
