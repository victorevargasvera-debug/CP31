namespace SpecialFeatures.DepotLabtool
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class MariRadSoftConverter : IMultiValueConverter
    {
        public MariRadSoftConverter();
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture);
    }
}

