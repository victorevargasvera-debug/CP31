using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000009 RID: 9
	internal class ActiveCellToContactSetCategoryConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002E88 File Offset: 0x00001088
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase fieldBase;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)116457473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (setCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좗\ud999캛\udd9d쾟첡킣장쮧\udea9\udfab", a_))
					{
						num2 = (short)1275265030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_185;
				case 2:
					if (setCategory != null)
					{
						goto IL_237;
					}
					goto IL_254;
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
					if (set != null)
					{
						num2 = (short)1935867908;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				}
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set;
					setCategory = (set.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
					num2 = (short)1722613760;
					short num3 = num2;
					num2 = (short)1130946880;
					short num4 = num2;
					num2 = (short)1865212224;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_237;
					default:
						num2 = (short)1892417536;
						if (num2 != 0)
						{
						}
						num2 = (short)1300430850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_76;
				case 6:
					goto IL_C6;
				case 7:
					if (!(setCategory.Name == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udb97솟송킣", a_)))
					{
						num2 = (short)930938880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return setCategory;
				case 8:
				{
					if (fieldBase == null)
					{
						num2 = (short)1330184197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = fieldBase.Parent as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
					num2 = (short)1519845379;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					num2 = (short)491126785;
					if (num2 != 0)
					{
					}
					num2 = (short)476971015;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_237:
				num2 = (short)856948745;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_76:
			return null;
			IL_C6:
			return setCategory;
			IL_185:
			return setCategory.Parent.Parent.Parent;
			IL_254:
			return null;
			IL_41:
			fieldBase = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase);
			num2 = (short)1895956488;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030EC File Offset: 0x000012EC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1198587904;
			short num2 = num;
			num = (short)2042102988;
			short num3 = num;
			num = (short)650642636;
			switch (num3 == num)
			{
			}
			num = (short)917700608;
			if (num != 0)
			{
			}
			num = (short)881065985;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
