namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using System;
    using System.Collections.Generic;

    public class _table : _RecSet
    {
        private string a;
        internal List<_RecSet> RecSet;
        internal List<string> ColTitle;

        public _table();

        internal string TableTitle { get; set; }
    }
}

