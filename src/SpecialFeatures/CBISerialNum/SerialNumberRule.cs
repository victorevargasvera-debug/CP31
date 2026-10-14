namespace SpecialFeatures.CBISerialNum
{
    using System;
    using System.Globalization;
    using System.Windows.Controls;

    public class SerialNumberRule : ValidationRule
    {
        public SerialNumberRule();
        public override ValidationResult Validate(object value, CultureInfo cultureInfo);
    }
}

