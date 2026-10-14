using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200008E RID: 142
	public class DateFilterTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0001B244 File Offset: 0x00019444
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value != null)
			{
				global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject dateFilterListDisplayObject = (global::Infragistics.Controls.Grids.Primitives.DateFilterListDisplayObject)value;
				switch (dateFilterListDisplayObject.DateFilterObjectType)
				{
				case global::Infragistics.Controls.Grids.DateFilterObjectType.None:
				case global::Infragistics.Controls.Grids.DateFilterObjectType.All:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_All");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Year:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Year");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Month:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Month");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Date:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Date");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Hour:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Hour");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Minute:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Minute");
				case global::Infragistics.Controls.Grids.DateFilterObjectType.Second:
					return global::Infragistics.SRGrid.GetString("FilterWatermark_Second");
				}
			}
			return global::Infragistics.SRGrid.GetString("FilterWatermark_All");
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0001B2E4 File Offset: 0x000194E4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
