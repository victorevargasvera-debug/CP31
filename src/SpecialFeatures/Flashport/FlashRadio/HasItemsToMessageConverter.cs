namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class HasItemsToMessageConverter : IValueConverter
    {
        public HasItemsToMessageConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

