namespace SpecialFeatures.Ucl.Contact
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class DecToHexConverter : IValueConverter
    {
        public DecToHexConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

