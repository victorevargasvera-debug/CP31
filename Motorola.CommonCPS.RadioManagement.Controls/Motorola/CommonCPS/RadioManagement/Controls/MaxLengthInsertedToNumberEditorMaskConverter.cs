using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000CB RID: 203
	public class MaxLengthInsertedToNumberEditorMaskConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00059AF4 File Offset: 0x00057CF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)616462910;
			short num2 = num;
			num = (short)1494317630;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2084700160;
				if (num != 0)
				{
				}
				if (parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풛ﮝ\ud89f", a_))
				{
					num = (short)1275068417;
					if (num != 0)
					{
					}
					return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎟쪡얣풥銧톩鲫펭誯花馳辵\ud9b7鞹\udabbﾽ蓁맃믅", a_), global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒛", a_), global::System.Globalization.CultureInfo.InvariantCulture).Length);
				}
				break;
			}
			num = (short)877002752;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎟쪡얣풥銧톩鲫펭誯花馳膵얷잹", a_), global::System.Convert.ToString(global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture), 8).Length);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00059C40 File Offset: 0x00057E40
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)742290456;
			short num2 = num;
			num = (short)204698648;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1311703040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1630142465;
			if (num != 0)
			{
			}
			num = (short)2055143424;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
