using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000F6 RID: 246
	internal class UnboundColumnPoisitionValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x0006EF08 File Offset: 0x0006D108
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet flatParentChildSet;
			short num;
			for (;;)
			{
				flatParentChildSet = (value as global::Motorola.CommonCPS.RadioManagement.UIModels.FlatParentChildSet);
				if (!(parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슢힤슦잨\udfaaﺬ쪮얰", a_)))
				{
					goto IL_DD;
				}
				num = (short)2062614528;
				short num2 = num;
				num = (short)1381550382;
				short num3 = num;
				num = (short)1201850670;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_90;
				}
			}
			IL_90:
			num = (short)374210561;
			if (num != 0)
			{
			}
			num = (short)1113587712;
			if (num != 0)
			{
			}
			return flatParentChildSet.ParentSet.Position;
			IL_DD:
			return flatParentChildSet.ChildSet.Position;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0006F004 File Offset: 0x0006D204
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)794636343;
			short num2 = num;
			num = (short)1648242743;
			switch (num2 == num)
			{
			}
			num = (short)1027407873;
			if (num != 0)
			{
			}
			num = (short)667090944;
			short num3 = num;
			num = (short)1380843520;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
