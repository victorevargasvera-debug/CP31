namespace SpecialFeatures.AcpXMLCoreEngineLib
{
    using SpecialFeatures.AcpReportManagerLib;
    using System;
    using System.Collections.Generic;

    public class AddRadHandoutTablesFuncs : IAddRadHandouttables
    {
        private string a;

        public AddRadHandoutTablesFuncs();
        private void a(ref _UIFields A_0, string A_1);
        private void a(ref Dictionary<int, string> A_0, short A_1);
        private int a(Dictionary<int, string> A_0, Dictionary<int, string> A_1, Dictionary<int, string> A_2);
        private int a(Dictionary<int, string> A_0, Dictionary<int, string> A_1, Dictionary<int, string> A_2, Dictionary<int, string> A_3, Dictionary<int, string> A_4, Dictionary<int, string> A_5);
        public void AddButtonsAndControl(ref _XMLData RptXMLData);
        public void AddButtonsAndControlO2(ref _XMLData RptXMLData, reportType rptType);
        public void AddButtonsAndControlO3(ref _XMLData RptXMLData, reportType rptType);
        public void AddButtonsAndControlO5(ref _XMLData RptXMLData, reportType rptType);
        public void AddButtonsAndControlO7(ref _XMLData RptXMLData, reportType rptType);
        public void AddButtonsAndControlO9(ref _XMLData RptXMLData, reportType rptType);
        public void AddGeneral(ref _XMLData RptXMLData);
        public void AddZonesAndChannels(ref _XMLData RptXMLData);
    }
}

