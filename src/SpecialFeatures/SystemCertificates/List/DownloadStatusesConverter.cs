namespace SpecialFeatures.SystemCertificates.List
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    [ValueConversion(typeof(TheDownloadStatuses), typeof(string))]
    public class DownloadStatusesConverter : IValueConverter
    {
        public DownloadStatusesConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

