namespace SpecialFeatures.CloneWizard
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class SerialNumberValidMultiConverter : IMultiValueConverter
    {
        public SerialNumberValidMultiConverter();
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture);
    }
}

