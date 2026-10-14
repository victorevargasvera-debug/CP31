using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200003E RID: 62
	public sealed class DayOfWeekToStringConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (values == null || values.Length < 1 || values.Length > 2)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			if (!(values[0] is global::System.DayOfWeek))
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			global::System.DayOfWeek day = (global::System.DayOfWeek)values[0];
			global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat format = global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.Abbreviated;
			if (values.Length > 1)
			{
				if (!(values[1] is global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat))
				{
					return global::System.Windows.DependencyProperty.UnsetValue;
				}
				format = (global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat)values[1];
			}
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			global::System.Globalization.DateTimeFormatInfo dateTimeFormat = culture.DateTimeFormat;
			return global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(format, day, dateTimeFormat);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00011B78 File Offset: 0x0000FD78
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return new object[]
			{
				global::System.Windows.Data.Binding.DoNothing
			};
		}
	}
}
