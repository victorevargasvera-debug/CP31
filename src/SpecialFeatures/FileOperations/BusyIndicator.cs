namespace SpecialFeatures.FileOperations
{
    using System;
    using System.Windows;
    using System.Windows.Automation.Peers;
    using System.Windows.Controls;
    using System.Windows.Media.Animation;

    public class BusyIndicator : Control
    {
        public static DependencyProperty BusyStateProperty;
        private Storyboard a;
        private FrameworkElement b;

        static BusyIndicator();
        public BusyIndicator();
        public override void OnApplyTemplate();
        private static void OnBusyStateChanged(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1);
        protected override AutomationPeer OnCreateAutomationPeer();

        public BusyStates BusyState { get; set; }
    }
}

