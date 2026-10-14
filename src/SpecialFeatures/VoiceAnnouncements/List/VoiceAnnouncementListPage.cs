namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpUI;
    using AcpUI.Common;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Markup;

    public class VoiceAnnouncementListPage : AcpPageFeature, IComponentConnector
    {
        private bool a;
        internal AcpParentRecNavToolbar RecNavToolbarPageVoiceAnnouncementList;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkVoiceAnnouncementGeneral;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderVoiceAnnouncementGeneral;
        internal Grid ExpanderVoiceAnnouncementGeneralGrid;
        internal AcpGroupBox GrpBoxExpanderVoiceAnnouncementListGeneralPseudo0;
        internal Grid StdGrpBoxExpanderVoiceAnnouncementGeneralPseudo0;
        internal AcpCustomViewCheckBox CVBtnVoiceFileName_A21220;
        internal AcpLabel LblVoiceFileName_A21220;
        internal AcpTextBoxFileBrowser VoiceFileName_A21220;
        internal Grid CompGrpBoxExpanderVoiceAnnouncementGeneralPseudo0;
        internal AcpCopyButton CpyBtnVoiceFileName_A21220;
        internal AcpViewOnlyCtrl VoiceFileName_A21220Comp;
        private bool b;

        public VoiceAnnouncementListPage();
        private void a(object A_0);
        private List<string> a(SelectionMode A_0);
        private void HLinkVoiceAnnouncementClick(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        private void OnMultiAddClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

