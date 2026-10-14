namespace SpecialFeatures.VoiceAnnouncements
{
    using ACPVoiceAnnouncementLib;
    using SpecialFeatures;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;

    public class VoiceAnnouncementUtilities : PageFunction<string>, IComponentConnector
    {
        private ACPVoiceAnnouncementInflateDeflate a;
        private List<ACPMotVoiceAnnouncementInfo> b;
        private Window c;
        private bool d;
        private SelectionMode e;
        private SpecialFeaturesSettings f;
        internal GroupBox OptionGrpBox;
        internal Label lblSelectionTitle;
        internal ListView voiceAnnDownloadList;
        internal Button btnDownloadSelectAll;
        internal Button btnDownloadUnSelectAll;
        internal Label lblSelectdownloadPath;
        internal TextBox txtboxdownloadPath;
        internal Button btnBrowse;
        internal Expander vaDownloadLogExpander;
        internal DockPanel vaExpanderHeaderPanel;
        internal ProgressBar vaDownloadProgressBar;
        internal ListView vaDownloadListView;
        internal Button btndownload;
        internal Button btndownloadCancel;
        internal Button btndownloadHelp;
        private bool g;

        public VoiceAnnouncementUtilities();
        private string a();
        private void a(ACPVoiceAnnoucementCompleted A_0);
        private void a(ACPVoiceAnnouncementProgress A_0);
        private void a(ACPVoiceAnnouncementPromptRequest A_0);
        private void btnBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btndownload_Click(object A_0, RoutedEventArgs A_1);
        private void btndownloadCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btndownloadHelp_Click(object A_0, RoutedEventArgs A_1);
        private void btnDownloadSelectAll_Click(object A_0, RoutedEventArgs A_1);
        private void btnDownloadUnSelectAll_Click(object A_0, RoutedEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        internal List<string> GetListOfVoiceAnn();
        private void GridViewColumnHeader_Click(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public override void OnApplyTemplate();
        private void OnLoaded(object A_0, RoutedEventArgs A_1);
        private void parent_Closing(object A_0, CancelEventArgs A_1);
        protected override void Start();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        private void vaDownloadLogExpander_Collapsed(object A_0, RoutedEventArgs A_1);
        private void vaDownloadLogExpander_Expanded(object A_0, RoutedEventArgs A_1);

        private class ConvertResult
        {
            private string a;
            private ACPInflateDeflateCodes b;

            internal ConvertResult(string fileName, ACPInflateDeflateCodes code);

            public string FileName { get; }

            public string ShortFileName { get; }

            public string Status { get; }
        }
    }
}

