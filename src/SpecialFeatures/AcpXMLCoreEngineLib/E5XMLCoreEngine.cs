namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
    using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class E5XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private ControlHeadE5Recset a;
        private E5NavigationControlsTableInnerRecset b;
        private E5InnerRecset c;
        private E5BottomFunctionButtonInnerRecset d;
        private KMButtonInnerRecset e;
        private KeypadMicAndAccessoriesRecset f;
        private DataButtonInnerRecset g;

        public E5XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
        private void e(ref _table A_0);
    }
}

