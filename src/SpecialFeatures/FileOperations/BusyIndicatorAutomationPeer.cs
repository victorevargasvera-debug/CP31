namespace SpecialFeatures.FileOperations
{
    using System;
    using System.Windows.Automation.Peers;
    using System.Windows.Controls;

    public class BusyIndicatorAutomationPeer : FrameworkElementAutomationPeer
    {
        public BusyIndicatorAutomationPeer(Control owner);
        protected override string GetClassNameCore();
    }
}

