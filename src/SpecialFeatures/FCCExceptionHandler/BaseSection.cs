namespace SpecialFeatures.FCCExceptionHandler
{
    using System;
    using System.Runtime.CompilerServices;

    internal class BaseSection
    {
        [CompilerGenerated]
        private string a;
        [CompilerGenerated]
        private SectionType b;

        public BaseSection();
        public override string ToString();

        public string BandType { get; set; }

        public SectionType FreqType { get; set; }
    }
}

