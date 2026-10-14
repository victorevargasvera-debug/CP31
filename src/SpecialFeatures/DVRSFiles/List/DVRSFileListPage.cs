namespace SpecialFeatures.DVRSFiles.List
{
    using AcpUI;
    using AcpUI.Common;
    using Infragistics.Windows.DataPresenter;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Markup;

    public class DVRSFileListPage : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private bool a;
        internal AcpParentRecNavToolbar RecNavToolbarPageDVRSFileList;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkLabtool;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderDVRSFileLabtool;
        internal AcpVoiceAnnRecNavToolBar RecNavToolbarExpanderDVRSFileListEmbeddedList;
        internal AcpGroupBox GrpBoxExpanderDVRSFileListLabtoolPseudo0;
        internal AcpLabel LblDVRSConfigDVRSFileName_A43736;
        internal AcpTextBox DVRSConfigDVRSFileName_A43736;
        internal Grid ExpanderDVRSFileListLabtoolGrid;
        internal Grid ExpanderDVRSFileListEmbeddedListGrid;
        internal AcpGroupBox GroupBoxExpanderDVRSFileListTableView;
        internal AcpXamDataPresenter ExpanderDVRSFileListEmbeddedList;
        internal UnboundField DVRSConfigDVRSFileData_A43734_Col;
        internal AcpGroupBox GroupBoxExpanderDVRSFileListSRecView;
        internal Grid gridExpanderDVRSFileListSRecView;
        internal Grid StdGridExpanderDVRSFileListSRecView;
        internal AcpTextBox DVRSConfigDVRSFileData_A43734;
        internal AcpLabel LblDVRSConfigDVRSFileData_A43734;
        private bool b;

        public DVRSFileListPage();
        private void a(object A_0);
        private void HLinkClick(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        private void OnMultiAddClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

