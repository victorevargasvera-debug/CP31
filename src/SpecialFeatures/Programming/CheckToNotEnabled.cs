namespace SpecialFeatures.Programming
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class CheckToNotEnabled : IValueConverter
    {
        public CheckToNotEnabled();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

