using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007E RID: 126
	public class QueryConditionToAndOrVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00014184 File Offset: 0x00012384
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if ((global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR), value.ToString()) != global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR.None)
			{
				short num = (short)112328705;
				if (num != 0)
				{
				}
				num = (short)109894963;
				short num2 = num;
				num = (short)72539443;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)399769600;
					if (num != 0)
					{
					}
					num = (short)1459421184;
					short num3 = num;
					return global::System.Windows.Visibility.Visible;
				}
				}
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00014258 File Offset: 0x00012458
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)497256194;
			short num2 = num;
			num = (short)740525826;
			switch (num2 == num)
			{
			}
			num = (short)1262878721;
			if (num != 0)
			{
			}
			num = (short)1821442048;
			if (num != 0)
			{
			}
			num = (short)1168769024;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
