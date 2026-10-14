namespace SpecialFeatures.Security
{
    using AcpASKLib;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class KeyFeature : Feature
    {
        private string keyTypeFieldName;

        public KeyFeature();
        public KeyFeature(string sName, CpsFeatureID cpsFeatId, FeatureCategoryType catType, string keyTypeFld);

        [XmlAttribute]
        public string KeyTypeFieldName { get; set; }
    }
}

