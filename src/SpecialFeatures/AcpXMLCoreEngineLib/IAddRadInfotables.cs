namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using System;

    public interface IAddRadInfotables
    {
        void AddFeatures(ref _XMLData RptXMLData);
        void AddFlashPort(ref _XMLData RptXMLData);
        void AddGeneral(ref _XMLData RptXMLData);
        void AddTracking(ref _XMLData RptXMLData);
        void AddVersion(ref _XMLData RptXMLData);
    }
}

