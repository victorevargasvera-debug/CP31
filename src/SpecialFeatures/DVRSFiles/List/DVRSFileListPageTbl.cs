namespace SpecialFeatures.DVRSFiles.List
{
    using AcpUI;
    using Infragistics.Windows.DataPresenter;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Data;
    using System.Windows.Markup;

    public class DVRSFileListPageTbl : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private CollectionView a;
        private bool b;
        internal AcpVoiceAnnRecNavToolBar RecNavToolbarPageDVRSFileTbl;
        internal AcpXamDataPresenter DVRSFileListDataPresenter;
        internal UnboundField DVRS_FileName_A43736_col;
        private bool c;

        public DVRSFileListPageTbl();
        private void a(DVRSFileList A_0);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        private void OnMultiAddClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        internal void OnVoiceAnnouncementListFlyInClick(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

