namespace SpecialFeatures.Ucl.HotList
{
    using AcpUI;
    using AcpUILib;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Markup;

    public class UclDTMFCallHotListPage : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        internal AcpRecNavToolbar RecNavToolbarUclDTMFCallHotList;
        internal AcpListBox LstBoxUclContact;
        internal AcpExpander ExpDTMFCallHotList;
        internal AcpTextBox TxtBoxHotListAlias;
        internal AcpLabel LblHotListAlias;
        internal AcpChildRecNavToolbar RecNavToolbarDTMFCallHotListHotList;
        internal AcpXamDataPresenter DTMFCallHotListDataPresenter;
        private bool a;

        public UclDTMFCallHotListPage();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

