using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E2 RID: 226
	internal class ItemsMoverIsCanSetPriorityToIconWidthConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x00063D98 File Offset: 0x00061F98
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 15;
			short num = (short)774108234;
			short num2 = num;
			num = (short)2143941706;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1105723392;
				if (num != 0)
				{
				}
				num = (short)456785921;
				if (num != 0)
				{
				}
				if ((bool)value)
				{
					num = (short)863436800;
					short num3 = num;
					return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udca8\udfaa슬", a_);
				}
				break;
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鞦", a_);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00063E74 File Offset: 0x00062074
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1250613355;
			short num2 = num;
			num = (short)18143339;
			switch (num2 == num)
			{
			}
			num = (short)1876426752;
			if (num != 0)
			{
			}
			num = (short)474415104;
			short num3 = num;
			num = (short)188809217;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
