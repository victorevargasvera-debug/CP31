namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
    using AcpUI;
    using AcpUI.Common;
    using AcpUILib;
    using Infragistics.Windows.DataPresenter.Events;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class PageFlashkeyConfiguration : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        public CollectionView myCollectionView;
        private FlashkeyConfigurationRecset a;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkFlashkeyCfgGeneral;
        internal Hyperlink HLinkFlashkeyCfgFeatures;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderFlashkeyCfgGeneral;
        internal AcpGroupBox GrpBoxExpanderFlashkeyCfgGeneralPseudo0;
        internal Grid StdGrpBoxExpanderFlashkeyCfgGeneralPseudo0;
        internal AcpTextBox FkeyConfigFactoryOrderNumberValue;
        internal AcpLabel LblFkeyConfigFactoryOrderNumber;
        internal AcpTextBox FkeyConfigCurrentModelNumberValue;
        internal AcpLabel LblFkeyConfigCurrentModelNumber;
        internal AcpTextBox FkeyConfigNewModelNumberValue;
        internal AcpLabel LblFkeyConfigNewModelNumber;
        internal AcpTextBox FkeyConfigCurrentFlashcodeValue;
        internal AcpLabel LblFkeyConfigCurrentFlashcode;
        internal AcpTextBox FkeyConfigNewFlashcodeValue;
        internal AcpLabel LblFkeyConfigNewFlashcode;
        internal AcpTextBox FkeyConfigUpgradesPurchasedValue;
        internal AcpLabel LblFkeyConfigUpgradesPurchased;
        internal AcpTextBox FkeyConfigUpgradesRemainingValue;
        internal AcpLabel LblFkeyConfigUpgradesRemaining;
        internal AcpExpander ExpanderFlashkeyCfgFeatures;
        internal AcpXamDataPresenter ExpanderFlashkeyCfgFeaturesTable;
        internal Button buttonClose;
        internal Button buttonHelp;
        private bool b;

        public PageFlashkeyConfiguration();
        private void a();
        private void buttonClose_Click(object A_0, RoutedEventArgs A_1);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private void ExpanderFlashkeyCfgFeaturesTable_RecordActivating(object A_0, RecordActivatingEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void HLinkClick(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

