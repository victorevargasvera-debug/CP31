namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class O9XMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private ResponseSelectorListInnerRecset a;
        private DirectionalButtonsListInnerRecset b;
        private O9InnerRecset c;
        private O9DataButtonInnerRecset d;
        private O9NavigationControlsTableInnerRecset e;
        private BottomFunctionProgrammableButtonInnerRecset f;
        private PASirenButtonsListInnerRecset g;

        public O9XMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
        private void e(ref _table A_0);
        private void f(ref _table A_0);
        private void g(ref _table A_0);
        protected override void KeypadButtonSequenceRTL(bool? condition1, bool? condition2, string value1, string value2, ref _UIFields rptField);
    }
}

