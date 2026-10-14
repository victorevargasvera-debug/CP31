namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
    using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class O7XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7 a;
        private Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;
        private O7InnerRecset c;
        private KMButtonInnerRecset d;
        private O7DataButtonInnerRecset e;
        private ControlHeadO7Recset f;
        private O7NavigationControlsTableInnerRecset g;
        private KeypadMicAndAccessoriesRecset h;

        public O7XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
        private void e(ref _table A_0);
    }
}

