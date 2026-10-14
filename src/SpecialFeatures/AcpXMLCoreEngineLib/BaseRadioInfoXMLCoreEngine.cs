namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class BaseRadioInfoXMLCoreEngine : AcpBaseXMLCoreEngine
    {
        public BaseRadioInfoXMLCoreEngine();
        protected virtual void AddFeatures(ref _XMLData RptXMLData);
        protected void AddFeatureSet(ref _XMLData RptXMLData);
        protected virtual void AddFlashPort(ref _XMLData RptXMLData);
        protected virtual void AddGeneral(ref _XMLData RptXMLData);
        protected virtual void AddTracking(ref _XMLData RptXMLData);
        protected virtual void AddVersion(ref _XMLData RptXMLData);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
    }
}

