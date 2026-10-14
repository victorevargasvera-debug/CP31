namespace SpecialFeatures.Utilities
{
    using System;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable]
    public class AstroASKProgrammingHistory
    {
        [CompilerGenerated]
        private int <Version>k__BackingField;
        [CompilerGenerated]
        private Collection<ASKProgrammingHistoryItem> <Recset>k__BackingField;
        [NonSerialized]
        private XmlSerializer a;

        public AstroASKProgrammingHistory();
        public AstroASKProgrammingHistory(string xmlData);
        internal string ToXML();

        public int Version { get; set; }

        public Collection<ASKProgrammingHistoryItem> Recset { get; set; }
    }
}

