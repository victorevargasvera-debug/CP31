namespace SpecialFeatures.POP25BatchProgrammer
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class IntToBusyStateConverter : IValueConverter
    {
        public IntToBusyStateConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

