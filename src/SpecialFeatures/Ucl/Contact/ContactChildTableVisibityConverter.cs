namespace SpecialFeatures.Ucl.Contact
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class ContactChildTableVisibityConverter : IMultiValueConverter
    {
        public ContactChildTableVisibityConverter();
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
    }
}

