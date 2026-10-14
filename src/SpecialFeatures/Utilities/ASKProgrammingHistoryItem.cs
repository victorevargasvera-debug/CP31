namespace SpecialFeatures.Utilities
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable, XmlType("Node")]
    public class ASKProgrammingHistoryItem
    {
        [CompilerGenerated]
        private long <LastProgramDateTime>k__BackingField;
        [CompilerGenerated]
        private string <SerialNumber>k__BackingField;

        public ASKProgrammingHistoryItem();

        [XmlAttribute]
        public long LastProgramDateTime { get; set; }

        [XmlAttribute]
        public string SerialNumber { get; set; }
    }
}

