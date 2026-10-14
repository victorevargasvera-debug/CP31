namespace SpecialFeatures.VoiceAnnouncements
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;

    public class ACPVoiceAnnouncementUsageMeter : PageFunction<string>, IComponentConnector
    {
        private const int a = 0x7d0;
        private const int b = 0x3e8;
        private Window c;
        internal Grid vaMemoryUsageGrid;
        internal Label vaMinimumLabel;
        internal Label vaMaxLabel;
        internal Label vaUnitsLabel;
        internal Label vaUsageLabel1;
        internal ProgressBar vaMemoryUsageBar1;
        internal Label vaUseageTextLabel1;
        internal Label vaPercentLabel;
        internal Button vaUsageMeterRefreshButton;
        internal Button vaUsageCloseButton;
        internal Button vaUsageHelpButton;
        private bool d;

        public ACPVoiceAnnouncementUsageMeter();
        private void a();
        private void b();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnLoaded(object A_0, RoutedEventArgs A_1);
        private void parent_Closing(object A_0, CancelEventArgs A_1);
        protected override void Start();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void vaUsageCloseButton_Click(object A_0, RoutedEventArgs A_1);
        private void vaUsageHelpButton_Click(object A_0, RoutedEventArgs A_1);
        private void vaUsageMeterRefreshButton_Click(object A_0, RoutedEventArgs A_1);
    }
}

