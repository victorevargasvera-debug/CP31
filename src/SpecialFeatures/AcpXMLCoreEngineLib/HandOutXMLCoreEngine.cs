namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using Motorola.MackinawCPS.CoreFeatures.Buttons;
    using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
    using Motorola.MackinawCPS.CoreFeatures.Switches;
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;

    public class HandOutXMLCoreEngine : BaseHandOutXMLCoreEngine
    {
        private Motorola.MackinawCPS.CoreFeatures.Switches.Switches a;
        private RotaryControlInnerRecset b;
        private RotaryControlInnerSection c;
        private MFKAssignmentControlInnerRecset d;
        private MFKAssignmentControlInnerSection e;
        private MFKAssignmentControlInnerSection f;
        private ButtonsRecset g;
        private PortableButtonInnerRecset h;
        private DataButtonInnerRecset i;
        private PortableSideUpDownArrowButtonInnerRecset j;
        private SmartKeyFobRecset k;
        private SmartKeyFobButtonTableInnerRecset l;

        public HandOutXMLCoreEngine();
        private void a(ref _table A_0);
        private void b(ref _table A_0);
        public override void BuildDataTables(ref _XMLData XMLRptDataObj);
        private void c(ref _table A_0);
        private void d(ref _table A_0);
        private void e(ref _table A_0);
        private void f(ref _table A_0);
        private void g(ref _table A_0);
        private void h(ref _table A_0);
        private void i(ref _table A_0);
        private void j(ref _table A_0);
    }
}

