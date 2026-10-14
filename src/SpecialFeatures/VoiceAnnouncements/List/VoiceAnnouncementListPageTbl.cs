namespace SpecialFeatures.VoiceAnnouncements.List
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

    public class VoiceAnnouncementListPageTbl : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private CollectionView a;
        private bool b;
        internal AcpVoiceAnnRecNavToolBar RecNavToolbarPageVoiceAnnouncementTbl;
        internal AcpXamDataPresenter VoiceAnnouncementListDataPresenter;
        internal UnboundField Voice_FileName_A21220_col;
        private bool c;

        public VoiceAnnouncementListPageTbl();
        private void a(VoiceAnnouncementList A_0);
        private List<string> a(SelectionMode A_0);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        private void OnMultiAddClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        internal void OnVoiceAnnouncementListFlyInClick(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

