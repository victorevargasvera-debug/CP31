namespace SpecialFeatures.VoiceAnnouncements
{
    using ACPVoiceAnnouncementLib;
    using SpecialFeatures;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;

    public class ACPVoiceAnnouncementImportUI : PageFunction<string>, IComponentConnector
    {
        private bool a;
        private ACPVoiceAnnouncementInflateDeflate b;
        private Window c;
        private SpecialFeaturesSettings d;
        internal Label lblSelectionTitle;
        internal TextBox txtboxSelectWavFilesPath;
        internal Button btnWavFilesPathBrowse;
        internal Label lblSelectConvertedFilesPath;
        internal TextBox txtboxSelectConvertedFilesPath;
        internal Button btnConvertedFilesPathBrowse;
        internal GroupBox OptionGrpBox;
        internal ListView listAvailableWavFiles;
        internal Button btnWavFilesSelectAll;
        internal Button btnWavFilesUnSelectAll;
        internal Expander vaConversionLogExpander;
        internal DockPanel vaExpanderHeaderPanel;
        internal ProgressBar vaVoiceConvertProgressBar;
        internal ListView vaConvertListView;
        internal Button btnConvert;
        internal Button vaCloseButton;
        internal Button vaImportHelpButton;
        private bool e;

        public ACPVoiceAnnouncementImportUI();
        private string a();
        private void a(ACPVoiceAnnoucementCompleted A_0);
        private void a(ACPVoiceAnnouncementProgress A_0);
        private void a(ACPVoiceAnnouncementPromptRequest A_0);
        private string b();
        private void btnConvert_Click(object A_0, RoutedEventArgs A_1);
        private void btnConvertedFilesPathBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnWavFilesPathBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnWavFilesSelectAll_Click(object A_0, RoutedEventArgs A_1);
        private void btnWavFilesUnSelectAll_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void GridViewColumnHeader_Click(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public override void OnApplyTemplate();
        private void OnLoad(object A_0, RoutedEventArgs A_1);
        private void parent_Closing(object A_0, CancelEventArgs A_1);
        protected override void Start();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void txtboxSelectWavFilesPath_TextChanged(object A_0, TextChangedEventArgs A_1);
        private void vaCloseButton_Click(object A_0, RoutedEventArgs A_1);
        private void vaConversionLogExpander_Collapsed(object A_0, RoutedEventArgs A_1);
        private void vaConversionLogExpander_Expanded(object A_0, RoutedEventArgs A_1);
        private void vaHelpButton_Click(object A_0, RoutedEventArgs A_1);

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

