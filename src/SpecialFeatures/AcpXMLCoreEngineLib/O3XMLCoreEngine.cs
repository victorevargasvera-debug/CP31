namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class O3XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3 a;
        private O3HHCHButtonInnerRecset b;
        private DataButtonInnerRecset c;
        private ControlHeadO3Recset d;
        private O3NavigationControlsTableInnerRecset e;

        public O3XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
    }
}

