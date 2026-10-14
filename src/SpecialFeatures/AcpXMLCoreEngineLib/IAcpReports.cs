namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using AcpCommonLib;
    using System;

    public interface IAcpReports
    {
        void GetFeatureSectionName(ref string sectionName, int FeatureID, int SectionID, int index);
        void GetfieldFromPath(ref IAcpField field, int FeatureID, string fieldPath);
        void GetfieldsCollection(ref IAcpFeatureSection featuresection, int FeatureID, int SectionID, int index);
        void GetfieldsCollectionFromName(ref IAcpField field, int FeatureID, int SectionID, int index, string fieldName);
    }
}

