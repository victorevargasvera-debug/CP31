namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
    using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class O5XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5 a;
        private Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;
        private O5InnerRecset c;
        private KMButtonInnerRecset d;
        private DataButtonInnerRecset e;
        private ControlHeadO5Recset f;
        private O5NavigationControlsTableInnerRecset g;
        private KeypadMicAndAccessoriesRecset h;

        public O5XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
    }
}

