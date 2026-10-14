namespace SpecialFeatures.CloneWizard
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class SetCloneBtnLblConverter : IValueConverter
    {
        public SetCloneBtnLblConverter();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture);
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}

