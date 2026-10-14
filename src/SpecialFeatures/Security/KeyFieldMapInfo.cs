namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlType("KeyFieldMap")]
    public class KeyFieldMapInfo : FieldMapInfo
    {
        private KeyType keyType;

        public KeyFieldMapInfo();
        public KeyFieldMapInfo(string strFldName, AccessElementIDType id, KeyType uKeyType);

        [XmlAttribute]
        public KeyType Type { get; set; }
    }
}

