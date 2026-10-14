namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlType("FieldMap")]
    public class FieldMapInfo
    {
        private string cpsFldName;
        private AccessElementIDType askID;
        private Feature parentFeature;

        public FieldMapInfo();
        public FieldMapInfo(string strFldName, AccessElementIDType id);

        [XmlAttribute]
        public string CPSFieldName { get; set; }

        [XmlAttribute]
        public AccessElementIDType ID { get; set; }

        [XmlIgnore]
        public Feature ParentFeature { get; set; }
    }
}

