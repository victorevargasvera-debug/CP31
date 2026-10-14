namespace SpecialFeatures.SystemCertificates.List
{
    using AcpUI;
    using Infragistics.Windows.DataPresenter;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Markup;

    public class SystemCertificateListPageTbl : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private CollectionView a;
        private bool b;
        internal AcpVoiceAnnRecNavToolBar RecNavToolbarPageSystemCertificateTbl;
        internal AcpXamDataPresenter SystemCertificateListDataPresenter;
        internal UnboundField System_Certificate_Name_col;
        internal UnboundField System_Certificate_FileName_A43634_col;
        private bool c;

        public SystemCertificateListPageTbl();
        private void a(SystemCertificateList A_0);
        private List<string> a(SelectionMode A_0);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        private void OnMultiAddClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        internal void OnVoiceAnnouncementListFlyInClick(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

