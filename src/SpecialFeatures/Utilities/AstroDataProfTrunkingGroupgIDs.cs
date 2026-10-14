namespace SpecialFeatures.Utilities
{
    using System;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable]
    public class AstroDataProfTrunkingGroupgIDs
    {
        [CompilerGenerated]
        private int <Version>k__BackingField;
        [CompilerGenerated]
        private Collection<Astro25DataGroupID> <Recset>k__BackingField;
        [NonSerialized]
        private XmlSerializer a;

        internal AstroDataProfTrunkingGroupgIDs();
        public AstroDataProfTrunkingGroupgIDs(string xmlData);
        internal string ToXML();

        public int Version { get; set; }

        public Collection<Astro25DataGroupID> Recset { get; set; }
    }
}

