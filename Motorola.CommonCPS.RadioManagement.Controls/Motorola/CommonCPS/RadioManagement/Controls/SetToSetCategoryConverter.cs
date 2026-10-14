using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000030 RID: 48
	internal class SetToSetCategoryConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000A2BC File Offset: 0x000084BC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12D;
				case 1:
					goto IL_10C;
				case 2:
					if (set != null)
					{
						num2 = (short)1673723907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7E;
				case 3:
				{
					num2 = (short)1709572096;
					short num3 = num2;
					num2 = (short)1927675905;
					if (num2 != 0)
					{
					}
					num2 = (short)1376035700;
					short num4 = num2;
					num2 = (short)519807860;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10C;
					default:
						num2 = (short)678363136;
						if (num2 != 0)
						{
						}
						num2 = (short)1473052673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_10C:
				if (set.Parent != null)
				{
					goto IL_132;
				}
				num2 = (short)1637023744;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7E:
			return null;
			IL_12D:
			goto IL_7E;
			IL_132:
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory = set.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory;
			setCategory.ActiveSet = set;
			return new object[]
			{
				setCategory,
				new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>
				{
					set
				}
			};
			IL_20:
			set = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.Set);
			num2 = (short)1584594946;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A42C File Offset: 0x0000862C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)204554035;
			short num2 = num;
			num = (short)571883315;
			switch (num2 == num)
			{
			}
			num = (short)1804271616;
			if (num != 0)
			{
			}
			num = (short)141557761;
			if (num != 0)
			{
			}
			num = (short)14417920;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
