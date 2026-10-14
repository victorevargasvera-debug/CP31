namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
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

    public class PageSiteSelectableAlertList : AcpPageFeature, IComponentConnector, IStyleConnector
    {
        private bool a;
        internal AcpParentRecNavToolbar RecNavToolbarPageSiteSelectableAlertList;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkSiteSelectableAlertListSiteSelectableAlertList41985;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderSiteSelectableAlertListSiteSelectableAlertList41985;
        internal AcpChildRecNavToolbar RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable;
        internal AcpGroupBox GrpBoxExpanderSiteSelectableAlertListSiteSelectableAlertList41985Pseudo1;
        internal AcpCustomViewCheckBox CVBtnSiteSelectableAlertListAlias_A41993;
        internal AcpLabel LblSiteSelectableAlertListAlias_A41993;
        internal AcpTextBox SiteSelectableAlertListAlias_A41993;
        internal AcpCopyButton CpyBtnSiteSelectableAlertListAlias_A41993;
        internal AcpViewOnlyCtrl SiteSelectableAlertListAlias_A41993Comp;
        internal AcpCustomViewCheckBox CVBtnSiteSelectableAlertListConfigurationType_A42058;
        internal AcpLabel LblSiteSelectableAlertListConfigurationType_A42058;
        internal AcpComboBox SiteSelectableAlertListConfigurationType_A42058;
        internal AcpRtdButton RTDBtnSiteSelectableAlertListConfigurationType_A42058;
        internal AcpCopyButton CpyBtnSiteSelectableAlertListConfigurationType_A42058;
        internal AcpViewOnlyCtrl SiteSelectableAlertListConfigurationType_A42058Comp;
        internal Grid ExpanderSiteSelectableAlertListSiteSelectableAlertList41985Grid;
        internal Grid ExpanderSiteSelectableAlertListSiteSelectableAlertTableGrid;
        internal AcpGroupBox ExpanderSiteSelectableAlertListSiteSelectableAlertTableTableView;
        internal AcpXamDataPresenter ExpanderSiteSelectableAlertListSiteSelectableAlertTable;
        internal UnboundField SSAFrontDisplayAlertAlias_A41987_Col;
        internal UnboundField SSAAlertFile_A41990_Col;
        internal UnboundField VASSAAlertPeriodSec_A41991_Col;
        internal UnboundField VASSASubscriberEncodable_A41992_Col;
        internal AcpGroupBox ExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView;
        internal Grid gridExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView;
        internal AcpTextBox SSAFrontDisplayAlertAlias_A41987;
        internal AcpCustomViewCheckBox CVBtnSSAFrontDisplayAlertAlias_A41987;
        internal AcpLabel LblSSAFrontDisplayAlertAlias_A41987;
        internal AcpRtdButton RTDBtnSSAFrontDisplayAlertAlias_A41987;
        internal AcpCopyButton CpyBtnSSAFrontDisplayAlertAlias_A41987;
        internal AcpViewOnlyCtrl SSAFrontDisplayAlertAlias_A41987Comp;
        internal AcpComboBox SSAAlertFile_A41990;
        internal AcpCustomViewCheckBox CVBtnSSAAlertFile_A41990;
        internal AcpLabel LblSSAAlertFile_A41990;
        internal AcpRtdButton RTDBtnSSAAlertFile_A41990;
        internal AcpCopyButton CpyBtnSSAAlertFile_A41990;
        internal AcpViewOnlyCtrl SSAAlertFile_A41990Comp;
        internal AcpTextBoxSpinner VASSAAlertPeriodSec_A41991;
        internal AcpCustomViewCheckBox CVBtnVASSAAlertPeriodSec_A41991;
        internal AcpLabel LblVASSAAlertPeriodSec_A41991;
        internal AcpRtdButton RTDBtnVASSAAlertPeriodSec_A41991;
        internal AcpCopyButton CpyBtnVASSAAlertPeriodSec_A41991;
        internal AcpViewOnlyCtrl VASSAAlertPeriodSec_A41991Comp;
        internal AcpCheckBox VASSASubscriberEncodable_A41992;
        internal AcpCustomViewCheckBox CVBtnVASSASubscriberEncodable_A41992;
        internal AcpLabel LblVASSASubscriberEncodable_A41992;
        internal AcpRtdButton RTDBtnVASSASubscriberEncodable_A41992;
        internal AcpCopyButton CpyBtnVASSASubscriberEncodable_A41992;
        internal AcpCheckBox VASSASubscriberEncodable_A41992Comp;
        private bool b;

        public PageSiteSelectableAlertList();
        private void HLinkSiteSelectableAlertListSiteSelectableAlertList41985Click(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        internal void OnExpanderSiteSelectableAlertListSiteSelectableAlertTableClick(object sender, RoutedEventArgs e);
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnModeClick(object A_0, RoutedEventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IStyleConnector.Connect(int connectionId, object target);
    }
}

