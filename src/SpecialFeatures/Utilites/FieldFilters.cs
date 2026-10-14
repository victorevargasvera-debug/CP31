namespace SpecialFeatures.Utilites
{
    using AcpCommonLib;
    using System;

    public class FieldFilters
    {
        private static string[] a;

        static FieldFilters();
        public FieldFilters();
        public static bool FilterSpecialFieldInReport(IAcpField fld);
    }
}

