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

    public class UclQCIICallHotListPage : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        internal AcpRecNavToolbar RecNavToolbarUclQCIICallHotList;
        internal AcpListBox LstBoxUclContact;
        internal AcpExpander ExpQCIICallHotList;
        internal AcpTextBox TxtBoxHotListAlias;
        internal AcpLabel LblHotListAlias;
        internal AcpChildRecNavToolbar RecNavToolbarQCIICallHotListHotList;
        internal AcpXamDataPresenter QCIICallHotListDataPresenter;
        private bool a;

        public UclQCIICallHotListPage();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

