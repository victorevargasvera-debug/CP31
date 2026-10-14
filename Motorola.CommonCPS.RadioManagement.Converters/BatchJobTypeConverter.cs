using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000083 RID: 131
	public class BatchJobTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00014A94 File Offset: 0x00012C94
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)603796201;
			short num2 = num;
			num = (short)1224815337;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1579352064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1754791937;
			if (num != 0)
			{
			}
			num = (short)595066880;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobType)value).ToResourceString();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00014B48 File Offset: 0x00012D48
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1808014576;
			short num2 = num;
			num = (short)1955601648;
			switch (num2 == num)
			{
			default:
			{
				num = (short)761462784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1486749697;
			if (num != 0)
			{
			}
			num = (short)33882112;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
