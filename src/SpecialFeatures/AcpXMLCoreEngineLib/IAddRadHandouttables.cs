namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using SpecialFeatures.AcpReportManagerLib;
    using System;

    public interface IAddRadHandouttables
    {
        void AddButtonsAndControl(ref _XMLData RptXMLData);
        void AddButtonsAndControlO2(ref _XMLData RptXMLData, reportType rptType);
        void AddButtonsAndControlO3(ref _XMLData RptXMLData, reportType rptType);
        void AddButtonsAndControlO5(ref _XMLData RptXMLData, reportType rptType);
        void AddButtonsAndControlO7(ref _XMLData RptXMLData, reportType rptType);
        void AddButtonsAndControlO9(ref _XMLData RptXMLData, reportType rptType);
        void AddGeneral(ref _XMLData RptXMLData);
        void AddZonesAndChannels(ref _XMLData RptXMLData);
    }
}

