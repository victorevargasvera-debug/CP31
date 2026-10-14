namespace SpecialFeatures.Ucl.HotList
{
    using AcpUI;
    using AcpUI.Common;
    using AcpUILib;
    using Infragistics.Windows.DataPresenter;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Markup;

    public class UclPhoneCallHotListPage : AcpPageFeature, IAcpPageFeature, IComponentConnector, IStyleConnector
    {
        private bool a;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkPhoneCallHotList;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpPhoneCallHotList;
        internal AcpRecNavToolbar RecNavToolbarPhoneCallHotListHotList;
        internal Grid GridFrame;
        internal AcpGroupBox GroupBoxTableView;
        internal AcpXamDataPresenter PhoneCallHotListDataPresenter;
        internal UnboundField ContactAliasTable_Col;
        internal UnboundField CallIdTable_Col;
        internal AcpGroupBox GroupBoxSRecView;
        internal Grid grid;
        internal Grid StdGridGeneralGrp;
        internal AcpComboBox ContactAlias;
        internal AcpCustomViewCheckBox CVBtnContactAlias;
        internal AcpLabel LblContactAlias;
        internal AcpRtdButton RtdBtnContactAlias;
        internal AcpComboBox CallID;
        internal AcpCustomViewCheckBox CVBtnCallID;
        internal AcpLabel LblCallID;
        internal AcpRtdButton RtdBtnCallID;
        internal Grid CompGridGeneralGrp;
        internal AcpCopyButton CopyButtonContactAlias;
        internal AcpViewOnlyCtrl ContactAliasComp;
        internal AcpCopyButton CopyButtonCallID;
        internal AcpViewOnlyCtrl CallIDComp;
        private bool b;

        public UclPhoneCallHotListPage();
        private void a();
        private void HLinkPhoneCallHotListClick(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

