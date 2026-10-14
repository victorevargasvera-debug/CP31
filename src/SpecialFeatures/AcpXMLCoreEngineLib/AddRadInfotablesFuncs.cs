namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using System;

    public class AddRadInfotablesFuncs : IAddRadInfotables
    {
        public AddRadInfotablesFuncs();
        public void AddFeatures(ref _XMLData RptXMLData);
        public void AddFlashPort(ref _XMLData RptXMLData);
        public void AddGeneral(ref _XMLData RptXMLData);
        public void AddTracking(ref _XMLData RptXMLData);
        public void AddVersion(ref _XMLData RptXMLData);
    }
}

