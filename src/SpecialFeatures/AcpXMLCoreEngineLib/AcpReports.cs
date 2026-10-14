namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using AcpCommonLib;
    using System;

    public class AcpReports : IAcpReports
    {
        public AcpReports();
        public void GetFeatureSectionName(ref string sectionName, int FeatureID, int SectionID, int index);
        public void GetfieldFromPath(ref IAcpField field, int FeatureID, string fieldPath);
        public void GetfieldsCollection(ref IAcpFeatureSection featureSection, int FeatureID, int SectionID, int index);
        public void GetfieldsCollectionFromName(ref IAcpField field, int FeatureID, int SectionID, int index, string fieldName);
    }
}

