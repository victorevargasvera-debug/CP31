using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000020 RID: 32
	internal class ControlTypeToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000076E0 File Offset: 0x000058E0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 16;
			short num = (short)1022361600;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_62;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			for (;;)
			{
				IL_3C:
				int num3;
				switch (num3)
				{
				case 0:
				{
					num = (short)422510593;
					if (num != 0)
					{
					}
					if (set.Fields.Count == 0)
					{
						goto IL_1C3;
					}
					string controlType = (set.Fields[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾩\ud9ab쪭\udfaf햳\udab5풷\ud8bb", a_)] as global::Motorola.CommonCPS.RadioManagement.UIModels.IControlType).ControlType;
					num = (short)1100414978;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (set != null)
					{
						num = (short)411500551;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 2:
				{
					string controlType;
					if (!(controlType == parameter.ToString()))
					{
						num = (short)77987845;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1555234819;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_1F5;
				case 4:
					goto IL_105;
				case 5:
					num = (short)642449412;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_1DC;
				case 7:
					num = (short)423952384;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_62;
			}
			IL_105:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_1FF;
			IL_1DC:
			goto IL_1F8;
			IL_1F5:
			visibility = global::System.Windows.Visibility.Visible;
			goto IL_1FF;
			IL_1F8:
			return global::System.Windows.Visibility.Collapsed;
			IL_1FF:
			return visibility;
			IL_62:
			set = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
			num = (short)13743020;
			short num4 = num;
			num = (short)110080940;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C3:
				num = (short)119734278;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_3C;
			}
			default:
			{
				num = (short)1959919616;
				if (num != 0)
				{
				}
				num = (short)835518465;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_3C;
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000078F4 File Offset: 0x00005AF4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2085650437;
			short num2 = num;
			num = (short)1062240261;
			switch (num2 == num)
			{
			}
			num = (short)163119105;
			if (num != 0)
			{
			}
			num = (short)1697841152;
			if (num != 0)
			{
			}
			num = (short)166920192;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
