namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using System;
    using System.Collections.Generic;

    public class _RecSet
    {
        private string a;
        private string b;
        internal List<_UIFields> UIFields;

        public _RecSet();

        internal string RecTitle { get; set; }

        internal string RecNo { get; set; }
    }
}

