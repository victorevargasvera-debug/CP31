namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
    using Motorola.MackinawCPS.CoreFeatures.Keypad;
    using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class O2XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 a;
        private Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories b;
        private O2InnerRecset c;
        private KMButtonInnerRecset d;
        private DataButtonInnerRecset e;
        private ControlHeadO2Recset f;
        private O2NavigationControlsTableInnerRecset g;
        private KeypadMicAndAccessoriesRecset h;
        private KeypadRecset i;
        private KeypadButtonInnerRecset j;

        public O2XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
        private void e(ref _table A_0);
    }
}

