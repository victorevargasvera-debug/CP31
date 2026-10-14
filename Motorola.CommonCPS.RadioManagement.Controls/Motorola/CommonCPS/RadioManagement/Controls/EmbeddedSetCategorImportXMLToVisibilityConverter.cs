using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000012 RID: 18
	internal class EmbeddedSetCategorImportXMLToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000036 RID: 54 RVA: 0x000043A0 File Offset: 0x000025A0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)1472856068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_156;
					case 2:
					{
						num2 = (short)1001632479;
						short num3 = num2;
						num2 = (short)1313321695;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
							num2 = (short)343080960;
							if (num2 != 0)
							{
							}
							if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ude9e", a_)))
							{
								num2 = (short)520880129;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_1AA;
						}
						break;
					}
					case 3:
						num2 = (short)633798658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (!setCategory.Name.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좞즠쪢톤슦\udbaa\uddac", a_)))
						{
							num2 = (short)62193667;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1AA;
					case 5:
						num2 = (short)424935425;
						if (num2 != 0)
						{
						}
						if (setCategory != null)
						{
							num2 = (short)1107755008;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8F;
					}
					goto IL_31;
				}
				IL_8F:
				num2 = (short)1777336320;
				short num4 = num2;
				return global::System.Windows.Visibility.Collapsed;
				IL_156:
				goto IL_8F;
				IL_1AA:
				return global::System.Windows.Visibility.Visible;
			}
			}
			IL_31:
			setCategory = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory);
			IL_38:
			num2 = (short)2108882949;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004560 File Offset: 0x00002760
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)173535116;
			short num2 = num;
			num = (short)1112141708;
			switch (num2 == num)
			{
			}
			num = (short)1739980800;
			short num3 = num;
			num = (short)1727660033;
			if (num != 0)
			{
			}
			num = (short)577830912;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
