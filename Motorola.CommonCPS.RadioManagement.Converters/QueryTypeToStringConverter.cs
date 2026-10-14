using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000076 RID: 118
	public class QueryTypeToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000166 RID: 358 RVA: 0x000130F4 File Offset: 0x000112F4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1559401788;
			short num2 = num;
			num = (short)219125052;
			switch (num2 == num)
			{
			}
			num = (short)1420427265;
			if (num != 0)
			{
			}
			num = (short)29360128;
			if (num != 0)
			{
			}
			num = (short)1449263104;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.GetResouce((global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType)value);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000131A8 File Offset: 0x000113A8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1623061778;
			short num2 = num;
			num = (short)1642722578;
			switch (num2 == num)
			{
			}
			num = (short)2082865153;
			if (num != 0)
			{
			}
			num = (short)174194688;
			if (num != 0)
			{
			}
			num = (short)1019543552;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.GetQueryType(value.ToString());
		}
	}
}
