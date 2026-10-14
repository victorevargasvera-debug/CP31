namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using System;
    using System.Collections.Generic;

    public class _UIFields
    {
        private string a;
        private string b;
        internal List<_Value> values;

        public _UIFields();

        internal string UIFieldName { get; set; }

        internal string UIFieldDes { get; set; }
    }
}

