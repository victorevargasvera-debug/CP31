using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000027 RID: 39
	internal class SetCategorImportToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000087A8 File Offset: 0x000069A8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)214564871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)899153921;
					if (num2 != 0)
					{
					}
					if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춣쮥\ud8a7용즫節\udfaf잱ힳ\udeb5", a_)))
					{
						num2 = (short)1072496649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				case 2:
					if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎩\udfab\udaad", a_)))
					{
						num2 = (short)1086652421;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				case 3:
					if (setCategory != null)
					{
						num2 = (short)1844772864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				case 4:
					num2 = (short)1964900358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_141;
				case 6:
					if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("첣쾥\udca7쾩잭쎯욱", a_)))
					{
						num2 = (short)609157128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				case 7:
					if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춣춧\ud8a9얫쮭쎯", a_)))
					{
						num2 = (short)1903493124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_263;
				case 8:
					num2 = (short)518979585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)941906920;
					short num3 = num2;
					num2 = (short)19553256;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)323747840;
						if (num2 != 0)
						{
						}
						num2 = (short)2066153474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_41;
			}
			IL_141:
			IL_20B:
			return global::System.Windows.Visibility.Collapsed;
			IL_263:
			return global::System.Windows.Visibility.Visible;
			IL_41:
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			num2 = (short)45350912;
			short num4 = num2;
			num2 = (short)2018246659;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008A20 File Offset: 0x00006C20
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1831141376;
			short num2 = num;
			num = (short)1847123895;
			short num3 = num;
			num = (short)1058660279;
			switch (num3 == num)
			{
			}
			num = (short)471924737;
			if (num != 0)
			{
			}
			num = (short)1230569472;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
