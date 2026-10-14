using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000074 RID: 116
	public class QueryToPaneHeaderConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00012C88 File Offset: 0x00010E88
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
			{
				short num = (short)1519176029;
				short num2 = num;
				num = (short)1850329437;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1209008128;
					if (num != 0)
					{
					}
					num = (short)879362049;
					if (num != 0)
					{
					}
					num = (short)1337982976;
					short num3 = num;
					global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType queryType = (global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType)values[0];
					return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꯯觱쓳诵\ud8f7臹췻菽巿⼁缃㐅甇", a_), global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.GetResouce(queryType), global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Title_Query, values[1]);
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00012D78 File Offset: 0x00010F78
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1068071473;
			short num2 = num;
			num = (short)404716081;
			switch (num2 == num)
			{
			}
			num = (short)2046754817;
			if (num != 0)
			{
			}
			num = (short)712900608;
			if (num != 0)
			{
			}
			num = (short)765198336;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
