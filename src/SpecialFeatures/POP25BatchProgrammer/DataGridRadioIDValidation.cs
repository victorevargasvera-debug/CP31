namespace SpecialFeatures.POP25BatchProgrammer
{
    using System;
    using System.Globalization;
    using System.Windows.Controls;

    public class DataGridRadioIDValidation : ValidationRule
    {
        private int a;
        private int b;

        public DataGridRadioIDValidation();
        public override ValidationResult Validate(object value, CultureInfo cultureInfo);

        internal int MIN { get; set; }

        internal int MAX { get; set; }
    }
}

