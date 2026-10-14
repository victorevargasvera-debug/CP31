namespace SpecialFeatures.VoiceAnnouncements.List
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class VAParentControlVisibilityConverter : IMultiValueConverter
    {
        public VAParentControlVisibilityConverter();
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture);
        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture);
    }
}

