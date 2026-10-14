using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000022 RID: 34
	internal class FrequencyRangeConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00007C60 File Offset: 0x00005E60
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 3;
			short num = (short)2036006913;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit stringEdit;
			global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit stringEdit2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 2:
					goto IL_9B;
				case 3:
				{
					num = (short)1280890938;
					short num3 = num;
					num = (short)742250554;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
						goto IL_182;
					}
					break;
				}
				case 4:
					if (stringEdit == null)
					{
						num = (short)1130364930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				case 5:
					if (stringEdit2 != null)
					{
						num = (short)1063190528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C2;
				case 6:
				{
					if (values.Length != 2)
					{
						num = (short)1758003203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringEdit2 = (values[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit);
					stringEdit = (values[1] as global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit);
					num = (short)460718080;
					short num4 = num;
					num = (short)1094778885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)857604102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4D:
				if (values != null)
				{
					num = (short)1875443719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C8;
				IL_6C:
				num = (short)2086797316;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			goto IL_1C2;
			IL_182:
			num = (short)868089857;
			if (num != 0)
			{
			}
			num = (short)1128202240;
			if (num != 0)
			{
			}
			goto IL_1C8;
			IL_1C2:
			return string.Empty;
			IL_1C8:
			return string.Empty;
			IL_1CE:
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("궜\udfa0\ud8a2钤\udaa6", a_), stringEdit2.Text, stringEdit.Text);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007E60 File Offset: 0x00006060
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1550889645;
			short num2 = num;
			num = (short)413512365;
			switch (num2 == num)
			{
			}
			num = (short)1395261441;
			if (num != 0)
			{
			}
			num = (short)1467547648;
			if (num != 0)
			{
			}
			num = (short)1283719168;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
