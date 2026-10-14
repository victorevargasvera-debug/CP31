using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200000B RID: 11
	public class ContextMenuInRootNodeVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003190 File Offset: 0x00001390
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1545817596;
			short num2 = num;
			num = (short)67259900;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1874395136;
				if (num != 0)
				{
				}
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
				{
					return global::System.Windows.Visibility.Visible;
				}
				break;
			}
			num = (short)831848449;
			if (num != 0)
			{
			}
			num = (short)690749440;
			short num3 = num;
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003250 File Offset: 0x00001450
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1818230784;
			short num2 = num;
			num = (short)1107229837;
			short num3 = num;
			num = (short)690879629;
			switch (num3 == num)
			{
			}
			num = (short)1038417921;
			if (num != 0)
			{
			}
			num = (short)124059648;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
