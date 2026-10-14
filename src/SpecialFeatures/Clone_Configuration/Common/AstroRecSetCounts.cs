namespace SpecialFeatures.Clone_Configuration.Common
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml;

    public static class AstroRecSetCounts
    {
        public static XmlDocument GetXmlDocument(string xmlData);
        public static List<AstroRecSetCountsItem> LoadRecSetItemsFromXml(string xmlData);
        public static List<AstroRecSetCountsItem> LoadRecSetItemsFromXml(XmlDocument doc);
        public static XmlDocument LoadRecSetItemsToXmlDoc(List<AstroRecSetCountsItem> recSetItems);
        public static string PopulateAstroRecSetCounts();

        [CompilerGenerated]
        private sealed class <>c__DisplayClass3_0
        {
            public AstroRecSetCountsItem item;

            public <>c__DisplayClass3_0();
            internal bool <LoadRecSetItemsToXmlDoc>b__0(AstroRecSetCountsItem x);
            internal bool <LoadRecSetItemsToXmlDoc>b__1(AstroRecSetCountsItem x);
        }
    }
}

