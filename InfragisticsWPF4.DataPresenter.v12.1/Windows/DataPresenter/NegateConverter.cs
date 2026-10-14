using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DA RID: 474
	internal class NegateConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06001B67 RID: 7015 RVA: 0x000753CD File Offset: 0x000735CD
		private NegateConverter()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000753D5 File Offset: 0x000735D5
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return -(double)value;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x000753E3 File Offset: 0x000735E3
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000B4F RID: 2895
		internal static readonly global::System.Windows.Data.IValueConverter Instance = new global::Infragistics.Windows.DataPresenter.NegateConverter();
	}
}
