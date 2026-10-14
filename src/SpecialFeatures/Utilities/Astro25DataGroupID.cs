namespace SpecialFeatures.Utilities
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable, XmlType("Node")]
    public class Astro25DataGroupID
    {
        [CompilerGenerated]
        private int <DataGroupID>k__BackingField;

        public Astro25DataGroupID();

        [XmlAttribute]
        public int DataGroupID { get; set; }
    }
}

