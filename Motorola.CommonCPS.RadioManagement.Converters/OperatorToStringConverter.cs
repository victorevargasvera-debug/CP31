using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200006F RID: 111
	public class OperatorToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0001223C File Offset: 0x0001043C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)537395200;
			short num2 = num;
			num = (short)1332694125;
			short num3 = num;
			num = (short)1086540909;
			switch (num3 == num)
			{
			}
			num = (short)408551425;
			if (num != 0)
			{
			}
			num = (short)1098252288;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.GetResouce((global::Motorola.CommonCPS.Server.CommonDBConstants.Operator)value);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000122F0 File Offset: 0x000104F0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1177616384;
			short num2 = num;
			num = (short)988597090;
			short num3 = num;
			num = (short)479644514;
			switch (num3 == num)
			{
			}
			num = (short)1573847040;
			if (num != 0)
			{
			}
			num = (short)1410007041;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.GetOperator(value.ToString());
		}
	}
}
