using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000044 RID: 68
	public class SetCategoryCanSaveDiscardConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000CE RID: 206 RVA: 0x0000B3F8 File Offset: 0x000095F8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)1793589248;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 1:
				{
					num = (short)762196804;
					short num3 = num;
					num = (short)1180775236;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10F;
					default:
						goto IL_A9;
					}
					break;
				}
				case 2:
					goto IL_10F;
				case 3:
					if (parameter.ToString().Equals(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("귽懿琁愃", a_)))
					{
						num = (short)1985413122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 4:
					if (setCategory.IsRoot)
					{
						num = (short)1830879239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 5:
					num = (short)733478915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1787625472;
					short num4 = num;
					if (setCategory == null)
					{
						num = (short)1564213249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2050293764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_1DD;
				}
				IL_4D:
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
				{
					num = (short)7733253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1E2;
				IL_10F:
				num = (short)943849473;
				if (num != 0)
				{
				}
				setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
				num = (short)55115782;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A9:
			num = (short)2127560704;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
			IL_137:
			return global::System.Windows.Visibility.Collapsed;
			IL_1DD:
			return global::System.Windows.Visibility.Visible;
			IL_1E2:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000B5F0 File Offset: 0x000097F0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1635603040;
			short num2 = num;
			num = (short)931091040;
			switch (num2 == num)
			{
			}
			num = (short)1981808641;
			if (num != 0)
			{
			}
			num = (short)2060910592;
			short num3 = num;
			num = (short)1404108800;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
