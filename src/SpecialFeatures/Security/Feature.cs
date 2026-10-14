namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    [Serializable]
    public class Feature
    {
        private string name;
        private FeatureCategoryType type;
        private CpsFeatureID cpsFeatureID;
        private Collection<FieldMapInfo> fldMaps;

        public Feature();
        public Feature(string sName, CpsFeatureID cpsFeatId, FeatureCategoryType catType);

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public CpsFeatureID FeatureID { get; set; }

        [XmlAttribute]
        public FeatureCategoryType Type { get; set; }

        [XmlElement(typeof(RefKeyFieldMapInfo)), XmlElement, XmlElement(typeof(KeyFieldMapInfo))]
        public Collection<FieldMapInfo> FieldMap { get; }
    }
}

