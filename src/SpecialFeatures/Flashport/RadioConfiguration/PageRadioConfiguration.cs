namespace SpecialFeatures.Flashport.RadioConfiguration
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

    public class PageRadioConfiguration : AcpPageFeature, IAcpPageFeature, IComponentConnector
    {
        public CollectionView myCollectionView;
        private RadioConfigurationRecset a;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkRadioCfgGeneral;
        internal Hyperlink HLinkRadioCfgFeatures;
        internal StackPanel MyStackPanel;
        internal AcpExpander ExpanderRadioCfgGeneral;
        internal AcpGroupBox GrpBoxExpanderRadioCfgGeneralPseudo0;
        internal Grid StdGrpBoxExpanderRadioCfgGeneralPseudo0;
        internal AcpTextBox RadioConfigCurrentModelNumberValue;
        internal AcpLabel LblRadioConfigCurrentModelNumber;
        internal AcpTextBox RadioConfigCurrentFlashcodeValue;
        internal AcpLabel LblRadioConfigCurrentFlashcode;
        internal AcpExpander ExpanderRadioCfgFeatures;
        internal AcpXamDataPresenter ExpanderRadioCfgFeaturesTable;
        internal Button buttonClose;
        internal Button buttonHelp;
        private bool b;

        public PageRadioConfiguration();
        private void a();
        private void buttonClose_Click(object A_0, RoutedEventArgs A_1);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private void ExpanderRadioCfgFeaturesTable_RecordActivating(object A_0, RecordActivatingEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void HLinkClick(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnFieldNameDoubleClick(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

