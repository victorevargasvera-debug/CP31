namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlType("RefKeyFieldMap")]
    public class RefKeyFieldMapInfo : FieldMapInfo
    {
        private string refFeatureName;

        public RefKeyFieldMapInfo();
        public RefKeyFieldMapInfo(string strFldName, AccessElementIDType id, string refFeatName);

        [XmlAttribute]
        public string ReferencedFeatureName { get; set; }
    }
}

