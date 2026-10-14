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

    public class UclMDCCallHotListPage : AcpPageFeature, IAcpPageFeature, IComponentConnector, IStyleConnector
    {
        private bool a;
        internal AcpParentRecNavToolbar RecNavToolbarUclMDCCallHotList;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkMDCCallHotList;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpMDCCallHotList;
        internal AcpChildRecNavToolbar RecNavToolbarMDCCallHotListHotList;
        internal AcpGroupBox GrpBoxExpanderPseudo0;
        internal Grid StdGrpBoxExpanderColumn;
        internal AcpCustomViewCheckBox CVBtnMDCHotListAlias;
        internal AcpLabel LblHotListAlias;
        internal AcpTextBox TxtBoxHotListAlias;
        internal Grid CompGrpBoxExpanderColumn;
        internal AcpCopyButton CpyBtnHotListAlias;
        internal AcpViewOnlyCtrl TxtBoxHotListAliasComp;
        internal Grid GridFrame;
        internal AcpGroupBox GroupBoxTableView;
        internal AcpXamDataPresenter MDCCallHotListDataPresenter;
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

        public UclMDCCallHotListPage();
        private void a();
        private void a(object A_0);
        private void HLinkMDCCallHotListClick(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

