using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200014B RID: 331
	public class SummaryResultFormatStringValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000ABA RID: 2746 RVA: 0x00028E50 File Offset: 0x00027050
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.SummaryResult summaryResult = value as global::Infragistics.SummaryResult;
			if (summaryResult == null || summaryResult.SummaryDefinition.SummaryOperand == null)
			{
				return value;
			}
			if (!string.IsNullOrEmpty(summaryResult.SummaryDefinition.SummaryOperand.FormatString))
			{
				return string.Format(summaryResult.SummaryDefinition.SummaryOperand.FormatString, summaryResult.Value);
			}
			return global::System.Convert.ChangeType(summaryResult.Value, targetType, global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00028EBA File Offset: 0x000270BA
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
