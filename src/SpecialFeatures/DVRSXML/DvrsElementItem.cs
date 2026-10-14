namespace SpecialFeatures.DVRSXML
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DvrsElementItem
    {
        private string a;
        private string b;
        private string c;
        private List<DvrsElementItem> d;

        internal DvrsElementItem(string elementName, string attrValue, string elementValue);
        internal void Add(DvrsElementItem item);

        internal string ElementName { get; }

        internal string AttrValue { get; }

        internal string ElementValue { get; }

        internal List<DvrsElementItem> ChildList { get; }
    }
}

