namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class HasItemsToImageConverter : IValueConverter
    {
        public HasItemsToImageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

