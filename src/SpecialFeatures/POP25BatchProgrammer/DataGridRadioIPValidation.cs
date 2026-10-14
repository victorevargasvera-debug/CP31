namespace SpecialFeatures.POP25BatchProgrammer
{
    using System;
    using System.Globalization;
    using System.Windows.Controls;

    public class DataGridRadioIPValidation : ValidationRule
    {
        public DataGridRadioIPValidation();
        public override ValidationResult Validate(object value, CultureInfo cultureInfo);
    }
}

